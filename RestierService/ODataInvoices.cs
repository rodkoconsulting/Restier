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
        public string Typ { get; set; }

        [StringLength(30)]
        public string Item { get; set; }

        [StringLength(30)]
        public string Acct { get; set; }

        [StringLength(25)]
        public string Aff { get; set; }

        [StringLength(8000)]
        public string Desc { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }

        public decimal? Qty { get; set; }

        public decimal? Pri { get; set; }

        public decimal? Tot { get; set; }

        [StringLength(30)]
        public string Cmt { get; set; }

        [StringLength(10)]
        public string Coop { get; set; }

        [StringLength(4)]
        public string AcctR { get; set; }

        [StringLength(4)]
        public string InvR { get; set; }

        [StringLength(20)]
        public string ITyp { get; set; }

        [StringLength(25)]
        public string Vari { get; set; }

        [StringLength(25)]
        public string Ctry { get; set; }

        [StringLength(25)]
        public string Reg { get; set; }

        [StringLength(50)]
        public string App { get; set; }

        [StringLength(25)]
        public string Mv { get; set; }

        [StringLength(3)]
        public string Prem { get; set; }

        [StringLength(1)]
        public string Foc { get; set; }

        [StringLength(1)]
        public string FocBm { get; set; }

        [StringLength(7)]
        public string Ter { get; set; }
    }
}
