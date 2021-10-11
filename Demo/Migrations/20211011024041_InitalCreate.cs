using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Migrations
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHD = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKH = table.Column<string>(nullable: true),
                    MaNV = table.Column<string>(nullable: true),
                    NgayLapHD = table.Column<DateTime>(nullable: false),
                    NgayNhanHang = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHD);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKH = table.Column<string>(nullable: false),
                    HoTenKH = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    DienThoai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNV = table.Column<string>(nullable: false),
                    HoNV = table.Column<string>(nullable: true),
                    TenNV = table.Column<string>(nullable: true),
                    GioiTinh = table.Column<bool>(nullable: false),
                    DiaChi = table.Column<string>(nullable: true),
                    DienThoai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNV);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    MaSP = table.Column<string>(nullable: false),
                    TenSp = table.Column<string>(nullable: true),
                    DonViTinh = table.Column<string>(nullable: true),
                    DonGia = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.MaSP);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "SanPham");
        }
    }
}
