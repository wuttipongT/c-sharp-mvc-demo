namespace WMS_Web_SCG_CDMA.Entity_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class tb_SalesOrder
    {
        [Key]
        [StringLength(13)]
        public string SalesOrder_Index { get; set; }

        [StringLength(50)]
        public string SalesOrder_No { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SalesOrder_Date { get; set; }

        [StringLength(13)]
        public string Carrier_Index { get; set; }

        [StringLength(13)]
        public string Customer_Receive_Location_Index { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Expected_Delivery_Date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Time_ExpectedDocPickup { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Time_DocPickup { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Delivery_Date { get; set; }

        [StringLength(13)]
        public string Customer_Shipping_Index { get; set; }

        [StringLength(13)]
        public string Department_Index { get; set; }

        [StringLength(13)]
        public string DocumentType_Index { get; set; }

        [StringLength(255)]
        public string Remark { get; set; }

        [StringLength(10)]
        public string Credit_Term { get; set; }

        [StringLength(13)]
        public string Currency_Index { get; set; }

        public double? Exchange_Rate { get; set; }

        [StringLength(13)]
        public string PaymentMethod_Index { get; set; }

        [StringLength(50)]
        public string Payment_Ref { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FullPaid_Date { get; set; }

        public double? Amount { get; set; }

        public int? Discount_Percent { get; set; }

        public double? Discount_Amt { get; set; }

        public double? Deposit_Amt { get; set; }

        public double? Total_Amt { get; set; }

        public int? VAT_Percent { get; set; }

        public double? VAT { get; set; }

        public double? Net_Amt { get; set; }

        [StringLength(13)]
        public string Reserve_index { get; set; }

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

        [StringLength(50)]
        public string cancel_by { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? cancel_date { get; set; }

        public int? cancel_branch { get; set; }

        public int? Status { get; set; }

        [StringLength(13)]
        public string Salesman_Index { get; set; }

        [StringLength(13)]
        public string Sales_Region_Index { get; set; }

        [StringLength(13)]
        public string Promotion_Index { get; set; }

        [StringLength(13)]
        public string CommissionGroup_Index { get; set; }

        [StringLength(13)]
        public string Supplier_Index { get; set; }

        [StringLength(13)]
        public string Customer_Index { get; set; }

        [StringLength(13)]
        public string Customer_Shipping_Location_Index { get; set; }

        [StringLength(13)]
        public string DistributionCenter_Index { get; set; }

        [StringLength(13)]
        public string SubRoute_Index { get; set; }

        [StringLength(13)]
        public string Route_Index { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Time_DocTripConfirmed { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Time_DeliveryToDestination { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Time_DocReturnedToDC { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Time_DocReturnedToSource { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Time_DocReturnedToOwner { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Time_DocConfirmedByOwner { get; set; }

        [StringLength(100)]
        public string Transport_Status { get; set; }

        public bool? chk_Problem { get; set; }

        [StringLength(13)]
        public string JobProblem_Index { get; set; }

        [StringLength(500)]
        public string JobProblem_Desc { get; set; }

        [StringLength(13)]
        public string ResponsibleParty_Index { get; set; }

        [StringLength(13)]
        public string JobSolution_Index { get; set; }

        [StringLength(500)]
        public string JobSolution_Desc { get; set; }

        public int? Process_Id { get; set; }

        public int? Status_Manifest { get; set; }

        [StringLength(50)]
        public string PO_No { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PO_Date { get; set; }

        [StringLength(15)]
        public string Saletype_Id { get; set; }

        [StringLength(15)]
        public string Shipby_Id { get; set; }

        public int? Worker { get; set; }

        [StringLength(13)]
        public string District_Index { get; set; }

        [StringLength(13)]
        public string Province_Index { get; set; }

        [StringLength(13)]
        public string VehicleType_Index { get; set; }

        [StringLength(1000)]
        public string PODRemark1 { get; set; }

        [StringLength(500)]
        public string PODDoc_Copy1 { get; set; }

        [StringLength(500)]
        public string PODDoc_Copy2 { get; set; }

        [StringLength(500)]
        public string PODDoc_Copy3 { get; set; }

        [StringLength(500)]
        public string PODDoc_Copy4 { get; set; }

        [StringLength(500)]
        public string PODDoc_Copy5 { get; set; }

        [StringLength(500)]
        public string GRRemark1 { get; set; }

        [StringLength(500)]
        public string GRDoc_Copy1 { get; set; }

        [StringLength(500)]
        public string GRDoc_Copy2 { get; set; }

        [StringLength(500)]
        public string GRDoc_Copy3 { get; set; }

        [StringLength(500)]
        public string GRDoc_Copy4 { get; set; }

        [StringLength(500)]
        public string GRDoc_Copy5 { get; set; }

        [StringLength(500)]
        public string Dock { get; set; }

        public int? Mile_AtSource { get; set; }

        public int? Mile_AtDestination { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Time_DestinationOutGate { get; set; }

        [StringLength(13)]
        public string TransportRegion_Index { get; set; }

        [StringLength(13)]
        public string DocumentPlanTO { get; set; }

        public bool? IsTransportPaid { get; set; }

        public bool? IsTransportCharged { get; set; }

        public int? Status_Pack { get; set; }

        public double? Total_Qty_Pack { get; set; }

        [StringLength(50)]
        public string TransportManifest_No { get; set; }

        [StringLength(13)]
        public string TransportManifest_Index { get; set; }
    }
}
