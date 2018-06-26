namespace UseStubbedData.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<AppLog> AppLogs { get; set; }
        public virtual DbSet<AppSetting> AppSettings { get; set; }
        public virtual DbSet<chkCheckItem> chkCheckItems { get; set; }
        public virtual DbSet<chkCheckItemLog> chkCheckItemLogs { get; set; }
        public virtual DbSet<chkPallet> chkPallets { get; set; }
        public virtual DbSet<chkPalletLog> chkPalletLogs { get; set; }
        public virtual DbSet<ClientBarcodeType> ClientBarcodeTypes { get; set; }
        public virtual DbSet<ClientBarcodeTypeSpec> ClientBarcodeTypeSpecs { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyCarrier> CompanyCarriers { get; set; }
        public virtual DbSet<CompanyContactInfo> CompanyContactInfoes { get; set; }
        public virtual DbSet<CompanyLocation> CompanyLocations { get; set; }
        public virtual DbSet<CompanyLocationAppointment> CompanyLocationAppointments { get; set; }
        public virtual DbSet<CompanyLocationGP> CompanyLocationGPS { get; set; }
        public virtual DbSet<CompanyOpenWindow> CompanyOpenWindows { get; set; }
        public virtual DbSet<CompanyStandard> CompanyStandards { get; set; }
        public virtual DbSet<CompletedWork> CompletedWorks { get; set; }
        public virtual DbSet<Condition> Conditions { get; set; }
        public virtual DbSet<ContactType> ContactTypes { get; set; }
        public virtual DbSet<DeletedOrder> DeletedOrders { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<ediGroup> ediGroups { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee_Calendar> Employee_Calendar { get; set; }
        public virtual DbSet<Employee_Department> Employee_Department { get; set; }
        public virtual DbSet<Employee_InActive_Reason_List> Employee_InActive_Reason_List { get; set; }
        public virtual DbSet<Employee_Productivity> Employee_Productivity { get; set; }
        public virtual DbSet<EmployeeTime> EmployeeTimes { get; set; }
        public virtual DbSet<EquipmentChecklistResponse> EquipmentChecklistResponses { get; set; }
        public virtual DbSet<EquipmentClassHeader> EquipmentClassHeaders { get; set; }
        public virtual DbSet<EquipmentDetail> EquipmentDetails { get; set; }
        public virtual DbSet<ExceptionLog> ExceptionLogs { get; set; }
        public virtual DbSet<Flag> Flags { get; set; }
        public virtual DbSet<GPSLocation> GPSLocations { get; set; }
        public virtual DbSet<IdList> IdLists { get; set; }
        public virtual DbSet<ImportedWarehouseWeight> ImportedWarehouseWeights { get; set; }
        public virtual DbSet<InboundCondition> InboundConditions { get; set; }
        public virtual DbSet<InboundException> InboundExceptions { get; set; }
        public virtual DbSet<InboundException_Beta> InboundException_Beta { get; set; }
        public virtual DbSet<InboundExceptionCondition> InboundExceptionConditions { get; set; }
        public virtual DbSet<InboundExceptionCondition_Beta> InboundExceptionCondition_Beta { get; set; }
        public virtual DbSet<InboundLocation> InboundLocations { get; set; }
        public virtual DbSet<InboundLog> InboundLogs { get; set; }
        public virtual DbSet<InboundPallet> InboundPallets { get; set; }
        public virtual DbSet<InboundPallet_Beta> InboundPallet_Beta { get; set; }
        public virtual DbSet<InboundPalletDetail_Beta> InboundPalletDetail_Beta { get; set; }
        public virtual DbSet<InboundSealDisposition> InboundSealDispositions { get; set; }
        public virtual DbSet<InboundTrailer> InboundTrailers { get; set; }
        public virtual DbSet<InboundTrailer_Beta> InboundTrailer_Beta { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<JobType> JobTypes { get; set; }
        public virtual DbSet<License> Licenses { get; set; }
        public virtual DbSet<Location_ImageRelationship> Location_ImageRelationship { get; set; }
        public virtual DbSet<Location_Images> Location_Images { get; set; }
        public virtual DbSet<LoggedInfo> LoggedInfoes { get; set; }
        public virtual DbSet<MobileAppConfig> MobileAppConfigs { get; set; }
        public virtual DbSet<MobileAppEmployeeRequestsOthersRun> MobileAppEmployeeRequestsOthersRuns { get; set; }
        public virtual DbSet<MobileAppException> MobileAppExceptions { get; set; }
        public virtual DbSet<MobileAppProformaDateReleased> MobileAppProformaDateReleaseds { get; set; }
        public virtual DbSet<MobileUser> MobileUsers { get; set; }
        public virtual DbSet<ModuleInfo> ModuleInfoes { get; set; }
        public virtual DbSet<NewOrder> NewOrders { get; set; }
        public virtual DbSet<NonDispatchedStop> NonDispatchedStops { get; set; }
        public virtual DbSet<NonDispatchedStopType> NonDispatchedStopTypes { get; set; }
        public virtual DbSet<OrderAction> OrderActions { get; set; }
        public virtual DbSet<OrderActivity> OrderActivities { get; set; }
        public virtual DbSet<OrderAssignment> OrderAssignments { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderError> OrderErrors { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<OrderJobCode> OrderJobCodes { get; set; }
        public virtual DbSet<OrderJobCodeMapping> OrderJobCodeMappings { get; set; }
        public virtual DbSet<OrderPick> OrderPicks { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PalletTag> PalletTags { get; set; }
        public virtual DbSet<Proforma> Proformas { get; set; }
        public virtual DbSet<ProformaRunMaster> ProformaRunMasters { get; set; }
        public virtual DbSet<ProformaRunResource> ProformaRunResources { get; set; }
        public virtual DbSet<ProformaRunStop> ProformaRunStops { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Run> Runs { get; set; }
        public virtual DbSet<RunAssignment> RunAssignments { get; set; }
        public virtual DbSet<RunDetail> RunDetails { get; set; }
        public virtual DbSet<RunOrder> RunOrders { get; set; }
        public virtual DbSet<RunResource> RunResources { get; set; }
        public virtual DbSet<RunStop> RunStops { get; set; }
        public virtual DbSet<RunStopDetail> RunStopDetails { get; set; }
        public virtual DbSet<RunStopDetailPhoto> RunStopDetailPhotoes { get; set; }
        public virtual DbSet<RunSub> RunSubs { get; set; }
        public virtual DbSet<ScannedPalletConfirm> ScannedPalletConfirms { get; set; }
        public virtual DbSet<ScannedPalletLoad> ScannedPalletLoads { get; set; }
        public virtual DbSet<Server> Servers { get; set; }
        public virtual DbSet<Status_Codes> Status_Codes { get; set; }
        public virtual DbSet<stkBarcode> stkBarcodes { get; set; }
        public virtual DbSet<stkCodeDate> stkCodeDates { get; set; }
        public virtual DbSet<stkFlag> stkFlags { get; set; }
        public virtual DbSet<stkInfo> stkInfoes { get; set; }
        public virtual DbSet<stkMobileDevice> stkMobileDevices { get; set; }
        public virtual DbSet<stkSqlCEIdentityRange> stkSqlCEIdentityRanges { get; set; }
        public virtual DbSet<stkStock> stkStocks { get; set; }
        public virtual DbSet<StopAssignment> StopAssignments { get; set; }
        public virtual DbSet<SurName> SurNames { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tractor> Tractors { get; set; }
        public virtual DbSet<Tractor_Calendar> Tractor_Calendar { get; set; }
        public virtual DbSet<Tractor_InActive_Reason_List> Tractor_InActive_Reason_List { get; set; }
        public virtual DbSet<Tractor_Productivity> Tractor_Productivity { get; set; }
        public virtual DbSet<Trailer> Trailers { get; set; }
        public virtual DbSet<Trailer_Calendar> Trailer_Calendar { get; set; }
        public virtual DbSet<Trailer_Inactive_Reason_List> Trailer_Inactive_Reason_List { get; set; }
        public virtual DbSet<Trailer_Productivity> Trailer_Productivity { get; set; }
        public virtual DbSet<WorkAssignment> WorkAssignments { get; set; }
        public virtual DbSet<XPObjectType> XPObjectTypes { get; set; }
        public virtual DbSet<ArchiveOrderDetail> ArchiveOrderDetails { get; set; }
        public virtual DbSet<ArchiveOrder> ArchiveOrders { get; set; }
        public virtual DbSet<ArchiveRun> ArchiveRuns { get; set; }
        public virtual DbSet<ArchiveRunOrder> ArchiveRunOrders { get; set; }
        public virtual DbSet<ArchiveRunResource> ArchiveRunResources { get; set; }
        public virtual DbSet<ArchiveRunStop> ArchiveRunStops { get; set; }
        public virtual DbSet<chkStop> chkStops { get; set; }
        public virtual DbSet<CompanyMfCode> CompanyMfCodes { get; set; }
        public virtual DbSet<CompanyShipper> CompanyShippers { get; set; }
        public virtual DbSet<edi214> edi214 { get; set; }
        public virtual DbSet<ediFa> ediFas { get; set; }
        public virtual DbSet<ediTransaction> ediTransactions { get; set; }
        public virtual DbSet<NewOrderDetail> NewOrderDetails { get; set; }
        public virtual DbSet<ReportJob> ReportJobs { get; set; }
        public virtual DbSet<Results_old> Results_old { get; set; }
        public virtual DbSet<Service_Level> Service_Level { get; set; }
        public virtual DbSet<stkBarcode_Archive> stkBarcode_Archive { get; set; }
        public virtual DbSet<stkCust> stkCusts { get; set; }
        public virtual DbSet<stkInfoFlag> stkInfoFlags { get; set; }
        public virtual DbSet<stkLocation> stkLocations { get; set; }
        public virtual DbSet<stkSqlCEIdentityRangeTable> stkSqlCEIdentityRangeTables { get; set; }
        public virtual DbSet<stkUser> stkUsers { get; set; }
        public virtual DbSet<StopPallet> StopPallets { get; set; }
        public virtual DbSet<Zip2Zip> Zip2Zip { get; set; }
        public virtual DbSet<Zip2ZipHistory> Zip2ZipHistory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppLog>()
                .Property(e => e.TraceType)
                .IsUnicode(false);

            modelBuilder.Entity<AppLog>()
                .Property(e => e.AppName)
                .IsUnicode(false);

            modelBuilder.Entity<AppLog>()
                .Property(e => e.Context)
                .IsUnicode(false);

            modelBuilder.Entity<AppLog>()
                .Property(e => e.SQLStmt)
                .IsUnicode(false);

            modelBuilder.Entity<AppLog>()
                .Property(e => e.ExecuteAsHours)
                .HasPrecision(12, 3);

            modelBuilder.Entity<AppLog>()
                .Property(e => e.ExecuteAsMinutes)
                .HasPrecision(12, 3);

            modelBuilder.Entity<AppLog>()
                .Property(e => e.ExecuteAsSeconds)
                .HasPrecision(12, 3);

            modelBuilder.Entity<AppLog>()
                .Property(e => e.ExecuteAsMilliseconds)
                .HasPrecision(12, 3);

            modelBuilder.Entity<AppSetting>()
                .Property(e => e.SettingName)
                .IsUnicode(false);

            modelBuilder.Entity<AppSetting>()
                .Property(e => e.SettingValue)
                .IsUnicode(false);

            modelBuilder.Entity<chkCheckItem>()
                .Property(e => e.Barcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<chkCheckItem>()
                .Property(e => e.Itemcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<chkCheckItem>()
                .Property(e => e.Custcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<chkCheckItemLog>()
                .Property(e => e.Barcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<chkCheckItemLog>()
                .Property(e => e.Itemcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<chkCheckItemLog>()
                .Property(e => e.Custcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<chkCheckItemLog>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<chkCheckItemLog>()
                .Property(e => e.ActionUser)
                .IsUnicode(false);

            modelBuilder.Entity<chkPallet>()
                .Property(e => e.Initials)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<chkPalletLog>()
                .Property(e => e.Initials)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<chkPalletLog>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<chkPalletLog>()
                .Property(e => e.ActionUser)
                .IsUnicode(false);

            modelBuilder.Entity<ClientBarcodeType>()
                .Property(e => e.ClientName)
                .IsUnicode(false);

            modelBuilder.Entity<ClientBarcodeType>()
                .Property(e => e.Prefix)
                .IsUnicode(false);

            modelBuilder.Entity<ClientBarcodeType>()
                .Property(e => e.ClientDesc)
                .IsUnicode(false);

            modelBuilder.Entity<ClientBarcodeType>()
                .HasMany(e => e.ClientBarcodeTypeSpecs)
                .WithRequired(e => e.ClientBarcodeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClientBarcodeTypeSpec>()
                .Property(e => e.BarcodeTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<ClientBarcodeTypeSpec>()
                .Property(e => e.RegexIdentExtract)
                .IsUnicode(false);

            modelBuilder.Entity<ClientBarcodeTypeSpec>()
                .Property(e => e.StoreConcatChar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.CompanyID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Company>()
                .Property(e => e.WMSCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.ParentCompany)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Notes)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyCarrier>()
                .Property(e => e.CompanyCarrierID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyCarrier>()
                .Property(e => e.CompanyLocationID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyCarrier>()
                .Property(e => e.Rank)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyContactInfo>()
                .Property(e => e.CompanyContactInfoID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyContactInfo>()
                .Property(e => e.CompanyLocationID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyContactInfo>()
                .Property(e => e.ContactType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyContactInfo>()
                .Property(e => e.ContactBlnk)
                .IsUnicode(false);

            modelBuilder.Entity<CompanyContactInfo>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<CompanyContactInfo>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyContactInfo>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyContactInfo>()
                .Property(e => e.ContactTypeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyLocation>()
                .Property(e => e.CompanyLocationID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyLocation>()
                .Property(e => e.CompanyID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyLocation>()
                .Property(e => e.Type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyLocation>()
                .Property(e => e.Type1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyLocation>()
                .Property(e => e.AlternateName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyLocation>()
                .Property(e => e.Street1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyLocation>()
                .Property(e => e.Street2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyLocation>()
                .Property(e => e.Street3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyLocation>()
                .Property(e => e.City)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyLocation>()
                .Property(e => e.State)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyLocation>()
                .Property(e => e.PostalCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyLocation>()
                .Property(e => e.Appointment)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyLocation>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<CompanyLocation>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyLocation>()
                .Property(e => e.FaxNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyLocation>()
                .Property(e => e.SpecialInstructions)
                .IsUnicode(false);

            modelBuilder.Entity<CompanyLocation>()
                .Property(e => e.Directions)
                .IsUnicode(false);

            modelBuilder.Entity<CompanyLocation>()
                .Property(e => e.PMCustNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyLocation>()
                .Property(e => e.Lane)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyLocation>()
                .HasMany(e => e.CompanyLocationAppointments)
                .WithRequired(e => e.CompanyLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompanyLocation>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.CompanyLocation)
                .HasForeignKey(e => e.Consignee);

            modelBuilder.Entity<CompanyLocation>()
                .HasMany(e => e.Orders1)
                .WithOptional(e => e.CompanyLocation1)
                .HasForeignKey(e => e.Consignor);

            modelBuilder.Entity<CompanyLocation>()
                .HasMany(e => e.Orders2)
                .WithRequired(e => e.CompanyLocation2)
                .HasForeignKey(e => e.ShipperID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompanyLocation>()
                .HasMany(e => e.ProformaRunStops)
                .WithRequired(e => e.CompanyLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompanyLocationAppointment>()
                .Property(e => e.CompanyLocationAppointmentID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyLocationAppointment>()
                .Property(e => e.CompanyLocationID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyLocationGP>()
                .Property(e => e.CompanyLocationId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyLocationGP>()
                .Property(e => e.Longitude)
                .HasPrecision(18, 10);

            modelBuilder.Entity<CompanyLocationGP>()
                .Property(e => e.Latitude)
                .HasPrecision(18, 10);

            modelBuilder.Entity<CompanyOpenWindow>()
                .Property(e => e.CompanyOpenWindowID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyOpenWindow>()
                .Property(e => e.CompanyLocationID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyOpenWindow>()
                .Property(e => e.DayofWeek)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyStandard>()
                .Property(e => e.CompanyStandardID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyStandard>()
                .Property(e => e.CompanyLocationID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyStandard>()
                .Property(e => e.MinTime)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyStandard>()
                .Property(e => e.PoundsPerHour)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompletedWork>()
                .Property(e => e.EmployeeId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompletedWork>()
                .Property(e => e.Hours)
                .HasPrecision(6, 2);

            modelBuilder.Entity<CompletedWork>()
                .Property(e => e.UnitType)
                .IsUnicode(false);

            modelBuilder.Entity<CompletedWork>()
                .Property(e => e.Units)
                .HasPrecision(9, 2);

            modelBuilder.Entity<CompletedWork>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<Condition>()
                .Property(e => e.ConditionID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Condition>()
                .Property(e => e.Condition1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ContactType>()
                .Property(e => e.ContactTypeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ContactType>()
                .Property(e => e.ContactType1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DeletedOrder>()
                .Property(e => e.DeletedOrdersID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DeletedOrder>()
                .Property(e => e.OrderID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DeletedOrder>()
                .Property(e => e.OrderNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DeletedOrder>()
                .Property(e => e.ShipperNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DeletedOrder>()
                .Property(e => e.ShipperID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DeletedOrder>()
                .Property(e => e.Consignor)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DeletedOrder>()
                .Property(e => e.Consignee)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DeletedOrder>()
                .Property(e => e.TotalOrderWeight)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DeletedOrder>()
                .Property(e => e.TotalOrderCube)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DeletedOrder>()
                .Property(e => e.TotalOrderPieces)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DeletedOrder>()
                .Property(e => e.TotalOrderPallets)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DeletedOrder>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DeletedOrder>()
                .Property(e => e.OrderOrientation)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DeletedOrder>()
                .Property(e => e.PO_Number)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DeletedOrder>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<DeletedOrder>()
                .Property(e => e.Condition)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.DepartmentID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Department>()
                .Property(e => e.Department1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Employee_Department)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<ediGroup>()
                .Property(e => e.IsaSendQual)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ediGroup>()
                .Property(e => e.IsaSendID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ediGroup>()
                .Property(e => e.IsaRecvQual)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ediGroup>()
                .Property(e => e.IsaRecvID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ediGroup>()
                .Property(e => e.IsaAck)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ediGroup>()
                .Property(e => e.IsaUsage)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ediGroup>()
                .Property(e => e.GsCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ediGroup>()
                .Property(e => e.GsSendID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ediGroup>()
                .Property(e => e.GsRecvID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ediGroup>()
                .Property(e => e.AckCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ediGroup>()
                .HasMany(e => e.ediTransactions)
                .WithOptional(e => e.ediGroup)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee>()
                .Property(e => e.SurName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.MiddleName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.LastName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.SuffixName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Ref1)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Ref2)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Ref3)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Employee_Department)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Employee_Productivity)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.RunResources)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.Driver1);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.RunResources1)
                .WithOptional(e => e.Employee1)
                .HasForeignKey(e => e.Driver2);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.WorkAssignments)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee_Calendar>()
                .Property(e => e.Employee_CalendarID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee_Calendar>()
                .Property(e => e.EmployeeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee_Calendar>()
                .Property(e => e.Employee_InActive_Reason_ListID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee_Department>()
                .Property(e => e.Employee_DepartmentID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee_Department>()
                .Property(e => e.EmployeeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee_Department>()
                .Property(e => e.DepartmentID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee_InActive_Reason_List>()
                .Property(e => e.Employee_Inactive_Reason_ListID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee_InActive_Reason_List>()
                .Property(e => e.InActive_Reason)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee_InActive_Reason_List>()
                .HasMany(e => e.Employee_Productivity)
                .WithOptional(e => e.Employee_InActive_Reason_List)
                .HasForeignKey(e => e.Employee_Inactive_ReasonID);

            modelBuilder.Entity<Employee_Productivity>()
                .Property(e => e.Employee_ProductivityID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee_Productivity>()
                .Property(e => e.EmployeeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee_Productivity>()
                .Property(e => e.Status)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee_Productivity>()
                .Property(e => e.Employee_Inactive_ReasonID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeTime>()
                .Property(e => e.EmployeeId)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeTime>()
                .Property(e => e.InTime)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeTime>()
                .Property(e => e.OutTime)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeTime>()
                .Property(e => e.InCode)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeTime>()
                .Property(e => e.OutCode)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeTime>()
                .Property(e => e.RegHour)
                .HasPrecision(6, 2);

            modelBuilder.Entity<EmployeeTime>()
                .Property(e => e.OverTime1)
                .HasPrecision(6, 2);

            modelBuilder.Entity<EmployeeTime>()
                .Property(e => e.OverTime2)
                .HasPrecision(6, 2);

            modelBuilder.Entity<EmployeeTime>()
                .Property(e => e.Shift)
                .IsUnicode(false);

            modelBuilder.Entity<EquipmentChecklistResponse>()
                .Property(e => e.RunNumberId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EquipmentChecklistResponse>()
                .Property(e => e.EmployeeId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EquipmentClassHeader>()
                .HasMany(e => e.EquipmentChecklistResponses)
                .WithRequired(e => e.EquipmentClassHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EquipmentClassHeader>()
                .HasMany(e => e.EquipmentDetails)
                .WithRequired(e => e.EquipmentClassHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExceptionLog>()
                .Property(e => e.ScannerId)
                .IsUnicode(false);

            modelBuilder.Entity<ExceptionLog>()
                .Property(e => e.MsgSource)
                .IsUnicode(false);

            modelBuilder.Entity<ExceptionLog>()
                .Property(e => e.MsgType)
                .IsUnicode(false);

            modelBuilder.Entity<ExceptionLog>()
                .Property(e => e.MsgText)
                .IsUnicode(false);

            modelBuilder.Entity<Flag>()
                .Property(e => e.FlagID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Flag>()
                .Property(e => e.HostOrders)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Flag>()
                .Property(e => e.ProcessedOrders)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Flag>()
                .HasMany(e => e.NewOrderDetails)
                .WithRequired(e => e.Flag)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GPSLocation>()
                .Property(e => e.EmployeeId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<GPSLocation>()
                .Property(e => e.Longitude)
                .HasPrecision(18, 8);

            modelBuilder.Entity<GPSLocation>()
                .Property(e => e.Latitude)
                .HasPrecision(18, 8);

            modelBuilder.Entity<IdList>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ImportedWarehouseWeight>()
                .Property(e => e.Weight)
                .HasPrecision(8, 2);

            modelBuilder.Entity<InboundCondition>()
                .Property(e => e.ConditionDescription)
                .IsUnicode(false);

            modelBuilder.Entity<InboundLocation>()
                .Property(e => e.LocationType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InboundLocation>()
                .Property(e => e.LocationCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InboundLocation>()
                .Property(e => e.LocationDescription)
                .IsUnicode(false);

            modelBuilder.Entity<InboundLog>()
                .Property(e => e.ScannerId)
                .IsUnicode(false);

            modelBuilder.Entity<InboundLog>()
                .Property(e => e.MsgSource)
                .IsUnicode(false);

            modelBuilder.Entity<InboundLog>()
                .Property(e => e.MsgType)
                .IsUnicode(false);

            modelBuilder.Entity<InboundLog>()
                .Property(e => e.MsgText)
                .IsUnicode(false);

            modelBuilder.Entity<InboundPallet>()
                .Property(e => e.LicensePlate)
                .IsUnicode(false);

            modelBuilder.Entity<InboundPallet>()
                .Property(e => e.ItemCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InboundPallet>()
                .Property(e => e.CustCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InboundPallet_Beta>()
                .Property(e => e.LicensePlate)
                .IsUnicode(false);

            modelBuilder.Entity<InboundPalletDetail_Beta>()
                .Property(e => e.ItemCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InboundPalletDetail_Beta>()
                .Property(e => e.CustCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InboundSealDisposition>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<InboundTrailer>()
                .Property(e => e.URNumber)
                .IsUnicode(false);

            modelBuilder.Entity<InboundTrailer>()
                .Property(e => e.ReportPrinted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InboundTrailer>()
                .Property(e => e.UnloadStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InboundTrailer>()
                .Property(e => e.ReSealNumber)
                .IsUnicode(false);

            modelBuilder.Entity<InboundTrailer>()
                .Property(e => e.SealNumber)
                .IsUnicode(false);

            modelBuilder.Entity<InboundTrailer>()
                .Property(e => e.Dunnage)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InboundTrailer_Beta>()
                .Property(e => e.URNumber)
                .IsUnicode(false);

            modelBuilder.Entity<InboundTrailer_Beta>()
                .Property(e => e.ReportPrinted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InboundTrailer_Beta>()
                .Property(e => e.UnloadStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InboundTrailer_Beta>()
                .Property(e => e.ReSealNumber)
                .IsUnicode(false);

            modelBuilder.Entity<InboundTrailer_Beta>()
                .Property(e => e.SealNumber)
                .IsUnicode(false);

            modelBuilder.Entity<InboundTrailer_Beta>()
                .Property(e => e.Dunnage)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.ItemCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Description)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Weight)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Item>()
                .Property(e => e.Cube)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Item>()
                .Property(e => e.Different_Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JobType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<JobType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<License>()
                .Property(e => e.LicenseID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<License>()
                .Property(e => e.RunID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<License>()
                .Property(e => e.RunStopID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<License>()
                .Property(e => e.ProformaRunMasterID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<License>()
                .Property(e => e.RunNumberID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<License>()
                .Property(e => e.StopNumberID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Location_Images>()
                .HasMany(e => e.Location_ImageRelationship)
                .WithRequired(e => e.Location_Images)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoggedInfo>()
                .Property(e => e.Importance)
                .IsUnicode(false);

            modelBuilder.Entity<LoggedInfo>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<MobileAppEmployeeRequestsOthersRun>()
                .Property(e => e.EmployeeId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MobileAppEmployeeRequestsOthersRun>()
                .Property(e => e.RequestedEmployeeId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MobileAppEmployeeRequestsOthersRun>()
                .Property(e => e.RunNumberId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MobileAppProformaDateReleased>()
                .Property(e => e.ProformaDate)
                .IsUnicode(false);

            modelBuilder.Entity<MobileUser>()
                .Property(e => e.Lastname)
                .IsFixedLength();

            modelBuilder.Entity<MobileUser>()
                .Property(e => e.Firstname)
                .IsFixedLength();

            modelBuilder.Entity<MobileUser>()
                .Property(e => e.Initials)
                .IsFixedLength();

            modelBuilder.Entity<NewOrder>()
                .Property(e => e.NewOrdersID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NewOrder>()
                .Property(e => e.OrderID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NewOrder>()
                .Property(e => e.OrderNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NewOrder>()
                .Property(e => e.ShipperNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewOrder>()
                .Property(e => e.ShipperID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NewOrder>()
                .Property(e => e.Consignor)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NewOrder>()
                .Property(e => e.Consignee)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NewOrder>()
                .Property(e => e.TotalOrderCube)
                .HasPrecision(18, 3);

            modelBuilder.Entity<NewOrder>()
                .Property(e => e.TotalOrderPieces)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NewOrder>()
                .Property(e => e.TotalOrderPallets)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NewOrder>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewOrder>()
                .Property(e => e.OrderOrientation)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewOrder>()
                .Property(e => e.PO_Number)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewOrder>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<NewOrder>()
                .Property(e => e.Condition)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewOrder>()
                .Property(e => e.FlagID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<NewOrder>()
                .Property(e => e.AddDeleteEdit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewOrder>()
                .Property(e => e.Error)
                .IsUnicode(false);

            modelBuilder.Entity<NonDispatchedStop>()
                .Property(e => e.RunId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NonDispatchedStop>()
                .Property(e => e.EmployeeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NonDispatchedStop>()
                .Property(e => e.Longitude)
                .HasPrecision(18, 10);

            modelBuilder.Entity<NonDispatchedStop>()
                .Property(e => e.Latitude)
                .HasPrecision(18, 10);

            modelBuilder.Entity<NonDispatchedStop>()
                .Property(e => e.RunNumberID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NonDispatchedStopType>()
                .HasMany(e => e.NonDispatchedStops)
                .WithRequired(e => e.NonDispatchedStopType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderAction>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<OrderActivity>()
                .Property(e => e.SupervisorCode)
                .IsUnicode(false);

            modelBuilder.Entity<OrderAssignment>()
                .Property(e => e.OrderId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderAssignment>()
                .Property(e => e.EmployeeId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderAssignment>()
                .Property(e => e.PercentPick)
                .HasPrecision(5, 4);

            modelBuilder.Entity<OrderAssignment>()
                .Property(e => e.PercentLoad)
                .HasPrecision(5, 4);

            modelBuilder.Entity<OrderAssignment>()
                .Property(e => e.PercentAssigned)
                .HasPrecision(5, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.OrderDetailID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.OrderID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Pieces)
                .HasPrecision(9, 0);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Cube)
                .HasPrecision(18, 3);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Itemcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Custcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrderError>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<OrderError>()
                .Property(e => e.CustCode)
                .IsUnicode(false);

            modelBuilder.Entity<OrderError>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<OrderError>()
                .Property(e => e.ErrorCode)
                .IsUnicode(false);

            modelBuilder.Entity<OrderError>()
                .Property(e => e.ErrorDesc)
                .IsUnicode(false);

            modelBuilder.Entity<OrderError>()
                .Property(e => e.EntryTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.LookupCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.ShipNo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.SourceTable)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.CustCode)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.EntryTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.EntryMode)
                .IsUnicode(false);

            modelBuilder.Entity<OrderJobCode>()
                .Property(e => e.OrderId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderJobCodeMapping>()
                .Property(e => e.ShipperShortName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderJobCodeMapping>()
                .Property(e => e.ShipperType)
                .IsUnicode(false);

            modelBuilder.Entity<OrderJobCodeMapping>()
                .Property(e => e.OrderType)
                .IsUnicode(false);

            modelBuilder.Entity<OrderPick>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order>()
                .Property(e => e.ShipperNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.ShipperID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order>()
                .Property(e => e.Consignor)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order>()
                .Property(e => e.Consignee)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order>()
                .Property(e => e.TotalOrderCube)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order>()
                .Property(e => e.TotalOrderPieces)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order>()
                .Property(e => e.TotalOrderPallets)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderOrientation)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.PO_Number)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Condition)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PalletTag>()
                .Property(e => e.Userid)
                .IsFixedLength();

            modelBuilder.Entity<PalletTag>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<Proforma>()
                .Property(e => e.ProformaName)
                .IsUnicode(false);

            modelBuilder.Entity<ProformaRunMaster>()
                .Property(e => e.ProformaRunMasterID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProformaRunMaster>()
                .Property(e => e.RunName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProformaRunMaster>()
                .Property(e => e.RunSequence)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProformaRunMaster>()
                .Property(e => e.ProformaName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProformaRunMaster>()
                .Property(e => e.DayOfWeek)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProformaRunMaster>()
                .Property(e => e.RunNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProformaRunResource>()
                .Property(e => e.ProformaRunResourceID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProformaRunResource>()
                .Property(e => e.Driver1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProformaRunResource>()
                .Property(e => e.Driver2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProformaRunResource>()
                .Property(e => e.Tractor)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProformaRunResource>()
                .Property(e => e.Trailer1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProformaRunResource>()
                .Property(e => e.Trailer2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProformaRunResource>()
                .Property(e => e.ProformaRunMasterID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProformaRunStop>()
                .Property(e => e.ProformaRunStopsID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProformaRunStop>()
                .Property(e => e.ProformaRunMasterID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProformaRunStop>()
                .Property(e => e.CompanyLocationID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProformaRunStop>()
                .Property(e => e.StopSequence)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProformaRunStop>()
                .Property(e => e.AveWeight)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProformaRunStop>()
                .Property(e => e.AveCube)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProformaRunStop>()
                .Property(e => e.AvePieces)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProformaRunStop>()
                .Property(e => e.AvePallets)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProformaRunStop>()
                .Property(e => e.MilesTo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProformaRunStop>()
                .Property(e => e.AveStopTime)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Report>()
                .Property(e => e.ReportID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Report>()
                .Property(e => e.Menu_Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Report>()
                .Property(e => e.Path)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Report>()
                .Property(e => e.Report1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Report>()
                .Property(e => e.SortOrder)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Run>()
                .Property(e => e.RunID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Run>()
                .Property(e => e.RunName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Run>()
                .Property(e => e.Weight)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Run>()
                .Property(e => e.Cube)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Run>()
                .Property(e => e.Pallets)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Run>()
                .Property(e => e.Pieces)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Run>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Run>()
                .Property(e => e.RunSequence)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Run>()
                .Property(e => e.StandardMiles)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Run>()
                .Property(e => e.ActualMiles)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Run>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<Run>()
                .Property(e => e.RunNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Run>()
                .Property(e => e.PickUp)
                .IsUnicode(false);

            modelBuilder.Entity<Run>()
                .Property(e => e.RunNumberID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Run>()
                .Property(e => e.WarehouseNotes)
                .IsUnicode(false);

            modelBuilder.Entity<RunAssignment>()
                .Property(e => e.RunNumberId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunAssignment>()
                .Property(e => e.EmployeeId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunAssignment>()
                .Property(e => e.PercentPick)
                .HasPrecision(5, 4);

            modelBuilder.Entity<RunAssignment>()
                .Property(e => e.PercentLoad)
                .HasPrecision(5, 4);

            modelBuilder.Entity<RunAssignment>()
                .Property(e => e.PercentAssigned)
                .HasPrecision(5, 4);

            modelBuilder.Entity<RunDetail>()
                .Property(e => e.RunId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunDetail>()
                .Property(e => e.EmployeeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunDetail>()
                .Property(e => e.RunNumberID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunOrder>()
                .Property(e => e.RunOrderID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunOrder>()
                .Property(e => e.RunStopID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunOrder>()
                .Property(e => e.OrderID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunOrder>()
                .Property(e => e.RunOrderSequence)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunOrder>()
                .Property(e => e.pdsCol)
                .IsFixedLength();

            modelBuilder.Entity<RunResource>()
                .Property(e => e.RunResourceID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunResource>()
                .Property(e => e.RunID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunResource>()
                .Property(e => e.CarrierID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunResource>()
                .Property(e => e.TractorID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunResource>()
                .Property(e => e.TrailerID1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunResource>()
                .Property(e => e.TrailerID2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunResource>()
                .Property(e => e.TrailerID3)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunResource>()
                .Property(e => e.Driver1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunResource>()
                .Property(e => e.Driver2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunStop>()
                .Property(e => e.RunStopID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunStop>()
                .Property(e => e.RunID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunStop>()
                .Property(e => e.StopSequence)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunStop>()
                .Property(e => e.RunSubID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunStop>()
                .Property(e => e.CompanyLocationID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunStop>()
                .Property(e => e.StandardMilesTo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunStop>()
                .Property(e => e.ActualMilesTo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunStop>()
                .Property(e => e.Notes)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RunStop>()
                .Property(e => e.StopNumberID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunStop>()
                .Property(e => e.DelayStopTime)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunStopDetail>()
                .Property(e => e.RunID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunStopDetail>()
                .Property(e => e.RunStopID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunStopDetail>()
                .Property(e => e.StopNumberID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunStopDetail>()
                .Property(e => e.EmployeeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunStopDetail>()
                .Property(e => e.GPSLatitude)
                .HasPrecision(18, 10);

            modelBuilder.Entity<RunStopDetail>()
                .Property(e => e.GPSLongitude)
                .HasPrecision(18, 10);

            modelBuilder.Entity<RunStopDetail>()
                .Property(e => e.RunNumberID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunStopDetailPhoto>()
                .Property(e => e.RunStopId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunStopDetailPhoto>()
                .Property(e => e.StopNumberID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunSub>()
                .Property(e => e.RunSubID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunSub>()
                .Property(e => e.RunStopID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RunSub>()
                .Property(e => e.RunID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ScannedPalletConfirm>()
                .Property(e => e.StopNumberID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ScannedPalletConfirm>()
                .Property(e => e.TrailerID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ScannedPalletConfirm>()
                .Property(e => e.TractorID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ScannedPalletConfirm>()
                .Property(e => e.TrailerBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<ScannedPalletConfirm>()
                .Property(e => e.TrailerNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ScannedPalletConfirm>()
                .HasMany(e => e.ScannedPalletLoads)
                .WithRequired(e => e.ScannedPalletConfirm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ScannedPalletLoad>()
                .Property(e => e.StopNumberID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ScannedPalletLoad>()
                .Property(e => e.WMSCode)
                .IsUnicode(false);

            modelBuilder.Entity<ScannedPalletLoad>()
                .Property(e => e.Store)
                .IsUnicode(false);

            modelBuilder.Entity<ScannedPalletLoad>()
                .Property(e => e.PalletCount)
                .HasPrecision(6, 2);

            modelBuilder.Entity<ScannedPalletLoad>()
                .Property(e => e.BarcodeScan)
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.Server1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.Database_Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.UserID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.Password)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.Timer)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Status_Codes>()
                .Property(e => e.Status_codeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Status_Codes>()
                .Property(e => e.Order_Status)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Status_Codes>()
                .Property(e => e.Order_Description)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkBarcode>()
                .Property(e => e.Barcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkBarcode>()
                .Property(e => e.ItemCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkBarcode>()
                .Property(e => e.CustCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkBarcode>()
                .Property(e => e.OldItemCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkCodeDate>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkInfo>()
                .Property(e => e.CustCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkInfo>()
                .Property(e => e.ItemCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkInfo>()
                .Property(e => e.Suffix)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkMobileDevice>()
                .Property(e => e.MacAddress)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkMobileDevice>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkMobileDevice>()
                .Property(e => e.SerialNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkSqlCEIdentityRange>()
                .Property(e => e.SqlCEIdentityRangeTableID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkStock>()
                .Property(e => e.Barcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkStock>()
                .Property(e => e.Itemcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkStock>()
                .Property(e => e.CustCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkStock>()
                .Property(e => e.Location)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkStock>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<StopAssignment>()
                .Property(e => e.StopNumberId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StopAssignment>()
                .Property(e => e.EmployeeId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StopAssignment>()
                .Property(e => e.PercentPick)
                .HasPrecision(5, 4);

            modelBuilder.Entity<StopAssignment>()
                .Property(e => e.PercentLoad)
                .HasPrecision(5, 4);

            modelBuilder.Entity<StopAssignment>()
                .Property(e => e.PercentAssigned)
                .HasPrecision(5, 4);

            modelBuilder.Entity<SurName>()
                .Property(e => e.SurNameID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SurName>()
                .Property(e => e.SurName1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tractor>()
                .Property(e => e.TractorID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Tractor>()
                .Property(e => e.Tractor_Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tractor>()
                .Property(e => e.Tractor_Weight)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tractor>()
                .Property(e => e.Tractor_Axles)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tractor>()
                .HasMany(e => e.Tractor_Productivity)
                .WithRequired(e => e.Tractor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tractor_Calendar>()
                .Property(e => e.Tractor_CalendarID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Tractor_Calendar>()
                .Property(e => e.TractorID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Tractor_Calendar>()
                .Property(e => e.Tractor_Inactive_Reason_ListID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Tractor_InActive_Reason_List>()
                .Property(e => e.Tractor_Inactive_Reason_ListID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Tractor_InActive_Reason_List>()
                .Property(e => e.Inactive_Reason)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tractor_Productivity>()
                .Property(e => e.Tractor_ProductivityID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Tractor_Productivity>()
                .Property(e => e.TractorID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Tractor_Productivity>()
                .Property(e => e.Status)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Tractor_Productivity>()
                .Property(e => e.Tractor_Inactive_ReasonID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Trailer>()
                .Property(e => e.TrailerID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Trailer>()
                .Property(e => e.Trailer_Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Trailer>()
                .Property(e => e.Trailer_Length)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Trailer>()
                .Property(e => e.Trailer_Weight)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Trailer>()
                .Property(e => e.Trailer_MaxOrderWeight)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Trailer>()
                .Property(e => e.Trailer_Axles)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Trailer>()
                .HasMany(e => e.RunResources)
                .WithOptional(e => e.Trailer)
                .HasForeignKey(e => e.TrailerID1);

            modelBuilder.Entity<Trailer>()
                .HasMany(e => e.RunResources1)
                .WithOptional(e => e.Trailer1)
                .HasForeignKey(e => e.TrailerID2);

            modelBuilder.Entity<Trailer>()
                .HasMany(e => e.RunResources2)
                .WithOptional(e => e.Trailer2)
                .HasForeignKey(e => e.TrailerID3);

            modelBuilder.Entity<Trailer>()
                .HasMany(e => e.Trailer_Productivity)
                .WithRequired(e => e.Trailer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Trailer_Calendar>()
                .Property(e => e.Trailer_CalendarID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Trailer_Calendar>()
                .Property(e => e.TrailerID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Trailer_Calendar>()
                .Property(e => e.Trailer_Inactive_Reason_ListID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Trailer_Inactive_Reason_List>()
                .Property(e => e.Trailer_Inactive_Reason_ListID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Trailer_Inactive_Reason_List>()
                .Property(e => e.Inactive_Reason)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Trailer_Productivity>()
                .Property(e => e.Trailer_ProductivityID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Trailer_Productivity>()
                .Property(e => e.TrailerID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Trailer_Productivity>()
                .Property(e => e.Status)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Trailer_Productivity>()
                .Property(e => e.Trailer_Inactive_ReasonID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WorkAssignment>()
                .Property(e => e.EmployeeId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WorkAssignment>()
                .Property(e => e.PercentAssigned)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ArchiveOrderDetail>()
                .Property(e => e.ArchiveOrderDetail1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveOrderDetail>()
                .Property(e => e.OrderID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveOrderDetail>()
                .Property(e => e.Pieces)
                .HasPrecision(9, 0);

            modelBuilder.Entity<ArchiveOrderDetail>()
                .Property(e => e.Cube)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ArchiveOrderDetail>()
                .Property(e => e.ItemCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ArchiveOrderDetail>()
                .Property(e => e.CustCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ArchiveOrder>()
                .Property(e => e.OrderID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveOrder>()
                .Property(e => e.OrderNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveOrder>()
                .Property(e => e.ShipperNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ArchiveOrder>()
                .Property(e => e.ShipperID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveOrder>()
                .Property(e => e.Consignor)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveOrder>()
                .Property(e => e.Consignee)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveOrder>()
                .Property(e => e.TotalOrderCube)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ArchiveOrder>()
                .Property(e => e.TotalOrderPieces)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveOrder>()
                .Property(e => e.TotalOrderPallets)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveOrder>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ArchiveOrder>()
                .Property(e => e.OrderOrientation)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ArchiveOrder>()
                .Property(e => e.PO_Number)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ArchiveOrder>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<ArchiveOrder>()
                .Property(e => e.Condition)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ArchiveRun>()
                .Property(e => e.RunID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRun>()
                .Property(e => e.RunName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ArchiveRun>()
                .Property(e => e.Weight)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRun>()
                .Property(e => e.Cube)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRun>()
                .Property(e => e.Pallets)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRun>()
                .Property(e => e.Pieces)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRun>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ArchiveRun>()
                .Property(e => e.RunSequence)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRun>()
                .Property(e => e.StandardMiles)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRun>()
                .Property(e => e.ActualMiles)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRun>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<ArchiveRun>()
                .Property(e => e.RunNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ArchiveRun>()
                .Property(e => e.PickUp)
                .IsUnicode(false);

            modelBuilder.Entity<ArchiveRun>()
                .Property(e => e.RunNumberID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunOrder>()
                .Property(e => e.RunOrderID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunOrder>()
                .Property(e => e.RunStopID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunOrder>()
                .Property(e => e.OrderID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunOrder>()
                .Property(e => e.RunOrderSequence)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunResource>()
                .Property(e => e.RunResourceID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunResource>()
                .Property(e => e.RunID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunResource>()
                .Property(e => e.CarrierID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunResource>()
                .Property(e => e.TractorID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunResource>()
                .Property(e => e.TrailerID1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunResource>()
                .Property(e => e.TrailerID2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunResource>()
                .Property(e => e.TrailerID3)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunResource>()
                .Property(e => e.Driver1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunResource>()
                .Property(e => e.Driver2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunStop>()
                .Property(e => e.RunStopID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunStop>()
                .Property(e => e.RunID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunStop>()
                .Property(e => e.StopSequence)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunStop>()
                .Property(e => e.RunSubID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunStop>()
                .Property(e => e.CompanyLocationID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunStop>()
                .Property(e => e.StandardMilesTo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunStop>()
                .Property(e => e.ActualMilesTo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunStop>()
                .Property(e => e.Notes)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ArchiveRunStop>()
                .Property(e => e.StopNumberID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ArchiveRunStop>()
                .Property(e => e.DelayStopTime)
                .HasPrecision(18, 0);

            modelBuilder.Entity<chkStop>()
                .Property(e => e.Initials)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<chkStop>()
                .Property(e => e.Cust)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyMfCode>()
                .Property(e => e.MfCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyShipper>()
                .Property(e => e.CompanyLocationID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyShipper>()
                .Property(e => e.Type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyShipper>()
                .Property(e => e.CustCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyShipper>()
                .Property(e => e.HotButton)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CompanyShipper>()
                .Property(e => e.MfgDateType)
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.B10_Ref)
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.B10_ShipId)
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.B10_Scac)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.L11_Po)
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.L11_Ma)
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.N1_Sf_Name)
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.N1_Sf_Qual)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.N1_Sf_Ref)
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.N1_Sh_Name)
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.N3_Sh_Addr1)
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.N4_Sh_City)
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.N4_Sh_St)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.N4_Sh_Zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.N1_Cn_Name)
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.At7_Xa_Date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.At7_Xa_Time)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.At7_Aa_Date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.At7_Aa_Time)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.At7_X9_Date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.At7_X9_Time)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.At7_Ab_Date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.At7_Ab_Time)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.At7_X3_Date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.At7_X3_Time)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.At7_Af_Date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.At7_Af_Time)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.At7_X1_Date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.At7_X1_Time)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.At7_D1_Date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<edi214>()
                .Property(e => e.At7_D1_Time)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ediTransaction>()
                .Property(e => e.StCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ediTransaction>()
                .Property(e => e.AckCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ediTransaction>()
                .Property(e => e.Ref1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ediTransaction>()
                .Property(e => e.Ref2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewOrderDetail>()
                .Property(e => e.OrderDetailID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NewOrderDetail>()
                .Property(e => e.OrderID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NewOrderDetail>()
                .Property(e => e.LineSeqNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NewOrderDetail>()
                .Property(e => e.Pieces)
                .HasPrecision(9, 0);

            modelBuilder.Entity<NewOrderDetail>()
                .Property(e => e.Cube)
                .HasPrecision(18, 3);

            modelBuilder.Entity<NewOrderDetail>()
                .Property(e => e.Itemcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewOrderDetail>()
                .Property(e => e.Custcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewOrderDetail>()
                .Property(e => e.OrderNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NewOrderDetail>()
                .Property(e => e.FlagID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ReportJob>()
                .Property(e => e.Printer)
                .IsUnicode(false);

            modelBuilder.Entity<ReportJob>()
                .Property(e => e.Param1Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ReportJob>()
                .Property(e => e.Param1Value)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ReportJob>()
                .Property(e => e.Param1Type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ReportJob>()
                .Property(e => e.Param2Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ReportJob>()
                .Property(e => e.Param2Value)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ReportJob>()
                .Property(e => e.Param2Type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ReportJob>()
                .Property(e => e.Param3Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ReportJob>()
                .Property(e => e.Param3Value)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ReportJob>()
                .Property(e => e.Param3Type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ReportJob>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Results_old>()
                .Property(e => e.runname)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Results_old>()
                .Property(e => e.CompanyLocationID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Results_old>()
                .Property(e => e.StopSequence)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Service_Level>()
                .Property(e => e.Service_LevelID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<stkBarcode_Archive>()
                .Property(e => e.Barcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkBarcode_Archive>()
                .Property(e => e.ItemCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkBarcode_Archive>()
                .Property(e => e.CustCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkBarcode_Archive>()
                .Property(e => e.OldItemCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkCust>()
                .Property(e => e.CustCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkLocation>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkLocation>()
                .Property(e => e.SortOrder)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkLocation>()
                .Property(e => e.PickSortOrder)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkSqlCEIdentityRangeTable>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkUser>()
                .Property(e => e.Initials)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stkUser>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<stkUser>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Zip2Zip>()
                .Property(e => e.Origin)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zip2Zip>()
                .Property(e => e.Dest)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zip2Zip>()
                .Property(e => e.Miles)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Zip2ZipHistory>()
                .Property(e => e.Origin)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zip2ZipHistory>()
                .Property(e => e.Dest)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zip2ZipHistory>()
                .Property(e => e.OriginalMiles)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Zip2ZipHistory>()
                .Property(e => e.Miles)
                .HasPrecision(7, 2);
        }
    }
}
