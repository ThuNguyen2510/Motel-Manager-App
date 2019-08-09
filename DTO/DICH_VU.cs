namespace QLNT.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DICH_VU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICH_VU()
        {
            CT_DICHVU = new HashSet<CT_DICHVU>();
        }

        [Key]
        [StringLength(5)]
        public string MaDichVu { get; set; }

        [StringLength(30)]
        public string DichVu { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaDichVu { get; set; }

        [StringLength(5)]
        public string MaLoaiDichVu { get; set; }

        [StringLength(30)]
        public string QuyCach { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DICHVU> CT_DICHVU { get; set; }

        public virtual LOAI_DICH_VU LOAI_DICH_VU { get; set; }
    }
}
