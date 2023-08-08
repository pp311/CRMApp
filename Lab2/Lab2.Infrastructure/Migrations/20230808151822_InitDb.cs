using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    TotalSales = table.Column<double>(type: "float", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenLifetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    Source = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    EstimatedRevenue = table.Column<double>(type: "float", nullable: false),
                    EndedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DisqualifiedReason = table.Column<int>(type: "int", nullable: true),
                    DisqualifiedDescription = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leads_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    ActualRevenue = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    LeadId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deals_Leads_LeadId",
                        column: x => x.LeadId,
                        principalTable: "Leads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DealProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    PricePerUnit = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DealProducts_Deals_DealId",
                        column: x => x.DealId,
                        principalTable: "Deals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DealProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Address", "CreatedAt", "CreatedBy", "Email", "ModifiedAt", "ModifiedBy", "Name", "Phone", "TotalSales" },
                values: new object[,]
                {
                    { 1, "148 Jones Well, Mohrmouth, Slovenia", null, null, "Gillian_Marvin@gmail.com", null, null, "Thompson Group", "1-361-370-6351", 45898.0 },
                    { 2, "833 McDermott Garden, North Muriel, Pitcairn Islands", null, null, "Kenny73@yahoo.com", null, null, "Schoen, Davis and Swaniawski", "367.953.7168", 10220.0 },
                    { 3, "02024 Carroll Street, South Jacinto, Saudi Arabia", null, null, "Uriel.Kertzmann40@gmail.com", null, null, "Ritchie, Wehner and Crona", "(545) 276-5372", 45389.0 },
                    { 4, "53290 Tianna Village, North Nikolasfurt, Libyan Arab Jamahiriya", null, null, "Nash.Hickle3@hotmail.com", null, null, "Altenwerth - Emmerich", "1-379-618-8457", 5471.0 },
                    { 5, "6196 Stokes Street, South Hughton, Bosnia and Herzegovina", null, null, "Anais.Reichel@hotmail.com", null, null, "Larkin LLC", "487.906.8362", 48147.0 },
                    { 6, "096 Demario Rue, Franciscaside, Venezuela", null, null, "Eleanore_Schimmel41@hotmail.com", null, null, "Leffler - Ortiz", "619-289-9766", 34444.0 },
                    { 7, "18927 Kristopher Mountain, North Afton, Macao", null, null, "Carter0@hotmail.com", null, null, "Collins, Wehner and Hessel", "616.980.9789 x4905", 12009.0 },
                    { 8, "152 Davin Crossroad, Julietland, Guinea-Bissau", null, null, "Amelie.Emard@yahoo.com", null, null, "Marks - Wolff", "(257) 844-2443 x26207", 17098.0 },
                    { 9, "2346 Mylene Mission, Ullrichmouth, South Georgia and the South Sandwich Islands", null, null, "Emmie_Gislason92@gmail.com", null, null, "Schmitt - Braun", "1-619-489-4303 x765", 29185.0 },
                    { 10, "0042 Linwood Isle, Koelpinberg, Marshall Islands", null, null, "Manley_Franecki41@hotmail.com", null, null, "Cremin, Bechtelar and Gaylord", "767-875-5215 x98879", 48896.0 },
                    { 11, "219 Grady Rapid, Wuckertshire, Aruba", null, null, "Jocelyn33@hotmail.com", null, null, "Schimmel Inc", "291.471.9429 x8370", 40030.0 },
                    { 12, "876 Lind Pike, West Millerborough, Palau", null, null, "Candido84@hotmail.com", null, null, "Murray - Koch", "1-650-608-4533 x59183", 7009.0 },
                    { 13, "114 Dominic Island, Port Justice, Guernsey", null, null, "Nat_Hamill@hotmail.com", null, null, "Stanton - Braun", "649.554.4091", 43309.0 },
                    { 14, "956 Anibal Motorway, West Wilber, United Arab Emirates", null, null, "Audie.Bauch24@hotmail.com", null, null, "Lynch, Stracke and Stark", "(359) 573-7984 x30973", 27355.0 },
                    { 15, "051 Raymond Vista, East Garfieldview, Philippines", null, null, "Ettie.Donnelly47@hotmail.com", null, null, "Miller, Cruickshank and Stoltenberg", "926-802-2916 x78114", 2524.0 },
                    { 16, "7996 Wunsch Village, Arnoland, New Caledonia", null, null, "Kayla_Dickinson81@hotmail.com", null, null, "Williamson Group", "(762) 466-8823 x0873", 5747.0 },
                    { 17, "461 Howell Flats, Port Jovantown, Barbados", null, null, "Eldred_Luettgen41@hotmail.com", null, null, "Runolfsson, Nienow and Feil", "638.371.8885 x263", 42113.0 },
                    { 18, "27571 Kuhlman Village, East Chrisburgh, Guyana", null, null, "Harry.Hickle45@yahoo.com", null, null, "Quitzon Group", "291-600-3425 x1441", 1203.0 },
                    { 19, "042 Trycia Expressway, South Jannie, Saint Martin", null, null, "Carmel_Runolfsdottir38@gmail.com", null, null, "Jakubowski - Koepp", "677-580-1228 x188", 44903.0 },
                    { 20, "752 Sven Burgs, Lake Elvieport, France", null, null, "Baylee_Green97@yahoo.com", null, null, "Batz - Zboncak", "767.825.5572", 27621.0 },
                    { 21, "81705 Natalie Neck, Idelltown, Mauritania", null, null, "Juanita23@hotmail.com", null, null, "Howell - Ondricka", "1-987-732-2643 x7633", 42597.0 },
                    { 22, "45236 Swaniawski Valleys, South Toni, South Georgia and the South Sandwich Islands", null, null, "Myah77@hotmail.com", null, null, "Kshlerin, Rosenbaum and Crooks", "(236) 459-0237", 23805.0 },
                    { 23, "74549 Dietrich Crescent, New Kaylee, Democratic People's Republic of Korea", null, null, "Reid70@gmail.com", null, null, "Feest - Blanda", "1-881-999-7367 x24651", 12759.0 },
                    { 24, "357 Gulgowski Crest, South Arelyfort, Australia", null, null, "Steve26@yahoo.com", null, null, "Gorczany Inc", "833.527.2316 x52803", 16161.0 },
                    { 25, "0214 Langosh Tunnel, Port Floyville, Morocco", null, null, "Celine.Doyle94@yahoo.com", null, null, "Armstrong - Haley", "869-305-3233", 11093.0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "SuperAdmin", "SUPERADMIN" },
                    { 2, null, "Admin", "ADMIN" },
                    { 3, null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenLifetime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "8b27eb77-b3d0-4a18-9af4-3b5c6db5d795", "superadmin@gmail.com", true, false, null, "superadmin", "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAENTThNZtbO4T5HjRhpjwH/qgKlh3SHekFyAI2vb6tXdnyIvNHuSe99iEE+RkSq5XKA==", null, false, null, null, "c7ec9813-4453-4847-ab9e-a0be99b1e870", false, "superadmin@gmail.com" },
                    { 2, 0, "a2762fb6-cff5-428b-a1fc-c1f4eb48c7ea", "admin@gmail.com", true, false, null, "admin", "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEL8D3c3ECsYL8wazc6slvj0CKEu8MrECJ7BB0vqQ6UNIo/cB/idfaoQ0S8FfkHEnxA==", null, false, null, null, "1f577229-7a12-4540-9d7c-ca1c7a674746", false, "admin@gmail.com" },
                    { 3, 0, "c4ae39d5-977c-4eeb-b6fc-c981e2ccb008", "Moshe.Willms@hotmail.com", false, false, null, "Ashley Bogisich", null, null, null, null, false, null, null, "c8666ba9-856e-4b04-8da8-4a8e568eb131", false, "Moshe.Willms@hotmail.com" },
                    { 4, 0, "53638482-da9f-435a-864c-ec2e1f55523d", "Susanna39@hotmail.com", false, false, null, "Maymie Schuppe", null, null, null, null, false, null, null, "bbc97412-29e8-4615-a496-8338770b8ee0", false, "Susanna39@hotmail.com" },
                    { 5, 0, "a63a7ea0-53ad-4164-b143-c2aba401aad1", "Kolby.Tremblay49@gmail.com", false, false, null, "Mabel Jacobson", null, null, null, null, false, null, null, "c00e9c2f-2c6c-4d67-9773-605b27c7167a", false, "Kolby.Tremblay49@gmail.com" },
                    { 6, 0, "6c3accb5-5d2f-4ed5-a342-e673ea82ec77", "Jovany68@gmail.com", false, false, null, "Casper Rodriguez", null, null, null, null, false, null, null, "7ede1a1b-c2ad-4cd1-bbab-ca4339c7bf66", false, "Jovany68@gmail.com" },
                    { 7, 0, "1546ee3c-cb73-4fde-8435-d08dfb0af35a", "Ari_Effertz@gmail.com", false, false, null, "Icie Moore", null, null, null, null, false, null, null, "bcdfdbce-6f13-412e-b095-9e5578e3c152", false, "Ari_Effertz@gmail.com" },
                    { 8, 0, "f7bb7793-8adb-4cb9-9b3d-3e55a08f5d72", "Ayana_Corkery@gmail.com", false, false, null, "Yvette Feeney", null, null, null, null, false, null, null, "5120e26c-7d4c-4d91-8bd4-b1ab4c515a7e", false, "Ayana_Corkery@gmail.com" },
                    { 9, 0, "fda7635a-410d-4033-82aa-d45f66434a29", "Annamarie.Frami40@yahoo.com", false, false, null, "Buster Tromp", null, null, null, null, false, null, null, "2e8ac2ec-d038-480d-8f31-8216492f9b44", false, "Annamarie.Frami40@yahoo.com" },
                    { 10, 0, "463de104-0491-404c-ae19-9b9c916212ee", "Perry.Ruecker@gmail.com", false, false, null, "Leland Kuphal", null, null, null, null, false, null, null, "0cad77e2-bad9-4701-a29a-4b06e17a2010", false, "Perry.Ruecker@gmail.com" },
                    { 11, 0, "a8177100-caff-4ad4-8a44-19c6581351b1", "Alfredo_Crist@gmail.com", false, false, null, "Magdalena Bartoletti", null, null, null, null, false, null, null, "64a06b2a-a722-4e54-afaf-9dee9fe54824", false, "Alfredo_Crist@gmail.com" },
                    { 12, 0, "3d640efe-0dd9-423c-b74c-e6aef6af2eeb", "Kimberly.Krajcik@yahoo.com", false, false, null, "Meaghan Corwin", null, null, null, null, false, null, null, "550ea0f6-a4fb-4039-ba35-4e932877600e", false, "Kimberly.Krajcik@yahoo.com" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsAvailable", "ModifiedAt", "ModifiedBy", "Name", "Price", "ProductCode", "Type" },
                values: new object[,]
                {
                    { 1, null, null, true, null, null, "Awesome Wooden Gloves", 373.0, "PRO-62205085", 0 },
                    { 2, null, null, true, null, null, "Fantastic Soft Soap", 129.0, "PRO-89560631", 0 },
                    { 3, null, null, true, null, null, "Tasty Plastic Cheese", 933.0, "PRO-28174189", 1 },
                    { 4, null, null, true, null, null, "Rustic Wooden Computer", 630.0, "PRO-14389795", 1 },
                    { 5, null, null, true, null, null, "Intelligent Soft Table", 854.0, "PRO-12961757", 0 },
                    { 6, null, null, true, null, null, "Sleek Granite Bacon", 13.0, "PRO-58764626", 1 },
                    { 7, null, null, true, null, null, "Generic Cotton Keyboard", 297.0, "PRO-63291148", 1 },
                    { 8, null, null, true, null, null, "Refined Concrete Bike", 978.0, "PRO-19863870", 1 },
                    { 9, null, null, true, null, null, "Unbranded Cotton Bacon", 663.0, "PRO-41985212", 0 },
                    { 10, null, null, true, null, null, "Awesome Concrete Towels", 509.0, "PRO-00806077", 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "permission", "Permission.Role.View", 1 },
                    { 2, "permission", "Permission.Role.Edit", 1 },
                    { 3, "permission", "Permission.User.View", 1 },
                    { 4, "permission", "Permission.User.View", 3 },
                    { 5, "permission", "Permission.User.View", 2 },
                    { 6, "permission", "Permission.User.Create", 1 },
                    { 7, "permission", "Permission.User.Create", 2 },
                    { 8, "permission", "Permission.User.Edit", 1 },
                    { 9, "permission", "Permission.User.Edit", 2 },
                    { 10, "permission", "Permission.User.Delete", 1 },
                    { 11, "permission", "Permission.User.Delete", 2 },
                    { 12, "permission", "Permission.Product.View", 1 },
                    { 13, "permission", "Permission.Product.View", 3 },
                    { 14, "permission", "Permission.Product.View", 2 },
                    { 15, "permission", "Permission.Product.Create", 1 },
                    { 16, "permission", "Permission.Product.Create", 2 },
                    { 17, "permission", "Permission.Product.Edit", 1 },
                    { 18, "permission", "Permission.Product.Edit", 2 },
                    { 19, "permission", "Permission.Product.Delete", 1 },
                    { 20, "permission", "Permission.Product.Delete", 2 },
                    { 21, "permission", "Permission.Account.View", 1 },
                    { 22, "permission", "Permission.Account.View", 3 },
                    { 23, "permission", "Permission.Account.View", 2 },
                    { 24, "permission", "Permission.Account.Create", 1 },
                    { 25, "permission", "Permission.Account.Create", 2 },
                    { 26, "permission", "Permission.Account.Edit", 1 },
                    { 27, "permission", "Permission.Account.Edit", 2 },
                    { 28, "permission", "Permission.Account.Delete", 1 },
                    { 29, "permission", "Permission.Account.Delete", 2 },
                    { 30, "permission", "Permission.Lead.View", 1 },
                    { 31, "permission", "Permission.Lead.View", 3 },
                    { 32, "permission", "Permission.Lead.View", 2 },
                    { 33, "permission", "Permission.Lead.Create", 1 },
                    { 34, "permission", "Permission.Lead.Create", 2 },
                    { 35, "permission", "Permission.Lead.Edit", 1 },
                    { 36, "permission", "Permission.Lead.Edit", 2 },
                    { 37, "permission", "Permission.Lead.Qualify", 1 },
                    { 38, "permission", "Permission.Lead.Qualify", 2 },
                    { 39, "permission", "Permission.Lead.Disqualify", 1 },
                    { 40, "permission", "Permission.Lead.Disqualify", 2 },
                    { 41, "permission", "Permission.Lead.Delete", 1 },
                    { 42, "permission", "Permission.Lead.Delete", 2 },
                    { 43, "permission", "Permission.Deal.View", 1 },
                    { 44, "permission", "Permission.Deal.View", 3 },
                    { 45, "permission", "Permission.Deal.View", 2 },
                    { 46, "permission", "Permission.Deal.Edit", 1 },
                    { 47, "permission", "Permission.Deal.Edit", 2 },
                    { 48, "permission", "Permission.Deal.EndDeal", 1 },
                    { 49, "permission", "Permission.Deal.EndDeal", 2 },
                    { 50, "permission", "Permission.Deal.Delete", 1 },
                    { 51, "permission", "Permission.Deal.Delete", 2 },
                    { 52, "permission", "Permission.Deal.Product.View", 1 },
                    { 53, "permission", "Permission.Deal.Product.View", 3 },
                    { 54, "permission", "Permission.Deal.Product.View", 2 },
                    { 55, "permission", "Permission.Deal.Product.Add", 1 },
                    { 56, "permission", "Permission.Deal.Product.Add", 2 },
                    { 57, "permission", "Permission.Deal.Product.Edit", 1 },
                    { 58, "permission", "Permission.Deal.Product.Edit", 2 },
                    { 59, "permission", "Permission.Deal.Product.Delete", 1 },
                    { 60, "permission", "Permission.Deal.Product.Delete", 2 },
                    { 61, "permission", "Permission.Contact.View", 1 },
                    { 62, "permission", "Permission.Contact.View", 3 },
                    { 63, "permission", "Permission.Contact.View", 2 },
                    { 64, "permission", "Permission.Contact.Create", 1 },
                    { 65, "permission", "Permission.Contact.Create", 2 },
                    { 66, "permission", "Permission.Contact.Edit", 1 },
                    { 67, "permission", "Permission.Contact.Edit", 2 },
                    { 68, "permission", "Permission.Contact.Delete", 1 },
                    { 69, "permission", "Permission.Contact.Delete", 2 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 3, 12 }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "AccountId", "CreatedAt", "CreatedBy", "Email", "ModifiedAt", "ModifiedBy", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, 25, null, null, "Carleton52@yahoo.com", null, null, "Elian Rau", "463.434.0672" },
                    { 2, 1, null, null, "Camille90@yahoo.com", null, null, "Araceli Bayer", "1-347-408-4077 x623" },
                    { 3, 15, null, null, "Pansy30@yahoo.com", null, null, "Cali Padberg", "(696) 358-3844 x770" },
                    { 4, 18, null, null, "Electa_Gleason20@hotmail.com", null, null, "Kathryne Reilly", "(421) 292-0354" },
                    { 5, 3, null, null, "Reta_Bednar70@gmail.com", null, null, "Elyse Mayert", "(578) 835-5623 x660" },
                    { 6, 21, null, null, "Emilie83@hotmail.com", null, null, "Kobe Thompson", "1-575-262-7368" },
                    { 7, 4, null, null, "Alessandra98@gmail.com", null, null, "Zella Ondricka", "667.852.7621 x320" },
                    { 8, 4, null, null, "Rebekah.Spencer58@hotmail.com", null, null, "Precious Buckridge", "501-369-2470 x4944" },
                    { 9, 5, null, null, "Ibrahim.Huel@hotmail.com", null, null, "Terry Hagenes", "943-437-2571" },
                    { 10, 17, null, null, "Shana67@gmail.com", null, null, "Jordyn Wintheiser", "1-839-275-8595 x23180" },
                    { 11, 18, null, null, "Talia58@hotmail.com", null, null, "Carlotta Larkin", "1-458-926-7153 x85535" },
                    { 12, 5, null, null, "Kristian_Ward71@yahoo.com", null, null, "Sadye O'Kon", "438-569-8253 x7379" },
                    { 13, 11, null, null, "Haven86@gmail.com", null, null, "Berniece Pagac", "918-927-7112 x93551" },
                    { 14, 6, null, null, "Weldon_Herzog@hotmail.com", null, null, "Jerrod McClure", "387.985.6231" },
                    { 15, 8, null, null, "Abdiel96@gmail.com", null, null, "Quincy Volkman", "320.795.6656 x01005" },
                    { 16, 20, null, null, "Ocie_Waelchi91@hotmail.com", null, null, "Francesco Brown", "(938) 252-6884 x662" },
                    { 17, 23, null, null, "Darby68@hotmail.com", null, null, "Anika Reinger", "(333) 827-3534 x455" },
                    { 18, 11, null, null, "Shannon78@gmail.com", null, null, "Robb Stamm", "(534) 762-3153 x98349" },
                    { 19, 13, null, null, "Kitty.Steuber@gmail.com", null, null, "Stuart Hahn", "(816) 825-1731 x6222" },
                    { 20, 9, null, null, "Jevon71@yahoo.com", null, null, "Devon Bernhard", "(431) 236-5463 x2412" },
                    { 21, 11, null, null, "Ebba7@yahoo.com", null, null, "Katherine Heller", "(372) 762-6958 x412" },
                    { 22, 12, null, null, "Marley_Rogahn3@gmail.com", null, null, "Brisa Conroy", "796-745-3372 x601" },
                    { 23, 1, null, null, "Dasia.Denesik@hotmail.com", null, null, "Kenneth Dooley", "251-890-7936 x2925" },
                    { 24, 15, null, null, "Kailey_Emard45@gmail.com", null, null, "Joannie Bergnaum", "(433) 483-8303 x94100" },
                    { 25, 9, null, null, "Frederique40@gmail.com", null, null, "Alba Olson", "504.931.4418 x941" },
                    { 26, 6, null, null, "Asha72@hotmail.com", null, null, "Lauretta O'Connell", "940-554-0078 x0008" },
                    { 27, 1, null, null, "Eddie36@gmail.com", null, null, "Scotty Windler", "(246) 396-0939" },
                    { 28, 14, null, null, "Obie_Brakus@gmail.com", null, null, "Bennie Price", "819.279.8238 x9523" },
                    { 29, 8, null, null, "Reuben.OHara49@yahoo.com", null, null, "Hilario Connelly", "887-728-1212" },
                    { 30, 3, null, null, "Cheyenne_Johnson@gmail.com", null, null, "Damon Ritchie", "339-624-6479 x20167" },
                    { 31, 16, null, null, "Florine_Zieme98@yahoo.com", null, null, "Mauricio Jones", "549-407-1334 x9224" },
                    { 32, 16, null, null, "Marian51@hotmail.com", null, null, "Gonzalo Schamberger", "522.534.4515 x7207" },
                    { 33, 3, null, null, "Amina.Batz@hotmail.com", null, null, "Orval Hagenes", "817-660-1775" },
                    { 34, 5, null, null, "Monserrat_Graham@yahoo.com", null, null, "Willy Bauch", "1-460-430-9643 x7389" },
                    { 35, 12, null, null, "Marjolaine75@gmail.com", null, null, "Consuelo Effertz", "(231) 655-2718 x934" },
                    { 36, 7, null, null, "Emmet.Labadie@hotmail.com", null, null, "Andrew Cummerata", "414-226-6115 x237" },
                    { 37, 7, null, null, "Gillian43@yahoo.com", null, null, "Crystel Lynch", "1-747-951-9541 x963" },
                    { 38, 10, null, null, "Daphne.Fisher@hotmail.com", null, null, "Sonia Rath", "(285) 749-8917 x969" },
                    { 39, 14, null, null, "Haylie53@hotmail.com", null, null, "Friedrich Hoeger", "1-272-403-5594 x349" },
                    { 40, 18, null, null, "Sterling_Romaguera87@hotmail.com", null, null, "Silas Kling", "(863) 652-4704 x190" },
                    { 41, 16, null, null, "Katlynn_Gottlieb@gmail.com", null, null, "Orland Schumm", "1-606-840-7678" },
                    { 42, 20, null, null, "Alysha_Kshlerin@hotmail.com", null, null, "Wilton Swift", "587-337-5602" },
                    { 43, 15, null, null, "Adam.Leuschke@yahoo.com", null, null, "Alexa Larson", "954.442.0957 x651" },
                    { 44, 3, null, null, "Marianne59@yahoo.com", null, null, "Muriel Jast", "955-616-6847" },
                    { 45, 8, null, null, "Olin73@hotmail.com", null, null, "Carolyn Wuckert", "566-765-5833 x336" },
                    { 46, 24, null, null, "Elyssa.Mayert@yahoo.com", null, null, "Micheal Marvin", "1-606-558-7112 x3135" },
                    { 47, 13, null, null, "Zula_Jerde2@yahoo.com", null, null, "Schuyler Strosin", "(671) 314-0873" },
                    { 48, 19, null, null, "Chloe_Quitzon39@yahoo.com", null, null, "Griffin Johnston", "942.621.9056 x67171" },
                    { 49, 18, null, null, "Edgar82@gmail.com", null, null, "Gilbert Wuckert", "(544) 330-3577 x228" },
                    { 50, 15, null, null, "Korey_Fritsch38@yahoo.com", null, null, "Doug Greenholt", "395-269-1613 x7708" },
                    { 51, 1, null, null, "Austen13@hotmail.com", null, null, "Chaz O'Conner", "(896) 218-0156" },
                    { 52, 14, null, null, "Tavares45@yahoo.com", null, null, "Ezekiel Becker", "1-967-287-8018" },
                    { 53, 11, null, null, "Eulalia.Hilll32@gmail.com", null, null, "Keegan Buckridge", "263-387-3583 x186" },
                    { 54, 16, null, null, "Lyric.Runolfsson56@hotmail.com", null, null, "Justine Konopelski", "1-440-468-9544 x10337" },
                    { 55, 14, null, null, "Mark_Jenkins@gmail.com", null, null, "Janessa Lang", "321.344.8945" },
                    { 56, 17, null, null, "Keaton38@gmail.com", null, null, "Graham Kshlerin", "(311) 349-7294 x6144" },
                    { 57, 3, null, null, "Malcolm.Klein74@gmail.com", null, null, "Natalia Bosco", "1-380-702-9546" },
                    { 58, 23, null, null, "Leonard_Walter@hotmail.com", null, null, "Mario DuBuque", "697-283-9090 x9882" },
                    { 59, 12, null, null, "Callie.McClure@yahoo.com", null, null, "Candace Prosacco", "(756) 621-1665" },
                    { 60, 20, null, null, "Kenny45@hotmail.com", null, null, "Chase Hansen", "868.580.8904" },
                    { 61, 6, null, null, "Kade.Harvey@yahoo.com", null, null, "Erik Jakubowski", "776-833-3770 x567" },
                    { 62, 1, null, null, "Giovanna.Parker@hotmail.com", null, null, "Emily Thompson", "(667) 456-6594" },
                    { 63, 8, null, null, "Mohammad_Rath@gmail.com", null, null, "Alize Funk", "878-645-8324 x2321" },
                    { 64, 18, null, null, "Joy97@yahoo.com", null, null, "Justice Cole", "(445) 764-6946" },
                    { 65, 2, null, null, "Natalie12@hotmail.com", null, null, "Wilfrid Ratke", "424.413.2802" },
                    { 66, 18, null, null, "Savanna_Kemmer58@gmail.com", null, null, "Bernadine Kuphal", "(465) 669-0809" },
                    { 67, 24, null, null, "Kaelyn.Lindgren@yahoo.com", null, null, "Cierra Veum", "1-408-443-4805 x20811" },
                    { 68, 21, null, null, "Pedro.Denesik@yahoo.com", null, null, "Tomas Reichert", "1-987-537-2685" },
                    { 69, 19, null, null, "Pattie68@hotmail.com", null, null, "Jaylin Bailey", "351-778-4377 x3959" },
                    { 70, 11, null, null, "Neha34@gmail.com", null, null, "Noemy Kovacek", "324.863.0040 x56828" },
                    { 71, 21, null, null, "Tamia56@hotmail.com", null, null, "Devon Crooks", "(257) 439-2601 x1482" },
                    { 72, 13, null, null, "Doug_Schaden91@yahoo.com", null, null, "Carole Crist", "(671) 275-5269 x5123" },
                    { 73, 22, null, null, "Agustina_Williamson@hotmail.com", null, null, "Maximillia McGlynn", "1-393-237-4707 x19222" },
                    { 74, 15, null, null, "Stephanie.Crist70@yahoo.com", null, null, "Rhianna Anderson", "590.674.1162 x74489" },
                    { 75, 21, null, null, "Jeffry_Christiansen@yahoo.com", null, null, "Willow Bartell", "1-956-684-6898 x10636" },
                    { 76, 15, null, null, "Edgardo.Ruecker@hotmail.com", null, null, "Ransom Heaney", "(892) 394-3065" },
                    { 77, 20, null, null, "Davin_Renner26@yahoo.com", null, null, "Anthony Schimmel", "1-397-770-2239 x4304" },
                    { 78, 25, null, null, "Susana.Corkery27@gmail.com", null, null, "Deondre Hoeger", "261.600.4867 x4252" },
                    { 79, 23, null, null, "Brianne.Cruickshank39@gmail.com", null, null, "Isabel Kshlerin", "875.514.2638 x747" },
                    { 80, 20, null, null, "River.Lang74@hotmail.com", null, null, "Janelle Walker", "320-221-3082 x7470" },
                    { 81, 19, null, null, "Jonathon1@gmail.com", null, null, "Hugh Smitham", "1-942-366-3144 x2645" },
                    { 82, 9, null, null, "Josue_Gerlach29@gmail.com", null, null, "Kirstin Schmeler", "(856) 812-6244 x16155" },
                    { 83, 11, null, null, "Robbie.Stamm@gmail.com", null, null, "Suzanne Marquardt", "(336) 980-6188" },
                    { 84, 15, null, null, "Heloise_Auer8@yahoo.com", null, null, "Adolf Green", "246.545.4008 x575" },
                    { 85, 4, null, null, "Gideon.Kassulke@hotmail.com", null, null, "Zelda Hagenes", "220-673-5940" },
                    { 86, 20, null, null, "Raquel.Mills@yahoo.com", null, null, "Alexandre Parker", "1-242-974-6784" },
                    { 87, 22, null, null, "Ubaldo99@yahoo.com", null, null, "Marquise King", "810-610-8627" },
                    { 88, 25, null, null, "Christiana.Kutch@yahoo.com", null, null, "Burdette Pfeffer", "815-590-3435 x084" },
                    { 89, 2, null, null, "Royal47@yahoo.com", null, null, "Nicolette Rempel", "836.972.2356 x3132" },
                    { 90, 3, null, null, "Kyra51@yahoo.com", null, null, "Minerva Batz", "890.532.3428 x40127" },
                    { 91, 7, null, null, "Jessy_Marquardt55@hotmail.com", null, null, "Merlin Deckow", "585.204.6133 x19111" },
                    { 92, 20, null, null, "Cale3@hotmail.com", null, null, "Isai Carter", "269-314-9381 x055" },
                    { 93, 3, null, null, "Herminia.Keebler@hotmail.com", null, null, "Hazle Ziemann", "1-979-374-1329 x7228" },
                    { 94, 18, null, null, "Abbigail_Stracke5@hotmail.com", null, null, "Lupe Beer", "1-539-465-0227" },
                    { 95, 16, null, null, "Blaze_Bartoletti@gmail.com", null, null, "Erwin Kerluke", "(532) 454-2412 x9871" },
                    { 96, 3, null, null, "Laron11@yahoo.com", null, null, "Lou Block", "212-841-1268" },
                    { 97, 18, null, null, "Haskell_Beier@yahoo.com", null, null, "Raphaelle Dibbert", "783-491-0848 x065" },
                    { 98, 25, null, null, "Meda_Rosenbaum17@hotmail.com", null, null, "Nola Fritsch", "796.614.1800 x883" },
                    { 99, 8, null, null, "Bertram_Heathcote@hotmail.com", null, null, "Savanna Brown", "695-278-2009 x41542" },
                    { 100, 7, null, null, "Shania78@gmail.com", null, null, "Adah Crooks", "(247) 839-0816 x204" }
                });

            migrationBuilder.InsertData(
                table: "Leads",
                columns: new[] { "Id", "AccountId", "CreatedAt", "CreatedBy", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "ModifiedAt", "ModifiedBy", "Source", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 8, null, null, "Sequi amet voluptatem nisi rerum quod beatae aut autem dolores nam rerum sint minima minima incidunt aliquid aperiam excepturi accusamus ad repudiandae non illum assumenda repudiandae.", null, null, null, 492788.0, null, null, 1, 0, "Et similique in ea deserunt provident." },
                    { 2, 24, null, null, "Corrupti aut et aut aut consequatur voluptatem pariatur molestias ut aut sequi est ex aperiam eum quis fugiat sed a tempore incidunt atque dicta excepturi cupiditate odit eaque corrupti repellendus.", null, null, new DateTime(2022, 11, 4, 19, 14, 44, 946, DateTimeKind.Local).AddTicks(402), 147855.0, null, null, 3, 2, "Neque id laborum." },
                    { 3, 17, null, null, "Saepe enim et animi sit ad sint animi itaque id aspernatur quo minus quam qui sunt omnis consequatur ipsum dolorum incidunt aspernatur omnis consequatur adipisci et eum aut enim.", null, null, null, 66573.0, null, null, 4, 0, "Ut distinctio placeat qui maxime." },
                    { 4, 6, null, null, "Aut eum magni velit porro sapiente et ea laboriosam reprehenderit tenetur sed harum vel consequuntur cum et esse in id quis exercitationem nisi eligendi laborum beatae eveniet.", null, null, new DateTime(2022, 8, 16, 0, 39, 23, 793, DateTimeKind.Local).AddTicks(2707), 168649.0, null, null, 0, 2, "Eius ut qui." },
                    { 5, 3, null, null, "Rerum tempore porro qui eum maiores tempora vel natus consequatur illo id dolorum error ea reiciendis sit vitae quia voluptatem iure voluptas.", "Eligendi modi vel architecto quia ipsum commodi provident ut tempore.", 3, new DateTime(2023, 1, 3, 11, 48, 7, 45, DateTimeKind.Local).AddTicks(7975), 261654.0, null, null, 1, 3, "Sint odit quod." },
                    { 6, 19, null, null, "Quod nobis voluptas voluptatibus est blanditiis laudantium dolor temporibus assumenda autem suscipit aliquam voluptas id adipisci.", null, null, null, 356002.0, null, null, 3, 0, "Debitis exercitationem esse." },
                    { 7, 11, null, null, "Blanditiis quia provident nobis deleniti praesentium quis sint aut maxime aut repellat qui consequatur ut aliquam perferendis rerum qui sunt vitae tempora vero molestias odit.", null, null, null, 463431.0, null, null, 0, 0, "Rerum repellat ipsa." },
                    { 8, 9, null, null, "Culpa aspernatur et asperiores voluptas dolores a tempore corrupti quidem libero quasi odit error maiores vero debitis eligendi optio enim sed unde possimus est odit saepe enim quaerat praesentium.", null, null, null, 458607.0, null, null, 0, 1, "Officiis et qui debitis." },
                    { 9, 22, null, null, "Rerum vel dolorem omnis quos non ratione recusandae praesentium magnam deleniti laboriosam ipsam aspernatur culpa illum occaecati corrupti quidem id aperiam commodi iusto dolorum debitis.", null, null, null, 388176.0, null, null, 0, 1, "Qui et enim aut quam temporibus." },
                    { 10, 24, null, null, "Rerum dolorum ipsa nemo dolore iure asperiores magnam culpa sed asperiores beatae enim aliquid omnis cumque excepturi quam rem molestiae itaque nesciunt quia voluptatem quaerat alias saepe repellendus.", null, null, new DateTime(2022, 8, 21, 2, 12, 31, 877, DateTimeKind.Local).AddTicks(7688), 262266.0, null, null, 2, 2, "Excepturi autem debitis." },
                    { 11, 12, null, null, "Corporis voluptatibus eveniet voluptas eius velit quo deleniti eligendi architecto mollitia aut fugiat quisquam non ex consequatur quis doloribus rerum itaque distinctio qui deserunt magnam odio aut quos quia iste.", null, null, null, 140503.0, null, null, 2, 1, "Dolores suscipit et ex voluptas et." },
                    { 12, 1, null, null, "Ut ipsam vel est porro necessitatibus ex cum odio quas enim iusto dolores.", null, null, null, 121426.0, null, null, 4, 1, "Possimus libero ut et enim." },
                    { 13, 7, null, null, "Aut magni aut atque eos pariatur qui dicta autem ab expedita et rem optio quia molestiae qui iusto vitae voluptatem atque error illo inventore quas autem.", null, null, new DateTime(2023, 6, 19, 1, 40, 21, 672, DateTimeKind.Local).AddTicks(8527), 357714.0, null, null, 0, 2, "Quo est consequuntur." },
                    { 14, 8, null, null, "Odio et autem quam voluptate eligendi reiciendis in iste harum libero consequatur aspernatur sed eum consequatur.", null, null, null, 326010.0, null, null, 4, 1, "Repudiandae asperiores expedita." },
                    { 15, 21, null, null, "Totam id architecto et voluptates vitae suscipit totam consequatur unde nostrum omnis culpa eaque ea veritatis id quidem.", null, null, null, 121902.0, null, null, 1, 1, "Rerum ullam aut." },
                    { 16, 16, null, null, "Et fugiat ex suscipit sint in ab voluptatem voluptas porro.", null, null, null, 402208.0, null, null, 0, 0, "Sequi ut quia rerum recusandae nobis." },
                    { 17, 10, null, null, "Ratione sed distinctio inventore odio laborum deserunt omnis et consequatur aut nisi voluptatem error quasi maiores.", null, null, new DateTime(2022, 11, 22, 22, 46, 13, 80, DateTimeKind.Local).AddTicks(9596), 191732.0, null, null, 2, 2, "Repellendus dolores qui." },
                    { 18, 22, null, null, "Ut nihil quod officia maiores perspiciatis dolorum odio quae ipsa provident aut qui id voluptatem qui aspernatur odit delectus sunt.", null, null, null, 103236.0, null, null, 1, 0, "Quisquam tempora libero." },
                    { 19, 2, null, null, "Veritatis quibusdam deserunt quisquam qui ut dolore debitis neque tempore quia molestiae fugit quia rem veniam adipisci nesciunt doloremque est unde.", "Quia dolorem tempora voluptates aut possimus in et dolores quaerat recusandae adipisci perspiciatis tempore ut blanditiis sit eum perspiciatis aut.", 3, new DateTime(2022, 11, 8, 2, 13, 4, 327, DateTimeKind.Local).AddTicks(7670), 64330.0, null, null, 1, 3, "Quibusdam sint quas vero culpa odit." },
                    { 20, 20, null, null, "Id dolor libero possimus quis velit sed consequuntur aut ab mollitia cumque doloribus vel iste pariatur deserunt soluta voluptatibus aut voluptatem.", null, null, new DateTime(2023, 5, 23, 14, 36, 18, 190, DateTimeKind.Local).AddTicks(4142), 348365.0, null, null, 2, 2, "Cumque sed distinctio unde voluptates vero." },
                    { 21, 15, null, null, "Ab est et non est ut voluptas dolor iusto facere similique sunt magni delectus repudiandae qui numquam voluptas adipisci velit dolorem quasi enim quisquam rerum labore vel saepe aut.", null, null, null, 80675.0, null, null, 0, 0, "Fuga et facere voluptas." },
                    { 22, 17, null, null, "Assumenda quia nam quos nisi illum culpa aut minus nulla nesciunt labore et aut voluptas consequuntur omnis numquam sed autem eos.", "Vero perferendis nihil neque aspernatur id cupiditate non nobis doloremque animi rerum alias quam corporis vero repellendus ut iusto quae.", 3, new DateTime(2023, 8, 2, 4, 46, 53, 760, DateTimeKind.Local).AddTicks(7044), 308687.0, null, null, 1, 3, "Aut aut amet nisi." },
                    { 23, 3, null, null, "Fuga voluptatem repellendus dolores aut sint odit ea hic sit expedita praesentium sit harum voluptatem omnis laudantium laboriosam pariatur voluptas nostrum quam voluptates corporis enim quaerat ut earum animi.", null, null, new DateTime(2023, 5, 19, 22, 46, 27, 700, DateTimeKind.Local).AddTicks(6343), 243148.0, null, null, 3, 2, "Officia officia consequatur saepe." },
                    { 24, 25, null, null, "Quisquam doloremque provident qui quis et soluta laudantium quae sint optio sed inventore culpa qui suscipit omnis cumque harum vel rerum illo eaque sequi soluta.", null, null, null, 102491.0, null, null, 0, 1, "Dicta quo dolores est praesentium architecto." },
                    { 25, 1, null, null, "Ipsa pariatur facilis qui consequatur qui qui aut quos non molestias.", null, null, new DateTime(2023, 6, 11, 21, 24, 39, 38, DateTimeKind.Local).AddTicks(6269), 469755.0, null, null, 3, 2, "Vel voluptatem et." },
                    { 26, 4, null, null, "Voluptatem ut saepe laboriosam nihil velit atque nulla quia nostrum beatae saepe voluptas laboriosam consectetur vero eius iusto quisquam voluptate laborum beatae eius vel nostrum.", null, null, null, 482890.0, null, null, 1, 1, "Nisi a ullam omnis doloribus veniam." },
                    { 27, 8, null, null, "Quam a tempora ullam beatae dignissimos aliquam mollitia quia consectetur modi id est aut quia nihil beatae praesentium aperiam.", "Sit sunt assumenda consectetur ad unde excepturi neque repellendus facilis nulla nobis quidem occaecati dolor officiis similique architecto dignissimos enim omnis aut veritatis id.", 1, new DateTime(2023, 7, 15, 3, 24, 56, 696, DateTimeKind.Local).AddTicks(222), 95124.0, null, null, 2, 3, "Eum perferendis et eos tempora adipisci." },
                    { 28, 16, null, null, "Dolor illo unde dolor qui dolores voluptatem corrupti iure dignissimos aspernatur et cum dolor a laboriosam cum rem consequatur voluptatem provident laborum voluptas aut fugit.", "Enim eum pariatur dolores sit commodi labore cum tempore nemo placeat sint repellendus saepe.", 3, new DateTime(2022, 12, 3, 19, 14, 8, 72, DateTimeKind.Local).AddTicks(666), 184445.0, null, null, 4, 3, "Dolores aliquam quam." },
                    { 29, 9, null, null, "Dolorum quo dolorem ut qui incidunt est ullam voluptatum odit illo ut consequatur ipsum quia aut.", null, null, new DateTime(2023, 8, 6, 5, 17, 35, 911, DateTimeKind.Local).AddTicks(624), 176137.0, null, null, 1, 2, "Impedit unde doloribus corrupti nobis." },
                    { 30, 21, null, null, "Velit autem consequuntur eius in repellat quia quia architecto magni aut aliquam quia voluptatum sed nemo doloribus quia laboriosam accusamus eaque illum impedit velit est voluptatibus.", null, null, null, 283903.0, null, null, 1, 1, "Deserunt omnis quasi ea." }
                });

            migrationBuilder.InsertData(
                table: "Deals",
                columns: new[] { "Id", "ActualRevenue", "CreatedAt", "CreatedBy", "Description", "LeadId", "ModifiedAt", "ModifiedBy", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 441327.0, null, null, "Mollitia omnis minima ut totam laborum explicabo qui tempora quisquam provident repudiandae voluptas molestiae.", 1, null, null, 0, "Pariatur velit est architecto explicabo." },
                    { 2, 337305.0, null, null, "Voluptates magnam molestias voluptate quia possimus est omnis quibusdam velit commodi facere maxime minima ducimus.", 2, null, null, 2, "Ea est officiis quis." },
                    { 3, 242423.0, null, null, "Nulla natus minus non dolorem facere non quae nisi magnam molestiae laboriosam accusantium nisi autem omnis asperiores necessitatibus provident tenetur soluta rem quo itaque at perferendis.", 3, null, null, 1, "Corporis laudantium quia in officiis." },
                    { 4, 229295.0, null, null, "Adipisci ullam mollitia non ea saepe et commodi explicabo ullam qui ipsa doloribus eum nihil non qui quae.", 4, null, null, 1, "Veritatis corrupti alias architecto nulla eveniet." },
                    { 5, 56494.0, null, null, "Ea eum et occaecati quis sed fugiat illo ut quas quam voluptatem officia totam dolores quaerat repellendus praesentium non voluptatem id nostrum molestias et aut.", 5, null, null, 0, "Vero omnis voluptas nemo." },
                    { 6, 416766.0, null, null, "Magni cum omnis officiis quia hic fugiat aspernatur voluptatem et dolore tempora est nulla hic odio animi et odio quidem optio rerum animi commodi neque.", 6, null, null, 0, "Odit nulla a aut atque." },
                    { 7, 469000.0, null, null, "Facilis rem saepe debitis quo qui sint et rerum quisquam eaque laborum deserunt officia esse alias ipsa ut natus culpa quasi ea.", 7, null, null, 0, "Nisi facilis amet enim recusandae natus." },
                    { 8, 491551.0, null, null, "Nostrum provident impedit architecto incidunt quasi tempore non ut nisi architecto totam ullam consequatur sit.", 8, null, null, 0, "Reiciendis ut vitae esse." },
                    { 9, 302204.0, null, null, "Ratione magni natus distinctio est aut ipsum magnam similique eveniet similique quaerat voluptatem eveniet nulla dolorum.", 9, null, null, 2, "Cupiditate est quos repellat corporis." },
                    { 10, 461015.0, null, null, "Aut in suscipit dignissimos qui minus sit iure quaerat sunt aperiam id consequatur maxime odio eius nemo sapiente facilis aut facilis.", 10, null, null, 1, "Deleniti exercitationem recusandae dignissimos ipsum." },
                    { 11, 226555.0, null, null, "Expedita velit minus eius voluptas consectetur beatae id ut sunt ut exercitationem beatae magnam neque rerum.", 11, null, null, 2, "Quidem consequuntur cupiditate quia temporibus quis." },
                    { 12, 79537.0, null, null, "Sequi nihil ut sunt sit beatae odit est eos architecto sunt consequatur numquam corporis asperiores.", 12, null, null, 2, "Quod facilis quo nihil mollitia." },
                    { 13, 271036.0, null, null, "Et pariatur officiis odio ut rerum odio consequuntur accusantium necessitatibus ratione animi qui aut natus.", 13, null, null, 2, "Labore laborum non magnam vero reprehenderit." },
                    { 14, 318128.0, null, null, "Ipsum explicabo et omnis incidunt quos commodi alias architecto officiis pariatur totam suscipit exercitationem dolorem quae praesentium odio nostrum eum molestias quae ea qui in alias qui incidunt.", 14, null, null, 0, "Qui voluptatibus autem." },
                    { 15, 77838.0, null, null, "Omnis velit eligendi labore aliquam harum labore id recusandae inventore sed quaerat qui repellendus sit qui ad numquam dicta aut eum dolore fuga pariatur nihil ut vero numquam.", 15, null, null, 0, "Vel dolor aliquam." },
                    { 16, 82131.0, null, null, "Aliquid ea deserunt consequatur dolor perspiciatis voluptas temporibus praesentium vel quia magni architecto cum optio magni officiis illum enim dolorem nam doloremque qui hic voluptatem sed iusto.", 16, null, null, 0, "Esse deserunt natus est asperiores." },
                    { 17, 396021.0, null, null, "Et vel maiores reprehenderit labore architecto natus consequuntur enim natus corrupti ad non ipsa nemo et quas at modi recusandae veniam et totam ut.", 17, null, null, 2, "Beatae quibusdam consectetur beatae repudiandae esse." },
                    { 18, 370209.0, null, null, "Laboriosam hic totam suscipit est praesentium veritatis fugiat et nihil.", 18, null, null, 2, "Aliquam quia consequatur nisi magni dolores." },
                    { 19, 108885.0, null, null, "Exercitationem voluptatum nemo nihil eos quod reprehenderit accusamus ea laudantium ullam dignissimos aut veniam sequi sunt neque vero porro.", 19, null, null, 2, "Deserunt omnis aut ratione quia ipsam." },
                    { 20, 110584.0, null, null, "Praesentium quos nostrum ut et saepe eligendi ducimus in voluptas et quis minus sit doloremque quia reiciendis nihil iure id ipsa ad rerum omnis.", 20, null, null, 1, "Optio quibusdam sit dolorem veritatis." },
                    { 21, 370186.0, null, null, "Dolorem similique amet officia totam debitis debitis libero cumque molestias qui atque quas tempora laboriosam vel delectus sit odio facilis modi.", 21, null, null, 0, "Sed vel ea." },
                    { 22, 82064.0, null, null, "Sit sequi aspernatur dignissimos pariatur delectus est voluptatem quod natus ut quidem.", 22, null, null, 0, "Temporibus aut quo labore molestiae." },
                    { 23, 127651.0, null, null, "Molestiae rerum aperiam vel id repellat quia suscipit nulla aut expedita harum voluptas ipsam.", 23, null, null, 0, "Error quo id est aliquid." },
                    { 24, 188330.0, null, null, "Nihil dicta dolor accusamus repellat eum ipsa error omnis reprehenderit ducimus expedita ea perspiciatis quia qui omnis quia qui eos fugiat ab earum nihil rerum repudiandae.", 24, null, null, 0, "Voluptas aut cumque." },
                    { 25, 230565.0, null, null, "Maxime enim cupiditate vel mollitia omnis est molestias beatae aut a dolor natus repellat in qui dolor itaque nobis non labore quia.", 25, null, null, 2, "Quo vel dicta." },
                    { 26, 56503.0, null, null, "Sed dolor assumenda quia ut placeat similique accusamus exercitationem exercitationem repellendus corporis repellat officiis at.", 26, null, null, 2, "Eum mollitia qui numquam sunt qui." },
                    { 27, 313458.0, null, null, "Consectetur eaque id et sit iusto perferendis rem voluptatum nemo eius et amet eum cumque iure eligendi dicta odio quae.", 27, null, null, 2, "Aut dicta nam adipisci placeat incidunt." },
                    { 28, 274026.0, null, null, "Dolor et officiis et consequatur eos tempora natus iste non labore sunt corrupti dolorum et facere nesciunt.", 28, null, null, 2, "Harum ipsam ea consequatur." },
                    { 29, 96525.0, null, null, "Odio et natus ut qui repudiandae illum iste excepturi esse nobis tempore sed porro dolorem.", 29, null, null, 2, "Et ut exercitationem et." },
                    { 30, 84706.0, null, null, "Dolores dolores dignissimos et provident perspiciatis delectus vel rerum corrupti optio enim.", 30, null, null, 1, "Deleniti quas id aut nihil." }
                });

            migrationBuilder.InsertData(
                table: "DealProducts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DealId", "ModifiedAt", "ModifiedBy", "PricePerUnit", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, null, null, 27, null, null, 66.0, 5, 84 },
                    { 2, null, null, 28, null, null, 89.0, 10, 75 },
                    { 3, null, null, 17, null, null, 26.0, 4, 63 },
                    { 4, null, null, 8, null, null, 45.0, 5, 81 },
                    { 5, null, null, 26, null, null, 75.0, 1, 17 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_Phone_Email",
                table: "Accounts",
                columns: new[] { "Phone", "Email" },
                unique: true,
                filter: "[Phone] IS NOT NULL AND [Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AccountId",
                table: "Contacts",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_Phone_Email",
                table: "Contacts",
                columns: new[] { "Phone", "Email" },
                unique: true,
                filter: "[Phone] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DealProducts_DealId",
                table: "DealProducts",
                column: "DealId");

            migrationBuilder.CreateIndex(
                name: "IX_DealProducts_ProductId",
                table: "DealProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_LeadId",
                table: "Deals",
                column: "LeadId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Leads_AccountId",
                table: "Leads",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCode",
                table: "Products",
                column: "ProductCode",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "DealProducts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Deals");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Leads");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
