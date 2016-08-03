namespace WMS_Web_SCG_CDMA.Entity_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VIEW_Inbound_New
    {
        [Key]
        [Column(Order = 0, TypeName = "smalldatetime")]
        public DateTime GR_DATE { get; set; }

        [StringLength(13)]
        public string PO_No { get; set; }

        [StringLength(50)]
        public string Ref_Doc { get; set; }

        [StringLength(50)]
        public string ProductID { get; set; }

        [StringLength(255)]
        public string ProductName { get; set; }

        public double? Qty { get; set; }

        [StringLength(100)]
        public string Serial_No { get; set; }

        [StringLength(50)]
        public string Engine_Lot { get; set; }

        [StringLength(50)]
        public string GroupSku_Desc { get; set; }

        [StringLength(200)]
        public string ProductType { get; set; }

        [StringLength(100)]
        public string Supplier_Name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Supplier_Id { get; set; }

        [StringLength(50)]
        public string TAG_No { get; set; }

        [StringLength(100)]
        public string Labelling { get; set; }

        [StringLength(100)]
        public string PutOnRack { get; set; }

        [StringLength(50)]
        public string Order_No { get; set; }

        public int? Status { get; set; }

        public int? GroupSku_Index { get; set; }
    }
}
