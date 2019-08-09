namespace QLNT.DTO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLPT : DbContext
    {
        public QLPT()
            : base("name=QLPT2")
        {
        }

        public virtual DbSet<BAO_TRI_THIET_BI> BAO_TRI_THIET_BI { get; set; }
        public virtual DbSet<CT_DICHVU> CT_DICHVU { get; set; }
        public virtual DbSet<CT_KHACH_THUE> CT_KHACH_THUE { get; set; }
        public virtual DbSet<DICH_VU> DICH_VU { get; set; }
        public virtual DbSet<GIA_THUE> GIA_THUE { get; set; }
        public virtual DbSet<HOA_DON> HOA_DON { get; set; }
        public virtual DbSet<HOP_DONG> HOP_DONG { get; set; }
        public virtual DbSet<KHACH_THUE> KHACH_THUE { get; set; }
        public virtual DbSet<LOAI_DICH_VU> LOAI_DICH_VU { get; set; }
        public virtual DbSet<PHONG_TRO> PHONG_TRO { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<USER_KHACHTHUE> USER_KHACHTHUE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BAO_TRI_THIET_BI>()
                .Property(e => e.MaThietBi)
                .IsUnicode(false);

            modelBuilder.Entity<BAO_TRI_THIET_BI>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<CT_DICHVU>()
                .Property(e => e.MaDichVu)
                .IsUnicode(false);

            modelBuilder.Entity<CT_KHACH_THUE>()
                .Property(e => e.MaKhach)
                .IsUnicode(false);

            modelBuilder.Entity<CT_KHACH_THUE>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<DICH_VU>()
                .Property(e => e.MaDichVu)
                .IsUnicode(false);

            modelBuilder.Entity<DICH_VU>()
                .Property(e => e.GiaDichVu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DICH_VU>()
                .Property(e => e.MaLoaiDichVu)
                .IsUnicode(false);

            modelBuilder.Entity<DICH_VU>()
                .HasMany(e => e.CT_DICHVU)
                .WithRequired(e => e.DICH_VU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GIA_THUE>()
                .Property(e => e.GiaTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .HasMany(e => e.CT_DICHVU)
                .WithRequired(e => e.HOA_DON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOP_DONG>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<KHACH_THUE>()
                .Property(e => e.MaKhach)
                .IsUnicode(false);

            modelBuilder.Entity<KHACH_THUE>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<KHACH_THUE>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<KHACH_THUE>()
                .HasMany(e => e.CT_KHACH_THUE)
                .WithRequired(e => e.KHACH_THUE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAI_DICH_VU>()
                .Property(e => e.MaLoaiDichVu)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG_TRO>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG_TRO>()
                .HasMany(e => e.CT_KHACH_THUE)
                .WithRequired(e => e.PHONG_TRO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USER_KHACHTHUE>()
                .Property(e => e.MaKhach)
                .IsUnicode(false);

            modelBuilder.Entity<USER_KHACHTHUE>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<USER_KHACHTHUE>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<USER_KHACHTHUE>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);
        }
    }
}
