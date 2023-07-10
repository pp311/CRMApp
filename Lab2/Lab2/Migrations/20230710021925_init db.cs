using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab2.Migrations
{
    /// <inheritdoc />
    public partial class initdb : Migration
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
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
                    EstimatedRevenue = table.Column<double>(type: "float", nullable: true),
                    EndedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DisqualifiedReason = table.Column<int>(type: "int", nullable: true),
                    DisqualifiedDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
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
                name: "Deals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    EstimatedRevenue = table.Column<double>(type: "float", nullable: true),
                    ActualRevenue = table.Column<double>(type: "float", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    LeadId = table.Column<int>(type: "int", nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deals_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deals_Leads_LeadId",
                        column: x => x.LeadId,
                        principalTable: "Leads",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DealProducts",
                columns: table => new
                {
                    DealId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    PricePerUnit = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealProducts", x => new { x.DealId, x.ProductId });
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
                    { 1, "4169 Eleonore Mountain, East Pierre, Saudi Arabia", null, null, "Danielle19@hotmail.com", null, null, "Johns, Robel and Cummerata", "387.439.0646 x6213", 13840.0 },
                    { 2, "612 Medhurst Vista, West Dewittland, Montenegro", null, null, "Pearline.Roberts17@yahoo.com", null, null, "Blick, Hirthe and Pagac", "1-670-617-2128 x268", 38902.0 },
                    { 3, "197 Tyler Divide, Austynbury, Kenya", null, null, "Bria55@gmail.com", null, null, "Rempel LLC", "312-483-9046 x5475", 16609.0 },
                    { 4, "628 Heidenreich Mountain, Katrinestad, Poland", null, null, "Garrison.Von68@yahoo.com", null, null, "Roberts Inc", "458.612.2699", 24548.0 },
                    { 5, "069 Schmidt Courts, New Raven, South Georgia and the South Sandwich Islands", null, null, "Albin.Bode@gmail.com", null, null, "Murazik - Waelchi", "(851) 809-8161", 41978.0 },
                    { 6, "5816 Armstrong Ridge, East Randall, Monaco", null, null, "Asa.Crooks@gmail.com", null, null, "Glover LLC", "530-970-5244 x603", 2152.0 },
                    { 7, "294 Alvis Extension, Lowestad, French Polynesia", null, null, "Tamia_Ledner@hotmail.com", null, null, "Schumm and Sons", "(784) 218-5341 x2535", 47389.0 },
                    { 8, "278 Royal Plains, North Matilde, Suriname", null, null, "Myra.Bartoletti@hotmail.com", null, null, "McClure LLC", "1-832-750-4740 x480", 37179.0 },
                    { 9, "769 Cruickshank Hills, Port Dayton, Cocos (Keeling) Islands", null, null, "Monty_Russel28@gmail.com", null, null, "Romaguera - Purdy", "403-726-5682 x6818", 49149.0 },
                    { 10, "65057 Luigi Divide, West Korbin, Republic of Korea", null, null, "Houston33@hotmail.com", null, null, "Volkman, Swaniawski and Weissnat", "502.721.8050 x36203", 44544.0 },
                    { 11, "80640 Gretchen Manor, Pfefferhaven, Saint Barthelemy", null, null, "Bridie_Schmidt@hotmail.com", null, null, "Marvin, Gleichner and Schowalter", "1-660-447-0892 x4442", 34212.0 },
                    { 12, "1456 Hegmann Walk, Lindgrenchester, Liechtenstein", null, null, "Antoinette12@yahoo.com", null, null, "Muller, Runolfsson and Ward", "(905) 728-5495", 1723.0 },
                    { 13, "044 Susana Estates, Arnulfofurt, Gambia", null, null, "Estrella_Lockman@hotmail.com", null, null, "Kassulke - Emard", "1-401-833-9533", 28732.0 },
                    { 14, "761 Bogan Drives, New Mayraport, Liberia", null, null, "Renee.Lemke14@hotmail.com", null, null, "Swaniawski - Harvey", "712-806-1712 x9793", 43924.0 },
                    { 15, "605 Paolo Pike, Lake Autumnview, Somalia", null, null, "Gladys59@hotmail.com", null, null, "Schultz - Weissnat", "901-732-7071 x629", 45943.0 },
                    { 16, "537 Rocky Place, Biankashire, Saint Helena", null, null, "Eldon39@gmail.com", null, null, "Hintz - Streich", "552.618.8946 x416", 10790.0 },
                    { 17, "01054 Alvera Stream, South Reymundoport, Central African Republic", null, null, "Johanna_Sporer@gmail.com", null, null, "Barton - Huels", "1-718-952-8996 x4944", 3400.0 },
                    { 18, "5992 Murazik Locks, Ornmouth, Equatorial Guinea", null, null, "Greg_Wintheiser9@gmail.com", null, null, "Keebler, Considine and Stamm", "1-617-585-6143", 45016.0 },
                    { 19, "5904 Ida Forge, North Thad, Christmas Island", null, null, "Flo_Ward8@hotmail.com", null, null, "Kemmer, Boehm and Kuvalis", "822.426.1124 x4167", 6891.0 },
                    { 20, "9397 Buckridge Shoal, East Hanna, Madagascar", null, null, "Arne_Ruecker53@gmail.com", null, null, "Bailey - Sawayn", "575.384.0111", 32256.0 },
                    { 21, "548 Reichel Knolls, North Leliastad, United Arab Emirates", null, null, "Emie40@gmail.com", null, null, "Senger, Ebert and Witting", "(747) 287-8002", 10586.0 },
                    { 22, "2418 Grady Stravenue, South Paula, Gambia", null, null, "Elta_OKon@gmail.com", null, null, "Huels - Herman", "292-720-3403 x535", 33378.0 },
                    { 23, "24208 Jaquelin Lake, West Horaciotown, Hong Kong", null, null, "Alisa30@hotmail.com", null, null, "Reilly - Strosin", "694-410-2816 x529", 8248.0 },
                    { 24, "3813 Patricia Coves, East Ryleighview, Sri Lanka", null, null, "Broderick.Murazik@hotmail.com", null, null, "Blanda - Mohr", "313.845.8473 x9986", 45735.0 },
                    { 25, "148 Bert Islands, Trompview, Bulgaria", null, null, "Marc34@hotmail.com", null, null, "Lang, Aufderhar and Strosin", "815.874.1087 x25972", 2354.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsAvailable", "ModifiedAt", "ModifiedBy", "Name", "Price", "ProductCode", "Type" },
                values: new object[,]
                {
                    { 1, null, null, true, null, null, "Intelligent Wooden Gloves", 867.0, "PRO-85750524", 0 },
                    { 2, null, null, true, null, null, "Generic Concrete Sausages", 845.0, "PRO-26533506", 0 },
                    { 3, null, null, true, null, null, "Incredible Plastic Hat", 262.0, "PRO-70223514", 1 },
                    { 4, null, null, true, null, null, "Unbranded Granite Computer", 795.0, "PRO-82074425", 0 },
                    { 5, null, null, true, null, null, "Sleek Concrete Shirt", 270.0, "PRO-56644197", 0 },
                    { 6, null, null, true, null, null, "Generic Fresh Mouse", 423.0, "PRO-14090752", 0 },
                    { 7, null, null, true, null, null, "Incredible Fresh Towels", 203.0, "PRO-97874652", 1 },
                    { 8, null, null, true, null, null, "Sleek Concrete Fish", 49.0, "PRO-06030049", 1 },
                    { 9, null, null, true, null, null, "Gorgeous Concrete Keyboard", 801.0, "PRO-01271973", 1 },
                    { 10, null, null, true, null, null, "Handmade Granite Fish", 708.0, "PRO-06805166", 1 }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "AccountId", "CreatedAt", "CreatedBy", "Email", "ModifiedAt", "ModifiedBy", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, 22, null, null, "Alaina.Hessel51@yahoo.com", null, null, "Velva Schoen", "1-974-293-8511" },
                    { 2, 21, null, null, "Alysha_Anderson52@hotmail.com", null, null, "Oma Spinka", "1-564-691-1982 x756" },
                    { 3, 4, null, null, "Tyrel.Rohan1@yahoo.com", null, null, "Amari Ward", "678-222-4168 x868" },
                    { 4, 13, null, null, "Alice74@gmail.com", null, null, "Floyd Heidenreich", "(214) 816-9264 x06563" },
                    { 5, 11, null, null, "Otto_Hessel@yahoo.com", null, null, "Veronica Emard", "609-614-3134 x91144" },
                    { 6, 17, null, null, "Aileen.Dach@yahoo.com", null, null, "Joanny Simonis", "587.813.3721" },
                    { 7, 9, null, null, "Misael.Anderson@gmail.com", null, null, "Ernestina Bashirian", "1-518-818-2707" },
                    { 8, 4, null, null, "Willy.Connelly52@yahoo.com", null, null, "Mariela VonRueden", "334.597.8729 x882" },
                    { 9, 4, null, null, "Reyes59@yahoo.com", null, null, "Boris Schiller", "(302) 245-0081 x03258" },
                    { 10, 10, null, null, "Mose.Predovic71@gmail.com", null, null, "Marlen Crooks", "1-701-439-2029" },
                    { 11, 2, null, null, "Juanita_Schneider@yahoo.com", null, null, "Bud Gleichner", "916-455-2105 x283" },
                    { 12, 14, null, null, "Tia47@gmail.com", null, null, "Charley Dickinson", "724.596.0066" },
                    { 13, 14, null, null, "Loraine_Fahey@hotmail.com", null, null, "Kelsie Lind", "(584) 871-9397 x6848" },
                    { 14, 22, null, null, "Rozella61@hotmail.com", null, null, "June Hills", "649-582-0407" },
                    { 15, 19, null, null, "Michel.Casper@hotmail.com", null, null, "Anderson Schamberger", "1-306-743-0459" },
                    { 16, 25, null, null, "Madisyn.Frami51@yahoo.com", null, null, "Kallie Langworth", "(481) 604-7765 x6311" },
                    { 17, 22, null, null, "Isabel_Watsica@yahoo.com", null, null, "Heber Stiedemann", "280-855-2915 x1282" },
                    { 18, 6, null, null, "Darien.Moore@gmail.com", null, null, "Branson Cummerata", "1-890-631-3015 x621" },
                    { 19, 5, null, null, "Dariana_Jones83@hotmail.com", null, null, "Viva Strosin", "1-533-612-7889" },
                    { 20, 25, null, null, "Dewayne.Stark40@gmail.com", null, null, "Davin MacGyver", "1-380-722-2310" },
                    { 21, 22, null, null, "Brent.Rowe61@yahoo.com", null, null, "Matilde Mills", "(771) 249-2018" },
                    { 22, 3, null, null, "Aric66@hotmail.com", null, null, "Nathen Kassulke", "281-533-1159 x1394" },
                    { 23, 16, null, null, "Tia.Turner21@yahoo.com", null, null, "Anna Orn", "(723) 563-5143" },
                    { 24, 11, null, null, "Olga87@yahoo.com", null, null, "Marina Ortiz", "(850) 240-2372 x2521" },
                    { 25, 24, null, null, "Arnulfo_Abshire80@gmail.com", null, null, "Eddie White", "(671) 506-4788 x72842" },
                    { 26, 20, null, null, "Cecil.Waters21@yahoo.com", null, null, "Abdullah Frami", "732-674-0268 x1265" },
                    { 27, 10, null, null, "Nicole.Murphy@yahoo.com", null, null, "Earline Batz", "330-313-3663" },
                    { 28, 25, null, null, "Audreanne52@gmail.com", null, null, "Emil Reynolds", "536.404.0073" },
                    { 29, 16, null, null, "Kaden.Johnson@hotmail.com", null, null, "Ona Harber", "(310) 331-0815 x8839" },
                    { 30, 25, null, null, "Rudy_Klein49@hotmail.com", null, null, "Reinhold O'Kon", "398.548.1173 x675" },
                    { 31, 12, null, null, "Dakota.Dibbert@yahoo.com", null, null, "Marcellus Tromp", "1-375-544-2525" },
                    { 32, 13, null, null, "Dante.Lindgren17@gmail.com", null, null, "Alexandra Moore", "(804) 323-2056 x02353" },
                    { 33, 13, null, null, "Joelle_Mueller92@gmail.com", null, null, "Rhett Klocko", "1-839-285-3583 x6578" },
                    { 34, 22, null, null, "Eladio_Hermann14@yahoo.com", null, null, "Elouise Hauck", "454-509-6595" },
                    { 35, 10, null, null, "Celestino_Langosh@yahoo.com", null, null, "Ibrahim Bartell", "(338) 593-4217" },
                    { 36, 17, null, null, "Easton16@gmail.com", null, null, "Dante Conn", "885-413-5282" },
                    { 37, 11, null, null, "Reginald_Cronin48@gmail.com", null, null, "Agustin Hintz", "345.770.1441 x0898" },
                    { 38, 11, null, null, "Jorge79@yahoo.com", null, null, "Rae Schultz", "219-984-2874 x1650" },
                    { 39, 1, null, null, "Columbus.Nitzsche37@hotmail.com", null, null, "Sadie Morissette", "(753) 492-6801" },
                    { 40, 15, null, null, "Brent.Boyer@gmail.com", null, null, "Major Cartwright", "1-214-591-9995" },
                    { 41, 11, null, null, "Leanne.Sipes@hotmail.com", null, null, "Beulah Harris", "906.276.6959" },
                    { 42, 13, null, null, "Logan_King@hotmail.com", null, null, "Melyssa Vandervort", "(692) 809-0625" },
                    { 43, 13, null, null, "Ardith6@gmail.com", null, null, "Mossie Bogisich", "(953) 474-7859 x42408" },
                    { 44, 20, null, null, "Tamia78@hotmail.com", null, null, "Alaina Lubowitz", "607-414-4145" },
                    { 45, 12, null, null, "Maiya28@hotmail.com", null, null, "Zackary Sporer", "1-408-961-6727 x3226" },
                    { 46, 16, null, null, "Krystina.Braun@gmail.com", null, null, "Timmothy Marquardt", "946.582.0469 x62622" },
                    { 47, 19, null, null, "Forest_Beer@yahoo.com", null, null, "Noble Breitenberg", "309.603.3075 x4594" },
                    { 48, 7, null, null, "Alycia.Lesch25@yahoo.com", null, null, "Mckenna Schumm", "633.791.7460 x914" },
                    { 49, 13, null, null, "Laurie_McClure@hotmail.com", null, null, "Sophie Hand", "815-319-6347 x552" },
                    { 50, 1, null, null, "Emerson_Fadel@gmail.com", null, null, "Gudrun Ledner", "414-611-0683 x280" },
                    { 51, 15, null, null, "Aurelia5@hotmail.com", null, null, "Dell Yundt", "1-873-919-2911 x57926" },
                    { 52, 3, null, null, "Brandon_Hintz@hotmail.com", null, null, "Brianne Hoppe", "1-925-568-4208 x5146" },
                    { 53, 17, null, null, "Graciela_Muller@gmail.com", null, null, "Marcia Schimmel", "771-693-2519 x770" },
                    { 54, 8, null, null, "Jamey_Hermann@gmail.com", null, null, "Cindy Prosacco", "411-391-0883 x846" },
                    { 55, 24, null, null, "Denis.McDermott2@yahoo.com", null, null, "Cary Wuckert", "1-893-917-2705" },
                    { 56, 22, null, null, "Rachelle73@gmail.com", null, null, "Delmer Howe", "(578) 948-7323 x82003" },
                    { 57, 11, null, null, "Pamela10@gmail.com", null, null, "Paul Kiehn", "(683) 520-6712" },
                    { 58, 25, null, null, "Patsy90@yahoo.com", null, null, "Loyce Wiza", "792-645-3328 x271" },
                    { 59, 25, null, null, "Elwin_Hintz@gmail.com", null, null, "Leopold Flatley", "(853) 360-4000 x549" },
                    { 60, 1, null, null, "Matteo68@gmail.com", null, null, "Mariam Strosin", "690.935.6875" },
                    { 61, 11, null, null, "Donato_Haag32@gmail.com", null, null, "Donny Streich", "528.396.6219" },
                    { 62, 4, null, null, "Aubrey93@yahoo.com", null, null, "Shany Wintheiser", "750-531-9676 x2868" },
                    { 63, 11, null, null, "Crystel_Jacobs@hotmail.com", null, null, "Chester Stracke", "913-342-6386" },
                    { 64, 15, null, null, "Stanton_Doyle34@hotmail.com", null, null, "Kallie Feeney", "(805) 349-5842" },
                    { 65, 10, null, null, "Dean_Bailey@gmail.com", null, null, "Kennedy Lesch", "1-482-906-8890 x270" },
                    { 66, 9, null, null, "Isaac_Hilpert@hotmail.com", null, null, "Dante Roob", "(850) 965-5439" },
                    { 67, 17, null, null, "Leland_Walsh@hotmail.com", null, null, "Nannie Abbott", "1-999-626-2412 x85060" },
                    { 68, 15, null, null, "Kathlyn_Bahringer4@yahoo.com", null, null, "Bailey Hessel", "362-612-5184" },
                    { 69, 19, null, null, "Tyrel_Labadie@gmail.com", null, null, "Mayra Osinski", "574.490.0790" },
                    { 70, 5, null, null, "Tavares72@hotmail.com", null, null, "Conner Heathcote", "732-327-6591" },
                    { 71, 16, null, null, "Foster.Reinger@yahoo.com", null, null, "Shania VonRueden", "642-224-2639 x2672" },
                    { 72, 10, null, null, "Liliana39@gmail.com", null, null, "Myrtice Hagenes", "(965) 966-6534" },
                    { 73, 18, null, null, "Toy_Corkery@hotmail.com", null, null, "Addie Funk", "(600) 803-2782 x1118" },
                    { 74, 14, null, null, "Sam25@yahoo.com", null, null, "Rachelle Murphy", "249.819.7058 x09104" },
                    { 75, 21, null, null, "Lowell_Walter@hotmail.com", null, null, "Ricky Hamill", "820.582.0570" },
                    { 76, 11, null, null, "Bernice5@gmail.com", null, null, "Eldon Rolfson", "808-596-9316 x91864" },
                    { 77, 25, null, null, "Aliza.Bayer@gmail.com", null, null, "Jarrett Thompson", "1-645-451-8679 x67433" },
                    { 78, 20, null, null, "Reginald_McLaughlin@gmail.com", null, null, "John Luettgen", "466-720-2809 x52238" },
                    { 79, 3, null, null, "Antonietta.Hartmann10@hotmail.com", null, null, "Elliott O'Connell", "220.428.3774" },
                    { 80, 3, null, null, "Keshawn58@yahoo.com", null, null, "Tiffany Jerde", "586-469-9097" },
                    { 81, 16, null, null, "Myron.Marvin@hotmail.com", null, null, "Eldon Rice", "288.681.2548" },
                    { 82, 3, null, null, "Lessie45@hotmail.com", null, null, "Ima Shields", "569-503-9658 x8120" },
                    { 83, 11, null, null, "Weldon98@hotmail.com", null, null, "Kaelyn Buckridge", "447.826.4382 x094" },
                    { 84, 12, null, null, "Mitchel_Kunze@hotmail.com", null, null, "Alycia Keeling", "(664) 264-2085" },
                    { 85, 8, null, null, "Julien87@hotmail.com", null, null, "Marquise Frami", "1-877-871-4154" },
                    { 86, 18, null, null, "Krystal4@hotmail.com", null, null, "Jon Gibson", "294-277-6287 x534" },
                    { 87, 20, null, null, "Minerva.Schuster@gmail.com", null, null, "Sabrina Hilll", "(285) 213-8725" },
                    { 88, 1, null, null, "Anabelle_Macejkovic@yahoo.com", null, null, "Anastacio Turner", "477.635.4983" },
                    { 89, 17, null, null, "Jadyn67@yahoo.com", null, null, "Carmella Miller", "782-812-6577" },
                    { 90, 16, null, null, "Bennie51@gmail.com", null, null, "Clinton Turner", "862.576.9490" },
                    { 91, 16, null, null, "Caesar30@gmail.com", null, null, "Kaia Leuschke", "453-869-6133" },
                    { 92, 12, null, null, "Thalia_Schultz37@yahoo.com", null, null, "Coleman Hessel", "1-203-385-9197 x74625" },
                    { 93, 7, null, null, "Herta91@hotmail.com", null, null, "Benton Stark", "217-818-0375 x793" },
                    { 94, 7, null, null, "Stefan.Hammes@hotmail.com", null, null, "Theresia Gerhold", "1-344-225-8323" },
                    { 95, 21, null, null, "Simone53@gmail.com", null, null, "Carley Lubowitz", "1-426-316-9448" },
                    { 96, 15, null, null, "Darrel.Ruecker26@yahoo.com", null, null, "Albin Cruickshank", "396.706.8115 x0897" },
                    { 97, 25, null, null, "Sven_Kilback@gmail.com", null, null, "Maximo Osinski", "(233) 561-9583" },
                    { 98, 23, null, null, "Ova69@hotmail.com", null, null, "Tamia Tremblay", "544-414-7887 x253" },
                    { 99, 20, null, null, "Bertram71@hotmail.com", null, null, "Felicity Funk", "1-981-482-8404" },
                    { 100, 10, null, null, "Clementine.Hickle@gmail.com", null, null, "London Grady", "1-896-560-5285" }
                });

            migrationBuilder.InsertData(
                table: "Leads",
                columns: new[] { "Id", "AccountId", "CreatedAt", "CreatedBy", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "ModifiedAt", "ModifiedBy", "Source", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 7, null, null, "Est nulla voluptate quibusdam neque vel amet quia et in eveniet dolorum quo voluptas tenetur quis est quos corrupti ipsa et ut et vero ea doloremque tempore.", null, null, null, 345562.0, null, null, 2, 0, "Voluptas est ut ullam laudantium." },
                    { 2, 10, null, null, "Qui voluptatem explicabo excepturi fugit dolorum eos rem unde repudiandae nobis quo voluptatem excepturi quasi porro sed fuga sint quia ipsum modi voluptatem qui facere excepturi veniam aut voluptatibus aliquam.", null, null, null, 126578.0, null, null, 4, 1, "Eius qui accusamus veritatis aliquam culpa." },
                    { 3, 22, null, null, "Impedit laudantium ipsam illo molestiae ratione maiores eos labore soluta consequatur voluptatem ratione voluptatem corporis rerum et perspiciatis dolore.", null, null, null, 174097.0, null, null, 4, 1, "Omnis et aliquid voluptas." },
                    { 4, 13, null, null, "Tempore aut praesentium dolor sapiente exercitationem et nam cupiditate nobis fugiat at sit quia distinctio quae autem adipisci esse ad adipisci voluptas.", null, null, null, 187381.0, null, null, 1, 0, "Facere temporibus fugiat sapiente corrupti sed." },
                    { 5, 24, null, null, "Saepe mollitia nemo sequi molestiae qui expedita exercitationem laborum recusandae et sint dolore quasi eum.", null, null, null, 280718.0, null, null, 4, 0, "Voluptatem dolores et." },
                    { 6, 9, null, null, "Numquam reiciendis vel molestiae quia amet voluptates repudiandae voluptatibus similique aperiam nihil saepe dolorem magni repudiandae nobis at rem illum quia unde impedit at sint delectus.", null, null, null, 80522.0, null, null, 3, 0, "Aliquam et minima odio omnis." },
                    { 7, 12, null, null, "Nostrum praesentium numquam necessitatibus numquam numquam dolor accusantium sunt quo sint non eum incidunt.", null, null, null, 160827.0, null, null, 3, 0, "Voluptas incidunt ut et." },
                    { 8, 15, null, null, "Est sed ea eligendi est voluptatem temporibus cumque repellat nisi doloribus sit voluptatum aut cupiditate natus in laboriosam quaerat quia ullam fuga cum omnis expedita sed cum.", "Vel sed nihil quia ex itaque est est placeat quia labore aspernatur alias ut hic consequatur cumque harum ducimus eum fugiat aliquam tempore.", 3, new DateTime(2022, 12, 14, 18, 20, 2, 479, DateTimeKind.Local).AddTicks(4936), 382925.0, null, null, 2, 3, "Cum alias officiis iure iste deserunt." },
                    { 9, 17, null, null, "Animi illo assumenda molestias dicta minus et quia quo esse consequatur aperiam ipsa velit quis doloribus adipisci est.", null, null, new DateTime(2023, 7, 7, 6, 19, 25, 176, DateTimeKind.Local).AddTicks(3847), 175591.0, null, null, 4, 2, "Autem labore aut soluta." },
                    { 10, 18, null, null, "Quam aut et nam dolor sed magnam amet voluptates non doloremque et ducimus odio dolorum fuga quas pariatur qui et aut.", null, null, null, 249438.0, null, null, 1, 1, "Vel dicta perspiciatis ipsa qui." },
                    { 11, 14, null, null, "Commodi est nobis non tempora sint nulla dolorem provident maiores minima sed unde ut.", "Quo ipsum fugiat deleniti accusamus commodi aperiam quia nihil illo occaecati quia dolorem.", 1, new DateTime(2022, 8, 29, 15, 5, 14, 463, DateTimeKind.Local).AddTicks(4552), 214492.0, null, null, 3, 3, "Id aspernatur inventore beatae." },
                    { 12, 19, null, null, "Et non enim optio ut consequatur voluptatem quia dolore perspiciatis sint id temporibus fugit perspiciatis deserunt beatae maxime ratione aut voluptatibus rerum omnis placeat est voluptas aperiam.", null, null, new DateTime(2022, 12, 5, 6, 40, 39, 339, DateTimeKind.Local).AddTicks(6692), 27986.0, null, null, 2, 2, "Recusandae optio aspernatur animi." },
                    { 13, 11, null, null, "Ipsam ab repellat rerum numquam sequi est labore quia repudiandae ex incidunt iusto molestiae accusamus repudiandae quidem possimus non provident laborum et dolorem a neque dolore veniam delectus.", "Accusamus enim tenetur omnis voluptas sint possimus eligendi sunt rerum assumenda ea provident qui esse consequuntur.", 0, new DateTime(2022, 9, 14, 7, 3, 47, 714, DateTimeKind.Local).AddTicks(1053), 365394.0, null, null, 4, 3, "Qui cum perferendis quia non." },
                    { 14, 8, null, null, "Reprehenderit assumenda vitae totam veniam non molestiae sit reprehenderit quo placeat ut id blanditiis nostrum tempora qui libero neque.", null, null, null, 222861.0, null, null, 3, 0, "Odit qui magnam cum aut." },
                    { 15, 24, null, null, "Et fuga laudantium aut id repellendus quia consequatur ut ipsam aliquam harum impedit non at fugiat quasi tempore rerum veritatis reiciendis quibusdam numquam accusamus.", null, null, null, 374357.0, null, null, 1, 0, "Dignissimos neque quidem reiciendis blanditiis aperiam." },
                    { 16, 25, null, null, "In ab qui dolorum tenetur et eum dolores magnam ab aut minima alias repellendus tenetur consequuntur aliquam non ipsam omnis porro voluptatem libero quia impedit quo dolores quos.", null, null, null, 474719.0, null, null, 4, 0, "Veniam dolorum cumque velit." },
                    { 17, 15, null, null, "Architecto velit aut odio commodi accusantium voluptas et eum vel cupiditate.", null, null, null, 292498.0, null, null, 3, 0, "Nulla laborum non laboriosam." },
                    { 18, 23, null, null, "Nostrum mollitia in molestiae exercitationem ut eos velit consequatur libero quia nostrum voluptatem sed beatae dignissimos et eum labore est explicabo aspernatur omnis et eius dolore natus.", null, null, new DateTime(2022, 8, 13, 4, 32, 39, 96, DateTimeKind.Local).AddTicks(4059), 312101.0, null, null, 1, 2, "Quaerat consequuntur eveniet vel veniam." },
                    { 19, 2, null, null, "Amet excepturi laboriosam natus natus provident illo est ut et et accusamus doloribus ea cum molestias eum perferendis voluptas amet sit quod.", null, null, null, 256414.0, null, null, 0, 1, "Ut ut labore." },
                    { 20, 12, null, null, "Autem consequatur incidunt ut et enim eaque similique asperiores illo sapiente commodi dolorem voluptas sapiente mollitia perferendis in enim tempora voluptatum aut accusantium sequi recusandae dolor ea soluta asperiores in.", null, null, null, 84418.0, null, null, 0, 0, "Quia architecto doloremque quaerat unde." },
                    { 21, 24, null, null, "Sunt nostrum magnam minus eum est vitae provident laboriosam eaque a repellendus voluptas perferendis dolor est cupiditate.", "Molestiae nam quia tempora debitis architecto veniam voluptatem cumque consequatur pariatur consequuntur temporibus velit dicta sint.", 3, new DateTime(2022, 11, 13, 5, 49, 35, 285, DateTimeKind.Local).AddTicks(5834), 87720.0, null, null, 3, 3, "Vel qui distinctio quae." },
                    { 22, 20, null, null, "Suscipit et veritatis aliquam officiis placeat consequatur sed dolores officiis delectus enim magni praesentium dolorem voluptates laudantium tempore voluptate quam ut laudantium.", null, null, null, 121248.0, null, null, 3, 1, "Iste error perferendis cupiditate." },
                    { 23, 15, null, null, "Iure odit impedit ad quam quis deserunt dolorum aut enim nostrum sed aut quisquam.", null, null, null, 479344.0, null, null, 4, 1, "Velit voluptatem perferendis ea." },
                    { 24, 9, null, null, "Voluptatem laudantium recusandae veniam rerum et ut accusantium perferendis perferendis.", "Eius possimus error qui autem animi quis tenetur distinctio natus ut recusandae perspiciatis est minus quos et aut.", 2, new DateTime(2022, 12, 11, 22, 20, 5, 101, DateTimeKind.Local).AddTicks(6901), 340144.0, null, null, 1, 3, "Omnis ea et." },
                    { 25, 20, null, null, "Qui doloribus beatae porro dolores nostrum sunt voluptas dignissimos quod nostrum provident est sequi animi quam delectus qui at aliquam asperiores enim.", null, null, null, 379648.0, null, null, 2, 1, "Totam et sed voluptas." },
                    { 26, 14, null, null, "Ea eveniet voluptatum similique consequatur vel quod error et qui in voluptatem voluptate qui rem aliquid aut et sequi doloremque praesentium eius ea dolor voluptatibus.", null, null, null, 16360.0, null, null, 1, 0, "Ut aperiam in." },
                    { 27, 21, null, null, "Non aliquid sit nisi iusto ut eligendi impedit unde repellat eum eos et.", "Quia voluptate dolor beatae et voluptatem et consequatur necessitatibus iure rem et occaecati temporibus a incidunt officiis enim totam.", 1, new DateTime(2022, 9, 13, 17, 2, 33, 735, DateTimeKind.Local).AddTicks(4310), 191042.0, null, null, 3, 3, "Unde provident at doloribus harum ipsa." },
                    { 28, 5, null, null, "Doloremque iure et non porro consequatur debitis perspiciatis omnis assumenda esse est ut deserunt eveniet qui aut voluptatibus repellendus.", null, null, null, 486346.0, null, null, 4, 1, "Placeat aspernatur quis et repudiandae." },
                    { 29, 15, null, null, "Rerum alias doloremque culpa maxime sequi sed molestiae aspernatur officiis et sint atque in est optio.", null, null, null, 408533.0, null, null, 3, 1, "Non delectus exercitationem suscipit ut." },
                    { 30, 9, null, null, "Id eos sunt adipisci et corporis voluptas nam iusto expedita soluta consequatur dolorum non aspernatur non officiis numquam delectus velit laboriosam omnis maxime molestias voluptates voluptatem delectus sit.", "Veniam qui necessitatibus quas enim sequi quas fugit nostrum id consequatur in molestias aut qui natus maiores tempore rerum nisi ut quae sequi ea.", 4, new DateTime(2022, 10, 21, 21, 48, 28, 966, DateTimeKind.Local).AddTicks(7454), 475916.0, null, null, 3, 3, "Nihil quo libero consequuntur aut." },
                    { 31, 12, null, null, "Dolor quidem quo nobis velit vero sapiente consequatur autem distinctio quia sapiente a sapiente eum repellat autem.", null, null, null, 434531.0, null, null, 4, 0, "Laborum magnam aut." },
                    { 32, 3, null, null, "Neque sit ut in velit facere unde optio eligendi eveniet aut et omnis quis dolor consequatur id expedita adipisci voluptas ducimus quia eaque aut hic similique qui officiis rerum dolores.", null, null, new DateTime(2022, 11, 21, 8, 10, 44, 366, DateTimeKind.Local).AddTicks(9579), 25759.0, null, null, 0, 2, "Vitae mollitia et placeat ad qui." },
                    { 33, 17, null, null, "Dolores qui sed dolores aut occaecati provident doloribus odio voluptatem consequatur praesentium doloribus provident molestias sunt ad totam velit a rem ratione atque iure deserunt ab fuga itaque possimus.", null, null, new DateTime(2023, 6, 12, 10, 11, 52, 224, DateTimeKind.Local).AddTicks(5627), 30656.0, null, null, 3, 2, "Ea repudiandae reiciendis animi accusamus molestias." },
                    { 34, 13, null, null, "Sed consequatur cumque laudantium saepe sunt magnam nam exercitationem eum voluptatem dignissimos quasi nam cupiditate similique odit incidunt culpa.", "Voluptas laborum corrupti animi ducimus et vitae aut nulla et dolores consequatur accusantium tempore aut sequi velit nisi velit neque.", 4, new DateTime(2023, 3, 1, 5, 51, 32, 409, DateTimeKind.Local).AddTicks(2626), 113950.0, null, null, 0, 3, "Odio vitae dolor." },
                    { 35, 4, null, null, "Quia est culpa culpa et dolore libero voluptatem hic porro nam officia accusantium labore.", null, null, new DateTime(2022, 10, 13, 12, 29, 48, 354, DateTimeKind.Local).AddTicks(8085), 282632.0, null, null, 2, 2, "Velit ipsum eos eum quae fugit." },
                    { 36, 4, null, null, "Non quibusdam est dolores odit nobis eum quia accusantium odit maiores labore aut et commodi rerum a inventore qui deserunt numquam delectus quo nesciunt eum.", null, null, new DateTime(2023, 1, 18, 9, 17, 52, 260, DateTimeKind.Local).AddTicks(6428), 5689.0, null, null, 2, 2, "Illum necessitatibus consequatur omnis omnis." },
                    { 37, 24, null, null, "Consequatur veniam at fugiat et et repellat et dicta ut voluptatum ut et fugit.", null, null, new DateTime(2023, 2, 23, 4, 2, 18, 774, DateTimeKind.Local).AddTicks(7158), 184743.0, null, null, 2, 2, "Ipsa officia ratione molestiae." },
                    { 38, 7, null, null, "Sunt cupiditate et tempora aliquid voluptas pariatur possimus ullam cum provident aspernatur ut asperiores consequatur nisi nisi.", null, null, null, 211430.0, null, null, 1, 0, "Quae id excepturi voluptatem quasi esse." },
                    { 39, 9, null, null, "Repudiandae rem et non aut dolor earum sed consequatur non quasi alias maxime atque aut omnis impedit dolores autem nihil.", "Sit deserunt excepturi id totam ad mollitia dolore consequuntur ratione odit nemo voluptatem fuga iusto aliquam et mollitia corporis aut consequatur quod quos ut iste dolor.", 4, new DateTime(2023, 4, 11, 13, 48, 28, 94, DateTimeKind.Local).AddTicks(5496), 321685.0, null, null, 0, 3, "Pariatur veniam eum accusamus ipsam." },
                    { 40, 2, null, null, "Culpa ut ipsa maiores reiciendis et ullam veniam recusandae perspiciatis necessitatibus sapiente incidunt optio consequatur.", null, null, null, 324661.0, null, null, 0, 0, "Qui tempora sint ut omnis." },
                    { 41, 15, null, null, "Ratione sed explicabo minima veritatis laborum voluptatem non perspiciatis sit ab quas consectetur ullam.", "Enim consequatur consequuntur et nemo laborum sint laudantium alias rerum dolor cupiditate laborum dolorum assumenda earum cum veniam a necessitatibus rerum maxime velit quo in cupiditate ab reprehenderit.", 0, new DateTime(2022, 9, 5, 5, 36, 9, 121, DateTimeKind.Local).AddTicks(1337), 243141.0, null, null, 1, 3, "Saepe nostrum saepe quod quae sunt." },
                    { 42, 5, null, null, "Voluptatem quae distinctio soluta eum cumque quae et doloremque dicta quod sed atque laborum at consequatur quia non possimus et illo delectus dolores in eius magnam impedit a laboriosam.", null, null, null, 52734.0, null, null, 4, 1, "Quis non quidem." },
                    { 43, 14, null, null, "Neque placeat officiis impedit neque perferendis debitis ipsa vel fugiat omnis hic modi qui autem voluptas exercitationem sit nesciunt alias est consequatur quia asperiores.", "Dolores et voluptas suscipit temporibus numquam sint autem porro ipsam esse aperiam temporibus voluptatem voluptatibus minima repellat est ea molestiae consectetur aspernatur tempore qui unde et quia quibusdam distinctio.", 0, new DateTime(2023, 4, 20, 14, 6, 40, 45, DateTimeKind.Local).AddTicks(7690), 298122.0, null, null, 3, 3, "Ut repellendus et magnam enim." },
                    { 44, 15, null, null, "Iusto eius minima quisquam sit doloribus voluptates nemo voluptatem amet amet quia accusamus commodi quia voluptatibus rerum reiciendis sequi dicta aliquid suscipit suscipit sit et sunt veritatis.", "Laboriosam optio fuga id cumque consequatur ab dicta nulla nihil fugiat.", 4, new DateTime(2023, 3, 11, 5, 2, 56, 448, DateTimeKind.Local).AddTicks(854), 46406.0, null, null, 1, 3, "Officia aut ut esse." },
                    { 45, 13, null, null, "Officiis beatae distinctio praesentium libero eos explicabo quo mollitia est natus pariatur qui saepe distinctio ipsam alias accusamus voluptate maiores soluta molestiae iste blanditiis voluptates sint et fugit nobis quia.", null, null, null, 36816.0, null, null, 0, 1, "Totam dolores aperiam autem doloremque incidunt." },
                    { 46, 5, null, null, "Quibusdam non nulla similique sunt vel minima suscipit hic est impedit est necessitatibus nesciunt nulla inventore consequatur cupiditate qui.", null, null, new DateTime(2022, 9, 11, 3, 49, 39, 291, DateTimeKind.Local).AddTicks(3858), 367213.0, null, null, 1, 2, "Quis neque soluta nostrum." },
                    { 47, 5, null, null, "Aut facilis asperiores distinctio aut et vitae omnis unde laboriosam aut minima.", null, null, null, 162458.0, null, null, 2, 0, "Ipsum aut vero provident ratione dolores." },
                    { 48, 23, null, null, "Minus dolorem voluptates id asperiores placeat totam soluta vitae saepe qui quis ut cumque omnis incidunt reiciendis inventore et asperiores reprehenderit necessitatibus aperiam dignissimos.", "Velit eaque repellat et et sunt cupiditate reiciendis nam ea a quod aut ratione quaerat dignissimos dolorum nostrum repellat consequatur.", 4, new DateTime(2023, 1, 19, 18, 20, 25, 344, DateTimeKind.Local).AddTicks(7063), 19947.0, null, null, 2, 3, "Expedita facilis voluptas impedit." },
                    { 49, 3, null, null, "Quia repellat dolor aspernatur totam voluptas molestiae optio eos tempora necessitatibus.", null, null, null, 155703.0, null, null, 4, 1, "Illum consequuntur ut." },
                    { 50, 17, null, null, "Ut ea nemo quis accusantium consequatur aperiam quo molestiae explicabo ea exercitationem iusto quod corrupti quia pariatur temporibus cum quia.", null, null, null, 385067.0, null, null, 4, 1, "Reprehenderit ipsam eligendi minima." },
                    { 51, 9, null, null, "Deleniti provident magni magnam ut sunt nam voluptatem inventore quo nemo quia perspiciatis voluptatem.", null, null, new DateTime(2022, 9, 21, 0, 54, 38, 899, DateTimeKind.Local).AddTicks(2678), 51528.0, null, null, 4, 2, "Et molestias sed dolor." },
                    { 52, 22, null, null, "Tempora illo et voluptatum et recusandae modi inventore facilis libero sunt ad eius nobis ad.", null, null, new DateTime(2022, 8, 12, 5, 9, 2, 595, DateTimeKind.Local).AddTicks(3729), 118181.0, null, null, 2, 2, "Iste quasi reiciendis." },
                    { 53, 11, null, null, "Sed qui earum atque quod quae repudiandae fugit et vitae aperiam eos quae vero architecto quos itaque cumque tempora voluptate magnam possimus quod omnis.", null, null, null, 398170.0, null, null, 1, 0, "Quam velit nihil sint iure dolores." },
                    { 54, 1, null, null, "Sit perferendis similique minima quasi velit velit blanditiis rerum amet sequi odio et aliquam hic a consequatur eveniet voluptatem ut sit hic quibusdam velit nemo veritatis consequatur nobis non.", null, null, null, 146671.0, null, null, 1, 0, "Et eius eos molestias." },
                    { 55, 20, null, null, "Quia aut explicabo quaerat molestiae earum omnis quae nesciunt ipsam.", "Dignissimos aliquid laborum pariatur excepturi excepturi eligendi ullam qui quos aut totam ipsum corrupti deserunt ut ea optio ipsam fugit omnis cumque quis eligendi vel.", 3, new DateTime(2023, 6, 7, 20, 4, 55, 352, DateTimeKind.Local).AddTicks(3971), 197460.0, null, null, 0, 3, "Qui sint maiores a est recusandae." },
                    { 56, 11, null, null, "Beatae saepe soluta aut et deleniti eum iure est corporis non a reiciendis distinctio voluptatem sint iusto labore eum asperiores ea porro delectus.", null, null, new DateTime(2023, 4, 6, 7, 11, 47, 285, DateTimeKind.Local).AddTicks(9542), 366291.0, null, null, 4, 2, "Possimus veniam vitae pariatur quisquam." },
                    { 57, 21, null, null, "Magni saepe rerum ad ullam nam et nisi labore reprehenderit dolorem.", null, null, null, 111997.0, null, null, 1, 1, "Sed magnam ea." },
                    { 58, 21, null, null, "Temporibus iste ad in fuga rerum ipsum aut ipsa incidunt architecto laborum quam consequuntur ea ea voluptatem aliquam consectetur.", null, null, new DateTime(2023, 6, 20, 13, 16, 59, 326, DateTimeKind.Local).AddTicks(8734), 97151.0, null, null, 2, 2, "Aut incidunt nam." },
                    { 59, 19, null, null, "Reiciendis consequuntur quibusdam consequatur ab similique dolorum eos sunt quis et praesentium sed iure a quos corrupti ea eum consequuntur temporibus minima repellendus voluptatem omnis.", "Aperiam sunt velit quasi ullam quisquam libero maiores possimus qui impedit excepturi ut officia perferendis nobis cumque numquam est sed non enim.", 4, new DateTime(2023, 2, 22, 21, 31, 46, 866, DateTimeKind.Local).AddTicks(1629), 433250.0, null, null, 1, 3, "Eveniet excepturi in ea." },
                    { 60, 25, null, null, "Fugit rerum iusto nobis eos aut commodi consequuntur accusantium laudantium sed unde dolor illo ratione.", null, null, null, 160863.0, null, null, 0, 1, "Dicta tempore odit consequuntur." },
                    { 61, 18, null, null, "Ullam molestiae eveniet optio quisquam ipsam reprehenderit ipsa unde nihil blanditiis perspiciatis esse consequatur impedit minima maxime.", "Ea debitis rem sunt placeat ipsam fugit autem vitae sit pariatur autem quae voluptatem ut occaecati assumenda.", 2, new DateTime(2022, 12, 21, 7, 40, 56, 761, DateTimeKind.Local).AddTicks(5197), 409005.0, null, null, 2, 3, "Sit explicabo est est." },
                    { 62, 3, null, null, "Velit et animi maxime aut nobis nemo delectus vero maiores dicta explicabo nihil similique culpa et necessitatibus voluptatem molestias cumque neque voluptatem voluptas earum non.", "Quo corporis enim quidem doloribus voluptatem architecto et at nihil.", 4, new DateTime(2023, 6, 7, 20, 13, 18, 186, DateTimeKind.Local).AddTicks(2369), 461259.0, null, null, 4, 3, "Quisquam eum sit fuga vel." },
                    { 63, 22, null, null, "Dolor qui molestias sit id culpa reprehenderit consequatur id quis ut dolor ut sit commodi cupiditate optio.", null, null, new DateTime(2023, 5, 27, 20, 52, 55, 179, DateTimeKind.Local).AddTicks(7343), 193416.0, null, null, 0, 2, "Ut repellat tenetur optio ea qui." },
                    { 64, 5, null, null, "Esse omnis necessitatibus ut facilis repellat assumenda et aut totam non aspernatur aut numquam molestias ipsa nam consequatur id atque tenetur optio totam facere et consectetur est.", null, null, new DateTime(2023, 3, 23, 17, 32, 47, 654, DateTimeKind.Local).AddTicks(3284), 80149.0, null, null, 2, 2, "Necessitatibus doloribus delectus." },
                    { 65, 23, null, null, "Quo eveniet veniam in sunt sit tempore est qui vero et sed saepe voluptatem incidunt dolor qui velit ea ut voluptatum voluptatem.", null, null, null, 328521.0, null, null, 2, 1, "Repellat error tenetur quis." },
                    { 66, 3, null, null, "Iste voluptatem accusamus eligendi consequatur omnis voluptatem eveniet et laboriosam nam in est possimus architecto quidem incidunt.", null, null, null, 438318.0, null, null, 0, 0, "Ipsa eum enim." },
                    { 67, 14, null, null, "Id necessitatibus et recusandae nam suscipit et id sequi in ipsam aut blanditiis atque mollitia excepturi architecto iusto distinctio consequatur adipisci sint ea repudiandae voluptates asperiores voluptatem voluptatem ipsam.", null, null, new DateTime(2022, 10, 31, 19, 17, 9, 801, DateTimeKind.Local).AddTicks(7051), 458519.0, null, null, 4, 2, "Est qui est delectus aut." },
                    { 68, 21, null, null, "Veniam quibusdam quos porro non aspernatur consectetur magnam cupiditate praesentium sed.", null, null, new DateTime(2023, 5, 24, 6, 24, 54, 566, DateTimeKind.Local).AddTicks(4221), 322857.0, null, null, 1, 2, "Dicta doloribus nihil ut dolorem." },
                    { 69, 7, null, null, "Iste possimus nemo nisi ea repellendus repellendus velit ut et itaque illo.", null, null, new DateTime(2022, 7, 16, 22, 26, 58, 653, DateTimeKind.Local).AddTicks(327), 143336.0, null, null, 1, 2, "Est tempora dolorum maxime aut." },
                    { 70, 2, null, null, "Odio quasi dolore neque id ducimus dolorem enim vitae qui at eum quisquam temporibus laudantium.", null, null, new DateTime(2023, 2, 14, 11, 0, 36, 972, DateTimeKind.Local).AddTicks(3501), 108065.0, null, null, 4, 2, "Illo labore suscipit." },
                    { 71, 19, null, null, "Voluptates culpa ut suscipit minima id voluptatem quisquam autem expedita sit et adipisci voluptates quia distinctio quas distinctio ab quo eius qui recusandae.", null, null, null, 11950.0, null, null, 4, 0, "Laboriosam non provident quod maxime." },
                    { 72, 21, null, null, "Et facilis dolorem hic aliquid odit quia laboriosam et mollitia molestias autem cupiditate magnam.", null, null, null, 126737.0, null, null, 4, 0, "Doloremque quos doloremque unde expedita." },
                    { 73, 15, null, null, "Et sit ullam dignissimos officiis sed hic natus ipsum alias consequatur velit autem aspernatur rerum eaque qui ea atque quibusdam dolor architecto molestiae ipsa voluptate laborum tempore maiores sapiente.", null, null, null, 454173.0, null, null, 4, 0, "Quae porro consectetur aut voluptatum sequi." },
                    { 74, 9, null, null, "Quae unde sed voluptatem architecto nihil quaerat sapiente unde in quo aut enim similique occaecati officia sunt dolores.", "In recusandae unde velit voluptatem et quas neque neque amet earum fuga velit doloremque est accusamus et similique sit explicabo totam consequatur adipisci quaerat eos nobis.", 1, new DateTime(2023, 5, 30, 17, 46, 54, 775, DateTimeKind.Local).AddTicks(6087), 112339.0, null, null, 0, 3, "Veritatis quos pariatur facilis illo." },
                    { 75, 10, null, null, "Nihil autem architecto eum non voluptate quia consequatur quidem illum eaque facilis culpa reiciendis laboriosam rerum voluptatibus ut labore ipsam nesciunt ex ea et.", null, null, null, 426660.0, null, null, 1, 1, "Quos rerum ullam consequatur reiciendis officia." },
                    { 76, 18, null, null, "Sunt numquam itaque cum amet asperiores quisquam harum necessitatibus voluptatem eius doloribus quam beatae fugiat ab consectetur esse saepe omnis sint provident hic placeat possimus nostrum voluptas sequi.", null, null, new DateTime(2022, 7, 20, 0, 4, 3, 708, DateTimeKind.Local).AddTicks(2686), 156606.0, null, null, 3, 2, "Vero quo totam." },
                    { 77, 19, null, null, "Odit est ratione inventore et nam sed autem aut velit facilis est sit quo qui praesentium id magnam nisi vel quisquam ex.", null, null, null, 237033.0, null, null, 4, 0, "Officiis laborum occaecati expedita." },
                    { 78, 16, null, null, "Eaque nihil quia voluptas assumenda beatae id exercitationem odit consequatur corporis non perspiciatis dignissimos est voluptatem repellendus ducimus vero.", null, null, null, 471581.0, null, null, 3, 0, "Maxime rerum quia provident." },
                    { 79, 25, null, null, "Aut sed quasi et rerum voluptas dolores id vero nihil impedit ullam et odit delectus omnis labore amet atque nihil incidunt distinctio minus occaecati modi minima.", null, null, null, 143882.0, null, null, 4, 1, "Minima enim non." },
                    { 80, 19, null, null, "Quidem maiores autem aut magnam autem dolor assumenda facere eveniet deserunt ex esse fugit laboriosam repudiandae nihil iure et et alias harum non ratione ut voluptas cupiditate alias.", null, null, new DateTime(2023, 4, 22, 8, 55, 0, 338, DateTimeKind.Local).AddTicks(5779), 41125.0, null, null, 3, 2, "Non unde neque dignissimos ea." },
                    { 81, 21, null, null, "Aut vel velit tempora est eum sint quis suscipit distinctio aut ut aliquam doloremque sunt at provident incidunt rem dignissimos ut.", "Et aut accusantium adipisci sunt dicta qui sunt deserunt quo molestiae sit sunt eius voluptas qui illo omnis autem quo.", 1, new DateTime(2023, 4, 11, 7, 27, 27, 465, DateTimeKind.Local).AddTicks(5602), 475042.0, null, null, 4, 3, "Suscipit et quia aspernatur dolor." },
                    { 82, 4, null, null, "Iure nobis tempore est autem ut fuga at voluptatem saepe neque vel sint accusantium.", null, null, null, 85075.0, null, null, 2, 1, "Reprehenderit ad vitae." },
                    { 83, 2, null, null, "Autem ducimus voluptas laborum minima id distinctio nihil culpa eveniet ipsum maiores tenetur aut non sit perspiciatis id earum consequuntur labore eaque vel non voluptates expedita eius.", null, null, null, 272043.0, null, null, 4, 0, "Quo aut consectetur explicabo voluptatum assumenda." },
                    { 84, 24, null, null, "Dolores cupiditate sapiente dolorum aut aut ratione in labore aliquid molestiae perferendis aut ullam dignissimos totam incidunt soluta velit aperiam nam sunt est.", null, null, new DateTime(2022, 11, 5, 20, 44, 40, 151, DateTimeKind.Local).AddTicks(3946), 225633.0, null, null, 0, 2, "Aliquid cum ut vero provident porro." },
                    { 85, 13, null, null, "Tempore vel quam recusandae delectus sed non dolore non accusamus quia.", null, null, null, 69309.0, null, null, 2, 0, "Illum incidunt laboriosam porro aut ea." },
                    { 86, 2, null, null, "Velit velit iure et in quia magnam necessitatibus est impedit ipsam sed ut esse fugiat aut aspernatur.", null, null, new DateTime(2022, 9, 28, 11, 33, 30, 107, DateTimeKind.Local).AddTicks(3628), 403729.0, null, null, 2, 2, "Nulla consequatur eos dolorum eaque quidem." },
                    { 87, 6, null, null, "Labore fuga neque sunt quae itaque dolorum in a est dolore sequi.", "Consequatur labore adipisci laborum ea iusto ipsum exercitationem quasi blanditiis hic quam quod maxime.", 1, new DateTime(2023, 3, 18, 0, 24, 58, 657, DateTimeKind.Local).AddTicks(9572), 343376.0, null, null, 0, 3, "Debitis sint quis." },
                    { 88, 20, null, null, "Est in beatae eveniet natus at quia quos deserunt esse ut dicta neque rerum facere tempore illo accusamus praesentium vitae quis et et iste quas voluptate odit.", null, null, null, 161892.0, null, null, 0, 0, "Nesciunt ipsum fugit amet est laborum." },
                    { 89, 11, null, null, "Ab consectetur aut doloremque exercitationem a reprehenderit deserunt hic itaque iure unde ex nobis dignissimos assumenda repudiandae omnis delectus similique ut voluptatibus assumenda aut.", null, null, new DateTime(2022, 11, 21, 4, 26, 37, 36, DateTimeKind.Local).AddTicks(8104), 148189.0, null, null, 1, 2, "Molestias numquam qui mollitia molestias placeat." },
                    { 90, 23, null, null, "Vel architecto laudantium consequatur eius rerum deleniti et sed dolorum in non dolor dignissimos aut sapiente a qui magni cupiditate sunt aspernatur corporis commodi necessitatibus voluptas aliquam in.", null, null, new DateTime(2022, 9, 29, 12, 14, 47, 945, DateTimeKind.Local).AddTicks(6470), 170603.0, null, null, 1, 2, "Molestiae quam enim quibusdam mollitia dolorum." },
                    { 91, 25, null, null, "Placeat aut veritatis alias rem et sequi velit sint molestias atque odit corrupti et.", null, null, null, 102102.0, null, null, 3, 0, "Fugit non sint." },
                    { 92, 25, null, null, "Modi a ducimus veniam aut voluptatem laudantium reiciendis repudiandae atque consequuntur quo sed doloribus delectus id sed et tempora ipsam qui rerum sed in repudiandae minus recusandae minus quo.", null, null, null, 100110.0, null, null, 1, 1, "Accusantium dolorum qui." },
                    { 93, 23, null, null, "Quia officiis fugit temporibus nam error minima blanditiis dolores quisquam adipisci magnam aut rem voluptate et laboriosam sed culpa eveniet voluptatem.", null, null, null, 204960.0, null, null, 4, 0, "Occaecati expedita autem ex." },
                    { 94, 2, null, null, "Voluptatibus qui blanditiis ratione voluptatibus nobis delectus impedit et consequatur.", null, null, null, 471692.0, null, null, 3, 0, "Ipsum et vel." },
                    { 95, 11, null, null, "Ea iusto et et consequatur voluptatum quos doloribus rerum doloremque ea quia numquam voluptatum dicta quia sint molestiae.", null, null, new DateTime(2022, 12, 13, 6, 51, 21, 589, DateTimeKind.Local).AddTicks(4071), 381321.0, null, null, 3, 2, "Sapiente quis recusandae sunt ad." },
                    { 96, 1, null, null, "Sunt voluptatem nihil rerum fugiat et ut quidem neque quisquam maiores quidem id vel doloremque assumenda est omnis labore officia tempore aut fugit minima facilis.", null, null, null, 146361.0, null, null, 0, 0, "Porro animi exercitationem." },
                    { 97, 12, null, null, "Iure tempora quis sed culpa nihil eveniet totam dolorum qui unde dolore.", null, null, new DateTime(2023, 6, 25, 9, 19, 10, 575, DateTimeKind.Local).AddTicks(7544), 435771.0, null, null, 1, 2, "Dolores voluptas rerum eaque." },
                    { 98, 13, null, null, "Ut quidem quaerat maiores facere harum repellendus commodi non asperiores deleniti est similique quo.", "Et et ratione non sit dicta sit adipisci eos veniam.", 4, new DateTime(2023, 7, 3, 7, 30, 47, 798, DateTimeKind.Local).AddTicks(9996), 118939.0, null, null, 4, 3, "Quos quam voluptas voluptatem exercitationem expedita." },
                    { 99, 11, null, null, "Dolor nemo fuga reprehenderit laudantium voluptatem voluptas nulla quasi earum corrupti culpa corrupti quo magnam quas ipsa itaque nemo repudiandae odio sit aut aut nemo.", null, null, null, 302725.0, null, null, 0, 0, "Earum molestiae voluptas ea ipsa." },
                    { 100, 2, null, null, "Quo veniam qui nulla impedit quisquam laboriosam earum saepe minus non inventore.", null, null, new DateTime(2023, 7, 5, 14, 57, 17, 641, DateTimeKind.Local).AddTicks(4364), 181288.0, null, null, 2, 2, "Vitae molestias blanditiis rerum voluptas veritatis." }
                });

            migrationBuilder.InsertData(
                table: "Deals",
                columns: new[] { "Id", "AccountId", "ActualRevenue", "CreatedAt", "CreatedBy", "Description", "EstimatedRevenue", "LeadId", "ModifiedAt", "ModifiedBy", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 7, 398515.0, null, null, "Enim cupiditate velit dolor provident recusandae doloribus rem sed et quia expedita ab quis ratione sequi et nemo quasi harum incidunt fugiat sapiente porro voluptatum pariatur.", 456267.0, 87, null, null, 1, "Laudantium optio placeat." },
                    { 2, 8, 383652.0, null, null, "In facilis nostrum voluptas beatae reprehenderit vero pariatur expedita ut deserunt necessitatibus quae libero at aliquid corporis odio et maiores eligendi ad at qui suscipit.", 177050.0, 85, null, null, 2, "Qui necessitatibus vel molestiae expedita quas." },
                    { 3, 4, 75399.0, null, null, "Voluptatem deserunt quis dolores rerum distinctio eaque assumenda odit officia et nihil occaecati voluptas dolorem corrupti mollitia voluptas ducimus quibusdam deserunt pariatur et.", 440672.0, 1, null, null, 0, "Nobis omnis voluptates." },
                    { 4, 1, 450815.0, null, null, "Qui in sed eos suscipit quisquam qui fugit voluptatem alias sunt tenetur aut quam et enim illo voluptas voluptatem ad numquam animi possimus quam ut quia est consequuntur perferendis nobis.", 204081.0, 47, null, null, 0, "Non vero et fuga." },
                    { 5, 23, 118753.0, null, null, "Voluptatem ipsam repellat cum voluptas sed et voluptatem nihil sit dolorem animi quia accusamus mollitia eligendi repudiandae ad.", 46298.0, 21, null, null, 0, "Iusto enim maiores." },
                    { 6, 24, 148506.0, null, null, "Non sunt corrupti et necessitatibus doloremque molestiae rem quae necessitatibus beatae necessitatibus eum perspiciatis nulla sunt est et laudantium consequatur repudiandae eum alias distinctio quod.", 75885.0, 88, null, null, 1, "Et non ut aut voluptas error." },
                    { 7, 19, 81676.0, null, null, "Quibusdam assumenda ipsam enim omnis esse sint quo voluptatum nulla rem reiciendis recusandae et iure qui sunt autem laudantium voluptatem molestiae autem debitis adipisci necessitatibus ea facilis et provident aut.", 148126.0, 80, null, null, 1, "Dolorum officia molestiae sit nemo et." },
                    { 8, 25, 199367.0, null, null, "Omnis dicta hic et sit eius qui sint rem voluptatibus tenetur in sit voluptatem eos sit velit ad ducimus qui voluptatem repellendus quia doloremque eos quis assumenda.", 56294.0, 74, null, null, 0, "Aspernatur nulla est et." },
                    { 9, 19, 246861.0, null, null, "Doloremque sed deserunt ut quia officia exercitationem ipsa expedita laboriosam at facere repellat tempore accusamus sed eos fugit quos ex exercitationem.", 424489.0, 75, null, null, 0, "Esse sequi laborum suscipit." },
                    { 10, 3, 26010.0, null, null, "Id reprehenderit magnam qui molestias quia itaque veniam dolor sunt.", 406862.0, 48, null, null, 0, "Ex consequuntur possimus quis eos voluptatem." },
                    { 11, 14, 393756.0, null, null, "Ut ab excepturi ipsam eaque voluptas dolorem consectetur fugit exercitationem officia sit tenetur id eligendi ut dolorem aut libero.", 396326.0, 50, null, null, 2, "Quis omnis eum dolorum." },
                    { 12, 13, 59499.0, null, null, "Sit laudantium voluptatem qui qui rerum vero officia quis eos est ducimus doloribus dolor consequatur est non voluptas sed eveniet vel provident et tempora voluptatem enim.", 364111.0, 28, null, null, 0, "Facere vel animi beatae pariatur et." },
                    { 13, 20, 30660.0, null, null, "Qui nulla illo placeat totam eius vel est aliquid exercitationem nam recusandae occaecati ab tempora ut quos tempore molestiae nobis deserunt quam ex.", 447974.0, 44, null, null, 1, "Nobis id blanditiis expedita beatae sapiente." },
                    { 14, 10, 296605.0, null, null, "Ipsam dolores voluptatem magnam commodi repellat qui ipsum voluptatum ut ut et neque eos dolores laborum ullam provident provident sed necessitatibus laboriosam adipisci est impedit mollitia laudantium.", 225065.0, 23, null, null, 1, "Est fugit ut quis porro." },
                    { 15, 17, 155179.0, null, null, "Ut et aspernatur iusto eum rerum facere sunt qui consequuntur.", 22138.0, 67, null, null, 1, "Eveniet dolorem officia." },
                    { 16, 6, 322333.0, null, null, "Et porro iste doloremque sequi amet ad eligendi nemo consectetur doloribus autem deleniti ex qui minima optio et eos facilis velit ducimus nobis ipsum fugiat qui sit voluptate doloribus repellendus.", 170401.0, 13, null, null, 0, "Animi blanditiis consequatur." },
                    { 17, 24, 329796.0, null, null, "Est dolor doloribus molestiae consequatur velit ipsa esse magnam consectetur est facere libero aut labore asperiores eligendi eos nesciunt necessitatibus et.", 71899.0, 96, null, null, 0, "Labore aut et a quia mollitia." },
                    { 18, 15, 485758.0, null, null, "Laudantium rerum consectetur optio porro repellendus mollitia dolores explicabo quae blanditiis aliquid eaque quaerat sint vel sunt possimus facilis numquam dolorum repellendus in quasi.", 279916.0, 84, null, null, 0, "Voluptatem delectus qui commodi." },
                    { 19, 5, 309949.0, null, null, "Culpa et quia et nisi impedit est corrupti eum a non laborum.", 452660.0, 47, null, null, 2, "Ut veritatis illo magni." },
                    { 20, 18, 39391.0, null, null, "Nostrum sit sed repudiandae explicabo cupiditate asperiores corporis qui et laboriosam dolorem similique officiis ea aut vel ut quos libero illum consequatur voluptatem.", 205966.0, 57, null, null, 0, "Natus sed magni sunt officiis." },
                    { 21, 10, 417983.0, null, null, "Aliquid tenetur quo quod officiis nesciunt optio est ipsam eius cumque quisquam at a tenetur voluptas et necessitatibus dignissimos aperiam est repudiandae quam ea explicabo ut aut.", 297725.0, 6, null, null, 0, "Aspernatur necessitatibus eaque sit nostrum." },
                    { 22, 19, 390326.0, null, null, "Veniam totam facere tenetur qui ex enim reiciendis quisquam enim ratione et iste velit perferendis voluptatem voluptas qui tempora quo ut enim quia rerum quis.", 498242.0, 83, null, null, 2, "Non qui rerum optio fugit." },
                    { 23, 4, 196180.0, null, null, "Aut in ut necessitatibus aut molestiae neque asperiores qui nesciunt eos minus incidunt ea dolore enim delectus ducimus molestiae ut.", 231957.0, 63, null, null, 2, "Illum asperiores minima." },
                    { 24, 3, 79512.0, null, null, "Blanditiis libero aut quibusdam dolorem et maxime est sed ipsa nostrum.", 488562.0, 28, null, null, 2, "Sed laborum vitae et et." },
                    { 25, 20, 123978.0, null, null, "Unde error dolorum provident quia dolore laboriosam a quia accusantium maiores repudiandae ut rem dolorem omnis deleniti aut sequi earum voluptatum facere qui et quia et nulla nesciunt dolor dignissimos.", 213111.0, 31, null, null, 2, "At nisi qui fugiat illo." },
                    { 26, 13, 411830.0, null, null, "Quis assumenda possimus et a voluptatem velit nisi veritatis et voluptas.", 237298.0, 9, null, null, 1, "Voluptatibus eligendi molestiae nisi deleniti architecto." },
                    { 27, 9, 374854.0, null, null, "Corporis adipisci repellat aut labore sit eius esse delectus maxime aut distinctio ipsum et rem vel.", 332025.0, 49, null, null, 0, "Sunt qui sit neque." },
                    { 28, 10, 266064.0, null, null, "Deserunt vero dolorem nulla voluptatem ad voluptatem atque et dolorem et minima quo deleniti repellendus quia ut assumenda id illum at.", 440929.0, 97, null, null, 1, "Deserunt sapiente ut." },
                    { 29, 6, 326330.0, null, null, "Voluptates asperiores optio et optio accusamus perferendis aut quia harum omnis corporis rerum quo delectus quod modi dolores quia.", 29671.0, 46, null, null, 2, "Harum nobis sit reiciendis dicta." },
                    { 30, 13, 448153.0, null, null, "Officiis et molestiae necessitatibus harum officia velit consequuntur qui error soluta vel rem ut velit magnam aut voluptatem est.", 486942.0, 73, null, null, 1, "Impedit eligendi nihil." }
                });

            migrationBuilder.InsertData(
                table: "DealProducts",
                columns: new[] { "DealId", "ProductId", "PricePerUnit", "Quantity", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 7, 74.0, 7, 723.0 },
                    { 2, 8, 18.0, 22, 880.0 },
                    { 3, 2, 24.0, 58, 514.0 },
                    { 4, 10, 57.0, 94, 295.0 },
                    { 5, 3, 57.0, 86, 514.0 },
                    { 6, 1, 35.0, 26, 810.0 },
                    { 7, 7, 62.0, 2, 262.0 },
                    { 8, 6, 24.0, 58, 845.0 },
                    { 9, 2, 28.0, 62, 142.0 },
                    { 10, 7, 72.0, 61, 976.0 },
                    { 11, 5, 60.0, 45, 642.0 },
                    { 12, 8, 87.0, 70, 128.0 },
                    { 13, 6, 68.0, 25, 456.0 },
                    { 14, 4, 30.0, 84, 777.0 },
                    { 15, 2, 51.0, 27, 420.0 },
                    { 16, 8, 25.0, 91, 706.0 },
                    { 17, 10, 97.0, 33, 484.0 },
                    { 18, 7, 17.0, 57, 550.0 },
                    { 19, 8, 51.0, 75, 234.0 },
                    { 20, 4, 58.0, 5, 238.0 },
                    { 21, 6, 84.0, 100, 311.0 },
                    { 22, 6, 69.0, 97, 366.0 },
                    { 23, 4, 50.0, 14, 480.0 },
                    { 24, 8, 43.0, 5, 439.0 },
                    { 25, 1, 14.0, 93, 825.0 },
                    { 26, 10, 78.0, 61, 758.0 },
                    { 27, 8, 98.0, 50, 853.0 },
                    { 28, 9, 54.0, 31, 560.0 },
                    { 29, 1, 87.0, 35, 763.0 },
                    { 30, 8, 85.0, 68, 527.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AccountId",
                table: "Contacts",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_DealProducts_ProductId",
                table: "DealProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_AccountId",
                table: "Deals",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_LeadId",
                table: "Deals",
                column: "LeadId");

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
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "DealProducts");

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
