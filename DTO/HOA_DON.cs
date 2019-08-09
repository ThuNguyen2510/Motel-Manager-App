namespace QLNT.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOA_DON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOA_DON()
        {
            CT_DICHVU = new HashSet<CT_DICHVU>();
        }

        [Key]
        public int MaHoaDon { get; set; }

        public DateTime? NgayLap { get; set; }

        [StringLength(5)]
        public string MaPhong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DICHVU> CT_DICHVU { get; set; }

        public virtual PHONG_TRO PHONG_TRO { get; set; }
    }
}
