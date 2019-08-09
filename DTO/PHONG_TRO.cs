namespace QLNT.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHONG_TRO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG_TRO()
        {
            BAO_TRI_THIET_BI = new HashSet<BAO_TRI_THIET_BI>();
            CT_KHACH_THUE = new HashSet<CT_KHACH_THUE>();
            HOA_DON = new HashSet<HOA_DON>();
            HOP_DONG = new HashSet<HOP_DONG>();
        }

        [Key]
        [StringLength(5)]
        public string MaPhong { get; set; }

        public int? TrangThai { get; set; }

        [StringLength(50)]
        public string ThongTinPhong { get; set; }

        public int? SoNguoi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAO_TRI_THIET_BI> BAO_TRI_THIET_BI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_KHACH_THUE> CT_KHACH_THUE { get; set; }

        public virtual GIA_THUE GIA_THUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOA_DON> HOA_DON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOP_DONG> HOP_DONG { get; set; }
    }
}
