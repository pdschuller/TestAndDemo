using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;
using UseStubbedData.StubData;

namespace UseStubbedData
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetData(object sender, RoutedEventArgs e)
        {
            if(chkUseStubData.IsChecked.HasValue &&  chkUseStubData.IsChecked.Value)
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                var PathToTheData = System.IO.Path.Combine(path, "StubData.db");
                employeeGrid.ItemsSource = new ObservableCollection<StubEmployee>(GetDataFromHdd_DeserializeIt_AndReturnIt(PathToTheData));
            }
            else
            {
                    employeeGrid.ItemsSource = 
                        new ObservableCollection<StubEmployee>(GetEmployees());
            }
        }
        private void StoreData(object sender, RoutedEventArgs e)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var stubFilePath = System.IO.Path.Combine(path, "StubData.db");

            List<StubEmployee> emps = GetEmployees();
            SerializeThisParam_ToThisTee_AndWriteToHdd<List<StubEmployee>>(emps, stubFilePath);          
        }

        private List<StubEmployee> GetEmployees()
        {
            List<StubEmployee> employees = new List<StubEmployee>();
            var connString = ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var query = "select * from employee";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                conn.Open();
                sda.Fill(dt);                
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        employees.Add(new StubEmployee()
                        {
                            Active = row["Active"] == DBNull.Value ? (bool?)null : Convert.ToBoolean(row["Active"]),
                            Email = row["Email"] == DBNull.Value ? null : row["Email"].ToString().Trim(),
                            EmployeeID = Convert.ToDecimal(row["EmployeeID"]),
                            FirstName = row["FirstName"] == DBNull.Value ? null : row["FirstName"].ToString().Trim(),
                            LastName = row["LastName"] == DBNull.Value ? null : row["LastName"].ToString().Trim(),
                            HireDate = row["HireDate"] == DBNull.Value ? (DateTime?)null : (DateTime?)row["HireDate"],
                            LisActive = (bool?)row["LisActive"] ?? null,
                            MiddleName = row["MiddleName"] == DBNull.Value ? null : row["MiddleName"].ToString(),
                            Ref1 = row["Ref1"] == DBNull.Value ? null : row["Ref1"].ToString().Trim(),
                            Ref2 = row["Ref2"] == DBNull.Value ? null : row["Ref2"].ToString().Trim(),
                            Ref3 = row["Ref3"] == DBNull.Value ? null : row["Ref3"].ToString().Trim(),
                            SuffixName = row["SuffixName"] == DBNull.Value ? null : row["SuffixName"].ToString().Trim(),
                            SurName = row["SurName"] == DBNull.Value ? null : row["SurName"].ToString().Trim()
                        });
                    }
                }

               
            }
            return employees;
        }


        private void SerializeThisParam_ToThisTee_AndWriteToHdd<T>(T obj, string stubFilePath) where T : class
        {
            using (MemoryStream stream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
                using (FileStream fileStream = new FileStream(stubFilePath, FileMode.OpenOrCreate))
                {
                    using (var zipStream = new GZipStream(fileStream, CompressionMode.Compress))
                    {
                        stream.Position = 0;
                        stream.CopyTo(zipStream);
                        stream.Flush();
                    }
                }
            }
        }

        private List<StubEmployee> GetDataFromHdd_DeserializeIt_AndReturnIt(string PathToTheData)
        {
            if (File.Exists(PathToTheData))
            {
                List<StubEmployee> res;
                using (FileStream fileStream = new FileStream(PathToTheData, FileMode.Open))
                {
                    using (GZipStream zipStream = new GZipStream(fileStream, CompressionMode.Decompress))
                    {
                        using (MemoryStream outStream = new MemoryStream())
                        {
                            zipStream.CopyTo(outStream);
                            IFormatter formatter = new BinaryFormatter();
                            outStream.Position = 0;
                            res = formatter.Deserialize(outStream) as List<StubEmployee>;

                        }
                    }
                }
                return res;
            }
            else return new List<StubEmployee>();
        }
    }
}
