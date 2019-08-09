namespace QLNT.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USER_KHACHTHUE
    {
        [Key]
        public int UserID { get; set; }

        [StringLength(25)]
        public string Username { get; set; }

        [StringLength(25)]
        public string Pwd { get; set; }

        public int? IsAdmin { get; set; }

        [StringLength(5)]
        public string MaKhach { get; set; }

        [StringLength(30)]
        public string TenKhach { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(5)]
        public string Phai { get; set; }

        [StringLength(11)]
        public string CMND { get; set; }

        [StringLength(20)]
        public string QueQuan { get; set; }

        [StringLength(20)]
        public string NgheNghiep { get; set; }

        [StringLength(11)]
        public string DienThoai { get; set; }

        public int? TinhTrang { get; set; }

        public virtual KHACH_THUE KHACH_THUE { get; set; }
    }
}
