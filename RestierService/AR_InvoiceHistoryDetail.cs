namespace RestierService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AR_InvoiceHistoryDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string InvoiceNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string HeaderSeqNo { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string DetailSeqNo { get; set; }

        [StringLength(30)]
        public string ItemCode { get; set; }

        [StringLength(30)]
        public string ItemCodeDesc { get; set; }

        [StringLength(1)]
        public string ItemType { get; set; }

        [StringLength(3)]
        public string WarehouseCode { get; set; }

        [StringLength(4)]
        public string UnitOfMeasure { get; set; }

        public decimal? QuantityShipped { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? UnitCost { get; set; }

        public decimal? ExtensionAmt { get; set; }

        [StringLength(9)]
        public string CostOfGoodsSoldAcctKey { get; set; }
    }
}
