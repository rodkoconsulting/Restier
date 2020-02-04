namespace RestierServiceV2
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

        [StringLength(10)]
        public string AccountType { get; set; }

        [StringLength(4)]
        public string RepCode { get; set; }

        [StringLength(2)]
        public string State { get; set; }
    }
}
