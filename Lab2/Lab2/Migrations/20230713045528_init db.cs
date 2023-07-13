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
                    DealId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    PricePerUnit = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    { 1, "1412 Malika Views, South Marisolberg, Belarus", null, null, "Zetta.Zemlak@yahoo.com", null, null, "Larkin and Sons", "682.694.0306", 10037.0 },
                    { 2, "8989 Smith Manors, West Skylar, Myanmar", null, null, "Hassie_Bahringer16@yahoo.com", null, null, "Kulas, D'Amore and Brekke", "(488) 759-6309 x6904", 27935.0 },
                    { 3, "946 Rasheed Oval, East Ethan, Guadeloupe", null, null, "Zaria_Casper@hotmail.com", null, null, "Torphy LLC", "932-976-3081", 12206.0 },
                    { 4, "514 Jamie Extensions, Jenkinsmouth, Bhutan", null, null, "Gerson_Murphy18@gmail.com", null, null, "Rice Inc", "(295) 422-2498 x12630", 22990.0 },
                    { 5, "29642 Solon Valley, New Tracey, Cote d'Ivoire", null, null, "Jovany98@gmail.com", null, null, "Gleichner LLC", "1-620-670-1513", 11825.0 },
                    { 6, "20579 Jewel Canyon, Kutchside, Senegal", null, null, "Gilberto_Schiller13@hotmail.com", null, null, "Zemlak, Blanda and Schmidt", "(383) 242-7830 x640", 11563.0 },
                    { 7, "1895 Boyer Light, Nicktown, Turks and Caicos Islands", null, null, "Vernice_Harber16@yahoo.com", null, null, "Conn LLC", "536.294.8434", 17723.0 },
                    { 8, "9538 Jaren Glens, East Mitchell, Palestinian Territory", null, null, "Jazmyn85@hotmail.com", null, null, "Larkin Group", "737.720.6645 x518", 15682.0 },
                    { 9, "585 Cathy Rue, Thielberg, Afghanistan", null, null, "Miller90@gmail.com", null, null, "Larkin LLC", "1-867-385-1002 x82744", 32687.0 },
                    { 10, "185 Jo Square, Delphinemouth, Belgium", null, null, "Jodie.Block@hotmail.com", null, null, "Christiansen - Willms", "264-441-3583 x74877", 35863.0 },
                    { 11, "802 Skye Tunnel, Port Aishaburgh, New Zealand", null, null, "Anastacio.Wyman54@gmail.com", null, null, "Johnston, Hodkiewicz and Ritchie", "926-331-4721", 3308.0 },
                    { 12, "69648 Haag Canyon, Ethylland, Saint Vincent and the Grenadines", null, null, "Skyla90@yahoo.com", null, null, "King Inc", "1-253-687-2979", 9497.0 },
                    { 13, "7811 Deion Trail, West Hazle, Vanuatu", null, null, "Jarvis11@yahoo.com", null, null, "Breitenberg - Zemlak", "997-379-6914 x08395", 44123.0 },
                    { 14, "89989 Oma Throughway, Port Luis, Norfolk Island", null, null, "Norval.Schultz@yahoo.com", null, null, "Gerlach - Hoppe", "579-838-2112", 11711.0 },
                    { 15, "59219 Maggio Locks, Fritschport, Montserrat", null, null, "Linda.Dooley34@hotmail.com", null, null, "Yost - Mueller", "1-419-928-6722 x84435", 1224.0 },
                    { 16, "098 Devante Ville, Port Destineeton, Mayotte", null, null, "Jarrell51@yahoo.com", null, null, "Hilll - Schiller", "1-821-239-6519", 49858.0 },
                    { 17, "932 Clifton Harbors, Kihntown, American Samoa", null, null, "Jakayla.Waters@yahoo.com", null, null, "Smitham, Parisian and Sanford", "(962) 457-4239", 17299.0 },
                    { 18, "05250 Erdman Rest, Ivoryton, Norway", null, null, "Mathilde.Renner45@yahoo.com", null, null, "Jast - Pacocha", "209.884.1618 x1991", 34980.0 },
                    { 19, "72307 O'Conner Run, Kileyborough, Lao People's Democratic Republic", null, null, "Dahlia46@gmail.com", null, null, "Jacobs - Jones", "1-651-870-6134 x422", 10493.0 },
                    { 20, "29118 Wehner Creek, Hermistonview, French Polynesia", null, null, "Skyla96@gmail.com", null, null, "Schamberger - Nitzsche", "1-714-422-8683 x679", 29381.0 },
                    { 21, "96513 Littel Keys, Ismaelland, Nepal", null, null, "Herminia28@hotmail.com", null, null, "Tromp, Jerde and Johns", "380.748.5753 x72258", 6416.0 },
                    { 22, "3605 Iva Heights, Beahanland, Republic of Korea", null, null, "Janie33@gmail.com", null, null, "Gibson, Torp and Ryan", "(719) 718-6843", 32813.0 },
                    { 23, "0270 Enrico Haven, West Joanniefort, Luxembourg", null, null, "Twila61@yahoo.com", null, null, "Zulauf - Koch", "211.404.4249 x08011", 617.0 },
                    { 24, "33203 Metz Trail, Alainachester, Jersey", null, null, "Stephanie.Halvorson@yahoo.com", null, null, "Volkman - Auer", "683-960-5688", 5281.0 },
                    { 25, "23200 Cronin Isle, Felipaview, Equatorial Guinea", null, null, "Shyann6@hotmail.com", null, null, "Goldner - Rice", "532-845-5329 x5252", 40482.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsAvailable", "ModifiedAt", "ModifiedBy", "Name", "Price", "ProductCode", "Type" },
                values: new object[,]
                {
                    { 1, null, null, true, null, null, "Unbranded Soft Pizza", 765.0, "PRO-83467271", 1 },
                    { 2, null, null, true, null, null, "Ergonomic Cotton Salad", 391.0, "PRO-97575252", 1 },
                    { 3, null, null, true, null, null, "Refined Soft Fish", 512.0, "PRO-66102946", 0 },
                    { 4, null, null, true, null, null, "Fantastic Cotton Chips", 820.0, "PRO-71118369", 0 },
                    { 5, null, null, true, null, null, "Handcrafted Frozen Gloves", 204.0, "PRO-57227979", 1 },
                    { 6, null, null, true, null, null, "Sleek Plastic Pizza", 796.0, "PRO-64018881", 1 },
                    { 7, null, null, true, null, null, "Generic Plastic Pants", 443.0, "PRO-81293506", 1 },
                    { 8, null, null, true, null, null, "Fantastic Steel Chicken", 813.0, "PRO-12422371", 1 },
                    { 9, null, null, true, null, null, "Practical Fresh Pizza", 192.0, "PRO-58926147", 1 },
                    { 10, null, null, true, null, null, "Sleek Concrete Computer", 865.0, "PRO-97373216", 1 }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "AccountId", "CreatedAt", "CreatedBy", "Email", "ModifiedAt", "ModifiedBy", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, 3, null, null, "Kacie.Hoppe@hotmail.com", null, null, "Deangelo Grant", "1-586-871-4797" },
                    { 2, 7, null, null, "Maude.Treutel@yahoo.com", null, null, "Zackary Thiel", "915.271.1584" },
                    { 3, 3, null, null, "Ellen77@hotmail.com", null, null, "Davion Douglas", "484-885-0873 x31341" },
                    { 4, 6, null, null, "Annabel56@hotmail.com", null, null, "Avis Ryan", "876-265-8198" },
                    { 5, 25, null, null, "Marguerite85@hotmail.com", null, null, "Aron O'Keefe", "391.685.7757" },
                    { 6, 25, null, null, "Annamae.Vandervort38@hotmail.com", null, null, "Isabelle Cronin", "1-226-441-0576 x72441" },
                    { 7, 25, null, null, "Dejah.Christiansen@hotmail.com", null, null, "Nels Wiegand", "775-785-5917 x00702" },
                    { 8, 14, null, null, "Buck.Grimes62@yahoo.com", null, null, "Sadie Erdman", "946-499-5955 x84652" },
                    { 9, 14, null, null, "Henriette59@yahoo.com", null, null, "Gennaro Shanahan", "(924) 788-5311" },
                    { 10, 12, null, null, "Lucious.Cartwright@yahoo.com", null, null, "Reid Mitchell", "517.512.8567 x91148" },
                    { 11, 4, null, null, "Leda21@gmail.com", null, null, "Evelyn White", "227.614.3793 x8938" },
                    { 12, 25, null, null, "Kaylie3@gmail.com", null, null, "Anita Larson", "(332) 226-3823" },
                    { 13, 13, null, null, "Janet_Koelpin@hotmail.com", null, null, "Lindsey Kertzmann", "256-339-0517" },
                    { 14, 25, null, null, "Derick_Olson@yahoo.com", null, null, "Giovanna Hand", "872-462-0897" },
                    { 15, 3, null, null, "Schuyler.Koepp@hotmail.com", null, null, "Garfield Tremblay", "915-515-4798" },
                    { 16, 4, null, null, "Kaleigh87@yahoo.com", null, null, "Virginie Hansen", "1-227-407-1153 x273" },
                    { 17, 10, null, null, "Alessandro39@yahoo.com", null, null, "Erin Hilpert", "(938) 489-5326 x123" },
                    { 18, 16, null, null, "Genesis_Walker92@hotmail.com", null, null, "Marley Rempel", "638.372.7017 x565" },
                    { 19, 10, null, null, "Chaim_Kub71@hotmail.com", null, null, "Hollie Kunze", "1-215-844-8788" },
                    { 20, 19, null, null, "Tevin_Considine27@hotmail.com", null, null, "Sigmund Oberbrunner", "1-878-657-3874 x95539" },
                    { 21, 22, null, null, "Nicholas94@gmail.com", null, null, "Burdette Nitzsche", "(388) 923-9989 x1061" },
                    { 22, 23, null, null, "Keaton.Tremblay@yahoo.com", null, null, "Aliyah Wyman", "(733) 450-2366 x15498" },
                    { 23, 24, null, null, "Murphy94@yahoo.com", null, null, "Lucienne Lebsack", "526.533.6033 x701" },
                    { 24, 2, null, null, "Florine.Mraz33@gmail.com", null, null, "Una Becker", "(200) 631-1248" },
                    { 25, 1, null, null, "Alena62@hotmail.com", null, null, "Anne King", "755-685-9703" },
                    { 26, 7, null, null, "Gerardo.Kling@gmail.com", null, null, "Leonel Klocko", "(877) 916-0297 x4026" },
                    { 27, 23, null, null, "Jeremie76@yahoo.com", null, null, "Brook Schamberger", "1-494-501-0742" },
                    { 28, 7, null, null, "Cecelia_Senger@gmail.com", null, null, "Kyle Connelly", "502.496.6796 x423" },
                    { 29, 8, null, null, "Odessa_Daniel@hotmail.com", null, null, "Blake Koepp", "560.427.8848 x791" },
                    { 30, 1, null, null, "Johnpaul69@yahoo.com", null, null, "Helen Mann", "1-709-711-5668 x9964" },
                    { 31, 13, null, null, "Bella_Prohaska47@yahoo.com", null, null, "Khalid Corwin", "(498) 857-6567 x91778" },
                    { 32, 15, null, null, "Vernice.Gislason@gmail.com", null, null, "Marvin Champlin", "1-218-839-6735 x0152" },
                    { 33, 15, null, null, "Freeda0@hotmail.com", null, null, "Carol Rau", "(847) 929-1170" },
                    { 34, 20, null, null, "Jared.Johnston4@hotmail.com", null, null, "Nicola Fisher", "(678) 738-9531 x6176" },
                    { 35, 11, null, null, "Demetrius.Mosciski@gmail.com", null, null, "Nelson Beer", "278.959.9344 x956" },
                    { 36, 10, null, null, "Bryana_Rodriguez@yahoo.com", null, null, "Adele Pfannerstill", "(367) 648-1131 x01052" },
                    { 37, 7, null, null, "Moriah_Mueller@hotmail.com", null, null, "Lucius Terry", "697-461-3245" },
                    { 38, 14, null, null, "Macie.Schowalter@gmail.com", null, null, "Orie Aufderhar", "1-320-267-6020" },
                    { 39, 9, null, null, "Jedidiah65@gmail.com", null, null, "Jessyca Tremblay", "802-775-1454 x5519" },
                    { 40, 8, null, null, "Adela33@yahoo.com", null, null, "Jaylin Towne", "1-805-971-5277 x932" },
                    { 41, 22, null, null, "Mariane14@gmail.com", null, null, "Kaley Kessler", "(251) 674-0173 x27481" },
                    { 42, 17, null, null, "Charlie.Weber@yahoo.com", null, null, "Randi Rodriguez", "(970) 497-4695 x35616" },
                    { 43, 23, null, null, "Oran_Kuhic32@hotmail.com", null, null, "Alysa Heaney", "(512) 554-8707 x2790" },
                    { 44, 23, null, null, "Clement_Lindgren83@gmail.com", null, null, "Yasmin Hegmann", "263.512.1180 x78281" },
                    { 45, 3, null, null, "Janick75@hotmail.com", null, null, "Zelma Ullrich", "812-871-1625 x118" },
                    { 46, 7, null, null, "Kaylah_Dare@hotmail.com", null, null, "Al Cronin", "897-619-1259 x8882" },
                    { 47, 16, null, null, "Colt.Hartmann@yahoo.com", null, null, "Adolphus Steuber", "823-437-4456" },
                    { 48, 15, null, null, "Georgianna_Bruen@gmail.com", null, null, "Yasmine Rogahn", "(633) 777-8091 x8005" },
                    { 49, 13, null, null, "Mason.Lynch97@yahoo.com", null, null, "Lavonne VonRueden", "1-610-882-7303" },
                    { 50, 14, null, null, "Royal88@yahoo.com", null, null, "Angelo Yundt", "931.387.8752" },
                    { 51, 6, null, null, "Barry_Cormier@hotmail.com", null, null, "Sarina Heidenreich", "(973) 333-4833 x834" },
                    { 52, 2, null, null, "Jaquelin_Rice@hotmail.com", null, null, "Alexandre Feil", "678.348.8027" },
                    { 53, 14, null, null, "Tabitha.Zieme70@gmail.com", null, null, "Eveline Conroy", "344-568-1128" },
                    { 54, 5, null, null, "Chadd42@gmail.com", null, null, "Nichole Legros", "219-460-5579 x94570" },
                    { 55, 23, null, null, "Dennis_Hermiston@gmail.com", null, null, "Houston Kertzmann", "(509) 357-6101" },
                    { 56, 3, null, null, "Derick_Willms@yahoo.com", null, null, "Brandi Paucek", "1-222-350-3665" },
                    { 57, 9, null, null, "Marlin.OConnell@gmail.com", null, null, "Madge Ledner", "(971) 495-8354 x60860" },
                    { 58, 13, null, null, "Jayson_Erdman@hotmail.com", null, null, "Madge Wintheiser", "1-256-751-4677" },
                    { 59, 1, null, null, "Kaley_Weimann1@hotmail.com", null, null, "Haven Jakubowski", "605.998.7249 x454" },
                    { 60, 21, null, null, "Oral7@gmail.com", null, null, "Johanna Casper", "848.912.7241 x3037" },
                    { 61, 1, null, null, "Nichole47@hotmail.com", null, null, "Abner Kohler", "(546) 526-5168 x66223" },
                    { 62, 11, null, null, "Deja.OReilly@hotmail.com", null, null, "Kari Anderson", "362-234-8510" },
                    { 63, 24, null, null, "Ophelia23@yahoo.com", null, null, "Floyd Jakubowski", "1-991-449-8873 x4799" },
                    { 64, 11, null, null, "Katarina.Barton88@gmail.com", null, null, "Brandon Gibson", "1-835-872-2411 x2823" },
                    { 65, 24, null, null, "Matt.Kling@yahoo.com", null, null, "Quinton Steuber", "770.239.8375 x90508" },
                    { 66, 9, null, null, "Marco_Cassin27@yahoo.com", null, null, "Brandon Weber", "450.672.4688" },
                    { 67, 10, null, null, "Vesta.Reichert48@gmail.com", null, null, "Juliet Lesch", "1-815-360-8684 x68105" },
                    { 68, 14, null, null, "Curtis.Morar@gmail.com", null, null, "Leonard MacGyver", "(472) 422-5369 x1350" },
                    { 69, 6, null, null, "Catharine78@yahoo.com", null, null, "Gennaro Brekke", "(656) 734-4050 x65540" },
                    { 70, 2, null, null, "Harmony99@hotmail.com", null, null, "Leanna Cronin", "932.242.7522" },
                    { 71, 1, null, null, "Kieran_Doyle37@gmail.com", null, null, "Charley Kunde", "1-465-939-0595" },
                    { 72, 5, null, null, "Laurianne.Jacobson@hotmail.com", null, null, "Dennis Johnston", "1-755-410-3403 x534" },
                    { 73, 15, null, null, "Johathan40@gmail.com", null, null, "Raina Champlin", "327-450-5330 x31603" },
                    { 74, 20, null, null, "Delta97@yahoo.com", null, null, "Jacinthe Mueller", "1-943-817-8647 x482" },
                    { 75, 17, null, null, "Ansel_Cummings@yahoo.com", null, null, "Eve Block", "263.350.6578 x6417" },
                    { 76, 18, null, null, "Gracie98@yahoo.com", null, null, "Ernest Schaden", "674.312.3657" },
                    { 77, 15, null, null, "Dora_Sauer70@gmail.com", null, null, "Ernestina Hermann", "374.484.4184 x880" },
                    { 78, 18, null, null, "Terry_Carroll@hotmail.com", null, null, "Chelsea Barrows", "842.602.2150 x246" },
                    { 79, 4, null, null, "Ethel62@gmail.com", null, null, "Justice Price", "1-409-759-2126 x691" },
                    { 80, 8, null, null, "Karson_Fay@hotmail.com", null, null, "Lina Ullrich", "(684) 337-5105 x53883" },
                    { 81, 12, null, null, "Morgan.Jacobs@gmail.com", null, null, "Maia Greenholt", "268-454-9524 x914" },
                    { 82, 10, null, null, "Frederik67@yahoo.com", null, null, "Warren Gerhold", "411-687-1712 x99356" },
                    { 83, 6, null, null, "Carter59@gmail.com", null, null, "Kieran Hane", "810.424.6786 x7488" },
                    { 84, 22, null, null, "Casandra.Ratke@yahoo.com", null, null, "Julian Kulas", "762.794.9937 x2509" },
                    { 85, 10, null, null, "Lucas49@yahoo.com", null, null, "Jakayla Orn", "861-643-8876 x6369" },
                    { 86, 5, null, null, "Shana_Dickens@yahoo.com", null, null, "Christophe Greenfelder", "(223) 754-4505" },
                    { 87, 5, null, null, "Caleb_Fisher@hotmail.com", null, null, "Sophie Ziemann", "853-440-1581 x99654" },
                    { 88, 14, null, null, "Ike.OKeefe87@hotmail.com", null, null, "Myra Bergstrom", "660.665.1023" },
                    { 89, 7, null, null, "Tobin.Nikolaus@yahoo.com", null, null, "Brisa Larson", "(480) 428-2569 x99159" },
                    { 90, 16, null, null, "Braxton.Kuphal@yahoo.com", null, null, "Ardella Johnson", "581-251-9151 x0460" },
                    { 91, 15, null, null, "Edmond44@gmail.com", null, null, "Hank Reynolds", "1-359-841-1890 x41223" },
                    { 92, 15, null, null, "Georgianna79@yahoo.com", null, null, "Patience Blick", "891-206-4387" },
                    { 93, 21, null, null, "Wilburn.Schaefer10@hotmail.com", null, null, "Felicita Homenick", "1-842-240-6908 x26878" },
                    { 94, 17, null, null, "Jayda39@hotmail.com", null, null, "Anastacio Considine", "840-337-2966 x08422" },
                    { 95, 11, null, null, "Ariel.Johns@gmail.com", null, null, "Macy Farrell", "(702) 389-7761 x5255" },
                    { 96, 7, null, null, "Audreanne.Block@hotmail.com", null, null, "Alysson Gerhold", "(940) 380-0869" },
                    { 97, 4, null, null, "Hannah_Moen@gmail.com", null, null, "Asha Stamm", "599-845-3510" },
                    { 98, 6, null, null, "Callie.Treutel60@gmail.com", null, null, "Genesis Roob", "(482) 321-5631" },
                    { 99, 24, null, null, "Jackeline77@hotmail.com", null, null, "Therese Fadel", "239.793.7926" },
                    { 100, 6, null, null, "Jewell19@yahoo.com", null, null, "Jerad Hintz", "473.688.8512 x4618" }
                });

            migrationBuilder.InsertData(
                table: "Leads",
                columns: new[] { "Id", "AccountId", "CreatedAt", "CreatedBy", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "ModifiedAt", "ModifiedBy", "Source", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 2, null, null, "Ut esse enim voluptatem distinctio deleniti ipsa consequatur iste labore sint quia quos qui sint.", null, null, null, 206633.0, null, null, 4, 0, "Ipsam quo omnis et alias quia." },
                    { 2, 25, null, null, "Aliquid omnis est quisquam officia omnis autem sit et ut possimus sed cum deleniti reprehenderit cumque vel consequuntur atque quos ut nulla totam similique voluptate quia ea odio.", null, null, null, 130497.0, null, null, 2, 1, "Sequi officiis itaque cum dolore voluptate." },
                    { 3, 25, null, null, "Provident vel aspernatur ut sunt sed sed reprehenderit eius illum.", null, null, null, 374559.0, null, null, 0, 0, "Ut voluptatem sit explicabo et numquam." },
                    { 4, 23, null, null, "Ad rerum cumque neque ea praesentium expedita iste et eaque aspernatur alias voluptas cupiditate sunt qui nobis consequatur qui et.", null, null, null, 326663.0, null, null, 1, 1, "Earum enim omnis cumque." },
                    { 5, 11, null, null, "Facilis ut est pariatur voluptate aspernatur incidunt saepe aliquid et error sed est quod aperiam debitis sequi recusandae.", null, null, new DateTime(2022, 9, 25, 10, 9, 24, 478, DateTimeKind.Local).AddTicks(8503), 395944.0, null, null, 1, 2, "Atque perspiciatis doloribus." },
                    { 6, 6, null, null, "Saepe dignissimos non ipsam incidunt qui magni praesentium ipsam qui quo harum earum aliquid est illum et tempore id dolorem dolorum ducimus quia necessitatibus.", null, null, null, 404602.0, null, null, 4, 0, "Tempore voluptatem non." },
                    { 7, 24, null, null, "Vitae sed et eum rem soluta cupiditate qui et quo enim nulla delectus et similique laborum praesentium pariatur veritatis hic quas.", null, null, null, 276394.0, null, null, 3, 0, "Excepturi et fugiat aut et incidunt." },
                    { 8, 10, null, null, "Similique provident iusto dolor nisi qui et a cupiditate saepe in deserunt accusantium aut et illo qui molestiae non quia molestiae ratione alias illo natus facere.", null, null, null, 158177.0, null, null, 4, 0, "Eius nulla illum." },
                    { 9, 23, null, null, "Corrupti sunt occaecati adipisci natus molestiae tenetur ut ipsum repudiandae qui minima ipsa hic id aperiam dolorem porro non velit ipsam omnis ea sed nulla ea ut esse.", "Molestias ullam laborum perferendis assumenda sunt asperiores vel et architecto omnis minima quo rerum beatae provident cupiditate corporis molestias est qui dolores corporis eveniet voluptatem officia consectetur amet aut molestiae.", 4, new DateTime(2022, 8, 8, 12, 57, 57, 90, DateTimeKind.Local).AddTicks(906), 201077.0, null, null, 2, 3, "Debitis ut id." },
                    { 10, 12, null, null, "Corporis eveniet a aut necessitatibus nisi fuga at optio dolore aliquid aliquid aliquid saepe.", null, null, new DateTime(2022, 12, 7, 8, 7, 52, 423, DateTimeKind.Local).AddTicks(470), 305873.0, null, null, 1, 2, "Non voluptas molestiae molestiae." },
                    { 11, 16, null, null, "Quae et odio et facilis nemo sunt odit est vel deleniti corporis est ea et nulla nostrum earum unde at deleniti cum commodi animi ab minus veritatis magni.", null, null, null, 237338.0, null, null, 2, 1, "Ad autem enim veniam." },
                    { 12, 8, null, null, "Voluptatibus alias qui sunt sit consequatur ut commodi ut aperiam perferendis rerum in.", null, null, null, 302010.0, null, null, 3, 1, "Incidunt eaque molestias dolores et." },
                    { 13, 14, null, null, "Ab ea excepturi veniam dolorem incidunt consectetur quia unde dolor voluptate quia a sunt repellat ut repellat maxime eveniet iure minima ducimus non consequatur dolorum beatae nemo.", null, null, null, 461102.0, null, null, 2, 0, "Non modi ut deleniti numquam." },
                    { 14, 24, null, null, "Repellendus eos atque velit voluptates delectus dolorum enim et vel deleniti voluptatem sapiente dicta nihil quod rerum eum unde.", null, null, null, 295865.0, null, null, 3, 1, "Sed totam laudantium et eos." },
                    { 15, 12, null, null, "Rerum et recusandae in praesentium sint atque error dicta quo laboriosam non quia id quidem dolore ipsa ratione et placeat consequatur alias quas ducimus dolorem.", null, null, null, 15122.0, null, null, 3, 1, "Quos quia quam non fuga." },
                    { 16, 23, null, null, "Illo dolor nam consequatur quo minima facere sit quae ut eius doloribus beatae impedit error aut consectetur provident quia quaerat accusantium numquam est minima nostrum aliquid.", "Culpa qui exercitationem laborum maiores enim et consectetur labore mollitia facilis enim eius numquam consequatur et est earum qui velit eos dicta occaecati.", 1, new DateTime(2023, 3, 27, 17, 10, 59, 841, DateTimeKind.Local).AddTicks(8530), 7134.0, null, null, 0, 3, "Voluptatem vitae amet ea voluptatum rerum." },
                    { 17, 9, null, null, "Ut qui vero autem tempora aut repellat omnis illum enim vel sit inventore porro harum eum ipsam ut possimus magni laudantium occaecati itaque harum officiis quia itaque aut tempore nemo.", null, null, new DateTime(2022, 10, 4, 6, 22, 2, 525, DateTimeKind.Local).AddTicks(1738), 31782.0, null, null, 2, 2, "Expedita est cupiditate delectus officia sequi." },
                    { 18, 17, null, null, "Dolores quia voluptates libero earum quia hic tempore odit voluptatem ut.", null, null, new DateTime(2022, 10, 2, 11, 46, 19, 253, DateTimeKind.Local).AddTicks(8873), 437486.0, null, null, 2, 2, "Accusantium eum tempora dolores natus." },
                    { 19, 15, null, null, "Est reprehenderit omnis harum hic est sed voluptatum vero incidunt alias voluptas facilis nulla quam temporibus in autem mollitia dolore voluptatibus placeat.", null, null, null, 15943.0, null, null, 0, 1, "Error doloremque reprehenderit ullam." },
                    { 20, 15, null, null, "Voluptatem impedit dignissimos earum nihil nulla voluptatum vero ut aliquid.", null, null, null, 254406.0, null, null, 1, 1, "Et esse quasi." },
                    { 21, 9, null, null, "Et non dolores alias ab minima quo ducimus consequatur voluptatem quae voluptatem totam consequatur esse labore nulla est.", null, null, null, 10564.0, null, null, 1, 1, "Sit id delectus ipsam." },
                    { 22, 21, null, null, "Tempore voluptatum qui magnam occaecati inventore voluptate ut in vel facere odit corporis vitae tenetur in consequatur ut reprehenderit non magni distinctio dolorum ab suscipit.", null, null, new DateTime(2023, 4, 16, 10, 8, 6, 104, DateTimeKind.Local).AddTicks(2243), 181760.0, null, null, 1, 2, "Molestiae esse consequatur." },
                    { 23, 10, null, null, "Pariatur omnis incidunt qui qui rerum laboriosam aliquam quam neque occaecati ullam itaque soluta vitae incidunt at quasi et vero delectus accusantium.", null, null, new DateTime(2022, 11, 26, 19, 2, 22, 177, DateTimeKind.Local).AddTicks(2954), 439451.0, null, null, 3, 2, "Ut corporis molestiae eum officiis." },
                    { 24, 16, null, null, "Sunt itaque soluta nihil sequi ducimus et magnam facere ut voluptate facilis reprehenderit esse eaque eius dolor distinctio iure qui omnis vel.", null, null, null, 168178.0, null, null, 4, 1, "Esse voluptas fugiat qui rerum ut." },
                    { 25, 5, null, null, "Voluptas temporibus unde iste voluptas aperiam alias et non eum quia suscipit fugit aut laborum veniam eos neque eius asperiores qui non voluptas molestiae provident nihil doloremque.", null, null, null, 321568.0, null, null, 0, 1, "Eos aut ad quis." },
                    { 26, 25, null, null, "Accusantium et suscipit ducimus magni et ut veritatis dolores nesciunt corporis corporis nobis velit dolorum officia rerum vel consectetur ab itaque quia consequuntur hic.", null, null, null, 187615.0, null, null, 0, 1, "Laboriosam recusandae quia." },
                    { 27, 12, null, null, "Amet culpa quos quo expedita illo unde eos asperiores voluptatem ut inventore placeat odio sit non amet dignissimos a sequi.", null, null, null, 129490.0, null, null, 2, 1, "Minus ut distinctio." },
                    { 28, 22, null, null, "Quis consequatur est sapiente blanditiis ea soluta ipsum sequi atque.", null, null, new DateTime(2023, 6, 1, 2, 17, 46, 283, DateTimeKind.Local).AddTicks(7954), 356326.0, null, null, 3, 2, "Consequatur unde harum quia ipsam." },
                    { 29, 7, null, null, "Saepe non eius suscipit est vitae quod et tenetur ut ex a magnam quae beatae totam.", null, null, null, 322053.0, null, null, 1, 0, "Ipsa aliquid quibusdam." },
                    { 30, 2, null, null, "Consequatur illum itaque et culpa nulla et tenetur voluptatibus voluptas molestiae quas repellendus reprehenderit tenetur nihil eum.", "Vitae vel est voluptatum placeat blanditiis sint aut eum est commodi aut facilis non reiciendis voluptatem cumque provident vel dolores voluptatem et modi corrupti.", 0, new DateTime(2023, 2, 14, 0, 52, 57, 18, DateTimeKind.Local).AddTicks(9667), 73383.0, null, null, 0, 3, "Modi eum est esse vel illo." }
                });

            migrationBuilder.InsertData(
                table: "Deals",
                columns: new[] { "Id", "ActualRevenue", "CreatedAt", "CreatedBy", "Description", "LeadId", "ModifiedAt", "ModifiedBy", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 234296.0, null, null, "Quia veniam aut qui doloribus dolor vel doloribus sunt omnis dolorem similique qui libero sed omnis blanditiis ea nemo fugiat sint modi tempore consequatur et ea adipisci et.", 1, null, null, 2, "Vitae id explicabo minus." },
                    { 2, 392634.0, null, null, "Minima et harum ut voluptatem a cumque nihil animi consequatur voluptatem eveniet ea voluptatibus deleniti aut qui dolorem architecto et aperiam nulla vero quaerat reprehenderit.", 2, null, null, 1, "Et dolorem voluptates voluptas." },
                    { 3, 60565.0, null, null, "Maxime quo incidunt voluptate ad est repellendus cupiditate tempore officia quaerat perspiciatis magni vitae libero atque officia doloribus unde consequatur.", 3, null, null, 0, "Voluptas aut quasi fuga mollitia." },
                    { 4, 82762.0, null, null, "Aliquid occaecati dignissimos quasi et qui impedit est nisi sed nihil nihil placeat rerum enim quia.", 4, null, null, 2, "Iste nemo sequi itaque sit." },
                    { 5, 247721.0, null, null, "Similique ducimus ab harum nihil rerum et et qui veniam vel sapiente blanditiis et laborum maxime cumque reprehenderit perferendis.", 5, null, null, 2, "At fugiat et magnam rerum quo." },
                    { 6, 68291.0, null, null, "Quis in recusandae tempore qui architecto quidem quia amet voluptatibus aperiam consequatur rem delectus qui sed perspiciatis autem accusamus iusto itaque sint molestiae aspernatur.", 6, null, null, 2, "Et deleniti quas aliquid quisquam vitae." },
                    { 7, 458326.0, null, null, "Similique quos laboriosam voluptatem et et omnis quae vero explicabo pariatur et sint ea laborum aut inventore.", 7, null, null, 2, "Nisi amet rem." },
                    { 8, 336811.0, null, null, "Deleniti tempore dignissimos hic quis vel facilis et optio qui praesentium adipisci nisi sed error magni cumque deserunt unde est quis dolores.", 8, null, null, 1, "Eveniet adipisci excepturi nihil deleniti aliquid." },
                    { 9, 123630.0, null, null, "Dolorem architecto eum quis nulla adipisci voluptate recusandae aut sed ut quidem sed voluptas sed assumenda itaque non voluptas eos dolores dolorum rerum quibusdam doloribus adipisci esse.", 9, null, null, 2, "Est suscipit in." },
                    { 10, 332276.0, null, null, "Officiis tempora corrupti provident et veniam libero et est sunt totam ut est incidunt modi ad aut ea ut quos.", 10, null, null, 1, "Ullam et amet dolores sed." },
                    { 11, 173848.0, null, null, "Rerum expedita voluptas enim repellendus velit nesciunt quia quidem doloremque voluptas autem inventore fugiat nihil repellat voluptate harum.", 11, null, null, 0, "Consequuntur accusantium in itaque tenetur aliquam." },
                    { 12, 268880.0, null, null, "Impedit iusto consequatur sunt ab quidem eligendi laborum consequatur itaque magnam rerum mollitia illo voluptatem et cum possimus necessitatibus omnis pariatur laborum suscipit sequi est velit incidunt iusto.", 12, null, null, 0, "Omnis distinctio natus et." },
                    { 13, 100221.0, null, null, "Totam eos voluptatibus beatae non ut atque reprehenderit nobis aut saepe nihil quo praesentium autem omnis voluptatum voluptatibus vel rerum aliquid sint et aliquam qui iusto asperiores eum sed.", 13, null, null, 0, "Veniam commodi nihil." },
                    { 14, 261472.0, null, null, "Repellendus et tempore id aspernatur fuga optio aspernatur temporibus et veritatis quos quidem nulla voluptas ea minima veniam quia.", 14, null, null, 0, "Nihil nulla est accusamus." },
                    { 15, 70361.0, null, null, "Quidem dolore nam iste in omnis praesentium aut perspiciatis porro rerum nulla similique est.", 15, null, null, 1, "Facilis necessitatibus impedit maiores velit accusantium." },
                    { 16, 290872.0, null, null, "Et quia molestiae sint voluptatibus provident minima iusto cum voluptates eos quia tenetur dolores accusamus omnis eius id est deleniti aut et.", 16, null, null, 2, "Laboriosam autem eligendi." },
                    { 17, 422151.0, null, null, "Et quaerat ad nemo quod praesentium vero sint incidunt qui.", 17, null, null, 0, "Quisquam recusandae iusto." },
                    { 18, 236631.0, null, null, "Aut sapiente magni eius voluptates itaque in accusantium ducimus eaque minus quia sunt a tempore placeat adipisci libero aut quia vitae.", 18, null, null, 2, "Repudiandae provident quidem non aut." },
                    { 19, 348760.0, null, null, "Incidunt voluptate id et et suscipit perferendis ad illo odio aperiam nemo quaerat voluptas id architecto omnis id sint ut dicta iusto dolore quidem consequatur saepe soluta enim labore.", 19, null, null, 2, "Quam provident soluta reprehenderit perspiciatis." },
                    { 20, 251754.0, null, null, "Fuga qui mollitia ut iusto ut quia distinctio voluptatum quo numquam fugit laudantium pariatur sunt sequi et et.", 20, null, null, 2, "Tempora dolor assumenda." },
                    { 21, 145018.0, null, null, "Ipsa ipsa fugit doloribus rerum sapiente consequatur aut neque eaque rerum.", 21, null, null, 0, "Consequatur expedita tempora." },
                    { 22, 232897.0, null, null, "Dolor ut facere ut illo voluptatum pariatur quam facere molestiae in eum necessitatibus ut adipisci sit accusamus dolores ipsam ea et quia vel eveniet itaque porro.", 22, null, null, 0, "Repellendus unde nihil aut quis." },
                    { 23, 345111.0, null, null, "Vel nihil maiores voluptatem aut placeat architecto illum delectus sunt eveniet consequatur aspernatur et accusantium voluptate nam et nesciunt sequi nisi libero.", 23, null, null, 1, "Temporibus consectetur repudiandae." },
                    { 24, 322818.0, null, null, "Facilis quia nisi fugiat cumque sit sit corporis adipisci id voluptatem pariatur vero similique expedita sed temporibus cupiditate et itaque et voluptatem reprehenderit impedit doloremque.", 24, null, null, 0, "Nihil quia id fugit aperiam." },
                    { 25, 488403.0, null, null, "Tempora ab ea aut est quae quo nam odio quasi.", 25, null, null, 1, "Accusantium provident nemo sed." },
                    { 26, 244482.0, null, null, "Soluta quos doloremque excepturi voluptatum deserunt voluptatem quod dicta aliquam sint adipisci voluptas et aut veritatis optio dolorem aliquid dolor et quo.", 26, null, null, 1, "Hic omnis qui dolorem quidem." },
                    { 27, 166132.0, null, null, "Quaerat unde dolor est eum nesciunt sit nostrum quasi suscipit est et atque natus assumenda nobis quaerat et ullam velit voluptate iure debitis et voluptate aliquam ullam quae itaque.", 27, null, null, 0, "Totam repellendus voluptatibus molestiae." },
                    { 28, 30333.0, null, null, "Harum harum qui eos quo maiores reiciendis ut necessitatibus praesentium ut architecto veritatis explicabo est est nesciunt voluptatem praesentium ut quidem rerum laboriosam ipsum omnis nam est explicabo sint id.", 28, null, null, 2, "Sit saepe et est repellendus amet." },
                    { 29, 148335.0, null, null, "Et rerum commodi autem rerum ex libero et ducimus itaque dolor et numquam consectetur rerum necessitatibus molestias doloremque quia quo sit enim ducimus officia officia.", 29, null, null, 0, "Totam fugiat necessitatibus quaerat at aperiam." },
                    { 30, 177209.0, null, null, "Sed ipsa ducimus autem dolores veritatis consequuntur non sint saepe molestiae alias quos quidem vel recusandae similique ipsum et molestiae quibusdam rerum neque iure autem aliquam dolorem architecto aut necessitatibus.", 30, null, null, 0, "Dolorum fugit alias iusto quis et." }
                });

            migrationBuilder.InsertData(
                table: "DealProducts",
                columns: new[] { "DealId", "ProductId", "CreatedAt", "CreatedBy", "Id", "ModifiedAt", "ModifiedBy", "PricePerUnit", "Quantity" },
                values: new object[,]
                {
                    { 1, 8, null, null, 1, null, null, 29.0, 51 },
                    { 2, 2, null, null, 1, null, null, 53.0, 20 },
                    { 3, 6, null, null, 1, null, null, 63.0, 58 },
                    { 4, 7, null, null, 1, null, null, 11.0, 66 },
                    { 5, 7, null, null, 1, null, null, 37.0, 92 },
                    { 6, 2, null, null, 1, null, null, 53.0, 3 },
                    { 7, 3, null, null, 1, null, null, 41.0, 10 },
                    { 8, 8, null, null, 1, null, null, 31.0, 2 },
                    { 9, 6, null, null, 1, null, null, 33.0, 9 },
                    { 10, 9, null, null, 1, null, null, 91.0, 84 },
                    { 11, 7, null, null, 1, null, null, 81.0, 95 },
                    { 12, 9, null, null, 1, null, null, 65.0, 92 },
                    { 13, 4, null, null, 1, null, null, 78.0, 29 },
                    { 14, 3, null, null, 1, null, null, 93.0, 93 },
                    { 15, 3, null, null, 1, null, null, 60.0, 66 },
                    { 16, 3, null, null, 1, null, null, 65.0, 78 },
                    { 17, 8, null, null, 1, null, null, 61.0, 31 },
                    { 18, 6, null, null, 1, null, null, 11.0, 68 },
                    { 19, 8, null, null, 1, null, null, 31.0, 14 },
                    { 20, 2, null, null, 1, null, null, 84.0, 67 },
                    { 21, 5, null, null, 1, null, null, 80.0, 23 },
                    { 22, 5, null, null, 1, null, null, 32.0, 24 },
                    { 23, 10, null, null, 1, null, null, 18.0, 66 },
                    { 24, 10, null, null, 1, null, null, 57.0, 19 },
                    { 25, 8, null, null, 1, null, null, 53.0, 44 },
                    { 26, 8, null, null, 1, null, null, 75.0, 63 },
                    { 27, 7, null, null, 1, null, null, 25.0, 59 },
                    { 28, 7, null, null, 1, null, null, 50.0, 57 },
                    { 29, 7, null, null, 1, null, null, 14.0, 11 },
                    { 30, 6, null, null, 1, null, null, 44.0, 5 }
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
