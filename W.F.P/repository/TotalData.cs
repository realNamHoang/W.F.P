using System.Data.Entity;

namespace W.F.P
{
    public partial class TotalData : DbContext
    {
        public TotalData()
            : base("name=TotalData")
        {
        }

        public virtual DbSet<ChatLieu> ChatLieux { get; set; }
        public virtual DbSet<ChiTietHDB> ChiTietHDBs { get; set; }
        public virtual DbSet<ChiTietHDN> ChiTietHDNs { get; set; }
        public virtual DbSet<Co> Coes { get; set; }
        public virtual DbSet<DoiTuong> DoiTuongs { get; set; }
        public virtual DbSet<HoaDonNhap> HoaDonNhaps { get; set; }
        public virtual DbSet<HoaDonBan> HoaDonBans { get; set; }
        public virtual DbSet<Mau> Maus { get; set; }
        public virtual DbSet<Mua> Muas { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<CongViec> CongViecs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NuocSanXuat> NuocSanXuats { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChatLieu>()
                .Property(e => e.MaChatLieu)
                .IsFixedLength();

            modelBuilder.Entity<ChatLieu>()
                .Property(e => e.TenChatLieu)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietHDB>()
                .Property(e => e.SoHDB)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietHDB>()
                .Property(e => e.MaGiayDep)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietHDN>()
                .Property(e => e.SoHDN)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietHDN>()
                .Property(e => e.MaGiayDep)
                .IsFixedLength();

            modelBuilder.Entity<Co>()
                .Property(e => e.MaCo)
                .IsFixedLength();

            modelBuilder.Entity<Co>()
                .Property(e => e.TenCo)
                .IsFixedLength();

            modelBuilder.Entity<DoiTuong>()
                .Property(e => e.MaDoiTuong)
                .IsFixedLength();

            modelBuilder.Entity<DoiTuong>()
                .Property(e => e.TenDoiTuong)
                .IsFixedLength();

            modelBuilder.Entity<HoaDonNhap>()
                .Property(e => e.SoHDN)
                .IsFixedLength();

            modelBuilder.Entity<HoaDonNhap>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<HoaDonNhap>()
                .Property(e => e.MaNCC)
                .IsFixedLength();

            modelBuilder.Entity<HoaDonBan>()
                .Property(e => e.SoHDB)
                .IsFixedLength();

            modelBuilder.Entity<HoaDonBan>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<HoaDonBan>()
                .Property(e => e.MaKhach)
                .IsFixedLength();

            modelBuilder.Entity<Mau>()
                .Property(e => e.MaMau)
                .IsFixedLength();

            modelBuilder.Entity<Mau>()
                .Property(e => e.TenMau)
                .IsFixedLength();

            modelBuilder.Entity<Mua>()
                .Property(e => e.MaMua)
                .IsFixedLength();

            modelBuilder.Entity<Mua>()
                .Property(e => e.TenMua)
                .IsFixedLength();

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.MaNCC)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNhanVien)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.GioiTinh)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.DienThoai)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaCV)
                .IsFixedLength();

            modelBuilder.Entity<NuocSanXuat>()
                .Property(e => e.MaNuocSX)
                .IsFixedLength();

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaGiayDep)
                .IsFixedLength();

            modelBuilder.Entity<SanPham>()
                .Property(e => e.TenGiayDep)
                .IsFixedLength();

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaLoai)
                .IsFixedLength();

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaCo)
                .IsFixedLength();

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaChatLieu)
                .IsFixedLength();

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaMau)
                .IsFixedLength();

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaNuocSX)
                .IsFixedLength();

            modelBuilder.Entity<TheLoai>()
                .Property(e => e.Maloai)
                .IsFixedLength();

            modelBuilder.Entity<TheLoai>()
                .Property(e => e.TenLoai)
                .IsFixedLength();

            modelBuilder.Entity<CongViec>()
                .Property(e => e.MaCongViec)
                .IsFixedLength();

            modelBuilder.Entity<CongViec>()
                .Property(e => e.TenCongViec)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKhach)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.TenKhach)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.DiaChi)
                .IsFixedLength();
        }
    }
}
