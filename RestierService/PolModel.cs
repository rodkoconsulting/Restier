namespace RestierService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PolModel : DbContext
    {
        public PolModel()
            : base("name=PolConnection")
        {
        }

        public virtual DbSet<AR_Customer> AR_Customer { get; set; }
        public virtual DbSet<AR_InvoiceHistoryDetail> AR_InvoiceHistoryDetail { get; set; }
        public virtual DbSet<AR_InvoiceHistoryHeader> AR_InvoiceHistoryHeader { get; set; }
        public virtual DbSet<ODataInvoices> ODataInvoices { get; set; }
        public virtual DbSet<Web_ActiveUsers> Web_ActiveUsers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.ARDivisionNo)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.CustomerNo)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.CustomerType)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.SalespersonDivisionNo)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.SalespersonNo)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.PrimaryShipToCode)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.SortField)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.TermsCode)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.PriceLevel)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.SHIPMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.AgingCategory1)
                .HasPrecision(13, 2);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.AgingCategory2)
                .HasPrecision(13, 2);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.AgingCategory3)
                .HasPrecision(13, 2);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.AgingCategory4)
                .HasPrecision(13, 2);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.CURRENTBALANCE)
                .HasPrecision(13, 2);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.CREDITHOLD)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.CREDITLIMIT)
                .HasPrecision(13, 2);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.OPENORDERAMT)
                .HasPrecision(13, 2);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_ACCOUNT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_LICENSE_NUM)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_AFFILIATIONS)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_GROWTH_POTENTIAL)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_STORE_REST_FOCUS)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_OTHER_KEY_SUPPLIERS)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_CUST_ACTIVE_STAT)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_CERT_ON_FILE)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_PERM_SPEC_DELIV)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_WINE_BUYER)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_WINE_BUYER_2)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_WINE_BUYER_3)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_WINE_BUYER_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_WINE_BUYER_PHONE_2)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_WINE_BUYER_PHONE_3)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_WINE_BUYER_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_WINE_BUYER_2_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_WINE_BUYER_3_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_PO_REQUIRED)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_NJ_COOP)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_PREMISIS_ADDRESS_LINE_1)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_PREMISIS_ADDRESS_LINE_2)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_PREMISIS_CITY)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_PREMISIS_STATE)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_PREMISIS_ZIP)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.UDF_REP_EMAIL_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<AR_Customer>()
                .Property(e => e.DefaultPaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<AR_InvoiceHistoryDetail>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<AR_InvoiceHistoryDetail>()
                .Property(e => e.HeaderSeqNo)
                .IsUnicode(false);

            modelBuilder.Entity<AR_InvoiceHistoryDetail>()
                .Property(e => e.DetailSeqNo)
                .IsUnicode(false);

            modelBuilder.Entity<AR_InvoiceHistoryDetail>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<AR_InvoiceHistoryDetail>()
                .Property(e => e.ItemCodeDesc)
                .IsUnicode(false);

            modelBuilder.Entity<AR_InvoiceHistoryDetail>()
                .Property(e => e.ItemType)
                .IsUnicode(false);

            modelBuilder.Entity<AR_InvoiceHistoryDetail>()
                .Property(e => e.WarehouseCode)
                .IsUnicode(false);

            modelBuilder.Entity<AR_InvoiceHistoryDetail>()
                .Property(e => e.UnitOfMeasure)
                .IsUnicode(false);

            modelBuilder.Entity<AR_InvoiceHistoryDetail>()
                .Property(e => e.QuantityShipped)
                .HasPrecision(15, 6);

            modelBuilder.Entity<AR_InvoiceHistoryDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(15, 6);

            modelBuilder.Entity<AR_InvoiceHistoryDetail>()
                .Property(e => e.UnitCost)
                .HasPrecision(15, 6);

            modelBuilder.Entity<AR_InvoiceHistoryDetail>()
                .Property(e => e.ExtensionAmt)
                .HasPrecision(11, 2);

            modelBuilder.Entity<AR_InvoiceHistoryDetail>()
                .Property(e => e.CostOfGoodsSoldAcctKey)
                .IsUnicode(false);

            modelBuilder.Entity<AR_InvoiceHistoryHeader>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<AR_InvoiceHistoryHeader>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<AR_InvoiceHistoryHeader>()
                .Property(e => e.HeaderSeqNo)
                .IsUnicode(false);

            modelBuilder.Entity<AR_InvoiceHistoryHeader>()
                .Property(e => e.ModuleCode)
                .IsUnicode(false);

            modelBuilder.Entity<AR_InvoiceHistoryHeader>()
                .Property(e => e.ARDivisionNo)
                .IsUnicode(false);

            modelBuilder.Entity<AR_InvoiceHistoryHeader>()
                .Property(e => e.CustomerNo)
                .IsUnicode(false);

            modelBuilder.Entity<AR_InvoiceHistoryHeader>()
                .Property(e => e.SalespersonDivisionNo)
                .IsUnicode(false);

            modelBuilder.Entity<AR_InvoiceHistoryHeader>()
                .Property(e => e.SalesPersonNo)
                .IsUnicode(false);

            modelBuilder.Entity<AR_InvoiceHistoryHeader>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<AR_InvoiceHistoryHeader>()
                .Property(e => e.UDF_NJ_COOP)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
               .Property(e => e.InvNo)
               .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Typ)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Item)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Acct)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Aff)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Desc)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Qty)
                .HasPrecision(15, 6);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Pri)
                .HasPrecision(15, 6);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Tot)
                .HasPrecision(11, 2);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Cmt)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Coop)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.AcctR)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.InvR)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.ITyp)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Vari)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Ctry)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Reg)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.App)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Mv)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Prem)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Foc)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.FocBm)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Ter)
                .IsUnicode(false);

            modelBuilder.Entity<Web_ActiveUsers>()
                .Property(e => e.RepCode)
                .IsFixedLength();

            modelBuilder.Entity<Web_ActiveUsers>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Web_ActiveUsers>()
                .Property(e => e.ZoomPercent)
                .HasPrecision(18, 0);
        }
    }
}
