using Microsoft.Extensions.Logging;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using tlModels.dbmsModels;


namespace tlModels
{

    public static class tlConstants
    {
        // phil_hp
        public static string DbmsConnStr = "data source = DESKTOP-6ILQE1V; initial catalog=wjbeitler_dbms;integrated security=SSPI; Connect Timeout = 0";
        // public static string DbmsConnStr = "data source = DESKTOP-6ILQE1V; initial catalog=wjbeitler_clv;integrated security=SSPI; Connect Timeout = 0";
        public static string WmsConnStr = "data source = DESKTOP-6ILQE1V; initial catalog=WMS;integrated security=SSPI; Connect Timeout = 90";
        // public static string WmsConnStr = "";
        // MIS15

        // public static string DbmsConnStr = "data source = MIS15; initial catalog=dbms;integrated security=SSPI; Connect Timeout = 0";
        // public static string WmsConnStr = "data source = MIS15; initial catalog=wms;integrated security=SSPI; Connect Timeout = 0";

        // public static string DbmsConnStr = "data source = MIS11\\MIS11_SQLEXPRESS; initial catalog=wjbeitler;User Id=pds1;Password=qweQWE101622!;Connect Timeout = 60";
        // public static string WmsConnStr = "data source = MIS11\\MIS11_SQLEXPRESS; initial catalog=wms;User Id=pds1;Password=qweQWE101622!;Connect Timeout = 60";

        // PITTSBURGH PROD
        // public static string DbmsConnStr = "data source=DBMS;initial catalog=wjbeitler;User Id=TruckLoader;Password=Sailboat; Connect Timeout = 60";
        // public static string WmsConnStr = "data source=wjb-wms;initial catalog=WMS;User Id=TruckLoader;Password=Sailboat; Connect Timeout = 60";
        // CLV DB ONLY - for CLV deployment  no wms
        // public static string DbmsConnStr = "data source=CLV-Server1\\SQL2019;initial catalog=wjbeitler;User Id=TruckLoader;Password=e2WCnM7sJMuEGqDPaA5KD; Connect Timeout = 60";
        // public static string WmsConnStr = "";
    }
    public class WmsOrderForUi
    {
        public int OrderId { get; set; }
        public int ExpectedCases { get; set; }
        public int ShipperId { get; set; }
        public string ShipperCompanyCode { get; set; }
        public string ShipperOrderNumber { get; set; }
    }
    // this is meant to have the properties that the Wms stored proc returns
    public class WmsServerPallet
    {
        public Guid OrderBatchId { get; set; }
        public string WmsCode { get; set; }
        public string LicensePlate { get; set; }
        public int PalletSequence { get; set; }
        public int PostScanQtySum { get; set; }
        public string MobileUserInitials { get; set; }
        public Guid ScannedPalletIdGuid { get; set; }
        public bool Loaded { get; set; }
        public bool IsBeingLoaded { get; set; }
        public string RsName { get; set; } // the proc returns this as Name
    }
    public class ScannedPalletForUi : INotifyPropertyChanged
    {
        public ScannedPalletForUi() { }
        public ScannedPalletForUi(string barcodeScan, decimal consigneeCompanyLocationId,
                string storeNumber, string wmsCode, DateTime dispatchDate, decimal shipperCompanyLocationId,
                int wlocId )
        {
            BarcodeScan = barcodeScan;
            ConsigneeCompanyLocationId = consigneeCompanyLocationId;
            StoreNumber = storeNumber;
            Wmscode = wmsCode;
            DispatchDate = dispatchDate;
            ShipperCompanyLocationId = Convert.ToInt32(shipperCompanyLocationId);
            WarehouseLocationId = wlocId;
        }
        public ScannedPalletForUi(int wlocId, string wlocRunNameProxy)
        {
            WarehouseLocationId = wlocId;
            WarehouseRunNameProxy = wlocRunNameProxy;
        }
        [PrimaryKey]
        public Guid ScannedPalletLoadGuid { get; set; }
        private DateTime _DispatchDate { get; set; }
        public DateTime DispatchDate
        {
            get { return _DispatchDate; }
            set
            {
                _DispatchDate = value;
                ThisPropertyHasChanged();
            }
        }
        private string _ProcessName { get; set; }
        /// <summary>
        /// This can be the string value of the PHistory enum ProcessName
        /// </summary>
        public string ProcessName { 
            get { return _ProcessName; }
            set
            {
                _ProcessName = value;
            } 
        }
        private string _DatePickerDate { get; set; }
        public string DatePickerDate
        {
            get { return _DatePickerDate; }
            set { _DatePickerDate = value; }
        }
        private string _BarcodeScan { get; set; }
        public string BarcodeScan
        {
            get
            { return _BarcodeScan; }
            set
            {
                _BarcodeScan = value;
                ThisPropertyHasChanged();
            }
        }
        private string _BarcodeWithElipsis { get; set; }
        public string BarcodeWithElipsis
        {
            get
            {
                try
                {
                    if (BarcodeScan == null)
                    {
                        _BarcodeWithElipsis = "";
                        return _BarcodeWithElipsis;
                    }
                    int len = BarcodeScan.Length;
                    if (len <= 9)
                    {
                        _BarcodeWithElipsis = BarcodeScan;
                        return _BarcodeWithElipsis;
                    }
                    string FirstPart = BarcodeScan.Substring(0, 4);
                    // you know you have at lease 10 characters
                    string LastPart = BarcodeScan.Substring(len - 6, 6);
                    _BarcodeWithElipsis = FirstPart + "..." + LastPart;
                    return _BarcodeWithElipsis;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            set
            {
                _BarcodeWithElipsis = value;
            }
        }
        private string _WmsCode { get; set; }
        public string Wmscode
        {
            get { return _WmsCode; }
            set
            {
                _WmsCode = value;
                ThisPropertyHasChanged();
            }
        }
        private int _WarehouseLocationId { get; set; } = 0;
        public int WarehouseLocationId
        {
            get { return _WarehouseLocationId; }
            set
            {
                _WarehouseLocationId = value;
                ThisPropertyHasChanged();
            }
        }
        private int _ShipperCompanyLocationId { get; set; }
        public int ShipperCompanyLocationId
        {
            get { return _ShipperCompanyLocationId; }
            set { _ShipperCompanyLocationId = value; ThisPropertyHasChanged(); }
        }
        public string StoreNumber { get; set; }
        private decimal? _ConsigneeCompanyLocationId { get; set; }
        public decimal? ConsigneeCompanyLocationId
        {
            get { return _ConsigneeCompanyLocationId; }
            set { _ConsigneeCompanyLocationId = value; ThisPropertyHasChanged(); }
        }
        public int RsClid { get; set; }
        private int _RunStopId { get; set; }
        public int RunStopId
        {
            get { return _RunStopId; }
            set { _RunStopId = value; ThisPropertyHasChanged(); }
        }
        public string RunNo { get; set; }
        public string RunName { get; set; }
        public DateTime? StagedDatetime { get; set; }
        public bool SavedToServer { get; set; }
        public string WarehouseRunNameProxy { get; set; }
        // public string SuggestedWarehouseLocation { get; set; } = "---";
        public bool IsBeingEdited { get; set; } = false;
        public bool IsWorkInProgress { get; set; } = false;
        public bool Loaded { get; set; } = false;
        public decimal StopSequence { get; set; }
        public bool IsBeingLoaded { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsFlyingToTheDatabases { get; set; } = false; // PropertyChanged event does not fire when this is true
        public DateTime ModifiedDateTime { get; set; }
        public int MobileUserId { get; set; }
        public string ConsigneeCompanyName { get; set; }
        public bool IsDbms { get; set; }  // this is false if pallet came from WMS
        private List<string> _ShipperCompanyCodesOnPallet { get; set; }
        [Ignore]
        public List<string> ShipperCompanyCodesOnPallet
        {
            get { return _ShipperCompanyCodesOnPallet; }
            set
            {
                _ShipperCompanyCodesOnPallet = value;
                ThisPropertyHasChanged();
            }
        } // where the order came from. 
          // used when putting wms pallets in a RS
        [Ignore]
        public List<string> ShippersNumbersOnPallet { get; set; }
        private string _ShipperCodesCommaDlimList { get; set; }
        public string ShipperCodesCommaDlimList
        {
            get
            {
                string TheList = "";
                if (ShipperCompanyCodesOnPallet == null) return TheList;

                foreach (string c in ShipperCompanyCodesOnPallet)
                {
                    if (!TheList.Contains(c))
                    {
                        TheList += c + ",";
                    }
                }
                int StartingAtThisPosition = TheList.Length - 1;
                TheList = TheList.Remove(StartingAtThisPosition);
                // TheList.Substring(0, l);
                _ShipperCodesCommaDlimList = TheList;
                return _ShipperCodesCommaDlimList;
            }
            set
            {
                _ShipperCodesCommaDlimList = value;
            }
        }
        private bool _IsReadyForDb { get; set; } = true;
        [Ignore]
        public bool IsReadyForDb
        {
            get { return _IsReadyForDb; }
            set { _IsReadyForDb = value; }
        }

        [Ignore]
        public Guid wmsOrderBatchId { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        // NOTE:  I changed the name of this for semantic readability
        //protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        protected virtual void ThisPropertyHasChanged([CallerMemberName] string propertyName = null)
        {
            if (IsFlyingToTheDatabases == false)
            {   // handled by HomeScreen . ActivePalletBeingStaged_PropertyChanged
                //         AND PalletBcChanged in PalletsOnLoadScreenAdapter 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public bool PalletExists { get; set; }
        private int _PalletRunstopId { get; set; } = 0;
        public int PalletRunstopId
        {
            get { return _PalletRunstopId; }
            set { _PalletRunstopId = value; }
        }
        private bool _ConsigneeNotNeeded { get; set; } = false;
        public bool ConsigneeNotNeeded
        {
            get { return _ConsigneeNotNeeded; }
            set { _ConsigneeNotNeeded = value; }
        }
        private int? _PalletColorId { get; set; }
        public int? PalletColorId
        {
            get { return _PalletColorId; }
            set { _PalletColorId = value; }
        }
        private DateTime _DispatchDateStaging { get; set; }
        public DateTime DispatchDateStaging
        {
            get { return _DispatchDateStaging; }
            set { _DispatchDateStaging = value; }
        }
        private DateTime? _DispatchDateOutboundFile { get; set; }
        public DateTime? DispatchDateOutboundFile
        {
            get { return _DispatchDateOutboundFile; }
            set { _DispatchDateOutboundFile = value; }
        }
        private bool _WasStagedWithXDock { get; set; }
        public bool WasStagedWithXDock
        {
            get { return _WasStagedWithXDock; }
            set { _WasStagedWithXDock = value; }
        }
        private int? _StagerMobileUserId { get; set; }
        public int? StagerMobileUserId
        {
            get { return _StagerMobileUserId;  }
            set { _StagerMobileUserId = value;  }
        }
        private int _LoaderMobileUserId { get; set; }
        public int LoaderMobileUserId
        {
            get { return _LoaderMobileUserId;  }
            set { _LoaderMobileUserId = value;  }
        }
        private DateTime? _LoadedDatetime { get; set; }
        public DateTime? LoadedDatetime
        {
            get { return _LoadedDatetime; }
            set { _LoadedDatetime = value;  }
        }
        private DateTime? _ImportedFromPcsDatetime { get; set; }
        public DateTime? ImportedFromPcsDatetime
        {
            get { return _ImportedFromPcsDatetime; }
            set { _ImportedFromPcsDatetime = value; }
        }
        private int? _CartonCount { get; set; }
        public int? CartonCount
        {
            get
            {
                return _CartonCount;
            }
            set
            {
                _CartonCount = value;
            }
        }
    }
    public class RunNameAndRunStopObj
    {
        public string TheRunName { get; set; }
        public decimal TheRunId { get; set; }
        public string TheRunStop { get; set; }
        public decimal TheRunStopId { get; set; }
        public int TheStopSequence { get; set; }
        public bool IsSelected { get; set; } = false;
        public int PalletRsId { get; set; }
    }
    public class LoggedBarcodeParamsForUpdate
    {
        public int theId { get; set; }
        public bool? wasUseful { get; set; }
        public int wmsBarcodeTypeId { get; set; }
        public string palletBc { get; set; }
    }
    // this is a data transfer object that displays on the Load Screen
    public class DestinationStore
    {
        public string Wmscode { get; set; }
        public string StoreName { get; set; }
        public string TrailerName { get; set; }
        public int TrailerId { get; set; }
        public string TrailerBarcode { get; set; }
        public bool IsTopSequenceStop { get; set; } // the HIGHEST sequence number w un-loaded pallets
        public List<ScannedPalletForUi> PalletsForThisStore { get; set; } = new List<ScannedPalletForUi>();
        public decimal StopSequence { get; set; }
        public int RunstopId { get; set; }
        public int RsClid { get; set; }
    }
    // MyCustomRetailer is used in the Retailers dd
    public class MyCustomRetailer
    {
        public string WMSCode { get; set; }
        public string TheCompanyName { get; set; }
        public decimal ShipperCompanyLocationId { get; set; }
        public string ConsigneeWMSCodePrefix { get; set; }
        public override string ToString()
        {
            return ConsigneeWMSCodePrefix;
        }
    }
    public class CustomRun
    {
        [NotNull]
        public decimal RunId { get; set; }
        [NotNull]
        public string RunName { get; set; }
        [NotNull]
        public string RunNo { get; set; }
        public int RunSequence { get; set; }
        public DateTime ProformaDate { get; set; }
        public List<CustomRunStop> CustomRunStops { get; set; }
        public string Trailer_Name { get; set; }
        public string TrailerBarcode { get; set; }
        public bool HasOrders { get; set; } = false;
    }
    public class CustomRunStop
    {
        [NotNull]
        public int RunStopId { get; set; }
        public decimal RunId { get; set; }
        public int rsCompanyLocationId { get; set; }
        public int RsClid { get; set; }
        public string WmsCode { get; set; }
        public decimal StopSequence { get; set; }
        public string RunStopName { get; set; }
        public DateTime PlannedDepartDate { get; set; }
        public string Store { get; set; }
        public List<ScannedPalletLoad> ServerPallets { get; set; }
        public List<ScannedPalletForUi> PalletsForUi { get; set; }
        public List<RSsOrderProperties> OrdersProperties { get; set; } // An item for each Order in the RS
                                                                       // each item has a Order ShippersCompanyCode and an Order ShippersNumber
                                                                       // used when putting wms pallets in a RS
        public bool HasOrders { get; set; } = false;
    }
    public class RSsOrderProperties
    {
        // 4-20-22, added ShipperCLid and match on this when the P can fit in 2 RSs
        public decimal ShipperCLid { get; set;}
        public string ShippersCompanyCode { get; set; }
        public string ShippersNumber { get; set; }
    }

    public class CustomConsignee
    {
        public decimal CompanyId { get; set; }
        public decimal CompanyLocationId { get; set; }
        public string WmsCode { get; set; }
        public string CompanyName { get; set; }
    }

    // this corresponds to CompanyLocation in the server Db
    public class CustomCompanyLocation
    {
        public decimal CompanyId { get; set; }
        public decimal CompanyLocationId { get; set; }
        public int WarehouseLocationId { get; set; }
    }
    public class CurrentUser
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Uid { get; set; }
        public string Pwd { get; set; }
        public DateTime RecentSubmit { get; set; }
        public int MostRecentScreen { get; set; }
        // IsHomeScreen = 1, IsMiddleScreen = 2, IsThirdScreen = 3, IsFourthScreen = 4
    }
    public class Store
    {
        [NotNull]
        public int id { get; set; }
        [NotNull]
        public string Retailer { get; set; }
        public string DivisionOrBrand { get; set; }
        [NotNull]
        public string StoreNumber { get; set; }
    }

    public class UpdateFlag : INotifyPropertyChanged
    {
        private Guid _FlagValue { get; set; }
        public Guid FlagValue
        {
            get
            { return _FlagValue; }
            set
            {
                _FlagValue = value;
                ThisPropertyHasChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void ThisPropertyHasChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class LoadOnTrailerModel
    {
        public Guid PalletId { get; set; }
        public bool IsDbms { get; set; }
        public string Reason { get; set; }
        public int LoaderMobileUserId { get; set; }
    }
    public class ScannerForUi
    {   // NOTE: changes here must be made in similar class in MgrLibrary . tlObjects
        public ScannerForUi() { }
        public ScannerForUi(string scannerName)
        {
            ScannerName = scannerName;
        }
        public string ScannerName { get; set; }
        public string CreatedDate { get; set; }
        public string UserNameFn { get; set; }
        public string UserNameLn { get; set; }
        public string ScreenName { get; set; }
        public string AppName { get; set; }
        public string ProformaDate { get; set; }
        public string RunName { get; set; }
        public string RsCompanyName { get; set; }
        public List<ScannerActivityForUi> LoggedActivities { get; set; } = new List<ScannerActivityForUi>();
    }

    public class ShipperForUi
    {
        public int CompanyLocationId { get; set; }

        public string ShipperName { get; set; }

    }
    public class ScannerActivityForUi
    {   // NOTE: changes here must be made in similar class in MgrLibrary
        public int ScannerActivityId { get; set; }
        public string ScannerName { get; set; }
        // public DateTime? CreatedDate { get; set; }
        public string CreatedDate { get; set; }
        public string UserNameFn { get; set; }
        public string UserNameLn { get; set; }
        public int DbAppServerVersion { get; set; }
        public int RunStopId { get; set; }
        public string ScreenName { get; set; }
        public string RunName { get; set; }
        public string StkCustomerCode { get; set; }
        public string AppName { get; set; }
        public string DeviceMacAddress { get; set; }
        public DateTime? DispatchDate { get; set; }
        public int? ConsigneeCompanyLocationId { get; set; }
        public string RsCompanyName { get; set; }
        public int MobileUserId { get; set; }
        public int? DeviceAppVersion { get; set; }
    }

    public class ThisDevice
    {
        public string MacAddress { get; set; }
        public string Name { get; set; }
    }
    public class RunStopForUi
    {
        public string RunStopName { get; set; }
        public int RunStopId { get; set; }
    }  
    
    public class MobileUserForUi
    {
        public int MobileUserId { get; set; }
        private string _Lastname { get; set; }
        public string Lastname
        {
            get
            {
                return _Lastname;
            }
            set
            {
                string ln = value == null ? "" : value;
                _Lastname = ln;
            }
        }
        private string _Firstname { get; set; }
        public string Firstname 
        {
            get
            {
                return _Firstname;
            }
            set
            {
                string fn = value == null ? "" : value;
                _Firstname = fn;
            }
        }
        public string FullName => $"{Firstname.Trim()} {Lastname.Trim()}";
    }

    public class PalletColorForUi
    {
        public int PalletColorId { get; set; }

        public string DisplayName { get; set; }

        public bool ShouldDisplay { get; set; }

    }

}

