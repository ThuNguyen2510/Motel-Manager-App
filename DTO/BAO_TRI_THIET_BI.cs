namespace QLNT.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BAO_TRI_THIET_BI
    {
        [Key]
        [StringLength(5)]
        public string MaThietBi { get; set; }

        [StringLength(5)]
        public string MaPhong { get; set; }

        [StringLength(30)]
        public string TenThietBi { get; set; }

        [StringLength(30)]
        public string TrangThai { get; set; }

        public virtual PHONG_TRO PHONG_TRO { get; set; }
    }
}
