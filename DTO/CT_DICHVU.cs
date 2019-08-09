namespace QLNT.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_DICHVU
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHoaDon { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaDichVu { get; set; }

        public int? DonViSuDung { get; set; }

        public virtual DICH_VU DICH_VU { get; set; }

        public virtual HOA_DON HOA_DON { get; set; }
    }
}
