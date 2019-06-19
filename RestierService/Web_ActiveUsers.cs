namespace RestierService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_ActiveUsers
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string AccountType { get; set; }

        [StringLength(4)]
        public string RepCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string State { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal ZoomPercent { get; set; }
    }
}