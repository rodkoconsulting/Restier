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

        public virtual DbSet<ODataInvoices> ODataInvoices { get; set; }
        public virtual DbSet<Web_ActiveUsers> Web_ActiveUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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
