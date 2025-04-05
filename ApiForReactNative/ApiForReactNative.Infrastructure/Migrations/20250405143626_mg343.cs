using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiForReactNative.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mg343 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TableOnes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjeSorumlusu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjeAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DGTParcaKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SorumluKisi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeriNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrerimAdeti = table.Column<int>(type: "int", nullable: false),
                    Gun = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileData = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kaydet = table.Column<bool>(type: "bit", nullable: false),
                    TeknisyebDosyaAcilmaZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableOnes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TableThrees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UygunsuzlukTespitListesi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeknisyenAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DGTParcaKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusValue = table.Column<int>(type: "int", nullable: false),
                    KacAdetBeklemede = table.Column<int>(type: "int", nullable: false),
                    AciklamaKalitecidenGelecek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableThrees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TableTwos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AciklamaListesi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeknisyenAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DgtParcaKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusValue = table.Column<int>(type: "int", nullable: false),
                    OnayProjeYoneticisi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KacAdetBeklemede = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableTwos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TableOnes");

            migrationBuilder.DropTable(
                name: "TableThrees");

            migrationBuilder.DropTable(
                name: "TableTwos");
        }
    }
}
