namespace WMS_Web_SCG_CDMA.Entity_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class VIEW_OUTBOUND_NEW1
    {
        [Key]
        [Column(Order = 0, TypeName = "smalldatetime")]
        public DateTime GI_Date { get; set; }

        [StringLength(50)]
        public string Shipment_No { get; set; }

        [StringLength(50)]
        public string SO { get; set; }

        [StringLength(100)]
        public string ProductID { get; set; }

        [StringLength(100)]
        public string SerialNo { get; set; }
        [StringLength(50)]
        public string Lot_Engine { get; set; }

        [StringLength(255)]
        public string ProductName { get; set; }
        public double? Qty { get; set; }
        [StringLength(13)]
        public string License { get; set; }

        [StringLength(15)]
        public string Shipto { get; set; }

        [StringLength(200)]
        public string ShiptoName { get; set; }

  
        [StringLength(13)]
        public string OnRack { get; set; }

        [StringLength(200)]
        public string TruckType { get; set; }

        [StringLength(100)]
        public string CarrierName { get; set; }

        [StringLength(510)]
        public string Driver_name { get; set; }

        [StringLength(200)]
        public string Tel { get; set; }
        [StringLength(50)]
        public string ProductType_Id { get; set; }
        [StringLength(500)]
        public string Producttype { get; set; }
        [StringLength(50)]
        public string GroupSku_Name { get; set; }
        [StringLength(50)]
        public string Withdraw_No { get; set; }
        [StringLength(50)]
        public string Tag_No { get; set; }
        public int? GroupSku_Index { get; set; }
        [StringLength(13)]
        public string SalesOrder_Index { get; set; }
        [StringLength(13)]
        public string WithdrawItemLocation_Index { get; set; }
        public int? Status { get; set; }
        [StringLength(13)]
        public string Customer_Shipping_Location_Index { get; set; }
        [StringLength(200)]
        public string Route { get; set; }
    }
}
