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
                    { 1, "999 Rosie Trafficway, Bufordfurt, Eritrea", null, null, "Colleen_Johnston36@hotmail.com", null, null, "Schaefer Group", "798.935.8211 x769", 44793.0 },
                    { 2, "50314 Fisher View, Abbigailborough, Latvia", null, null, "Robbie71@hotmail.com", null, null, "Hartmann, Haag and Haag", "508-311-3485 x73251", 7671.0 },
                    { 3, "0450 Ryan Crest, Beierside, Slovakia (Slovak Republic)", null, null, "Velva.Balistreri@hotmail.com", null, null, "Blanda, Satterfield and Hartmann", "404-216-2756 x950", 33026.0 },
                    { 4, "6055 Schoen Canyon, East Llewellyn, Aruba", null, null, "Ashleigh.Oberbrunner@yahoo.com", null, null, "Emard, Hansen and Medhurst", "552-831-4099 x616", 11752.0 },
                    { 5, "0621 Camylle Stravenue, Jarvisfort, Cambodia", null, null, "Carlo.Leuschke@yahoo.com", null, null, "Pfeffer - Maggio", "(934) 259-8929", 26586.0 },
                    { 6, "35702 Kutch Gateway, Nakiaside, South Africa", null, null, "Lesly.Hansen@hotmail.com", null, null, "Ferry - Ullrich", "288.550.6956 x2280", 22879.0 },
                    { 7, "53549 Ignatius Loop, West Ryleigh, Argentina", null, null, "Violet94@hotmail.com", null, null, "Bosco, Runte and Padberg", "1-971-280-2416", 4132.0 },
                    { 8, "28005 Schinner Forges, Schmelershire, Austria", null, null, "Dudley_Hahn76@gmail.com", null, null, "Gislason, Wiegand and Barton", "1-430-576-3958 x51869", 7926.0 },
                    { 9, "23154 Efrain Cape, Thomasbury, Germany", null, null, "Katelynn_Carroll@hotmail.com", null, null, "Kutch - Cronin", "(519) 513-2663 x9412", 41151.0 },
                    { 10, "4719 Fanny Drive, Silasland, San Marino", null, null, "Hershel.Frami82@yahoo.com", null, null, "Kessler, Dooley and Mueller", "(580) 488-6435 x12254", 45468.0 },
                    { 11, "8436 Margret Spur, Clementineberg, France", null, null, "Raven_Breitenberg@gmail.com", null, null, "Mann, Bode and Kub", "(489) 706-1702", 43809.0 },
                    { 12, "61367 Homenick Street, East Eugeniabury, Italy", null, null, "Jaclyn7@gmail.com", null, null, "Lebsack LLC", "1-680-205-4527 x22802", 11125.0 },
                    { 13, "4734 Junius Plains, New Clyde, French Southern Territories", null, null, "Zoila_Mohr@hotmail.com", null, null, "Ledner, Dickens and Crona", "(272) 669-9835 x79855", 14565.0 },
                    { 14, "777 Emelia Drive, Alejandraville, Bhutan", null, null, "Dangelo_Cremin@yahoo.com", null, null, "Weimann, Kertzmann and Haley", "621-278-9873 x28411", 521.0 },
                    { 15, "4737 Sauer Crossing, Effertzview, Algeria", null, null, "Johnathan.Skiles87@hotmail.com", null, null, "Conn LLC", "924.631.6299 x279", 32824.0 },
                    { 16, "3457 Wanda Shores, Lake Clovis, Guyana", null, null, "Charlotte_Grady@hotmail.com", null, null, "Hagenes and Sons", "1-504-755-8528 x8399", 39709.0 },
                    { 17, "386 Dicki Gardens, Padbergchester, Kyrgyz Republic", null, null, "Catharine.Bernier17@gmail.com", null, null, "Reynolds - Hintz", "362.604.1646", 40024.0 },
                    { 18, "3607 Leanna Ranch, New Westley, Saint Martin", null, null, "Jamil32@yahoo.com", null, null, "Effertz - Wilderman", "(459) 940-9766", 37712.0 },
                    { 19, "21347 Gottlieb Path, New Jairoview, Austria", null, null, "Zane_Thiel79@gmail.com", null, null, "Harber Inc", "(304) 470-8970 x299", 11093.0 },
                    { 20, "388 Stuart Overpass, Augustside, Anguilla", null, null, "Consuelo.Lehner89@hotmail.com", null, null, "Rutherford Group", "517.746.2205", 39951.0 },
                    { 21, "29009 Walter Greens, East Mathias, Austria", null, null, "Wilber.Miller@yahoo.com", null, null, "Homenick - Maggio", "440-743-5735", 47051.0 },
                    { 22, "3784 Daniel Views, Alexandreton, India", null, null, "Augustus11@gmail.com", null, null, "Kozey - Kuhn", "1-851-434-2227", 5907.0 },
                    { 23, "67810 George Run, Elbertberg, Taiwan", null, null, "Aubree70@yahoo.com", null, null, "Lehner - Gleason", "936-933-9591", 959.0 },
                    { 24, "7765 Dejon Freeway, Lake Busterton, Serbia", null, null, "Kyle_Greenholt31@yahoo.com", null, null, "Hintz, Smitham and Kilback", "700.713.1150 x7391", 4926.0 },
                    { 25, "91549 Otho Villages, Keithhaven, Guam", null, null, "Aubree_Gislason@yahoo.com", null, null, "O'Connell Inc", "837-316-9879", 41490.0 }
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
                    { 1, 0, "6fb182e7-4476-4fcd-bcc0-eedccca3102a", "superadmin@gmail.com", true, false, null, "superadmin", "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAELXOFhq+D7rOritmSp6MXJxAWKXYopYqOOTOFhvS3BE/wqAi8KhGpmPgRPI7RhO2IQ==", null, false, null, null, "e2ae4805-41ce-4175-bf6f-cde2ae33fb0e", false, "superadmin@gmail.com" },
                    { 2, 0, "50fa56bb-475b-466a-bf3e-e06d707d4da2", "admin@gmail.com", true, false, null, "admin", "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEGThK3UV6jW8IfEcZdBQZacZ1j4ige8dcwWYWNBn7AUO7kaoAdfGy+cBeYlftFSvgA==", null, false, null, null, "cfa26e88-cec1-4ce9-b48f-db66ff104328", false, "admin@gmail.com" },
                    { 3, 0, "fde6c95d-3be1-446a-a03c-fd692ad32330", "Orin32@hotmail.com", false, false, null, "Moises Schinner", null, null, null, null, false, null, null, null, false, "Orin32@hotmail.com" },
                    { 4, 0, "4e6e1978-8896-49e7-8875-1a10a7d73f6e", "Marcelino24@hotmail.com", false, false, null, "Tevin Ernser", null, null, null, null, false, null, null, null, false, "Marcelino24@hotmail.com" },
                    { 5, 0, "aed0d91f-2002-4385-b793-9fc96ab89467", "Jimmie72@hotmail.com", false, false, null, "Lucy Lebsack", null, null, null, null, false, null, null, null, false, "Jimmie72@hotmail.com" },
                    { 6, 0, "78c7ecf1-3cb1-4d27-8037-46c608f274e2", "Dorothy46@hotmail.com", false, false, null, "Jarod Hessel", null, null, null, null, false, null, null, null, false, "Dorothy46@hotmail.com" },
                    { 7, 0, "0e9f394a-641a-42f1-b386-cee7f5c20317", "Eddie.Weimann29@gmail.com", false, false, null, "Tom Quitzon", null, null, null, null, false, null, null, null, false, "Eddie.Weimann29@gmail.com" },
                    { 8, 0, "878ffbcc-953e-4bdc-b053-d1371acb486f", "Tina_Jerde85@yahoo.com", false, false, null, "Eulalia Graham", null, null, null, null, false, null, null, null, false, "Tina_Jerde85@yahoo.com" },
                    { 9, 0, "03b46eb3-63dd-41b4-aa11-e79c307e196e", "Desiree.Leffler@hotmail.com", false, false, null, "Nella Metz", null, null, null, null, false, null, null, null, false, "Desiree.Leffler@hotmail.com" },
                    { 10, 0, "f323ef4f-c2c7-4d2c-bd0a-27bcda52885f", "Jovani88@yahoo.com", false, false, null, "Sonia Mante", null, null, null, null, false, null, null, null, false, "Jovani88@yahoo.com" },
                    { 11, 0, "fc681565-0ccc-437b-a336-53b0453f7d50", "Nolan.Sauer@yahoo.com", false, false, null, "Maria Schmitt", null, null, null, null, false, null, null, null, false, "Nolan.Sauer@yahoo.com" },
                    { 12, 0, "3dbd514d-f522-4ed2-b0d4-06aeacc14e19", "Mikayla.Prohaska34@yahoo.com", false, false, null, "Waylon Wolff", null, null, null, null, false, null, null, null, false, "Mikayla.Prohaska34@yahoo.com" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsAvailable", "ModifiedAt", "ModifiedBy", "Name", "Price", "ProductCode", "Type" },
                values: new object[,]
                {
                    { 1, null, null, true, null, null, "Handcrafted Fresh Pants", 849.0, "PRO-22145413", 0 },
                    { 2, null, null, true, null, null, "Ergonomic Cotton Shirt", 584.0, "PRO-47129573", 0 },
                    { 3, null, null, true, null, null, "Fantastic Rubber Sausages", 785.0, "PRO-06679163", 0 },
                    { 4, null, null, true, null, null, "Rustic Steel Table", 580.0, "PRO-07306273", 0 },
                    { 5, null, null, true, null, null, "Rustic Soft Salad", 136.0, "PRO-93005906", 0 },
                    { 6, null, null, true, null, null, "Ergonomic Plastic Keyboard", 279.0, "PRO-77681973", 0 },
                    { 7, null, null, true, null, null, "Licensed Metal Gloves", 570.0, "PRO-40503554", 0 },
                    { 8, null, null, true, null, null, "Handmade Frozen Sausages", 791.0, "PRO-10825501", 1 },
                    { 9, null, null, true, null, null, "Generic Granite Tuna", 141.0, "PRO-38924248", 1 },
                    { 10, null, null, true, null, null, "Intelligent Plastic Shirt", 830.0, "PRO-35264033", 1 }
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
                    { 37, "permission", "Permission.Lead.Delete", 1 },
                    { 38, "permission", "Permission.Lead.Delete", 2 },
                    { 39, "permission", "Permission.Deal.View", 1 },
                    { 40, "permission", "Permission.Deal.View", 3 },
                    { 41, "permission", "Permission.Deal.View", 2 },
                    { 42, "permission", "Permission.Deal.Create", 1 },
                    { 43, "permission", "Permission.Deal.Create", 2 },
                    { 44, "permission", "Permission.Deal.Edit", 1 },
                    { 45, "permission", "Permission.Deal.Edit", 2 },
                    { 46, "permission", "Permission.Deal.Delete", 1 },
                    { 47, "permission", "Permission.Deal.Delete", 2 }
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
                    { 1, 18, null, null, "Jodie.Lynch@hotmail.com", null, null, "Marianne Reynolds", "539-652-9146 x9687" },
                    { 2, 15, null, null, "Iliana.Lakin@gmail.com", null, null, "Fritz Witting", "343.302.4520" },
                    { 3, 22, null, null, "Stephany22@gmail.com", null, null, "Emerson Runolfsdottir", "883.353.6796 x76308" },
                    { 4, 2, null, null, "Garret.Boyer@yahoo.com", null, null, "Lelah Pagac", "750.427.8406" },
                    { 5, 14, null, null, "Mariam58@hotmail.com", null, null, "Lavon Schuppe", "1-312-622-7308" },
                    { 6, 4, null, null, "Maribel27@hotmail.com", null, null, "Karen Rowe", "(947) 725-7539 x134" },
                    { 7, 17, null, null, "Damien44@yahoo.com", null, null, "Dorothea Kertzmann", "1-952-606-7733 x9931" },
                    { 8, 8, null, null, "Pedro_Cummerata62@hotmail.com", null, null, "Myah Marquardt", "(509) 333-4859 x372" },
                    { 9, 2, null, null, "Kenyon14@gmail.com", null, null, "Felton Reynolds", "554-608-6755" },
                    { 10, 17, null, null, "Alek.Prosacco33@gmail.com", null, null, "Maximilian Goyette", "(261) 329-2834 x09237" },
                    { 11, 19, null, null, "Rex.Leffler@yahoo.com", null, null, "Kayley Koch", "(418) 317-9314" },
                    { 12, 6, null, null, "Paula.Anderson90@yahoo.com", null, null, "Mariane Cartwright", "(801) 585-9482 x17938" },
                    { 13, 16, null, null, "Annetta.Nikolaus69@gmail.com", null, null, "Bert Kihn", "778.278.8927" },
                    { 14, 23, null, null, "Dominic92@hotmail.com", null, null, "Lucinda Wilkinson", "354.220.6282" },
                    { 15, 21, null, null, "Brian.Denesik31@yahoo.com", null, null, "Raymundo Schneider", "(917) 697-0952" },
                    { 16, 7, null, null, "Augustus44@yahoo.com", null, null, "Toby Bednar", "721-726-1765 x6480" },
                    { 17, 6, null, null, "Boyd10@gmail.com", null, null, "Kathleen Hessel", "(967) 837-8234" },
                    { 18, 10, null, null, "Jay.Veum@hotmail.com", null, null, "Zechariah Jones", "526.514.4313" },
                    { 19, 23, null, null, "Krystina.Goldner19@yahoo.com", null, null, "Melyssa Pagac", "573-996-4993 x6681" },
                    { 20, 12, null, null, "Pauline.Jacobson86@yahoo.com", null, null, "Mikel Tremblay", "218-710-7039 x146" },
                    { 21, 12, null, null, "Thelma.Dickens@hotmail.com", null, null, "Marlee Pfeffer", "439-242-3776 x40354" },
                    { 22, 4, null, null, "Madyson_Kuvalis@gmail.com", null, null, "Myriam Gutmann", "(758) 811-5452 x76848" },
                    { 23, 8, null, null, "Perry21@yahoo.com", null, null, "Idella Medhurst", "262.919.4203" },
                    { 24, 3, null, null, "Rafaela.Schmitt@gmail.com", null, null, "Mireille White", "993-894-0981 x207" },
                    { 25, 5, null, null, "Cordia_Murray79@yahoo.com", null, null, "Roel Hamill", "(504) 733-7111 x64718" },
                    { 26, 2, null, null, "Presley_Barton@yahoo.com", null, null, "Imelda Emmerich", "1-990-825-7160 x5907" },
                    { 27, 12, null, null, "Joanny.King62@hotmail.com", null, null, "Abbigail Altenwerth", "251.429.9970" },
                    { 28, 1, null, null, "Ariel40@gmail.com", null, null, "Hollis Denesik", "543-827-7412 x3417" },
                    { 29, 19, null, null, "Andreane1@yahoo.com", null, null, "Cassandra McKenzie", "366-201-1423" },
                    { 30, 14, null, null, "Enrique.OKon2@hotmail.com", null, null, "Ruthie Grimes", "1-894-716-2913 x37980" },
                    { 31, 21, null, null, "Judson33@yahoo.com", null, null, "Carey Wuckert", "(241) 713-2176 x794" },
                    { 32, 24, null, null, "Jeromy.Mraz@gmail.com", null, null, "Richie Schumm", "(364) 324-5836 x8947" },
                    { 33, 10, null, null, "Urban.Halvorson92@hotmail.com", null, null, "Addie Morissette", "1-734-444-3983 x539" },
                    { 34, 25, null, null, "Toy_Kling13@hotmail.com", null, null, "Juvenal Von", "269-370-3885" },
                    { 35, 16, null, null, "Erwin43@gmail.com", null, null, "Ray Johns", "700.617.1438 x85141" },
                    { 36, 8, null, null, "Ezra_Welch58@hotmail.com", null, null, "Ursula Kutch", "1-715-620-1945 x7192" },
                    { 37, 23, null, null, "Mara50@gmail.com", null, null, "Mauricio Dietrich", "(432) 297-1320 x9670" },
                    { 38, 25, null, null, "Arno_Considine@yahoo.com", null, null, "Celestine Ortiz", "711-486-1127 x203" },
                    { 39, 7, null, null, "Kavon36@gmail.com", null, null, "Odessa Reichel", "(416) 328-6008 x29817" },
                    { 40, 10, null, null, "Tanner.Collins52@hotmail.com", null, null, "Alex Green", "738-543-7207 x74097" },
                    { 41, 20, null, null, "Ernie_Reichel1@yahoo.com", null, null, "Calista Bailey", "276.705.3433" },
                    { 42, 21, null, null, "Eleonore_Crona35@yahoo.com", null, null, "Dina Jerde", "264-210-2139" },
                    { 43, 3, null, null, "Wade_Ruecker@hotmail.com", null, null, "Ethan Wolf", "446.707.9852 x778" },
                    { 44, 8, null, null, "Easter5@gmail.com", null, null, "Jillian Raynor", "792-625-2379 x91490" },
                    { 45, 14, null, null, "Isabel.King@yahoo.com", null, null, "Marcelle Buckridge", "921.396.6879" },
                    { 46, 11, null, null, "Viva_Goyette@yahoo.com", null, null, "Bessie Lebsack", "641-274-4534 x68100" },
                    { 47, 22, null, null, "Urban45@gmail.com", null, null, "Dee Crooks", "(642) 603-5695 x52469" },
                    { 48, 15, null, null, "Lora53@yahoo.com", null, null, "Delphine Lockman", "720.549.4071 x22889" },
                    { 49, 2, null, null, "Missouri.Simonis@yahoo.com", null, null, "Nina Erdman", "877-926-6148 x196" },
                    { 50, 5, null, null, "Brandon25@gmail.com", null, null, "Garth Lindgren", "(700) 294-2589 x24627" },
                    { 51, 16, null, null, "Clemens40@yahoo.com", null, null, "Thea Jacobson", "804.742.2369" },
                    { 52, 19, null, null, "Kali_Stark@yahoo.com", null, null, "Zora Ortiz", "673-389-7721 x736" },
                    { 53, 5, null, null, "Sheldon_Hessel51@gmail.com", null, null, "Buster Howe", "(723) 978-8953" },
                    { 54, 23, null, null, "Caden_Ortiz22@hotmail.com", null, null, "Mireille Jaskolski", "732-879-0445 x12458" },
                    { 55, 6, null, null, "Emelie.Goldner39@hotmail.com", null, null, "Torrance Hoeger", "423.552.1070 x8774" },
                    { 56, 13, null, null, "Elvis.Turcotte57@yahoo.com", null, null, "Kelli Bradtke", "539.827.1213 x500" },
                    { 57, 19, null, null, "Sidney34@hotmail.com", null, null, "Mekhi Cremin", "702-621-8521" },
                    { 58, 5, null, null, "Clovis7@hotmail.com", null, null, "Muriel Kling", "254-582-4765 x12945" },
                    { 59, 13, null, null, "Estella.Heidenreich@yahoo.com", null, null, "Ally Dare", "397-715-0269 x433" },
                    { 60, 5, null, null, "Jedediah_Leuschke60@yahoo.com", null, null, "Jacinto Robel", "(520) 655-2598 x4948" },
                    { 61, 2, null, null, "Tremaine71@yahoo.com", null, null, "Wanda Runolfsdottir", "632.736.0375" },
                    { 62, 6, null, null, "Art27@gmail.com", null, null, "Vallie Harris", "444-864-7300 x50283" },
                    { 63, 9, null, null, "Geovanni_Lemke17@yahoo.com", null, null, "Claudie Buckridge", "747.632.6557 x8265" },
                    { 64, 19, null, null, "Josiane_Berge76@hotmail.com", null, null, "Jesse Green", "205.295.1942" },
                    { 65, 13, null, null, "Leo.Bosco1@gmail.com", null, null, "Angelita Hettinger", "960.624.9654" },
                    { 66, 3, null, null, "Eliseo_Hirthe16@hotmail.com", null, null, "Mandy Heidenreich", "1-574-263-1453 x0007" },
                    { 67, 21, null, null, "Mathew_Crona87@hotmail.com", null, null, "Elyse Collins", "689-879-4141 x16441" },
                    { 68, 3, null, null, "Bell_Hartmann@yahoo.com", null, null, "Donna Will", "1-659-628-2657" },
                    { 69, 25, null, null, "Jarrett23@gmail.com", null, null, "Kaylie Stokes", "1-854-488-5397" },
                    { 70, 14, null, null, "Aurelia27@hotmail.com", null, null, "Cassandra Friesen", "(986) 799-0867" },
                    { 71, 20, null, null, "Jovany_Olson20@yahoo.com", null, null, "Chauncey Gibson", "980-595-4843 x76549" },
                    { 72, 16, null, null, "Vivienne_McKenzie@yahoo.com", null, null, "Amy Barrows", "702.660.3474" },
                    { 73, 1, null, null, "Addie_Fay@hotmail.com", null, null, "Adrain Hagenes", "644.550.1156 x419" },
                    { 74, 25, null, null, "Tiffany22@gmail.com", null, null, "Randi Casper", "895-956-7265 x00760" },
                    { 75, 7, null, null, "Isabelle.Skiles68@gmail.com", null, null, "Zackery Jaskolski", "(258) 544-7479 x362" },
                    { 76, 5, null, null, "Eda87@gmail.com", null, null, "Dakota Gaylord", "920.449.7041" },
                    { 77, 22, null, null, "Madelynn_Harber18@hotmail.com", null, null, "Nickolas McGlynn", "966.919.3727" },
                    { 78, 8, null, null, "Dominic.Reilly@hotmail.com", null, null, "Sincere Wisozk", "968.810.0495" },
                    { 79, 17, null, null, "Carolanne.Block39@yahoo.com", null, null, "Yvette Wilderman", "1-244-387-1635" },
                    { 80, 24, null, null, "Ana_Shields4@hotmail.com", null, null, "Alisha Cronin", "(236) 999-1545 x9248" },
                    { 81, 1, null, null, "Dana51@yahoo.com", null, null, "Chadrick Kihn", "990-660-6146" },
                    { 82, 15, null, null, "Florian12@hotmail.com", null, null, "Ressie Aufderhar", "463-674-8676 x432" },
                    { 83, 9, null, null, "Jewell95@hotmail.com", null, null, "Lester Gaylord", "845-325-3167 x290" },
                    { 84, 14, null, null, "Bertha4@yahoo.com", null, null, "Sandy Kuvalis", "316.395.3785 x294" },
                    { 85, 2, null, null, "Robert_Hilll17@yahoo.com", null, null, "Jarred Nikolaus", "311-949-5272 x747" },
                    { 86, 9, null, null, "Heaven.Dare@gmail.com", null, null, "Foster Gutkowski", "775-263-9592" },
                    { 87, 11, null, null, "Lizzie_Gerlach81@gmail.com", null, null, "Amelia Wyman", "1-233-706-6653 x5556" },
                    { 88, 20, null, null, "Andres50@gmail.com", null, null, "Eloy Gulgowski", "835.288.4263 x45023" },
                    { 89, 5, null, null, "Marina.Nolan45@hotmail.com", null, null, "Marcelle Lueilwitz", "1-345-361-7968 x491" },
                    { 90, 17, null, null, "Pablo_Wilkinson31@yahoo.com", null, null, "Jettie Shields", "345-641-9549 x156" },
                    { 91, 12, null, null, "Simone.Jenkins66@hotmail.com", null, null, "Celestine Nitzsche", "596.240.7808" },
                    { 92, 11, null, null, "Isabel20@yahoo.com", null, null, "Jordi Ratke", "1-822-548-1988 x7477" },
                    { 93, 22, null, null, "Jarred_Walker34@hotmail.com", null, null, "Lauretta Rosenbaum", "1-370-566-7138" },
                    { 94, 18, null, null, "Benny58@gmail.com", null, null, "Keshawn Durgan", "611.626.6760 x332" },
                    { 95, 5, null, null, "Landen_Daugherty@yahoo.com", null, null, "Daryl Schultz", "976-288-4081 x9049" },
                    { 96, 8, null, null, "Alexandre81@gmail.com", null, null, "Gwendolyn Hansen", "1-295-541-7340" },
                    { 97, 23, null, null, "Jeff39@hotmail.com", null, null, "Korbin Aufderhar", "200-852-1138 x4175" },
                    { 98, 1, null, null, "Dagmar_Hegmann36@hotmail.com", null, null, "Gillian Gleichner", "1-939-834-7405 x09874" },
                    { 99, 20, null, null, "Marcelino_Stamm@hotmail.com", null, null, "Cletus Kunde", "(345) 350-3199 x151" },
                    { 100, 23, null, null, "Cade_Stiedemann@gmail.com", null, null, "Kylie Roob", "(715) 732-4710 x371" }
                });

            migrationBuilder.InsertData(
                table: "Leads",
                columns: new[] { "Id", "AccountId", "CreatedAt", "CreatedBy", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "ModifiedAt", "ModifiedBy", "Source", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 20, null, null, "Consequatur deleniti eum necessitatibus placeat illum cupiditate error sed magnam dolorum laudantium facilis saepe quis hic et quae id eos.", null, null, null, 465917.0, null, null, 2, 0, "Sed enim a dicta earum voluptatem." },
                    { 2, 16, null, null, "Hic laboriosam pariatur autem repellendus commodi eos delectus sunt quibusdam autem aperiam quibusdam eos quis et necessitatibus sint non eos qui sapiente praesentium enim.", null, null, new DateTime(2022, 8, 29, 0, 0, 16, 93, DateTimeKind.Local).AddTicks(9704), 133153.0, null, null, 1, 2, "Consectetur consequuntur corrupti." },
                    { 3, 23, null, null, "Est ullam explicabo ducimus quis at optio molestias non voluptatum ut possimus alias quasi sunt perferendis aut eum ut qui quia illum est suscipit optio.", null, null, null, 168644.0, null, null, 0, 0, "Consequatur qui quisquam doloremque velit consequatur." },
                    { 4, 9, null, null, "Voluptate et quos laudantium nostrum assumenda omnis quod nulla aperiam qui assumenda est sed perferendis sunt molestias.", null, null, new DateTime(2022, 12, 1, 0, 32, 43, 206, DateTimeKind.Local).AddTicks(2073), 153131.0, null, null, 1, 2, "Sit magnam quia nihil." },
                    { 5, 22, null, null, "Quis dolorum animi distinctio doloremque non ullam quia ut enim sed eveniet ipsa hic nobis et est aspernatur ea non totam aspernatur perspiciatis facere repellendus omnis eum ducimus.", null, null, null, 340905.0, null, null, 3, 0, "Excepturi vero consequuntur." },
                    { 6, 6, null, null, "Ipsum est nihil rerum quibusdam rem nam fugiat et quia deleniti distinctio aspernatur deserunt veritatis et occaecati explicabo est qui officia quo dignissimos.", null, null, null, 11499.0, null, null, 0, 1, "Placeat laborum dolorem eum ut." },
                    { 7, 10, null, null, "Sit iusto dolor et voluptatibus corporis corporis sunt qui et nulla distinctio dicta et rerum et officiis pariatur dolor earum nam.", null, null, null, 426840.0, null, null, 2, 0, "Natus id praesentium sequi assumenda deserunt." },
                    { 8, 19, null, null, "Quae eligendi unde blanditiis qui et placeat velit maxime laudantium quia et sit autem quod quia harum aperiam similique minima aut molestiae eos ipsam molestiae ut non doloribus qui voluptatibus.", null, null, null, 336098.0, null, null, 3, 0, "Aliquam eaque nesciunt quae." },
                    { 9, 3, null, null, "Odio voluptatem doloremque aut deserunt quasi perspiciatis eos aut quidem neque consectetur dolores quo excepturi occaecati et non.", null, null, new DateTime(2023, 3, 18, 15, 47, 24, 567, DateTimeKind.Local).AddTicks(161), 122489.0, null, null, 4, 2, "Voluptatem voluptas sunt aperiam molestiae dolore." },
                    { 10, 9, null, null, "Et qui possimus adipisci aliquid aliquid amet dolor repellat dicta omnis dolor ad ab eos ex aspernatur esse eius ea nemo non iure.", "Est illum labore qui consequatur fugit dolorem tempora eum laborum reiciendis non velit facilis quae ex et quo nihil consequatur modi aut aut.", 3, new DateTime(2023, 8, 6, 4, 12, 29, 921, DateTimeKind.Local).AddTicks(1492), 10903.0, null, null, 0, 3, "Id nihil ipsam sed temporibus dolor." },
                    { 11, 3, null, null, "Error distinctio consectetur ullam ut odit minima consectetur deserunt est et reiciendis aliquid similique omnis reprehenderit quia et soluta.", "Rem excepturi beatae ut vel corporis dolor dignissimos facere beatae commodi id molestias incidunt impedit.", 0, new DateTime(2023, 7, 9, 8, 10, 38, 525, DateTimeKind.Local).AddTicks(6475), 255374.0, null, null, 1, 3, "Odit in et mollitia." },
                    { 12, 14, null, null, "Recusandae aut accusamus ea tempora voluptatem similique sed quo distinctio sint molestiae animi et aut temporibus fugiat suscipit eos.", null, null, new DateTime(2023, 8, 7, 12, 27, 43, 66, DateTimeKind.Local).AddTicks(3179), 117979.0, null, null, 0, 2, "Beatae distinctio sed numquam et." },
                    { 13, 9, null, null, "Fugit natus ut eos vel qui eum odio tenetur et commodi ut amet eos quia itaque incidunt corrupti doloremque possimus laudantium blanditiis natus omnis non sed ut ut veniam optio.", null, null, null, 460924.0, null, null, 4, 0, "Et et in." },
                    { 14, 22, null, null, "Similique natus ex perspiciatis impedit rerum aperiam et nihil et deserunt esse aut accusamus totam voluptatem voluptas eos nesciunt facere sit natus ut.", null, null, null, 308578.0, null, null, 2, 1, "Ullam harum ea." },
                    { 15, 11, null, null, "Voluptatem qui earum dolorem aliquam et voluptas sed eveniet qui molestiae nisi quos iure dolorem ducimus aut fuga sapiente a quaerat odit ut dolorem vero aspernatur atque quidem.", null, null, null, 214365.0, null, null, 0, 0, "Dolorem quis illo." },
                    { 16, 7, null, null, "Itaque sint quidem fugiat tenetur consequatur est iure temporibus beatae earum esse modi.", "Iure in inventore pariatur magnam accusantium voluptatem non totam et ea.", 0, new DateTime(2023, 7, 13, 15, 10, 9, 298, DateTimeKind.Local).AddTicks(1454), 108966.0, null, null, 0, 3, "Adipisci aperiam dicta at a." },
                    { 17, 17, null, null, "Consequatur quo corrupti est omnis quia voluptas sed iusto esse sint libero quaerat minima inventore veritatis repellat quos praesentium porro sint itaque fuga enim in animi debitis.", null, null, null, 35057.0, null, null, 1, 0, "Inventore accusantium deleniti error nihil qui." },
                    { 18, 12, null, null, "Qui unde cum omnis totam et eum ea repudiandae consequuntur sapiente et voluptatum dicta eum.", null, null, null, 84781.0, null, null, 0, 1, "Quae earum deleniti est sequi et." },
                    { 19, 21, null, null, "Sunt sed molestiae velit laborum voluptatem optio minus dolorum et.", null, null, null, 243867.0, null, null, 1, 0, "Autem omnis voluptas esse fuga quibusdam." },
                    { 20, 22, null, null, "Rem nulla laborum suscipit est ipsum commodi est earum possimus cupiditate id facere.", null, null, new DateTime(2022, 8, 30, 15, 8, 46, 922, DateTimeKind.Local).AddTicks(5739), 424928.0, null, null, 4, 2, "Doloremque aut omnis." },
                    { 21, 4, null, null, "Magnam suscipit et quisquam alias ratione esse sit mollitia nesciunt quam eum ut provident.", null, null, null, 26669.0, null, null, 2, 1, "Occaecati magni optio laborum." },
                    { 22, 25, null, null, "Aut assumenda sunt harum quo temporibus doloremque voluptatum animi est voluptate deleniti et natus voluptatum et eaque velit molestiae voluptatum incidunt consequuntur.", null, null, new DateTime(2023, 2, 28, 8, 1, 17, 291, DateTimeKind.Local).AddTicks(6846), 301278.0, null, null, 2, 2, "Amet et ut debitis sit est." },
                    { 23, 3, null, null, "Quia officia iure quia sed ipsam sunt ipsum optio consequatur.", null, null, new DateTime(2023, 2, 26, 0, 52, 27, 56, DateTimeKind.Local).AddTicks(8299), 323809.0, null, null, 0, 2, "Recusandae accusamus architecto perspiciatis." },
                    { 24, 24, null, null, "Aut saepe eligendi cum ipsum non itaque aut eius quasi.", "Dolor quo ipsum laudantium aliquam qui molestias at officiis quos dolores aspernatur voluptate assumenda quis omnis recusandae esse eveniet laborum.", 1, new DateTime(2023, 1, 5, 6, 56, 9, 933, DateTimeKind.Local).AddTicks(4482), 29191.0, null, null, 0, 3, "Numquam unde reiciendis ex." },
                    { 25, 10, null, null, "Et rem id magnam debitis quisquam quod aspernatur eum rem est iusto officia.", null, null, new DateTime(2023, 6, 1, 10, 24, 45, 450, DateTimeKind.Local).AddTicks(9807), 96120.0, null, null, 4, 2, "Et ut est officiis quia soluta." },
                    { 26, 22, null, null, "Eum voluptatem et rerum quaerat provident blanditiis occaecati cumque dolore voluptas dolores molestias voluptatem sequi explicabo debitis nihil.", null, null, new DateTime(2023, 5, 19, 5, 58, 4, 934, DateTimeKind.Local).AddTicks(7993), 462989.0, null, null, 2, 2, "Quia ex doloribus." },
                    { 27, 19, null, null, "Iusto debitis quidem assumenda consequatur dolor quos quo alias repudiandae dicta aut doloribus labore magnam maxime expedita eos asperiores accusantium et exercitationem.", null, null, null, 317794.0, null, null, 2, 0, "Illum reprehenderit ex sit consequatur." },
                    { 28, 20, null, null, "Odit necessitatibus qui molestias sed ducimus architecto ut est magnam pariatur sit nostrum vitae aut in distinctio dolores animi consequatur molestias exercitationem cum voluptatem modi beatae qui placeat.", "Qui culpa iure architecto nihil quia sit reiciendis deserunt omnis commodi ex sed nostrum culpa.", 4, new DateTime(2023, 3, 4, 20, 30, 11, 268, DateTimeKind.Local).AddTicks(7351), 352694.0, null, null, 4, 3, "Aspernatur sint delectus autem." },
                    { 29, 17, null, null, "Perferendis cumque enim ex ut qui soluta libero incidunt est dolorum velit aliquid dolorem expedita aliquam quibusdam aut facilis dolores fugiat.", "Voluptatem qui et sapiente et ad dolores vitae assumenda quae minima tempore commodi est sed quia accusantium consequatur qui officia.", 2, new DateTime(2023, 1, 3, 17, 55, 13, 318, DateTimeKind.Local).AddTicks(3121), 118833.0, null, null, 0, 3, "Impedit nihil dolorem." },
                    { 30, 8, null, null, "Delectus laudantium saepe aperiam itaque sit consequatur perspiciatis nesciunt culpa ipsam quia beatae consequatur sint aut error error tempora qui ducimus eaque amet ipsum omnis officia odio mollitia commodi eveniet.", null, null, new DateTime(2023, 2, 4, 14, 48, 23, 304, DateTimeKind.Local).AddTicks(6253), 301135.0, null, null, 2, 2, "Quo mollitia ea quidem." }
                });

            migrationBuilder.InsertData(
                table: "Deals",
                columns: new[] { "Id", "ActualRevenue", "CreatedAt", "CreatedBy", "Description", "LeadId", "ModifiedAt", "ModifiedBy", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 458637.0, null, null, "Hic iste ut dolores perspiciatis in illum aut sint inventore qui aut ipsa quo repudiandae perferendis blanditiis odio fugiat voluptatem vero delectus consequuntur eos iusto praesentium nobis autem iusto ab.", 1, null, null, 2, "Et corporis vero." },
                    { 2, 405021.0, null, null, "Aperiam id a aut ipsam in nulla animi ut numquam alias dolorem dolorem itaque qui et debitis doloribus quaerat temporibus saepe consequatur ad voluptatum aliquid.", 2, null, null, 0, "Consectetur omnis assumenda sunt adipisci." },
                    { 3, 328570.0, null, null, "Dolor dolores qui ut debitis qui dolor quam aut cumque est repudiandae nulla qui blanditiis quo perferendis quia quasi sit itaque.", 3, null, null, 0, "Ratione consectetur quasi." },
                    { 4, 422208.0, null, null, "Blanditiis et laudantium alias rem ex amet vel autem ullam est fugiat sequi possimus.", 4, null, null, 0, "Minus qui aliquid iusto et nesciunt." },
                    { 5, 420622.0, null, null, "Voluptatum vel et voluptatem ut nesciunt voluptates impedit neque laboriosam in corrupti molestiae mollitia ullam fuga eos ab consequuntur corrupti repudiandae veniam quaerat inventore dolor molestiae sit.", 5, null, null, 2, "Et perspiciatis magnam exercitationem quia error." },
                    { 6, 435260.0, null, null, "Odio sunt quibusdam quo impedit quia nihil laudantium maiores harum ducimus rerum.", 6, null, null, 0, "Quod inventore repellendus sint aut impedit." },
                    { 7, 326639.0, null, null, "Reiciendis vel officia et quisquam sint qui velit velit beatae dignissimos dolores quis.", 7, null, null, 2, "Quia laudantium dolores veritatis omnis." },
                    { 8, 412293.0, null, null, "Maxime quia numquam esse debitis aut accusamus saepe ea suscipit neque cum facere commodi necessitatibus quia maiores et.", 8, null, null, 1, "Aut dolores similique omnis rem." },
                    { 9, 324749.0, null, null, "Sunt eos voluptate deserunt natus tempora voluptas natus doloribus sunt repudiandae suscipit eum rem reiciendis recusandae beatae deleniti error eum magni adipisci laboriosam eum natus corrupti.", 9, null, null, 1, "Debitis culpa possimus ullam et quo." },
                    { 10, 320283.0, null, null, "Laboriosam ut sint quia est cum amet excepturi ut quod facere fugiat at enim dignissimos non nisi minus enim soluta.", 10, null, null, 0, "Provident rem reiciendis." },
                    { 11, 234800.0, null, null, "Fuga vitae quo qui et dolor non cumque at voluptatibus eum placeat voluptas optio beatae sunt sed.", 11, null, null, 1, "Et recusandae quia cumque et vel." },
                    { 12, 216444.0, null, null, "Minus minus ad voluptate tempora pariatur sunt eum velit qui iure in vel eius voluptate facere aut laboriosam dolore.", 12, null, null, 0, "Explicabo id qui." },
                    { 13, 62529.0, null, null, "Illo qui quos velit est delectus cum earum magnam consequatur rerum exercitationem qui amet vero in ratione.", 13, null, null, 2, "Tenetur facere perspiciatis et mollitia." },
                    { 14, 112310.0, null, null, "Quisquam omnis sint dolorum magnam nobis ut repellendus temporibus ut.", 14, null, null, 1, "Officiis qui deleniti velit." },
                    { 15, 390065.0, null, null, "Eligendi aut dolorem ipsum voluptatem itaque voluptatem amet consequuntur et.", 15, null, null, 2, "Dicta qui reiciendis non perferendis." },
                    { 16, 151567.0, null, null, "Quo consequuntur quis sunt non omnis velit qui soluta labore est velit eos repudiandae ut tempora.", 16, null, null, 2, "Quaerat earum tempore quidem dolor." },
                    { 17, 340938.0, null, null, "Est sit voluptatem in maxime ea libero at corporis et aliquam natus consequatur officia.", 17, null, null, 2, "Quia quia quia quisquam." },
                    { 18, 450304.0, null, null, "Nemo libero quaerat accusamus esse ab nisi vel sunt velit consequatur voluptatem sint quis veritatis amet repudiandae voluptas et voluptas autem est in neque minima qui distinctio quis cupiditate.", 18, null, null, 2, "Et dolore adipisci." },
                    { 19, 48618.0, null, null, "Ut adipisci dignissimos et harum a suscipit eaque accusamus laboriosam ut facere aut.", 19, null, null, 1, "Praesentium eaque maxime non porro." },
                    { 20, 421252.0, null, null, "Incidunt voluptatem dolorem id labore dolorum mollitia reiciendis quod vero quae a quis voluptatem et quibusdam provident molestiae delectus suscipit sit aut quaerat molestias nihil error.", 20, null, null, 0, "Quia et ad sapiente ipsum quaerat." },
                    { 21, 474092.0, null, null, "Vitae voluptas rerum repudiandae eos impedit eligendi iusto quidem omnis fuga ullam soluta quia saepe totam expedita expedita explicabo laboriosam tempora tempora consequatur minus ratione.", 21, null, null, 1, "Nulla et aut libero et dicta." },
                    { 22, 381877.0, null, null, "Voluptas labore iure et rerum dicta quis quas quasi beatae aliquam cumque.", 22, null, null, 2, "Provident assumenda dolor." },
                    { 23, 297473.0, null, null, "Deserunt quis illo voluptate quo soluta excepturi reiciendis repellendus dolorem sit iusto dignissimos porro suscipit.", 23, null, null, 2, "Repudiandae in voluptas quia." },
                    { 24, 50165.0, null, null, "Doloremque explicabo pariatur corporis sed suscipit sit dolorum vel labore non doloribus eaque tempore non occaecati est fugiat quia enim a eos.", 24, null, null, 2, "Sequi enim facere aut." },
                    { 25, 329575.0, null, null, "Ut vitae enim sed sunt dolorem odio magni dolore sed quia rerum dolorum ex eum sed ipsa aut autem ut nemo vel impedit exercitationem.", 25, null, null, 0, "Vel aperiam quod illo ut." },
                    { 26, 377984.0, null, null, "Voluptas rerum impedit sit ipsa rerum ut qui atque laborum enim et temporibus molestiae ipsum animi delectus odit beatae earum et.", 26, null, null, 2, "Cum pariatur aut id exercitationem." },
                    { 27, 248418.0, null, null, "Vel ipsum recusandae commodi numquam laboriosam rerum quibusdam et quia aut maiores ea.", 27, null, null, 2, "Quidem nihil et." },
                    { 28, 97304.0, null, null, "Expedita neque ut inventore impedit sit omnis consectetur autem suscipit qui est in quibusdam occaecati.", 28, null, null, 1, "Pariatur consequatur cupiditate fugit." },
                    { 29, 217098.0, null, null, "Doloribus nesciunt ut fuga temporibus ex eum et sed odio explicabo saepe ad sed est non quis repellat et dolorem accusamus magni.", 29, null, null, 2, "Earum ducimus quos quis non." },
                    { 30, 96402.0, null, null, "Deserunt laboriosam eveniet ducimus quos maiores aut voluptatum dolor numquam aut vel non ea voluptas ea maiores molestiae unde illo molestias tempore impedit.", 30, null, null, 0, "Est voluptas dolorum eius est." }
                });

            migrationBuilder.InsertData(
                table: "DealProducts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DealId", "ModifiedAt", "ModifiedBy", "PricePerUnit", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, null, null, 27, null, null, 41.0, 4, 72 },
                    { 2, null, null, 18, null, null, 40.0, 7, 54 },
                    { 3, null, null, 2, null, null, 51.0, 4, 42 },
                    { 4, null, null, 12, null, null, 47.0, 6, 6 },
                    { 5, null, null, 27, null, null, 99.0, 1, 13 }
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
