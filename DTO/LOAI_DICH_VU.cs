namespace QLNT.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOAI_DICH_VU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAI_DICH_VU()
        {
            DICH_VU = new HashSet<DICH_VU>();
        }

        [Key]
        [StringLength(5)]
        public string MaLoaiDichVu { get; set; }

        [StringLength(20)]
        public string TenLoaiDichVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DICH_VU> DICH_VU { get; set; }
    }
}
