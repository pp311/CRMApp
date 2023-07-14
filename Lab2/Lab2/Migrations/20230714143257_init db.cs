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
                    EstimatedRevenue = table.Column<double>(type: "float", nullable: true),
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
                name: "Deals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    ActualRevenue = table.Column<double>(type: "float", nullable: true),
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
                    Id = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_DealProducts", x => new { x.DealId, x.ProductId, x.Id });
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
                    { 1, "894 Wade Centers, New Arloport, Western Sahara", null, null, "Marlene54@gmail.com", null, null, "Padberg Group", "287.377.0770 x89106", 810.0 },
                    { 2, "10542 Bode Road, Whiteside, Honduras", null, null, "Earnestine20@gmail.com", null, null, "Johnson LLC", "(906) 445-3304", 4285.0 },
                    { 3, "3274 Hegmann Brooks, East Willaborough, India", null, null, "Molly49@yahoo.com", null, null, "Aufderhar, Beier and Lakin", "(379) 752-7616 x825", 33216.0 },
                    { 4, "7961 Sherman Forge, New Judd, Peru", null, null, "Emie69@hotmail.com", null, null, "Kuhn, Rath and Krajcik", "1-863-719-4404 x65910", 2544.0 },
                    { 5, "412 Konopelski Passage, Grahammouth, Mexico", null, null, "Julio58@gmail.com", null, null, "Gerlach - Mraz", "1-212-294-2744", 45307.0 },
                    { 6, "817 Swift Junction, Lake Modesto, Greenland", null, null, "Amir_Ernser@yahoo.com", null, null, "Collins - Mohr", "596-745-3373 x94213", 6106.0 },
                    { 7, "0876 Dooley Forks, Eusebioborough, Israel", null, null, "Markus_Weissnat63@hotmail.com", null, null, "O'Keefe LLC", "1-631-728-8040 x248", 31292.0 },
                    { 8, "395 Nienow Cape, Gaylordmouth, United Kingdom", null, null, "Frank_Hirthe@hotmail.com", null, null, "Heathcote - Cassin", "823.411.5060", 22366.0 },
                    { 9, "80000 Kunde Ville, West Alexiehaven, French Polynesia", null, null, "Stephan47@gmail.com", null, null, "Mertz Group", "(234) 723-9956", 26047.0 },
                    { 10, "923 Frederic Valley, Christiantown, Poland", null, null, "Genevieve_Cremin54@hotmail.com", null, null, "Kuhic, Smith and Durgan", "1-585-471-6015", 37806.0 },
                    { 11, "4247 Senger Oval, Port Bonnieville, China", null, null, "Rosemarie3@gmail.com", null, null, "Bashirian, Ondricka and Ryan", "672.409.1159", 48763.0 },
                    { 12, "89068 Tyson Burgs, Maryland, Denmark", null, null, "Alfreda63@gmail.com", null, null, "Smith, Huels and Abernathy", "(357) 570-2032 x8348", 6692.0 },
                    { 13, "72214 Robin Centers, New Alexanderbury, Swaziland", null, null, "Burdette81@yahoo.com", null, null, "Jones - Kunde", "372-813-1264 x0472", 5603.0 },
                    { 14, "170 Liam Estate, East Adam, New Caledonia", null, null, "Wilma_Corwin72@gmail.com", null, null, "Monahan, Hilpert and Heathcote", "(979) 330-1780", 15893.0 },
                    { 15, "85871 Tanner Underpass, Lake Coltonville, Trinidad and Tobago", null, null, "Antonina_Littel@yahoo.com", null, null, "Feeney - Hilll", "(356) 723-0946 x9849", 12186.0 },
                    { 16, "71624 Kovacek Union, Tiffanytown, Western Sahara", null, null, "Alexandrine_Bogisich81@hotmail.com", null, null, "Mayer, Barton and Wisozk", "321-473-8504 x445", 40421.0 },
                    { 17, "101 Prosacco Rue, Lake Eino, Thailand", null, null, "Nora.Lynch@gmail.com", null, null, "Rogahn - Hackett", "444.220.1304", 32404.0 },
                    { 18, "3001 Rodriguez Divide, New Samanthaberg, Gibraltar", null, null, "Zelma5@yahoo.com", null, null, "Ward, Schowalter and Gulgowski", "1-379-799-9920", 39489.0 },
                    { 19, "2288 Bahringer Freeway, Sageton, Guam", null, null, "Yazmin.Nitzsche@hotmail.com", null, null, "Schuster - Stoltenberg", "(383) 708-5981", 38347.0 },
                    { 20, "1409 Roderick Shores, Luthermouth, Argentina", null, null, "Rae72@yahoo.com", null, null, "Fay Group", "765-860-1201 x14602", 37373.0 },
                    { 21, "3891 Pollich Gateway, Botsfordshire, Zambia", null, null, "Lucius30@hotmail.com", null, null, "Koss Group", "340-925-3566 x373", 13165.0 },
                    { 22, "8763 Ferry Plains, Ashaborough, United States Minor Outlying Islands", null, null, "Kieran35@gmail.com", null, null, "Rolfson Inc", "1-808-662-5792 x27596", 12335.0 },
                    { 23, "8927 Katharina Harbor, Steubermouth, Reunion", null, null, "Murphy_Farrell73@yahoo.com", null, null, "Towne LLC", "(249) 642-0933", 15243.0 },
                    { 24, "1267 Tressie Island, Manteside, Venezuela", null, null, "Brian_Conn33@gmail.com", null, null, "Ebert, Rice and Wilkinson", "888.506.6066 x5178", 32989.0 },
                    { 25, "8183 Schaden View, Newtonberg, Chile", null, null, "Luella48@gmail.com", null, null, "Upton - Okuneva", "(992) 295-7267", 25861.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsAvailable", "ModifiedAt", "ModifiedBy", "Name", "Price", "ProductCode", "Type" },
                values: new object[,]
                {
                    { 1, null, null, true, null, null, "Generic Rubber Pants", 301.0, "PRO-19157863", 0 },
                    { 2, null, null, true, null, null, "Unbranded Fresh Salad", 381.0, "PRO-23563759", 0 },
                    { 3, null, null, true, null, null, "Incredible Soft Shoes", 842.0, "PRO-67434046", 0 },
                    { 4, null, null, true, null, null, "Fantastic Rubber Cheese", 414.0, "PRO-05955367", 1 },
                    { 5, null, null, true, null, null, "Awesome Soft Tuna", 239.0, "PRO-51267452", 1 },
                    { 6, null, null, true, null, null, "Gorgeous Metal Hat", 288.0, "PRO-54267954", 1 },
                    { 7, null, null, true, null, null, "Awesome Wooden Hat", 875.0, "PRO-71376967", 1 },
                    { 8, null, null, true, null, null, "Ergonomic Steel Shirt", 720.0, "PRO-58273029", 1 },
                    { 9, null, null, true, null, null, "Sleek Wooden Pants", 859.0, "PRO-90708169", 1 },
                    { 10, null, null, true, null, null, "Rustic Wooden Table", 600.0, "PRO-28771975", 0 }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "AccountId", "CreatedAt", "CreatedBy", "Email", "ModifiedAt", "ModifiedBy", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, 23, null, null, "Karlie.Cassin@gmail.com", null, null, "Carolyn Bartell", "(609) 617-9528 x59288" },
                    { 2, 12, null, null, "Hailey97@gmail.com", null, null, "Jarret Hoppe", "509-699-3847 x110" },
                    { 3, 13, null, null, "Alberta_Jaskolski@yahoo.com", null, null, "Elliott Langosh", "489-899-9167 x77985" },
                    { 4, 4, null, null, "Coy60@yahoo.com", null, null, "Maia Weber", "805-597-1914 x801" },
                    { 5, 4, null, null, "Weldon64@gmail.com", null, null, "Dorothea McCullough", "750.646.1089" },
                    { 6, 8, null, null, "Kathryn_Padberg@gmail.com", null, null, "Nicolette Tillman", "1-926-399-4109" },
                    { 7, 5, null, null, "Gunner.Kshlerin@hotmail.com", null, null, "Josue Koelpin", "656-641-7122 x594" },
                    { 8, 3, null, null, "Myah.Kuhlman86@yahoo.com", null, null, "Eldridge Lemke", "859-273-6013 x795" },
                    { 9, 14, null, null, "Alessia.Mosciski63@yahoo.com", null, null, "Rachel Kuhn", "620-493-3710 x051" },
                    { 10, 20, null, null, "Sally.Williamson24@gmail.com", null, null, "Katlynn Kemmer", "330.552.1908 x66036" },
                    { 11, 15, null, null, "Loyce.Wisozk23@hotmail.com", null, null, "Braeden Jenkins", "861.961.5899 x4250" },
                    { 12, 16, null, null, "Fletcher84@hotmail.com", null, null, "Linwood Langworth", "1-708-273-6616 x996" },
                    { 13, 8, null, null, "Diamond.Kling@hotmail.com", null, null, "Nicholas Turner", "942.303.0414 x3708" },
                    { 14, 24, null, null, "Sterling.Schneider@yahoo.com", null, null, "Antonina Reynolds", "1-786-510-7992 x65649" },
                    { 15, 22, null, null, "Benton.Hoppe75@gmail.com", null, null, "Maybell Kessler", "267.921.8067 x13997" },
                    { 16, 1, null, null, "Raoul1@hotmail.com", null, null, "Loma Collins", "1-773-819-2565" },
                    { 17, 8, null, null, "Jarod.Reichel54@yahoo.com", null, null, "Darrel Ritchie", "(411) 777-6106 x1334" },
                    { 18, 5, null, null, "Corine75@hotmail.com", null, null, "Orlando Crooks", "1-326-403-5641 x32124" },
                    { 19, 21, null, null, "Hank.Davis61@gmail.com", null, null, "Cesar Swaniawski", "713.303.4711" },
                    { 20, 5, null, null, "Emilio95@yahoo.com", null, null, "Elliott Von", "565.703.0328" },
                    { 21, 24, null, null, "Aglae26@gmail.com", null, null, "Jordan Gislason", "900-956-3004 x1618" },
                    { 22, 8, null, null, "Trystan39@hotmail.com", null, null, "Kylie Halvorson", "1-337-775-8057" },
                    { 23, 14, null, null, "Dandre_Veum14@gmail.com", null, null, "Lloyd Considine", "987.758.1879" },
                    { 24, 17, null, null, "Maximillia_Roob@gmail.com", null, null, "Meggie Kunde", "615.939.7833 x8725" },
                    { 25, 16, null, null, "Daisha.Waelchi@hotmail.com", null, null, "Austin Miller", "(492) 723-0921" },
                    { 26, 6, null, null, "Pearline83@hotmail.com", null, null, "Lambert Vandervort", "882.662.7143 x3975" },
                    { 27, 4, null, null, "Rodolfo_Emmerich@gmail.com", null, null, "Lamar Harvey", "1-733-776-9268" },
                    { 28, 13, null, null, "Alfredo_Wolff72@hotmail.com", null, null, "Deonte Hilpert", "(404) 304-8684 x814" },
                    { 29, 5, null, null, "Sandrine.Green38@yahoo.com", null, null, "Alexane Padberg", "630-221-4215" },
                    { 30, 24, null, null, "Francisco_White23@gmail.com", null, null, "Maurice Leuschke", "638.673.3085 x3624" },
                    { 31, 20, null, null, "Ron.Von@gmail.com", null, null, "Zula Feest", "1-955-846-6883" },
                    { 32, 23, null, null, "Walter76@hotmail.com", null, null, "Quentin Abernathy", "(617) 837-3761" },
                    { 33, 13, null, null, "Wilburn81@yahoo.com", null, null, "Isom Graham", "(831) 519-7569 x60320" },
                    { 34, 14, null, null, "Susie.Baumbach@gmail.com", null, null, "Eugene Prosacco", "699-866-6678" },
                    { 35, 23, null, null, "Michale.Swaniawski61@yahoo.com", null, null, "Gudrun Klocko", "757-405-7103 x00370" },
                    { 36, 9, null, null, "Aaliyah_Kozey@gmail.com", null, null, "Genevieve Volkman", "974.299.9856 x09343" },
                    { 37, 8, null, null, "Adele_Ullrich25@gmail.com", null, null, "Ruthie Rowe", "899.489.2400 x520" },
                    { 38, 14, null, null, "Orrin.Marks58@gmail.com", null, null, "Mathilde Greenholt", "883-244-0141" },
                    { 39, 24, null, null, "Elmer.Miller@gmail.com", null, null, "Deron Hammes", "(690) 525-1220 x674" },
                    { 40, 4, null, null, "Wyman_Feest83@gmail.com", null, null, "Jaydon Osinski", "512-708-1175 x55308" },
                    { 41, 5, null, null, "Austen13@yahoo.com", null, null, "Amos Rohan", "1-973-427-8401" },
                    { 42, 3, null, null, "Euna.Heathcote38@hotmail.com", null, null, "Abdul O'Connell", "774-410-9431" },
                    { 43, 21, null, null, "Jaiden55@yahoo.com", null, null, "Marcelino Lakin", "208.389.8666 x628" },
                    { 44, 5, null, null, "Ernesto17@gmail.com", null, null, "Jerrod Cummings", "872-666-8250" },
                    { 45, 19, null, null, "Jillian73@hotmail.com", null, null, "Iva Cormier", "1-389-926-8788" },
                    { 46, 12, null, null, "Susana.Hammes8@yahoo.com", null, null, "Kenyatta Borer", "1-318-347-3513" },
                    { 47, 2, null, null, "Ignacio.McDermott83@yahoo.com", null, null, "Billie Nitzsche", "1-233-946-8637" },
                    { 48, 8, null, null, "Adele.Schmitt45@yahoo.com", null, null, "Hortense Thiel", "300-836-5850 x440" },
                    { 49, 2, null, null, "Halle49@hotmail.com", null, null, "Grady Wisozk", "(762) 619-6229" },
                    { 50, 25, null, null, "Patricia81@yahoo.com", null, null, "Gerhard Haag", "565.645.7209 x729" },
                    { 51, 21, null, null, "Loy.Mills38@hotmail.com", null, null, "Gregorio Crooks", "(409) 525-1849" },
                    { 52, 24, null, null, "Adele_Boyer@hotmail.com", null, null, "Mustafa Gusikowski", "679-489-4721 x2599" },
                    { 53, 8, null, null, "Shyann_Leffler72@hotmail.com", null, null, "Juwan Krajcik", "(702) 258-4993" },
                    { 54, 23, null, null, "Verla55@gmail.com", null, null, "Wilhelmine Nicolas", "272-245-4599" },
                    { 55, 10, null, null, "Rachael_Bergnaum@hotmail.com", null, null, "Stewart Thompson", "236.359.6461" },
                    { 56, 1, null, null, "Garry28@hotmail.com", null, null, "Vladimir Schuppe", "(996) 854-9547" },
                    { 57, 7, null, null, "Patience26@gmail.com", null, null, "Merl McGlynn", "(391) 980-6629 x50254" },
                    { 58, 10, null, null, "Tad24@hotmail.com", null, null, "Briana Schmitt", "876-260-2428" },
                    { 59, 16, null, null, "Virgie.Rau43@gmail.com", null, null, "Stephanie Gleason", "(997) 464-6443 x06286" },
                    { 60, 9, null, null, "Adah.Mraz25@gmail.com", null, null, "Kaleigh Hickle", "1-807-961-6064" },
                    { 61, 16, null, null, "Ashly.Jenkins23@gmail.com", null, null, "Hal Schuster", "1-684-478-9397 x12156" },
                    { 62, 24, null, null, "Bryon6@gmail.com", null, null, "Vida Kling", "779-491-0895" },
                    { 63, 19, null, null, "Maya13@yahoo.com", null, null, "Pete Hettinger", "1-969-701-3347 x29947" },
                    { 64, 19, null, null, "Dangelo65@gmail.com", null, null, "Hertha Gerlach", "639.632.7925 x66148" },
                    { 65, 2, null, null, "Vivianne_Yundt@yahoo.com", null, null, "Greg Brown", "(779) 355-4866" },
                    { 66, 13, null, null, "Keagan42@hotmail.com", null, null, "Hailey Von", "(900) 843-1288 x91854" },
                    { 67, 21, null, null, "Kristoffer.Fay@hotmail.com", null, null, "Wallace Leannon", "1-589-643-6668" },
                    { 68, 18, null, null, "Haylee.Strosin@gmail.com", null, null, "Billy Russel", "490-627-6221" },
                    { 69, 13, null, null, "Julio.Blanda@gmail.com", null, null, "Taryn Lakin", "1-824-293-4747 x2036" },
                    { 70, 3, null, null, "Makenzie.Marks@yahoo.com", null, null, "Jaylin Barrows", "327.907.3820 x500" },
                    { 71, 21, null, null, "Manuela12@yahoo.com", null, null, "Shawn Bailey", "281.461.9280 x5867" },
                    { 72, 22, null, null, "Gillian.Blanda91@yahoo.com", null, null, "Toney Schroeder", "461-888-6424 x3225" },
                    { 73, 15, null, null, "Robert_Renner@hotmail.com", null, null, "Desmond Gusikowski", "953-393-2656 x4409" },
                    { 74, 10, null, null, "Sammie.Beahan@yahoo.com", null, null, "Caleigh Zboncak", "(563) 720-7277 x07287" },
                    { 75, 13, null, null, "Presley_Rowe@hotmail.com", null, null, "Libbie Cormier", "672.717.5115 x2543" },
                    { 76, 12, null, null, "Ila.Denesik@yahoo.com", null, null, "Imelda Schimmel", "1-832-827-6471 x54116" },
                    { 77, 5, null, null, "Ozella.Fahey@gmail.com", null, null, "Tess West", "(832) 761-0802 x30346" },
                    { 78, 7, null, null, "Joe87@yahoo.com", null, null, "Ed Padberg", "(997) 259-1019 x035" },
                    { 79, 6, null, null, "Larry39@gmail.com", null, null, "Meagan Heidenreich", "561.634.6454" },
                    { 80, 23, null, null, "Osbaldo.Heidenreich@gmail.com", null, null, "Gladys Harris", "1-797-243-5968" },
                    { 81, 20, null, null, "Adalberto38@yahoo.com", null, null, "Zachery Gleichner", "298.523.5263 x21587" },
                    { 82, 15, null, null, "Darrick_Luettgen70@yahoo.com", null, null, "Kendrick Hahn", "547-620-6634 x46566" },
                    { 83, 2, null, null, "Otho_Waelchi79@gmail.com", null, null, "Hailey Boehm", "467.607.3073 x4913" },
                    { 84, 22, null, null, "Nikki_Murazik14@yahoo.com", null, null, "Amelie Kiehn", "1-472-371-3730 x5476" },
                    { 85, 21, null, null, "Florence_Miller@gmail.com", null, null, "Kip Hackett", "1-815-417-9120 x33038" },
                    { 86, 15, null, null, "Judah.Hermiston@yahoo.com", null, null, "Lola Hammes", "903-651-3439 x8416" },
                    { 87, 2, null, null, "Darwin93@hotmail.com", null, null, "Ray Goodwin", "342.898.8019 x8641" },
                    { 88, 7, null, null, "Colby26@yahoo.com", null, null, "Marta Emard", "(523) 881-0575" },
                    { 89, 13, null, null, "Shanny.Fay@hotmail.com", null, null, "Cesar Hahn", "779.752.5148 x14954" },
                    { 90, 21, null, null, "Connie15@hotmail.com", null, null, "Darrel Casper", "775-921-3569 x04141" },
                    { 91, 15, null, null, "Mohammad44@gmail.com", null, null, "Cary Grant", "743.491.0033" },
                    { 92, 19, null, null, "Joyce_Quitzon10@hotmail.com", null, null, "Kassandra Legros", "1-414-359-5227" },
                    { 93, 18, null, null, "Claudine83@hotmail.com", null, null, "Jerome Conn", "1-413-736-1609 x831" },
                    { 94, 18, null, null, "Abdiel_Gottlieb47@hotmail.com", null, null, "Kariane Shanahan", "(941) 250-5397" },
                    { 95, 7, null, null, "Braeden.Bartell@gmail.com", null, null, "Elva Lind", "1-627-555-3460" },
                    { 96, 9, null, null, "Brenden24@yahoo.com", null, null, "Josefa Dicki", "1-375-657-0306 x76598" },
                    { 97, 5, null, null, "Mallie12@hotmail.com", null, null, "Kamille Ferry", "(871) 212-2289" },
                    { 98, 17, null, null, "Lora_Kirlin@gmail.com", null, null, "Bertrand Sanford", "372-216-7390 x43136" },
                    { 99, 6, null, null, "Magali35@hotmail.com", null, null, "Charles Murphy", "1-446-880-4092 x175" },
                    { 100, 23, null, null, "Marco.Kovacek@yahoo.com", null, null, "Kennith Rowe", "715.754.1754" }
                });

            migrationBuilder.InsertData(
                table: "Leads",
                columns: new[] { "Id", "AccountId", "CreatedAt", "CreatedBy", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "ModifiedAt", "ModifiedBy", "Source", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 25, null, null, "Neque alias commodi sunt nisi eaque vitae officia corrupti dolor doloribus nam nisi natus.", null, null, null, 48634.0, null, null, 1, 1, "Aut iste qui similique inventore hic." },
                    { 2, 20, null, null, "Repellendus sunt rerum unde eligendi ut excepturi culpa consequuntur eveniet quo.", null, null, null, 253813.0, null, null, 2, 1, "Enim delectus dolores." },
                    { 3, 10, null, null, "Aut vitae qui eveniet soluta eum et excepturi alias nesciunt molestiae doloremque velit a in quis atque dolorem.", null, null, null, 73256.0, null, null, 4, 0, "Minima eos vero quia natus." },
                    { 4, 8, null, null, "Amet iure sit laudantium amet quisquam et eos autem sunt inventore cupiditate dolor aspernatur nesciunt dolorem aut.", "Qui iste et rem quo error nihil exercitationem exercitationem omnis aspernatur laboriosam quia qui non fuga nam reprehenderit repellendus sint inventore facilis libero ut esse nostrum ipsam ad.", 2, new DateTime(2022, 10, 6, 20, 41, 3, 607, DateTimeKind.Local).AddTicks(5761), 203810.0, null, null, 1, 3, "Ipsa commodi culpa." },
                    { 5, 25, null, null, "Est dolorem odit accusantium vel dignissimos rerum hic veniam omnis hic inventore ut ut non facere quis ipsa minima accusantium ratione repellendus.", null, null, new DateTime(2022, 12, 6, 0, 18, 6, 198, DateTimeKind.Local).AddTicks(6948), 164594.0, null, null, 0, 2, "Qui rerum id." },
                    { 6, 21, null, null, "Deleniti dolorem excepturi eum perspiciatis provident veniam odit et quis fuga voluptatem neque eos corrupti fugit id ipsum hic perspiciatis ut nihil ducimus laboriosam.", null, null, null, 38532.0, null, null, 4, 0, "Inventore enim aliquam sed dolorem odit." },
                    { 7, 13, null, null, "Occaecati voluptatem laboriosam eum adipisci nihil optio vel amet a eos.", null, null, null, 466699.0, null, null, 1, 0, "Voluptatibus quod eum et quo eaque." },
                    { 8, 16, null, null, "Nihil ut porro ut quaerat consectetur dolores perferendis architecto et sint velit cupiditate.", "Culpa inventore velit voluptatibus et voluptate fuga eum aut architecto qui excepturi molestiae modi officiis ratione laborum eligendi occaecati deleniti.", 3, new DateTime(2023, 3, 24, 8, 53, 2, 476, DateTimeKind.Local).AddTicks(7032), 224465.0, null, null, 3, 3, "Sint quasi dolorem numquam." },
                    { 9, 9, null, null, "Dolor dolores illo facere nisi quia consequuntur similique quidem repellendus repudiandae magni repudiandae nemo voluptatem nemo qui dolores dolores est odit sequi et.", "Quisquam voluptate saepe voluptatibus aut eligendi quos placeat assumenda maiores soluta reiciendis vero harum cumque molestiae omnis ut qui enim unde.", 4, new DateTime(2022, 10, 6, 0, 41, 42, 326, DateTimeKind.Local).AddTicks(4785), 100803.0, null, null, 0, 3, "Molestiae nulla doloribus." },
                    { 10, 20, null, null, "Quo nisi sunt quod placeat quo similique expedita et magni porro voluptatem voluptates illo deserunt aperiam tenetur fugiat enim assumenda assumenda ut vel qui earum magnam aperiam omnis et.", null, null, null, 218704.0, null, null, 2, 0, "Sint dolor repellendus autem quisquam." },
                    { 11, 19, null, null, "Similique laudantium itaque non sunt dolores eveniet officiis quo quam reprehenderit vel beatae voluptas consequatur officia natus odio repellat est hic alias.", "Quis eum suscipit veniam iure incidunt assumenda sint repellendus reiciendis quis laudantium et omnis cupiditate accusamus suscipit nobis soluta aut eligendi nemo eos.", 2, new DateTime(2023, 4, 18, 19, 38, 48, 897, DateTimeKind.Local).AddTicks(7889), 482232.0, null, null, 2, 3, "Earum quos modi reiciendis fugit." },
                    { 12, 2, null, null, "Aut nesciunt aut debitis unde iusto eos dolore explicabo similique voluptates consequatur reiciendis omnis beatae corporis eos ab rerum provident rerum consequatur quo porro est rerum ex.", null, null, new DateTime(2023, 3, 18, 3, 58, 2, 960, DateTimeKind.Local).AddTicks(708), 122444.0, null, null, 4, 2, "Ullam quibusdam molestias sint necessitatibus." },
                    { 13, 21, null, null, "Eaque est illum modi in error vitae ut quis dignissimos incidunt et nihil eum alias itaque repellendus laboriosam aut ad et.", null, null, null, 124223.0, null, null, 2, 0, "Iste totam sed et sit et." },
                    { 14, 13, null, null, "Dolorem quam sit itaque eum doloremque qui aut fuga architecto minus non provident perspiciatis delectus non et magnam eos facere aut atque neque velit quod voluptatibus facere.", null, null, null, 223621.0, null, null, 2, 1, "Autem dolorum est." },
                    { 15, 20, null, null, "Autem maiores culpa saepe incidunt vitae sint totam mollitia sint.", "Cumque minus voluptates id quae qui rem soluta consequuntur voluptatem tenetur vitae ipsam deserunt aut sit.", 4, new DateTime(2022, 8, 24, 21, 43, 9, 830, DateTimeKind.Local).AddTicks(5131), 48757.0, null, null, 0, 3, "Aliquam aut quod aut." },
                    { 16, 14, null, null, "Labore modi ut est voluptas harum eum officiis vero et ea perferendis dolorum.", "Sit laborum et quia et doloribus voluptatem optio at quia voluptatem voluptatem aliquam ut temporibus maiores repellendus cupiditate voluptatem dolorum quas qui sunt iste tenetur.", 3, new DateTime(2022, 9, 15, 15, 51, 30, 292, DateTimeKind.Local).AddTicks(7813), 463146.0, null, null, 0, 3, "Soluta qui fuga corrupti minus molestias." },
                    { 17, 1, null, null, "Iste adipisci quis omnis et ut consequatur velit omnis minima odio adipisci expedita sed praesentium quasi delectus dolorem accusamus ratione temporibus sed voluptatum et aut quidem est.", null, null, null, 115651.0, null, null, 3, 0, "Esse sunt voluptatum laudantium." },
                    { 18, 7, null, null, "Eum cupiditate dolorem qui labore debitis fuga cumque odit incidunt et quibusdam quia dolor perferendis et et et ut exercitationem iure excepturi quia magnam eveniet et aspernatur molestiae.", null, null, null, 29484.0, null, null, 1, 1, "Voluptas omnis tempora omnis." },
                    { 19, 18, null, null, "Temporibus voluptate aut in enim doloribus ut quia quod quia ut in libero rem tempora quo voluptate et hic qui omnis voluptatem est quisquam hic doloribus quod.", "Dolor reiciendis magnam odio sed rerum repudiandae ut quidem voluptates eaque fugiat vel.", 1, new DateTime(2022, 11, 10, 4, 12, 47, 194, DateTimeKind.Local).AddTicks(7751), 445876.0, null, null, 2, 3, "Est quam culpa totam earum debitis." },
                    { 20, 21, null, null, "Dolorem eaque corporis saepe odio sed laudantium aut sed distinctio sequi cupiditate facere nulla fugit et qui numquam voluptas est corrupti dolores.", null, null, null, 157623.0, null, null, 4, 1, "Sequi fuga rerum velit deleniti modi." },
                    { 21, 23, null, null, "Aut est error error ipsa facilis aliquam rerum fuga eum quia nemo ut ut quis ut amet dolores adipisci voluptatibus tempore corporis.", null, null, null, 153865.0, null, null, 0, 1, "Corporis fugit nobis eligendi dolorem possimus." },
                    { 22, 23, null, null, "Non quam adipisci qui aspernatur tenetur voluptatibus quibusdam et culpa sit.", "Vero repellat quasi voluptates recusandae fugit delectus sint delectus asperiores sunt sit quam voluptate illum voluptatem soluta nobis et aut quisquam vel aliquid ex.", 3, new DateTime(2022, 7, 27, 18, 54, 18, 668, DateTimeKind.Local).AddTicks(6998), 272734.0, null, null, 1, 3, "Reiciendis tenetur ex est at." },
                    { 23, 6, null, null, "Hic occaecati vel aut quia dolores sunt molestiae cumque molestias ad aspernatur.", null, null, null, 363180.0, null, null, 0, 1, "Ut ut suscipit nemo in." },
                    { 24, 11, null, null, "Perferendis et qui harum ab sint nulla rem eos aliquid soluta a deleniti quae hic sed eos dolorem harum expedita aut molestiae ducimus cumque vel explicabo.", null, null, null, 80767.0, null, null, 4, 1, "Cupiditate dolorem libero voluptatem accusamus." },
                    { 25, 10, null, null, "Voluptas explicabo et at voluptatum molestiae architecto velit in quam distinctio quod nam similique quos autem veniam consequuntur aspernatur rerum voluptas.", null, null, null, 457540.0, null, null, 2, 0, "Consectetur aut molestias numquam est." },
                    { 26, 13, null, null, "Omnis ab quo autem commodi reprehenderit in similique quae qui a animi commodi laudantium expedita repellendus quia fugit sequi libero magnam dolor non quae.", "Doloremque aperiam possimus laborum maxime quis et eos et dolor velit odio dolor dolores.", 3, new DateTime(2023, 2, 13, 15, 23, 27, 246, DateTimeKind.Local).AddTicks(2144), 147738.0, null, null, 2, 3, "Consequatur sapiente animi." },
                    { 27, 14, null, null, "Ratione voluptatem ea quia autem enim cupiditate odit debitis maiores nesciunt aut nulla ut et nulla.", null, null, null, 46888.0, null, null, 3, 0, "Temporibus est maxime." },
                    { 28, 9, null, null, "Officiis molestiae beatae et quisquam voluptatem veniam eos dolorem eos impedit ut exercitationem ipsa amet.", null, null, null, 499902.0, null, null, 3, 0, "Ipsam provident repudiandae consequatur placeat." },
                    { 29, 8, null, null, "Voluptatibus ut sit non soluta vel dolorem quia rem voluptates est asperiores voluptas quo rerum sapiente quia vero velit.", null, null, null, 288184.0, null, null, 0, 1, "Enim qui reprehenderit." },
                    { 30, 4, null, null, "Et dolor recusandae est soluta et et hic deleniti nostrum ipsum voluptates aut accusantium.", null, null, null, 265986.0, null, null, 4, 0, "Vel harum deleniti." }
                });

            migrationBuilder.InsertData(
                table: "Deals",
                columns: new[] { "Id", "ActualRevenue", "CreatedAt", "CreatedBy", "Description", "LeadId", "ModifiedAt", "ModifiedBy", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 414798.0, null, null, "Facilis asperiores itaque qui magni minima est quia suscipit ullam nemo sunt.", 1, null, null, 1, "Non quis eum sed." },
                    { 2, 264385.0, null, null, "Eveniet non atque natus distinctio quisquam atque est voluptate rerum.", 2, null, null, 1, "Neque voluptatem facere amet quo non." },
                    { 3, 358718.0, null, null, "Quisquam et deserunt recusandae sequi assumenda unde non porro quas reprehenderit iste et quisquam quos at expedita.", 3, null, null, 0, "Deleniti earum et minus." },
                    { 4, 217275.0, null, null, "Soluta omnis consectetur ex aut et ab veritatis quas voluptatem et qui veritatis quos.", 4, null, null, 0, "Aut quia architecto suscipit iusto exercitationem." },
                    { 5, 152682.0, null, null, "Et sequi placeat sed aut et impedit soluta ut aperiam eos tempore eaque corrupti unde nemo tenetur numquam.", 5, null, null, 2, "Quam expedita alias temporibus." },
                    { 6, 131083.0, null, null, "Eveniet ipsa ipsam est similique sed sed eveniet nobis repellat voluptates.", 6, null, null, 1, "Architecto perspiciatis quia." },
                    { 7, 401542.0, null, null, "Ipsam vero consequuntur ut sit sunt quia soluta aut temporibus aliquam ea veniam quaerat voluptatem autem optio ipsum quibusdam enim suscipit temporibus ea.", 7, null, null, 1, "Atque blanditiis et." },
                    { 8, 183418.0, null, null, "Beatae id ut eligendi debitis ipsam temporibus officia distinctio ratione repellendus est quis provident fugiat pariatur dolor eius magnam ducimus ut earum est.", 8, null, null, 0, "Nemo cum quam fuga harum." },
                    { 9, 165942.0, null, null, "Et in consequatur minima fuga quisquam quia ea voluptatem qui fuga nihil quidem eveniet esse quia et molestias et corrupti eius quia.", 9, null, null, 1, "In nihil vel quasi placeat." },
                    { 10, 264882.0, null, null, "Harum qui repellendus quidem est et sit sint cumque dolor suscipit ex dignissimos et natus occaecati rerum id et in.", 10, null, null, 1, "Optio sit quia hic eius." },
                    { 11, 235205.0, null, null, "Necessitatibus quia blanditiis id autem aut rerum debitis in iusto laboriosam explicabo expedita qui.", 11, null, null, 0, "Temporibus nihil voluptatum et omnis." },
                    { 12, 371353.0, null, null, "Omnis earum iure ut reprehenderit repudiandae in omnis libero officiis amet.", 12, null, null, 1, "At consequuntur ut delectus optio." },
                    { 13, 292213.0, null, null, "Architecto ut suscipit dolor minus voluptatem voluptatem rerum dolorem nostrum iure explicabo laudantium.", 13, null, null, 1, "Totam beatae nihil." },
                    { 14, 192476.0, null, null, "Ea doloribus id asperiores quia eaque quod et totam est nemo doloremque quia doloribus quo recusandae doloremque nostrum aliquam rerum natus corrupti et.", 14, null, null, 1, "Ratione quis quia." },
                    { 15, 60014.0, null, null, "Labore voluptas reiciendis neque consectetur officiis laboriosam necessitatibus quis nemo id illum autem commodi est voluptate ea aut nobis est laborum ut ex minima laudantium.", 15, null, null, 2, "Itaque nisi omnis sint." },
                    { 16, 354194.0, null, null, "Tempore cupiditate mollitia voluptas qui quis suscipit fugiat laborum tempora.", 16, null, null, 1, "Atque rerum fugiat officia." },
                    { 17, 132023.0, null, null, "Quia fugit quo exercitationem quia repellat veritatis qui tempora illo voluptas omnis tenetur molestias et.", 17, null, null, 0, "Quos quibusdam aut ut ut." },
                    { 18, 284674.0, null, null, "Aut aut perferendis sit ea sed sapiente sed saepe facere impedit et maiores cum sit recusandae id esse accusamus ea aut.", 18, null, null, 1, "Ipsum quia asperiores." },
                    { 19, 367020.0, null, null, "Reiciendis nihil quis voluptatum quia exercitationem ut soluta occaecati est sequi et necessitatibus aspernatur quaerat excepturi eum sequi officiis dolorem aspernatur dolor dolorem.", 19, null, null, 2, "Eos officia excepturi earum." },
                    { 20, 463513.0, null, null, "Voluptatum et natus dolores tenetur qui adipisci laboriosam repellat illum.", 20, null, null, 1, "Cum ut excepturi et." },
                    { 21, 81031.0, null, null, "Atque libero non qui porro mollitia ut incidunt sunt dolor est ad sunt.", 21, null, null, 1, "Porro et natus." },
                    { 22, 394226.0, null, null, "Consequuntur nemo modi eum laudantium est sit est ea nostrum amet deleniti minus repellendus illum voluptatem ut ipsum aut velit beatae est.", 22, null, null, 1, "Consequatur impedit minima magnam sit." },
                    { 23, 290991.0, null, null, "Voluptatum provident fuga eos eius et deleniti dolores tempora eum nemo in dolor in labore et aperiam accusamus debitis et dolores repudiandae quisquam.", 23, null, null, 2, "Error culpa assumenda sunt et animi." },
                    { 24, 206035.0, null, null, "Labore mollitia error temporibus modi fugit voluptas dolores ad deleniti pariatur excepturi ullam ut quos tenetur natus dolores qui consequatur omnis sapiente quos eaque.", 24, null, null, 1, "Non eaque voluptate corrupti." },
                    { 25, 464184.0, null, null, "Quas quisquam maxime modi eligendi provident aut suscipit delectus vel reiciendis similique doloremque sit autem ratione ut ut expedita cupiditate fugit quas.", 25, null, null, 1, "Velit doloribus ipsa dolorem." },
                    { 26, 421276.0, null, null, "Sint dolorem atque ut temporibus nesciunt repellendus nihil laborum eius itaque cumque.", 26, null, null, 1, "Temporibus nemo optio et." },
                    { 27, 441643.0, null, null, "Illum molestiae qui expedita magni et beatae fugiat consequatur quia reiciendis aspernatur molestiae recusandae asperiores accusantium reprehenderit asperiores est.", 27, null, null, 2, "Dicta inventore dolorum et atque." },
                    { 28, 340188.0, null, null, "Temporibus pariatur officia eum aliquam repudiandae optio animi quia impedit sapiente et cumque qui quo veniam totam est modi et ut beatae.", 28, null, null, 2, "Qui soluta ratione aut sed." },
                    { 29, 160885.0, null, null, "Est nihil vero rerum sit maxime eveniet ut dolorem quos incidunt eveniet sed ut rerum doloremque sed est dolore doloremque quos veniam ipsa.", 29, null, null, 0, "Asperiores eius fuga eum expedita." },
                    { 30, 349130.0, null, null, "Maiores magnam sit doloremque voluptas voluptates est eius architecto ea facilis numquam et.", 30, null, null, 0, "Voluptates maxime quidem maxime." }
                });

            migrationBuilder.InsertData(
                table: "DealProducts",
                columns: new[] { "DealId", "Id", "ProductId", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "PricePerUnit", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 3, null, null, null, null, 59.0, 32 },
                    { 2, 1, 10, null, null, null, null, 28.0, 19 },
                    { 3, 1, 3, null, null, null, null, 55.0, 100 },
                    { 4, 1, 4, null, null, null, null, 62.0, 30 },
                    { 5, 1, 2, null, null, null, null, 94.0, 97 },
                    { 6, 1, 5, null, null, null, null, 33.0, 94 },
                    { 7, 1, 5, null, null, null, null, 76.0, 40 },
                    { 8, 1, 5, null, null, null, null, 31.0, 11 },
                    { 9, 1, 3, null, null, null, null, 42.0, 30 },
                    { 10, 1, 6, null, null, null, null, 13.0, 77 },
                    { 11, 1, 3, null, null, null, null, 35.0, 39 },
                    { 12, 1, 3, null, null, null, null, 58.0, 51 },
                    { 13, 1, 10, null, null, null, null, 20.0, 19 },
                    { 14, 1, 6, null, null, null, null, 56.0, 78 },
                    { 15, 1, 8, null, null, null, null, 67.0, 78 },
                    { 16, 1, 10, null, null, null, null, 63.0, 34 },
                    { 17, 1, 5, null, null, null, null, 41.0, 14 },
                    { 18, 1, 9, null, null, null, null, 85.0, 59 },
                    { 19, 1, 6, null, null, null, null, 48.0, 55 },
                    { 20, 1, 3, null, null, null, null, 73.0, 8 },
                    { 21, 1, 1, null, null, null, null, 25.0, 53 },
                    { 22, 1, 2, null, null, null, null, 27.0, 77 },
                    { 23, 1, 10, null, null, null, null, 27.0, 51 },
                    { 24, 1, 1, null, null, null, null, 62.0, 86 },
                    { 25, 1, 5, null, null, null, null, 50.0, 97 },
                    { 26, 1, 3, null, null, null, null, 64.0, 41 },
                    { 27, 1, 5, null, null, null, null, 41.0, 68 },
                    { 28, 1, 1, null, null, null, null, 12.0, 23 },
                    { 29, 1, 7, null, null, null, null, 48.0, 36 },
                    { 30, 1, 10, null, null, null, null, 40.0, 26 }
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
