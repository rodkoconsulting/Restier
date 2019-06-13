using System.Runtime.InteropServices;

namespace RestierService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ODataInvoices
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string InvNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string Type { get; set; }

        [StringLength(30)]
        public string Item { get; set; }

        [StringLength(30)]
        public string Acct { get; set; }

        [StringLength(25)]
        public string Affiliations { get; set; }

        [StringLength(8000)]
        public string Description { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }

        public decimal? Cases { get; set; }

        public decimal? Price { get; set; }

        public decimal? Total { get; set; }

        [StringLength(30)]
        public string Comment { get; set; }

        [StringLength(10)]
        public string Coop { get; set; }

        [StringLength(4)]
        public string RepAcct { get; set; }

        [StringLength(4)]
        public string RepInv { get; set; }

        [StringLength(20)]
        public string WineType { get; set; }

        [StringLength(25)]
        public string Varietal { get; set; }

        [StringLength(25)]
        public string Country { get; set; }

        [StringLength(25)]
        public string Region { get; set; }

        [StringLength(50)]
        public string Appellation { get; set; }

        [StringLength(25)]
        public string MV { get; set; }

        [StringLength(3)]
        public string Premise { get; set; }

        [StringLength(1)]
        public string Focus { get; set; }

        [StringLength(1)]
        public string FocusBm { get; set; }

        [StringLength(7)]
        public string Territory { get; set; }
    }
}
