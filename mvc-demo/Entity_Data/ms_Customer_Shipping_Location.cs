namespace WMS_Web_SCG_CDMA.Entity_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class ms_Customer_Shipping_Location
    {
        [Key]
        [StringLength(13)]
        public string Customer_Shipping_Location_Index { get; set; }

        [StringLength(15)]
        public string Customer_Shipping_Location_Id { get; set; }

        [StringLength(13)]
        public string Route_Index { get; set; }

        [StringLength(13)]
        public string Customer_Shipping_Index { get; set; }

        [StringLength(100)]
        public string Shipping_Location_Name { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(13)]
        public string District_Index { get; set; }

        [StringLength(13)]
        public string Province_Index { get; set; }

        [StringLength(100)]
        public string Postcode { get; set; }

        [StringLength(100)]
        public string Tel { get; set; }

        [StringLength(100)]
        public string Fax { get; set; }

        [StringLength(100)]
        public string Mobile { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public int? AmtWH { get; set; }

        [StringLength(100)]
        public string Contact_Person1 { get; set; }

        [StringLength(100)]
        public string Contact_Person2 { get; set; }

        [StringLength(100)]
        public string Contact_Person3 { get; set; }

        [StringLength(255)]
        public string Remark { get; set; }

        [StringLength(100)]
        public string Str1 { get; set; }

        [StringLength(100)]
        public string Str2 { get; set; }

        [StringLength(100)]
        public string Str3 { get; set; }

        [StringLength(100)]
        public string Str4 { get; set; }

        [StringLength(100)]
        public string Str5 { get; set; }

        [StringLength(255)]
        public string Str6 { get; set; }

        [StringLength(100)]
        public string Str7 { get; set; }

        [StringLength(100)]
        public string Str8 { get; set; }

        [StringLength(2000)]
        public string Str9 { get; set; }

        [StringLength(2000)]
        public string Str10 { get; set; }

        [StringLength(2000)]
        public string DayIndex { get; set; }

        [StringLength(50)]
        public string add_by { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? add_date { get; set; }

        public int? add_branch { get; set; }

        [StringLength(50)]
        public string update_by { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? update_date { get; set; }

        public int? update_branch { get; set; }

        public int? status_id { get; set; }

        public int? isBangkok { get; set; }

        [StringLength(50)]
        public string SubRoute_Index { get; set; }

        [StringLength(13)]
        public string TransportRegion_Index { get; set; }
    }
}
