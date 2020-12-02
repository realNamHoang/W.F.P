namespace W.F.P.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddChiTietHDNClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChatLieu",
                c => new
                {
                    MaChatLieu = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    TenChatLieu = c.String(nullable: false, maxLength: 40, fixedLength: true),
                })
                .PrimaryKey(t => t.MaChatLieu);

            CreateTable(
                "dbo.ChiTietHDB",
                c => new
                {
                    SoHDB = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    MaGiayDep = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    SoLuong = c.Int(nullable: false),
                    GiamGia = c.Long(nullable: false),
                    ThanhTien = c.Long(nullable: false),
                })
                .PrimaryKey(t => new { t.SoHDB, t.MaGiayDep });

            //Trigger for export
            Sql(@"IF OBJECT_ID ('dbo.updatesell','TR') is not null
                Drop TRIGGER dbo.updatesell;
                GO
                CREATE TRIGGER [dbo].[updatesell]
                ON
                [dbo].[ChiTietHDB]
                FOR INSERT,UPDATE
                AS
                BEGIN
                    DECLARE @MaGiay nvarchar(10),@number int
                    SELECT @MaGiay = MaGiayDep ,@number = SoLuong  FROM INSERTED
                    UPDATE SanPham SET SoLuong = SoLuong - @number WHERE MaGiayDep = @MaGiay
                End");

            CreateTable(
                "dbo.ChiTietHDN",
                c => new
                {
                    SoHDN = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    MaGiayDep = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    SoLuong = c.Int(nullable: false),
                    DonGia = c.Long(nullable: false),
                    GiamGia = c.Long(nullable: false),
                    ThanhTien = c.Long(),
                })
                .PrimaryKey(t => new { t.SoHDN, t.MaGiayDep });

            //Trigger for import
            Sql(@"IF OBJECT_ID ('dbo.updateimport','TR') is not null
                Drop TRIGGER dbo.updateimport;
                GO
                CREATE TRIGGER [dbo].[updateimport]
                ON
                [dbo].[ChiTietHDN]
                FOR INSERT,UPDATE
                AS
                BEGIN
                    DECLARE @MaGiay nvarchar(10),@number int,@TongThanhTien bigint
                    SELECT @MaGiay = MaGiayDep ,@number = SoLuong, @TongThanhTien = ThanhTien  FROM INSERTED
                    UPDATE SanPham SET SoLuong = SoLuong + @number , DonGiaNhap=@TongThanhTien , DonGiaBan = @TongThanhTien * 1.1
                    WHERE MaGiayDep = @MaGiay
                End");

            CreateTable(
                "dbo.Co",
                c => new
                {
                    MaCo = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    TenCo = c.String(maxLength: 30, fixedLength: true),
                })
                .PrimaryKey(t => t.MaCo);

            CreateTable(
                "dbo.DoiTuong",
                c => new
                {
                    MaDoiTuong = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    TenDoiTuong = c.String(nullable: false, maxLength: 50, fixedLength: true),
                })
                .PrimaryKey(t => t.MaDoiTuong);

            CreateTable(
                "dbo.HoaDonNhap",
                c => new
                {
                    SoHDN = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    MaNV = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    NgayNhap = c.DateTime(nullable: false, storeType: "date"),
                    MaNCC = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    TongTien = c.Long(),
                })
                .PrimaryKey(t => t.SoHDN);

            CreateTable(
                "dbo.HoaDonBan",
                c => new
                {
                    SoHDB = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    MaNV = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    NgayBan = c.DateTime(nullable: false, storeType: "date"),
                    MaNCC = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    TongTien = c.Long(),
                })
                .PrimaryKey(t => t.SoHDB);

            CreateTable(
                "dbo.Mau",
                c => new
                {
                    MaMau = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    TenMau = c.String(nullable: false, maxLength: 50, fixedLength: true),
                })
                .PrimaryKey(t => t.MaMau);

            CreateTable(
                "dbo.Mua",
                c => new
                {
                    MaMua = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    TenMua = c.String(nullable: false, maxLength: 50, fixedLength: true),
                })
                .PrimaryKey(t => t.MaMua);

            CreateTable(
                "dbo.NhaCungCap",
                c => new
                {
                    MaNCC = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    TenNCC = c.String(nullable: false, maxLength: 50),
                    DiaChi = c.String(nullable: false, maxLength: 50),
                    DienThoai = c.Long(),
                })
                .PrimaryKey(t => t.MaNCC);

            CreateTable(
                "dbo.NhanVien",
                c => new
                {
                    MaNhanVien = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    TenNhanVien = c.String(nullable: false, maxLength: 50),
                    GioiTinh = c.String(maxLength: 10, fixedLength: true),
                    NgaySinh = c.DateTime(storeType: "date"),
                    DienThoai = c.String(maxLength: 30, fixedLength: true),
                    DiaChi = c.String(maxLength: 50),
                    MaCV = c.String(nullable: false, maxLength: 10, fixedLength: true),
                })
                .PrimaryKey(t => t.MaNhanVien);

            CreateTable(
                "dbo.NuocSanXuat",
                c => new
                {
                    MaNuocSX = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    TenNuocSX = c.String(maxLength: 50),
                })
                .PrimaryKey(t => t.MaNuocSX);

            CreateTable(
                "dbo.CongViec",
                c => new
                {
                    MaCV = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    TenCV = c.String(maxLength: 50),
                })
                .PrimaryKey(t => t.MaCV);

            CreateTable(
                "dbo.KhachHang",
                c => new
                {
                    MaKhach = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    TenKhach = c.String(maxLength: 50),
                })
                .PrimaryKey(t => t.MaKhach);

            CreateTable(
                "dbo.SanPham",
                c => new
                {
                    MaGiayDep = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    TenGiayDep = c.String(nullable: false, maxLength: 50, fixedLength: true),
                    MaLoai = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    MaCo = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    MaChatLieu = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    MaMau = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    MaDoiTuong = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    MaMua = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    MaNuocSX = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    SoLuong = c.Int(nullable: true),
                    Anh = c.String(nullable: false, maxLength: 50),
                    DonGiaNhap = c.Long(nullable: true),
                    DonGiaBan = c.Long(nullable: true),
                })
                .PrimaryKey(t => t.MaGiayDep);

            CreateTable(
                "dbo.TheLoai",
                c => new
                {
                    Maloai = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    TenLoai = c.String(maxLength: 40, fixedLength: true),
                })
                .PrimaryKey(t => t.Maloai);

            //Tong Tien Theo Quy
            Sql(@"create procedure DS_HDN @quy int
                as
                begin
                    declare @thang int
                    set @thang=1 + 3*(@quy-1)
                    select *
                    from HoaDonNhap
                    where MONTH(NgayNhap) between @thang and @thang+2
                end");

            //Ho Ten Tong Tien 3 Nguoi Trong nam
            Sql(@"create procedure Top3_KH @quy int
                as
                begin
                    declare @thang int
                    set @thang=1 + 3*(@quy-1)
                    select top 3 KhachHang.*,a.Tong
                    from KhachHang join
                    (select makhach, sum(DonGiaBan*ChiTietHDB.SoLuong) Tong
                    from SanPham join ChiTietHDB on SanPham.MaGiayDep=ChiTietHDB.MaGiayDep join HoaDonBan on HoaDonBan.SoHDB=ChiTietHDB.SoHDB
                    where month(NgayBan) between @thang and @thang+2 and year(NgayBan)=2020
                    group by MaKhach) a on a.MaKhach=KhachHang.MaKhach   
                    order by a.Tong desc   
                end");

        }

        public override void Down()
        {
            DropTable("dbo.TheLoai");
            DropTable("dbo.SanPham");
            DropTable("dbo.NuocSanXuat");
            DropTable("dbo.NhanVien");
            DropTable("dbo.NhaCungCap");
            DropTable("dbo.Mua");
            DropTable("dbo.Mau");
            DropTable("dbo.HoaDonNhap");
            DropTable("dbo.HoaDonBan");
            DropTable("dbo.DoiTuong");
            DropTable("dbo.Co");
            DropTable("dbo.ChiTietHDN");
            DropTable("dbo.ChiTietHDB");
            DropTable("dbo.ChatLieu");
        }
    }
}
