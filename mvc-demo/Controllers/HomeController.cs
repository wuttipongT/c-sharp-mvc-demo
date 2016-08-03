using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WMS_Web_SCG_CDMA.Entity_Data;
using WMS_Web_SCG_CDMA.Models;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.IO;
//using WMS_Web_SCG_CDMA.Entity_Data;
namespace WMS_Web_SCG_CDMA.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        WMS_Site_SCG_KUBOTA_DCT_Model db = new WMS_Site_SCG_KUBOTA_DCT_Model();
        List<VIEW_Inbound_New> Inbound = new List<VIEW_Inbound_New>();
        List<VIEW_OUTBOUND_NEW1> OUTBOUND = new List<VIEW_OUTBOUND_NEW1>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ServiceCharge(int id) {
            string _view = "DiskRotary";
            if (id == 1)
            {
                _view = "DiskRotary";
            }
            else if (id == 2) {
                _view = "Other";
            }
            return PartialView(_view);
        }

        public ActionResult ExtraCharge()
        {
            return PartialView();
        }
        public ActionResult ChargeSummary() {
            return PartialView();
        }

        public ActionResult ExportData(int id) {

            

            DateTime now = DateTime.Now;
            SortingPagingInfo info = new SortingPagingInfo();
            
            var startDate = new DateTime(now.Year, now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            string strSQL = string.Empty;
            string strWhere = string.Empty;

            if (id == 1)//GR
            {
                string GRStartDate = startDate.ToString("yyyy/MM/dd");//String.Format("{ 0:yyyy/MM/dd}", );
                string GREndDate = endDate.ToString("yyyy/MM/dd");//String.Format("{ 0:yyyy/MM/dd}", endDate);

                strWhere = " AND (Convert ( DateTime ,Convert(NVARCHAR(4) , year(GR_Date)) + '/' + " +
                           " Convert(NVARCHAR(2) , Month(GR_Date)) + '/'  + Convert(NVARCHAR(2) , day(GR_Date))) " +
                           " BETWEEN '" + GRStartDate + "' AND  '" + GREndDate + "' ) ";

                strSQL = " SELECT * FROM dbo.VIEW_INBOUND_NEW WHERE 1=1 ";
                var q = db.VIEW_Inbound_New.SqlQuery(strSQL + strWhere);
                //  var q = db.VIEW_Inbound_New;

                info.PageNumber = 1;
                info.ItemPerPage = 20;
                info.TotalRows = Convert.ToInt32(q.Count());
                info.TotalPages = (int)Math.Ceiling((decimal)(info.TotalRows / info.ItemPerPage));
                info.PagePosition = ((info.PageNumber - 1) * info.ItemPerPage);
                ViewData["SortingPagingInfo"] = info;


                var ms_GroupSku = (from m in db.ms_GroupSku orderby m.GroupSku_Index select m);
                ViewData["ms_GroupSku"] = ms_GroupSku;
                //var GroupSku = (from p in Model.ms_GroupSku orderby p.GroupSku_Index select p);

                

                Inbound = q.OrderBy(v => v.GR_DATE).Skip(info.PagePosition).Take(info.ItemPerPage).ToList();
                //Response.AddHeader("Content-Length", Convert.ToString(info.TotalRows));

            }
            else if (id == 2)
            {//GI
                string GIStartDate = startDate.ToString("yyyy/MM/dd");
                string GIEndDate = endDate.ToString("yyyy/MM/dd");

                strWhere = " AND (Convert ( DateTime ,Convert(NVARCHAR(4) , year(GI_Date)) + '/' + Convert(NVARCHAR(2) , " +
                           " Month(GI_Date)) + '/'  + Convert(NVARCHAR(2) , day(GI_Date))) between '" + GIStartDate + "' and  '" + GIEndDate + "' )";
                strSQL = " SELECT * FROM VIEW_OUTBOUND_NEW1 WHERE 1=1 ";
                var q = db.VIEW_OUTBOUND_NEW1.SqlQuery(strSQL + strWhere);

                info.PageNumber = 1;
                info.ItemPerPage = 20;
                info.TotalRows = Convert.ToInt32(q.Count());
                info.TotalPages = (int)Math.Ceiling((decimal)(info.TotalRows / info.ItemPerPage));
                info.PagePosition = ((info.PageNumber - 1) * info.ItemPerPage);
                ViewData["SortingPagingInfo"] = info;

                var ms_GroupSku = (from m in db.ms_GroupSku orderby m.GroupSku_Index select m);
                ViewData["ms_GroupSku"] = ms_GroupSku;

              

                OUTBOUND = q.OrderBy(v => v.GI_Date).Skip(info.PagePosition).Take(info.ItemPerPage).ToList();
                //Response.AddHeader("Content-Length", Convert.ToString(info.TotalRows));
                //HttpContext.Response.AddHeader("Content-Length", file.Length.ToString());
            }
            ViewBag.Page = id;
            var Models = new Tuple<List<VIEW_Inbound_New>,
                                    List<VIEW_OUTBOUND_NEW1>>(Inbound, OUTBOUND)
            { };

            return PartialView(Models);
        }

        [HttpPost]
        public ActionResult ExportData(int id,SortingPagingInfo info, Export Me) {

           // IQueryable<VIEW_Inbound_New> q = null;
 
            info.PagePosition = ((info.PageNumber - 1) * info.ItemPerPage);
            // ViewBag.SortingPagingInfo = info;
            ViewData["SortingPagingInfo"] = info;
            //List<ms_GroupSku> ms_GroupSku = new List<ms_GroupSku>();
            //ms_GroupSku = (from m in db.ms_GroupSku orderby m.GroupSku_Index select m).ToList();
            //ViewBag.ms_GroupSku = ms_GroupSku;


            //string startDate = frm.dtpGR.Split(new String[] { "-" }, StringSplitOptions.None)[0];
            // var endDate = frm.dtpGR.Split(new String[] { "-" }, StringSplitOptions.None)[1];
            
            
            string strWhere = "";

            if (id == 1) {

                if (Me.chkGR && Me.dtpGR != null) {
                    string GIStartDate = Me.dtpGR.Split(new String[] { "-" }, StringSplitOptions.None)[0];
                    string GIEndtDate = Me.dtpGR.Split(new String[] { "-" }, StringSplitOptions.None)[1];

                    strWhere += "AND (Convert ( DateTime ,Convert(NVARCHAR(4) , year(GR_Date)) + '/' + " +
                              "Convert(NVARCHAR(2) , Month(GR_Date)) + '/'  + Convert(NVARCHAR(2) , day(GR_Date))) " +
                              " BETWEEN '" + GIStartDate + "' AND  '" + GIEndtDate + "' )";
                }

                if (Me.chkPO) {
                    strWhere += String.Format("AND PO_No = '{0}'", Me.txtPO);
                }

                if (Me.chkGroup) {
                    strWhere += String.Format("AND GroupSku_Index = '{0}'", Me.cboGroup);
                }

                string strSQL = " SELECT * FROM dbo.VIEW_INBOUND_NEW WHERE 1=1 ";
                var q = db.VIEW_Inbound_New.SqlQuery(strSQL + strWhere);
                Inbound = q.OrderBy(v => v.GR_DATE).Skip(info.PagePosition).Take(info.ItemPerPage).ToList();

                

            } else if (id == 2) {
                if (Me.chkGI && Me.dtpGI != null)
                {
                    string GIStartDate = Me.dtpGI.Split(new String[] { "-" }, StringSplitOptions.None)[0];
                    string GIEndDate = Me.dtpGI.Split(new String[] { "-" }, StringSplitOptions.None)[1];

                    strWhere = " AND (Convert ( DateTime ,Convert(NVARCHAR(4) , year(GI_Date)) + '/' + Convert(NVARCHAR(2) , " +
                           " Month(GI_Date)) + '/'  + Convert(NVARCHAR(2) , day(GI_Date))) between '" + GIStartDate + "' and  '" + GIEndDate + "' )";
                }

                if (Me.txtShipment_No != "") {
                    strWhere += " AND Shipment_No = '" + Me.txtShipment_No + "'";
                }

                if (Me.chkShipment && Me.cboDN != "") {
                    strWhere += " AND SalesOrder_Index= '" + Me.cboDN + "'";
                }

                if (Me.chkShipTo && Me.cboShipTo != "") {
                    strWhere += " AND Customer_Shipping_Location_Index= '" + Me.cboShipTo + "'";
                }

                if (Me.chkGroup && Me.cboGroup != "") {
                    strWhere += " AND GroupSku_Index = '" + Me.cboGroup + "'";
                }

                string strSQL = " SELECT * FROM dbo.VIEW_OUTBOUND_NEW1 WHERE 1=1 ";
                var q = db.VIEW_OUTBOUND_NEW1.SqlQuery(strSQL + strWhere);
                OUTBOUND = q.OrderBy(v => v.GI_Date).Skip(info.PagePosition).Take(info.ItemPerPage).ToList();
            }

            ViewBag.Page = id;
            var Models = new Tuple<List<VIEW_Inbound_New>,
                                    List<VIEW_OUTBOUND_NEW1>>(Inbound, OUTBOUND)
            { };
            return PartialView(Models);
        }

        [HttpGet]
        public string AddcbShipTo(string pstrShipment_No)
        {
            string strSQL = " SELECT  dbo.tb_SalesOrder.TransportManifest_No, dbo.ms_Customer_Shipping_Location.Shipping_Location_Name, ";
            strSQL += " dbo.ms_Customer_Shipping_Location.Customer_Shipping_Location_Id, dbo.ms_Customer_Shipping_Location.Customer_Shipping_Location_Index ";
            strSQL += " FROM  dbo.tb_SalesOrder INNER JOIN ";
            strSQL += " dbo.ms_Customer_Shipping_Location ON ";
            strSQL += " dbo.tb_SalesOrder.Customer_Shipping_Location_Index = dbo.ms_Customer_Shipping_Location.Customer_Shipping_Location_Index ";
            strSQL += " where 1=1 and status <> -1 and TransportManifest_No = '"+ pstrShipment_No + "' ";
            strSQL += " GROUP BY dbo.tb_SalesOrder.TransportManifest_No, dbo.ms_Customer_Shipping_Location.Shipping_Location_Name, ";
            strSQL += " dbo.ms_Customer_Shipping_Location.Customer_Shipping_Location_Id, dbo.ms_Customer_Shipping_Location.Customer_Shipping_Location_Index ";


            //using (var db = new MyContext())
            //{
            //    var dbRecord = db.MyTable.Where(t => t.keyid == keyid).FirstOrDefault();

            //    if (dbRecord != null)
            //    {
            //        oldval = dbRecord.TheValue;
            //        dbRecord.TheValue = newval;
            //        db.SaveChanges();
            //    }
            //}
            string strJSON = string.Empty;
            DataTable data = GetDataFromQuery(strSQL);
            DataRow dr = data.NewRow();
            dr["Customer_Shipping_Location_Index"] = "";
            dr["Customer_Shipping_Location_Id"] = "--- ไม่ระบุ ---";
            data.Rows.InsertAt(dr, 0);
            strJSON = JsonConvert.SerializeObject(data);
            return strJSON;
            //return Json(new { success = true, oldval = oldval },
            //            JsonRequestBehavior.AllowGet);
        }
        public string AddcbDN(string pstrShipment_No) {
            string strJSON = "";
            string strSQL = " SELECT * FROM tb_salesorder  where 1=1 and status <> -1 and TransportManifest_No = '" + pstrShipment_No + "' ";
            DataTable data = GetDataFromQuery(strSQL);
            DataRow dr = data.NewRow();
            dr["SalesOrder_Index"] = "";
            dr["SalesOrder_No"] = "--- ไม่ระบุ ---";
            data.Rows.InsertAt(dr, 0);
            strJSON = JsonConvert.SerializeObject(data);
            return strJSON;
        }
        DataTable GetDataFromQuery(string query)
        {
            SqlDataAdapter adap =
                 new SqlDataAdapter(query, WMS_Site_SCG_KUBOTA_DCT_Model.WV_ConnectionString);
            DataTable data = new DataTable();
            adap.Fill(data);
            return data;
        }

        [HttpGet]
       
        public void ExportDataReceive() {

            //var data = db.ms_GroupSku;
            //string xml = String.Empty;

            //XmlDocument xmlDoc = new XmlDocument();

            //XmlSerializer xmlSerializer = new XmlSerializer();

            //using (System.IO.MemoryStream xmlStream = new System.IO.MemoryStream()) {
            //    xmlSerializer.Serialize(xmlStream, data);
            //    xmlStream.Position = 0;
            //    xmlDoc.Load(xmlStream);
            //    xml = xmlDoc.InnerXml;
            //}

            //var fName = String.Format("GroupSku-{0}", DateTime.Now.ToString("s"));
            //byte[] fileContents = Encoding.UTF8.GetBytes(xml);

            //return File(fileContents, "application/vnd.ms-excel", fName);
            // var fName = String.Format("Data Receive SKU Qty-{0}", DateTime.Now.ToString("s"));
            //string strSQL = " SELECT * FROM dbo.VIEW_INBOUND_NEW WHERE 1=1 ";
            //string strWhere = "";
            //strWhere += " AND Shipment_No = '" + Shipment_No + "'";
            //var q = db.VIEW_OUTBOUND_NEW1.SqlQuery(strSQL + strWhere);
            //OUTBOUND = q.OrderBy(v => v.GI_Date).ToList();
     
            string txtPO = Request.QueryString["txtPO"];
            string dtpGR = Request.QueryString["dtpGR"];
            string cboGroup = Request.QueryString["cboGroup"];
            string strWhere = String.Empty;
            if (dtpGR != "")
            {
                string StartDate = dtpGR.Split(new String[] { "-" }, StringSplitOptions.None)[0];
                string EndtDate = dtpGR.Split(new String[] { "-" }, StringSplitOptions.None)[1];

                strWhere += "AND (Convert ( DateTime ,Convert(NVARCHAR(4) , year(GR_Date)) + '/' + " +
                          "Convert(NVARCHAR(2) , Month(GR_Date)) + '/'  + Convert(NVARCHAR(2) , day(GR_Date))) " +
                          " BETWEEN '" + StartDate + "' AND  '" + EndtDate + "' )";
            }

            if (txtPO != "")
            {
                strWhere += String.Format("AND PO_No = '{0}'", txtPO);
            }

            if (cboGroup != "")
            {
                strWhere += String.Format("AND GroupSku_Index = '{0}'", cboGroup);
            }

            string strSQL = " SELECT TOP 500 * FROM dbo.VIEW_INBOUND_NEW WHERE 1=1 ";
            var q = db.VIEW_Inbound_New.SqlQuery(strSQL + strWhere);
            Inbound = q.OrderBy(v => v.GR_DATE).ToList();
            var fName = String.Format("GroupSku-{0}", DateTime.Now.ToString("s"));
            GridView gv = new GridView();
            gv.DataSource = Inbound;
            gv.DataBind();
            Response.Clear();
            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment; filename=" + fName + ".xls");
            Response.ContentType = "application/ms-excel";
            Response.ContentEncoding = System.Text.Encoding.Unicode;
            Response.BinaryWrite(System.Text.Encoding.Unicode.GetPreamble());
            Response.Charset = "utf-8";
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            gv.RenderControl(htw);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
            
        }

        public void ExportDataDispatch()
        {
            string dtpGI = Request.QueryString["dtpGI"];
            string cboGroup = Request.QueryString["cboGroup"];
            string cboShipTo = Request.QueryString["cboShipTo"];
            string cboDN = Request.QueryString["cboDN"];
            string txtShipment = Request.QueryString["txtShipment "];
            string strWhere = String.Empty;
            if (dtpGI != "")
            {
                string StartDate = dtpGI.Split(new String[] { "-" }, StringSplitOptions.None)[0];
                string EndDate = dtpGI.Split(new String[] { "-" }, StringSplitOptions.None)[1];

                strWhere = " AND (Convert ( DateTime ,Convert(NVARCHAR(4) , year(GI_Date)) + '/' + Convert(NVARCHAR(2) , " +
                       " Month(GI_Date)) + '/'  + Convert(NVARCHAR(2) , day(GI_Date))) between '" + StartDate + "' and  '" + EndDate + "' )";
            }

            if (txtShipment != "")
            {
                strWhere += " AND Shipment_No = '" + txtShipment + "'";
            }

            if (cboDN != "")
            {
                strWhere += " AND SalesOrder_Index= '" + cboDN + "'";
            }

            if (cboShipTo != "")
            {
                strWhere += " AND Customer_Shipping_Location_Index= '" + cboShipTo + "'";
            }

            if (cboGroup != "")
            {
                strWhere += " AND GroupSku_Index = '" + cboGroup + "'";
            }

            string strSQL = " SELECT TOP 500 * FROM dbo.VIEW_OUTBOUND_NEW1 WHERE 1=1 ";
            var q = db.VIEW_OUTBOUND_NEW1.SqlQuery(strSQL + strWhere);
            OUTBOUND = q.OrderBy(v => v.GI_Date).ToList();

            var fName = String.Format("Data Dispatch-{0}", DateTime.Now.ToString("s"));
            GridView gv = new GridView();
            gv.DataSource = OUTBOUND;
            gv.DataBind();
            Response.Clear();
            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment; filename=" + fName + ".xls");
            Response.ContentType = "application/ms-excel";
            Response.ContentEncoding = System.Text.Encoding.Unicode;
            Response.BinaryWrite(System.Text.Encoding.Unicode.GetPreamble());
            Response.Charset = "utf-8";
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            gv.RenderControl(htw);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
        }
        [HttpGet]
        [GZipOrDeflate]
        public ActionResult test() {
           
           // Response.AddHeader("Content-Length", "10000");
           // Response.AppendHeader("Content-Length", "1000");
           // byte[] s = Encoding.UTF8.GetBytes("1000");
           // Response.AddHeader("Content-Length", s.Length.ToString());
           // Response.BinaryWrite(s);
            //return Json(new { foo = "bar", baz = "Blech" });
            return PartialView(db.VIEW_Inbound_New.Take(100).ToList());
        }
    }
}