namespace WMS_Web_SCG_CDMA.Entity_Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.SqlClient;
    using System.Configuration;
    public partial class WMS_Site_SCG_KUBOTA_DCT_Model : DbContext
    {
        public static String WV_ConnectionString = String.Empty;
        public WMS_Site_SCG_KUBOTA_DCT_Model()
            //: base("name=ConnectionString")
        {


            WMS_Site_SCG_KUBOTA_DCT_Model.WV_ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            this.Database.Connection.ConnectionString = WMS_Site_SCG_KUBOTA_DCT_Model.WV_ConnectionString;
        }

        public void setConnectionString() {
            this.Database.Connection.ConnectionString = WMS_Site_SCG_KUBOTA_DCT_Model.WV_ConnectionString;
        }

        public virtual DbSet<se_User> se_User { get; set; }
        public virtual DbSet<VIEW_Inbound_New> VIEW_Inbound_New { get; set; }
        public virtual DbSet<ms_GroupSku> ms_GroupSku { get; set; }
        //public virtual DbSet<ms_Customer_Shipping_Location> ms_Customer_Shipping_Location { get; set; }
        //public virtual DbSet<tb_SalesOrder> tb_SalesOrder { get; set; }

        public virtual DbSet<VIEW_OUTBOUND_NEW1> VIEW_OUTBOUND_NEW1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<se_User>()
                .Property(e => e.user_index)
                .IsUnicode(false);

            modelBuilder.Entity<se_User>()
                .Property(e => e.user_id)
                .IsUnicode(false);

            modelBuilder.Entity<se_User>()
                .Property(e => e.group_index)
                .IsUnicode(false);

            modelBuilder.Entity<se_User>()
                .Property(e => e.userName)
                .IsUnicode(false);

            modelBuilder.Entity<se_User>()
                .Property(e => e.userPasswd)
                .IsUnicode(false);

            modelBuilder.Entity<se_User>()
                .Property(e => e.userFullName)
                .IsUnicode(false);

            modelBuilder.Entity<se_User>()
                .Property(e => e.add_by)
                .IsUnicode(false);

            modelBuilder.Entity<se_User>()
                .Property(e => e.update_by)
                .IsUnicode(false);

            modelBuilder.Entity<se_User>()
                .Property(e => e.Department_Index)
                .IsUnicode(false);

            modelBuilder.Entity<se_User>()
                .Property(e => e.Customer_Index)
                .IsUnicode(false);

            modelBuilder.Entity<se_User>()
                .Property(e => e.Supplier_Index)
                .IsUnicode(false);

            modelBuilder.Entity<se_User>()
                .Property(e => e.Image_Path)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_Inbound_New>()
                .Property(e => e.PO_No)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_Inbound_New>()
                .Property(e => e.Ref_Doc)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_Inbound_New>()
                .Property(e => e.GroupSku_Desc)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_Inbound_New>()
                .Property(e => e.Supplier_Id)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_Inbound_New>()
                .Property(e => e.TAG_No)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_Inbound_New>()
                .Property(e => e.Order_No)
                .IsUnicode(false);

            modelBuilder.Entity<ms_GroupSku>()
                .Property(e => e.GroupSku_Index);
               

            modelBuilder.Entity<ms_GroupSku>()
                .Property(e => e.GroupSku_Name)
                .IsUnicode(false);

            modelBuilder.Entity<ms_GroupSku>()
                .Property(e => e.GroupSku_Des)
                .IsUnicode(false);

            //modelBuilder.Entity<ms_Customer_Shipping_Location>()
            //   .Property(e => e.Customer_Shipping_Location_Index)
            //   .IsUnicode(false);

            //modelBuilder.Entity<ms_Customer_Shipping_Location>()
            //    .Property(e => e.Customer_Shipping_Location_Id)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ms_Customer_Shipping_Location>()
            //    .Property(e => e.Route_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ms_Customer_Shipping_Location>()
            //    .Property(e => e.Customer_Shipping_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ms_Customer_Shipping_Location>()
            //    .Property(e => e.District_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ms_Customer_Shipping_Location>()
            //    .Property(e => e.Province_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ms_Customer_Shipping_Location>()
            //    .Property(e => e.add_by)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ms_Customer_Shipping_Location>()
            //    .Property(e => e.update_by)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ms_Customer_Shipping_Location>()
            //    .Property(e => e.SubRoute_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ms_Customer_Shipping_Location>()
            //    .Property(e => e.TransportRegion_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.SalesOrder_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.SalesOrder_No)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.Carrier_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.Customer_Receive_Location_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.Customer_Shipping_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.Department_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.DocumentType_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.Currency_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.add_by)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.update_by)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.cancel_by)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.Salesman_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.Sales_Region_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.Promotion_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.CommissionGroup_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.Supplier_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.Customer_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.Customer_Shipping_Location_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.DistributionCenter_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.SubRoute_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.Route_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.Transport_Status)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.JobProblem_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.JobProblem_Desc)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.ResponsibleParty_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.JobSolution_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.JobSolution_Desc)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.PO_No)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.Saletype_Id)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.Shipby_Id)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.District_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.Province_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.VehicleType_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.PODRemark1)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.PODDoc_Copy1)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.PODDoc_Copy2)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.PODDoc_Copy3)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.PODDoc_Copy4)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.PODDoc_Copy5)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.GRRemark1)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.GRDoc_Copy1)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.GRDoc_Copy2)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.GRDoc_Copy3)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.GRDoc_Copy4)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.GRDoc_Copy5)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.Dock)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.TransportRegion_Index)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.DocumentPlanTO)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.TransportManifest_No)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_SalesOrder>()
            //    .Property(e => e.TransportManifest_Index)
            //    .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTBOUND_NEW1>()
                .Property(e => e.Shipment_No)
                .IsUnicode(false);
        }
    }
}
