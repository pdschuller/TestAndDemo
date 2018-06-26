using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UseStubbedData.Data;
using UseStubbedData.StubData;

namespace UseStubbedData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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
                employeeGrid.ItemsSource = new ObservableCollection<StubEmployee>(DeSerializableStubData());
            }
            else
            {
                    employeeGrid.ItemsSource = 
                        new ObservableCollection<StubEmployee>(GetEmployees());
            }
        }
        private void StoreData(object sender, RoutedEventArgs e)
        {
                SerializableObject<List<StubEmployee>>(GetEmployees());          

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


        private void SerializableObject<T>(T obj) where T : class
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var stubFilePath =  System.IO.Path.Combine(path, "StubData.db");   
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

        private List<StubEmployee> DeSerializableStubData()
        {
            List<StubEmployee> res;
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var stubFilePath = System.IO.Path.Combine(path, "StubData.db");
            if (File.Exists(stubFilePath))
            {
                using (FileStream fileStream = new FileStream(stubFilePath, FileMode.Open))
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
