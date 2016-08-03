namespace WMS_Web_SCG_CDMA.Entity_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ms_GroupSku
    {
        [Key]
        public int GroupSku_Index { get; set; }

        [Required]
        [StringLength(50)]
        public string GroupSku_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string GroupSku_Des { get; set; }

    }
}
