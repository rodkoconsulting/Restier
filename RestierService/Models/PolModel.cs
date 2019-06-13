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
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Item)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Acct)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Affiliations)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Cases)
                .HasPrecision(15, 6);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Price)
                .HasPrecision(15, 6);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Total)
                .HasPrecision(11, 2);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Coop)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.RepAcct)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.RepInv)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.WineType)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Varietal)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Region)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Appellation)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.MV)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Premise)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Focus)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.FocusBm)
                .IsUnicode(false);

            modelBuilder.Entity<ODataInvoices>()
                .Property(e => e.Territory)
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
