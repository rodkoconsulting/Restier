namespace RestierService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AR_Customer
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string ARDivisionNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CustomerNo { get; set; }

        [StringLength(30)]
        public string CustomerName { get; set; }

        [StringLength(4)]
        public string CustomerType { get; set; }

        [StringLength(2)]
        public string SalespersonDivisionNo { get; set; }

        [StringLength(4)]
        public string SalespersonNo { get; set; }

        [StringLength(4)]
        public string PrimaryShipToCode { get; set; }

        [StringLength(10)]
        public string SortField { get; set; }

        [StringLength(2)]
        public string TermsCode { get; set; }

        [StringLength(1)]
        public string PriceLevel { get; set; }

        [StringLength(15)]
        public string SHIPMETHOD { get; set; }

        public decimal? AgingCategory1 { get; set; }

        public decimal? AgingCategory2 { get; set; }

        public decimal? AgingCategory3 { get; set; }

        public decimal? AgingCategory4 { get; set; }

        public decimal? CURRENTBALANCE { get; set; }

        [StringLength(1)]
        public string CREDITHOLD { get; set; }

        public decimal? CREDITLIMIT { get; set; }

        public decimal? OPENORDERAMT { get; set; }

        [StringLength(22)]
        public string UDF_ACCOUNT_TYPE { get; set; }

        [StringLength(20)]
        public string UDF_LICENSE_NUM { get; set; }

        [StringLength(25)]
        public string UDF_AFFILIATIONS { get; set; }

        [StringLength(15)]
        public string UDF_GROWTH_POTENTIAL { get; set; }

        [StringLength(25)]
        public string UDF_STORE_REST_FOCUS { get; set; }

        [StringLength(55)]
        public string UDF_OTHER_KEY_SUPPLIERS { get; set; }

        [StringLength(1)]
        public string UDF_CUST_ACTIVE_STAT { get; set; }

        public DateTime? UDF_LIC_EXPIRATION { get; set; }

        [StringLength(1)]
        public string UDF_CERT_ON_FILE { get; set; }

        [StringLength(1)]
        public string UDF_PERM_SPEC_DELIV { get; set; }

        [StringLength(25)]
        public string UDF_WINE_BUYER { get; set; }

        [StringLength(25)]
        public string UDF_WINE_BUYER_2 { get; set; }

        [StringLength(25)]
        public string UDF_WINE_BUYER_3 { get; set; }

        [StringLength(20)]
        public string UDF_WINE_BUYER_PHONE { get; set; }

        [StringLength(20)]
        public string UDF_WINE_BUYER_PHONE_2 { get; set; }

        [StringLength(20)]
        public string UDF_WINE_BUYER_PHONE_3 { get; set; }

        [StringLength(40)]
        public string UDF_WINE_BUYER_EMAIL { get; set; }

        [StringLength(40)]
        public string UDF_WINE_BUYER_2_EMAIL { get; set; }

        [StringLength(40)]
        public string UDF_WINE_BUYER_3_EMAIL { get; set; }

        [StringLength(1)]
        public string UDF_PO_REQUIRED { get; set; }

        [StringLength(40)]
        public string UDF_NJ_COOP { get; set; }

        [StringLength(40)]
        public string UDF_PREMISIS_ADDRESS_LINE_1 { get; set; }

        [StringLength(40)]
        public string UDF_PREMISIS_ADDRESS_LINE_2 { get; set; }

        [StringLength(40)]
        public string UDF_PREMISIS_CITY { get; set; }

        [StringLength(2)]
        public string UDF_PREMISIS_STATE { get; set; }

        [StringLength(10)]
        public string UDF_PREMISIS_ZIP { get; set; }

        [StringLength(50)]
        public string UDF_REP_EMAIL_ADDRESS { get; set; }

        [StringLength(5)]
        public string DefaultPaymentType { get; set; }
    }
}
