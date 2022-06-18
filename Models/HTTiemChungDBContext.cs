using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Models
{
    public partial class HTTiemChungDBContext : DbContext
    {
        public HTTiemChungDBContext()
        {
        }

        public HTTiemChungDBContext(DbContextOptions<HTTiemChungDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietDangKy> ChiTietDangKies { get; set; }
        public virtual DbSet<ChiTietPhieuMua> ChiTietPhieuMuas { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonToanBo> HoaDonToanBos { get; set; }
        public virtual DbSet<HoaDonTraGop> HoaDonTraGops { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Lich> Liches { get; set; }
        public virtual DbSet<NguoiGiamHo> NguoiGiamHos { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuDangKy> PhieuDangKies { get; set; }
        public virtual DbSet<PhieuDatHang> PhieuDatHangs { get; set; }
        public virtual DbSet<PhieuMua> PhieuMuas { get; set; }
        public virtual DbSet<Vaccine> Vaccines { get; set; }
        public virtual DbSet<VaccineGoi> VaccineGois { get; set; }
        public virtual DbSet<VaccineLe> VaccineLes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=H8PHP13;Database=HTTiemChungDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDangKy>(entity =>
            {
                entity.HasKey(e => new { e.MaPhieuDk, e.MaVaccine });

                entity.ToTable("ChiTietDangKy");

                entity.Property(e => e.MaPhieuDk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaPhieuDK");

                entity.Property(e => e.MaVaccine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiaDiem).HasMaxLength(50);

                entity.Property(e => e.ThoiGianTiem).HasColumnType("datetime");

                entity.HasOne(d => d.MaVaccineNavigation)
                    .WithMany(p => p.ChiTietDangKies)
                    .HasForeignKey(d => d.MaVaccine)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietDangKy_Vaccine");
            });

            modelBuilder.Entity<ChiTietPhieuMua>(entity =>
            {
                entity.HasKey(e => new { e.MaPhieuMua, e.MaVaccine })
                    .HasName("PK__ChiTietP__AD5296A430E2E655");

                entity.ToTable("ChiTietPhieuMua");

                entity.Property(e => e.MaPhieuMua)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaVaccine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaPhieuMuaNavigation)
                    .WithMany(p => p.ChiTietPhieuMuas)
                    .HasForeignKey(d => d.MaPhieuMua)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PhieuMua_ChiTietPhieuMua");

                entity.HasOne(d => d.MaVaccineNavigation)
                    .WithMany(p => p.ChiTietPhieuMuas)
                    .HasForeignKey(d => d.MaVaccine)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Vaccine_ChiTietPhieuMua");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHd)
                    .HasName("PK__HoaDon__2725A6E02D0B63C1");

                entity.ToTable("HoaDon");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaHD");

                entity.Property(e => e.HinhThuc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgayThanhToan).HasColumnType("date");

                entity.Property(e => e.PhieuDk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PhieuDK");

                entity.HasOne(d => d.PhieuDkNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.PhieuDk)
                    .HasConstraintName("fk_PhieuDangKy_HoaDon");
            });

            modelBuilder.Entity<HoaDonToanBo>(entity =>
            {
                entity.HasKey(e => e.MaHoaDonToanBo)
                    .HasName("PK__HoaDonTo__DE9820A42BF026F7");

                entity.ToTable("HoaDonToanBo");

                entity.Property(e => e.MaHoaDonToanBo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaHoaDonToanBoNavigation)
                    .WithOne(p => p.HoaDonToanBo)
                    .HasForeignKey<HoaDonToanBo>(d => d.MaHoaDonToanBo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_HoaDon_HoaDonToanBo");
            });

            modelBuilder.Entity<HoaDonTraGop>(entity =>
            {
                entity.HasKey(e => e.MaHoaDonTraGop)
                    .HasName("PK__HoaDonTr__231D889DED603611");

                entity.ToTable("HoaDonTraGop");

                entity.Property(e => e.MaHoaDonTraGop)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoTienThanhToanTungDot)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaHoaDonTraGopNavigation)
                    .WithOne(p => p.HoaDonTraGop)
                    .HasForeignKey<HoaDonTraGop>(d => d.MaHoaDonTraGop)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_HoaDon_HoaDonTraGop");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("pk_KhachHang");

                entity.ToTable("KhachHang");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaKH");

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.GiamHo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.SoDt)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SoDT")
                    .IsFixedLength();

                entity.HasOne(d => d.GiamHoNavigation)
                    .WithMany(p => p.KhachHangs)
                    .HasForeignKey(d => d.GiamHo)
                    .HasConstraintName("fk_KH_GH");
            });

            modelBuilder.Entity<Lich>(entity =>
            {
                entity.HasKey(e => new { e.MaNv, e.Ngay, e.Ca })
                    .HasName("PK__Lich__53AB0DEB3FB787BA");

                entity.ToTable("Lich");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.Ngay).HasColumnType("date");

                entity.Property(e => e.LoaiLich)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.Liches)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_NhanVien_Lich");
            });

            modelBuilder.Entity<NguoiGiamHo>(entity =>
            {
                entity.HasKey(e => e.MaGiamHo)
                    .HasName("pk_NguoiGH");

                entity.ToTable("NguoiGiamHo");

                entity.Property(e => e.MaGiamHo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.MoiQuanHe).HasMaxLength(20);

                entity.Property(e => e.SoDt)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SoDT")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv)
                    .HasName("pk_NhanVien");

                entity.ToTable("NhanVien");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.BangCap).HasMaxLength(50);

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.TrungTamLamViec).HasMaxLength(50);

                entity.Property(e => e.ViTri).HasMaxLength(20);
            });

            modelBuilder.Entity<PhieuDangKy>(entity =>
            {
                entity.HasKey(e => e.MaPhieuDk)
                    .HasName("pk_PhieuDK");

                entity.ToTable("PhieuDangKy");

                entity.Property(e => e.MaPhieuDk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaPhieuDK");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaKH");

                entity.Property(e => e.NgayDk)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayDK");
            });

            modelBuilder.Entity<PhieuDatHang>(entity =>
            {
                entity.HasKey(e => e.MaPhieuDatHang)
                    .HasName("PK__PhieuDat__2665F4A27FA88587");

                entity.ToTable("PhieuDatHang");

                entity.Property(e => e.MaPhieuDatHang)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HoTen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaPhieuMua)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nvduyet)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NVDuyet");

                entity.HasOne(d => d.MaPhieuMuaNavigation)
                    .WithMany(p => p.PhieuDatHangs)
                    .HasForeignKey(d => d.MaPhieuMua)
                    .HasConstraintName("fk_PhieuMua_PhieuDatHang");

                entity.HasOne(d => d.NvduyetNavigation)
                    .WithMany(p => p.PhieuDatHangs)
                    .HasForeignKey(d => d.Nvduyet)
                    .HasConstraintName("fk_NhanVien_PhieuDatHang");
            });

            modelBuilder.Entity<PhieuMua>(entity =>
            {
                entity.HasKey(e => e.MaPhieuMua);

                entity.ToTable("PhieuMua");

                entity.Property(e => e.MaPhieuMua)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.MaKh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaKH");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDT")
                    .IsFixedLength();

                entity.Property(e => e.TrangThai).HasMaxLength(50);

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.PhieuMuas)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK_PhieuMua_KhachHang");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.PhieuMuas)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK_PhieuMua_NhanVien");
            });

            modelBuilder.Entity<Vaccine>(entity =>
            {
                entity.HasKey(e => e.MaVaccine)
                    .HasName("pk_Vaccine");

                entity.ToTable("Vaccine");

                entity.Property(e => e.MaVaccine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenVaccine).HasMaxLength(50);
            });

            modelBuilder.Entity<VaccineGoi>(entity =>
            {
                entity.HasKey(e => e.MaGoiVaccine);

                entity.ToTable("VaccineGoi");

                entity.Property(e => e.MaGoiVaccine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Loai).HasMaxLength(50);

                entity.HasMany(d => d.MaVaccineLes)
                    .WithMany(p => p.MaGoiVaccines)
                    .UsingEntity<Dictionary<string, object>>(
                        "VaccineGoiVaccineLe",
                        l => l.HasOne<VaccineLe>().WithMany().HasForeignKey("MaVaccineLe").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_VaccineGoi_VaccineLe_VaccineLe"),
                        r => r.HasOne<VaccineGoi>().WithMany().HasForeignKey("MaGoiVaccine").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_VaccineGoi_VaccineLe_VaccineGoi"),
                        j =>
                        {
                            j.HasKey("MaGoiVaccine", "MaVaccineLe");

                            j.ToTable("VaccineGoi_VaccineLe");

                            j.IndexerProperty<string>("MaGoiVaccine").HasMaxLength(50).IsUnicode(false);

                            j.IndexerProperty<string>("MaVaccineLe").HasMaxLength(50).IsUnicode(false);
                        });
            });

            modelBuilder.Entity<VaccineLe>(entity =>
            {
                entity.HasKey(e => e.MaVaccineLe);

                entity.ToTable("VaccineLe");

                entity.Property(e => e.MaVaccineLe)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
