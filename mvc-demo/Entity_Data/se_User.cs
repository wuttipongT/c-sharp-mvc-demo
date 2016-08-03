namespace WMS_Web_SCG_CDMA.Entity_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class se_User
    {
        [Key]
        [StringLength(50)]
        public string user_index { get; set; }

        [Required]
        [StringLength(50)]
        public string user_id { get; set; }

        [Required]
        [StringLength(50)]
        public string group_index { get; set; }

        [Required]
        [StringLength(50)]
        public string userName { get; set; }

        [Required]
        [StringLength(50)]
        public string userPasswd { get; set; }

        [StringLength(50)]
        public string userFullName { get; set; }

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

        [StringLength(13)]
        public string Department_Index { get; set; }

        [StringLength(13)]
        public string Customer_Index { get; set; }

        [StringLength(13)]
        public string Supplier_Index { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }

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

        [StringLength(100)]
        public string Str6 { get; set; }

        [StringLength(100)]
        public string Str7 { get; set; }

        [StringLength(100)]
        public string Str8 { get; set; }

        [StringLength(2000)]
        public string Str9 { get; set; }

        [StringLength(2000)]
        public string Str10 { get; set; }

        public double? Flo1 { get; set; }

        public double? Flo2 { get; set; }

        public double? Flo3 { get; set; }

        public double? Flo4 { get; set; }

        public double? Flo5 { get; set; }

        [StringLength(500)]
        public string Image_Path { get; set; }
    }
}
