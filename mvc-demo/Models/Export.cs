using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS_Web_SCG_CDMA.Models
{
    public class Export
    {
        //GR
        public bool chkGR { get; set; }
       
        public bool chkPO { get; set; }

        public string dtpGR { get; set; }
       
        public string txtPO { get; set; }


        //GI
        public bool chkGI { get; set; }
    
        public bool chkShipment { get; set; }
        public bool chkShipTo { get; set; }
        public string dtpGI { get; set; }
 
        public string cboShipTo { get; set; }
        public string cboDN { get; set; }
        public string txtShipment_No { get; set; }

        //GR GI
        public bool chkGroup { get; set; }
        public string cboGroup { get; set; }
    }
}
