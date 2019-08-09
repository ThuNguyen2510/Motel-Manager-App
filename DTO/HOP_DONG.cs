namespace QLNT.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOP_DONG
    {
        [Key]
        public int MaHopDong { get; set; }

        public DateTime? NgayLap { get; set; }

        [StringLength(5)]
        public string MaPhong { get; set; }

        public virtual PHONG_TRO PHONG_TRO { get; set; }
    }
}
