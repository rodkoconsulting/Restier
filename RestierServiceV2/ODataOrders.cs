using System.Runtime.InteropServices;

namespace RestierServiceV2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ODataOrders
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string OrdNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string Typ { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string Item { get; set; }

        [StringLength(30)]
        public string Acct { get; set; }

        [StringLength(5)]
        public string Hold { get; set; }

        [StringLength(25)]
        public string Aff { get; set; }

        [StringLength(8000)]
        public string Desc { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? OrdDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? ShpDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? ExpDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? ArrDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? BoEta { get; set; }

        public decimal? Qty { get; set; }

        public decimal? Pri { get; set; }

        public decimal? Tot { get; set; }

        [StringLength(30)]
        public string Cmt { get; set; }

        [StringLength(30)]
        public string ItmCmt { get; set; }

        [StringLength(10)]
        public string Coop { get; set; }

        [StringLength(4)]
        public string Rep { get; set; }

        [StringLength(3)]
        public string Prem { get; set; }

        [StringLength(3)]
        public string Ter { get; set; }
    }
}
