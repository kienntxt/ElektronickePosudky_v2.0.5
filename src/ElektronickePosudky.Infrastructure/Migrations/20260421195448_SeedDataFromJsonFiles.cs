using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ElektronickePosudky.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataFromJsonFiles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pacienti",
                keyColumn: "Rid",
                keyValue: new Guid("b362e8f1-99a7-4d68-8b95-ed3606949f25"));

            migrationBuilder.DeleteData(
                table: "PosudekRoHistories",
                keyColumn: "Id",
                keyValue: new Guid("0b4e6456-bc2e-4d51-992b-0da4fbdd3564"));

            migrationBuilder.DeleteData(
                table: "PosudekRoHistories",
                keyColumn: "Id",
                keyValue: new Guid("d012fd1d-3fb9-4dde-a0a9-a06b3ce03e3f"));

            migrationBuilder.DeleteData(
                table: "PosudekRoZpusobilosti",
                keyColumn: "Id",
                keyValue: new Guid("9d44e4e6-f7cd-41cf-b2a0-289c29faaea4"));

            migrationBuilder.DeleteData(
                table: "PosudekRoZpusobilosti",
                keyColumn: "Id",
                keyValue: new Guid("9e0760f2-54af-4cb3-ba3e-c423b4b567bc"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("027d1631-f498-4c49-9a8d-0930bc4d9f2d"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("033ff235-6965-4b10-8604-7839b8d7e817"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("0478ee82-99dd-46de-b111-187cca3bd963"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("07587291-6e91-4569-9eec-738ab04d0a88"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("0a6d0451-88df-41b9-9f9e-ba0cc3f308e7"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("180a30f6-e421-480e-871d-238ab93857cd"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("1e0737a3-2b8e-4039-858d-7b37d33ebe96"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("224d147d-3abe-4d9d-b98b-d74c92e56d15"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("231e6ed5-3808-4e1a-a793-d34b7d015a05"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("2e51e2d2-a07e-465a-8b52-0cf167bf73b1"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("31856937-429f-4bdb-a714-c19729bc4b59"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("31ae4019-93aa-4c96-8e42-ea105b9b8b5c"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("3435e325-6611-47c8-aabb-53275a1adcf0"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("35fded7b-a9db-4143-837f-4df98368454f"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("390b91d4-d284-42a6-9f50-cc74ecf008e6"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("3fae980b-d199-4899-9712-62b69afdc6e3"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("4148c5ee-8143-449b-a47a-63262c0fae29"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("472c0643-f333-452d-8462-3603d6aa0e5c"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("4b8d3135-59ae-4baa-a6f1-287d35502460"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("4bcc622d-094d-48b4-b87c-446965265de0"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("4bf4e35f-6f1b-420e-991f-7f84d2759a6b"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("4c7f5378-dc81-4cc0-87b8-4ab1e14ac5fc"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("503dc0b1-d17f-424e-9c04-c83f1b9453dd"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("55977a83-23a1-4a5c-8b96-53f5f6e221b9"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("573b75f2-db88-4e2d-812f-36a743f091ac"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("5850d2db-ed05-4dd8-98c9-2a29b13b2bce"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("5a0c662b-edee-4ef8-909b-7d21220f81e5"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("5bb55986-3a35-4f5c-a4a5-2f8f196986f1"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("5fb5c057-aa56-43d6-9752-6384f27d5d48"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("60cf8d89-c0db-4fed-ab0f-e22c862e4cfa"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("624dc3bf-69ec-4fc8-a68a-fff5813e99f2"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("65d16cb8-1a1f-4f99-ac35-90d9c8c56e92"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("670cccb2-a2c2-4ee3-9245-7ccfbae0b60f"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("67a6752d-5aee-41fb-b373-afe29825417b"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("68d74b78-276b-4ee5-9696-2eefc53ff11f"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("69ef37dc-4ec7-4587-a8e3-8358d1420d2b"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("6dae6354-7952-4709-8c78-c484d560e678"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("716dfab9-361b-43ee-a6f1-32f99111c746"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("739aef0e-9ece-43cc-960a-a4ed8076cb0c"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("86eaad43-638e-404b-b7de-a4f71a4c6f59"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("8922593c-d0a8-4f2a-81d6-061f3c85fedc"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("8c4de44e-806b-401e-8947-d35d703b00ce"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("8e1eeb73-7a0a-400d-9fc9-093ce712a974"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("91175483-d2fc-4716-acba-08353b081d1d"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("91579e92-7ad8-478e-8e3b-ea6140a5b7d9"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("95d15029-a56e-42d3-94d0-e144cf153de6"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("9681e93f-f2db-493c-b5ef-94d6bcfbe968"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("9807fec7-563d-46a3-bca1-6622de371add"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("98991224-6e9c-47c9-a197-ea0b67a4c27c"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("999c5a85-4490-4cc8-9cce-5235e2cf2a65"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("9dcaf0f1-f93e-43f3-acbf-5f861e17f31e"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("9f87bbab-541e-43c2-b277-8ecc19cd42e9"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("a11ab03b-38cf-441d-b048-742d24d0e40c"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("a15d2f3c-f850-4e4d-92bb-d4264b34696a"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("a24d9b74-5e02-49d8-bd9a-0662712f188f"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("a64d1eff-2e67-454c-b30c-18261a89a84f"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("aaefffc6-27a5-4715-ba79-f8ecfb1d2a5e"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("b589dc61-76ab-441a-84b4-073fd444bb8e"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("b8f8478e-4dac-4ce6-8577-b356cde69e1c"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("befaa12e-6c93-44ac-a794-8b593830cc82"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("c0eb025d-0d26-40fb-88f7-03f51beb2762"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("c0ec0752-d01c-40b3-b940-a028b22f256e"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("c14bf82f-fb0f-440c-94b9-c79d65bd8470"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("c63682c4-ae65-494d-82d8-86e003308a22"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("c6960894-8698-432b-b0f2-82cde98e8e4d"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("c9ff9c22-bf7e-484f-905d-ac83dc429a41"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("ca1bca16-12d4-4a26-8f8a-b00e0a37fd52"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("cabce0bf-b8d3-4298-a038-7e17bc7fe760"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("cedbb8df-5004-420b-91b6-2323b19a5bb7"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("d0038089-a614-439a-8fb3-81d42b784b1f"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("d02b8ebe-3334-4d96-bce8-26dcf3f174b3"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("d0c1d04d-3696-4b3b-a68b-68894660fc7b"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("d1100919-b486-4482-a1b9-8f7e3d99a13a"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("d1b60674-af88-4475-b0af-13a1dfb1d12c"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("d3e32bec-ceb0-495e-90ed-1a477dff07a1"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("d5657426-93a7-4ada-8f65-1fa2e7d428f2"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("ddec5138-afb3-4ed9-8112-690ce0776399"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("ded6a613-5a99-4225-a34e-03e498d4e55b"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("dfd88391-2917-4672-a9d2-1fe87f08586d"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("e0680f53-3ac2-4a0b-8258-4935b21c132f"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("e1fb0372-71b8-4c78-bb4a-51f23fc482ef"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("e3970c58-98f6-409d-be75-902da3817ce8"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("e6f1cbbe-e0ca-4e36-b663-cb588cd042ae"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("ec206853-eaa4-47d8-9f05-bfe23fdcf42f"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("eea72213-d480-4c06-bffa-07144e6ad5b5"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("f851bcb7-6926-43b8-9596-68b1ed487300"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("fa9b5f56-a22d-4736-95c4-e7156ed2a701"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("fc9c1ccf-afd2-4f75-a17e-98df8d7f95c3"));

            migrationBuilder.DeleteData(
                table: "ZdravotnickyPracovnici",
                keyColumn: "KrzpId",
                keyValue: new Guid("613b2812-75f2-4dff-85c9-f884bc479385"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("06cefa04-8612-4dcf-b196-46d435f1718b"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("22743832-b044-4b23-bbb1-a109f7215467"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("ea4b809d-35eb-47c7-bbf8-91b4b3528914"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("ea9d54c9-aa27-4aec-bd71-5e74f18318e5"));

            migrationBuilder.DeleteData(
                table: "PoskytovateleZdravotnickychSluzeb",
                keyColumn: "Id",
                keyValue: new Guid("bd009c28-b756-416d-9227-341928694587"));

            migrationBuilder.DeleteData(
                table: "PosudekRos",
                keyColumn: "Id",
                keyValue: new Guid("2fbef511-6099-4bef-b366-75470b13ce1a"));

            migrationBuilder.DeleteData(
                table: "PosudekRos",
                keyColumn: "Id",
                keyValue: new Guid("a15fd61e-7c4f-411d-9fd6-7348ef1ce3f3"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("388f831b-4fb6-42e6-b049-35d14808db0b"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("5dbb39ff-9d53-4c4a-956e-1e5fd88a0987"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("69e3533b-2d45-4c6d-b8f8-2e2da0900cf5"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("80bfdd5b-19fd-4c59-bd51-382a7cc97815"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("91c091e9-2d8a-454a-952e-61a37a6daa0c"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("93f1f521-9613-47d4-b483-ce27821b7e5a"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("e5f46887-8028-4b62-9286-b2840eef4001"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("f0c80839-a28f-4698-8ecd-1a8eb7cb7778"));

            migrationBuilder.DeleteData(
                table: "Ciselniky",
                keyColumn: "Id",
                keyValue: new Guid("aae6530b-15f1-4469-b5f6-4f69592ad15d"));

            migrationBuilder.DeleteData(
                table: "Pacienti",
                keyColumn: "Rid",
                keyValue: new Guid("68eff241-fd51-4b06-9c3c-05799f341d28"));

            migrationBuilder.DeleteData(
                table: "Pacienti",
                keyColumn: "Rid",
                keyValue: new Guid("a2e5324b-9ad8-4304-b7b9-e31b56d787f5"));

            migrationBuilder.DeleteData(
                table: "ZdravotnickyPracovnici",
                keyColumn: "KrzpId",
                keyValue: new Guid("90755fe5-be32-41cc-9925-27b9648dc6df"));

            migrationBuilder.DeleteData(
                table: "ZdravotnickyPracovnici",
                keyColumn: "KrzpId",
                keyValue: new Guid("f62d4576-4f54-4c10-90de-b479ea81b433"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("82f7d36c-abd7-4e81-b29a-59873ac932a1"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("d8270f50-c7ad-4653-b893-b5897f9d52b0"));

            migrationBuilder.DeleteData(
                table: "Ciselniky",
                keyColumn: "Id",
                keyValue: new Guid("599ce4bc-4222-42f1-a238-eaed3a4b0abd"));

            migrationBuilder.DeleteData(
                table: "Ciselniky",
                keyColumn: "Id",
                keyValue: new Guid("9c599c83-1898-4d8a-aa18-3f867f8772a4"));

            migrationBuilder.DeleteData(
                table: "Ciselniky",
                keyColumn: "Id",
                keyValue: new Guid("a14bffda-1149-4ec5-b79d-cdda839259c1"));

            migrationBuilder.DeleteData(
                table: "Ciselniky",
                keyColumn: "Id",
                keyValue: new Guid("a376442b-a991-4405-81fb-e923e7dde10a"));

            migrationBuilder.DeleteData(
                table: "Ciselniky",
                keyColumn: "Id",
                keyValue: new Guid("aff0c688-3a22-46c8-8404-82c61101d642"));

            migrationBuilder.DeleteData(
                table: "Ciselniky",
                keyColumn: "Id",
                keyValue: new Guid("d8142494-0f9d-4f6c-b1aa-2a42d071b5e8"));

            migrationBuilder.DeleteData(
                table: "PoskytovateleZdravotnickychSluzeb",
                keyColumn: "Id",
                keyValue: new Guid("33bfad8b-102c-42f4-b78a-1ad49bdf5a42"));

            migrationBuilder.DeleteData(
                table: "PoskytovateleZdravotnickychSluzeb",
                keyColumn: "Id",
                keyValue: new Guid("5373f175-39ae-4082-8345-2434b0fa5d5d"));

            migrationBuilder.DeleteData(
                table: "Ciselniky",
                keyColumn: "Id",
                keyValue: new Guid("278605a9-2aa3-42d4-babe-f3d177fd2905"));

            migrationBuilder.InsertData(
                table: "Ciselniky",
                columns: new[] { "Id", "Kod", "PlatnostDo", "PlatnostOd", "Termx", "TermxId", "TermxUrl", "Verze" },
                values: new object[,]
                {
                    { new Guid("00000001-0001-0000-0000-000002328856"), "akce-ro", null, new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "1.0.0" },
                    { new Guid("00000001-0002-0000-0000-000002328862"), "druh-posudku-ro", null, new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "1.0.0" },
                    { new Guid("00000001-0003-0000-0000-000002328865"), "druh-prohlidky-ro", null, new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "1.0.0" },
                    { new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", null, new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "1.0.0" },
                    { new Guid("00000001-0005-0000-0000-000002328868"), "seznam-narodni-kody-ro", null, new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "1.0.0" },
                    { new Guid("00000001-0006-0000-0000-000002328874"), "seznam-skupin-ro", null, new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "1.0.0" },
                    { new Guid("00000001-0007-0000-0000-000002328877"), "stav-posudku", null, new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "1.0.0" },
                    { new Guid("00000001-0008-0000-0000-000002328883"), "vysledek-posudku-ro", null, new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "1.0.0" },
                    { new Guid("00000001-0009-0000-0000-000002328886"), "skupina-zadatel-ridic-ro", null, new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "1.0.0" },
                    { new Guid("00000001-0010-0000-0000-000000000001"), "odbnornost", null, new DateTime(2025, 4, 21, 19, 54, 48, 144, DateTimeKind.Utc).AddTicks(2979), false, null, null, "1.0.0" }
                });

            migrationBuilder.InsertData(
                table: "Pacienti",
                columns: new[] { "Rid", "Adresa", "DatumNarozeni", "Doklad", "Email", "Jmeno", "Pohlavi", "Prijmeni" },
                values: new object[,]
                {
                    { new Guid("00000004-0000-0000-0000-000000000001"), "Praha 1, Václavské náměstí 1", new DateTime(1985, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AA123456", "jan.novak@example.com", "Jan", "M", "Novák" },
                    { new Guid("00000004-0000-0000-0000-000000000002"), "Brno, Náměstí Svobody 10", new DateTime(1990, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "BB654321", "marie.svobodova@example.com", "Marie", "F", "Svobodová" },
                    { new Guid("00000004-0000-0000-0000-000000000003"), "Ostrava, Masarykovo náměstí 5", new DateTime(1978, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "CC987654", "petr.dvorak@example.com", "Petr", "M", "Dvořák" }
                });

            migrationBuilder.InsertData(
                table: "PoskytovateleZdravotnickychSluzeb",
                columns: new[] { "Id", "Adresa", "Ico", "Nazev" },
                values: new object[,]
                {
                    { new Guid("00000006-0000-0000-0000-000000000001"), "Praha 2, Karlovo náměstí 10", "12345678", "Zdravotní zařízení s.r.o." },
                    { new Guid("00000006-0000-0000-0000-000000000002"), "Brno, Hlavní třída 25", "87654321", "Lékařská klinika Brno a.s." },
                    { new Guid("00000006-0000-0000-0000-000000000003"), "Ostrava, Polská 15", "11223344", "Oční ambulance Ostrava" }
                });

            migrationBuilder.InsertData(
                table: "CiselnikPolozky",
                columns: new[] { "Id", "CiselnikId", "CiselnikKod", "CiselnikVerze", "Kod", "RodicId", "Verze" },
                values: new object[,]
                {
                    { new Guid("00000002-0001-0000-0000-000002328601"), new Guid("00000001-0001-0000-0000-000002328856"), "akce-ro", "1.0.0", "akce_ro_3", null, "1.0.0" },
                    { new Guid("00000002-0001-0000-0000-000002328610"), new Guid("00000001-0001-0000-0000-000002328856"), "akce-ro", "1.0.0", "akce_ro_1", null, "1.0.0" },
                    { new Guid("00000002-0001-0000-0000-000002328612"), new Guid("00000001-0001-0000-0000-000002328856"), "akce-ro", "1.0.0", "akce_ro_2", null, "1.0.0" },
                    { new Guid("00000002-0002-0000-0000-000002328547"), new Guid("00000001-0002-0000-0000-000002328862"), "druh-posudku-ro", "1.0.0", "druh_posudku_ro_1", null, "1.0.0" },
                    { new Guid("00000002-0002-0000-0000-000002328552"), new Guid("00000001-0002-0000-0000-000002328862"), "druh-posudku-ro", "1.0.0", "druh_posudku_ro_4", null, "1.0.0" },
                    { new Guid("00000002-0002-0000-0000-000002328554"), new Guid("00000001-0002-0000-0000-000002328862"), "druh-posudku-ro", "1.0.0", "druh_posudku_ro_5", null, "1.0.0" },
                    { new Guid("00000002-0002-0000-0000-000002328606"), new Guid("00000001-0002-0000-0000-000002328862"), "druh-posudku-ro", "1.0.0", "druh_posudku_ro_2", null, "1.0.0" },
                    { new Guid("00000002-0002-0000-0000-000002328608"), new Guid("00000001-0002-0000-0000-000002328862"), "druh-posudku-ro", "1.0.0", "druh_posudku_ro_3", null, "1.0.0" },
                    { new Guid("00000002-0003-0000-0000-000002328544"), new Guid("00000001-0003-0000-0000-000002328865"), "druh-prohlidky-ro", "1.0.0", "druh_prohlidky_ro_1", null, "1.0.0" },
                    { new Guid("00000002-0003-0000-0000-000002328559"), new Guid("00000001-0003-0000-0000-000002328865"), "druh-prohlidky-ro", "1.0.0", "druh_prohlidky_ro_2", null, "1.0.0" },
                    { new Guid("00000002-0003-0000-0000-000002328561"), new Guid("00000001-0003-0000-0000-000002328865"), "druh-prohlidky-ro", "1.0.0", "druh_prohlidky_ro_3", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000001"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "43.01", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000002"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "10.02", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000003"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "10.04", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000004"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "20.07", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000005"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "25.09", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000006"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "35.05", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000007"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "20.03", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000008"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "31.04", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000009"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "25.01", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000010"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "44.02", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000011"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "42.05", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000012"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "42.01", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000013"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "25.05", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000014"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "44.10", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000015"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "63", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000016"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "64", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000017"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "61", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000018"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "62", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000019"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "40.05", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000020"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "67", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000021"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "40.01", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000022"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "65", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000023"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "66", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000024"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "35.02", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000025"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "25.08", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000026"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "01.02", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000027"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "01.01", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000028"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "40.09", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000029"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "31.03", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000030"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "20.14", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000031"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "44.12", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000032"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "44.11", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000033"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "44.03", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000034"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "01.07", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000035"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "01.06", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000036"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "25.04", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000037"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "01.05", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000038"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "43.04", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000039"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "15.04", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000040"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "15.03", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000041"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "15.02", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000042"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "15.01", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000043"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "32.02 ", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000044"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "40.06", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000045"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "78", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000046"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "40.14", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000047"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "42.03", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000048"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "20.09", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000049"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "35.03", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000050"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "44.08", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000051"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "20.05", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000052"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "31.02", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000053"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "44.04", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000054"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "33.02", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000055"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "20.13", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000056"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "20.01", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000057"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "25.03", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000058"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "43.03", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000059"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "43.07", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000060"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "32.01 ", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000061"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "40.15", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000062"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "47", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000063"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "03.01", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000064"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "43.02", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000065"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "45", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000066"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "03.02", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000067"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "46", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000068"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "02", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000069"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "40.11", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000070"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "44.09", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000071"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "35.04", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000072"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "20.04", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000073"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "33.01", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000074"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "20.12", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000075"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "44.01", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000076"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "31.01", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000077"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "20.06", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000078"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "25.06", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000079"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "43.06", null, "1.0.0" },
                    { new Guid("00000002-0004-0000-0000-000000000080"), new Guid("00000001-0004-0000-0000-000002328890"), "seznam-harmonizovane-kody-ro", "1.0.0", "50", null, "1.0.0" },
                    { new Guid("00000002-0005-0000-0000-000000000001"), new Guid("00000001-0005-0000-0000-000002328868"), "seznam-narodni-kody-ro", "1.0.0", "185", null, "1.0.0" },
                    { new Guid("00000002-0005-0000-0000-000000000002"), new Guid("00000001-0005-0000-0000-000002328868"), "seznam-narodni-kody-ro", "1.0.0", "111a", null, "1.0.0" },
                    { new Guid("00000002-0005-0000-0000-000000000003"), new Guid("00000001-0005-0000-0000-000002328868"), "seznam-narodni-kody-ro", "1.0.0", "111b", null, "1.0.0" },
                    { new Guid("00000002-0005-0000-0000-000000000004"), new Guid("00000001-0005-0000-0000-000002328868"), "seznam-narodni-kody-ro", "1.0.0", "175", null, "1.0.0" },
                    { new Guid("00000002-0005-0000-0000-000000000005"), new Guid("00000001-0005-0000-0000-000002328868"), "seznam-narodni-kody-ro", "1.0.0", "111c", null, "1.0.0" },
                    { new Guid("00000002-0005-0000-0000-000000000006"), new Guid("00000001-0005-0000-0000-000002328868"), "seznam-narodni-kody-ro", "1.0.0", "160", null, "1.0.0" },
                    { new Guid("00000002-0005-0000-0000-000000000007"), new Guid("00000001-0005-0000-0000-000002328868"), "seznam-narodni-kody-ro", "1.0.0", "172", null, "1.0.0" },
                    { new Guid("00000002-0005-0000-0000-000000000008"), new Guid("00000001-0005-0000-0000-000002328868"), "seznam-narodni-kody-ro", "1.0.0", "115", null, "1.0.0" },
                    { new Guid("00000002-0005-0000-0000-000000000009"), new Guid("00000001-0005-0000-0000-000002328868"), "seznam-narodni-kody-ro", "1.0.0", "105", null, "1.0.0" },
                    { new Guid("00000002-0005-0000-0000-000000000010"), new Guid("00000001-0005-0000-0000-000002328868"), "seznam-narodni-kody-ro", "1.0.0", "199", null, "1.0.0" },
                    { new Guid("00000002-0006-0000-0000-000000000001"), new Guid("00000001-0006-0000-0000-000002328874"), "seznam-skupin-ro", "1.0.0", "B", null, "1.0.0" },
                    { new Guid("00000002-0006-0000-0000-000000000002"), new Guid("00000001-0006-0000-0000-000002328874"), "seznam-skupin-ro", "1.0.0", "A", null, "1.0.0" },
                    { new Guid("00000002-0006-0000-0000-000000000003"), new Guid("00000001-0006-0000-0000-000002328874"), "seznam-skupin-ro", "1.0.0", "D", null, "1.0.0" },
                    { new Guid("00000002-0006-0000-0000-000000000004"), new Guid("00000001-0006-0000-0000-000002328874"), "seznam-skupin-ro", "1.0.0", "BE", null, "1.0.0" },
                    { new Guid("00000002-0006-0000-0000-000000000005"), new Guid("00000001-0006-0000-0000-000002328874"), "seznam-skupin-ro", "1.0.0", "C", null, "1.0.0" },
                    { new Guid("00000002-0006-0000-0000-000000000006"), new Guid("00000001-0006-0000-0000-000002328874"), "seznam-skupin-ro", "1.0.0", "DE", null, "1.0.0" },
                    { new Guid("00000002-0006-0000-0000-000000000007"), new Guid("00000001-0006-0000-0000-000002328874"), "seznam-skupin-ro", "1.0.0", "CE", null, "1.0.0" },
                    { new Guid("00000002-0006-0000-0000-000000000008"), new Guid("00000001-0006-0000-0000-000002328874"), "seznam-skupin-ro", "1.0.0", "D1", null, "1.0.0" },
                    { new Guid("00000002-0006-0000-0000-000000000009"), new Guid("00000001-0006-0000-0000-000002328874"), "seznam-skupin-ro", "1.0.0", "C1", null, "1.0.0" },
                    { new Guid("00000002-0006-0000-0000-000000000010"), new Guid("00000001-0006-0000-0000-000002328874"), "seznam-skupin-ro", "1.0.0", "C1E", null, "1.0.0" },
                    { new Guid("00000002-0006-0000-0000-000000000011"), new Guid("00000001-0006-0000-0000-000002328874"), "seznam-skupin-ro", "1.0.0", "AM", null, "1.0.0" },
                    { new Guid("00000002-0006-0000-0000-000000000012"), new Guid("00000001-0006-0000-0000-000002328874"), "seznam-skupin-ro", "1.0.0", "D1E", null, "1.0.0" },
                    { new Guid("00000002-0006-0000-0000-000000000013"), new Guid("00000001-0006-0000-0000-000002328874"), "seznam-skupin-ro", "1.0.0", "T", null, "1.0.0" },
                    { new Guid("00000002-0006-0000-0000-000000000014"), new Guid("00000001-0006-0000-0000-000002328874"), "seznam-skupin-ro", "1.0.0", "A2", null, "1.0.0" },
                    { new Guid("00000002-0006-0000-0000-000000000015"), new Guid("00000001-0006-0000-0000-000002328874"), "seznam-skupin-ro", "1.0.0", "B1", null, "1.0.0" },
                    { new Guid("00000002-0006-0000-0000-000000000016"), new Guid("00000001-0006-0000-0000-000002328874"), "seznam-skupin-ro", "1.0.0", "A1", null, "1.0.0" },
                    { new Guid("00000002-0007-0000-0000-000002328671"), new Guid("00000001-0007-0000-0000-000002328877"), "stav-posudku", "1.0.0", "stav_posudku_3", null, "1.0.0" },
                    { new Guid("00000002-0007-0000-0000-000002328680"), new Guid("00000001-0007-0000-0000-000002328877"), "stav-posudku", "1.0.0", "stav_posudku_1", null, "1.0.0" },
                    { new Guid("00000002-0007-0000-0000-000002328681"), new Guid("00000001-0007-0000-0000-000002328877"), "stav-posudku", "1.0.0", "stav_posudku_2", null, "1.0.0" },
                    { new Guid("00000002-0008-0000-0000-000002328678"), new Guid("00000001-0008-0000-0000-000002328883"), "vysledek-posudku-ro", "1.0.0", "vysledek_posudku_ro_1", null, "1.0.0" },
                    { new Guid("00000002-0008-0000-0000-000002328682"), new Guid("00000001-0008-0000-0000-000002328883"), "vysledek-posudku-ro", "1.0.0", "vysledek_posudku_ro_2", null, "1.0.0" },
                    { new Guid("00000002-0008-0000-0000-000002328684"), new Guid("00000001-0008-0000-0000-000002328883"), "vysledek-posudku-ro", "1.0.0", "vysledek_posudku_ro_3", null, "1.0.0" },
                    { new Guid("00000002-0009-0000-0000-000002328673"), new Guid("00000001-0009-0000-0000-000002328886"), "skupina-zadatel-ridic-ro", "1.0.0", "skupina_ro_1", null, "1.0.0" },
                    { new Guid("00000002-0009-0000-0000-000002328675"), new Guid("00000001-0009-0000-0000-000002328886"), "skupina-zadatel-ridic-ro", "1.0.0", "skupina_ro_2", null, "1.0.0" },
                    { new Guid("00000002-0010-0000-0000-000000000001"), new Guid("00000001-0010-0000-0000-000000000001"), "odbnornost", "1.0.0", "interni", null, "1.0.0" },
                    { new Guid("00000002-0010-0000-0000-000000000002"), new Guid("00000001-0010-0000-0000-000000000001"), "odbnornost", "1.0.0", "okulista", null, "1.0.0" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CiselnikId", "CiselnikPolozkaId", "EntityId", "EntityType", "Language", "PropertyName", "Value" },
                values: new object[,]
                {
                    { new Guid("00000003-0001-0000-0000-000000000001"), new Guid("00000001-0001-0000-0000-000002328856"), null, new Guid("00000001-0001-0000-0000-000002328856"), "Ciselnik", "cs-CZ", "Nazev", "Typ akce" },
                    { new Guid("00000003-0001-0000-0000-000000000002"), new Guid("00000001-0001-0000-0000-000002328856"), null, new Guid("00000001-0001-0000-0000-000002328856"), "Ciselnik", "cs-CZ", "Popis", "Typ akce s posudkem" },
                    { new Guid("00000003-0001-0000-0000-000000000003"), new Guid("00000001-0001-0000-0000-000002328856"), null, new Guid("00000001-0001-0000-0000-000002328856"), "Ciselnik", "en-US", "Nazev", "Type of action" },
                    { new Guid("00000003-0001-0000-0000-000000000004"), new Guid("00000001-0001-0000-0000-000002328856"), null, new Guid("00000001-0001-0000-0000-000002328856"), "Ciselnik", "en-US", "Popis", "Type of action with certificate" },
                    { new Guid("00000003-0002-0000-0000-000000000001"), new Guid("00000001-0002-0000-0000-000002328862"), null, new Guid("00000001-0002-0000-0000-000002328862"), "Ciselnik", "cs-CZ", "Nazev", "Druh posudku" },
                    { new Guid("00000003-0002-0000-0000-000000000002"), new Guid("00000001-0002-0000-0000-000002328862"), null, new Guid("00000001-0002-0000-0000-000002328862"), "Ciselnik", "cs-CZ", "Popis", "Typ lékařského posudku" },
                    { new Guid("00000003-0002-0000-0000-000000000003"), new Guid("00000001-0002-0000-0000-000002328862"), null, new Guid("00000001-0002-0000-0000-000002328862"), "Ciselnik", "en-US", "Nazev", "Type of report" },
                    { new Guid("00000003-0002-0000-0000-000000000004"), new Guid("00000001-0002-0000-0000-000002328862"), null, new Guid("00000001-0002-0000-0000-000002328862"), "Ciselnik", "en-US", "Popis", "Type of medical report" },
                    { new Guid("00000003-0003-0000-0000-000000000001"), new Guid("00000001-0003-0000-0000-000002328865"), null, new Guid("00000001-0003-0000-0000-000002328865"), "Ciselnik", "cs-CZ", "Nazev", "Druh prohlídky" },
                    { new Guid("00000003-0003-0000-0000-000000000002"), new Guid("00000001-0003-0000-0000-000002328865"), null, new Guid("00000001-0003-0000-0000-000002328865"), "Ciselnik", "cs-CZ", "Popis", "Typ lékařské prohlídky" },
                    { new Guid("00000003-0003-0000-0000-000000000003"), new Guid("00000001-0003-0000-0000-000002328865"), null, new Guid("00000001-0003-0000-0000-000002328865"), "Ciselnik", "en-US", "Nazev", "Type of examination" },
                    { new Guid("00000003-0003-0000-0000-000000000004"), new Guid("00000001-0003-0000-0000-000002328865"), null, new Guid("00000001-0003-0000-0000-000002328865"), "Ciselnik", "en-US", "Popis", "Type of medical examination" },
                    { new Guid("00000003-0004-0000-0000-000000000001"), new Guid("00000001-0004-0000-0000-000002328890"), null, new Guid("00000001-0004-0000-0000-000002328890"), "Ciselnik", "cs-CZ", "Nazev", "Harmonizovane kódy" },
                    { new Guid("00000003-0004-0000-0000-000000000002"), new Guid("00000001-0004-0000-0000-000002328890"), null, new Guid("00000001-0004-0000-0000-000002328890"), "Ciselnik", "cs-CZ", "Popis", "Harmonizované kódy pro omezení Mas" },
                    { new Guid("00000003-0004-0000-0000-000000000003"), new Guid("00000001-0004-0000-0000-000002328890"), null, new Guid("00000001-0004-0000-0000-000002328890"), "Ciselnik", "en-US", "Nazev", "Harmonised codes" },
                    { new Guid("00000003-0004-0000-0000-000000000004"), new Guid("00000001-0004-0000-0000-000002328890"), null, new Guid("00000001-0004-0000-0000-000002328890"), "Ciselnik", "en-US", "Popis", "Harmonised codes for the restriction of Mas" },
                    { new Guid("00000003-0005-0000-0000-000000000001"), new Guid("00000001-0005-0000-0000-000002328868"), null, new Guid("00000001-0005-0000-0000-000002328868"), "Ciselnik", "cs-CZ", "Nazev", "Národní kódy" },
                    { new Guid("00000003-0005-0000-0000-000000000002"), new Guid("00000001-0005-0000-0000-000002328868"), null, new Guid("00000001-0005-0000-0000-000002328868"), "Ciselnik", "cs-CZ", "Popis", "Národní kódy pro omezení MA" },
                    { new Guid("00000003-0005-0000-0000-000000000003"), new Guid("00000001-0005-0000-0000-000002328868"), null, new Guid("00000001-0005-0000-0000-000002328868"), "Ciselnik", "en-US", "Nazev", "National codes" },
                    { new Guid("00000003-0005-0000-0000-000000000004"), new Guid("00000001-0005-0000-0000-000002328868"), null, new Guid("00000001-0005-0000-0000-000002328868"), "Ciselnik", "en-US", "Popis", "National codes for MA restrictions" },
                    { new Guid("00000003-0006-0000-0000-000000000001"), new Guid("00000001-0006-0000-0000-000002328874"), null, new Guid("00000001-0006-0000-0000-000002328874"), "Ciselnik", "cs-CZ", "Nazev", "Seznam skupin" },
                    { new Guid("00000003-0006-0000-0000-000000000002"), new Guid("00000001-0006-0000-0000-000002328874"), null, new Guid("00000001-0006-0000-0000-000002328874"), "Ciselnik", "cs-CZ", "Popis", "Seznam skupin" },
                    { new Guid("00000003-0006-0000-0000-000000000003"), new Guid("00000001-0006-0000-0000-000002328874"), null, new Guid("00000001-0006-0000-0000-000002328874"), "Ciselnik", "en-US", "Nazev", "List of groups" },
                    { new Guid("00000003-0006-0000-0000-000000000004"), new Guid("00000001-0006-0000-0000-000002328874"), null, new Guid("00000001-0006-0000-0000-000002328874"), "Ciselnik", "en-US", "Popis", "Driving License Groups" },
                    { new Guid("00000003-0007-0000-0000-000000000001"), new Guid("00000001-0007-0000-0000-000002328877"), null, new Guid("00000001-0007-0000-0000-000002328877"), "Ciselnik", "cs-CZ", "Nazev", "Stav posudku" },
                    { new Guid("00000003-0007-0000-0000-000000000002"), new Guid("00000001-0007-0000-0000-000002328877"), null, new Guid("00000001-0007-0000-0000-000002328877"), "Ciselnik", "cs-CZ", "Popis", "Stav lékařského posudku" },
                    { new Guid("00000003-0007-0000-0000-000000000003"), new Guid("00000001-0007-0000-0000-000002328877"), null, new Guid("00000001-0007-0000-0000-000002328877"), "Ciselnik", "en-US", "Nazev", "Medical Opinion Status" },
                    { new Guid("00000003-0007-0000-0000-000000000004"), new Guid("00000001-0007-0000-0000-000002328877"), null, new Guid("00000001-0007-0000-0000-000002328877"), "Ciselnik", "en-US", "Popis", "Medical Opinion Status" },
                    { new Guid("00000003-0008-0000-0000-000000000001"), new Guid("00000001-0008-0000-0000-000002328883"), null, new Guid("00000001-0008-0000-0000-000002328883"), "Ciselnik", "cs-CZ", "Nazev", "Výsledek" },
                    { new Guid("00000003-0008-0000-0000-000000000002"), new Guid("00000001-0008-0000-0000-000002328883"), null, new Guid("00000001-0008-0000-0000-000002328883"), "Ciselnik", "cs-CZ", "Popis", "Výsledek lékařského posudku" },
                    { new Guid("00000003-0008-0000-0000-000000000003"), new Guid("00000001-0008-0000-0000-000002328883"), null, new Guid("00000001-0008-0000-0000-000002328883"), "Ciselnik", "en-US", "Nazev", "Result" },
                    { new Guid("00000003-0008-0000-0000-000000000004"), new Guid("00000001-0008-0000-0000-000002328883"), null, new Guid("00000001-0008-0000-0000-000002328883"), "Ciselnik", "en-US", "Popis", "Medical conclusion, competence." },
                    { new Guid("00000003-0009-0000-0000-000000000001"), new Guid("00000001-0009-0000-0000-000002328886"), null, new Guid("00000001-0009-0000-0000-000002328886"), "Ciselnik", "cs-CZ", "Nazev", "Skupina žadatele řidič" },
                    { new Guid("00000003-0009-0000-0000-000000000002"), new Guid("00000001-0009-0000-0000-000002328886"), null, new Guid("00000001-0009-0000-0000-000002328886"), "Ciselnik", "cs-CZ", "Popis", "Skupina řidičského oprávnění" },
                    { new Guid("00000003-0009-0000-0000-000000000003"), new Guid("00000001-0009-0000-0000-000002328886"), null, new Guid("00000001-0009-0000-0000-000002328886"), "Ciselnik", "en-US", "Nazev", "Driver applicant group" },
                    { new Guid("00000003-0009-0000-0000-000000000004"), new Guid("00000001-0009-0000-0000-000002328886"), null, new Guid("00000001-0009-0000-0000-000002328886"), "Ciselnik", "en-US", "Popis", "Group of applicants, holders of driving licences" },
                    { new Guid("00000003-0010-0000-0000-000000000001"), new Guid("00000001-0010-0000-0000-000000000001"), null, new Guid("00000001-0010-0000-0000-000000000001"), "Ciselnik", "cs-CZ", "Nazev", "Odbornost" },
                    { new Guid("00000003-0010-0000-0000-000000000002"), new Guid("00000001-0010-0000-0000-000000000001"), null, new Guid("00000001-0010-0000-0000-000000000001"), "Ciselnik", "cs-CZ", "Popis", "Lékařská odbornost" },
                    { new Guid("00000003-0010-0000-0000-000000000003"), new Guid("00000001-0010-0000-0000-000000000001"), null, new Guid("00000001-0010-0000-0000-000000000001"), "Ciselnik", "en-US", "Nazev", "Specialty" },
                    { new Guid("00000003-0010-0000-0000-000000000004"), new Guid("00000001-0010-0000-0000-000000000001"), null, new Guid("00000001-0010-0000-0000-000000000001"), "Ciselnik", "en-US", "Popis", "Medical specialty" },
                    { new Guid("00000003-0001-0000-0000-000000000005"), null, new Guid("00000002-0001-0000-0000-000002328610"), new Guid("00000002-0001-0000-0000-000002328610"), "CiselnikPolozka", "cs-CZ", "Nazev", "vytvoření" },
                    { new Guid("00000003-0001-0000-0000-000000000006"), null, new Guid("00000002-0001-0000-0000-000002328612"), new Guid("00000002-0001-0000-0000-000002328612"), "CiselnikPolozka", "cs-CZ", "Nazev", "aktualizace" },
                    { new Guid("00000003-0001-0000-0000-000000000007"), null, new Guid("00000002-0001-0000-0000-000002328601"), new Guid("00000002-0001-0000-0000-000002328601"), "CiselnikPolozka", "cs-CZ", "Nazev", "zneplatnění" },
                    { new Guid("00000003-0001-0000-0000-000000000008"), null, new Guid("00000002-0001-0000-0000-000002328610"), new Guid("00000002-0001-0000-0000-000002328610"), "CiselnikPolozka", "cs-CZ", "Popis", "Vytvoření lékařského posudku." },
                    { new Guid("00000003-0001-0000-0000-000000000009"), null, new Guid("00000002-0001-0000-0000-000002328612"), new Guid("00000002-0001-0000-0000-000002328612"), "CiselnikPolozka", "cs-CZ", "Popis", "Aktualizace lékařského posudku." },
                    { new Guid("00000003-0001-0000-0000-000000000010"), null, new Guid("00000002-0001-0000-0000-000002328601"), new Guid("00000002-0001-0000-0000-000002328601"), "CiselnikPolozka", "cs-CZ", "Popis", "Zneplatnění lékařského posudku." },
                    { new Guid("00000003-0002-0000-0000-000000000005"), null, new Guid("00000002-0002-0000-0000-000002328606"), new Guid("00000002-0002-0000-0000-000002328606"), "CiselnikPolozka", "cs-CZ", "Nazev", "rozšíření řidičského oprávnění" },
                    { new Guid("00000003-0002-0000-0000-000000000006"), null, new Guid("00000002-0002-0000-0000-000002328547"), new Guid("00000002-0002-0000-0000-000002328547"), "CiselnikPolozka", "cs-CZ", "Nazev", "prvořidič" },
                    { new Guid("00000003-0002-0000-0000-000000000007"), null, new Guid("00000002-0002-0000-0000-000002328552"), new Guid("00000002-0002-0000-0000-000002328552"), "CiselnikPolozka", "cs-CZ", "Nazev", "senioři" },
                    { new Guid("00000003-0002-0000-0000-000000000008"), null, new Guid("00000002-0002-0000-0000-000002328608"), new Guid("00000002-0002-0000-0000-000002328608"), "CiselnikPolozka", "cs-CZ", "Nazev", "prodloužení řidičského oprávnění" },
                    { new Guid("00000003-0002-0000-0000-000000000009"), null, new Guid("00000002-0002-0000-0000-000002328554"), new Guid("00000002-0002-0000-0000-000002328554"), "CiselnikPolozka", "cs-CZ", "Nazev", "přezkoumání způsobilosti" },
                    { new Guid("00000003-0002-0000-0000-000000000010"), null, new Guid("00000002-0002-0000-0000-000002328606"), new Guid("00000002-0002-0000-0000-000002328606"), "CiselnikPolozka", "cs-CZ", "Popis", "Rozšíření řidičského oprávnění." },
                    { new Guid("00000003-0002-0000-0000-000000000011"), null, new Guid("00000002-0002-0000-0000-000002328547"), new Guid("00000002-0002-0000-0000-000002328547"), "CiselnikPolozka", "cs-CZ", "Popis", "Vydání řidičského oprávnění (prvořidič)." },
                    { new Guid("00000003-0002-0000-0000-000000000012"), null, new Guid("00000002-0002-0000-0000-000002328552"), new Guid("00000002-0002-0000-0000-000002328552"), "CiselnikPolozka", "cs-CZ", "Popis", "Řidičské oprávnění pro seniory." },
                    { new Guid("00000003-0002-0000-0000-000000000013"), null, new Guid("00000002-0002-0000-0000-000002328608"), new Guid("00000002-0002-0000-0000-000002328608"), "CiselnikPolozka", "cs-CZ", "Popis", "Prodloužení řidičského oprávnění." },
                    { new Guid("00000003-0002-0000-0000-000000000014"), null, new Guid("00000002-0002-0000-0000-000002328554"), new Guid("00000002-0002-0000-0000-000002328554"), "CiselnikPolozka", "cs-CZ", "Popis", "Přezkoumání způsobilosti." },
                    { new Guid("00000003-0003-0000-0000-000000000005"), null, new Guid("00000002-0003-0000-0000-000002328561"), new Guid("00000002-0003-0000-0000-000002328561"), "CiselnikPolozka", "cs-CZ", "Nazev", "mimořádná" },
                    { new Guid("00000003-0003-0000-0000-000000000006"), null, new Guid("00000002-0003-0000-0000-000002328559"), new Guid("00000002-0003-0000-0000-000002328559"), "CiselnikPolozka", "cs-CZ", "Nazev", "pravidelná" },
                    { new Guid("00000003-0003-0000-0000-000000000007"), null, new Guid("00000002-0003-0000-0000-000002328544"), new Guid("00000002-0003-0000-0000-000002328544"), "CiselnikPolozka", "cs-CZ", "Nazev", "vstupní" },
                    { new Guid("00000003-0003-0000-0000-000000000008"), null, new Guid("00000002-0003-0000-0000-000002328561"), new Guid("00000002-0003-0000-0000-000002328561"), "CiselnikPolozka", "cs-CZ", "Popis", "Mimořádná lékařská prohlídka." },
                    { new Guid("00000003-0003-0000-0000-000000000009"), null, new Guid("00000002-0003-0000-0000-000002328559"), new Guid("00000002-0003-0000-0000-000002328559"), "CiselnikPolozka", "cs-CZ", "Popis", "Pravidelná lékařská prohlídka." },
                    { new Guid("00000003-0003-0000-0000-000000000010"), null, new Guid("00000002-0003-0000-0000-000002328544"), new Guid("00000002-0003-0000-0000-000002328544"), "CiselnikPolozka", "cs-CZ", "Popis", "Vstupní lékařská prohlídka." },
                    { new Guid("00000003-0004-0000-0000-000000000005"), null, new Guid("00000002-0004-0000-0000-000000000001"), new Guid("00000002-0004-0000-0000-000000000001"), "CiselnikPolozka", "cs-CZ", "Nazev", "43.01 Výška sedadla řidiče umožňující normální výhled a v normální vzdálenosti od-volantu a pedálů" },
                    { new Guid("00000003-0004-0000-0000-000000000006"), null, new Guid("00000002-0004-0000-0000-000000000002"), new Guid("00000002-0004-0000-0000-000000000002"), "CiselnikPolozka", "cs-CZ", "Nazev", "10.02 Automatická převodovka" },
                    { new Guid("00000003-0004-0000-0000-000000000007"), null, new Guid("00000002-0004-0000-0000-000000000003"), new Guid("00000002-0004-0000-0000-000000000003"), "CiselnikPolozka", "cs-CZ", "Nazev", "10.04 Přizpůsobené ústrojí ovládání převodovky" },
                    { new Guid("00000003-0004-0000-0000-000000000008"), null, new Guid("00000002-0004-0000-0000-000000000004"), new Guid("00000002-0004-0000-0000-000000000004"), "CiselnikPolozka", "cs-CZ", "Nazev", "20.07 Ovládání brzdy s použitím maximální síly ... N [například: 20.07(300 N)]" },
                    { new Guid("00000003-0004-0000-0000-000000000009"), null, new Guid("00000002-0004-0000-0000-000000000005"), new Guid("00000002-0004-0000-0000-000000000005"), "CiselnikPolozka", "cs-CZ", "Nazev", "25.09 Opatření proti zablokování nebo aktivaci akcelerátoru" },
                    { new Guid("00000003-0004-0000-0000-000000000010"), null, new Guid("00000002-0004-0000-0000-000000000006"), new Guid("00000002-0004-0000-0000-000000000006"), "CiselnikPolozka", "cs-CZ", "Nazev", "35.05 Ovladače ovladatelné bez puštění zařízení pro řízení vozidla a mechanismy akcelerátoru a brzd" },
                    { new Guid("00000003-0004-0000-0000-000000000011"), null, new Guid("00000002-0004-0000-0000-000000000007"), new Guid("00000002-0004-0000-0000-000000000007"), "CiselnikPolozka", "cs-CZ", "Nazev", "20.03 Brzdový pedál upravený na levou nohu" },
                    { new Guid("00000003-0004-0000-0000-000000000012"), null, new Guid("00000002-0004-0000-0000-000000000008"), new Guid("00000002-0004-0000-0000-000000000008"), "CiselnikPolozka", "cs-CZ", "Nazev", "31.04 Zvýšená podlaha" },
                    { new Guid("00000003-0004-0000-0000-000000000013"), null, new Guid("00000002-0004-0000-0000-000000000009"), new Guid("00000002-0004-0000-0000-000000000009"), "CiselnikPolozka", "cs-CZ", "Nazev", "25.01 Přizpůsobený pedál akcelerátoru" },
                    { new Guid("00000003-0004-0000-0000-000000000014"), null, new Guid("00000002-0004-0000-0000-000000000010"), new Guid("00000002-0004-0000-0000-000000000010"), "CiselnikPolozka", "cs-CZ", "Nazev", "44.02 Přizpůsobená brzda na předním kole" },
                    { new Guid("00000003-0004-0000-0000-000000000015"), null, new Guid("00000002-0004-0000-0000-000000000011"), new Guid("00000002-0004-0000-0000-000000000011"), "CiselnikPolozka", "cs-CZ", "Nazev", "42.05 Zařízení k eliminaci mrtvého úhlu" },
                    { new Guid("00000003-0004-0000-0000-000000000016"), null, new Guid("00000002-0004-0000-0000-000000000012"), new Guid("00000002-0004-0000-0000-000000000012"), "CiselnikPolozka", "cs-CZ", "Nazev", "42.01 Přizpůsobené zařízení pro výhled dozadu" },
                    { new Guid("00000003-0004-0000-0000-000000000017"), null, new Guid("00000002-0004-0000-0000-000000000013"), new Guid("00000002-0004-0000-0000-000000000013"), "CiselnikPolozka", "cs-CZ", "Nazev", "25.05 Ovládání akcelerátoru kolenem" },
                    { new Guid("00000003-0004-0000-0000-000000000018"), null, new Guid("00000002-0004-0000-0000-000000000014"), new Guid("00000002-0004-0000-0000-000000000014"), "CiselnikPolozka", "cs-CZ", "Nazev", "44.10 Maximální ovládací síla brzdy zadního kola... N [například 44.10 (240 N)]" },
                    { new Guid("00000003-0004-0000-0000-000000000019"), null, new Guid("00000002-0004-0000-0000-000000000015"), new Guid("00000002-0004-0000-0000-000000000015"), "CiselnikPolozka", "cs-CZ", "Nazev", "63. Řízení vozidla bez cestujících" },
                    { new Guid("00000003-0004-0000-0000-000000000020"), null, new Guid("00000002-0004-0000-0000-000000000016"), new Guid("00000002-0004-0000-0000-000000000016"), "CiselnikPolozka", "cs-CZ", "Nazev", "64. Jízda rychlostí nepřesahující ... km/h" },
                    { new Guid("00000003-0004-0000-0000-000000000021"), null, new Guid("00000002-0004-0000-0000-000000000017"), new Guid("00000002-0004-0000-0000-000000000017"), "CiselnikPolozka", "cs-CZ", "Nazev", "61. Omezení jízdy podle denní doby (například: jedna hodina po východu slunce a jedna hodina před západem slunce)" },
                    { new Guid("00000003-0004-0000-0000-000000000022"), null, new Guid("00000002-0004-0000-0000-000000000018"), new Guid("00000002-0004-0000-0000-000000000018"), "CiselnikPolozka", "cs-CZ", "Nazev", "62. Omezení jízdy v okruhu ... km od místa bydliště řidiče nebo pouze ve městě/regionu" },
                    { new Guid("00000003-0004-0000-0000-000000000023"), null, new Guid("00000002-0004-0000-0000-000000000019"), new Guid("00000002-0004-0000-0000-000000000019"), "CiselnikPolozka", "cs-CZ", "Nazev", "40.05 Přizpůsobený volant (větší nebo silnější volant, zmenšený průměr volantu, apod.)" },
                    { new Guid("00000003-0004-0000-0000-000000000024"), null, new Guid("00000002-0004-0000-0000-000000000020"), new Guid("00000002-0004-0000-0000-000000000020"), "CiselnikPolozka", "cs-CZ", "Nazev", "67. Zákaz jízdy na dálnici" },
                    { new Guid("00000003-0004-0000-0000-000000000025"), null, new Guid("00000002-0004-0000-0000-000000000021"), new Guid("00000002-0004-0000-0000-000000000021"), "CiselnikPolozka", "cs-CZ", "Nazev", "40.01 Řízení s použitím maximální ovládací síly... N [například 40.01 (140 N)]" },
                    { new Guid("00000003-0004-0000-0000-000000000026"), null, new Guid("00000002-0004-0000-0000-000000000022"), new Guid("00000002-0004-0000-0000-000000000022"), "CiselnikPolozka", "cs-CZ", "Nazev", "65. Řízení vozidla povoleno výhradně v doprovodu jiného držitele řidičského oprávnění minimálně stejné skupiny vozidel" },
                    { new Guid("00000003-0004-0000-0000-000000000027"), null, new Guid("00000002-0004-0000-0000-000000000023"), new Guid("00000002-0004-0000-0000-000000000023"), "CiselnikPolozka", "cs-CZ", "Nazev", "66. Bez přívěsu" },
                    { new Guid("00000003-0004-0000-0000-000000000028"), null, new Guid("00000002-0004-0000-0000-000000000024"), new Guid("00000002-0004-0000-0000-000000000024"), "CiselnikPolozka", "cs-CZ", "Nazev", "35.02 Ovladače ovladatelné bez puštění zařízení pro řízení vozidla" },
                    { new Guid("00000003-0004-0000-0000-000000000029"), null, new Guid("00000002-0004-0000-0000-000000000025"), new Guid("00000002-0004-0000-0000-000000000025"), "CiselnikPolozka", "cs-CZ", "Nazev", "25.08 Pedál akcelerátoru nalevo" },
                    { new Guid("00000003-0004-0000-0000-000000000030"), null, new Guid("00000002-0004-0000-0000-000000000026"), new Guid("00000002-0004-0000-0000-000000000026"), "CiselnikPolozka", "cs-CZ", "Nazev", "01.02 Kontaktní čočky" },
                    { new Guid("00000003-0004-0000-0000-000000000031"), null, new Guid("00000002-0004-0000-0000-000000000027"), new Guid("00000002-0004-0000-0000-000000000027"), "CiselnikPolozka", "cs-CZ", "Nazev", "01.01 Brýle" },
                    { new Guid("00000003-0004-0000-0000-000000000032"), null, new Guid("00000002-0004-0000-0000-000000000028"), new Guid("00000002-0004-0000-0000-000000000028"), "CiselnikPolozka", "cs-CZ", "Nazev", "40.09 Nožní ovládání řízení" },
                    { new Guid("00000003-0004-0000-0000-000000000033"), null, new Guid("00000002-0004-0000-0000-000000000029"), new Guid("00000002-0004-0000-0000-000000000029"), "CiselnikPolozka", "cs-CZ", "Nazev", "31.03 Opatření proti zablokování nebo aktivaci akcelerátoru a brzdových pedálů, pokudpedály nejsou ovládány nohou" },
                    { new Guid("00000003-0004-0000-0000-000000000034"), null, new Guid("00000002-0004-0000-0000-000000000030"), new Guid("00000002-0004-0000-0000-000000000030"), "CiselnikPolozka", "cs-CZ", "Nazev", "20.14 Ovládání brzdového systému s podporou vnější síly" },
                    { new Guid("00000003-0004-0000-0000-000000000035"), null, new Guid("00000002-0004-0000-0000-000000000031"), new Guid("00000002-0004-0000-0000-000000000031"), "CiselnikPolozka", "cs-CZ", "Nazev", "44.12 Přizpůsobená řídítka" },
                    { new Guid("00000003-0004-0000-0000-000000000036"), null, new Guid("00000002-0004-0000-0000-000000000032"), new Guid("00000002-0004-0000-0000-000000000032"), "CiselnikPolozka", "cs-CZ", "Nazev", "44.11 Přizpůsobená stupačka" },
                    { new Guid("00000003-0004-0000-0000-000000000037"), null, new Guid("00000002-0004-0000-0000-000000000033"), new Guid("00000002-0004-0000-0000-000000000033"), "CiselnikPolozka", "cs-CZ", "Nazev", "44.03 Přizpůsobená brzda na zadním kole" },
                    { new Guid("00000003-0004-0000-0000-000000000038"), null, new Guid("00000002-0004-0000-0000-000000000034"), new Guid("00000002-0004-0000-0000-000000000034"), "CiselnikPolozka", "cs-CZ", "Nazev", "01.07 Specifické optické pomůcky" },
                    { new Guid("00000003-0004-0000-0000-000000000039"), null, new Guid("00000002-0004-0000-0000-000000000035"), new Guid("00000002-0004-0000-0000-000000000035"), "CiselnikPolozka", "cs-CZ", "Nazev", "01.06 Brýle nebo kontaktní čočky" },
                    { new Guid("00000003-0004-0000-0000-000000000040"), null, new Guid("00000002-0004-0000-0000-000000000036"), new Guid("00000002-0004-0000-0000-000000000036"), "CiselnikPolozka", "cs-CZ", "Nazev", "25.04 Ručně ovládaný akcelerátor" },
                    { new Guid("00000003-0004-0000-0000-000000000041"), null, new Guid("00000002-0004-0000-0000-000000000037"), new Guid("00000002-0004-0000-0000-000000000037"), "CiselnikPolozka", "cs-CZ", "Nazev", "01.05 Oční kryt" },
                    { new Guid("00000003-0004-0000-0000-000000000042"), null, new Guid("00000002-0004-0000-0000-000000000038"), new Guid("00000002-0004-0000-0000-000000000038"), "CiselnikPolozka", "cs-CZ", "Nazev", "43.04 Sedadlo řidiče s opěrkou ruky" },
                    { new Guid("00000003-0004-0000-0000-000000000043"), null, new Guid("00000002-0004-0000-0000-000000000039"), new Guid("00000002-0004-0000-0000-000000000039"), "CiselnikPolozka", "cs-CZ", "Nazev", "15.04 Opatření proti zablokování nebo aktivaci pedálu spojky" },
                    { new Guid("00000003-0004-0000-0000-000000000044"), null, new Guid("00000002-0004-0000-0000-000000000040"), new Guid("00000002-0004-0000-0000-000000000040"), "CiselnikPolozka", "cs-CZ", "Nazev", "15.03 Automatická spojka" },
                    { new Guid("00000003-0004-0000-0000-000000000045"), null, new Guid("00000002-0004-0000-0000-000000000041"), new Guid("00000002-0004-0000-0000-000000000041"), "CiselnikPolozka", "cs-CZ", "Nazev", "15.02 Ručně ovládaná spojka" },
                    { new Guid("00000003-0004-0000-0000-000000000046"), null, new Guid("00000002-0004-0000-0000-000000000042"), new Guid("00000002-0004-0000-0000-000000000042"), "CiselnikPolozka", "cs-CZ", "Nazev", "15.01 Přizpůsobený pedál spojky" },
                    { new Guid("00000003-0004-0000-0000-000000000047"), null, new Guid("00000002-0004-0000-0000-000000000043"), new Guid("00000002-0004-0000-0000-000000000043"), "CiselnikPolozka", "cs-CZ", "Nazev", "32.02 Akcelerátor a provozní brzda jako kombinovaný systém ovládaný vnější silou" },
                    { new Guid("00000003-0004-0000-0000-000000000048"), null, new Guid("00000002-0004-0000-0000-000000000044"), new Guid("00000002-0004-0000-0000-000000000044"), "CiselnikPolozka", "cs-CZ", "Nazev", "40.06 Přizpůsobená poloha volantu" },
                    { new Guid("00000003-0004-0000-0000-000000000049"), null, new Guid("00000002-0004-0000-0000-000000000045"), new Guid("00000002-0004-0000-0000-000000000045"), "CiselnikPolozka", "cs-CZ", "Nazev", "78. Pouze pro vozidla s automatickou převodovkou" },
                    { new Guid("00000003-0004-0000-0000-000000000050"), null, new Guid("00000002-0004-0000-0000-000000000046"), new Guid("00000002-0004-0000-0000-000000000046"), "CiselnikPolozka", "cs-CZ", "Nazev", "40.14 Alternativně přizpůsobený systém řízení vozidla ovládaný jednou rukou/paží" },
                    { new Guid("00000003-0004-0000-0000-000000000051"), null, new Guid("00000002-0004-0000-0000-000000000047"), new Guid("00000002-0004-0000-0000-000000000047"), "CiselnikPolozka", "cs-CZ", "Nazev", "42.03 Přídavné vnitřní zařízení umožňující výhled do stran" },
                    { new Guid("00000003-0004-0000-0000-000000000052"), null, new Guid("00000002-0004-0000-0000-000000000048"), new Guid("00000002-0004-0000-0000-000000000048"), "CiselnikPolozka", "cs-CZ", "Nazev", "20.09 Přizpůsobená parkovací brzda" },
                    { new Guid("00000003-0004-0000-0000-000000000053"), null, new Guid("00000002-0004-0000-0000-000000000049"), new Guid("00000002-0004-0000-0000-000000000049"), "CiselnikPolozka", "cs-CZ", "Nazev", "35.03 Ovladače ovladatelné levou rukou bez puštění zařízení pro řízení vozidla" },
                    { new Guid("00000003-0004-0000-0000-000000000054"), null, new Guid("00000002-0004-0000-0000-000000000050"), new Guid("00000002-0004-0000-0000-000000000050"), "CiselnikPolozka", "cs-CZ", "Nazev", "44.08 Výška sedadla umožňující řidiči v poloze vsedě mít současně obě nohy nazemi a udržovat motocykl v rovnováze při zastavení a stání" },
                    { new Guid("00000003-0004-0000-0000-000000000055"), null, new Guid("00000002-0004-0000-0000-000000000051"), new Guid("00000002-0004-0000-0000-000000000051"), "CiselnikPolozka", "cs-CZ", "Nazev", "20.05 Sklopený brzdový pedál" },
                    { new Guid("00000003-0004-0000-0000-000000000056"), null, new Guid("00000002-0004-0000-0000-000000000052"), new Guid("00000002-0004-0000-0000-000000000052"), "CiselnikPolozka", "cs-CZ", "Nazev", "31.02 Pedály ve stejné (nebo téměř stejné) úrovni" },
                    { new Guid("00000003-0004-0000-0000-000000000057"), null, new Guid("00000002-0004-0000-0000-000000000053"), new Guid("00000002-0004-0000-0000-000000000053"), "CiselnikPolozka", "cs-CZ", "Nazev", "44.04 Přizpůsobená rukojeť akcelerátoru" },
                    { new Guid("00000003-0004-0000-0000-000000000058"), null, new Guid("00000002-0004-0000-0000-000000000054"), new Guid("00000002-0004-0000-0000-000000000054"), "CiselnikPolozka", "cs-CZ", "Nazev", "33.02 Akcelerátor, provozní brzda a řízení jako kombinovaný systém ovládaný vnějšísilou oběma rukama" },
                    { new Guid("00000003-0004-0000-0000-000000000059"), null, new Guid("00000002-0004-0000-0000-000000000055"), new Guid("00000002-0004-0000-0000-000000000055"), "CiselnikPolozka", "cs-CZ", "Nazev", "20.13 Ovládání brzdy kolenem" },
                    { new Guid("00000003-0004-0000-0000-000000000060"), null, new Guid("00000002-0004-0000-0000-000000000056"), new Guid("00000002-0004-0000-0000-000000000056"), "CiselnikPolozka", "cs-CZ", "Nazev", "20.01 Přizpůsobený brzdový pedál" },
                    { new Guid("00000003-0004-0000-0000-000000000061"), null, new Guid("00000002-0004-0000-0000-000000000057"), new Guid("00000002-0004-0000-0000-000000000057"), "CiselnikPolozka", "cs-CZ", "Nazev", "25.03 Sklopený pedál akcelerátoru" },
                    { new Guid("00000003-0004-0000-0000-000000000062"), null, new Guid("00000002-0004-0000-0000-000000000058"), new Guid("00000002-0004-0000-0000-000000000058"), "CiselnikPolozka", "cs-CZ", "Nazev", "43.03 Sedadlo řidiče s postranní opěrou pro dobrou stabilitu" },
                    { new Guid("00000003-0004-0000-0000-000000000063"), null, new Guid("00000002-0004-0000-0000-000000000059"), new Guid("00000002-0004-0000-0000-000000000059"), "CiselnikPolozka", "cs-CZ", "Nazev", "43.07 Typ bezpečnostního pásu s podporou pro dobrou stabilitu" },
                    { new Guid("00000003-0004-0000-0000-000000000064"), null, new Guid("00000002-0004-0000-0000-000000000060"), new Guid("00000002-0004-0000-0000-000000000060"), "CiselnikPolozka", "cs-CZ", "Nazev", "32.01 Akcelerátor a provozní brzda jako kombinovaný systém ovládaný jednourukou" },
                    { new Guid("00000003-0004-0000-0000-000000000065"), null, new Guid("00000002-0004-0000-0000-000000000061"), new Guid("00000002-0004-0000-0000-000000000061"), "CiselnikPolozka", "cs-CZ", "Nazev", "40.15 Alternativně přizpůsobený systém řízení vozidla ovládaný dvěma rukama/pažemi" },
                    { new Guid("00000003-0004-0000-0000-000000000066"), null, new Guid("00000002-0004-0000-0000-000000000062"), new Guid("00000002-0004-0000-0000-000000000062"), "CiselnikPolozka", "cs-CZ", "Nazev", "47. Pouze pro vozidla s více než dvěma koly, u kterých řidič nemusí pro rozjetí, zastavení a stání udržovat rovnováhu" },
                    { new Guid("00000003-0004-0000-0000-000000000067"), null, new Guid("00000002-0004-0000-0000-000000000063"), new Guid("00000002-0004-0000-0000-000000000063"), "CiselnikPolozka", "cs-CZ", "Nazev", "03.01 Protéza/ortéza horní končetiny" },
                    { new Guid("00000003-0004-0000-0000-000000000068"), null, new Guid("00000002-0004-0000-0000-000000000064"), new Guid("00000002-0004-0000-0000-000000000064"), "CiselnikPolozka", "cs-CZ", "Nazev", "43.02 Anatomicky přizpůsobené sedadlo řidiče" },
                    { new Guid("00000003-0004-0000-0000-000000000069"), null, new Guid("00000002-0004-0000-0000-000000000065"), new Guid("00000002-0004-0000-0000-000000000065"), "CiselnikPolozka", "cs-CZ", "Nazev", "45. Motocykl pouze s postranním vozíkem" },
                    { new Guid("00000003-0004-0000-0000-000000000070"), null, new Guid("00000002-0004-0000-0000-000000000066"), new Guid("00000002-0004-0000-0000-000000000066"), "CiselnikPolozka", "cs-CZ", "Nazev", "03.02 Protéza/ortéza dolní končetiny" },
                    { new Guid("00000003-0004-0000-0000-000000000071"), null, new Guid("00000002-0004-0000-0000-000000000067"), new Guid("00000002-0004-0000-0000-000000000067"), "CiselnikPolozka", "cs-CZ", "Nazev", "46. Pouze pro tříkolová motorová vozidla" },
                    { new Guid("00000003-0004-0000-0000-000000000072"), null, new Guid("00000002-0004-0000-0000-000000000068"), new Guid("00000002-0004-0000-0000-000000000068"), "CiselnikPolozka", "cs-CZ", "Nazev", "02. Sluchové pomůcky/komunikační pomůcky" },
                    { new Guid("00000003-0004-0000-0000-000000000073"), null, new Guid("00000002-0004-0000-0000-000000000069"), new Guid("00000002-0004-0000-0000-000000000069"), "CiselnikPolozka", "cs-CZ", "Nazev", "40.11 Pomocná zařízení na volantu" },
                    { new Guid("00000003-0004-0000-0000-000000000074"), null, new Guid("00000002-0004-0000-0000-000000000070"), new Guid("00000002-0004-0000-0000-000000000070"), "CiselnikPolozka", "cs-CZ", "Nazev", "44.09 Maximální ovládací síla brzdy předního kola... N [například 44.09 (140 N)]" },
                    { new Guid("00000003-0004-0000-0000-000000000075"), null, new Guid("00000002-0004-0000-0000-000000000071"), new Guid("00000002-0004-0000-0000-000000000071"), "CiselnikPolozka", "cs-CZ", "Nazev", "35.04 Ovladače ovladatelné pravou rukou bez puštění zařízení pro řízení vozidla" },
                    { new Guid("00000003-0004-0000-0000-000000000076"), null, new Guid("00000002-0004-0000-0000-000000000072"), new Guid("00000002-0004-0000-0000-000000000072"), "CiselnikPolozka", "cs-CZ", "Nazev", "20.04 Posuvný brzdový pedál" },
                    { new Guid("00000003-0004-0000-0000-000000000077"), null, new Guid("00000002-0004-0000-0000-000000000073"), new Guid("00000002-0004-0000-0000-000000000073"), "CiselnikPolozka", "cs-CZ", "Nazev", "33.01 Akcelerátor, provozní brzda a řízení jako kombinovaný systém ovládaný vnějšísilou jednou rukou" },
                    { new Guid("00000003-0004-0000-0000-000000000078"), null, new Guid("00000002-0004-0000-0000-000000000074"), new Guid("00000002-0004-0000-0000-000000000074"), "CiselnikPolozka", "cs-CZ", "Nazev", "20.12 Opatření proti zablokování nebo aktivaci brzdového pedálu" },
                    { new Guid("00000003-0004-0000-0000-000000000079"), null, new Guid("00000002-0004-0000-0000-000000000075"), new Guid("00000002-0004-0000-0000-000000000075"), "CiselnikPolozka", "cs-CZ", "Nazev", "44.01 Samostatně ovládaná brzda" },
                    { new Guid("00000003-0004-0000-0000-000000000080"), null, new Guid("00000002-0004-0000-0000-000000000076"), new Guid("00000002-0004-0000-0000-000000000076"), "CiselnikPolozka", "cs-CZ", "Nazev", "31.01 Další sada paralelních pedálů" },
                    { new Guid("00000003-0004-0000-0000-000000000081"), null, new Guid("00000002-0004-0000-0000-000000000077"), new Guid("00000002-0004-0000-0000-000000000077"), "CiselnikPolozka", "cs-CZ", "Nazev", "20.06 Ručně ovládaná provozní brzda" },
                    { new Guid("00000003-0004-0000-0000-000000000082"), null, new Guid("00000002-0004-0000-0000-000000000078"), new Guid("00000002-0004-0000-0000-000000000078"), "CiselnikPolozka", "cs-CZ", "Nazev", "25.06 Ovládání akcelerátoru s podporou vnější síly" },
                    { new Guid("00000003-0004-0000-0000-000000000083"), null, new Guid("00000002-0004-0000-0000-000000000079"), new Guid("00000002-0004-0000-0000-000000000079"), "CiselnikPolozka", "cs-CZ", "Nazev", "43.06 Přizpůsobení bezpečnostního pásu" },
                    { new Guid("00000003-0004-0000-0000-000000000084"), null, new Guid("00000002-0004-0000-0000-000000000080"), new Guid("00000002-0004-0000-0000-000000000080"), "CiselnikPolozka", "cs-CZ", "Nazev", "50. Omezení na určité vozidlo/číslo podvozku (identifikační číslo vozidla, VIN)" },
                    { new Guid("00000003-0004-0000-0000-000000000085"), null, new Guid("00000002-0004-0000-0000-000000000001"), new Guid("00000002-0004-0000-0000-000000000001"), "CiselnikPolozka", "cs-CZ", "Popis", "43.01 Výška sedadla řidiče umožňující normální výhled a v normální vzdálenosti od-volantu a pedálů" },
                    { new Guid("00000003-0004-0000-0000-000000000086"), null, new Guid("00000002-0004-0000-0000-000000000002"), new Guid("00000002-0004-0000-0000-000000000002"), "CiselnikPolozka", "cs-CZ", "Popis", "10.02 Automatická převodovka" },
                    { new Guid("00000003-0004-0000-0000-000000000087"), null, new Guid("00000002-0004-0000-0000-000000000003"), new Guid("00000002-0004-0000-0000-000000000003"), "CiselnikPolozka", "cs-CZ", "Popis", "10.04 Přizpůsobené ústrojí ovládání převodovky" },
                    { new Guid("00000003-0004-0000-0000-000000000088"), null, new Guid("00000002-0004-0000-0000-000000000004"), new Guid("00000002-0004-0000-0000-000000000004"), "CiselnikPolozka", "cs-CZ", "Popis", "20.07 Ovládání brzdy s použitím maximální síly ... N [například: \"20.07(300 N)\"]" },
                    { new Guid("00000003-0004-0000-0000-000000000089"), null, new Guid("00000002-0004-0000-0000-000000000005"), new Guid("00000002-0004-0000-0000-000000000005"), "CiselnikPolozka", "cs-CZ", "Popis", "25.09 Opatření proti zablokování nebo aktivaci akcelerátoru" },
                    { new Guid("00000003-0004-0000-0000-000000000090"), null, new Guid("00000002-0004-0000-0000-000000000006"), new Guid("00000002-0004-0000-0000-000000000006"), "CiselnikPolozka", "cs-CZ", "Popis", "35.05 Ovladače ovladatelné bez puštění zařízení pro řízení vozidla a mechanismy akcelerátoru a brzd" },
                    { new Guid("00000003-0004-0000-0000-000000000091"), null, new Guid("00000002-0004-0000-0000-000000000007"), new Guid("00000002-0004-0000-0000-000000000007"), "CiselnikPolozka", "cs-CZ", "Popis", "20.03 Brzdový pedál upravený na levou nohu" },
                    { new Guid("00000003-0004-0000-0000-000000000092"), null, new Guid("00000002-0004-0000-0000-000000000008"), new Guid("00000002-0004-0000-0000-000000000008"), "CiselnikPolozka", "cs-CZ", "Popis", "31.04 Zvýšená podlaha" },
                    { new Guid("00000003-0004-0000-0000-000000000093"), null, new Guid("00000002-0004-0000-0000-000000000009"), new Guid("00000002-0004-0000-0000-000000000009"), "CiselnikPolozka", "cs-CZ", "Popis", "25.01 Přizpůsobený pedál akcelerátoru" },
                    { new Guid("00000003-0004-0000-0000-000000000094"), null, new Guid("00000002-0004-0000-0000-000000000010"), new Guid("00000002-0004-0000-0000-000000000010"), "CiselnikPolozka", "cs-CZ", "Popis", "44.02 Přizpůsobená brzda na předním kole" },
                    { new Guid("00000003-0004-0000-0000-000000000095"), null, new Guid("00000002-0004-0000-0000-000000000011"), new Guid("00000002-0004-0000-0000-000000000011"), "CiselnikPolozka", "cs-CZ", "Popis", "42.05 Zařízení k eliminaci mrtvého úhlu" },
                    { new Guid("00000003-0004-0000-0000-000000000096"), null, new Guid("00000002-0004-0000-0000-000000000012"), new Guid("00000002-0004-0000-0000-000000000012"), "CiselnikPolozka", "cs-CZ", "Popis", "42.01 Přizpůsobené zařízení pro výhled dozadu" },
                    { new Guid("00000003-0004-0000-0000-000000000097"), null, new Guid("00000002-0004-0000-0000-000000000013"), new Guid("00000002-0004-0000-0000-000000000013"), "CiselnikPolozka", "cs-CZ", "Popis", "25.05 Ovládání akcelerátoru kolenem" },
                    { new Guid("00000003-0004-0000-0000-000000000098"), null, new Guid("00000002-0004-0000-0000-000000000014"), new Guid("00000002-0004-0000-0000-000000000014"), "CiselnikPolozka", "cs-CZ", "Popis", "44.10 Maximální ovládací síla brzdy zadního kola... N [například \"44.10 (240 N)\"]" },
                    { new Guid("00000003-0004-0000-0000-000000000099"), null, new Guid("00000002-0004-0000-0000-000000000015"), new Guid("00000002-0004-0000-0000-000000000015"), "CiselnikPolozka", "cs-CZ", "Popis", "63. Řízení vozidla bez cestujících" },
                    { new Guid("00000003-0004-0000-0000-000000000100"), null, new Guid("00000002-0004-0000-0000-000000000016"), new Guid("00000002-0004-0000-0000-000000000016"), "CiselnikPolozka", "cs-CZ", "Popis", "64. Jízda rychlostí nepřesahující ... km/h" },
                    { new Guid("00000003-0004-0000-0000-000000000101"), null, new Guid("00000002-0004-0000-0000-000000000017"), new Guid("00000002-0004-0000-0000-000000000017"), "CiselnikPolozka", "cs-CZ", "Popis", "61. Omezení jízdy podle denní doby (například: jedna hodina po východu slunce a jedna hodina před západem slunce)" },
                    { new Guid("00000003-0004-0000-0000-000000000102"), null, new Guid("00000002-0004-0000-0000-000000000018"), new Guid("00000002-0004-0000-0000-000000000018"), "CiselnikPolozka", "cs-CZ", "Popis", "62. Omezení jízdy v okruhu ... km od místa bydliště řidiče nebo pouze ve městě/regionu" },
                    { new Guid("00000003-0004-0000-0000-000000000103"), null, new Guid("00000002-0004-0000-0000-000000000019"), new Guid("00000002-0004-0000-0000-000000000019"), "CiselnikPolozka", "cs-CZ", "Popis", "40.05 Přizpůsobený volant (větší nebo silnější volant, zmenšený průměr volantu, apod.)" },
                    { new Guid("00000003-0004-0000-0000-000000000104"), null, new Guid("00000002-0004-0000-0000-000000000020"), new Guid("00000002-0004-0000-0000-000000000020"), "CiselnikPolozka", "cs-CZ", "Popis", "67. Zákaz jízdy na dálnici" },
                    { new Guid("00000003-0004-0000-0000-000000000105"), null, new Guid("00000002-0004-0000-0000-000000000021"), new Guid("00000002-0004-0000-0000-000000000021"), "CiselnikPolozka", "cs-CZ", "Popis", "40.01 Řízení s použitím maximální ovládací síly... N [například \"40.01 (140 N)\"]" },
                    { new Guid("00000003-0004-0000-0000-000000000106"), null, new Guid("00000002-0004-0000-0000-000000000022"), new Guid("00000002-0004-0000-0000-000000000022"), "CiselnikPolozka", "cs-CZ", "Popis", "65. Řízení vozidla povoleno výhradně v doprovodu jiného držitele řidičského oprávnění minimálně stejné skupiny vozidel" },
                    { new Guid("00000003-0004-0000-0000-000000000107"), null, new Guid("00000002-0004-0000-0000-000000000023"), new Guid("00000002-0004-0000-0000-000000000023"), "CiselnikPolozka", "cs-CZ", "Popis", "66. Bez přívěsu" },
                    { new Guid("00000003-0004-0000-0000-000000000108"), null, new Guid("00000002-0004-0000-0000-000000000024"), new Guid("00000002-0004-0000-0000-000000000024"), "CiselnikPolozka", "cs-CZ", "Popis", "35.02 Ovladače ovladatelné bez puštění zařízení pro řízení vozidla" },
                    { new Guid("00000003-0004-0000-0000-000000000109"), null, new Guid("00000002-0004-0000-0000-000000000025"), new Guid("00000002-0004-0000-0000-000000000025"), "CiselnikPolozka", "cs-CZ", "Popis", "25.08 Pedál akcelerátoru nalevo" },
                    { new Guid("00000003-0004-0000-0000-000000000110"), null, new Guid("00000002-0004-0000-0000-000000000026"), new Guid("00000002-0004-0000-0000-000000000026"), "CiselnikPolozka", "cs-CZ", "Popis", "01.02 Kontaktní čočky" },
                    { new Guid("00000003-0004-0000-0000-000000000111"), null, new Guid("00000002-0004-0000-0000-000000000027"), new Guid("00000002-0004-0000-0000-000000000027"), "CiselnikPolozka", "cs-CZ", "Popis", "01.01 Brýle" },
                    { new Guid("00000003-0004-0000-0000-000000000112"), null, new Guid("00000002-0004-0000-0000-000000000028"), new Guid("00000002-0004-0000-0000-000000000028"), "CiselnikPolozka", "cs-CZ", "Popis", "40.09 Nožní ovládání řízení" },
                    { new Guid("00000003-0004-0000-0000-000000000113"), null, new Guid("00000002-0004-0000-0000-000000000029"), new Guid("00000002-0004-0000-0000-000000000029"), "CiselnikPolozka", "cs-CZ", "Popis", "31.03 Opatření proti zablokování nebo aktivaci akcelerátoru a brzdových pedálů, pokudpedály nejsou ovládány nohou" },
                    { new Guid("00000003-0004-0000-0000-000000000114"), null, new Guid("00000002-0004-0000-0000-000000000030"), new Guid("00000002-0004-0000-0000-000000000030"), "CiselnikPolozka", "cs-CZ", "Popis", "20.14 Ovládání brzdového systému s podporou vnější síly" },
                    { new Guid("00000003-0004-0000-0000-000000000115"), null, new Guid("00000002-0004-0000-0000-000000000031"), new Guid("00000002-0004-0000-0000-000000000031"), "CiselnikPolozka", "cs-CZ", "Popis", "44.12 Přizpůsobená řídítka" },
                    { new Guid("00000003-0004-0000-0000-000000000116"), null, new Guid("00000002-0004-0000-0000-000000000032"), new Guid("00000002-0004-0000-0000-000000000032"), "CiselnikPolozka", "cs-CZ", "Popis", "44.11 Přizpůsobená stupačka" },
                    { new Guid("00000003-0004-0000-0000-000000000117"), null, new Guid("00000002-0004-0000-0000-000000000033"), new Guid("00000002-0004-0000-0000-000000000033"), "CiselnikPolozka", "cs-CZ", "Popis", "44.03 Přizpůsobená brzda na zadním kole" },
                    { new Guid("00000003-0004-0000-0000-000000000118"), null, new Guid("00000002-0004-0000-0000-000000000034"), new Guid("00000002-0004-0000-0000-000000000034"), "CiselnikPolozka", "cs-CZ", "Popis", "01.07 Specifické optické pomůcky" },
                    { new Guid("00000003-0004-0000-0000-000000000119"), null, new Guid("00000002-0004-0000-0000-000000000035"), new Guid("00000002-0004-0000-0000-000000000035"), "CiselnikPolozka", "cs-CZ", "Popis", "01.06 Brýle nebo kontaktní čočky" },
                    { new Guid("00000003-0004-0000-0000-000000000120"), null, new Guid("00000002-0004-0000-0000-000000000036"), new Guid("00000002-0004-0000-0000-000000000036"), "CiselnikPolozka", "cs-CZ", "Popis", "25.04 Ručně ovládaný akcelerátor" },
                    { new Guid("00000003-0004-0000-0000-000000000121"), null, new Guid("00000002-0004-0000-0000-000000000037"), new Guid("00000002-0004-0000-0000-000000000037"), "CiselnikPolozka", "cs-CZ", "Popis", "01.05 Oční kryt" },
                    { new Guid("00000003-0004-0000-0000-000000000122"), null, new Guid("00000002-0004-0000-0000-000000000038"), new Guid("00000002-0004-0000-0000-000000000038"), "CiselnikPolozka", "cs-CZ", "Popis", "43.04 Sedadlo řidiče s opěrkou ruky" },
                    { new Guid("00000003-0004-0000-0000-000000000123"), null, new Guid("00000002-0004-0000-0000-000000000039"), new Guid("00000002-0004-0000-0000-000000000039"), "CiselnikPolozka", "cs-CZ", "Popis", "15.04 Opatření proti zablokování nebo aktivaci pedálu spojky" },
                    { new Guid("00000003-0004-0000-0000-000000000124"), null, new Guid("00000002-0004-0000-0000-000000000040"), new Guid("00000002-0004-0000-0000-000000000040"), "CiselnikPolozka", "cs-CZ", "Popis", "15.03 Automatická spojka" },
                    { new Guid("00000003-0004-0000-0000-000000000125"), null, new Guid("00000002-0004-0000-0000-000000000041"), new Guid("00000002-0004-0000-0000-000000000041"), "CiselnikPolozka", "cs-CZ", "Popis", "15.02 Ručně ovládaná spojka" },
                    { new Guid("00000003-0004-0000-0000-000000000126"), null, new Guid("00000002-0004-0000-0000-000000000042"), new Guid("00000002-0004-0000-0000-000000000042"), "CiselnikPolozka", "cs-CZ", "Popis", "15.01 Přizpůsobený pedál spojky" },
                    { new Guid("00000003-0004-0000-0000-000000000127"), null, new Guid("00000002-0004-0000-0000-000000000044"), new Guid("00000002-0004-0000-0000-000000000044"), "CiselnikPolozka", "cs-CZ", "Popis", "40.06 Přizpůsobená poloha volantu" },
                    { new Guid("00000003-0004-0000-0000-000000000128"), null, new Guid("00000002-0004-0000-0000-000000000045"), new Guid("00000002-0004-0000-0000-000000000045"), "CiselnikPolozka", "cs-CZ", "Popis", "78. Pouze pro vozidla s automatickou převodovkou" },
                    { new Guid("00000003-0004-0000-0000-000000000129"), null, new Guid("00000002-0004-0000-0000-000000000046"), new Guid("00000002-0004-0000-0000-000000000046"), "CiselnikPolozka", "cs-CZ", "Popis", "40.14 Alternativně přizpůsobený systém řízení vozidla ovládaný jednou rukou/paží" },
                    { new Guid("00000003-0004-0000-0000-000000000130"), null, new Guid("00000002-0004-0000-0000-000000000047"), new Guid("00000002-0004-0000-0000-000000000047"), "CiselnikPolozka", "cs-CZ", "Popis", "42.03 Přídavné vnitřní zařízení umožňující výhled do stran" },
                    { new Guid("00000003-0004-0000-0000-000000000131"), null, new Guid("00000002-0004-0000-0000-000000000048"), new Guid("00000002-0004-0000-0000-000000000048"), "CiselnikPolozka", "cs-CZ", "Popis", "20.09 Přizpůsobená parkovací brzda" },
                    { new Guid("00000003-0004-0000-0000-000000000132"), null, new Guid("00000002-0004-0000-0000-000000000049"), new Guid("00000002-0004-0000-0000-000000000049"), "CiselnikPolozka", "cs-CZ", "Popis", "35.03 Ovladače ovladatelné levou rukou bez puštění zařízení pro řízení vozidla" },
                    { new Guid("00000003-0004-0000-0000-000000000133"), null, new Guid("00000002-0004-0000-0000-000000000050"), new Guid("00000002-0004-0000-0000-000000000050"), "CiselnikPolozka", "cs-CZ", "Popis", "44.08 Výška sedadla umožňující řidiči v poloze vsedě mít současně obě nohy nazemi a udržovat motocykl v rovnováze při zastavení a stání" },
                    { new Guid("00000003-0004-0000-0000-000000000134"), null, new Guid("00000002-0004-0000-0000-000000000051"), new Guid("00000002-0004-0000-0000-000000000051"), "CiselnikPolozka", "cs-CZ", "Popis", "20.05 Sklopený brzdový pedál" },
                    { new Guid("00000003-0004-0000-0000-000000000135"), null, new Guid("00000002-0004-0000-0000-000000000052"), new Guid("00000002-0004-0000-0000-000000000052"), "CiselnikPolozka", "cs-CZ", "Popis", "31.02 Pedály ve stejné (nebo téměř stejné) úrovni" },
                    { new Guid("00000003-0004-0000-0000-000000000136"), null, new Guid("00000002-0004-0000-0000-000000000053"), new Guid("00000002-0004-0000-0000-000000000053"), "CiselnikPolozka", "cs-CZ", "Popis", "44.04 Přizpůsobená rukojeť akcelerátoru" },
                    { new Guid("00000003-0004-0000-0000-000000000137"), null, new Guid("00000002-0004-0000-0000-000000000054"), new Guid("00000002-0004-0000-0000-000000000054"), "CiselnikPolozka", "cs-CZ", "Popis", "33.02 Akcelerátor, provozní brzda a řízení jako kombinovaný systém ovládaný vnějšísilou oběma rukama" },
                    { new Guid("00000003-0004-0000-0000-000000000138"), null, new Guid("00000002-0004-0000-0000-000000000055"), new Guid("00000002-0004-0000-0000-000000000055"), "CiselnikPolozka", "cs-CZ", "Popis", "20.13 Ovládání brzdy kolenem" },
                    { new Guid("00000003-0004-0000-0000-000000000139"), null, new Guid("00000002-0004-0000-0000-000000000056"), new Guid("00000002-0004-0000-0000-000000000056"), "CiselnikPolozka", "cs-CZ", "Popis", "20.01 Přizpůsobený brzdový pedál" },
                    { new Guid("00000003-0004-0000-0000-000000000140"), null, new Guid("00000002-0004-0000-0000-000000000057"), new Guid("00000002-0004-0000-0000-000000000057"), "CiselnikPolozka", "cs-CZ", "Popis", "25.03 Sklopený pedál akcelerátoru" },
                    { new Guid("00000003-0004-0000-0000-000000000141"), null, new Guid("00000002-0004-0000-0000-000000000058"), new Guid("00000002-0004-0000-0000-000000000058"), "CiselnikPolozka", "cs-CZ", "Popis", "43.03 Sedadlo řidiče s postranní opěrou pro dobrou stabilitu" },
                    { new Guid("00000003-0004-0000-0000-000000000142"), null, new Guid("00000002-0004-0000-0000-000000000059"), new Guid("00000002-0004-0000-0000-000000000059"), "CiselnikPolozka", "cs-CZ", "Popis", "43.07 Typ bezpečnostního pásu s podporou pro dobrou stabilitu" },
                    { new Guid("00000003-0004-0000-0000-000000000143"), null, new Guid("00000002-0004-0000-0000-000000000061"), new Guid("00000002-0004-0000-0000-000000000061"), "CiselnikPolozka", "cs-CZ", "Popis", "40.15 Alternativně přizpůsobený systém řízení vozidla ovládaný dvěma rukama/pažemi" },
                    { new Guid("00000003-0004-0000-0000-000000000144"), null, new Guid("00000002-0004-0000-0000-000000000062"), new Guid("00000002-0004-0000-0000-000000000062"), "CiselnikPolozka", "cs-CZ", "Popis", "47. Pouze pro vozidla s více než dvěma koly, u kterých řidič nemusí pro rozjetí, zastavení a stání udržovat rovnováhu" },
                    { new Guid("00000003-0004-0000-0000-000000000145"), null, new Guid("00000002-0004-0000-0000-000000000063"), new Guid("00000002-0004-0000-0000-000000000063"), "CiselnikPolozka", "cs-CZ", "Popis", "03.01 Protéza/ortéza horní končetiny" },
                    { new Guid("00000003-0004-0000-0000-000000000146"), null, new Guid("00000002-0004-0000-0000-000000000064"), new Guid("00000002-0004-0000-0000-000000000064"), "CiselnikPolozka", "cs-CZ", "Popis", "43.02 Anatomicky přizpůsobené sedadlo řidiče" },
                    { new Guid("00000003-0004-0000-0000-000000000147"), null, new Guid("00000002-0004-0000-0000-000000000065"), new Guid("00000002-0004-0000-0000-000000000065"), "CiselnikPolozka", "cs-CZ", "Popis", "45. Motocykl pouze s postranním vozíkem" },
                    { new Guid("00000003-0004-0000-0000-000000000148"), null, new Guid("00000002-0004-0000-0000-000000000066"), new Guid("00000002-0004-0000-0000-000000000066"), "CiselnikPolozka", "cs-CZ", "Popis", "03.02 Protéza/ortéza dolní končetiny" },
                    { new Guid("00000003-0004-0000-0000-000000000149"), null, new Guid("00000002-0004-0000-0000-000000000067"), new Guid("00000002-0004-0000-0000-000000000067"), "CiselnikPolozka", "cs-CZ", "Popis", "46. Pouze pro tříkolová motorová vozidla" },
                    { new Guid("00000003-0004-0000-0000-000000000150"), null, new Guid("00000002-0004-0000-0000-000000000068"), new Guid("00000002-0004-0000-0000-000000000068"), "CiselnikPolozka", "cs-CZ", "Popis", "02. Sluchové pomůcky/komunikační pomůcky" },
                    { new Guid("00000003-0004-0000-0000-000000000151"), null, new Guid("00000002-0004-0000-0000-000000000069"), new Guid("00000002-0004-0000-0000-000000000069"), "CiselnikPolozka", "cs-CZ", "Popis", "40.11 Pomocná zařízení na volantu" },
                    { new Guid("00000003-0004-0000-0000-000000000152"), null, new Guid("00000002-0004-0000-0000-000000000070"), new Guid("00000002-0004-0000-0000-000000000070"), "CiselnikPolozka", "cs-CZ", "Popis", "44.09 Maximální ovládací síla brzdy předního kola... N [například \"44.09 (140 N)\"]" },
                    { new Guid("00000003-0004-0000-0000-000000000153"), null, new Guid("00000002-0004-0000-0000-000000000071"), new Guid("00000002-0004-0000-0000-000000000071"), "CiselnikPolozka", "cs-CZ", "Popis", "35.04 Ovladače ovladatelné pravou rukou bez puštění zařízení pro řízení vozidla" },
                    { new Guid("00000003-0004-0000-0000-000000000154"), null, new Guid("00000002-0004-0000-0000-000000000072"), new Guid("00000002-0004-0000-0000-000000000072"), "CiselnikPolozka", "cs-CZ", "Popis", "20.04 Posuvný brzdový pedál" },
                    { new Guid("00000003-0004-0000-0000-000000000155"), null, new Guid("00000002-0004-0000-0000-000000000073"), new Guid("00000002-0004-0000-0000-000000000073"), "CiselnikPolozka", "cs-CZ", "Popis", "33.01 Akcelerátor, provozní brzda a řízení jako kombinovaný systém ovládaný vnějšísilou jednou rukou" },
                    { new Guid("00000003-0004-0000-0000-000000000156"), null, new Guid("00000002-0004-0000-0000-000000000074"), new Guid("00000002-0004-0000-0000-000000000074"), "CiselnikPolozka", "cs-CZ", "Popis", "20.12 Opatření proti zablokování nebo aktivaci brzdového pedálu" },
                    { new Guid("00000003-0004-0000-0000-000000000157"), null, new Guid("00000002-0004-0000-0000-000000000075"), new Guid("00000002-0004-0000-0000-000000000075"), "CiselnikPolozka", "cs-CZ", "Popis", "44.01 Samostatně ovládaná brzda" },
                    { new Guid("00000003-0004-0000-0000-000000000158"), null, new Guid("00000002-0004-0000-0000-000000000076"), new Guid("00000002-0004-0000-0000-000000000076"), "CiselnikPolozka", "cs-CZ", "Popis", "31.01 Další sada paralelních pedálů" },
                    { new Guid("00000003-0004-0000-0000-000000000159"), null, new Guid("00000002-0004-0000-0000-000000000077"), new Guid("00000002-0004-0000-0000-000000000077"), "CiselnikPolozka", "cs-CZ", "Popis", "20.06 Ručně ovládaná provozní brzda" },
                    { new Guid("00000003-0004-0000-0000-000000000160"), null, new Guid("00000002-0004-0000-0000-000000000078"), new Guid("00000002-0004-0000-0000-000000000078"), "CiselnikPolozka", "cs-CZ", "Popis", "25.06 Ovládání akcelerátoru s podporou vnější síly" },
                    { new Guid("00000003-0004-0000-0000-000000000161"), null, new Guid("00000002-0004-0000-0000-000000000079"), new Guid("00000002-0004-0000-0000-000000000079"), "CiselnikPolozka", "cs-CZ", "Popis", "43.06 Přizpůsobení bezpečnostního pásu" },
                    { new Guid("00000003-0004-0000-0000-000000000162"), null, new Guid("00000002-0004-0000-0000-000000000080"), new Guid("00000002-0004-0000-0000-000000000080"), "CiselnikPolozka", "cs-CZ", "Popis", "50. Omezení na určité vozidlo/číslo podvozku (identifikační číslo vozidla, VIN)" },
                    { new Guid("00000003-0005-0000-0000-000000000005"), null, new Guid("00000002-0005-0000-0000-000000000001"), new Guid("00000002-0005-0000-0000-000000000001"), "CiselnikPolozka", "cs-CZ", "Nazev", "185. Pouze pro řízení motorových vozidel stanovených v § 83 odst. 5 zákona č. 361/2000 Sb. do doby dosažení věku u skupiny vozidel C 21 let, u skupiny vozidel D 24 let" },
                    { new Guid("00000003-0005-0000-0000-000000000006"), null, new Guid("00000002-0005-0000-0000-000000000002"), new Guid("00000002-0005-0000-0000-000000000002"), "CiselnikPolozka", "cs-CZ", "Nazev", "111. Nelze vykonávat činnost: a) řidiče, který řídí motorové vozidlo v pracovněprávním vztahu a u něhož je řízení motorového vozidla druhem práce sjednaným v pracovní smlouvě" },
                    { new Guid("00000003-0005-0000-0000-000000000007"), null, new Guid("00000002-0005-0000-0000-000000000003"), new Guid("00000002-0005-0000-0000-000000000003"), "CiselnikPolozka", "cs-CZ", "Nazev", "111. Nelze vykonávat činnost: b) řidiče, u kterého je řízení motorového vozidla předmětem samostatné výdělečné činnosti prováděné podle jiného právního předpisu" },
                    { new Guid("00000003-0005-0000-0000-000000000008"), null, new Guid("00000002-0005-0000-0000-000000000004"), new Guid("00000002-0005-0000-0000-000000000004"), "CiselnikPolozka", "cs-CZ", "Nazev", "175. Omezení řidičského oprávnění skupiny vozidel D pouze k řízení vozidla městské hromadné dopravy osob" },
                    { new Guid("00000003-0005-0000-0000-000000000009"), null, new Guid("00000002-0005-0000-0000-000000000005"), new Guid("00000002-0005-0000-0000-000000000005"), "CiselnikPolozka", "cs-CZ", "Nazev", "111. Nelze vykonávat činnost: c) učitele výcviku v řízení motorových vozidel podle jiného právního předpisu" },
                    { new Guid("00000003-0005-0000-0000-000000000010"), null, new Guid("00000002-0005-0000-0000-000000000006"), new Guid("00000002-0005-0000-0000-000000000006"), "CiselnikPolozka", "cs-CZ", "Nazev", "160. Výjimka z věku u řidičského oprávnění skupiny vozidel A1, A2 nebo A osoby, která je držitelem licence motoristického sportovce, udělená pouze pro jízdu při sportovní soutěži" },
                    { new Guid("00000003-0005-0000-0000-000000000011"), null, new Guid("00000002-0005-0000-0000-000000000007"), new Guid("00000002-0005-0000-0000-000000000007"), "CiselnikPolozka", "cs-CZ", "Nazev", "172. Omezení řidičského oprávnění skupiny vozidel A pouze k řízení motorového vozíku pro invalidy" },
                    { new Guid("00000003-0005-0000-0000-000000000012"), null, new Guid("00000002-0005-0000-0000-000000000008"), new Guid("00000002-0005-0000-0000-000000000008"), "CiselnikPolozka", "cs-CZ", "Nazev", "115. Posilovač spojky" },
                    { new Guid("00000003-0005-0000-0000-000000000013"), null, new Guid("00000002-0005-0000-0000-000000000009"), new Guid("00000002-0005-0000-0000-000000000009"), "CiselnikPolozka", "cs-CZ", "Nazev", "105. Jiná zdravotní omezení, která nejsou uvedena v části I této přílohy" },
                    { new Guid("00000003-0005-0000-0000-000000000014"), null, new Guid("00000002-0005-0000-0000-000000000010"), new Guid("00000002-0005-0000-0000-000000000010"), "CiselnikPolozka", "cs-CZ", "Nazev", "199. Zkušební doba podmíněného upuštění od výkon" },
                    { new Guid("00000003-0005-0000-0000-000000000015"), null, new Guid("00000002-0005-0000-0000-000000000001"), new Guid("00000002-0005-0000-0000-000000000001"), "CiselnikPolozka", "cs-CZ", "Popis", "185. Pouze pro řízení motorových vozidel stanovených v § 83 odst. 5 zákona č. 361/2000 Sb. do doby dosažení věku u skupiny vozidel C 21 let, u skupiny vozidel D 24 let" },
                    { new Guid("00000003-0005-0000-0000-000000000016"), null, new Guid("00000002-0005-0000-0000-000000000002"), new Guid("00000002-0005-0000-0000-000000000002"), "CiselnikPolozka", "cs-CZ", "Popis", "111. Nelze vykonávat činnost: a) řidiče, který řídí motorové vozidlo v pracovněprávním vztahu a u něhož je řízení motorového vozidla druhem práce sjednaným v pracovní smlouvě" },
                    { new Guid("00000003-0005-0000-0000-000000000017"), null, new Guid("00000002-0005-0000-0000-000000000003"), new Guid("00000002-0005-0000-0000-000000000003"), "CiselnikPolozka", "cs-CZ", "Popis", "111. Nelze vykonávat činnost: b) řidiče, u kterého je řízení motorového vozidla předmětem samostatné výdělečné činnosti prováděné podle jiného právního předpisu" },
                    { new Guid("00000003-0005-0000-0000-000000000018"), null, new Guid("00000002-0005-0000-0000-000000000004"), new Guid("00000002-0005-0000-0000-000000000004"), "CiselnikPolozka", "cs-CZ", "Popis", "175. Omezení řidičského oprávnění skupiny vozidel D pouze k řízení vozidla městské hromadné dopravy osob" },
                    { new Guid("00000003-0005-0000-0000-000000000019"), null, new Guid("00000002-0005-0000-0000-000000000005"), new Guid("00000002-0005-0000-0000-000000000005"), "CiselnikPolozka", "cs-CZ", "Popis", "111. Nelze vykonávat činnost: c) učitele výcviku v řízení motorových vozidel podle jiného právního předpisu" },
                    { new Guid("00000003-0005-0000-0000-000000000020"), null, new Guid("00000002-0005-0000-0000-000000000006"), new Guid("00000002-0005-0000-0000-000000000006"), "CiselnikPolozka", "cs-CZ", "Popis", "160. Výjimka z věku u řidičského oprávnění skupiny vozidel A1, A2 nebo A osoby, která je držitelem licence motoristického sportovce, udělená pouze pro jízdu při sportovní soutěži" },
                    { new Guid("00000003-0005-0000-0000-000000000021"), null, new Guid("00000002-0005-0000-0000-000000000007"), new Guid("00000002-0005-0000-0000-000000000007"), "CiselnikPolozka", "cs-CZ", "Popis", "172. Omezení řidičského oprávnění skupiny vozidel A pouze k řízení motorového vozíku pro invalidy" },
                    { new Guid("00000003-0005-0000-0000-000000000022"), null, new Guid("00000002-0005-0000-0000-000000000008"), new Guid("00000002-0005-0000-0000-000000000008"), "CiselnikPolozka", "cs-CZ", "Popis", "115. Posilovač spojky" },
                    { new Guid("00000003-0005-0000-0000-000000000023"), null, new Guid("00000002-0005-0000-0000-000000000009"), new Guid("00000002-0005-0000-0000-000000000009"), "CiselnikPolozka", "cs-CZ", "Popis", "105. Jiná zdravotní omezení, která nejsou uvedena v části I této přílohy" },
                    { new Guid("00000003-0005-0000-0000-000000000024"), null, new Guid("00000002-0005-0000-0000-000000000010"), new Guid("00000002-0005-0000-0000-000000000010"), "CiselnikPolozka", "cs-CZ", "Popis", "199. Zkušební doba podmíněného upuštění od výkon" },
                    { new Guid("00000003-0006-0000-0000-000000000005"), null, new Guid("00000002-0006-0000-0000-000000000001"), new Guid("00000002-0006-0000-0000-000000000001"), "CiselnikPolozka", "cs-CZ", "Nazev", "skupina B" },
                    { new Guid("00000003-0006-0000-0000-000000000006"), null, new Guid("00000002-0006-0000-0000-000000000002"), new Guid("00000002-0006-0000-0000-000000000002"), "CiselnikPolozka", "cs-CZ", "Nazev", "skupina A" },
                    { new Guid("00000003-0006-0000-0000-000000000007"), null, new Guid("00000002-0006-0000-0000-000000000003"), new Guid("00000002-0006-0000-0000-000000000003"), "CiselnikPolozka", "cs-CZ", "Nazev", "skupina D" },
                    { new Guid("00000003-0006-0000-0000-000000000008"), null, new Guid("00000002-0006-0000-0000-000000000004"), new Guid("00000002-0006-0000-0000-000000000004"), "CiselnikPolozka", "cs-CZ", "Nazev", "skupina BE" },
                    { new Guid("00000003-0006-0000-0000-000000000009"), null, new Guid("00000002-0006-0000-0000-000000000005"), new Guid("00000002-0006-0000-0000-000000000005"), "CiselnikPolozka", "cs-CZ", "Nazev", "skupina C" },
                    { new Guid("00000003-0006-0000-0000-000000000010"), null, new Guid("00000002-0006-0000-0000-000000000006"), new Guid("00000002-0006-0000-0000-000000000006"), "CiselnikPolozka", "cs-CZ", "Nazev", "skupina DE" },
                    { new Guid("00000003-0006-0000-0000-000000000011"), null, new Guid("00000002-0006-0000-0000-000000000007"), new Guid("00000002-0006-0000-0000-000000000007"), "CiselnikPolozka", "cs-CZ", "Nazev", "skupina CE" },
                    { new Guid("00000003-0006-0000-0000-000000000012"), null, new Guid("00000002-0006-0000-0000-000000000008"), new Guid("00000002-0006-0000-0000-000000000008"), "CiselnikPolozka", "cs-CZ", "Nazev", "skupina D1" },
                    { new Guid("00000003-0006-0000-0000-000000000013"), null, new Guid("00000002-0006-0000-0000-000000000009"), new Guid("00000002-0006-0000-0000-000000000009"), "CiselnikPolozka", "cs-CZ", "Nazev", "skupina C1" },
                    { new Guid("00000003-0006-0000-0000-000000000014"), null, new Guid("00000002-0006-0000-0000-000000000010"), new Guid("00000002-0006-0000-0000-000000000010"), "CiselnikPolozka", "cs-CZ", "Nazev", "skupina C1E" },
                    { new Guid("00000003-0006-0000-0000-000000000015"), null, new Guid("00000002-0006-0000-0000-000000000011"), new Guid("00000002-0006-0000-0000-000000000011"), "CiselnikPolozka", "cs-CZ", "Nazev", "skupina AM" },
                    { new Guid("00000003-0006-0000-0000-000000000016"), null, new Guid("00000002-0006-0000-0000-000000000012"), new Guid("00000002-0006-0000-0000-000000000012"), "CiselnikPolozka", "cs-CZ", "Nazev", "skupina D1E" },
                    { new Guid("00000003-0006-0000-0000-000000000017"), null, new Guid("00000002-0006-0000-0000-000000000013"), new Guid("00000002-0006-0000-0000-000000000013"), "CiselnikPolozka", "cs-CZ", "Nazev", "skupina T" },
                    { new Guid("00000003-0006-0000-0000-000000000018"), null, new Guid("00000002-0006-0000-0000-000000000014"), new Guid("00000002-0006-0000-0000-000000000014"), "CiselnikPolozka", "cs-CZ", "Nazev", "skupina A2" },
                    { new Guid("00000003-0006-0000-0000-000000000019"), null, new Guid("00000002-0006-0000-0000-000000000015"), new Guid("00000002-0006-0000-0000-000000000015"), "CiselnikPolozka", "cs-CZ", "Nazev", "skupina B1" },
                    { new Guid("00000003-0006-0000-0000-000000000020"), null, new Guid("00000002-0006-0000-0000-000000000016"), new Guid("00000002-0006-0000-0000-000000000016"), "CiselnikPolozka", "cs-CZ", "Nazev", "skupina A1" },
                    { new Guid("00000003-0006-0000-0000-000000000021"), null, new Guid("00000002-0006-0000-0000-000000000001"), new Guid("00000002-0006-0000-0000-000000000001"), "CiselnikPolozka", "cs-CZ", "Popis", "B" },
                    { new Guid("00000003-0006-0000-0000-000000000022"), null, new Guid("00000002-0006-0000-0000-000000000002"), new Guid("00000002-0006-0000-0000-000000000002"), "CiselnikPolozka", "cs-CZ", "Popis", "A" },
                    { new Guid("00000003-0006-0000-0000-000000000023"), null, new Guid("00000002-0006-0000-0000-000000000003"), new Guid("00000002-0006-0000-0000-000000000003"), "CiselnikPolozka", "cs-CZ", "Popis", "D" },
                    { new Guid("00000003-0006-0000-0000-000000000024"), null, new Guid("00000002-0006-0000-0000-000000000004"), new Guid("00000002-0006-0000-0000-000000000004"), "CiselnikPolozka", "cs-CZ", "Popis", "BE" },
                    { new Guid("00000003-0006-0000-0000-000000000025"), null, new Guid("00000002-0006-0000-0000-000000000005"), new Guid("00000002-0006-0000-0000-000000000005"), "CiselnikPolozka", "cs-CZ", "Popis", "C" },
                    { new Guid("00000003-0006-0000-0000-000000000026"), null, new Guid("00000002-0006-0000-0000-000000000006"), new Guid("00000002-0006-0000-0000-000000000006"), "CiselnikPolozka", "cs-CZ", "Popis", "DE" },
                    { new Guid("00000003-0006-0000-0000-000000000027"), null, new Guid("00000002-0006-0000-0000-000000000007"), new Guid("00000002-0006-0000-0000-000000000007"), "CiselnikPolozka", "cs-CZ", "Popis", "CE" },
                    { new Guid("00000003-0006-0000-0000-000000000028"), null, new Guid("00000002-0006-0000-0000-000000000008"), new Guid("00000002-0006-0000-0000-000000000008"), "CiselnikPolozka", "cs-CZ", "Popis", "D1" },
                    { new Guid("00000003-0006-0000-0000-000000000029"), null, new Guid("00000002-0006-0000-0000-000000000009"), new Guid("00000002-0006-0000-0000-000000000009"), "CiselnikPolozka", "cs-CZ", "Popis", "C1" },
                    { new Guid("00000003-0006-0000-0000-000000000030"), null, new Guid("00000002-0006-0000-0000-000000000010"), new Guid("00000002-0006-0000-0000-000000000010"), "CiselnikPolozka", "cs-CZ", "Popis", "C1E" },
                    { new Guid("00000003-0006-0000-0000-000000000031"), null, new Guid("00000002-0006-0000-0000-000000000011"), new Guid("00000002-0006-0000-0000-000000000011"), "CiselnikPolozka", "cs-CZ", "Popis", "AM" },
                    { new Guid("00000003-0006-0000-0000-000000000032"), null, new Guid("00000002-0006-0000-0000-000000000012"), new Guid("00000002-0006-0000-0000-000000000012"), "CiselnikPolozka", "cs-CZ", "Popis", "D1E" },
                    { new Guid("00000003-0006-0000-0000-000000000033"), null, new Guid("00000002-0006-0000-0000-000000000013"), new Guid("00000002-0006-0000-0000-000000000013"), "CiselnikPolozka", "cs-CZ", "Popis", "T" },
                    { new Guid("00000003-0006-0000-0000-000000000034"), null, new Guid("00000002-0006-0000-0000-000000000014"), new Guid("00000002-0006-0000-0000-000000000014"), "CiselnikPolozka", "cs-CZ", "Popis", "A2" },
                    { new Guid("00000003-0006-0000-0000-000000000035"), null, new Guid("00000002-0006-0000-0000-000000000015"), new Guid("00000002-0006-0000-0000-000000000015"), "CiselnikPolozka", "cs-CZ", "Popis", "B1" },
                    { new Guid("00000003-0006-0000-0000-000000000036"), null, new Guid("00000002-0006-0000-0000-000000000016"), new Guid("00000002-0006-0000-0000-000000000016"), "CiselnikPolozka", "cs-CZ", "Popis", "A1" },
                    { new Guid("00000003-0007-0000-0000-000000000005"), null, new Guid("00000002-0007-0000-0000-000002328680"), new Guid("00000002-0007-0000-0000-000002328680"), "CiselnikPolozka", "cs-CZ", "Nazev", "platný" },
                    { new Guid("00000003-0007-0000-0000-000000000006"), null, new Guid("00000002-0007-0000-0000-000002328671"), new Guid("00000002-0007-0000-0000-000002328671"), "CiselnikPolozka", "cs-CZ", "Nazev", "zneplatněný" },
                    { new Guid("00000003-0007-0000-0000-000000000007"), null, new Guid("00000002-0007-0000-0000-000002328681"), new Guid("00000002-0007-0000-0000-000002328681"), "CiselnikPolozka", "cs-CZ", "Nazev", "neplatný" },
                    { new Guid("00000003-0008-0000-0000-000000000005"), null, new Guid("00000002-0008-0000-0000-000002328678"), new Guid("00000002-0008-0000-0000-000002328678"), "CiselnikPolozka", "cs-CZ", "Nazev", "způsobilý" },
                    { new Guid("00000003-0008-0000-0000-000000000006"), null, new Guid("00000002-0008-0000-0000-000002328682"), new Guid("00000002-0008-0000-0000-000002328682"), "CiselnikPolozka", "cs-CZ", "Nazev", "nezpůsobilý" },
                    { new Guid("00000003-0008-0000-0000-000000000007"), null, new Guid("00000002-0008-0000-0000-000002328684"), new Guid("00000002-0008-0000-0000-000002328684"), "CiselnikPolozka", "cs-CZ", "Nazev", "způsobilý s podmínkou" },
                    { new Guid("00000003-0008-0000-0000-000000000008"), null, new Guid("00000002-0008-0000-0000-000002328678"), new Guid("00000002-0008-0000-0000-000002328678"), "CiselnikPolozka", "cs-CZ", "Popis", "Zdravotní způsobilost k řízení motorových vozidel." },
                    { new Guid("00000003-0008-0000-0000-000000000009"), null, new Guid("00000002-0008-0000-0000-000002328682"), new Guid("00000002-0008-0000-0000-000002328682"), "CiselnikPolozka", "cs-CZ", "Popis", "Zdravotní nezpůsobilost k řízení motorových vozidel." },
                    { new Guid("00000003-0008-0000-0000-000000000010"), null, new Guid("00000002-0008-0000-0000-000002328684"), new Guid("00000002-0008-0000-0000-000002328684"), "CiselnikPolozka", "cs-CZ", "Popis", "Zdravotní způsobilost k řízení motorových vozidel s podmínkou." },
                    { new Guid("00000003-0009-0000-0000-000000000005"), null, new Guid("00000002-0009-0000-0000-000002328673"), new Guid("00000002-0009-0000-0000-000002328673"), "CiselnikPolozka", "cs-CZ", "Nazev", "skupina 1" },
                    { new Guid("00000003-0009-0000-0000-000000000006"), null, new Guid("00000002-0009-0000-0000-000002328675"), new Guid("00000002-0009-0000-0000-000002328675"), "CiselnikPolozka", "cs-CZ", "Nazev", "skupina 2" },
                    { new Guid("00000003-0009-0000-0000-000000000007"), null, new Guid("00000002-0009-0000-0000-000002328673"), new Guid("00000002-0009-0000-0000-000002328673"), "CiselnikPolozka", "cs-CZ", "Popis", "Žadatelé a držitelé řidičských oprávnění definovaných vyhláškou 277/2004 Sb." },
                    { new Guid("00000003-0009-0000-0000-000000000008"), null, new Guid("00000002-0009-0000-0000-000002328675"), new Guid("00000002-0009-0000-0000-000002328675"), "CiselnikPolozka", "cs-CZ", "Popis", "Žadatelé a držitelé řidičských oprávnění definovaných vyhláškou 277/2004 Sb." },
                    { new Guid("00000003-0010-0000-0000-000000000005"), null, new Guid("00000002-0010-0000-0000-000000000001"), new Guid("00000002-0010-0000-0000-000000000001"), "CiselnikPolozka", "cs-CZ", "Nazev", "Interní lékař" },
                    { new Guid("00000003-0010-0000-0000-000000000006"), null, new Guid("00000002-0010-0000-0000-000000000001"), new Guid("00000002-0010-0000-0000-000000000001"), "CiselnikPolozka", "cs-CZ", "Popis", "Lékař interního lékařství" },
                    { new Guid("00000003-0010-0000-0000-000000000007"), null, new Guid("00000002-0010-0000-0000-000000000001"), new Guid("00000002-0010-0000-0000-000000000001"), "CiselnikPolozka", "en-US", "Nazev", "Internal medicine" },
                    { new Guid("00000003-0010-0000-0000-000000000008"), null, new Guid("00000002-0010-0000-0000-000000000001"), new Guid("00000002-0010-0000-0000-000000000001"), "CiselnikPolozka", "en-US", "Popis", "Internal medicine physician" },
                    { new Guid("00000003-0010-0000-0000-000000000009"), null, new Guid("00000002-0010-0000-0000-000000000002"), new Guid("00000002-0010-0000-0000-000000000002"), "CiselnikPolozka", "cs-CZ", "Nazev", "Oční lékař" },
                    { new Guid("00000003-0010-0000-0000-000000000010"), null, new Guid("00000002-0010-0000-0000-000000000002"), new Guid("00000002-0010-0000-0000-000000000002"), "CiselnikPolozka", "cs-CZ", "Popis", "Oční lékař (oftalmolog)" },
                    { new Guid("00000003-0010-0000-0000-000000000011"), null, new Guid("00000002-0010-0000-0000-000000000002"), new Guid("00000002-0010-0000-0000-000000000002"), "CiselnikPolozka", "en-US", "Nazev", "Ophthalmologist" },
                    { new Guid("00000003-0010-0000-0000-000000000012"), null, new Guid("00000002-0010-0000-0000-000000000002"), new Guid("00000002-0010-0000-0000-000000000002"), "CiselnikPolozka", "en-US", "Popis", "Eye physician (ophthalmologist)" }
                });

            migrationBuilder.InsertData(
                table: "ZdravotnickyPracovnici",
                columns: new[] { "KrzpId", "Jmeno", "OdbornostId", "PoskytovatelId", "Prijmeni" },
                values: new object[,]
                {
                    { new Guid("00000005-0000-0000-0000-000000000001"), "Petr", new Guid("00000002-0010-0000-0000-000000000001"), new Guid("00000006-0000-0000-0000-000000000001"), "Dvořák" },
                    { new Guid("00000005-0000-0000-0000-000000000002"), "Anna", new Guid("00000002-0010-0000-0000-000000000002"), new Guid("00000006-0000-0000-0000-000000000002"), "Novotná" },
                    { new Guid("00000005-0000-0000-0000-000000000003"), "Michal", new Guid("00000002-0010-0000-0000-000000000001"), new Guid("00000006-0000-0000-0000-000000000003"), "Procházka" }
                });

            migrationBuilder.InsertData(
                table: "PosudekRos",
                columns: new[] { "Id", "DatumVystaveni", "DatumVytvoreni", "DruhPosudkuId", "DruhProhlidkyId", "KrzpId", "OpakovanyPosudekId", "PlatnostDo", "Rid", "SkupinaZadateleRidicId", "StavPosudkuId", "TypAkceId", "VysledekId" },
                values: new object[,]
                {
                    { new Guid("140d9154-0f68-497d-af65-ac322ae204bd"), new DateTime(2026, 3, 22, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 22, 19, 54, 48, 133, DateTimeKind.Utc).AddTicks(6975), new Guid("00000002-0002-0000-0000-000002328547"), new Guid("00000002-0003-0000-0000-000002328559"), new Guid("00000005-0000-0000-0000-000000000002"), null, new DateTime(2026, 10, 21, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000004-0000-0000-0000-000000000002"), new Guid("00000002-0009-0000-0000-000002328673"), new Guid("00000002-0007-0000-0000-000002328680"), new Guid("00000002-0001-0000-0000-000002328610"), new Guid("00000002-0008-0000-0000-000002328678") },
                    { new Guid("6fe858e3-0566-4558-9f1f-01d6868c921e"), new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 21, 19, 54, 48, 133, DateTimeKind.Utc).AddTicks(6975), new Guid("00000002-0002-0000-0000-000002328547"), new Guid("00000002-0003-0000-0000-000002328544"), new Guid("00000005-0000-0000-0000-000000000001"), null, new DateTime(2027, 4, 21, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000004-0000-0000-0000-000000000001"), new Guid("00000002-0009-0000-0000-000002328675"), new Guid("00000002-0007-0000-0000-000002328680"), new Guid("00000002-0001-0000-0000-000002328610"), new Guid("00000002-0008-0000-0000-000002328678") }
                });

            migrationBuilder.InsertData(
                table: "PosudekRoHistories",
                columns: new[] { "Id", "DatumOperace", "KrzpId", "PosudekRoId", "TypOperaceId" },
                values: new object[,]
                {
                    { new Guid("bfee0ec5-03e7-416b-b0f7-1b3e353fbabf"), new DateTime(2026, 3, 22, 19, 54, 48, 133, DateTimeKind.Utc).AddTicks(6975), new Guid("00000005-0000-0000-0000-000000000002"), new Guid("140d9154-0f68-497d-af65-ac322ae204bd"), new Guid("00000002-0001-0000-0000-000002328610") },
                    { new Guid("cee3582c-e7e2-4633-bf09-9d92911fdef9"), new DateTime(2026, 4, 21, 19, 54, 48, 133, DateTimeKind.Utc).AddTicks(6975), new Guid("00000005-0000-0000-0000-000000000001"), new Guid("6fe858e3-0566-4558-9f1f-01d6868c921e"), new Guid("00000002-0001-0000-0000-000002328610") }
                });

            migrationBuilder.InsertData(
                table: "PosudekRoZpusobilosti",
                columns: new[] { "Id", "PosudekRoId", "SkupinaZadateleRidicId", "VysledekId" },
                values: new object[,]
                {
                    { new Guid("675357b4-1ea5-482e-b049-0b1a330a2460"), new Guid("6fe858e3-0566-4558-9f1f-01d6868c921e"), new Guid("00000002-0009-0000-0000-000002328675"), new Guid("00000002-0008-0000-0000-000002328678") },
                    { new Guid("c71fa81b-79eb-4c3c-821b-0782d7283c5e"), new Guid("140d9154-0f68-497d-af65-ac322ae204bd"), new Guid("00000002-0009-0000-0000-000002328673"), new Guid("00000002-0008-0000-0000-000002328678") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pacienti",
                keyColumn: "Rid",
                keyValue: new Guid("00000004-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "PosudekRoHistories",
                keyColumn: "Id",
                keyValue: new Guid("bfee0ec5-03e7-416b-b0f7-1b3e353fbabf"));

            migrationBuilder.DeleteData(
                table: "PosudekRoHistories",
                keyColumn: "Id",
                keyValue: new Guid("cee3582c-e7e2-4633-bf09-9d92911fdef9"));

            migrationBuilder.DeleteData(
                table: "PosudekRoZpusobilosti",
                keyColumn: "Id",
                keyValue: new Guid("675357b4-1ea5-482e-b049-0b1a330a2460"));

            migrationBuilder.DeleteData(
                table: "PosudekRoZpusobilosti",
                keyColumn: "Id",
                keyValue: new Guid("c71fa81b-79eb-4c3c-821b-0782d7283c5e"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0001-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0001-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0001-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0001-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0001-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0001-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0001-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0001-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0001-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0001-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0002-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0002-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0002-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0002-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0002-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0002-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0002-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0002-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0002-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0002-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0002-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0002-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0002-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0002-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0003-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0003-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0003-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0003-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0003-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0003-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0003-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0003-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0003-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0003-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000035"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000036"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000037"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000038"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000039"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000040"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000041"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000042"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000043"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000044"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000045"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000046"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000047"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000048"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000049"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000050"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000051"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000052"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000053"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000054"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000055"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000056"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000057"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000058"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000059"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000060"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000061"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000062"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000063"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000064"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000065"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000066"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000067"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000068"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000069"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000070"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000074"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000075"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000076"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000077"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000078"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000079"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000080"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000081"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000082"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000083"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000084"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000085"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000086"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000087"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000088"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000089"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000090"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000093"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000094"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000095"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000096"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000097"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000098"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000099"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000100"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000101"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000102"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000103"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000104"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000105"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000106"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000107"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000108"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000109"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000110"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000111"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000112"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000113"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000114"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000115"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000116"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000117"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000118"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000119"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000120"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000121"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000122"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000123"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000124"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000125"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000126"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000127"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000128"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000129"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000130"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000131"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000132"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000133"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000134"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000135"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000136"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000137"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000138"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000139"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000140"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000141"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000142"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000143"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000144"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000145"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000146"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000147"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000148"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000149"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000150"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000151"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000152"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000153"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000154"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000155"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000156"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000157"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000158"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000159"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000160"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000161"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0004-0000-0000-000000000162"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0005-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000035"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0006-0000-0000-000000000036"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0007-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0007-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0007-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0007-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0007-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0007-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0007-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0008-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0008-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0008-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0008-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0008-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0008-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0008-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0008-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0008-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0008-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0009-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0009-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0009-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0009-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0009-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0009-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0009-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0009-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0010-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0010-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0010-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0010-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0010-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0010-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0010-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0010-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0010-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0010-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0010-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0010-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "ZdravotnickyPracovnici",
                keyColumn: "KrzpId",
                keyValue: new Guid("00000005-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0001-0000-0000-000002328601"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0001-0000-0000-000002328612"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0002-0000-0000-000002328552"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0002-0000-0000-000002328554"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0002-0000-0000-000002328606"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0002-0000-0000-000002328608"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0003-0000-0000-000002328561"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000035"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000036"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000037"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000038"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000039"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000040"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000041"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000042"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000043"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000044"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000045"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000046"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000047"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000048"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000049"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000050"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000051"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000052"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000053"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000054"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000055"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000056"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000057"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000058"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000059"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000060"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000061"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000062"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000063"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000064"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000065"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000066"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000067"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000068"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000069"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000070"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000074"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000075"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000076"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000077"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000078"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000079"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0004-0000-0000-000000000080"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0005-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0005-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0005-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0005-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0005-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0005-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0005-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0005-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0005-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0005-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0006-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0006-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0006-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0006-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0006-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0006-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0006-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0006-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0006-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0006-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0006-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0006-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0006-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0006-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0006-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0006-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0007-0000-0000-000002328671"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0007-0000-0000-000002328681"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0008-0000-0000-000002328682"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0008-0000-0000-000002328684"));

            migrationBuilder.DeleteData(
                table: "PoskytovateleZdravotnickychSluzeb",
                keyColumn: "Id",
                keyValue: new Guid("00000006-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "PosudekRos",
                keyColumn: "Id",
                keyValue: new Guid("140d9154-0f68-497d-af65-ac322ae204bd"));

            migrationBuilder.DeleteData(
                table: "PosudekRos",
                keyColumn: "Id",
                keyValue: new Guid("6fe858e3-0566-4558-9f1f-01d6868c921e"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0001-0000-0000-000002328610"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0002-0000-0000-000002328547"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0003-0000-0000-000002328544"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0003-0000-0000-000002328559"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0007-0000-0000-000002328680"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0008-0000-0000-000002328678"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0009-0000-0000-000002328673"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0009-0000-0000-000002328675"));

            migrationBuilder.DeleteData(
                table: "Ciselniky",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0004-0000-0000-000002328890"));

            migrationBuilder.DeleteData(
                table: "Ciselniky",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0005-0000-0000-000002328868"));

            migrationBuilder.DeleteData(
                table: "Ciselniky",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0006-0000-0000-000002328874"));

            migrationBuilder.DeleteData(
                table: "Pacienti",
                keyColumn: "Rid",
                keyValue: new Guid("00000004-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Pacienti",
                keyColumn: "Rid",
                keyValue: new Guid("00000004-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "ZdravotnickyPracovnici",
                keyColumn: "KrzpId",
                keyValue: new Guid("00000005-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ZdravotnickyPracovnici",
                keyColumn: "KrzpId",
                keyValue: new Guid("00000005-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0010-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "CiselnikPolozky",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0010-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Ciselniky",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0001-0000-0000-000002328856"));

            migrationBuilder.DeleteData(
                table: "Ciselniky",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0002-0000-0000-000002328862"));

            migrationBuilder.DeleteData(
                table: "Ciselniky",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0003-0000-0000-000002328865"));

            migrationBuilder.DeleteData(
                table: "Ciselniky",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0007-0000-0000-000002328877"));

            migrationBuilder.DeleteData(
                table: "Ciselniky",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0008-0000-0000-000002328883"));

            migrationBuilder.DeleteData(
                table: "Ciselniky",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0009-0000-0000-000002328886"));

            migrationBuilder.DeleteData(
                table: "PoskytovateleZdravotnickychSluzeb",
                keyColumn: "Id",
                keyValue: new Guid("00000006-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "PoskytovateleZdravotnickychSluzeb",
                keyColumn: "Id",
                keyValue: new Guid("00000006-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Ciselniky",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0010-0000-0000-000000000001"));

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
        }
    }
}
