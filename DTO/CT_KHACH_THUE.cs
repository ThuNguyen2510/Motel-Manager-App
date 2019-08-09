namespace QLNT.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_KHACH_THUE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MaKhach { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaPhong { get; set; }

        public DateTime? NgayVaoPhong { get; set; }

        public virtual KHACH_THUE KHACH_THUE { get; set; }

        public virtual PHONG_TRO PHONG_TRO { get; set; }
    }
}
