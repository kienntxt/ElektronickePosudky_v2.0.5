using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ElektronickePosudky.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ciselniky",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Verze = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlatnostOd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlatnostDo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Termx = table.Column<bool>(type: "bit", nullable: true),
                    TermxId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TermxUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciselniky", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pacienti",
                columns: table => new
                {
                    Rid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Jmeno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prijmeni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumNarozeni = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doklad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pohlavi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacienti", x => x.Rid);
                });

            migrationBuilder.CreateTable(
                name: "PoskytovateleZdravotnickychSluzeb",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoskytovateleZdravotnickychSluzeb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CiselnikPolozky",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiselnikId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Verze = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RodicId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CiselnikKod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiselnikVerze = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiselnikPolozky", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiselnikPolozky_CiselnikPolozky_RodicId",
                        column: x => x.RodicId,
                        principalTable: "CiselnikPolozky",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CiselnikPolozky_Ciselniky_CiselnikId",
                        column: x => x.CiselnikId,
                        principalTable: "Ciselniky",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityType = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CiselnikId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CiselnikPolozkaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Language = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PropertyName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Translations_CiselnikPolozky_CiselnikPolozkaId",
                        column: x => x.CiselnikPolozkaId,
                        principalTable: "CiselnikPolozky",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Translations_Ciselniky_CiselnikId",
                        column: x => x.CiselnikId,
                        principalTable: "Ciselniky",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZdravotnickyPracovnici",
                columns: table => new
                {
                    KrzpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Jmeno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prijmeni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OdbornostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PoskytovatelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZdravotnickyPracovnici", x => x.KrzpId);
                    table.ForeignKey(
                        name: "FK_ZdravotnickyPracovnici_CiselnikPolozky_OdbornostId",
                        column: x => x.OdbornostId,
                        principalTable: "CiselnikPolozky",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ZdravotnickyPracovnici_PoskytovateleZdravotnickychSluzeb_PoskytovatelId",
                        column: x => x.PoskytovatelId,
                        principalTable: "PoskytovateleZdravotnickychSluzeb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PosudekRos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KrzpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StavPosudkuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DruhProhlidkyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DruhPosudkuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TypAkceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VysledekId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SkupinaZadateleRidicId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DatumVystaveni = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlatnostDo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OpakovanyPosudekId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DatumVytvoreni = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosudekRos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PosudekRos_CiselnikPolozky_DruhPosudkuId",
                        column: x => x.DruhPosudkuId,
                        principalTable: "CiselnikPolozky",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PosudekRos_CiselnikPolozky_DruhProhlidkyId",
                        column: x => x.DruhProhlidkyId,
                        principalTable: "CiselnikPolozky",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PosudekRos_CiselnikPolozky_SkupinaZadateleRidicId",
                        column: x => x.SkupinaZadateleRidicId,
                        principalTable: "CiselnikPolozky",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PosudekRos_CiselnikPolozky_StavPosudkuId",
                        column: x => x.StavPosudkuId,
                        principalTable: "CiselnikPolozky",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PosudekRos_CiselnikPolozky_TypAkceId",
                        column: x => x.TypAkceId,
                        principalTable: "CiselnikPolozky",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PosudekRos_CiselnikPolozky_VysledekId",
                        column: x => x.VysledekId,
                        principalTable: "CiselnikPolozky",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PosudekRos_Pacienti_Rid",
                        column: x => x.Rid,
                        principalTable: "Pacienti",
                        principalColumn: "Rid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PosudekRos_ZdravotnickyPracovnici_KrzpId",
                        column: x => x.KrzpId,
                        principalTable: "ZdravotnickyPracovnici",
                        principalColumn: "KrzpId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PosudekRoHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PosudekRoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypOperaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DatumOperace = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KrzpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosudekRoHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PosudekRoHistories_CiselnikPolozky_TypOperaceId",
                        column: x => x.TypOperaceId,
                        principalTable: "CiselnikPolozky",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PosudekRoHistories_PosudekRos_PosudekRoId",
                        column: x => x.PosudekRoId,
                        principalTable: "PosudekRos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PosudekRoHistories_ZdravotnickyPracovnici_KrzpId",
                        column: x => x.KrzpId,
                        principalTable: "ZdravotnickyPracovnici",
                        principalColumn: "KrzpId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PosudekRoZpusobilosti",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PosudekRoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkupinaZadateleRidicId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VysledekId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosudekRoZpusobilosti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PosudekRoZpusobilosti_CiselnikPolozky_SkupinaZadateleRidicId",
                        column: x => x.SkupinaZadateleRidicId,
                        principalTable: "CiselnikPolozky",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PosudekRoZpusobilosti_CiselnikPolozky_VysledekId",
                        column: x => x.VysledekId,
                        principalTable: "CiselnikPolozky",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PosudekRoZpusobilosti_PosudekRos_PosudekRoId",
                        column: x => x.PosudekRoId,
                        principalTable: "PosudekRos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PosudekRoHarmonizovaneKody",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PosudekRoZpusobilostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HarmonizovanyKodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpresneniText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosudekRoHarmonizovaneKody", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PosudekRoHarmonizovaneKody_CiselnikPolozky_HarmonizovanyKodId",
                        column: x => x.HarmonizovanyKodId,
                        principalTable: "CiselnikPolozky",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PosudekRoHarmonizovaneKody_PosudekRoZpusobilosti_PosudekRoZpusobilostId",
                        column: x => x.PosudekRoZpusobilostId,
                        principalTable: "PosudekRoZpusobilosti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PosudekRoNarodniKody",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PosudekRoZpusobilostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NarodniKodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkupinaRoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpresneniText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosudekRoNarodniKody", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PosudekRoNarodniKody_CiselnikPolozky_NarodniKodId",
                        column: x => x.NarodniKodId,
                        principalTable: "CiselnikPolozky",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PosudekRoNarodniKody_CiselnikPolozky_SkupinaRoId",
                        column: x => x.SkupinaRoId,
                        principalTable: "CiselnikPolozky",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PosudekRoNarodniKody_PosudekRoZpusobilosti_PosudekRoZpusobilostId",
                        column: x => x.PosudekRoZpusobilostId,
                        principalTable: "PosudekRoZpusobilosti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PosudekRoSkupiny",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PosudekRoZpusobilostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkupinaRoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosudekRoSkupiny", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PosudekRoSkupiny_CiselnikPolozky_SkupinaRoId",
                        column: x => x.SkupinaRoId,
                        principalTable: "CiselnikPolozky",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PosudekRoSkupiny_PosudekRoZpusobilosti_PosudekRoZpusobilostId",
                        column: x => x.PosudekRoZpusobilostId,
                        principalTable: "PosudekRoZpusobilosti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ciselniky",
                columns: new[] { "Id", "Kod", "PlatnostDo", "PlatnostOd", "Termx", "TermxId", "TermxUrl", "Verze" },
                values: new object[,]
                {
                    { new Guid("278605a9-2aa3-42d4-babe-f3d177fd2905"), "ODBNORNOST", null, new DateTime(2025, 4, 16, 11, 3, 35, 144, DateTimeKind.Utc).AddTicks(1512), false, null, null, "1" },
                    { new Guid("599ce4bc-4222-42f1-a238-eaed3a4b0abd"), "VYSLEDEK", null, new DateTime(2025, 4, 16, 11, 3, 35, 144, DateTimeKind.Utc).AddTicks(1512), false, null, null, "1" },
                    { new Guid("9c599c83-1898-4d8a-aa18-3f867f8772a4"), "SKUPINA-ZADATELE-RIDIC", null, new DateTime(2025, 4, 16, 11, 3, 35, 144, DateTimeKind.Utc).AddTicks(1512), false, null, null, "1" },
                    { new Guid("a14bffda-1149-4ec5-b79d-cdda839259c1"), "STAV-RO", null, new DateTime(2025, 4, 16, 11, 3, 35, 144, DateTimeKind.Utc).AddTicks(1512), false, null, null, "1" },
                    { new Guid("a376442b-a991-4405-81fb-e923e7dde10a"), "DRUH-PROHLIDKY", null, new DateTime(2025, 4, 16, 11, 3, 35, 144, DateTimeKind.Utc).AddTicks(1512), false, null, null, "1" },
                    { new Guid("aae6530b-15f1-4469-b5f6-4f69592ad15d"), "TYP-OPERACE", null, new DateTime(2025, 4, 16, 11, 3, 35, 144, DateTimeKind.Utc).AddTicks(1512), false, null, null, "1" },
                    { new Guid("aff0c688-3a22-46c8-8404-82c61101d642"), "DRUH-POSUDKU", null, new DateTime(2025, 4, 16, 11, 3, 35, 144, DateTimeKind.Utc).AddTicks(1512), false, null, null, "1" },
                    { new Guid("d8142494-0f9d-4f6c-b1aa-2a42d071b5e8"), "TYP-AKCE", null, new DateTime(2025, 4, 16, 11, 3, 35, 144, DateTimeKind.Utc).AddTicks(1512), false, null, null, "1" }
                });

            migrationBuilder.InsertData(
                table: "Pacienti",
                columns: new[] { "Rid", "Adresa", "DatumNarozeni", "Doklad", "Email", "Jmeno", "Pohlavi", "Prijmeni" },
                values: new object[,]
                {
                    { new Guid("68eff241-fd51-4b06-9c3c-05799f341d28"), "Brno, Náměstí Svobody 10", new DateTime(1990, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "BB654321", "marie.svobodova@example.com", "Marie", "F", "Svobodová" },
                    { new Guid("a2e5324b-9ad8-4304-b7b9-e31b56d787f5"), "Praha 1, Václavské náměstí 1", new DateTime(1985, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AA123456", "jan.novak@example.com", "Jan", "M", "Novák" },
                    { new Guid("b362e8f1-99a7-4d68-8b95-ed3606949f25"), "Ostrava, Masarykovo náměstí 5", new DateTime(1978, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "CC987654", "petr.dvorak@example.com", "Petr", "M", "Dvořák" }
                });

            migrationBuilder.InsertData(
                table: "PoskytovateleZdravotnickychSluzeb",
                columns: new[] { "Id", "Adresa", "Ico", "Nazev" },
                values: new object[,]
                {
                    { new Guid("33bfad8b-102c-42f4-b78a-1ad49bdf5a42"), "Brno, Hlavní třída 25", "87654321", "Lékařská klinika Brno a.s." },
                    { new Guid("5373f175-39ae-4082-8345-2434b0fa5d5d"), "Praha 2, Karlovo náměstí 10", "12345678", "Zdravotní zařízení s.r.o." },
                    { new Guid("bd009c28-b756-416d-9227-341928694587"), "Ostrava, Polská 15", "11223344", "Oční ambulance Ostrava" }
                });

            migrationBuilder.InsertData(
                table: "CiselnikPolozky",
                columns: new[] { "Id", "CiselnikId", "CiselnikKod", "CiselnikVerze", "Kod", "RodicId", "Verze" },
                values: new object[,]
                {
                    { new Guid("06cefa04-8612-4dcf-b196-46d435f1718b"), new Guid("a14bffda-1149-4ec5-b79d-cdda839259c1"), "STAV-RO", "1", "ZNEPLATNENY", null, "1" },
                    { new Guid("22743832-b044-4b23-bbb1-a109f7215467"), new Guid("599ce4bc-4222-42f1-a238-eaed3a4b0abd"), "VYSLEDEK", "1", "NEZPUSOBILY", null, "1" },
                    { new Guid("388f831b-4fb6-42e6-b049-35d14808db0b"), new Guid("9c599c83-1898-4d8a-aa18-3f867f8772a4"), "SKUPINA-ZADATELE-RIDIC", "1", "B", null, "1" },
                    { new Guid("5dbb39ff-9d53-4c4a-956e-1e5fd88a0987"), new Guid("599ce4bc-4222-42f1-a238-eaed3a4b0abd"), "VYSLEDEK", "1", "ZPUSOBILY", null, "1" },
                    { new Guid("69e3533b-2d45-4c6d-b8f8-2e2da0900cf5"), new Guid("a376442b-a991-4405-81fb-e923e7dde10a"), "DRUH-PROHLIDKY", "1", "VYCHOZI", null, "1" },
                    { new Guid("80bfdd5b-19fd-4c59-bd51-382a7cc97815"), new Guid("d8142494-0f9d-4f6c-b1aa-2a42d071b5e8"), "TYP-AKCE", "1", "VYDANI", null, "1" },
                    { new Guid("82f7d36c-abd7-4e81-b29a-59873ac932a1"), new Guid("278605a9-2aa3-42d4-babe-f3d177fd2905"), "ODBNORNOST", "1", "INTERNI", null, "1" },
                    { new Guid("91c091e9-2d8a-454a-952e-61a37a6daa0c"), new Guid("a14bffda-1149-4ec5-b79d-cdda839259c1"), "STAV-RO", "1", "PLATNY", null, "1" },
                    { new Guid("93f1f521-9613-47d4-b483-ce27821b7e5a"), new Guid("9c599c83-1898-4d8a-aa18-3f867f8772a4"), "SKUPINA-ZADATELE-RIDIC", "1", "A", null, "1" },
                    { new Guid("d8270f50-c7ad-4653-b893-b5897f9d52b0"), new Guid("278605a9-2aa3-42d4-babe-f3d177fd2905"), "ODBNORNOST", "1", "OKULISTA", null, "1" },
                    { new Guid("e5f46887-8028-4b62-9286-b2840eef4001"), new Guid("a376442b-a991-4405-81fb-e923e7dde10a"), "DRUH-PROHLIDKY", "1", "PERIODICKA", null, "1" },
                    { new Guid("ea4b809d-35eb-47c7-bbf8-91b4b3528914"), new Guid("aae6530b-15f1-4469-b5f6-4f69592ad15d"), "TYP-OPERACE", "1", "ZNEPLATNENI", null, "1" },
                    { new Guid("ea9d54c9-aa27-4aec-bd71-5e74f18318e5"), new Guid("aae6530b-15f1-4469-b5f6-4f69592ad15d"), "TYP-OPERACE", "1", "VYTVORENI", null, "1" },
                    { new Guid("f0c80839-a28f-4698-8ecd-1a8eb7cb7778"), new Guid("aff0c688-3a22-46c8-8404-82c61101d642"), "DRUH-POSUDKU", "1", "RIDICKY", null, "1" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CiselnikId", "CiselnikPolozkaId", "EntityId", "EntityType", "Language", "PropertyName", "Value" },
                values: new object[,]
                {
                    { new Guid("0a6d0451-88df-41b9-9f9e-ba0cc3f308e7"), new Guid("a376442b-a991-4405-81fb-e923e7dde10a"), null, new Guid("a376442b-a991-4405-81fb-e923e7dde10a"), "Ciselnik", "cs-CZ", "Nazev", "Druh prohlídky" },
                    { new Guid("1e0737a3-2b8e-4039-858d-7b37d33ebe96"), new Guid("aff0c688-3a22-46c8-8404-82c61101d642"), null, new Guid("aff0c688-3a22-46c8-8404-82c61101d642"), "Ciselnik", "cs-CZ", "Nazev", "Druh posudku" },
                    { new Guid("224d147d-3abe-4d9d-b98b-d74c92e56d15"), new Guid("a14bffda-1149-4ec5-b79d-cdda839259c1"), null, new Guid("a14bffda-1149-4ec5-b79d-cdda839259c1"), "Ciselnik", "en-US", "Nazev", "Certificate status" },
                    { new Guid("31856937-429f-4bdb-a714-c19729bc4b59"), new Guid("a376442b-a991-4405-81fb-e923e7dde10a"), null, new Guid("a376442b-a991-4405-81fb-e923e7dde10a"), "Ciselnik", "en-US", "Nazev", "Type of examination" },
                    { new Guid("31ae4019-93aa-4c96-8e42-ea105b9b8b5c"), new Guid("aae6530b-15f1-4469-b5f6-4f69592ad15d"), null, new Guid("aae6530b-15f1-4469-b5f6-4f69592ad15d"), "Ciselnik", "cs-CZ", "Nazev", "Typ operace" },
                    { new Guid("35fded7b-a9db-4143-837f-4df98368454f"), new Guid("a376442b-a991-4405-81fb-e923e7dde10a"), null, new Guid("a376442b-a991-4405-81fb-e923e7dde10a"), "Ciselnik", "cs-CZ", "Popis", "Typ lékařské prohlídky" },
                    { new Guid("390b91d4-d284-42a6-9f50-cc74ecf008e6"), new Guid("aae6530b-15f1-4469-b5f6-4f69592ad15d"), null, new Guid("aae6530b-15f1-4469-b5f6-4f69592ad15d"), "Ciselnik", "cs-CZ", "Popis", "Typ operace v historii" },
                    { new Guid("4bcc622d-094d-48b4-b87c-446965265de0"), new Guid("599ce4bc-4222-42f1-a238-eaed3a4b0abd"), null, new Guid("599ce4bc-4222-42f1-a238-eaed3a4b0abd"), "Ciselnik", "cs-CZ", "Popis", "Výsledek lékařského posudku" },
                    { new Guid("4bf4e35f-6f1b-420e-991f-7f84d2759a6b"), new Guid("278605a9-2aa3-42d4-babe-f3d177fd2905"), null, new Guid("278605a9-2aa3-42d4-babe-f3d177fd2905"), "Ciselnik", "en-US", "Popis", "Medical specialty" },
                    { new Guid("4c7f5378-dc81-4cc0-87b8-4ab1e14ac5fc"), new Guid("9c599c83-1898-4d8a-aa18-3f867f8772a4"), null, new Guid("9c599c83-1898-4d8a-aa18-3f867f8772a4"), "Ciselnik", "cs-CZ", "Popis", "Skupina řidičského oprávnění" },
                    { new Guid("55977a83-23a1-4a5c-8b96-53f5f6e221b9"), new Guid("9c599c83-1898-4d8a-aa18-3f867f8772a4"), null, new Guid("9c599c83-1898-4d8a-aa18-3f867f8772a4"), "Ciselnik", "en-US", "Popis", "Driver license group" },
                    { new Guid("5a0c662b-edee-4ef8-909b-7d21220f81e5"), new Guid("d8142494-0f9d-4f6c-b1aa-2a42d071b5e8"), null, new Guid("d8142494-0f9d-4f6c-b1aa-2a42d071b5e8"), "Ciselnik", "en-US", "Popis", "Type of action with certificate" },
                    { new Guid("5fb5c057-aa56-43d6-9752-6384f27d5d48"), new Guid("aff0c688-3a22-46c8-8404-82c61101d642"), null, new Guid("aff0c688-3a22-46c8-8404-82c61101d642"), "Ciselnik", "cs-CZ", "Popis", "Typ lékařského posudku" },
                    { new Guid("624dc3bf-69ec-4fc8-a68a-fff5813e99f2"), new Guid("a14bffda-1149-4ec5-b79d-cdda839259c1"), null, new Guid("a14bffda-1149-4ec5-b79d-cdda839259c1"), "Ciselnik", "cs-CZ", "Nazev", "Stav posudku" },
                    { new Guid("670cccb2-a2c2-4ee3-9245-7ccfbae0b60f"), new Guid("a376442b-a991-4405-81fb-e923e7dde10a"), null, new Guid("a376442b-a991-4405-81fb-e923e7dde10a"), "Ciselnik", "en-US", "Popis", "Type of medical examination" },
                    { new Guid("67a6752d-5aee-41fb-b373-afe29825417b"), new Guid("a14bffda-1149-4ec5-b79d-cdda839259c1"), null, new Guid("a14bffda-1149-4ec5-b79d-cdda839259c1"), "Ciselnik", "en-US", "Popis", "State of the medical certificate" },
                    { new Guid("6dae6354-7952-4709-8c78-c484d560e678"), new Guid("d8142494-0f9d-4f6c-b1aa-2a42d071b5e8"), null, new Guid("d8142494-0f9d-4f6c-b1aa-2a42d071b5e8"), "Ciselnik", "en-US", "Nazev", "Type of action" },
                    { new Guid("86eaad43-638e-404b-b7de-a4f71a4c6f59"), new Guid("aae6530b-15f1-4469-b5f6-4f69592ad15d"), null, new Guid("aae6530b-15f1-4469-b5f6-4f69592ad15d"), "Ciselnik", "en-US", "Popis", "Type of operation in history" },
                    { new Guid("8922593c-d0a8-4f2a-81d6-061f3c85fedc"), new Guid("278605a9-2aa3-42d4-babe-f3d177fd2905"), null, new Guid("278605a9-2aa3-42d4-babe-f3d177fd2905"), "Ciselnik", "cs-CZ", "Nazev", "Odbornost" },
                    { new Guid("91579e92-7ad8-478e-8e3b-ea6140a5b7d9"), new Guid("599ce4bc-4222-42f1-a238-eaed3a4b0abd"), null, new Guid("599ce4bc-4222-42f1-a238-eaed3a4b0abd"), "Ciselnik", "en-US", "Popis", "Result of medical certificate" },
                    { new Guid("9807fec7-563d-46a3-bca1-6622de371add"), new Guid("278605a9-2aa3-42d4-babe-f3d177fd2905"), null, new Guid("278605a9-2aa3-42d4-babe-f3d177fd2905"), "Ciselnik", "en-US", "Nazev", "Specialty" },
                    { new Guid("999c5a85-4490-4cc8-9cce-5235e2cf2a65"), new Guid("aff0c688-3a22-46c8-8404-82c61101d642"), null, new Guid("aff0c688-3a22-46c8-8404-82c61101d642"), "Ciselnik", "en-US", "Popis", "Type of medical certificate" },
                    { new Guid("9f87bbab-541e-43c2-b277-8ecc19cd42e9"), new Guid("d8142494-0f9d-4f6c-b1aa-2a42d071b5e8"), null, new Guid("d8142494-0f9d-4f6c-b1aa-2a42d071b5e8"), "Ciselnik", "cs-CZ", "Popis", "Typ akce s posudkem" },
                    { new Guid("befaa12e-6c93-44ac-a794-8b593830cc82"), new Guid("599ce4bc-4222-42f1-a238-eaed3a4b0abd"), null, new Guid("599ce4bc-4222-42f1-a238-eaed3a4b0abd"), "Ciselnik", "en-US", "Nazev", "Result" },
                    { new Guid("ca1bca16-12d4-4a26-8f8a-b00e0a37fd52"), new Guid("aae6530b-15f1-4469-b5f6-4f69592ad15d"), null, new Guid("aae6530b-15f1-4469-b5f6-4f69592ad15d"), "Ciselnik", "en-US", "Nazev", "Operation type" },
                    { new Guid("d0c1d04d-3696-4b3b-a68b-68894660fc7b"), new Guid("278605a9-2aa3-42d4-babe-f3d177fd2905"), null, new Guid("278605a9-2aa3-42d4-babe-f3d177fd2905"), "Ciselnik", "cs-CZ", "Popis", "Lékařská odbornost" },
                    { new Guid("d1100919-b486-4482-a1b9-8f7e3d99a13a"), new Guid("aff0c688-3a22-46c8-8404-82c61101d642"), null, new Guid("aff0c688-3a22-46c8-8404-82c61101d642"), "Ciselnik", "en-US", "Nazev", "Type of certificate" },
                    { new Guid("d1b60674-af88-4475-b0af-13a1dfb1d12c"), new Guid("599ce4bc-4222-42f1-a238-eaed3a4b0abd"), null, new Guid("599ce4bc-4222-42f1-a238-eaed3a4b0abd"), "Ciselnik", "cs-CZ", "Nazev", "Výsledek" },
                    { new Guid("e3970c58-98f6-409d-be75-902da3817ce8"), new Guid("d8142494-0f9d-4f6c-b1aa-2a42d071b5e8"), null, new Guid("d8142494-0f9d-4f6c-b1aa-2a42d071b5e8"), "Ciselnik", "cs-CZ", "Nazev", "Typ akce" },
                    { new Guid("e6f1cbbe-e0ca-4e36-b663-cb588cd042ae"), new Guid("a14bffda-1149-4ec5-b79d-cdda839259c1"), null, new Guid("a14bffda-1149-4ec5-b79d-cdda839259c1"), "Ciselnik", "cs-CZ", "Popis", "Stav lékařského posudku" },
                    { new Guid("ec206853-eaa4-47d8-9f05-bfe23fdcf42f"), new Guid("9c599c83-1898-4d8a-aa18-3f867f8772a4"), null, new Guid("9c599c83-1898-4d8a-aa18-3f867f8772a4"), "Ciselnik", "en-US", "Nazev", "Driver applicant group" },
                    { new Guid("f851bcb7-6926-43b8-9596-68b1ed487300"), new Guid("9c599c83-1898-4d8a-aa18-3f867f8772a4"), null, new Guid("9c599c83-1898-4d8a-aa18-3f867f8772a4"), "Ciselnik", "cs-CZ", "Nazev", "Skupina žadatele řidič" },
                    { new Guid("027d1631-f498-4c49-9a8d-0930bc4d9f2d"), null, new Guid("69e3533b-2d45-4c6d-b8f8-2e2da0900cf5"), new Guid("69e3533b-2d45-4c6d-b8f8-2e2da0900cf5"), "CiselnikPolozka", "en-US", "Popis", "First medical examination" },
                    { new Guid("033ff235-6965-4b10-8604-7839b8d7e817"), null, new Guid("93f1f521-9613-47d4-b483-ce27821b7e5a"), new Guid("93f1f521-9613-47d4-b483-ce27821b7e5a"), "CiselnikPolozka", "en-US", "Popis", "Driver group A (motorcycles)" },
                    { new Guid("0478ee82-99dd-46de-b111-187cca3bd963"), null, new Guid("f0c80839-a28f-4698-8ecd-1a8eb7cb7778"), new Guid("f0c80839-a28f-4698-8ecd-1a8eb7cb7778"), "CiselnikPolozka", "en-US", "Nazev", "Driver certificate" },
                    { new Guid("07587291-6e91-4569-9eec-738ab04d0a88"), null, new Guid("f0c80839-a28f-4698-8ecd-1a8eb7cb7778"), new Guid("f0c80839-a28f-4698-8ecd-1a8eb7cb7778"), "CiselnikPolozka", "cs-CZ", "Nazev", "Řidičský posudek" },
                    { new Guid("180a30f6-e421-480e-871d-238ab93857cd"), null, new Guid("69e3533b-2d45-4c6d-b8f8-2e2da0900cf5"), new Guid("69e3533b-2d45-4c6d-b8f8-2e2da0900cf5"), "CiselnikPolozka", "en-US", "Nazev", "Initial examination" },
                    { new Guid("231e6ed5-3808-4e1a-a793-d34b7d015a05"), null, new Guid("93f1f521-9613-47d4-b483-ce27821b7e5a"), new Guid("93f1f521-9613-47d4-b483-ce27821b7e5a"), "CiselnikPolozka", "cs-CZ", "Nazev", "Skupina A" },
                    { new Guid("2e51e2d2-a07e-465a-8b52-0cf167bf73b1"), null, new Guid("d8270f50-c7ad-4653-b893-b5897f9d52b0"), new Guid("d8270f50-c7ad-4653-b893-b5897f9d52b0"), "CiselnikPolozka", "cs-CZ", "Nazev", "Oční lékař" },
                    { new Guid("3435e325-6611-47c8-aabb-53275a1adcf0"), null, new Guid("06cefa04-8612-4dcf-b196-46d435f1718b"), new Guid("06cefa04-8612-4dcf-b196-46d435f1718b"), "CiselnikPolozka", "cs-CZ", "Nazev", "Zneplatněný" },
                    { new Guid("3fae980b-d199-4899-9712-62b69afdc6e3"), null, new Guid("5dbb39ff-9d53-4c4a-956e-1e5fd88a0987"), new Guid("5dbb39ff-9d53-4c4a-956e-1e5fd88a0987"), "CiselnikPolozka", "en-US", "Nazev", "Fit" },
                    { new Guid("4148c5ee-8143-449b-a47a-63262c0fae29"), null, new Guid("06cefa04-8612-4dcf-b196-46d435f1718b"), new Guid("06cefa04-8612-4dcf-b196-46d435f1718b"), "CiselnikPolozka", "en-US", "Popis", "The certificate has been invalidated." },
                    { new Guid("472c0643-f333-452d-8462-3603d6aa0e5c"), null, new Guid("93f1f521-9613-47d4-b483-ce27821b7e5a"), new Guid("93f1f521-9613-47d4-b483-ce27821b7e5a"), "CiselnikPolozka", "en-US", "Nazev", "Group A" },
                    { new Guid("4b8d3135-59ae-4baa-a6f1-287d35502460"), null, new Guid("22743832-b044-4b23-bbb1-a109f7215467"), new Guid("22743832-b044-4b23-bbb1-a109f7215467"), "CiselnikPolozka", "en-US", "Nazev", "Unfit" },
                    { new Guid("503dc0b1-d17f-424e-9c04-c83f1b9453dd"), null, new Guid("82f7d36c-abd7-4e81-b29a-59873ac932a1"), new Guid("82f7d36c-abd7-4e81-b29a-59873ac932a1"), "CiselnikPolozka", "en-US", "Nazev", "Internal medicine" },
                    { new Guid("573b75f2-db88-4e2d-812f-36a743f091ac"), null, new Guid("80bfdd5b-19fd-4c59-bd51-382a7cc97815"), new Guid("80bfdd5b-19fd-4c59-bd51-382a7cc97815"), "CiselnikPolozka", "en-US", "Popis", "Issuance of new certificate" },
                    { new Guid("5850d2db-ed05-4dd8-98c9-2a29b13b2bce"), null, new Guid("ea9d54c9-aa27-4aec-bd71-5e74f18318e5"), new Guid("ea9d54c9-aa27-4aec-bd71-5e74f18318e5"), "CiselnikPolozka", "cs-CZ", "Nazev", "Vytvoření" },
                    { new Guid("5bb55986-3a35-4f5c-a4a5-2f8f196986f1"), null, new Guid("ea4b809d-35eb-47c7-bbf8-91b4b3528914"), new Guid("ea4b809d-35eb-47c7-bbf8-91b4b3528914"), "CiselnikPolozka", "cs-CZ", "Popis", "Zneplatnění posudku" },
                    { new Guid("60cf8d89-c0db-4fed-ab0f-e22c862e4cfa"), null, new Guid("91c091e9-2d8a-454a-952e-61a37a6daa0c"), new Guid("91c091e9-2d8a-454a-952e-61a37a6daa0c"), "CiselnikPolozka", "en-US", "Popis", "The certificate is valid." },
                    { new Guid("65d16cb8-1a1f-4f99-ac35-90d9c8c56e92"), null, new Guid("d8270f50-c7ad-4653-b893-b5897f9d52b0"), new Guid("d8270f50-c7ad-4653-b893-b5897f9d52b0"), "CiselnikPolozka", "cs-CZ", "Popis", "Oční lékař (oftalmolog)" },
                    { new Guid("68d74b78-276b-4ee5-9696-2eefc53ff11f"), null, new Guid("82f7d36c-abd7-4e81-b29a-59873ac932a1"), new Guid("82f7d36c-abd7-4e81-b29a-59873ac932a1"), "CiselnikPolozka", "cs-CZ", "Popis", "Lékař interního lékařství" },
                    { new Guid("69ef37dc-4ec7-4587-a8e3-8358d1420d2b"), null, new Guid("69e3533b-2d45-4c6d-b8f8-2e2da0900cf5"), new Guid("69e3533b-2d45-4c6d-b8f8-2e2da0900cf5"), "CiselnikPolozka", "cs-CZ", "Nazev", "Výchozí prohlídka" },
                    { new Guid("716dfab9-361b-43ee-a6f1-32f99111c746"), null, new Guid("d8270f50-c7ad-4653-b893-b5897f9d52b0"), new Guid("d8270f50-c7ad-4653-b893-b5897f9d52b0"), "CiselnikPolozka", "en-US", "Nazev", "Ophthalmologist" },
                    { new Guid("739aef0e-9ece-43cc-960a-a4ed8076cb0c"), null, new Guid("388f831b-4fb6-42e6-b049-35d14808db0b"), new Guid("388f831b-4fb6-42e6-b049-35d14808db0b"), "CiselnikPolozka", "en-US", "Popis", "Driver group B (cars)" },
                    { new Guid("8c4de44e-806b-401e-8947-d35d703b00ce"), null, new Guid("ea9d54c9-aa27-4aec-bd71-5e74f18318e5"), new Guid("ea9d54c9-aa27-4aec-bd71-5e74f18318e5"), "CiselnikPolozka", "cs-CZ", "Popis", "Vytvoření posudku" },
                    { new Guid("8e1eeb73-7a0a-400d-9fc9-093ce712a974"), null, new Guid("388f831b-4fb6-42e6-b049-35d14808db0b"), new Guid("388f831b-4fb6-42e6-b049-35d14808db0b"), "CiselnikPolozka", "cs-CZ", "Nazev", "Skupina B" },
                    { new Guid("91175483-d2fc-4716-acba-08353b081d1d"), null, new Guid("5dbb39ff-9d53-4c4a-956e-1e5fd88a0987"), new Guid("5dbb39ff-9d53-4c4a-956e-1e5fd88a0987"), "CiselnikPolozka", "cs-CZ", "Nazev", "Způsobilý" },
                    { new Guid("95d15029-a56e-42d3-94d0-e144cf153de6"), null, new Guid("80bfdd5b-19fd-4c59-bd51-382a7cc97815"), new Guid("80bfdd5b-19fd-4c59-bd51-382a7cc97815"), "CiselnikPolozka", "cs-CZ", "Nazev", "Vydání" },
                    { new Guid("9681e93f-f2db-493c-b5ef-94d6bcfbe968"), null, new Guid("f0c80839-a28f-4698-8ecd-1a8eb7cb7778"), new Guid("f0c80839-a28f-4698-8ecd-1a8eb7cb7778"), "CiselnikPolozka", "cs-CZ", "Popis", "Posudek pro řidiče motorových vozidel" },
                    { new Guid("98991224-6e9c-47c9-a197-ea0b67a4c27c"), null, new Guid("f0c80839-a28f-4698-8ecd-1a8eb7cb7778"), new Guid("f0c80839-a28f-4698-8ecd-1a8eb7cb7778"), "CiselnikPolozka", "en-US", "Popis", "Certificate for motor vehicle drivers" },
                    { new Guid("9dcaf0f1-f93e-43f3-acbf-5f861e17f31e"), null, new Guid("5dbb39ff-9d53-4c4a-956e-1e5fd88a0987"), new Guid("5dbb39ff-9d53-4c4a-956e-1e5fd88a0987"), "CiselnikPolozka", "en-US", "Popis", "Patient is fit to drive" },
                    { new Guid("a11ab03b-38cf-441d-b048-742d24d0e40c"), null, new Guid("91c091e9-2d8a-454a-952e-61a37a6daa0c"), new Guid("91c091e9-2d8a-454a-952e-61a37a6daa0c"), "CiselnikPolozka", "en-US", "Nazev", "Valid" },
                    { new Guid("a15d2f3c-f850-4e4d-92bb-d4264b34696a"), null, new Guid("ea4b809d-35eb-47c7-bbf8-91b4b3528914"), new Guid("ea4b809d-35eb-47c7-bbf8-91b4b3528914"), "CiselnikPolozka", "cs-CZ", "Nazev", "Zneplatnění" },
                    { new Guid("a24d9b74-5e02-49d8-bd9a-0662712f188f"), null, new Guid("22743832-b044-4b23-bbb1-a109f7215467"), new Guid("22743832-b044-4b23-bbb1-a109f7215467"), "CiselnikPolozka", "en-US", "Popis", "Patient is unfit to drive" },
                    { new Guid("a64d1eff-2e67-454c-b30c-18261a89a84f"), null, new Guid("80bfdd5b-19fd-4c59-bd51-382a7cc97815"), new Guid("80bfdd5b-19fd-4c59-bd51-382a7cc97815"), "CiselnikPolozka", "cs-CZ", "Popis", "Vydání nového posudku" },
                    { new Guid("aaefffc6-27a5-4715-ba79-f8ecfb1d2a5e"), null, new Guid("e5f46887-8028-4b62-9286-b2840eef4001"), new Guid("e5f46887-8028-4b62-9286-b2840eef4001"), "CiselnikPolozka", "cs-CZ", "Popis", "Opakovaná lékařská prohlídka" },
                    { new Guid("b589dc61-76ab-441a-84b4-073fd444bb8e"), null, new Guid("93f1f521-9613-47d4-b483-ce27821b7e5a"), new Guid("93f1f521-9613-47d4-b483-ce27821b7e5a"), "CiselnikPolozka", "cs-CZ", "Popis", "Řidičská skupina A (motocykly)" },
                    { new Guid("b8f8478e-4dac-4ce6-8577-b356cde69e1c"), null, new Guid("ea9d54c9-aa27-4aec-bd71-5e74f18318e5"), new Guid("ea9d54c9-aa27-4aec-bd71-5e74f18318e5"), "CiselnikPolozka", "en-US", "Popis", "Certificate creation" },
                    { new Guid("c0eb025d-0d26-40fb-88f7-03f51beb2762"), null, new Guid("82f7d36c-abd7-4e81-b29a-59873ac932a1"), new Guid("82f7d36c-abd7-4e81-b29a-59873ac932a1"), "CiselnikPolozka", "cs-CZ", "Nazev", "Interní lékař" },
                    { new Guid("c0ec0752-d01c-40b3-b940-a028b22f256e"), null, new Guid("5dbb39ff-9d53-4c4a-956e-1e5fd88a0987"), new Guid("5dbb39ff-9d53-4c4a-956e-1e5fd88a0987"), "CiselnikPolozka", "cs-CZ", "Popis", "Pacient je způsobilý k řízení" },
                    { new Guid("c14bf82f-fb0f-440c-94b9-c79d65bd8470"), null, new Guid("ea4b809d-35eb-47c7-bbf8-91b4b3528914"), new Guid("ea4b809d-35eb-47c7-bbf8-91b4b3528914"), "CiselnikPolozka", "en-US", "Nazev", "Invalidation" },
                    { new Guid("c63682c4-ae65-494d-82d8-86e003308a22"), null, new Guid("22743832-b044-4b23-bbb1-a109f7215467"), new Guid("22743832-b044-4b23-bbb1-a109f7215467"), "CiselnikPolozka", "cs-CZ", "Popis", "Pacient není způsobilý k řízení" },
                    { new Guid("c6960894-8698-432b-b0f2-82cde98e8e4d"), null, new Guid("ea4b809d-35eb-47c7-bbf8-91b4b3528914"), new Guid("ea4b809d-35eb-47c7-bbf8-91b4b3528914"), "CiselnikPolozka", "en-US", "Popis", "Certificate invalidation" },
                    { new Guid("c9ff9c22-bf7e-484f-905d-ac83dc429a41"), null, new Guid("06cefa04-8612-4dcf-b196-46d435f1718b"), new Guid("06cefa04-8612-4dcf-b196-46d435f1718b"), "CiselnikPolozka", "en-US", "Nazev", "Invalidated" },
                    { new Guid("cabce0bf-b8d3-4298-a038-7e17bc7fe760"), null, new Guid("e5f46887-8028-4b62-9286-b2840eef4001"), new Guid("e5f46887-8028-4b62-9286-b2840eef4001"), "CiselnikPolozka", "en-US", "Popis", "Repeated medical examination" },
                    { new Guid("cedbb8df-5004-420b-91b6-2323b19a5bb7"), null, new Guid("388f831b-4fb6-42e6-b049-35d14808db0b"), new Guid("388f831b-4fb6-42e6-b049-35d14808db0b"), "CiselnikPolozka", "en-US", "Nazev", "Group B" },
                    { new Guid("d0038089-a614-439a-8fb3-81d42b784b1f"), null, new Guid("82f7d36c-abd7-4e81-b29a-59873ac932a1"), new Guid("82f7d36c-abd7-4e81-b29a-59873ac932a1"), "CiselnikPolozka", "en-US", "Popis", "Internal medicine physician" },
                    { new Guid("d02b8ebe-3334-4d96-bce8-26dcf3f174b3"), null, new Guid("22743832-b044-4b23-bbb1-a109f7215467"), new Guid("22743832-b044-4b23-bbb1-a109f7215467"), "CiselnikPolozka", "cs-CZ", "Nazev", "Nezpůsobilý" },
                    { new Guid("d3e32bec-ceb0-495e-90ed-1a477dff07a1"), null, new Guid("80bfdd5b-19fd-4c59-bd51-382a7cc97815"), new Guid("80bfdd5b-19fd-4c59-bd51-382a7cc97815"), "CiselnikPolozka", "en-US", "Nazev", "Issuance" },
                    { new Guid("d5657426-93a7-4ada-8f65-1fa2e7d428f2"), null, new Guid("91c091e9-2d8a-454a-952e-61a37a6daa0c"), new Guid("91c091e9-2d8a-454a-952e-61a37a6daa0c"), "CiselnikPolozka", "cs-CZ", "Popis", "Posudek je platný." },
                    { new Guid("ddec5138-afb3-4ed9-8112-690ce0776399"), null, new Guid("91c091e9-2d8a-454a-952e-61a37a6daa0c"), new Guid("91c091e9-2d8a-454a-952e-61a37a6daa0c"), "CiselnikPolozka", "cs-CZ", "Nazev", "Platný" },
                    { new Guid("ded6a613-5a99-4225-a34e-03e498d4e55b"), null, new Guid("e5f46887-8028-4b62-9286-b2840eef4001"), new Guid("e5f46887-8028-4b62-9286-b2840eef4001"), "CiselnikPolozka", "en-US", "Nazev", "Periodic examination" },
                    { new Guid("dfd88391-2917-4672-a9d2-1fe87f08586d"), null, new Guid("06cefa04-8612-4dcf-b196-46d435f1718b"), new Guid("06cefa04-8612-4dcf-b196-46d435f1718b"), "CiselnikPolozka", "cs-CZ", "Popis", "Posudek byl zneplatněn." },
                    { new Guid("e0680f53-3ac2-4a0b-8258-4935b21c132f"), null, new Guid("ea9d54c9-aa27-4aec-bd71-5e74f18318e5"), new Guid("ea9d54c9-aa27-4aec-bd71-5e74f18318e5"), "CiselnikPolozka", "en-US", "Nazev", "Creation" },
                    { new Guid("e1fb0372-71b8-4c78-bb4a-51f23fc482ef"), null, new Guid("d8270f50-c7ad-4653-b893-b5897f9d52b0"), new Guid("d8270f50-c7ad-4653-b893-b5897f9d52b0"), "CiselnikPolozka", "en-US", "Popis", "Eye physician (ophthalmologist)" },
                    { new Guid("eea72213-d480-4c06-bffa-07144e6ad5b5"), null, new Guid("69e3533b-2d45-4c6d-b8f8-2e2da0900cf5"), new Guid("69e3533b-2d45-4c6d-b8f8-2e2da0900cf5"), "CiselnikPolozka", "cs-CZ", "Popis", "První lékařská prohlídka" },
                    { new Guid("fa9b5f56-a22d-4736-95c4-e7156ed2a701"), null, new Guid("e5f46887-8028-4b62-9286-b2840eef4001"), new Guid("e5f46887-8028-4b62-9286-b2840eef4001"), "CiselnikPolozka", "cs-CZ", "Nazev", "Periodická prohlídka" },
                    { new Guid("fc9c1ccf-afd2-4f75-a17e-98df8d7f95c3"), null, new Guid("388f831b-4fb6-42e6-b049-35d14808db0b"), new Guid("388f831b-4fb6-42e6-b049-35d14808db0b"), "CiselnikPolozka", "cs-CZ", "Popis", "Řidičská skupina B (automobily)" }
                });

            migrationBuilder.InsertData(
                table: "ZdravotnickyPracovnici",
                columns: new[] { "KrzpId", "Jmeno", "OdbornostId", "PoskytovatelId", "Prijmeni" },
                values: new object[,]
                {
                    { new Guid("613b2812-75f2-4dff-85c9-f884bc479385"), "Michal", new Guid("82f7d36c-abd7-4e81-b29a-59873ac932a1"), new Guid("bd009c28-b756-416d-9227-341928694587"), "Procházka" },
                    { new Guid("90755fe5-be32-41cc-9925-27b9648dc6df"), "Petr", new Guid("82f7d36c-abd7-4e81-b29a-59873ac932a1"), new Guid("5373f175-39ae-4082-8345-2434b0fa5d5d"), "Dvořák" },
                    { new Guid("f62d4576-4f54-4c10-90de-b479ea81b433"), "Anna", new Guid("d8270f50-c7ad-4653-b893-b5897f9d52b0"), new Guid("33bfad8b-102c-42f4-b78a-1ad49bdf5a42"), "Novotná" }
                });

            migrationBuilder.InsertData(
                table: "PosudekRos",
                columns: new[] { "Id", "DatumVystaveni", "DatumVytvoreni", "DruhPosudkuId", "DruhProhlidkyId", "KrzpId", "OpakovanyPosudekId", "PlatnostDo", "Rid", "SkupinaZadateleRidicId", "StavPosudkuId", "TypAkceId", "VysledekId" },
                values: new object[,]
                {
                    { new Guid("2fbef511-6099-4bef-b366-75470b13ce1a"), new DateTime(2026, 4, 16, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 16, 11, 3, 35, 144, DateTimeKind.Utc).AddTicks(1512), new Guid("f0c80839-a28f-4698-8ecd-1a8eb7cb7778"), new Guid("69e3533b-2d45-4c6d-b8f8-2e2da0900cf5"), new Guid("90755fe5-be32-41cc-9925-27b9648dc6df"), null, new DateTime(2027, 4, 16, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("a2e5324b-9ad8-4304-b7b9-e31b56d787f5"), new Guid("388f831b-4fb6-42e6-b049-35d14808db0b"), new Guid("91c091e9-2d8a-454a-952e-61a37a6daa0c"), new Guid("80bfdd5b-19fd-4c59-bd51-382a7cc97815"), new Guid("5dbb39ff-9d53-4c4a-956e-1e5fd88a0987") },
                    { new Guid("a15fd61e-7c4f-411d-9fd6-7348ef1ce3f3"), new DateTime(2026, 3, 17, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 17, 11, 3, 35, 144, DateTimeKind.Utc).AddTicks(1512), new Guid("f0c80839-a28f-4698-8ecd-1a8eb7cb7778"), new Guid("e5f46887-8028-4b62-9286-b2840eef4001"), new Guid("f62d4576-4f54-4c10-90de-b479ea81b433"), null, new DateTime(2026, 10, 16, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("68eff241-fd51-4b06-9c3c-05799f341d28"), new Guid("93f1f521-9613-47d4-b483-ce27821b7e5a"), new Guid("91c091e9-2d8a-454a-952e-61a37a6daa0c"), new Guid("80bfdd5b-19fd-4c59-bd51-382a7cc97815"), new Guid("5dbb39ff-9d53-4c4a-956e-1e5fd88a0987") }
                });

            migrationBuilder.InsertData(
                table: "PosudekRoHistories",
                columns: new[] { "Id", "DatumOperace", "KrzpId", "PosudekRoId", "TypOperaceId" },
                values: new object[,]
                {
                    { new Guid("0b4e6456-bc2e-4d51-992b-0da4fbdd3564"), new DateTime(2026, 4, 16, 11, 3, 35, 144, DateTimeKind.Utc).AddTicks(1512), new Guid("90755fe5-be32-41cc-9925-27b9648dc6df"), new Guid("2fbef511-6099-4bef-b366-75470b13ce1a"), new Guid("ea9d54c9-aa27-4aec-bd71-5e74f18318e5") },
                    { new Guid("d012fd1d-3fb9-4dde-a0a9-a06b3ce03e3f"), new DateTime(2026, 3, 17, 11, 3, 35, 144, DateTimeKind.Utc).AddTicks(1512), new Guid("f62d4576-4f54-4c10-90de-b479ea81b433"), new Guid("a15fd61e-7c4f-411d-9fd6-7348ef1ce3f3"), new Guid("ea9d54c9-aa27-4aec-bd71-5e74f18318e5") }
                });

            migrationBuilder.InsertData(
                table: "PosudekRoZpusobilosti",
                columns: new[] { "Id", "PosudekRoId", "SkupinaZadateleRidicId", "VysledekId" },
                values: new object[,]
                {
                    { new Guid("9d44e4e6-f7cd-41cf-b2a0-289c29faaea4"), new Guid("a15fd61e-7c4f-411d-9fd6-7348ef1ce3f3"), new Guid("93f1f521-9613-47d4-b483-ce27821b7e5a"), new Guid("5dbb39ff-9d53-4c4a-956e-1e5fd88a0987") },
                    { new Guid("9e0760f2-54af-4cb3-ba3e-c423b4b567bc"), new Guid("2fbef511-6099-4bef-b366-75470b13ce1a"), new Guid("388f831b-4fb6-42e6-b049-35d14808db0b"), new Guid("5dbb39ff-9d53-4c4a-956e-1e5fd88a0987") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CiselnikPolozky_CiselnikId_Kod",
                table: "CiselnikPolozky",
                columns: new[] { "CiselnikId", "Kod" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CiselnikPolozky_RodicId",
                table: "CiselnikPolozky",
                column: "RodicId");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRoHarmonizovaneKody_HarmonizovanyKodId",
                table: "PosudekRoHarmonizovaneKody",
                column: "HarmonizovanyKodId");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRoHarmonizovaneKody_PosudekRoZpusobilostId",
                table: "PosudekRoHarmonizovaneKody",
                column: "PosudekRoZpusobilostId");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRoHistories_KrzpId",
                table: "PosudekRoHistories",
                column: "KrzpId");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRoHistories_PosudekRoId",
                table: "PosudekRoHistories",
                column: "PosudekRoId");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRoHistories_TypOperaceId",
                table: "PosudekRoHistories",
                column: "TypOperaceId");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRoNarodniKody_NarodniKodId",
                table: "PosudekRoNarodniKody",
                column: "NarodniKodId");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRoNarodniKody_PosudekRoZpusobilostId",
                table: "PosudekRoNarodniKody",
                column: "PosudekRoZpusobilostId");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRoNarodniKody_SkupinaRoId",
                table: "PosudekRoNarodniKody",
                column: "SkupinaRoId");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRos_DruhPosudkuId",
                table: "PosudekRos",
                column: "DruhPosudkuId");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRos_DruhProhlidkyId",
                table: "PosudekRos",
                column: "DruhProhlidkyId");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRos_KrzpId",
                table: "PosudekRos",
                column: "KrzpId");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRos_Rid",
                table: "PosudekRos",
                column: "Rid");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRos_SkupinaZadateleRidicId",
                table: "PosudekRos",
                column: "SkupinaZadateleRidicId");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRos_StavPosudkuId",
                table: "PosudekRos",
                column: "StavPosudkuId");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRos_TypAkceId",
                table: "PosudekRos",
                column: "TypAkceId");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRos_VysledekId",
                table: "PosudekRos",
                column: "VysledekId");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRoSkupiny_PosudekRoZpusobilostId",
                table: "PosudekRoSkupiny",
                column: "PosudekRoZpusobilostId");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRoSkupiny_SkupinaRoId",
                table: "PosudekRoSkupiny",
                column: "SkupinaRoId");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRoZpusobilosti_PosudekRoId",
                table: "PosudekRoZpusobilosti",
                column: "PosudekRoId");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRoZpusobilosti_SkupinaZadateleRidicId",
                table: "PosudekRoZpusobilosti",
                column: "SkupinaZadateleRidicId");

            migrationBuilder.CreateIndex(
                name: "IX_PosudekRoZpusobilosti_VysledekId",
                table: "PosudekRoZpusobilosti",
                column: "VysledekId");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_CiselnikId",
                table: "Translations",
                column: "CiselnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_CiselnikPolozkaId",
                table: "Translations",
                column: "CiselnikPolozkaId");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_EntityType_EntityId_Language_PropertyName",
                table: "Translations",
                columns: new[] { "EntityType", "EntityId", "Language", "PropertyName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ZdravotnickyPracovnici_OdbornostId",
                table: "ZdravotnickyPracovnici",
                column: "OdbornostId");

            migrationBuilder.CreateIndex(
                name: "IX_ZdravotnickyPracovnici_PoskytovatelId",
                table: "ZdravotnickyPracovnici",
                column: "PoskytovatelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PosudekRoHarmonizovaneKody");

            migrationBuilder.DropTable(
                name: "PosudekRoHistories");

            migrationBuilder.DropTable(
                name: "PosudekRoNarodniKody");

            migrationBuilder.DropTable(
                name: "PosudekRoSkupiny");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.DropTable(
                name: "PosudekRoZpusobilosti");

            migrationBuilder.DropTable(
                name: "PosudekRos");

            migrationBuilder.DropTable(
                name: "Pacienti");

            migrationBuilder.DropTable(
                name: "ZdravotnickyPracovnici");

            migrationBuilder.DropTable(
                name: "CiselnikPolozky");

            migrationBuilder.DropTable(
                name: "PoskytovateleZdravotnickychSluzeb");

            migrationBuilder.DropTable(
                name: "Ciselniky");
        }
    }
}
