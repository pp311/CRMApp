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
                    { 1, "6422 Alverta Rapid, Antonioville, Netherlands", null, null, "King96@hotmail.com", null, null, "Mayert, Kohler and Lind", "1-834-443-4275", 47224.0 },
                    { 2, "4723 Eli Track, Tremblayton, Estonia", null, null, "Dayton_Sipes@gmail.com", null, null, "Kulas - Bartoletti", "1-259-452-3900 x112", 9334.0 },
                    { 3, "559 Blanche Ramp, Wilhelmville, Afghanistan", null, null, "Ernesto_Labadie@hotmail.com", null, null, "Bartell, Walsh and Dooley", "1-838-384-3597", 1127.0 },
                    { 4, "267 Cremin Falls, Lake Giuseppe, Slovenia", null, null, "Antonette.Funk@gmail.com", null, null, "Keeling - Osinski", "381-292-1288 x752", 10361.0 },
                    { 5, "220 Hollis Forge, Port Reginald, Nepal", null, null, "Audie55@yahoo.com", null, null, "Rowe and Sons", "204-393-0231 x53231", 39870.0 },
                    { 6, "668 Stanton Trafficway, Port Ashleetown, American Samoa", null, null, "Marie.Littel@yahoo.com", null, null, "Runolfsson, Weber and Ondricka", "377.424.4480", 46663.0 },
                    { 7, "26284 Queenie Stream, Kielchester, Fiji", null, null, "Theresia32@gmail.com", null, null, "Carroll, Robel and Bayer", "529.394.3623 x2101", 4650.0 },
                    { 8, "875 Joyce Extensions, Emiliotown, Antarctica (the territory South of 60 deg S)", null, null, "Sheila4@gmail.com", null, null, "Watsica LLC", "1-402-946-5488 x339", 24685.0 },
                    { 9, "2582 Tristin Club, South Dewayne, Jordan", null, null, "Vicente_Wilkinson47@hotmail.com", null, null, "Sauer - Kerluke", "(439) 906-6329 x284", 16381.0 },
                    { 10, "47677 Prosacco Plains, Janickhaven, Central African Republic", null, null, "Kenyatta.Gorczany36@yahoo.com", null, null, "Schultz, Kub and Koch", "(329) 271-8009 x46123", 19632.0 },
                    { 11, "3123 Gottlieb Extensions, North Elenora, Fiji", null, null, "Rocio_Weissnat@hotmail.com", null, null, "Bogan - Effertz", "692-288-9930 x096", 21417.0 },
                    { 12, "673 Conn Stravenue, East Ellsworthbury, Trinidad and Tobago", null, null, "Aliyah92@hotmail.com", null, null, "Hammes Group", "409.258.5375 x83256", 34840.0 },
                    { 13, "334 Pascale Port, West Allene, Ethiopia", null, null, "Vicky34@gmail.com", null, null, "Dietrich - Kessler", "444-296-7080", 40201.0 },
                    { 14, "45940 Lind Shores, New Meagan, Montenegro", null, null, "Mylene.Monahan61@hotmail.com", null, null, "Wuckert LLC", "224.221.0067 x693", 34888.0 },
                    { 15, "18686 Maribel Stream, Port Holden, Brunei Darussalam", null, null, "Cullen20@gmail.com", null, null, "Mayert, Gorczany and Huel", "753-872-7201 x50024", 44230.0 },
                    { 16, "5064 Ruecker Ford, East Jarod, Kyrgyz Republic", null, null, "Destiny_Smith@yahoo.com", null, null, "Douglas - Muller", "1-461-904-4862 x3238", 1472.0 },
                    { 17, "79495 Denis Canyon, Port Christop, British Indian Ocean Territory (Chagos Archipelago)", null, null, "Johnny_Torp80@gmail.com", null, null, "Gulgowski - Spencer", "1-557-992-0042 x59441", 43992.0 },
                    { 18, "406 Lemuel Garden, Brannonview, Republic of Korea", null, null, "Alisa.Beer35@hotmail.com", null, null, "McClure and Sons", "(519) 573-6216 x747", 16430.0 },
                    { 19, "866 Pfannerstill Heights, Port Alexis, Armenia", null, null, "Eliza.Kessler59@gmail.com", null, null, "Huel, Waelchi and Friesen", "1-900-844-0596 x22286", 38141.0 },
                    { 20, "76687 Colton Falls, Spinkaberg, Anguilla", null, null, "Linda.Waters@gmail.com", null, null, "Heidenreich, Quigley and Casper", "826.411.0788 x67560", 17867.0 },
                    { 21, "89981 Katelyn Mews, East Christview, Lebanon", null, null, "Frances.Boyer@hotmail.com", null, null, "McLaughlin, Lowe and Watsica", "1-843-422-6847", 8218.0 },
                    { 22, "07865 Creola Shoal, Joeport, Marshall Islands", null, null, "Brandyn.Boyer54@yahoo.com", null, null, "Lynch, Wyman and Stehr", "(773) 414-4993", 46775.0 },
                    { 23, "231 Monroe Ford, North Nels, Kyrgyz Republic", null, null, "Magali68@yahoo.com", null, null, "Hagenes - Feeney", "(728) 200-7085 x7762", 12669.0 },
                    { 24, "7857 Sibyl Flat, New Dashawn, Equatorial Guinea", null, null, "Nasir_Morar@yahoo.com", null, null, "Johnson - Hahn", "1-596-282-6503", 12128.0 },
                    { 25, "002 Isadore Orchard, Dylanfort, Libyan Arab Jamahiriya", null, null, "Stephanie.Zulauf56@gmail.com", null, null, "Marvin - Corkery", "254.732.4935 x55933", 41468.0 }
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
                    { 1, 0, "9ad77664-1700-480f-bc93-8325f59a5613", "superadmin@gmail.com", true, false, null, "superadmin", "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEJb8vQaZuc4NBCG+eKrHVtTM3sxXbyCDZrLK71z4UBNlq7TQ+cbV8NvHs9HFeZhHSg==", null, false, null, null, "7423d90f-5f22-4a57-96bf-78fe5bb3a751", false, "superadmin@gmail.com" },
                    { 2, 0, "efbf8f52-dfc3-4ab4-aa0d-f71fc701035d", "admin@gmail.com", true, false, null, "admin", "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEEPCf4C9hUhiIHhDBC7nZD5u5WMkA1uVV8676pyx+nSkJt7M57ab84Fhfxv/GK7HlA==", null, false, null, null, "d7ee6f0e-0c3a-4a34-8062-5bda26de238c", false, "admin@gmail.com" },
                    { 3, 0, "bdd4accf-0213-4af6-a930-34835d10a236", "Tevin.Marvin@gmail.com", false, false, null, "Arnold Bogan", null, null, null, null, false, null, null, null, false, "Tevin.Marvin@gmail.com" },
                    { 4, 0, "95f108fc-4823-4af3-8059-8bb1d008c1c2", "Ophelia_Kunde@hotmail.com", false, false, null, "Norberto Murazik", null, null, null, null, false, null, null, null, false, "Ophelia_Kunde@hotmail.com" },
                    { 5, 0, "c0883cae-7673-4727-9064-d3745d8a66d2", "Kendra70@gmail.com", false, false, null, "Cornell Koch", null, null, null, null, false, null, null, null, false, "Kendra70@gmail.com" },
                    { 6, 0, "769000b3-26c9-4a95-8e6c-071d8f395f13", "Kareem_Zulauf@gmail.com", false, false, null, "Molly Reilly", null, null, null, null, false, null, null, null, false, "Kareem_Zulauf@gmail.com" },
                    { 7, 0, "9c28dec7-5a5e-4839-9bb1-90df5382fed3", "Rowan.Stehr@yahoo.com", false, false, null, "Elaina Beatty", null, null, null, null, false, null, null, null, false, "Rowan.Stehr@yahoo.com" },
                    { 8, 0, "c1cd6dc2-312a-4709-ae7d-2731177324f0", "Rocio_Mills12@yahoo.com", false, false, null, "Lina Lind", null, null, null, null, false, null, null, null, false, "Rocio_Mills12@yahoo.com" },
                    { 9, 0, "cf588190-c838-41ab-bb49-9c22cfb22b8a", "Fanny.Koelpin@gmail.com", false, false, null, "Raleigh Barton", null, null, null, null, false, null, null, null, false, "Fanny.Koelpin@gmail.com" },
                    { 10, 0, "97422762-ef05-42f8-b1e3-fd3647ce2a43", "Maximillian_Kreiger@gmail.com", false, false, null, "Hattie Runolfsson", null, null, null, null, false, null, null, null, false, "Maximillian_Kreiger@gmail.com" },
                    { 11, 0, "69602abb-86df-4eaa-80a3-efcbd5f4744a", "Jennifer.Howell@yahoo.com", false, false, null, "Brandon Kessler", null, null, null, null, false, null, null, null, false, "Jennifer.Howell@yahoo.com" },
                    { 12, 0, "b4a6749b-9e90-4606-9286-c061bd3c2a14", "Ethan3@hotmail.com", false, false, null, "Pasquale Bartoletti", null, null, null, null, false, null, null, null, false, "Ethan3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsAvailable", "ModifiedAt", "ModifiedBy", "Name", "Price", "ProductCode", "Type" },
                values: new object[,]
                {
                    { 1, null, null, true, null, null, "Tasty Soft Bike", 233.0, "PRO-64506890", 0 },
                    { 2, null, null, true, null, null, "Incredible Fresh Car", 681.0, "PRO-93220361", 1 },
                    { 3, null, null, true, null, null, "Incredible Plastic Keyboard", 796.0, "PRO-68069629", 0 },
                    { 4, null, null, true, null, null, "Unbranded Granite Pizza", 693.0, "PRO-92525672", 1 },
                    { 5, null, null, true, null, null, "Sleek Steel Computer", 392.0, "PRO-20818142", 1 },
                    { 6, null, null, true, null, null, "Handcrafted Plastic Soap", 54.0, "PRO-21881220", 0 },
                    { 7, null, null, true, null, null, "Generic Concrete Towels", 544.0, "PRO-31901055", 1 },
                    { 8, null, null, true, null, null, "Refined Fresh Gloves", 212.0, "PRO-65830697", 0 },
                    { 9, null, null, true, null, null, "Handmade Fresh Chair", 959.0, "PRO-77811059", 1 },
                    { 10, null, null, true, null, null, "Handmade Concrete Tuna", 398.0, "PRO-35785101", 0 }
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
                    { 1, 5, null, null, "Elena.Rogahn@hotmail.com", null, null, "Marge Pfannerstill", "1-204-493-2723 x5202" },
                    { 2, 17, null, null, "Judson27@yahoo.com", null, null, "Foster Schinner", "1-965-201-5881" },
                    { 3, 10, null, null, "Kaia_Feeney57@gmail.com", null, null, "Sadie Watsica", "1-462-532-1366 x37943" },
                    { 4, 10, null, null, "Juana_Harvey30@gmail.com", null, null, "Rudy Abshire", "(504) 662-5153 x184" },
                    { 5, 5, null, null, "Santa_Spinka95@yahoo.com", null, null, "Garland Wilkinson", "1-230-753-9758 x87701" },
                    { 6, 24, null, null, "Osvaldo.Reichert62@gmail.com", null, null, "Sammy Kihn", "1-917-513-0278" },
                    { 7, 18, null, null, "Otis.Frami71@gmail.com", null, null, "Lane Runte", "1-871-870-6065 x793" },
                    { 8, 23, null, null, "Brock.McCullough@hotmail.com", null, null, "Adah Witting", "(552) 255-1504 x79853" },
                    { 9, 2, null, null, "Helen91@yahoo.com", null, null, "Evans Gibson", "846-662-8376" },
                    { 10, 25, null, null, "Gilbert33@yahoo.com", null, null, "Delphia Smitham", "1-900-857-0467" },
                    { 11, 6, null, null, "Karlee_OConnell@yahoo.com", null, null, "Brice Kessler", "872.682.9771 x322" },
                    { 12, 13, null, null, "Frederic_Mohr67@hotmail.com", null, null, "Porter Boyle", "1-372-341-1642" },
                    { 13, 1, null, null, "Alyce.Gulgowski@gmail.com", null, null, "Jazlyn McKenzie", "1-471-637-6155 x330" },
                    { 14, 6, null, null, "Elwin84@yahoo.com", null, null, "Manuel Johnson", "372-703-6678 x80812" },
                    { 15, 8, null, null, "Chet_Turner@hotmail.com", null, null, "Ryley Hayes", "790-901-2583 x5388" },
                    { 16, 3, null, null, "Guy66@hotmail.com", null, null, "Berniece McGlynn", "284.287.5777 x82962" },
                    { 17, 5, null, null, "Emory.Rodriguez18@gmail.com", null, null, "Isabella Schneider", "1-417-237-6400" },
                    { 18, 5, null, null, "Bertrand.Feest25@gmail.com", null, null, "Wilfred Jaskolski", "(461) 883-7246" },
                    { 19, 10, null, null, "Chandler_MacGyver@hotmail.com", null, null, "Joany Davis", "(844) 602-4411 x145" },
                    { 20, 25, null, null, "Elnora17@yahoo.com", null, null, "Lilian Schowalter", "1-317-334-1074 x9186" },
                    { 21, 17, null, null, "Hortense_Bode57@gmail.com", null, null, "Sydney Bartell", "1-454-665-4583" },
                    { 22, 14, null, null, "Samanta_Larson@hotmail.com", null, null, "Elsa Kunde", "(315) 699-0397 x334" },
                    { 23, 1, null, null, "Trace6@gmail.com", null, null, "Maurice Hauck", "(434) 729-3995 x396" },
                    { 24, 5, null, null, "Diamond_Nicolas84@yahoo.com", null, null, "Hunter Mosciski", "405.985.1272" },
                    { 25, 24, null, null, "Alexandrea.Yundt@yahoo.com", null, null, "Rylan Lowe", "(623) 543-3549 x866" },
                    { 26, 7, null, null, "Annie_Carter@gmail.com", null, null, "Brant Pacocha", "938.825.6819 x04490" },
                    { 27, 19, null, null, "Savanah.Murazik@gmail.com", null, null, "Hazel Bayer", "1-261-244-6618 x873" },
                    { 28, 8, null, null, "Lenny8@yahoo.com", null, null, "Gayle Sipes", "(889) 977-7370 x92074" },
                    { 29, 8, null, null, "Kip33@gmail.com", null, null, "Kirsten Sipes", "1-418-549-5914" },
                    { 30, 11, null, null, "Albina_Harvey26@hotmail.com", null, null, "Johnpaul Heller", "396-569-8232" },
                    { 31, 13, null, null, "Mollie5@yahoo.com", null, null, "Alverta Yundt", "1-357-241-7384 x0588" },
                    { 32, 8, null, null, "Coy13@gmail.com", null, null, "Adella Lueilwitz", "351.978.7566 x7179" },
                    { 33, 9, null, null, "Domenico90@hotmail.com", null, null, "Ara Sipes", "(679) 303-5417 x984" },
                    { 34, 10, null, null, "Zora_Kunze@yahoo.com", null, null, "Vern Barrows", "341-913-9563 x051" },
                    { 35, 21, null, null, "Michelle.Lowe71@yahoo.com", null, null, "Neha Beahan", "1-301-670-3313" },
                    { 36, 16, null, null, "Elmore74@hotmail.com", null, null, "Marquise Hessel", "738-923-2884 x985" },
                    { 37, 3, null, null, "Herta.Rodriguez@gmail.com", null, null, "Oren Blick", "1-993-557-6935" },
                    { 38, 2, null, null, "Kristopher.Bosco67@hotmail.com", null, null, "Dannie Beatty", "1-533-362-3223 x0861" },
                    { 39, 11, null, null, "Rod.Lynch6@yahoo.com", null, null, "Constantin Kautzer", "321-417-1047 x15337" },
                    { 40, 22, null, null, "Chet.Schimmel32@hotmail.com", null, null, "Charity Haley", "576.596.4442 x721" },
                    { 41, 7, null, null, "Hettie.Ortiz@gmail.com", null, null, "Bud Aufderhar", "(476) 786-4990 x3758" },
                    { 42, 9, null, null, "Russ_Hyatt9@yahoo.com", null, null, "Tanner Wehner", "(717) 726-9281 x82196" },
                    { 43, 24, null, null, "Dagmar_Schuster@yahoo.com", null, null, "Larry Marquardt", "614-944-2193" },
                    { 44, 21, null, null, "Kaleigh.Rosenbaum11@gmail.com", null, null, "Antoinette Keeling", "396.323.3807 x71458" },
                    { 45, 13, null, null, "Camden45@yahoo.com", null, null, "Omer Smith", "848.622.1977 x0673" },
                    { 46, 11, null, null, "Camille65@yahoo.com", null, null, "Ronny Klein", "618-578-9001" },
                    { 47, 5, null, null, "Jonathan.Klein@hotmail.com", null, null, "Deshaun Larkin", "454.846.9740" },
                    { 48, 9, null, null, "Hershel.Raynor72@yahoo.com", null, null, "Wilmer Schumm", "1-730-302-7399" },
                    { 49, 8, null, null, "Zita_Rowe96@gmail.com", null, null, "Rudolph Stroman", "778-598-1592" },
                    { 50, 23, null, null, "Aditya13@hotmail.com", null, null, "Jamir Gibson", "(927) 803-5952 x514" },
                    { 51, 14, null, null, "Jamir.McDermott@gmail.com", null, null, "Reinhold Mitchell", "1-241-833-9040 x16938" },
                    { 52, 1, null, null, "Marlee_Maggio@gmail.com", null, null, "Felipa Mitchell", "1-594-831-6788 x146" },
                    { 53, 10, null, null, "Adrienne4@yahoo.com", null, null, "Abbie Hoeger", "(253) 890-9747 x776" },
                    { 54, 20, null, null, "Mariam.Reilly79@hotmail.com", null, null, "Gust Runolfsson", "900.234.1390 x4984" },
                    { 55, 6, null, null, "Manley_Champlin79@hotmail.com", null, null, "Darron Ratke", "400.722.9647 x0843" },
                    { 56, 16, null, null, "Lauriane4@gmail.com", null, null, "Kenna Hane", "(304) 708-2761 x7169" },
                    { 57, 16, null, null, "Taryn_Price75@yahoo.com", null, null, "Stefanie Kovacek", "1-252-221-4113 x397" },
                    { 58, 25, null, null, "Paxton52@gmail.com", null, null, "Arno McLaughlin", "515-799-5502" },
                    { 59, 16, null, null, "Milan_Beier26@gmail.com", null, null, "Joan Bergnaum", "1-368-526-4227 x5892" },
                    { 60, 19, null, null, "Kolby_Block65@yahoo.com", null, null, "Rocky Graham", "505.504.0617 x82023" },
                    { 61, 20, null, null, "Jake65@gmail.com", null, null, "Grady Mertz", "550.593.0250" },
                    { 62, 5, null, null, "Megane_Hodkiewicz@hotmail.com", null, null, "Ida Reilly", "627-363-5281" },
                    { 63, 8, null, null, "Imani3@yahoo.com", null, null, "Suzanne Denesik", "1-537-236-0696" },
                    { 64, 19, null, null, "Lilly.Cassin@yahoo.com", null, null, "Bell Fisher", "817-911-6239" },
                    { 65, 3, null, null, "Cristopher6@yahoo.com", null, null, "Angel Pagac", "982.650.3445" },
                    { 66, 16, null, null, "Nettie44@yahoo.com", null, null, "Christy Collins", "647-612-1287" },
                    { 67, 16, null, null, "Maximus16@gmail.com", null, null, "Eudora Wehner", "211.501.1589 x4143" },
                    { 68, 25, null, null, "Irving49@yahoo.com", null, null, "Birdie Pfannerstill", "1-699-629-1201 x7142" },
                    { 69, 2, null, null, "Kevon.Green28@gmail.com", null, null, "Diego Pfeffer", "581-843-8970" },
                    { 70, 14, null, null, "Judge61@hotmail.com", null, null, "Soledad Skiles", "1-643-454-2696 x891" },
                    { 71, 6, null, null, "Enola_Collier@hotmail.com", null, null, "Savanna Wehner", "641.588.3816 x88442" },
                    { 72, 25, null, null, "Kelly.Will7@hotmail.com", null, null, "Kaylin Baumbach", "466-420-3125" },
                    { 73, 8, null, null, "Madilyn.Lemke62@gmail.com", null, null, "Leopoldo Crooks", "1-663-557-3275 x9244" },
                    { 74, 4, null, null, "Leatha_Kris21@hotmail.com", null, null, "Osvaldo Leuschke", "(843) 413-2478 x1370" },
                    { 75, 12, null, null, "Walker_Kuhlman@hotmail.com", null, null, "Carolanne Renner", "(883) 914-8801 x8473" },
                    { 76, 17, null, null, "Geraldine90@gmail.com", null, null, "Teresa Hoeger", "541.230.6326 x22639" },
                    { 77, 21, null, null, "Durward_OKon6@gmail.com", null, null, "Price Herzog", "876.758.2278" },
                    { 78, 7, null, null, "Gust.Goyette73@gmail.com", null, null, "Germaine Rau", "1-410-717-7690 x92142" },
                    { 79, 23, null, null, "Hellen_Connelly2@yahoo.com", null, null, "Max Swift", "941.587.6478" },
                    { 80, 2, null, null, "Matilda_Willms68@gmail.com", null, null, "Marjorie DuBuque", "635.798.2537 x853" },
                    { 81, 24, null, null, "Emiliano_Padberg@hotmail.com", null, null, "Ozella Turner", "642.316.3133 x323" },
                    { 82, 8, null, null, "Kristoffer86@yahoo.com", null, null, "Edwina Hoppe", "1-331-311-6572 x53897" },
                    { 83, 19, null, null, "Pierre.Adams90@hotmail.com", null, null, "Jillian Ortiz", "(541) 296-2319" },
                    { 84, 3, null, null, "Shawn28@gmail.com", null, null, "Norene Sporer", "1-240-883-7490 x26253" },
                    { 85, 15, null, null, "Uriah_Boyer@hotmail.com", null, null, "Bailee Hansen", "(481) 635-6963 x588" },
                    { 86, 15, null, null, "Geovanni62@hotmail.com", null, null, "Maximillian Hilll", "(947) 569-8481" },
                    { 87, 10, null, null, "Alicia19@yahoo.com", null, null, "Ewell Heller", "1-738-601-6722 x673" },
                    { 88, 2, null, null, "Dorcas.Kessler25@gmail.com", null, null, "Helmer Larkin", "(540) 617-9009 x65982" },
                    { 89, 12, null, null, "Brock1@hotmail.com", null, null, "Braulio Farrell", "895.362.0926" },
                    { 90, 12, null, null, "Elisha81@hotmail.com", null, null, "Fiona O'Keefe", "1-725-874-1433 x57444" },
                    { 91, 3, null, null, "Tiana.Stark@hotmail.com", null, null, "Cydney Cole", "790-915-7148 x5912" },
                    { 92, 14, null, null, "Ellsworth.McDermott21@hotmail.com", null, null, "Florence Nader", "1-564-828-8170 x8271" },
                    { 93, 25, null, null, "Iva_Halvorson84@gmail.com", null, null, "Kyleigh Bosco", "(771) 641-9906 x2665" },
                    { 94, 10, null, null, "Gabriella95@yahoo.com", null, null, "Rachael Rosenbaum", "1-594-482-5765" },
                    { 95, 2, null, null, "Gertrude_Metz8@yahoo.com", null, null, "Maggie Zemlak", "681.242.7631" },
                    { 96, 13, null, null, "Donavon_Wisoky@yahoo.com", null, null, "Kaleb Kihn", "(428) 741-3091" },
                    { 97, 15, null, null, "Adriel40@gmail.com", null, null, "Philip Abbott", "562.311.3786 x4354" },
                    { 98, 14, null, null, "Dylan_Brakus@yahoo.com", null, null, "Paul Larson", "900.239.6677 x3376" },
                    { 99, 1, null, null, "Sammie_Bergstrom@gmail.com", null, null, "Albina Carter", "(307) 656-5502 x4192" },
                    { 100, 20, null, null, "Jamison_Dare41@yahoo.com", null, null, "Misael Keeling", "723-751-2786 x232" }
                });

            migrationBuilder.InsertData(
                table: "Leads",
                columns: new[] { "Id", "AccountId", "CreatedAt", "CreatedBy", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "ModifiedAt", "ModifiedBy", "Source", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 21, null, null, "Et sunt harum quasi et corrupti quia error aut deleniti dicta hic voluptas.", null, null, new DateTime(2022, 11, 4, 13, 37, 24, 367, DateTimeKind.Local).AddTicks(3802), 130724.0, null, null, 4, 2, "Similique fugit ut et cum nobis." },
                    { 2, 8, null, null, "Excepturi nihil ut voluptatibus sint officiis ea reiciendis fugit dolor quo omnis debitis qui fuga eius rerum quasi magni esse ipsa eos porro reprehenderit distinctio nulla.", null, null, null, 220520.0, null, null, 1, 1, "Quia numquam accusantium." },
                    { 3, 2, null, null, "Ut quas autem quo voluptatem et et explicabo autem sed facere nihil dolor hic sit cum aut sed aliquid vero rerum eos quis libero vel.", null, null, new DateTime(2022, 12, 27, 16, 24, 16, 904, DateTimeKind.Local).AddTicks(2842), 341806.0, null, null, 4, 2, "Autem eos ratione dolores magni." },
                    { 4, 1, null, null, "Mollitia porro quae qui excepturi vel non eius sint pariatur qui eos cum nesciunt adipisci est sequi dolorum et consequatur quisquam animi.", null, null, null, 197821.0, null, null, 3, 1, "Quo natus pariatur." },
                    { 5, 22, null, null, "Et id minima sed est modi dolores consectetur veritatis esse quia.", null, null, new DateTime(2023, 2, 21, 19, 56, 55, 922, DateTimeKind.Local).AddTicks(7479), 96795.0, null, null, 4, 2, "Est dignissimos dicta reprehenderit." },
                    { 6, 8, null, null, "Qui modi autem id ut et dignissimos quia iusto incidunt ea nemo dolore enim incidunt pariatur quia molestiae nulla facilis temporibus illo ea eligendi et.", null, null, null, 399619.0, null, null, 1, 0, "Fuga cum nemo aliquam repellat placeat." },
                    { 7, 19, null, null, "Eos illum corporis non non natus est in qui quam voluptas laudantium quasi maiores ut voluptate ut.", null, null, null, 475097.0, null, null, 3, 0, "Reprehenderit et illo doloremque odio." },
                    { 8, 17, null, null, "Voluptatum ut autem et voluptates neque dicta quam delectus id velit laboriosam id aut et qui officia pariatur voluptatem natus est sunt non.", null, null, null, 78708.0, null, null, 3, 0, "Perspiciatis dolorum exercitationem reprehenderit deleniti ut." },
                    { 9, 13, null, null, "Consequatur expedita magnam odio ea debitis dolorem voluptate eligendi est quae quo eligendi et eos molestias odio dicta incidunt et nesciunt.", null, null, new DateTime(2022, 11, 12, 8, 1, 51, 928, DateTimeKind.Local).AddTicks(2148), 473598.0, null, null, 1, 2, "Rerum omnis in." },
                    { 10, 22, null, null, "Doloremque voluptatibus totam itaque minima vel illum voluptatem fugiat nihil vero ipsa cum deleniti ut dolorem aut et molestiae autem natus quia nobis quia dignissimos porro temporibus suscipit consequatur.", "Dolorem omnis qui suscipit amet voluptatem natus soluta et est qui amet nam beatae iste tempore.", 2, new DateTime(2022, 10, 20, 7, 16, 40, 861, DateTimeKind.Local).AddTicks(4390), 110685.0, null, null, 4, 3, "Error excepturi similique iure." },
                    { 11, 22, null, null, "Sunt autem nihil ipsum soluta a exercitationem recusandae quibusdam provident accusamus aliquid voluptatem quia quos assumenda sit et recusandae non beatae qui distinctio et et cupiditate voluptatum in iusto eos.", null, null, null, 328876.0, null, null, 3, 1, "Recusandae voluptatem ea et." },
                    { 12, 6, null, null, "Incidunt aperiam rerum est velit natus eum a sequi reiciendis dolorum non.", null, null, new DateTime(2022, 12, 27, 10, 18, 24, 985, DateTimeKind.Local).AddTicks(7240), 447775.0, null, null, 0, 2, "A in et." },
                    { 13, 16, null, null, "Qui non quis dolores sapiente cupiditate vel et natus doloremque nulla voluptates mollitia tempore libero voluptatem culpa molestiae aliquid.", null, null, new DateTime(2023, 4, 10, 17, 1, 45, 395, DateTimeKind.Local).AddTicks(2023), 85958.0, null, null, 4, 2, "Animi velit architecto iure." },
                    { 14, 14, null, null, "Magni debitis ut suscipit qui dicta suscipit est quisquam dolor neque iste sed vitae quisquam culpa nihil illum fugiat et in accusamus nisi.", null, null, null, 193233.0, null, null, 4, 1, "Alias perferendis repellendus." },
                    { 15, 13, null, null, "Eaque eos vel minima quam asperiores quasi iste earum voluptates.", null, null, new DateTime(2023, 5, 24, 7, 38, 23, 47, DateTimeKind.Local).AddTicks(9280), 78617.0, null, null, 1, 2, "Qui voluptas odio." },
                    { 16, 9, null, null, "Eos et velit et rerum quasi harum aut omnis quod rem quos ex nesciunt nam eaque voluptatem sunt reprehenderit placeat soluta eveniet voluptatum rerum quo odit vel vel quo.", null, null, null, 24407.0, null, null, 1, 1, "Non qui repellendus itaque." },
                    { 17, 11, null, null, "Eum aliquam non quam asperiores quam reprehenderit ducimus facere vel ad reprehenderit.", "Molestiae non id consequatur nobis ea laudantium aut animi libero repellat.", 2, new DateTime(2023, 4, 19, 13, 19, 45, 271, DateTimeKind.Local).AddTicks(310), 110616.0, null, null, 1, 3, "Reiciendis dolorem tempora." },
                    { 18, 13, null, null, "Sunt unde incidunt est neque sit omnis excepturi nobis quo consectetur earum aut fugiat non porro.", null, null, null, 143460.0, null, null, 3, 1, "Aut unde est nesciunt non." },
                    { 19, 13, null, null, "Suscipit provident at exercitationem asperiores nisi reiciendis possimus inventore quia voluptatem autem esse velit et et quasi ut eaque ut.", null, null, null, 449958.0, null, null, 1, 1, "Eum ipsa aliquid." },
                    { 20, 19, null, null, "Nisi dolorem perferendis earum consequatur modi maiores eligendi similique dicta dolore iusto consectetur accusamus voluptatum quo id dignissimos aliquam illo odio dolor nemo sit eaque dolorem deserunt dignissimos.", null, null, null, 289500.0, null, null, 0, 1, "Natus deleniti rerum rem dolor in." },
                    { 21, 19, null, null, "Ut et temporibus nesciunt aut quae cum dolore voluptatibus omnis velit ducimus et ut nemo enim quia tempora officia accusantium temporibus sed impedit.", "Explicabo exercitationem dicta aut quam fugit soluta modi rerum asperiores.", 3, new DateTime(2022, 10, 26, 23, 15, 56, 919, DateTimeKind.Local).AddTicks(7934), 138823.0, null, null, 3, 3, "Qui recusandae quibusdam." },
                    { 22, 18, null, null, "Magni officia non enim qui totam debitis eos reiciendis quia id et earum doloribus iusto fugiat quisquam non quibusdam dolorem odio soluta enim consequatur et qui et placeat dolorum.", null, null, new DateTime(2022, 9, 14, 12, 15, 46, 663, DateTimeKind.Local).AddTicks(4704), 141182.0, null, null, 3, 2, "Aperiam non nulla architecto aut eum." },
                    { 23, 13, null, null, "Perspiciatis aliquid architecto rerum ipsa quidem quisquam corrupti qui qui et ducimus sit minima magnam voluptates quidem voluptatem cum illum est.", null, null, new DateTime(2022, 8, 30, 4, 53, 26, 880, DateTimeKind.Local).AddTicks(7547), 114225.0, null, null, 1, 2, "Sed officiis velit occaecati beatae labore." },
                    { 24, 12, null, null, "Illum quidem voluptatibus quia et mollitia dolore laboriosam rerum aut quisquam ad consequatur voluptatibus.", null, null, null, 79516.0, null, null, 1, 0, "Voluptatem sed consequuntur quo." },
                    { 25, 2, null, null, "Minus rem libero voluptatem nemo praesentium et nostrum consequatur asperiores id.", null, null, null, 364443.0, null, null, 4, 1, "Placeat quae enim nobis." },
                    { 26, 2, null, null, "Non nesciunt sed corporis quam libero rerum voluptas ducimus aliquid sunt rem.", null, null, null, 445719.0, null, null, 1, 1, "Veniam tempora expedita ea esse debitis." },
                    { 27, 7, null, null, "Vitae ex in neque totam fugit est quasi omnis doloremque quasi ipsa autem at fugiat velit pariatur distinctio maxime rerum impedit.", "Quam et et atque exercitationem nihil quos deserunt laborum voluptatibus earum veniam ea non neque itaque nisi corporis quod dolore deserunt ad.", 2, new DateTime(2023, 2, 12, 5, 17, 30, 629, DateTimeKind.Local).AddTicks(4770), 343571.0, null, null, 0, 3, "Harum minus in rerum sit." },
                    { 28, 15, null, null, "Dolorum totam quae quae rerum in aperiam doloremque dolores aliquam repellat quis fugit.", null, null, null, 143055.0, null, null, 4, 1, "Officia perferendis tenetur qui." },
                    { 29, 5, null, null, "Sint quis sed culpa cumque voluptatem molestiae adipisci sapiente eius est sunt doloremque ad ut.", null, null, null, 368261.0, null, null, 1, 1, "At repellat facere error consectetur." },
                    { 30, 4, null, null, "Animi vel quis qui dignissimos quos quam sit quod qui veritatis et porro eaque sit expedita labore incidunt accusantium distinctio optio eveniet eligendi est et quo et praesentium ut.", null, null, new DateTime(2023, 7, 1, 11, 10, 55, 73, DateTimeKind.Local).AddTicks(4815), 10574.0, null, null, 3, 2, "Aspernatur aut non." }
                });

            migrationBuilder.InsertData(
                table: "Deals",
                columns: new[] { "Id", "ActualRevenue", "CreatedAt", "CreatedBy", "Description", "LeadId", "ModifiedAt", "ModifiedBy", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 68936.0, null, null, "Quas et alias sunt nihil beatae perferendis ducimus repellendus minima voluptates libero porro.", 1, null, null, 2, "Doloremque eligendi dolores." },
                    { 2, 195596.0, null, null, "Temporibus rerum in suscipit quae dolore sed dolor voluptas animi modi laudantium aut voluptas et quis ipsum ut nihil aspernatur tempore consequuntur molestias iusto nam.", 2, null, null, 1, "Animi commodi id." },
                    { 3, 295393.0, null, null, "Et repellat deleniti et dicta quas earum rerum est repellat aperiam rerum possimus reprehenderit expedita dolorem eius beatae.", 3, null, null, 0, "Quia aut quis consectetur." },
                    { 4, 348296.0, null, null, "Voluptatibus quae tempore autem odio ut itaque est ullam est saepe sed qui qui aliquam repudiandae enim vel non quae doloribus eaque voluptatibus.", 4, null, null, 0, "Maxime earum minus ea." },
                    { 5, 324261.0, null, null, "Sunt itaque dolorum nostrum iure dignissimos voluptatem delectus tenetur harum dolorem mollitia id aspernatur.", 5, null, null, 2, "Occaecati corrupti ex eos nesciunt." },
                    { 6, 356248.0, null, null, "Tempore et qui nesciunt maxime architecto enim sed ut et atque in sapiente ea ut sed eaque rerum rerum aliquid.", 6, null, null, 0, "Qui saepe suscipit." },
                    { 7, 51275.0, null, null, "Architecto quaerat reprehenderit magni possimus expedita deserunt saepe sint aspernatur quia maiores est et assumenda saepe quaerat tenetur veritatis.", 7, null, null, 1, "Et ullam et." },
                    { 8, 384342.0, null, null, "Ullam quam doloribus pariatur fuga et autem ut molestiae inventore et minima.", 8, null, null, 1, "Accusamus molestiae tempore earum minima earum." },
                    { 9, 348529.0, null, null, "Quisquam blanditiis consequatur nesciunt magni quia consequatur vero deleniti odit perferendis adipisci qui expedita voluptas labore quaerat eum consequatur ad dignissimos fugit repudiandae et libero odio non quae.", 9, null, null, 0, "Aut nostrum quia quam ut et." },
                    { 10, 480275.0, null, null, "Qui quas ut ratione temporibus voluptas perspiciatis deleniti architecto quibusdam sunt excepturi ipsam libero hic.", 10, null, null, 0, "Eligendi autem similique sit." },
                    { 11, 178092.0, null, null, "Aliquid non cumque aliquam aperiam minus aut sint nostrum expedita ea voluptas placeat aspernatur necessitatibus cupiditate hic perferendis dolorum natus.", 11, null, null, 0, "Sapiente esse est." },
                    { 12, 459333.0, null, null, "Eum est iure qui ut rerum libero reiciendis aspernatur aut perspiciatis distinctio.", 12, null, null, 0, "Deleniti modi corporis cupiditate sed." },
                    { 13, 436238.0, null, null, "Nulla doloribus officia eos voluptatem perspiciatis provident exercitationem tempore omnis ex ex delectus voluptatem dolorum quos ad ut eum tenetur velit.", 13, null, null, 1, "Animi deleniti et." },
                    { 14, 325811.0, null, null, "Ut non sunt aperiam odit dignissimos accusamus sunt expedita possimus rem quo.", 14, null, null, 0, "Animi rerum optio fugit velit." },
                    { 15, 483196.0, null, null, "Veritatis ea exercitationem et debitis dignissimos aut et et qui omnis.", 15, null, null, 2, "Quae distinctio illum ut accusantium." },
                    { 16, 246373.0, null, null, "Et esse rerum dicta facilis non et inventore deleniti est ut aperiam officiis magni error eos voluptatem totam.", 16, null, null, 0, "Corrupti velit hic ipsum explicabo deserunt." },
                    { 17, 108536.0, null, null, "Dolores et veritatis et fugiat error soluta eveniet dolores nihil non ut fuga mollitia sit impedit nesciunt quia non aspernatur voluptas voluptatem maiores.", 17, null, null, 2, "Cumque similique perspiciatis quia perspiciatis dolorem." },
                    { 18, 422029.0, null, null, "Natus molestiae sit qui voluptas aut ut repellat suscipit perspiciatis tenetur ducimus ducimus et quisquam adipisci ea reiciendis aut occaecati distinctio quia consequuntur dolorem.", 18, null, null, 2, "Corrupti ab et perspiciatis." },
                    { 19, 179421.0, null, null, "Et natus autem atque eum placeat odio et voluptatem assumenda est.", 19, null, null, 1, "Quaerat non et." },
                    { 20, 84043.0, null, null, "Enim veniam consequatur quam voluptas voluptatibus consequuntur voluptatem sit ipsum dolore est dolore magnam eligendi voluptatem est omnis nesciunt repudiandae eveniet nam mollitia quia ratione aperiam voluptates quos doloremque.", 20, null, null, 2, "Accusantium minima consequatur." },
                    { 21, 261414.0, null, null, "Et reiciendis consectetur omnis possimus et sed quas minima enim voluptates enim quaerat.", 21, null, null, 2, "Voluptates mollitia voluptas similique possimus." },
                    { 22, 323079.0, null, null, "Qui in tenetur et et vel esse repudiandae quia tempora quos occaecati aliquid aliquam nihil ipsa.", 22, null, null, 0, "Et et deleniti reiciendis ut cum." },
                    { 23, 302063.0, null, null, "Unde aut sit voluptas consequuntur sit iusto et molestias rerum necessitatibus eum natus est.", 23, null, null, 0, "Deserunt ipsam qui aperiam." },
                    { 24, 311893.0, null, null, "Officia pariatur libero eos laudantium deleniti qui cum nihil et non nobis suscipit et ut.", 24, null, null, 0, "Qui nihil dolorum voluptatem veniam ut." },
                    { 25, 171096.0, null, null, "Id sunt eos qui voluptatem et cumque sunt nihil omnis quisquam voluptatum qui est dignissimos deleniti incidunt maxime saepe.", 25, null, null, 2, "Id sit quod numquam sit unde." },
                    { 26, 190052.0, null, null, "Repellat sit a alias dicta ad iste quisquam quos nihil deleniti nostrum nesciunt accusamus dolorem ad sit aut architecto laborum asperiores est in rerum illum deleniti ducimus.", 26, null, null, 0, "Eligendi minima et magni sit sequi." },
                    { 27, 17295.0, null, null, "Consequatur distinctio ex consequatur non quo deserunt quasi qui suscipit ducimus saepe eaque nisi assumenda voluptatibus nam natus nostrum.", 27, null, null, 1, "In expedita veniam deserunt." },
                    { 28, 278908.0, null, null, "Qui facilis beatae delectus et animi molestiae omnis atque magnam praesentium itaque aut ex maxime voluptas in.", 28, null, null, 0, "Incidunt ea dolor ex quos cum." },
                    { 29, 298990.0, null, null, "Delectus facilis at ut voluptas eaque facilis sapiente provident tenetur aut consectetur voluptatem corrupti fuga odio vitae magnam laborum expedita error quo molestiae recusandae illum vitae repellat ipsa et.", 29, null, null, 1, "Quas aut nulla voluptatibus molestias." },
                    { 30, 179215.0, null, null, "Aut ut nihil labore architecto in voluptas dolore laboriosam repudiandae at recusandae enim ea voluptate autem sed voluptas animi sed quia fuga quaerat sit dolor rerum et.", 30, null, null, 1, "Nam sed aut rerum non." }
                });

            migrationBuilder.InsertData(
                table: "DealProducts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DealId", "ModifiedAt", "ModifiedBy", "PricePerUnit", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, null, null, 16, null, null, 39.0, 6, 11 },
                    { 2, null, null, 10, null, null, 45.0, 6, 5 },
                    { 3, null, null, 14, null, null, 75.0, 7, 45 },
                    { 4, null, null, 3, null, null, 82.0, 8, 27 },
                    { 5, null, null, 29, null, null, 38.0, 4, 93 }
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
