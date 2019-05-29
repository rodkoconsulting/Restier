namespace RestierService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AR_InvoiceHistoryHeader
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string InvoiceNo { get; set; }

        [StringLength(2)]
        public string InvoiceType { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string HeaderSeqNo { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime InvoiceDate { get; set; }

        [StringLength(3)]
        public string ModuleCode { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime TransactionDate { get; set; }

        [StringLength(2)]
        public string ARDivisionNo { get; set; }

        [StringLength(20)]
        public string CustomerNo { get; set; }

        [StringLength(2)]
        public string SalespersonDivisionNo { get; set; }

        [StringLength(4)]
        public string SalesPersonNo { get; set; }

        [StringLength(30)]
        public string Comment { get; set; }

        [StringLength(10)]
        public string UDF_NJ_COOP { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime InvoiceDueDate { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime DateCreated { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime DateUpdated { get; set; }
    }
}
