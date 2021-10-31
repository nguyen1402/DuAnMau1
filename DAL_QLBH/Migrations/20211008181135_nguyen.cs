using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL_QLBH.Migrations
{
    public partial class nguyen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LichSu",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lucvao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lucra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tinhtrang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Nhanvien",
                columns: table => new
                {
                    MaNV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vaitro = table.Column<int>(type: "int", nullable: false),
                    Tinhtrang = table.Column<bool>(type: "bit", nullable: false),
                    Matkhau = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhanvien", x => x.MaNV);
                });

            migrationBuilder.CreateTable(
                name: "Hang",
                columns: table => new
                {
                    MaHang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenHang = table.Column<string>(type: "nvarchar(28)", maxLength: 28, nullable: false),
                    SoLuong = table.Column<int>(type: "int", maxLength: 28, nullable: false),
                    Dgiaban = table.Column<float>(type: "real", nullable: false),
                    Dgianhap = table.Column<float>(type: "real", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hinhanh = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    MaNV = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hang", x => x.MaHang);
                    table.ForeignKey(
                        name: "FK_Hang_Nhanvien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "Nhanvien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKhach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(28)", maxLength: 28, nullable: false),
                    Phai = table.Column<int>(type: "int", nullable: false),
                    SDtKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaNV = table.Column<int>(type: "int", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.MaKH);
                    table.ForeignKey(
                        name: "FK_KhachHang_Nhanvien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "Nhanvien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hang_MaNV",
                table: "Hang",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_MaNV",
                table: "KhachHang",
                column: "MaNV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hang");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "LichSu");

            migrationBuilder.DropTable(
                name: "Nhanvien");
        }
    }
}
