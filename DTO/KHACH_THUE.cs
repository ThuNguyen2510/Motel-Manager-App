namespace QLNT.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KHACH_THUE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACH_THUE()
        {
            CT_KHACH_THUE = new HashSet<CT_KHACH_THUE>();
            USER_KHACHTHUE = new HashSet<USER_KHACHTHUE>();
        }

        [Key]
        [StringLength(5)]
        public string MaKhach { get; set; }

        [StringLength(30)]
        public string TenKhach { get; set; }

        [StringLength(5)]
        public string GioiTinh { get; set; }

        [StringLength(11)]
        public string CMND { get; set; }

        [StringLength(20)]
        public string QueQuan { get; set; }

        [StringLength(20)]
        public string NgheNghiep { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [Column(TypeName = "image")]
        public byte[] HinhAnh { get; set; }

        public int? TinhTrang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_KHACH_THUE> CT_KHACH_THUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_KHACHTHUE> USER_KHACHTHUE { get; set; }
    }
}
