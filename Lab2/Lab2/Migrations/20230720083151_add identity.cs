using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab2.Migrations
{
    /// <inheritdoc />
    public partial class addidentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 30);

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

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "92084 Jana Trafficway, East Rahul, Yemen", "Jaleel81@hotmail.com", "Beier - Weissnat", "611-379-7443 x5515", 13036.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "7314 Kendall Corner, East Alvertamouth, Turks and Caicos Islands", "Alycia.Ratke@gmail.com", "Erdman - Hessel", "(210) 370-9364", 43811.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "9035 Jakayla Corners, Ewaldland, Montserrat", "Sterling.Heathcote75@yahoo.com", "Crona - Ryan", "825.785.9099", 38113.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "7270 Adelle Square, South Julia, Canada", "Darron61@hotmail.com", "Feeney - Corkery", "707.763.1202", 6353.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "848 Emmanuel Row, West Trinity, Austria", "Alberto_Runolfsdottir@hotmail.com", "Monahan and Sons", "(338) 393-1477", 2945.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "16587 Nelson Mills, Jarrodchester, Mongolia", "Pasquale_Carroll91@gmail.com", "Klocko, Quigley and Beier", "291-882-6937 x865", 43185.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "0666 Larson Lane, Kochview, Lithuania", "Chris.Cole26@hotmail.com", "Bogan, Kassulke and Dicki", "551-650-6063 x06823", 16253.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "1541 Maya Track, East Melisaville, Malawi", "Ramiro50@gmail.com", "Willms, Kihn and Dach", "259.824.3256", 19520.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "94049 Torphy Overpass, New Mortimerberg, Cuba", "Annamarie82@hotmail.com", "Bergstrom - Hermiston", "451.971.1141 x5130", 17404.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "6636 Terry Village, East Ernieberg, Mauritius", "Lilly44@gmail.com", "Bode, Schmitt and Grady", "616-847-0599 x1656", 44228.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "109 Jolie Mews, Strackefort, Albania", "Leonardo_Erdman@yahoo.com", "Willms - Will", "1-839-331-2573 x6697", 13796.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "03408 Allan Trail, New Augustaborough, Palau", "Cory.Pagac@hotmail.com", "Kub - Konopelski", "1-221-797-2841 x749", 19565.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "80897 Zella Mill, South Lane, Cote d'Ivoire", "Bryana.Waters20@yahoo.com", "McCullough Group", "455-204-5504 x7781", 2964.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "4064 Boehm Harbor, South Myah, Pakistan", "Nettie.Raynor@hotmail.com", "Deckow, Cronin and Ferry", "1-478-987-6517 x294", 47590.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "00207 Johnson Burg, South Leslieview, Pitcairn Islands", "Ron.Quigley21@yahoo.com", "Hartmann - Cummerata", "(448) 898-9495 x15126", 12059.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "418 Joe Inlet, New Jaylen, Netherlands Antilles", "Hulda_Klein94@yahoo.com", "Thiel - Lehner", "1-657-772-9312 x71976", 22149.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "163 Daphne Circles, Port Trent, Cote d'Ivoire", "Richie31@yahoo.com", "Grady, Willms and Goodwin", "284.368.4065 x24177", 28554.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "60074 Nickolas Roads, Port Annalise, Seychelles", "Clark1@gmail.com", "Oberbrunner - Denesik", "(788) 751-6551 x8113", 16759.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "7685 Stephany Drive, Lake Marcelino, Senegal", "Christ49@yahoo.com", "Johnston - Lueilwitz", "1-373-655-4691", 547.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "839 Wehner Canyon, New Junior, Angola", "Edyth.Deckow@yahoo.com", "Larkin, Bahringer and Kemmer", "(871) 284-9568", 15372.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "14947 Schmidt Loaf, Rosebury, Palestinian Territory", "Rosalyn.Stamm@hotmail.com", "Rice, Beatty and Braun", "(859) 720-5245", 936.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "5131 Winfield Center, New Emmaleeshire, South Africa", "Brandyn_Yost@hotmail.com", "Macejkovic, Stokes and Kreiger", "617.518.1623 x486", 13085.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "5944 Hartmann Burg, South Taurean, Cook Islands", "Katelyn.Medhurst46@hotmail.com", "Mohr, Runolfsson and Gorczany", "767-540-6573 x7236", 21068.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "562 Bergnaum Corner, Mustafaport, Czech Republic", "Alia77@gmail.com", "Leuschke, King and Crona", "(545) 440-8922 x67973", 4072.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "317 Zakary Skyway, South Price, Jordan", "Carmen13@hotmail.com", "Rutherford, Herzog and McGlynn", "286-818-8884 x802", 16093.0 });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Admin", "ADMIN" },
                    { 2, null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "a13c6887-4bca-4481-a734-1b25ed3459d9", "admin@gmail.com", true, false, null, "admin", "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEHUgib1Jclqc1+BjtKjQjja5vO+pF+8EeZGXLPzaMZrFcj1w1gpX+QURYnCNgubfDA==", null, false, null, false, "admin@gmail.com" },
                    { 2, 0, "ff9a3db1-30e2-4bcb-a8bf-540cfe3c11b6", "Abraham_Johnston@gmail.com", false, false, null, "Bartholome Feeney", null, null, null, null, false, null, false, null },
                    { 3, 0, "914e7576-e550-41f1-9836-f781d16a96ad", "Diamond63@yahoo.com", false, false, null, "Adella Barton", null, null, null, null, false, null, false, null },
                    { 4, 0, "174daef1-54fd-44d2-801d-b63f98c21030", "Adalberto_Cummings28@gmail.com", false, false, null, "Frieda Zulauf", null, null, null, null, false, null, false, null },
                    { 5, 0, "67ae35b7-49c7-4336-aee6-20318dc91fbf", "Louie34@hotmail.com", false, false, null, "Lea Wyman", null, null, null, null, false, null, false, null },
                    { 6, 0, "195c4584-9671-4127-8165-cdfb2082aaca", "Alisha_Gibson91@gmail.com", false, false, null, "Kurt Jerde", null, null, null, null, false, null, false, null },
                    { 7, 0, "a719ac8c-91f4-4765-ad64-73f5a8ba7ea3", "Jevon.Jacobs@yahoo.com", false, false, null, "Anastacio Parisian", null, null, null, null, false, null, false, null },
                    { 8, 0, "db0f2bb2-184e-49c3-949d-fa6bd2fc183b", "Markus_Langworth74@yahoo.com", false, false, null, "Manuel O'Connell", null, null, null, null, false, null, false, null },
                    { 9, 0, "087784bf-9262-4293-a27e-75050b1666ea", "Madonna_Wintheiser86@gmail.com", false, false, null, "Esperanza Walter", null, null, null, null, false, null, false, null },
                    { 10, 0, "ff22e903-f5e4-4458-b927-43a65ad9831c", "Natalia45@yahoo.com", false, false, null, "Kirstin Bednar", null, null, null, null, false, null, false, null },
                    { 11, 0, "72378b18-f7c8-4103-9ea1-b1561eb17cad", "Kira.OHara@hotmail.com", false, false, null, "Jettie Brakus", null, null, null, null, false, null, false, null },
                    { 12, 0, "187a38c6-6565-4163-a7aa-1fde9771d478", "Anastasia.Miller@gmail.com", false, false, null, "Caleigh Gerhold", null, null, null, null, false, null, false, null },
                    { 13, 0, "5d3c46ee-1eef-4798-8466-9d9cad3b813b", "Ashlee.OHara21@hotmail.com", false, false, null, "Vida Frami", null, null, null, null, false, null, false, null },
                    { 14, 0, "3614b72d-115d-4449-9e07-e79c36e40b6b", "Gillian38@hotmail.com", false, false, null, "Duncan Harris", null, null, null, null, false, null, false, null },
                    { 15, 0, "f4a2e2c4-215a-411c-bb1e-3d28993ad5a9", "Marcelino.Graham16@yahoo.com", false, false, null, "Zula Goyette", null, null, null, null, false, null, false, null },
                    { 16, 0, "816385e3-9443-4254-b846-17fdca67ea85", "Kenyatta_Champlin@hotmail.com", false, false, null, "Ciara Emard", null, null, null, null, false, null, false, null }
                });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 17, "Celine_Hackett29@gmail.com", "Jana Ruecker", "(695) 793-2765 x099" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 6, "Lora_Marks@hotmail.com", "Bennett Haag", "1-454-235-2285 x147" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 24, "Cathrine.Harris10@gmail.com", "Jazlyn Koch", "267.325.2114" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 6, "Tanner50@gmail.com", "Alessandra Stamm", "(996) 219-3428 x13235" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Adolphus91@gmail.com", "Maryjane Monahan", "904-594-1533" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Nadia_Jacobs27@yahoo.com", "Carter Gutmann", "(982) 510-4279" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 22, "Reese20@gmail.com", "Colt Hilll", "505-939-3247" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 12, "Dora_Pfeffer63@gmail.com", "Frederique Braun", "946-633-9804" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 9, "Moshe_Greenholt@hotmail.com", "Eloy Nikolaus", "324-500-2775 x65321" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 20, "Kenyatta_Jerde31@yahoo.com", "Daniela Abernathy", "819.793.6472 x7360" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 11, "Russell_Mayert@gmail.com", "Jerrell Kling", "270.757.8647 x97165" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 21, "Kathryne_Bauch49@hotmail.com", "Newton Marks", "(944) 814-3840" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Carissa_Barrows7@yahoo.com", "Ulises Ritchie", "1-738-818-3511 x513" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 22, "Dino.Stiedemann75@yahoo.com", "Larissa Harris", "1-702-222-1974 x422" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 23, "Rebekah_Hayes7@gmail.com", "Coty Welch", "(859) 883-9184" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 6, "Madaline_Upton@gmail.com", "Kenton Watsica", "(216) 924-6220" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Braden.Christiansen84@gmail.com", "Vicenta Casper", "849.764.7859 x11159" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 19, "Natalia.Morar20@yahoo.com", "Brendon Aufderhar", "(464) 376-7567" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 22, "Freddy_Davis73@hotmail.com", "Alycia Bashirian", "1-347-766-1584" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 12, "Isaiah.Quigley86@gmail.com", "Helena Bode", "959.678.2749 x169" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 19, "Sammie.Torphy@yahoo.com", "Annetta Romaguera", "1-737-859-5845 x23429" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Aurore.Mann@gmail.com", "Madeline Kshlerin", "673-562-6478" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 2, "Ashlynn_Satterfield@hotmail.com", "Rhea Conroy", "1-207-752-1912" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 11, "Laila74@gmail.com", "Alvina Jaskolski", "1-618-628-0517" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 8, "Roy84@gmail.com", "Stephen Trantow", "1-954-360-0138 x59310" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 25, "Esmeralda_Hammes@yahoo.com", "Veda Herman", "1-472-346-9106 x6454" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 15, "Shanel.Bartell6@hotmail.com", "Cayla Doyle", "1-976-550-3466 x345" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 17, "Arne75@yahoo.com", "Jayne Johns", "747.212.3751" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 7, "Salvador89@yahoo.com", "Cornelius Boehm", "(999) 379-1604" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 17, "Michel38@gmail.com", "Wade Johnson", "346.744.4204" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 19, "Terrance.Hane@hotmail.com", "Deondre Brown", "818-308-0986 x769" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 18, "Isabella_Kohler95@hotmail.com", "Agustina Gutmann", "458.796.4609" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 10, "Allison.Streich@yahoo.com", "Maribel Fahey", "452-903-7600 x4727" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 10, "Ian_Cole48@hotmail.com", "Ruby Funk", "(245) 990-7590" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 21, "Maximo_Luettgen@gmail.com", "Mervin Lynch", "1-270-288-5776" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 13, "Raquel.Prosacco48@yahoo.com", "Ahmad Feeney", "574-851-4300" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 16, "Linnea.Rippin11@hotmail.com", "Korbin Christiansen", "(299) 369-2315 x31054" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 13, "Corrine.Ryan83@gmail.com", "Thomas Johnson", "1-305-532-9968" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 12, "Stefanie_Walker@gmail.com", "Dorian Kling", "305-608-4659" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 20, "Madeline.Pfannerstill38@yahoo.com", "Nona Auer", "347.860.0443" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Noble4@hotmail.com", "Jillian Koelpin", "1-618-337-6686" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 14, "Bella.Kertzmann26@hotmail.com", "Darrion Bartoletti", "1-543-462-5418 x04938" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 24, "Osvaldo69@gmail.com", "Kirsten Torp", "(315) 650-1887" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 14, "Kirstin90@yahoo.com", "Hiram Mohr", "1-493-673-6194 x779" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 10, "Buster69@gmail.com", "Aditya Bogisich", "699-969-8387 x44873" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Duncan33@hotmail.com", "Nikolas Bogisich", "927.658.3343 x4639" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 6, "Bettie95@gmail.com", "Boyd Huel", "248-463-8790 x23302" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Carolina.OHara@hotmail.com", "Natalie Bayer", "1-898-955-7062" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 21, "Cory.Runolfsson@yahoo.com", "Malika Walter", "1-389-433-4476 x1242" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 16, "Saul.Lueilwitz@hotmail.com", "Kiarra Feest", "1-308-622-4522 x931" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 15, "Tyshawn.Dickens43@yahoo.com", "Eulalia Connelly", "854.422.7326 x87264" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 17, "Darron.Feest@hotmail.com", "Eileen Osinski", "801.942.1061" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 25, "Kari89@gmail.com", "Rosella Toy", "712.584.1775 x307" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 23, "Mathilde_Adams@gmail.com", "Sigmund Rau", "831.496.6441" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Forest_Langosh51@yahoo.com", "Heloise Carroll", "765-371-5076 x025" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 16, "Thelma_Homenick85@hotmail.com", "Madilyn Kozey", "496.367.6455" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Joseph.Johnson51@hotmail.com", "Bernice Prosacco", "1-392-559-8339 x086" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 10, "Brandy21@yahoo.com", "Josefa Schmeler", "1-743-636-0107 x072" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 13, "Theron62@gmail.com", "Kyla Wiegand", "720.369.6692" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 23, "Adrien.Dietrich29@hotmail.com", "Ethel Feil", "(931) 477-8887 x0286" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Bret5@gmail.com", "Franz Powlowski", "342.366.7165" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 15, "Lee.Ritchie69@gmail.com", "Juwan Bartell", "1-838-535-1614 x663" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 5, "Ines_Lowe50@gmail.com", "Giles Beier", "665-506-5519 x65130" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 9, "Landen.Tremblay@hotmail.com", "Juanita Stamm", "(258) 772-9145 x08022" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 10, "Maryse_Baumbach@hotmail.com", "Kaitlin Zieme", "(311) 595-1402" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 11, "Immanuel34@gmail.com", "Lesly Nader", "459.292.5381" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Mozell.Romaguera47@yahoo.com", "Myrl Feeney", "409.871.5311 x433" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 23, "Philip.Kris36@gmail.com", "Lauretta Haley", "1-317-430-8545" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 24, "Watson51@hotmail.com", "Genevieve Wehner", "969-978-1838" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 25, "Florian.Schulist63@yahoo.com", "Hazle Fritsch", "739.616.1660" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 5, "Aglae.Hettinger84@hotmail.com", "Baylee Farrell", "1-920-921-5111 x27017" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 8, "Fredrick.Bahringer@yahoo.com", "Ava DuBuque", "218.950.0849 x8418" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 12, "Pierce.Koepp@hotmail.com", "Dannie Lang", "1-497-903-0454 x35468" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Zack.Lehner6@yahoo.com", "Cassidy Jaskolski", "861.437.6344" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 1, "Kelley_Bruen36@yahoo.com", "Felipe Brown", "(415) 334-4109 x357" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Tyreek.Reynolds@gmail.com", "Levi Deckow", "659-763-8710 x638" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 16, "Santos_West30@gmail.com", "Damian Schoen", "(610) 679-6961" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 20, "Seamus.Jakubowski86@gmail.com", "Houston Hagenes", "(252) 648-8567" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Luciano53@yahoo.com", "Phoebe Turner", "1-225-483-6607 x9366" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 10, "Donald_Cormier37@hotmail.com", "Kathlyn Hauck", "1-772-491-7790" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 6, "Edwin_Hoppe70@yahoo.com", "Britney Flatley", "(662) 373-2904 x49663" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 1, "Dana63@hotmail.com", "Deron Sporer", "202.510.7260 x47978" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Nya.Braun28@hotmail.com", "Paul Wilderman", "1-282-906-7710" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 10, "Alisa_Grant@gmail.com", "Lorena Considine", "654.985.9238 x4697" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 13, "Domenica.Leannon83@gmail.com", "Brent Berge", "625.770.3724" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 1, "Eden13@hotmail.com", "Brenna Weber", "(224) 944-4153 x711" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 5, "Donnie.Predovic@yahoo.com", "Daphne Rowe", "427.620.4397" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Marquis74@gmail.com", "Carli Sanford", "1-890-900-7927" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Rory_Kertzmann@yahoo.com", "Columbus Mann", "1-266-363-1888 x93419" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 21, "Lucie_Anderson5@yahoo.com", "Nellie Wintheiser", "659-671-2978" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 17, "Geo.Breitenberg@hotmail.com", "Javier Simonis", "1-899-261-5875 x684" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 10, "Makenzie_Kshlerin@yahoo.com", "Alberta Block", "(297) 200-4720 x0514" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 21, "Milo_Lindgren32@hotmail.com", "Jonathan Kautzer", "288.244.3625" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 5, "Devyn_Beatty@gmail.com", "Bette Kautzer", "1-640-826-1274 x2216" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 12, "Lia.Kassulke88@hotmail.com", "Bobbie Jast", "(993) 238-5157 x3949" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 12, "Idella_Klein83@yahoo.com", "Estefania Torp", "395.559.6826" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Dayton81@yahoo.com", "Reyna Gerlach", "1-812-215-1141" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 23, "Adell_Bashirian77@gmail.com", "Brook Brekke", "929.519.7106 x0890" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Willa.Auer13@yahoo.com", "Samara Schoen", "562.389.8242 x452" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 19, "Imani_Ziemann12@hotmail.com", "Demarco Metz", "555.325.4606" });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DealId", "PricePerUnit", "ProductId", "Quantity" },
                values: new object[] { 2, 84.0, 3, 14 });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PricePerUnit", "ProductId", "Quantity" },
                values: new object[] { 13.0, 6, 34 });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DealId", "PricePerUnit", "Quantity" },
                values: new object[] { 16, 95.0, 71 });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DealId", "PricePerUnit", "Quantity" },
                values: new object[] { 28, 62.0, 66 });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DealId", "ProductId", "Quantity" },
                values: new object[] { 27, 8, 71 });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 48138.0, "Officia dolore inventore impedit eveniet accusamus dolores aperiam ullam debitis sequi corporis earum.", 0, "Sed non aperiam qui rerum non." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 53046.0, "Ipsum est delectus nulla beatae quod temporibus tenetur illum dolorem esse cum repellendus quis.", 2, "Placeat veritatis nihil dolor cumque totam." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 456631.0, "Sequi blanditiis sunt ea voluptas aperiam sit numquam nisi adipisci voluptatem nam delectus ratione iusto provident recusandae omnis quae dolores quisquam voluptas dolor dolores dolor est.", 0, "Adipisci architecto non expedita et." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 285657.0, "Saepe rerum iusto consequuntur ducimus dolores rerum cum reiciendis nam aliquid nisi sequi omnis in iusto omnis repudiandae facere repudiandae accusantium esse accusamus.", 0, "Tenetur fugit illo sunt." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 199347.0, "Rerum odit illum ducimus accusantium sunt quibusdam reiciendis fuga labore earum voluptatem iure omnis consequuntur natus debitis dolorem sunt saepe repudiandae iste est voluptatum tenetur occaecati.", "Vel corporis hic explicabo rerum." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 351921.0, "Ut facere sed optio aperiam quibusdam ullam alias quod assumenda ullam nam quis.", 2, "Occaecati quo dolor quia voluptas esse." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 248383.0, "Nobis suscipit laudantium ut repellendus et et a iusto in consectetur quis voluptatibus.", "Nostrum sint illo neque autem." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 478267.0, "Ea culpa facere mollitia dicta quidem aut ut dicta reiciendis sit iure eum molestiae sunt dolores nostrum voluptas sint voluptas ab porro.", "Eos velit numquam similique delectus." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 46026.0, "Temporibus neque illum saepe repellendus consequatur beatae sed amet nemo veritatis soluta ullam animi officia error atque dignissimos eos quo magnam.", 2, "Provident quia assumenda." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 62152.0, "Assumenda ratione aut ea sit veritatis perferendis et eos ut ex vel dolorum unde ut sed ut nihil molestiae aperiam ut fugiat est error et ipsum vel.", "Blanditiis molestias voluptas." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 441757.0, "Iusto rerum voluptate quibusdam quo aut voluptas repudiandae omnis dolorum aut necessitatibus rerum perferendis excepturi reiciendis iusto perspiciatis culpa omnis modi.", 2, "Sit veritatis et." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 212370.0, "Non adipisci esse quia laboriosam porro molestias sit dolore molestiae reprehenderit sequi debitis reprehenderit libero sit illum impedit sed numquam repudiandae consequuntur molestiae.", "Fugit vel facere sunt id officiis." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 399498.0, "Harum odio sapiente officiis aspernatur accusamus voluptatem fugit reprehenderit in.", 0, "Eligendi eveniet qui voluptas eum asperiores." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 290003.0, "Occaecati necessitatibus consectetur voluptates qui adipisci ut odio aspernatur ut.", 1, "Molestias aut minima." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 438904.0, "Dicta cupiditate alias sit maxime quia ut et temporibus eum sapiente blanditiis autem dolorem culpa tempora voluptas qui temporibus minima consequuntur.", "Voluptatibus quisquam aperiam accusamus voluptatibus." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 465765.0, "Cumque et cupiditate necessitatibus facilis quo dolorum nam accusamus harum.", "Aspernatur est a qui ea." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 268732.0, "Praesentium quia soluta consequatur magni consequatur optio sapiente maxime inventore culpa qui at in ea et error et a ullam praesentium omnis repudiandae.", 1, "Sint et natus." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 274866.0, "Ex cumque quisquam possimus magnam voluptate cupiditate ut aliquid temporibus quod autem enim dolorem maxime voluptatibus qui perspiciatis natus numquam omnis quibusdam nam ipsam.", 2, "Nobis id occaecati." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 284074.0, "Enim nam quas rem itaque et modi ullam beatae architecto voluptate nemo voluptatem aut assumenda aliquam asperiores nisi reiciendis voluptatem cumque et sed mollitia magnam animi et qui voluptas rem.", 0, "Est omnis autem quia atque corrupti." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 253199.0, "Nostrum sed aut minima repellat placeat iure facere necessitatibus quis illo rerum.", "Laboriosam quae at tempore quasi tenetur." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 166007.0, "Optio culpa recusandae similique debitis quia qui vel occaecati voluptates quo harum dolore sit quasi nihil non.", "Atque aspernatur praesentium libero vero enim." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 250217.0, "Provident voluptatem laudantium sapiente quisquam non rem reiciendis qui molestiae id reiciendis ducimus quas eos aperiam ratione amet sit et.", 2, "Quia deserunt dolores." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 128932.0, "Est quo pariatur est asperiores commodi distinctio culpa aspernatur aut consequuntur nihil quasi eius nihil quia velit consequatur ut adipisci sint reiciendis sapiente vero molestiae in sit et ab.", "Ratione exercitationem pariatur corrupti repellendus." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 89072.0, "Ab repellat deserunt ut incidunt iure nisi perspiciatis ut quod eligendi doloremque non debitis enim earum rerum.", 1, "Facilis ipsa et et." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 214468.0, "Rerum eos beatae reprehenderit praesentium accusamus voluptas quo aut voluptatem in dicta eos optio voluptatem et facere quo.", "Aut sit rerum nemo." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 340451.0, "Sed est aut deleniti tenetur sed laboriosam laboriosam rerum qui animi similique architecto qui voluptas perferendis sit officia consequuntur maxime sapiente similique exercitationem ad aliquam.", 1, "Ut excepturi earum accusamus." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 312216.0, "Ducimus enim consectetur nobis est et minus ea veritatis minus fuga quia doloremque error quisquam sunt quia eum voluptate impedit voluptates ad molestias et.", 1, "Distinctio nulla et sint animi perspiciatis." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 78886.0, "Amet facilis quo distinctio et molestiae velit corrupti explicabo id fugit ipsam repudiandae id est quia eligendi harum quo commodi.", "Eligendi laborum quasi aliquam voluptatum voluptas." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 46423.0, "Id iste in quas quibusdam quia et illo et minima sunt architecto est consequatur est consequatur deleniti fugit cupiditate placeat.", 1, "Vel officia molestiae debitis consequatur." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 213004.0, "Voluptas et esse asperiores nulla tempore debitis quibusdam nihil eos quis velit in eum id.", 0, "Tempora autem doloremque voluptatum iure corrupti." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 9, "Voluptatem enim sunt nobis nemo sit qui culpa sunt dicta consequuntur fugiat ut in aliquam alias totam autem facere maxime ab id.", new DateTime(2023, 7, 1, 15, 15, 51, 313, DateTimeKind.Local).AddTicks(5484), 150602.0, 2, "Inventore a aut nihil autem omnis." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 23, "Qui voluptas ea iure aliquam est est perspiciatis reiciendis ea perferendis autem consequatur quia ut sed tenetur nulla.", new DateTime(2023, 2, 19, 16, 35, 49, 699, DateTimeKind.Local).AddTicks(9883), 245256.0, 1, "Sit maiores recusandae libero pariatur dolorum." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 3, "Possimus et et nemo incidunt qui accusantium vero expedita qui molestiae tempora sed similique atque id iusto eligendi molestias eveniet et qui nostrum qui quibusdam omnis non libero repellendus.", 231223.0, 2, "Et ratione asperiores qui dolore quia." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 18, "Et iste qui quas impedit dolor enim tempora dicta nostrum facere dolorem accusantium molestiae est doloremque doloremque pariatur.", null, 320462.0, 3, 0, "Sed quos ab quos qui culpa." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 8, "Ut rerum in voluptates consequuntur ipsa blanditiis qui sit quia quia.", 73479.0, 1, "Eos iure sint eaque corporis." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { "Numquam in sed dolor distinctio autem non ut aliquid aut tempora ut necessitatibus incidunt assumenda dolores praesentium voluptatum omnis temporibus dolore iusto rerum nostrum.", null, 32519.0, 0, 0, "Odit quia et." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 9, "Nam in veniam praesentium velit excepturi explicabo est voluptatum a vitae nihil natus voluptatem aut.", null, null, null, 206044.0, 4, 1, "Dolore et nobis culpa." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 10, "Ut voluptas aliquid ut dignissimos enim at eligendi magni vel ducimus ut numquam est animi in nostrum voluptatum mollitia autem minima aliquid dolor voluptatem molestiae vel.", null, 67536.0, 0, "Modi tempore quidem consectetur est eum." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 2, "Aliquam voluptatibus illum in repellendus velit earum facilis est repellat inventore ex ut rem eos qui ex praesentium et doloribus praesentium qui vitae earum cupiditate voluptates vitae quisquam.", "Provident est itaque est deserunt consequatur culpa commodi quos deserunt aut quaerat perspiciatis in ad est ipsam quis sit eos beatae.", 3, new DateTime(2023, 5, 8, 17, 32, 44, 807, DateTimeKind.Local).AddTicks(8894), 16843.0, 1, 3, "Maiores et iure quibusdam ad." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 7, "Id perferendis eligendi rerum commodi vel doloribus sed voluptatibus doloremque voluptatum quibusdam iusto iusto quia quae nihil dolore et ratione molestiae recusandae voluptatem modi qui officia dolores incidunt ratione.", null, null, null, 15696.0, 1, "Non ea expedita et omnis." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 16, "Est exercitationem voluptas amet perferendis tenetur ea sed ea corrupti nobis quis debitis et necessitatibus doloremque quasi.", 125318.0, 0, "Enim ipsam hic hic." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Title" },
                values: new object[] { 6, "Eaque vel corrupti quas ut quisquam voluptas et eos distinctio cum sequi sed dolor laboriosam aut sit quasi ut iste asperiores possimus reiciendis voluptas dolor ut.", new DateTime(2023, 5, 14, 16, 29, 19, 47, DateTimeKind.Local).AddTicks(1473), 314712.0, "Illum reiciendis et ut repellendus placeat." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 16, "Ipsum eligendi ratione eum saepe dolores accusantium accusantium blanditiis omnis.", 25777.0, 4, "Soluta similique dignissimos vero perferendis et." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 3, "Numquam magnam porro et velit quisquam magni vel quo veniam id eligendi et itaque nihil sed et inventore optio a et ut porro facilis dolorem.", 471446.0, 2, "Est veniam reprehenderit consequatur." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 10, "Architecto ut placeat quia excepturi sint corrupti modi magnam explicabo aspernatur accusamus ex eum dolor quia.", "Et adipisci enim voluptatem et sint eveniet unde odit autem et mollitia fuga vero soluta excepturi architecto impedit aliquid corrupti amet rem sapiente corrupti qui eos et sit officiis.", 3, new DateTime(2022, 12, 20, 12, 13, 46, 773, DateTimeKind.Local).AddTicks(3425), 181494.0, 4, "Aliquam enim aut et dolorem." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 22, "Similique repudiandae amet dolore saepe corporis aliquam vitae ipsa quas necessitatibus sunt porro est atque eum quo nam qui enim mollitia dolorem neque facere corrupti autem et sunt ad.", new DateTime(2023, 7, 15, 19, 25, 37, 526, DateTimeKind.Local).AddTicks(3013), 306473.0, 1, 2, "Reprehenderit minima libero ea." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 1, "Nam nihil dolores vero aut omnis vel distinctio incidunt numquam perspiciatis delectus dolor voluptatem voluptas eos repudiandae commodi optio sit ut neque quod nostrum est eius veniam voluptatibus aspernatur nulla.", 101254.0, 1, "Vel voluptas deserunt quia et quo." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 10, "Nemo nihil eveniet consequatur doloremque qui nihil alias et doloremque praesentium nesciunt.", 124409.0, 0, "Sed consequuntur assumenda magni ducimus." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 11, "Consequuntur rerum tenetur provident et illo mollitia quis tempore aut ut aut enim vitae animi.", new DateTime(2023, 1, 3, 17, 48, 52, 345, DateTimeKind.Local).AddTicks(7878), 129961.0, 0, 2, "Aut asperiores corrupti odio quo ut." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 17, "Quam illum dolorum quis nobis nemo expedita accusamus molestias expedita dolores sed deserunt nisi velit magni nesciunt sint est molestiae voluptates culpa assumenda ut sint repellat.", "Iure deserunt consectetur in repellat animi quidem in minima nihil in harum ipsam quis sit excepturi.", 4, new DateTime(2023, 1, 1, 4, 30, 55, 219, DateTimeKind.Local).AddTicks(714), 436049.0, 1, 3, "Et sit similique sit asperiores ab." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 13, "Ratione doloremque voluptatum quos ipsa cupiditate vel quia quia voluptas eum ipsam.", null, null, new DateTime(2022, 12, 13, 11, 21, 2, 506, DateTimeKind.Local).AddTicks(4448), 84639.0, 2, "Dolore dolorem ad." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 22, "Dolores in accusamus debitis consequatur autem repudiandae quo assumenda ipsum sed iste labore dignissimos unde voluptates officia velit maxime soluta voluptas aliquam tenetur tempora aliquam ipsum est odio.", new DateTime(2022, 12, 10, 22, 19, 35, 106, DateTimeKind.Local).AddTicks(6301), 437078.0, 4, "Cumque beatae hic explicabo optio perferendis." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 23, "Tenetur optio libero fugit eos illo laboriosam expedita deleniti et.", 35074.0, 2, 0, "Laboriosam accusamus sed." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 15, "Non et consequatur deserunt iste ex omnis aut rem qui.", 162145.0, 0, 1, "Doloremque quia rem rem voluptas." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 19, "Voluptatem nostrum quia blanditiis qui voluptate rerum praesentium numquam consequatur ut maxime beatae laboriosam et et facere minus id qui pariatur quis libero facilis voluptatem id rerum explicabo voluptatem.", new DateTime(2022, 10, 14, 9, 21, 3, 420, DateTimeKind.Local).AddTicks(9332), 269366.0, 4, 2, "Harum fuga qui." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Title" },
                values: new object[] { 5, "Libero aliquam iste nihil iste quos aliquam autem minus est sint rerum autem sed commodi rerum velit a ducimus cum.", 71592.0, "Sit earum aut et natus." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 22, "Dolor sed exercitationem hic asperiores qui aperiam nam quam sed dolores possimus sapiente minus necessitatibus beatae.", null, 396289.0, 4, 1, "Sequi aperiam eum dolores aut." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 7, "Officiis quae aut illo beatae qui omnis maxime aut quia sequi at asperiores quos hic et dolores tempora sed sint eaque et porro aut est consequatur doloribus.", null, 438545.0, 1, "Voluptatum harum numquam iure vel." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 17, "Omnis consequatur recusandae sed aut temporibus est maiores perspiciatis totam mollitia rerum facere explicabo id esse qui.", null, 296358.0, 2, 0, "Mollitia sed nostrum." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 11, "Suscipit nesciunt laboriosam veritatis a enim et cupiditate nulla quaerat harum culpa omnis ut cupiditate ut id rerum aliquam illo ipsa repellendus dicta inventore consequatur nihil assumenda beatae voluptate.", "Est qui tempore aut ipsam mollitia quos voluptatem amet ea ea laboriosam sit corporis ut animi iusto et quia pariatur eaque veniam cupiditate quasi.", 4, new DateTime(2023, 7, 7, 23, 41, 49, 623, DateTimeKind.Local).AddTicks(9836), 237526.0, 1, 3, "Totam culpa distinctio." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Sleek Wooden Cheese", 396.0, "PRO-59148968" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Incredible Soft Chicken", 888.0, "PRO-19083308" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Ergonomic Frozen Chips", 246.0, "PRO-76850509" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Rustic Concrete Chicken", 859.0, "PRO-75825942" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Generic Cotton Hat", 774.0, "PRO-82284893" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "Price", "ProductCode", "Type" },
                values: new object[] { "Fantastic Rubber Shoes", 35.0, "PRO-89535059", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Price", "ProductCode", "Type" },
                values: new object[] { "Licensed Metal Tuna", 978.0, "PRO-84344106", 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Intelligent Steel Bacon", 565.0, "PRO-19442563" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Sleek Steel Gloves", 648.0, "PRO-42889199" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "Price", "ProductCode", "Type" },
                values: new object[] { "Rustic Concrete Pants", 412.0, "PRO-44069537", 0 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 2, 16 }
                });

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "178 Macejkovic Oval, West Esperanzaview, Central African Republic", "Watson64@gmail.com", "Stokes, Rau and Miller", "322-392-9225", 34673.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "656 Corkery Grove, Cristville, Finland", "Jovanny_Gleichner37@hotmail.com", "Balistreri - Kassulke", "825-682-7123 x897", 16506.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "3844 Dietrich Rest, East Grayce, Cuba", "Hayden.Denesik@hotmail.com", "Koch - Sporer", "435-401-2942 x3733", 48293.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "1510 Swift Terrace, Schusterberg, Nepal", "Maya.Adams@gmail.com", "Rosenbaum, Okuneva and Will", "(947) 842-1055 x2215", 48417.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "0383 Jedidiah Walks, South Mozelleton, Botswana", "Jayne.Dietrich@yahoo.com", "Rogahn, Swaniawski and Berge", "384-965-4755", 16464.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "010 Champlin Trail, Wiegandfurt, Cyprus", "Imelda_Roberts59@hotmail.com", "Gaylord - Grimes", "1-343-570-8665", 12973.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "51557 Krajcik Key, Domenicmouth, Norfolk Island", "Maymie53@hotmail.com", "Little and Sons", "(264) 563-8642 x86300", 31117.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "84357 Uriah Rue, Pourosmouth, Guam", "Otha82@hotmail.com", "Abernathy and Sons", "554-504-3025 x562", 23821.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "36893 Bergstrom Valleys, New Haskell, Marshall Islands", "Waldo_Bradtke86@hotmail.com", "Gutmann, Beier and Muller", "393.795.8910 x8772", 28183.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "5246 Mara Station, New Cleo, Taiwan", "Gene31@yahoo.com", "Padberg - Olson", "281-394-7953 x1144", 26393.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "31552 Nader Wall, Hickleport, Monaco", "Armani_Swaniawski33@hotmail.com", "Nitzsche - Murazik", "(759) 531-3635 x1803", 38676.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "569 Karina Mountains, West Celiaport, Saudi Arabia", "Heloise.Turcotte@gmail.com", "Wiza, Altenwerth and Hessel", "247-831-8396", 7348.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "993 Elena Divide, Kozeychester, Saint Vincent and the Grenadines", "Jose.Johns28@yahoo.com", "Kuphal - Bins", "1-858-270-9977", 23038.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "137 Leslie Dam, South Kattiebury, Mongolia", "Elyse_Marks94@hotmail.com", "Turcotte - West", "(656) 464-4826 x45608", 22277.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "78735 Hammes Forest, New Cicero, Jamaica", "Bobbie_OHara@gmail.com", "Morar LLC", "1-734-295-8724", 42240.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "29015 Gottlieb Lights, Wandaport, Somalia", "Jace.Breitenberg@gmail.com", "Luettgen and Sons", "1-910-475-5870", 5902.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "788 Kailyn Glen, Geraldburgh, Tokelau", "Taurean68@yahoo.com", "Baumbach, Bernier and Sauer", "357-464-6090 x1379", 4483.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "16650 Wilfrid Rue, Kubstad, Greece", "Carol_Emard@gmail.com", "Wolf, Hamill and Bode", "952.850.1021", 41292.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "9407 Schaefer Inlet, Eastonmouth, Martinique", "Kathleen61@yahoo.com", "Bruen, Ebert and Jast", "(847) 464-4734", 36669.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "22554 Vilma Garden, South Aleneshire, Maldives", "Allen_Schiller22@hotmail.com", "Gerlach - Block", "627-636-4980", 26606.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "31866 Johns Orchard, Weberburgh, Comoros", "Garfield_Morissette88@gmail.com", "Stracke, Pacocha and Larkin", "(364) 900-9408 x4670", 30822.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "6938 Darion Club, West Adella, Haiti", "Bernadette_Brakus@gmail.com", "Friesen LLC", "(826) 534-5426 x44680", 7137.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "4725 Alivia Station, East Nikolas, Cayman Islands", "Asia21@gmail.com", "Heathcote, McDermott and Sporer", "(383) 722-2571 x10973", 19501.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "56034 Zack Inlet, Dameonside, Bahamas", "Buford_Spinka93@gmail.com", "Jacobson LLC", "(566) 502-4716", 45826.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "4408 Edna Port, Ratketon, Oman", "Fermin93@hotmail.com", "McClure - Hegmann", "964-741-6609 x66076", 1863.0 });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 12, "Garret68@yahoo.com", "Abner Brekke", "(918) 584-4403" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 8, "Berenice_Gottlieb@hotmail.com", "Merritt Koch", "379.591.7581 x2777" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 19, "Tomasa.Yost@yahoo.com", "Erwin Reichel", "699-293-6098 x81402" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 25, "Marcelo3@yahoo.com", "Dakota Kuhlman", "1-453-383-0195 x26349" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 12, "Mike.Hermann33@gmail.com", "Kayden Bogisich", "(845) 251-5168 x3760" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 20, "Garry_Thompson78@hotmail.com", "Ross Ryan", "(388) 681-1447" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 16, "Celine_Mitchell@hotmail.com", "Joana Sipes", "302-828-5159" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 14, "Everette_Beatty@yahoo.com", "Sasha Hessel", "673.399.5215 x665" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 22, "Jeanette.Davis93@yahoo.com", "Jerad Harvey", "550-568-9769 x2624" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 2, "Thea_Schmidt@hotmail.com", "Filiberto Blick", "1-520-857-2635 x4760" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 19, "Napoleon78@yahoo.com", "Jerod Dickinson", "754.773.1913 x42800" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 17, "Ocie92@yahoo.com", "Kyla Hauck", "860-967-0797 x836" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 13, "Rylee.Rohan@gmail.com", "Lupe Stark", "370.553.5544" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 24, "Adella99@gmail.com", "Wilhelmine Jenkins", "1-287-856-8613" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 8, "Shanon47@hotmail.com", "Michel Rolfson", "310.575.2069" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 1, "Magnus19@hotmail.com", "Myrna Kertzmann", "1-502-296-7985 x8871" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Tomasa.Gleichner4@gmail.com", "Dalton Conn", "(298) 257-7322" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 15, "Shayne47@yahoo.com", "Sarah Russel", "581.570.0536 x6784" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 12, "Eleanore54@hotmail.com", "Emmett Haag", "955-547-8385" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 16, "Heaven.Rolfson59@yahoo.com", "Scot Labadie", "376-580-8455 x725" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 21, "Hassie_Erdman28@yahoo.com", "Santos Brekke", "1-328-622-9286" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Toy69@gmail.com", "Theresa Little", "(930) 561-1131" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Clair37@yahoo.com", "Meggie Stamm", "899-628-3682 x454" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 17, "Dorris9@yahoo.com", "Wilmer Rosenbaum", "1-739-801-3576 x65813" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 23, "Wyman47@hotmail.com", "Everardo Ritchie", "1-699-571-7309 x659" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 10, "Hilda.Larkin@hotmail.com", "Hannah Hansen", "655-443-7685" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 16, "Rahsaan31@yahoo.com", "Rory Hauck", "1-521-367-5551 x350" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 23, "Norene.Runolfsson@hotmail.com", "Megane Schmidt", "1-386-716-1666 x66941" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 1, "Jesus_Becker91@yahoo.com", "Raegan Haag", "1-421-900-4618 x3270" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 6, "Lauriane30@hotmail.com", "Norval Lind", "701.562.8579" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 13, "Mitchell_Hermiston17@hotmail.com", "Charley Rohan", "652-968-7487 x161" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 16, "Fermin_Satterfield79@hotmail.com", "Clementine Krajcik", "764.331.6648" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 24, "Percival_Kertzmann64@hotmail.com", "Cedrick Hickle", "1-758-760-5783 x7734" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 6, "Violette_Howell@yahoo.com", "Isobel Beahan", "(431) 217-5961" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 5, "Anissa81@hotmail.com", "Ernestine Schmeler", "552.726.2139 x0044" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 22, "Karli_Cremin61@yahoo.com", "Oma Kub", "919.973.1849" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 11, "Estevan43@yahoo.com", "Norris Miller", "(324) 624-8571" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 25, "Sadye.Kulas@yahoo.com", "Albina Stroman", "1-473-804-9387" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Delta_Cassin37@yahoo.com", "Etha Reichert", "(581) 931-8243 x96738" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 22, "Zack_Kertzmann45@yahoo.com", "Dee Glover", "550.870.8363" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Phoebe.Bergnaum53@yahoo.com", "Don Schmidt", "846-795-7646" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 12, "Cecile_Gislason49@gmail.com", "Hanna Swaniawski", "710.492.0726 x794" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 2, "Kim37@yahoo.com", "Jovany Dickens", "631-854-4326 x739" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 19, "Dasia0@hotmail.com", "Selmer Beier", "(393) 535-8004" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 18, "Rory_Johnston@gmail.com", "Coby Johns", "(395) 577-7460 x4964" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 25, "Chasity.Boyle97@yahoo.com", "Alyson Block", "1-623-569-0581" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 24, "Ludie_Cartwright@yahoo.com", "Stephanie Veum", "655.697.0049 x12741" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 9, "Lulu_Williamson2@yahoo.com", "Reese Wehner", "(732) 306-9370 x84990" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 6, "Brown46@yahoo.com", "Santiago Hodkiewicz", "1-403-688-9974 x5936" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 23, "Eleanore2@hotmail.com", "Tommie Veum", "852.356.2094" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 25, "America3@gmail.com", "Summer Feest", "622-597-9657" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 19, "Jorge.Haley@hotmail.com", "Virgil Schinner", "(758) 868-2146 x86095" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 18, "Arvilla99@gmail.com", "Brittany Dibbert", "1-760-430-6644 x18168" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 17, "Kareem15@gmail.com", "Gertrude Moore", "(483) 510-7796" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 1, "Adam.Auer49@hotmail.com", "Celine Schulist", "459.643.9385" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 21, "Dagmar_Monahan@hotmail.com", "Rodolfo Rosenbaum", "1-631-207-5007 x354" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Santa53@yahoo.com", "Carmen Waters", "634-644-8429 x6807" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Madisyn_Swaniawski54@yahoo.com", "Phoebe Koch", "353.222.9116 x689" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Rachelle.Ernser@gmail.com", "Tressa Stark", "1-889-743-8117" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Mossie.Rutherford@gmail.com", "Bernie Maggio", "(587) 675-4465 x17821" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 9, "Lyric_Monahan@yahoo.com", "Destiney Rempel", "588.372.4110 x7832" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 17, "Brendan68@gmail.com", "Melyssa Wilkinson", "(812) 321-9425" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 9, "Maribel.Bosco@hotmail.com", "Damaris Gutmann", "389.469.4411 x5506" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 24, "Roderick_Parisian@gmail.com", "Vidal Kassulke", "837-793-7767 x002" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 16, "Michaela_Marks96@yahoo.com", "Elenor Will", "490.466.6068 x3518" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 16, "Jewel.Kessler@gmail.com", "Jarrod Wiza", "249.672.1130 x605" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 24, "Maryse.Braun@hotmail.com", "Dustin Hermann", "311-427-4896 x4398" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 21, "Michele_Wintheiser57@yahoo.com", "Judd Rutherford", "(477) 285-9446" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 17, "Juston.Osinski@gmail.com", "Cecilia Gerlach", "(643) 662-1425 x499" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 16, "Maryse.Hermiston85@gmail.com", "Georgiana Bogisich", "553-670-9439 x84325" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 16, "Chloe3@hotmail.com", "Joelle Denesik", "308.400.7271 x32976" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 22, "Violette25@gmail.com", "Kayleigh Kozey", "782-968-7985 x76364" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 25, "Lauren8@yahoo.com", "Deon Bernier", "486-768-1585" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Magnus_Hessel@gmail.com", "Elmer Bernier", "(523) 633-0876 x52005" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 21, "Stewart_Kirlin@gmail.com", "Penelope Bayer", "272-482-0152" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Jade_Von34@hotmail.com", "Elisa Durgan", "540-774-9615" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 13, "Emmet45@gmail.com", "Felicia Wilkinson", "357.249.5576 x943" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 7, "River50@hotmail.com", "Maryam Bechtelar", "364-281-1256" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Otha_Mills@hotmail.com", "Adrienne Block", "775.367.0387" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 17, "Alycia.Huels68@yahoo.com", "Mortimer Kunde", "776.751.4754 x10018" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 7, "Sage_VonRueden98@hotmail.com", "Jed Herzog", "930-581-7804 x0117" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 19, "Israel_OKeefe62@gmail.com", "Chadd Howell", "743.652.7154 x531" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 24, "Aric.Schuppe@gmail.com", "Callie Grant", "408.704.2325 x242" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 14, "Ken_Ledner45@hotmail.com", "Peter Bernhard", "1-852-911-6885" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 9, "Alexys_Watsica@gmail.com", "Nina Collins", "1-655-339-4957" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 15, "Justina_Becker45@yahoo.com", "Robb Runolfsson", "374.643.9309 x2318" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 10, "Ara_Champlin@yahoo.com", "Zoie Schowalter", "977-625-2955 x45274" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 17, "Daphnee.Ruecker@yahoo.com", "Claudia Tromp", "1-371-890-0516 x30084" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 19, "Laverne.Ondricka41@yahoo.com", "Sabryna Stehr", "834.407.6701" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 16, "Petra_Cole@gmail.com", "Abigail Waelchi", "(261) 971-4948 x136" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Shania.Cassin@gmail.com", "Macie Ortiz", "(562) 520-1827 x525" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 6, "Rudolph_Kassulke@yahoo.com", "Rhoda Leffler", "625-455-7496" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 7, "Imani_Shields38@yahoo.com", "Timothy Mraz", "1-693-616-7650" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 23, "Katlyn.Mohr14@gmail.com", "Pink Conn", "830-440-9222 x749" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 7, "Harrison.Stracke@hotmail.com", "Annamae Mayert", "(431) 376-1741 x43346" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 14, "Toby.Herzog34@yahoo.com", "Sterling Murray", "1-653-977-7346" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Heath_Wolff@hotmail.com", "Emie Little", "1-847-550-7959" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 18, "Tiana.Gutmann3@hotmail.com", "Cristobal Schaden", "1-719-370-8158 x418" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Carlo67@hotmail.com", "Candido Pfeffer", "632-473-7206 x05302" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 18, "Alana46@hotmail.com", "Barry Kuhn", "1-801-523-1108 x49088" });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DealId", "PricePerUnit", "ProductId", "Quantity" },
                values: new object[] { 1, 41.0, 9, 22 });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PricePerUnit", "ProductId", "Quantity" },
                values: new object[] { 82.0, 4, 65 });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DealId", "PricePerUnit", "Quantity" },
                values: new object[] { 3, 84.0, 18 });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DealId", "PricePerUnit", "Quantity" },
                values: new object[] { 4, 54.0, 3 });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DealId", "ProductId", "Quantity" },
                values: new object[] { 5, 6, 86 });

            migrationBuilder.InsertData(
                table: "DealProducts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DealId", "ModifiedAt", "ModifiedBy", "PricePerUnit", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 6, null, null, 6, null, null, 77.0, 8, 33 },
                    { 7, null, null, 7, null, null, 16.0, 9, 7 },
                    { 8, null, null, 8, null, null, 39.0, 1, 9 },
                    { 9, null, null, 9, null, null, 62.0, 10, 41 },
                    { 10, null, null, 10, null, null, 84.0, 5, 71 },
                    { 11, null, null, 11, null, null, 61.0, 7, 48 },
                    { 12, null, null, 12, null, null, 76.0, 1, 68 },
                    { 13, null, null, 13, null, null, 13.0, 7, 19 },
                    { 14, null, null, 14, null, null, 65.0, 8, 37 },
                    { 15, null, null, 15, null, null, 31.0, 10, 25 },
                    { 16, null, null, 16, null, null, 31.0, 2, 8 },
                    { 17, null, null, 17, null, null, 25.0, 2, 35 },
                    { 18, null, null, 18, null, null, 52.0, 6, 25 },
                    { 19, null, null, 19, null, null, 53.0, 6, 52 },
                    { 20, null, null, 20, null, null, 27.0, 7, 51 },
                    { 21, null, null, 21, null, null, 40.0, 9, 91 },
                    { 22, null, null, 22, null, null, 34.0, 10, 28 },
                    { 23, null, null, 23, null, null, 23.0, 10, 39 },
                    { 24, null, null, 24, null, null, 20.0, 10, 4 },
                    { 25, null, null, 25, null, null, 15.0, 10, 36 },
                    { 26, null, null, 26, null, null, 78.0, 2, 7 },
                    { 27, null, null, 27, null, null, 92.0, 10, 76 },
                    { 28, null, null, 28, null, null, 92.0, 7, 92 },
                    { 29, null, null, 29, null, null, 50.0, 4, 52 },
                    { 30, null, null, 30, null, null, 63.0, 2, 49 }
                });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 161179.0, "Pariatur facere est occaecati quidem itaque eum et quia sint qui vero laborum provident dolorem laborum corrupti.", 1, "Quisquam ipsa repellat adipisci veritatis." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 55499.0, "Voluptatem pariatur suscipit et a doloremque rerum tenetur voluptates quo.", 1, "Numquam in dolor." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 188468.0, "Inventore molestias quia velit ex ut et officiis quo deleniti sint repellendus quidem magni sit quasi ut incidunt ab eum sit autem.", 1, "Nihil perferendis laboriosam quasi hic." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 84013.0, "Temporibus quasi quidem omnis optio consequatur voluptates impedit modi perferendis repellendus.", 2, "Illo et aut consequatur." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 40467.0, "Deleniti nemo consequatur recusandae vitae iusto minima est pariatur aliquam laudantium quis blanditiis amet voluptatibus inventore dolorem fugiat quidem et vitae eos laborum sit dolor consectetur.", "Qui laborum non." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 136262.0, "Possimus perspiciatis et quis nulla est aut qui voluptas ipsam.", 1, "Ut nobis voluptatem nobis excepturi." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 139236.0, "Et sint placeat est perspiciatis ipsum natus nam occaecati distinctio similique fuga.", "Pariatur molestiae facilis facere dolorum." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 72355.0, "Sint earum vitae numquam sit aut amet facere laboriosam accusamus sit minus enim illum quibusdam eveniet id eveniet corporis iusto sed quia soluta magni non qui aut voluptas cupiditate consequatur.", "Non sapiente cum necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 160633.0, "Est earum ipsum unde iusto eligendi qui quia incidunt omnis aliquid esse animi voluptatum consectetur quis aut repellendus a est est explicabo soluta aperiam accusamus expedita inventore.", 1, "Illum voluptatem quibusdam est." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 284467.0, "Ad sunt beatae sed dolores repellendus iusto et fugit id at molestiae ea dolor eaque dolores rem nihil et labore quas ex totam explicabo quidem assumenda ut sunt iusto maiores.", "At assumenda dolorum id quod aut." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 239201.0, "Nisi fugiat dolor aspernatur id sed voluptas fugiat suscipit nihil eos cumque provident ut iure neque est et atque quisquam suscipit.", 1, "Eaque hic enim." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 112769.0, "Odio et ea aliquam ut sint magni assumenda voluptatem voluptatem tempora pariatur harum voluptatem rerum recusandae sequi enim eos repellat adipisci nobis laudantium qui sit consequatur.", "Praesentium animi qui officia." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 69335.0, "Necessitatibus sequi laborum similique quo facere deserunt fugit rem soluta ex autem quia.", 1, "Alias sed explicabo nostrum atque." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 296244.0, "Aut autem vero illum doloribus numquam dicta sed sint ut.", 0, "Ducimus ut optio." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 126169.0, "Et iure dolores magnam enim ullam quaerat quia molestiae eligendi ad deserunt voluptatem blanditiis assumenda aut est voluptas.", "Sunt consequatur quia et cum." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 283942.0, "Officiis voluptatem magnam omnis vel recusandae molestiae voluptas et odio dolores voluptas.", "Est qui recusandae maiores enim." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 245767.0, "Quia rerum ut excepturi rem ut dignissimos est sunt et facilis possimus quae aperiam impedit qui.", 0, "Debitis suscipit voluptates." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 263815.0, "Et nihil reprehenderit aut minima minima debitis quis delectus amet sint autem aut quia et est deleniti error porro voluptatum enim est qui aliquid dolore et.", 1, "Aliquam eos est." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 435789.0, "Dolores earum provident facere autem culpa quia deserunt delectus sunt porro consequatur culpa nostrum esse.", 1, "Beatae distinctio ut ipsa." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 405586.0, "Et rerum fugiat deserunt magni qui quis fugit et neque dolorem et saepe magni provident ipsam corporis et suscipit voluptatem maiores distinctio minus repellat alias nemo harum.", "Quos et id eligendi saepe reiciendis." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 43678.0, "Expedita quia et laudantium ipsa eos culpa mollitia accusantium iste non eos ratione quia quam eum assumenda explicabo.", "Qui tempora ut." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 19455.0, "Reiciendis repellat ratione ratione hic ipsum reiciendis ad eius tempora natus sapiente ipsam officia quis nostrum est quidem saepe temporibus amet.", 1, "Ut dicta voluptatem." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 344170.0, "Quidem est ea dolorem explicabo aspernatur soluta nihil exercitationem ut voluptatem libero et quod eligendi asperiores fugit praesentium veritatis omnis nemo aut vero nesciunt sed perferendis facilis deserunt itaque.", "Quia perspiciatis voluptatem molestiae et molestiae." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 223740.0, "Commodi aut rerum ex officiis explicabo dolorem suscipit voluptas aliquid id ad voluptatem quaerat sed et.", 0, "Perferendis iusto omnis." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 416626.0, "Distinctio officiis quisquam sunt enim quasi rerum facere quas ab quo asperiores repellendus expedita laudantium officia deserunt saepe qui assumenda non voluptatibus.", "Rem est minima cum sunt." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 198643.0, "Provident hic sed laboriosam voluptatibus eveniet exercitationem libero omnis distinctio qui sit deleniti dolor ut et eos temporibus odio voluptatem sed aut corporis quaerat iure ducimus quo veniam.", 2, "Qui possimus est voluptatum." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 168191.0, "Assumenda officiis id consequatur nostrum sit eum saepe quidem omnis id quis laboriosam quaerat non distinctio est et corrupti perferendis voluptas tempore corrupti eum qui facere possimus rerum.", 0, "Eos possimus doloribus doloribus quod molestiae." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 12930.0, "Assumenda voluptate harum dolores optio qui vel et earum amet sunt ut alias velit occaecati ipsam.", "Ut repellat ratione nihil voluptas." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 61328.0, "Odio reprehenderit quia aut earum qui voluptatum non est error velit fuga quidem.", 2, "Qui odio occaecati." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 290561.0, "Itaque recusandae vel temporibus voluptatem ut beatae occaecati cumque alias necessitatibus iste eveniet deleniti eius minima libero corporis nostrum esse aut quia est aliquid quae.", 1, "Consequatur quod voluptas quasi." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 8, "Consequatur consequatur et vel aspernatur sequi est dicta quaerat incidunt ipsa dicta aperiam id omnis maxime.", new DateTime(2023, 2, 19, 4, 2, 25, 761, DateTimeKind.Local).AddTicks(2815), 7271.0, 1, "Eius delectus et sed aliquam cupiditate." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 9, "Quibusdam et rem est perferendis molestiae tempora iusto eos perferendis ut possimus ex est accusantium dolorem dolorum incidunt dolorem aut ut et aut praesentium et unde mollitia aut.", new DateTime(2022, 8, 13, 0, 38, 16, 674, DateTimeKind.Local).AddTicks(6630), 127513.0, 3, "Quia architecto et pariatur." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 13, "Dolores assumenda at aut qui veritatis commodi totam rerum consequatur sit explicabo omnis ut ea pariatur quaerat architecto facilis eum mollitia voluptatem rerum dolor animi omnis.", 339596.0, 3, "Aspernatur aperiam et explicabo." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 1, "In earum est omnis consequuntur ratione nemo aut iusto consequuntur modi tempore illum aliquam nulla voluptatum explicabo dolor.", new DateTime(2023, 2, 7, 10, 49, 0, 817, DateTimeKind.Local).AddTicks(3468), 57780.0, 2, 2, "Nihil accusamus magni ducimus." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 15, "Occaecati tempore ea sapiente vitae deleniti soluta nobis rerum corporis blanditiis.", 165518.0, 3, "Officia sit rerum qui quas modi." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { "Quo veniam labore soluta dolores sint delectus pariatur ut incidunt officiis maiores qui quia accusamus in est quae a iusto voluptas architecto aut facere nihil sit iusto dolorem dolore.", new DateTime(2023, 2, 1, 10, 26, 43, 686, DateTimeKind.Local).AddTicks(4908), 228805.0, 2, 2, "Recusandae accusantium dolores aliquid in." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 17, "Ad rerum error voluptates aperiam aut autem soluta optio impedit aut placeat quaerat nisi odit et est autem cupiditate omnis inventore non autem voluptas eligendi placeat omnis qui nisi.", "Numquam qui qui rerum tempora sed enim sed accusamus libero ut est labore in qui sit facilis.", 0, new DateTime(2022, 9, 27, 2, 35, 40, 165, DateTimeKind.Local).AddTicks(285), 107103.0, 2, 3, "Ratione ut magnam unde." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 9, "Velit ut saepe sapiente voluptates quo voluptates nihil qui est magni ab omnis vel quidem iure est et explicabo maiores sint itaque odit debitis.", new DateTime(2022, 10, 14, 12, 50, 55, 810, DateTimeKind.Local).AddTicks(9718), 78702.0, 2, "Commodi deleniti consequatur." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 14, "In et aut voluptate fuga et sint eum voluptatem qui sed commodi.", null, null, new DateTime(2023, 5, 22, 8, 8, 32, 142, DateTimeKind.Local).AddTicks(9637), 499648.0, 2, 2, "Libero illum quis." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 11, "Autem molestias sunt placeat nihil laboriosam excepturi quo et quia voluptate et nostrum sunt et quod dolore voluptates voluptas at reprehenderit et.", "Aut explicabo deserunt numquam a numquam expedita explicabo ducimus quibusdam impedit fugit asperiores qui corporis commodi et aut commodi.", 0, new DateTime(2022, 12, 1, 15, 43, 58, 752, DateTimeKind.Local).AddTicks(2379), 46493.0, 3, "Similique soluta accusamus exercitationem." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 15, "Aut illum quibusdam et ullam reiciendis qui sed ea ipsa.", 330556.0, 1, "Ut aut aliquid." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Title" },
                values: new object[] { 18, "Aut nulla ut sunt totam ipsam ducimus sunt quia provident quam nihil dicta quae ratione.", new DateTime(2023, 5, 14, 17, 0, 56, 327, DateTimeKind.Local).AddTicks(809), 499872.0, "Hic suscipit sint et." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 12, "Itaque ea earum itaque soluta nulla incidunt officia fuga culpa dolores non rerum illo inventore sint commodi dolorem eveniet consequuntur ducimus explicabo fugit in et.", 67855.0, 2, "Quod et quas tempore vel." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 1, "Temporibus voluptatem laborum voluptatem excepturi facilis autem ipsa enim beatae velit quas occaecati optio sapiente.", 40090.0, 4, "Quasi fuga quod." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 24, "Autem minima labore deleniti expedita qui amet qui mollitia consequatur exercitationem quasi culpa dolores qui aut et omnis dolor rerum culpa eos repellat quaerat similique molestiae id.", "Ipsam suscipit voluptas consequatur nulla error non quis adipisci mollitia rerum ut consequatur nesciunt ratione neque nihil earum.", 4, new DateTime(2023, 3, 15, 20, 36, 10, 85, DateTimeKind.Local).AddTicks(7607), 122399.0, 3, "Ratione ex ea." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 18, "Dolores accusantium velit ab adipisci mollitia porro doloremque dignissimos quis veniam accusamus quia est excepturi eos minima qui qui nostrum.", null, 183975.0, 2, 0, "Aut odio nihil commodi magni." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 13, "Expedita tempora aut nulla consequatur aperiam officia explicabo eligendi quis minus nostrum expedita officia distinctio dolorem totam beatae alias a cum.", 127728.0, 3, "Velit quia magnam." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 17, "Et esse voluptatem harum perspiciatis incidunt adipisci dolore iure ut quis qui sunt.", 65485.0, 2, "Incidunt similique laudantium qui ducimus odit." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 21, "Aut magnam quos eius sapiente et neque sed id aperiam labore earum voluptas velit deleniti aut sapiente debitis.", null, 445422.0, 2, 0, "Earum magni nemo aperiam qui id." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 24, "Quia enim aspernatur aliquid repellat aut nam qui deleniti quia illo assumenda consequatur iusto hic nam totam numquam ea quo nam repudiandae.", null, null, null, 244944.0, 4, 1, "Iusto eum quia id nisi." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 23, "Adipisci iure similique consequatur vel earum tenetur ut voluptatem nulla veniam sint sunt vel aut molestiae sit qui qui possimus quo assumenda non sed minus et incidunt.", "Laudantium corrupti accusamus non dolores eos quae facilis fuga nobis quia.", 1, new DateTime(2022, 7, 19, 7, 9, 31, 920, DateTimeKind.Local).AddTicks(4035), 16157.0, 3, "Incidunt odio animi earum voluptas architecto." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 7, "Non dolores vel ipsam modi molestiae est dicta ea aut quis et amet consequatur vero voluptas molestiae incidunt earum corrupti sit est dolores maxime in qui rerum rerum.", new DateTime(2022, 10, 5, 10, 6, 40, 616, DateTimeKind.Local).AddTicks(7846), 28106.0, 3, "Dignissimos hic unde." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 11, "Delectus quod nam esse id et iure ut qui velit illo sit fugit.", 142873.0, 4, 1, "Facilis voluptatem debitis." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 12, "Quia ipsam enim dolor voluptatibus cupiditate omnis voluptas et eveniet molestiae quasi quia dolor voluptatum et vel magni nisi adipisci dignissimos eum velit a illum.", 209850.0, 1, 0, "Aliquam minus excepturi velit non inventore." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 18, "Numquam modi iusto odio quam perferendis amet veniam eum saepe veniam delectus voluptatem culpa vel fugiat beatae ut excepturi iste nihil quod est et blanditiis nihil earum harum ipsam dolor.", null, 212725.0, 2, 1, "Aut et eligendi autem." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Title" },
                values: new object[] { 8, "Rerum et id ab non aut ipsum incidunt dolor est non quisquam.", 131792.0, "Qui ipsum sint molestiae consequatur." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 24, "Accusantium aut dolore delectus aut hic rerum quo et est a beatae itaque aut sit est dicta omnis rem quis ut asperiores mollitia neque non atque soluta facere magnam officiis.", new DateTime(2022, 9, 23, 6, 21, 25, 328, DateTimeKind.Local).AddTicks(9552), 318530.0, 0, 2, "Ratione animi ut." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 3, "Occaecati nihil similique quas dolor ratione aut illo rem accusamus aliquid voluptatibus et beatae consequuntur ut aliquid voluptatibus aut sed nesciunt occaecati cumque molestiae aut totam vero.", new DateTime(2022, 9, 3, 21, 24, 32, 579, DateTimeKind.Local).AddTicks(3042), 71674.0, 2, "Sint non culpa earum nihil placeat." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 25, "Consectetur aut necessitatibus sint voluptate aut dolore dolore quia quas hic id sit dicta placeat ut molestias sequi dolor magni nobis quos esse et.", new DateTime(2022, 8, 23, 6, 27, 5, 255, DateTimeKind.Local).AddTicks(5532), 256000.0, 0, 2, "Ex earum error." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 1, "Natus enim tempore consequatur hic hic molestiae sint rerum ipsam quo aliquid dolorum pariatur et at assumenda corporis.", null, null, new DateTime(2022, 12, 15, 17, 30, 22, 196, DateTimeKind.Local).AddTicks(8597), 149267.0, 2, 2, "Eum aut nulla reiciendis sequi dolor." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Incredible Cotton Cheese", 721.0, "PRO-54396333" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Tasty Frozen Ball", 882.0, "PRO-43607655" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Licensed Rubber Mouse", 655.0, "PRO-72478257" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Awesome Granite Pizza", 367.0, "PRO-31299558" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Incredible Wooden Bacon", 150.0, "PRO-67364893" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "Price", "ProductCode", "Type" },
                values: new object[] { "Licensed Soft Car", 294.0, "PRO-67572182", 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Price", "ProductCode", "Type" },
                values: new object[] { "Incredible Concrete Salad", 201.0, "PRO-79349574", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Generic Metal Hat", 869.0, "PRO-33897066" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Generic Steel Tuna", 26.0, "PRO-70991826" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "Price", "ProductCode", "Type" },
                values: new object[] { "Practical Soft Soap", 407.0, "PRO-43803163", 1 });
        }
    }
}
