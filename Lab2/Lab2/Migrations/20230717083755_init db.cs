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
                    { 1, "178 Macejkovic Oval, West Esperanzaview, Central African Republic", null, null, "Watson64@gmail.com", null, null, "Stokes, Rau and Miller", "322-392-9225", 34673.0 },
                    { 2, "656 Corkery Grove, Cristville, Finland", null, null, "Jovanny_Gleichner37@hotmail.com", null, null, "Balistreri - Kassulke", "825-682-7123 x897", 16506.0 },
                    { 3, "3844 Dietrich Rest, East Grayce, Cuba", null, null, "Hayden.Denesik@hotmail.com", null, null, "Koch - Sporer", "435-401-2942 x3733", 48293.0 },
                    { 4, "1510 Swift Terrace, Schusterberg, Nepal", null, null, "Maya.Adams@gmail.com", null, null, "Rosenbaum, Okuneva and Will", "(947) 842-1055 x2215", 48417.0 },
                    { 5, "0383 Jedidiah Walks, South Mozelleton, Botswana", null, null, "Jayne.Dietrich@yahoo.com", null, null, "Rogahn, Swaniawski and Berge", "384-965-4755", 16464.0 },
                    { 6, "010 Champlin Trail, Wiegandfurt, Cyprus", null, null, "Imelda_Roberts59@hotmail.com", null, null, "Gaylord - Grimes", "1-343-570-8665", 12973.0 },
                    { 7, "51557 Krajcik Key, Domenicmouth, Norfolk Island", null, null, "Maymie53@hotmail.com", null, null, "Little and Sons", "(264) 563-8642 x86300", 31117.0 },
                    { 8, "84357 Uriah Rue, Pourosmouth, Guam", null, null, "Otha82@hotmail.com", null, null, "Abernathy and Sons", "554-504-3025 x562", 23821.0 },
                    { 9, "36893 Bergstrom Valleys, New Haskell, Marshall Islands", null, null, "Waldo_Bradtke86@hotmail.com", null, null, "Gutmann, Beier and Muller", "393.795.8910 x8772", 28183.0 },
                    { 10, "5246 Mara Station, New Cleo, Taiwan", null, null, "Gene31@yahoo.com", null, null, "Padberg - Olson", "281-394-7953 x1144", 26393.0 },
                    { 11, "31552 Nader Wall, Hickleport, Monaco", null, null, "Armani_Swaniawski33@hotmail.com", null, null, "Nitzsche - Murazik", "(759) 531-3635 x1803", 38676.0 },
                    { 12, "569 Karina Mountains, West Celiaport, Saudi Arabia", null, null, "Heloise.Turcotte@gmail.com", null, null, "Wiza, Altenwerth and Hessel", "247-831-8396", 7348.0 },
                    { 13, "993 Elena Divide, Kozeychester, Saint Vincent and the Grenadines", null, null, "Jose.Johns28@yahoo.com", null, null, "Kuphal - Bins", "1-858-270-9977", 23038.0 },
                    { 14, "137 Leslie Dam, South Kattiebury, Mongolia", null, null, "Elyse_Marks94@hotmail.com", null, null, "Turcotte - West", "(656) 464-4826 x45608", 22277.0 },
                    { 15, "78735 Hammes Forest, New Cicero, Jamaica", null, null, "Bobbie_OHara@gmail.com", null, null, "Morar LLC", "1-734-295-8724", 42240.0 },
                    { 16, "29015 Gottlieb Lights, Wandaport, Somalia", null, null, "Jace.Breitenberg@gmail.com", null, null, "Luettgen and Sons", "1-910-475-5870", 5902.0 },
                    { 17, "788 Kailyn Glen, Geraldburgh, Tokelau", null, null, "Taurean68@yahoo.com", null, null, "Baumbach, Bernier and Sauer", "357-464-6090 x1379", 4483.0 },
                    { 18, "16650 Wilfrid Rue, Kubstad, Greece", null, null, "Carol_Emard@gmail.com", null, null, "Wolf, Hamill and Bode", "952.850.1021", 41292.0 },
                    { 19, "9407 Schaefer Inlet, Eastonmouth, Martinique", null, null, "Kathleen61@yahoo.com", null, null, "Bruen, Ebert and Jast", "(847) 464-4734", 36669.0 },
                    { 20, "22554 Vilma Garden, South Aleneshire, Maldives", null, null, "Allen_Schiller22@hotmail.com", null, null, "Gerlach - Block", "627-636-4980", 26606.0 },
                    { 21, "31866 Johns Orchard, Weberburgh, Comoros", null, null, "Garfield_Morissette88@gmail.com", null, null, "Stracke, Pacocha and Larkin", "(364) 900-9408 x4670", 30822.0 },
                    { 22, "6938 Darion Club, West Adella, Haiti", null, null, "Bernadette_Brakus@gmail.com", null, null, "Friesen LLC", "(826) 534-5426 x44680", 7137.0 },
                    { 23, "4725 Alivia Station, East Nikolas, Cayman Islands", null, null, "Asia21@gmail.com", null, null, "Heathcote, McDermott and Sporer", "(383) 722-2571 x10973", 19501.0 },
                    { 24, "56034 Zack Inlet, Dameonside, Bahamas", null, null, "Buford_Spinka93@gmail.com", null, null, "Jacobson LLC", "(566) 502-4716", 45826.0 },
                    { 25, "4408 Edna Port, Ratketon, Oman", null, null, "Fermin93@hotmail.com", null, null, "McClure - Hegmann", "964-741-6609 x66076", 1863.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsAvailable", "ModifiedAt", "ModifiedBy", "Name", "Price", "ProductCode", "Type" },
                values: new object[,]
                {
                    { 1, null, null, true, null, null, "Incredible Cotton Cheese", 721.0, "PRO-54396333", 0 },
                    { 2, null, null, true, null, null, "Tasty Frozen Ball", 882.0, "PRO-43607655", 0 },
                    { 3, null, null, true, null, null, "Licensed Rubber Mouse", 655.0, "PRO-72478257", 1 },
                    { 4, null, null, true, null, null, "Awesome Granite Pizza", 367.0, "PRO-31299558", 0 },
                    { 5, null, null, true, null, null, "Incredible Wooden Bacon", 150.0, "PRO-67364893", 0 },
                    { 6, null, null, true, null, null, "Licensed Soft Car", 294.0, "PRO-67572182", 0 },
                    { 7, null, null, true, null, null, "Incredible Concrete Salad", 201.0, "PRO-79349574", 1 },
                    { 8, null, null, true, null, null, "Generic Metal Hat", 869.0, "PRO-33897066", 0 },
                    { 9, null, null, true, null, null, "Generic Steel Tuna", 26.0, "PRO-70991826", 0 },
                    { 10, null, null, true, null, null, "Practical Soft Soap", 407.0, "PRO-43803163", 1 }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "AccountId", "CreatedAt", "CreatedBy", "Email", "ModifiedAt", "ModifiedBy", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, 12, null, null, "Garret68@yahoo.com", null, null, "Abner Brekke", "(918) 584-4403" },
                    { 2, 8, null, null, "Berenice_Gottlieb@hotmail.com", null, null, "Merritt Koch", "379.591.7581 x2777" },
                    { 3, 19, null, null, "Tomasa.Yost@yahoo.com", null, null, "Erwin Reichel", "699-293-6098 x81402" },
                    { 4, 25, null, null, "Marcelo3@yahoo.com", null, null, "Dakota Kuhlman", "1-453-383-0195 x26349" },
                    { 5, 12, null, null, "Mike.Hermann33@gmail.com", null, null, "Kayden Bogisich", "(845) 251-5168 x3760" },
                    { 6, 20, null, null, "Garry_Thompson78@hotmail.com", null, null, "Ross Ryan", "(388) 681-1447" },
                    { 7, 16, null, null, "Celine_Mitchell@hotmail.com", null, null, "Joana Sipes", "302-828-5159" },
                    { 8, 14, null, null, "Everette_Beatty@yahoo.com", null, null, "Sasha Hessel", "673.399.5215 x665" },
                    { 9, 22, null, null, "Jeanette.Davis93@yahoo.com", null, null, "Jerad Harvey", "550-568-9769 x2624" },
                    { 10, 2, null, null, "Thea_Schmidt@hotmail.com", null, null, "Filiberto Blick", "1-520-857-2635 x4760" },
                    { 11, 19, null, null, "Napoleon78@yahoo.com", null, null, "Jerod Dickinson", "754.773.1913 x42800" },
                    { 12, 17, null, null, "Ocie92@yahoo.com", null, null, "Kyla Hauck", "860-967-0797 x836" },
                    { 13, 13, null, null, "Rylee.Rohan@gmail.com", null, null, "Lupe Stark", "370.553.5544" },
                    { 14, 24, null, null, "Adella99@gmail.com", null, null, "Wilhelmine Jenkins", "1-287-856-8613" },
                    { 15, 8, null, null, "Shanon47@hotmail.com", null, null, "Michel Rolfson", "310.575.2069" },
                    { 16, 1, null, null, "Magnus19@hotmail.com", null, null, "Myrna Kertzmann", "1-502-296-7985 x8871" },
                    { 17, 10, null, null, "Tomasa.Gleichner4@gmail.com", null, null, "Dalton Conn", "(298) 257-7322" },
                    { 18, 15, null, null, "Shayne47@yahoo.com", null, null, "Sarah Russel", "581.570.0536 x6784" },
                    { 19, 12, null, null, "Eleanore54@hotmail.com", null, null, "Emmett Haag", "955-547-8385" },
                    { 20, 16, null, null, "Heaven.Rolfson59@yahoo.com", null, null, "Scot Labadie", "376-580-8455 x725" },
                    { 21, 21, null, null, "Hassie_Erdman28@yahoo.com", null, null, "Santos Brekke", "1-328-622-9286" },
                    { 22, 14, null, null, "Toy69@gmail.com", null, null, "Theresa Little", "(930) 561-1131" },
                    { 23, 3, null, null, "Clair37@yahoo.com", null, null, "Meggie Stamm", "899-628-3682 x454" },
                    { 24, 17, null, null, "Dorris9@yahoo.com", null, null, "Wilmer Rosenbaum", "1-739-801-3576 x65813" },
                    { 25, 23, null, null, "Wyman47@hotmail.com", null, null, "Everardo Ritchie", "1-699-571-7309 x659" },
                    { 26, 10, null, null, "Hilda.Larkin@hotmail.com", null, null, "Hannah Hansen", "655-443-7685" },
                    { 27, 16, null, null, "Rahsaan31@yahoo.com", null, null, "Rory Hauck", "1-521-367-5551 x350" },
                    { 28, 23, null, null, "Norene.Runolfsson@hotmail.com", null, null, "Megane Schmidt", "1-386-716-1666 x66941" },
                    { 29, 1, null, null, "Jesus_Becker91@yahoo.com", null, null, "Raegan Haag", "1-421-900-4618 x3270" },
                    { 30, 6, null, null, "Lauriane30@hotmail.com", null, null, "Norval Lind", "701.562.8579" },
                    { 31, 13, null, null, "Mitchell_Hermiston17@hotmail.com", null, null, "Charley Rohan", "652-968-7487 x161" },
                    { 32, 16, null, null, "Fermin_Satterfield79@hotmail.com", null, null, "Clementine Krajcik", "764.331.6648" },
                    { 33, 24, null, null, "Percival_Kertzmann64@hotmail.com", null, null, "Cedrick Hickle", "1-758-760-5783 x7734" },
                    { 34, 6, null, null, "Violette_Howell@yahoo.com", null, null, "Isobel Beahan", "(431) 217-5961" },
                    { 35, 5, null, null, "Anissa81@hotmail.com", null, null, "Ernestine Schmeler", "552.726.2139 x0044" },
                    { 36, 22, null, null, "Karli_Cremin61@yahoo.com", null, null, "Oma Kub", "919.973.1849" },
                    { 37, 11, null, null, "Estevan43@yahoo.com", null, null, "Norris Miller", "(324) 624-8571" },
                    { 38, 25, null, null, "Sadye.Kulas@yahoo.com", null, null, "Albina Stroman", "1-473-804-9387" },
                    { 39, 4, null, null, "Delta_Cassin37@yahoo.com", null, null, "Etha Reichert", "(581) 931-8243 x96738" },
                    { 40, 22, null, null, "Zack_Kertzmann45@yahoo.com", null, null, "Dee Glover", "550.870.8363" },
                    { 41, 22, null, null, "Phoebe.Bergnaum53@yahoo.com", null, null, "Don Schmidt", "846-795-7646" },
                    { 42, 12, null, null, "Cecile_Gislason49@gmail.com", null, null, "Hanna Swaniawski", "710.492.0726 x794" },
                    { 43, 2, null, null, "Kim37@yahoo.com", null, null, "Jovany Dickens", "631-854-4326 x739" },
                    { 44, 19, null, null, "Dasia0@hotmail.com", null, null, "Selmer Beier", "(393) 535-8004" },
                    { 45, 18, null, null, "Rory_Johnston@gmail.com", null, null, "Coby Johns", "(395) 577-7460 x4964" },
                    { 46, 25, null, null, "Chasity.Boyle97@yahoo.com", null, null, "Alyson Block", "1-623-569-0581" },
                    { 47, 24, null, null, "Ludie_Cartwright@yahoo.com", null, null, "Stephanie Veum", "655.697.0049 x12741" },
                    { 48, 9, null, null, "Lulu_Williamson2@yahoo.com", null, null, "Reese Wehner", "(732) 306-9370 x84990" },
                    { 49, 6, null, null, "Brown46@yahoo.com", null, null, "Santiago Hodkiewicz", "1-403-688-9974 x5936" },
                    { 50, 23, null, null, "Eleanore2@hotmail.com", null, null, "Tommie Veum", "852.356.2094" },
                    { 51, 25, null, null, "America3@gmail.com", null, null, "Summer Feest", "622-597-9657" },
                    { 52, 19, null, null, "Jorge.Haley@hotmail.com", null, null, "Virgil Schinner", "(758) 868-2146 x86095" },
                    { 53, 18, null, null, "Arvilla99@gmail.com", null, null, "Brittany Dibbert", "1-760-430-6644 x18168" },
                    { 54, 17, null, null, "Kareem15@gmail.com", null, null, "Gertrude Moore", "(483) 510-7796" },
                    { 55, 1, null, null, "Adam.Auer49@hotmail.com", null, null, "Celine Schulist", "459.643.9385" },
                    { 56, 21, null, null, "Dagmar_Monahan@hotmail.com", null, null, "Rodolfo Rosenbaum", "1-631-207-5007 x354" },
                    { 57, 9, null, null, "Santa53@yahoo.com", null, null, "Carmen Waters", "634-644-8429 x6807" },
                    { 58, 3, null, null, "Madisyn_Swaniawski54@yahoo.com", null, null, "Phoebe Koch", "353.222.9116 x689" },
                    { 59, 3, null, null, "Rachelle.Ernser@gmail.com", null, null, "Tressa Stark", "1-889-743-8117" },
                    { 60, 3, null, null, "Mossie.Rutherford@gmail.com", null, null, "Bernie Maggio", "(587) 675-4465 x17821" },
                    { 61, 9, null, null, "Lyric_Monahan@yahoo.com", null, null, "Destiney Rempel", "588.372.4110 x7832" },
                    { 62, 17, null, null, "Brendan68@gmail.com", null, null, "Melyssa Wilkinson", "(812) 321-9425" },
                    { 63, 9, null, null, "Maribel.Bosco@hotmail.com", null, null, "Damaris Gutmann", "389.469.4411 x5506" },
                    { 64, 24, null, null, "Roderick_Parisian@gmail.com", null, null, "Vidal Kassulke", "837-793-7767 x002" },
                    { 65, 16, null, null, "Michaela_Marks96@yahoo.com", null, null, "Elenor Will", "490.466.6068 x3518" },
                    { 66, 16, null, null, "Jewel.Kessler@gmail.com", null, null, "Jarrod Wiza", "249.672.1130 x605" },
                    { 67, 24, null, null, "Maryse.Braun@hotmail.com", null, null, "Dustin Hermann", "311-427-4896 x4398" },
                    { 68, 21, null, null, "Michele_Wintheiser57@yahoo.com", null, null, "Judd Rutherford", "(477) 285-9446" },
                    { 69, 17, null, null, "Juston.Osinski@gmail.com", null, null, "Cecilia Gerlach", "(643) 662-1425 x499" },
                    { 70, 16, null, null, "Maryse.Hermiston85@gmail.com", null, null, "Georgiana Bogisich", "553-670-9439 x84325" },
                    { 71, 16, null, null, "Chloe3@hotmail.com", null, null, "Joelle Denesik", "308.400.7271 x32976" },
                    { 72, 22, null, null, "Violette25@gmail.com", null, null, "Kayleigh Kozey", "782-968-7985 x76364" },
                    { 73, 25, null, null, "Lauren8@yahoo.com", null, null, "Deon Bernier", "486-768-1585" },
                    { 74, 2, null, null, "Magnus_Hessel@gmail.com", null, null, "Elmer Bernier", "(523) 633-0876 x52005" },
                    { 75, 21, null, null, "Stewart_Kirlin@gmail.com", null, null, "Penelope Bayer", "272-482-0152" },
                    { 76, 5, null, null, "Jade_Von34@hotmail.com", null, null, "Elisa Durgan", "540-774-9615" },
                    { 77, 13, null, null, "Emmet45@gmail.com", null, null, "Felicia Wilkinson", "357.249.5576 x943" },
                    { 78, 7, null, null, "River50@hotmail.com", null, null, "Maryam Bechtelar", "364-281-1256" },
                    { 79, 12, null, null, "Otha_Mills@hotmail.com", null, null, "Adrienne Block", "775.367.0387" },
                    { 80, 17, null, null, "Alycia.Huels68@yahoo.com", null, null, "Mortimer Kunde", "776.751.4754 x10018" },
                    { 81, 7, null, null, "Sage_VonRueden98@hotmail.com", null, null, "Jed Herzog", "930-581-7804 x0117" },
                    { 82, 19, null, null, "Israel_OKeefe62@gmail.com", null, null, "Chadd Howell", "743.652.7154 x531" },
                    { 83, 24, null, null, "Aric.Schuppe@gmail.com", null, null, "Callie Grant", "408.704.2325 x242" },
                    { 84, 14, null, null, "Ken_Ledner45@hotmail.com", null, null, "Peter Bernhard", "1-852-911-6885" },
                    { 85, 9, null, null, "Alexys_Watsica@gmail.com", null, null, "Nina Collins", "1-655-339-4957" },
                    { 86, 15, null, null, "Justina_Becker45@yahoo.com", null, null, "Robb Runolfsson", "374.643.9309 x2318" },
                    { 87, 10, null, null, "Ara_Champlin@yahoo.com", null, null, "Zoie Schowalter", "977-625-2955 x45274" },
                    { 88, 17, null, null, "Daphnee.Ruecker@yahoo.com", null, null, "Claudia Tromp", "1-371-890-0516 x30084" },
                    { 89, 19, null, null, "Laverne.Ondricka41@yahoo.com", null, null, "Sabryna Stehr", "834.407.6701" },
                    { 90, 16, null, null, "Petra_Cole@gmail.com", null, null, "Abigail Waelchi", "(261) 971-4948 x136" },
                    { 91, 4, null, null, "Shania.Cassin@gmail.com", null, null, "Macie Ortiz", "(562) 520-1827 x525" },
                    { 92, 6, null, null, "Rudolph_Kassulke@yahoo.com", null, null, "Rhoda Leffler", "625-455-7496" },
                    { 93, 7, null, null, "Imani_Shields38@yahoo.com", null, null, "Timothy Mraz", "1-693-616-7650" },
                    { 94, 23, null, null, "Katlyn.Mohr14@gmail.com", null, null, "Pink Conn", "830-440-9222 x749" },
                    { 95, 7, null, null, "Harrison.Stracke@hotmail.com", null, null, "Annamae Mayert", "(431) 376-1741 x43346" },
                    { 96, 14, null, null, "Toby.Herzog34@yahoo.com", null, null, "Sterling Murray", "1-653-977-7346" },
                    { 97, 11, null, null, "Heath_Wolff@hotmail.com", null, null, "Emie Little", "1-847-550-7959" },
                    { 98, 18, null, null, "Tiana.Gutmann3@hotmail.com", null, null, "Cristobal Schaden", "1-719-370-8158 x418" },
                    { 99, 3, null, null, "Carlo67@hotmail.com", null, null, "Candido Pfeffer", "632-473-7206 x05302" },
                    { 100, 18, null, null, "Alana46@hotmail.com", null, null, "Barry Kuhn", "1-801-523-1108 x49088" }
                });

            migrationBuilder.InsertData(
                table: "Leads",
                columns: new[] { "Id", "AccountId", "CreatedAt", "CreatedBy", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "ModifiedAt", "ModifiedBy", "Source", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 8, null, null, "Consequatur consequatur et vel aspernatur sequi est dicta quaerat incidunt ipsa dicta aperiam id omnis maxime.", null, null, new DateTime(2023, 2, 19, 4, 2, 25, 761, DateTimeKind.Local).AddTicks(2815), 7271.0, null, null, 1, 2, "Eius delectus et sed aliquam cupiditate." },
                    { 2, 9, null, null, "Quibusdam et rem est perferendis molestiae tempora iusto eos perferendis ut possimus ex est accusantium dolorem dolorum incidunt dolorem aut ut et aut praesentium et unde mollitia aut.", null, null, new DateTime(2022, 8, 13, 0, 38, 16, 674, DateTimeKind.Local).AddTicks(6630), 127513.0, null, null, 3, 2, "Quia architecto et pariatur." },
                    { 3, 13, null, null, "Dolores assumenda at aut qui veritatis commodi totam rerum consequatur sit explicabo omnis ut ea pariatur quaerat architecto facilis eum mollitia voluptatem rerum dolor animi omnis.", null, null, null, 339596.0, null, null, 3, 1, "Aspernatur aperiam et explicabo." },
                    { 4, 1, null, null, "In earum est omnis consequuntur ratione nemo aut iusto consequuntur modi tempore illum aliquam nulla voluptatum explicabo dolor.", null, null, new DateTime(2023, 2, 7, 10, 49, 0, 817, DateTimeKind.Local).AddTicks(3468), 57780.0, null, null, 2, 2, "Nihil accusamus magni ducimus." },
                    { 5, 15, null, null, "Occaecati tempore ea sapiente vitae deleniti soluta nobis rerum corporis blanditiis.", null, null, null, 165518.0, null, null, 3, 1, "Officia sit rerum qui quas modi." },
                    { 6, 19, null, null, "Quo veniam labore soluta dolores sint delectus pariatur ut incidunt officiis maiores qui quia accusamus in est quae a iusto voluptas architecto aut facere nihil sit iusto dolorem dolore.", null, null, new DateTime(2023, 2, 1, 10, 26, 43, 686, DateTimeKind.Local).AddTicks(4908), 228805.0, null, null, 2, 2, "Recusandae accusantium dolores aliquid in." },
                    { 7, 17, null, null, "Ad rerum error voluptates aperiam aut autem soluta optio impedit aut placeat quaerat nisi odit et est autem cupiditate omnis inventore non autem voluptas eligendi placeat omnis qui nisi.", "Numquam qui qui rerum tempora sed enim sed accusamus libero ut est labore in qui sit facilis.", 0, new DateTime(2022, 9, 27, 2, 35, 40, 165, DateTimeKind.Local).AddTicks(285), 107103.0, null, null, 2, 3, "Ratione ut magnam unde." },
                    { 8, 9, null, null, "Velit ut saepe sapiente voluptates quo voluptates nihil qui est magni ab omnis vel quidem iure est et explicabo maiores sint itaque odit debitis.", null, null, new DateTime(2022, 10, 14, 12, 50, 55, 810, DateTimeKind.Local).AddTicks(9718), 78702.0, null, null, 0, 2, "Commodi deleniti consequatur." },
                    { 9, 14, null, null, "In et aut voluptate fuga et sint eum voluptatem qui sed commodi.", null, null, new DateTime(2023, 5, 22, 8, 8, 32, 142, DateTimeKind.Local).AddTicks(9637), 499648.0, null, null, 2, 2, "Libero illum quis." },
                    { 10, 11, null, null, "Autem molestias sunt placeat nihil laboriosam excepturi quo et quia voluptate et nostrum sunt et quod dolore voluptates voluptas at reprehenderit et.", "Aut explicabo deserunt numquam a numquam expedita explicabo ducimus quibusdam impedit fugit asperiores qui corporis commodi et aut commodi.", 0, new DateTime(2022, 12, 1, 15, 43, 58, 752, DateTimeKind.Local).AddTicks(2379), 46493.0, null, null, 4, 3, "Similique soluta accusamus exercitationem." },
                    { 11, 15, null, null, "Aut illum quibusdam et ullam reiciendis qui sed ea ipsa.", null, null, null, 330556.0, null, null, 2, 1, "Ut aut aliquid." },
                    { 12, 18, null, null, "Aut nulla ut sunt totam ipsam ducimus sunt quia provident quam nihil dicta quae ratione.", null, null, new DateTime(2023, 5, 14, 17, 0, 56, 327, DateTimeKind.Local).AddTicks(809), 499872.0, null, null, 3, 2, "Hic suscipit sint et." },
                    { 13, 12, null, null, "Itaque ea earum itaque soluta nulla incidunt officia fuga culpa dolores non rerum illo inventore sint commodi dolorem eveniet consequuntur ducimus explicabo fugit in et.", null, null, null, 67855.0, null, null, 2, 1, "Quod et quas tempore vel." },
                    { 14, 1, null, null, "Temporibus voluptatem laborum voluptatem excepturi facilis autem ipsa enim beatae velit quas occaecati optio sapiente.", null, null, null, 40090.0, null, null, 4, 0, "Quasi fuga quod." },
                    { 15, 24, null, null, "Autem minima labore deleniti expedita qui amet qui mollitia consequatur exercitationem quasi culpa dolores qui aut et omnis dolor rerum culpa eos repellat quaerat similique molestiae id.", "Ipsam suscipit voluptas consequatur nulla error non quis adipisci mollitia rerum ut consequatur nesciunt ratione neque nihil earum.", 4, new DateTime(2023, 3, 15, 20, 36, 10, 85, DateTimeKind.Local).AddTicks(7607), 122399.0, null, null, 3, 3, "Ratione ex ea." },
                    { 16, 18, null, null, "Dolores accusantium velit ab adipisci mollitia porro doloremque dignissimos quis veniam accusamus quia est excepturi eos minima qui qui nostrum.", null, null, null, 183975.0, null, null, 2, 0, "Aut odio nihil commodi magni." },
                    { 17, 13, null, null, "Expedita tempora aut nulla consequatur aperiam officia explicabo eligendi quis minus nostrum expedita officia distinctio dolorem totam beatae alias a cum.", null, null, null, 127728.0, null, null, 3, 1, "Velit quia magnam." },
                    { 18, 17, null, null, "Et esse voluptatem harum perspiciatis incidunt adipisci dolore iure ut quis qui sunt.", null, null, null, 65485.0, null, null, 2, 0, "Incidunt similique laudantium qui ducimus odit." },
                    { 19, 21, null, null, "Aut magnam quos eius sapiente et neque sed id aperiam labore earum voluptas velit deleniti aut sapiente debitis.", null, null, null, 445422.0, null, null, 2, 0, "Earum magni nemo aperiam qui id." },
                    { 20, 24, null, null, "Quia enim aspernatur aliquid repellat aut nam qui deleniti quia illo assumenda consequatur iusto hic nam totam numquam ea quo nam repudiandae.", null, null, null, 244944.0, null, null, 4, 1, "Iusto eum quia id nisi." },
                    { 21, 23, null, null, "Adipisci iure similique consequatur vel earum tenetur ut voluptatem nulla veniam sint sunt vel aut molestiae sit qui qui possimus quo assumenda non sed minus et incidunt.", "Laudantium corrupti accusamus non dolores eos quae facilis fuga nobis quia.", 1, new DateTime(2022, 7, 19, 7, 9, 31, 920, DateTimeKind.Local).AddTicks(4035), 16157.0, null, null, 1, 3, "Incidunt odio animi earum voluptas architecto." },
                    { 22, 7, null, null, "Non dolores vel ipsam modi molestiae est dicta ea aut quis et amet consequatur vero voluptas molestiae incidunt earum corrupti sit est dolores maxime in qui rerum rerum.", null, null, new DateTime(2022, 10, 5, 10, 6, 40, 616, DateTimeKind.Local).AddTicks(7846), 28106.0, null, null, 3, 2, "Dignissimos hic unde." },
                    { 23, 11, null, null, "Delectus quod nam esse id et iure ut qui velit illo sit fugit.", null, null, null, 142873.0, null, null, 4, 1, "Facilis voluptatem debitis." },
                    { 24, 12, null, null, "Quia ipsam enim dolor voluptatibus cupiditate omnis voluptas et eveniet molestiae quasi quia dolor voluptatum et vel magni nisi adipisci dignissimos eum velit a illum.", null, null, null, 209850.0, null, null, 1, 0, "Aliquam minus excepturi velit non inventore." },
                    { 25, 18, null, null, "Numquam modi iusto odio quam perferendis amet veniam eum saepe veniam delectus voluptatem culpa vel fugiat beatae ut excepturi iste nihil quod est et blanditiis nihil earum harum ipsam dolor.", null, null, null, 212725.0, null, null, 2, 1, "Aut et eligendi autem." },
                    { 26, 8, null, null, "Rerum et id ab non aut ipsum incidunt dolor est non quisquam.", null, null, null, 131792.0, null, null, 0, 1, "Qui ipsum sint molestiae consequatur." },
                    { 27, 24, null, null, "Accusantium aut dolore delectus aut hic rerum quo et est a beatae itaque aut sit est dicta omnis rem quis ut asperiores mollitia neque non atque soluta facere magnam officiis.", null, null, new DateTime(2022, 9, 23, 6, 21, 25, 328, DateTimeKind.Local).AddTicks(9552), 318530.0, null, null, 0, 2, "Ratione animi ut." },
                    { 28, 3, null, null, "Occaecati nihil similique quas dolor ratione aut illo rem accusamus aliquid voluptatibus et beatae consequuntur ut aliquid voluptatibus aut sed nesciunt occaecati cumque molestiae aut totam vero.", null, null, new DateTime(2022, 9, 3, 21, 24, 32, 579, DateTimeKind.Local).AddTicks(3042), 71674.0, null, null, 2, 2, "Sint non culpa earum nihil placeat." },
                    { 29, 25, null, null, "Consectetur aut necessitatibus sint voluptate aut dolore dolore quia quas hic id sit dicta placeat ut molestias sequi dolor magni nobis quos esse et.", null, null, new DateTime(2022, 8, 23, 6, 27, 5, 255, DateTimeKind.Local).AddTicks(5532), 256000.0, null, null, 0, 2, "Ex earum error." },
                    { 30, 1, null, null, "Natus enim tempore consequatur hic hic molestiae sint rerum ipsam quo aliquid dolorum pariatur et at assumenda corporis.", null, null, new DateTime(2022, 12, 15, 17, 30, 22, 196, DateTimeKind.Local).AddTicks(8597), 149267.0, null, null, 2, 2, "Eum aut nulla reiciendis sequi dolor." }
                });

            migrationBuilder.InsertData(
                table: "Deals",
                columns: new[] { "Id", "ActualRevenue", "CreatedAt", "CreatedBy", "Description", "LeadId", "ModifiedAt", "ModifiedBy", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 161179.0, null, null, "Pariatur facere est occaecati quidem itaque eum et quia sint qui vero laborum provident dolorem laborum corrupti.", 1, null, null, 1, "Quisquam ipsa repellat adipisci veritatis." },
                    { 2, 55499.0, null, null, "Voluptatem pariatur suscipit et a doloremque rerum tenetur voluptates quo.", 2, null, null, 1, "Numquam in dolor." },
                    { 3, 188468.0, null, null, "Inventore molestias quia velit ex ut et officiis quo deleniti sint repellendus quidem magni sit quasi ut incidunt ab eum sit autem.", 3, null, null, 1, "Nihil perferendis laboriosam quasi hic." },
                    { 4, 84013.0, null, null, "Temporibus quasi quidem omnis optio consequatur voluptates impedit modi perferendis repellendus.", 4, null, null, 2, "Illo et aut consequatur." },
                    { 5, 40467.0, null, null, "Deleniti nemo consequatur recusandae vitae iusto minima est pariatur aliquam laudantium quis blanditiis amet voluptatibus inventore dolorem fugiat quidem et vitae eos laborum sit dolor consectetur.", 5, null, null, 0, "Qui laborum non." },
                    { 6, 136262.0, null, null, "Possimus perspiciatis et quis nulla est aut qui voluptas ipsam.", 6, null, null, 1, "Ut nobis voluptatem nobis excepturi." },
                    { 7, 139236.0, null, null, "Et sint placeat est perspiciatis ipsum natus nam occaecati distinctio similique fuga.", 7, null, null, 2, "Pariatur molestiae facilis facere dolorum." },
                    { 8, 72355.0, null, null, "Sint earum vitae numquam sit aut amet facere laboriosam accusamus sit minus enim illum quibusdam eveniet id eveniet corporis iusto sed quia soluta magni non qui aut voluptas cupiditate consequatur.", 8, null, null, 2, "Non sapiente cum necessitatibus." },
                    { 9, 160633.0, null, null, "Est earum ipsum unde iusto eligendi qui quia incidunt omnis aliquid esse animi voluptatum consectetur quis aut repellendus a est est explicabo soluta aperiam accusamus expedita inventore.", 9, null, null, 1, "Illum voluptatem quibusdam est." },
                    { 10, 284467.0, null, null, "Ad sunt beatae sed dolores repellendus iusto et fugit id at molestiae ea dolor eaque dolores rem nihil et labore quas ex totam explicabo quidem assumenda ut sunt iusto maiores.", 10, null, null, 0, "At assumenda dolorum id quod aut." },
                    { 11, 239201.0, null, null, "Nisi fugiat dolor aspernatur id sed voluptas fugiat suscipit nihil eos cumque provident ut iure neque est et atque quisquam suscipit.", 11, null, null, 1, "Eaque hic enim." },
                    { 12, 112769.0, null, null, "Odio et ea aliquam ut sint magni assumenda voluptatem voluptatem tempora pariatur harum voluptatem rerum recusandae sequi enim eos repellat adipisci nobis laudantium qui sit consequatur.", 12, null, null, 0, "Praesentium animi qui officia." },
                    { 13, 69335.0, null, null, "Necessitatibus sequi laborum similique quo facere deserunt fugit rem soluta ex autem quia.", 13, null, null, 1, "Alias sed explicabo nostrum atque." },
                    { 14, 296244.0, null, null, "Aut autem vero illum doloribus numquam dicta sed sint ut.", 14, null, null, 0, "Ducimus ut optio." },
                    { 15, 126169.0, null, null, "Et iure dolores magnam enim ullam quaerat quia molestiae eligendi ad deserunt voluptatem blanditiis assumenda aut est voluptas.", 15, null, null, 2, "Sunt consequatur quia et cum." },
                    { 16, 283942.0, null, null, "Officiis voluptatem magnam omnis vel recusandae molestiae voluptas et odio dolores voluptas.", 16, null, null, 1, "Est qui recusandae maiores enim." },
                    { 17, 245767.0, null, null, "Quia rerum ut excepturi rem ut dignissimos est sunt et facilis possimus quae aperiam impedit qui.", 17, null, null, 0, "Debitis suscipit voluptates." },
                    { 18, 263815.0, null, null, "Et nihil reprehenderit aut minima minima debitis quis delectus amet sint autem aut quia et est deleniti error porro voluptatum enim est qui aliquid dolore et.", 18, null, null, 1, "Aliquam eos est." },
                    { 19, 435789.0, null, null, "Dolores earum provident facere autem culpa quia deserunt delectus sunt porro consequatur culpa nostrum esse.", 19, null, null, 1, "Beatae distinctio ut ipsa." },
                    { 20, 405586.0, null, null, "Et rerum fugiat deserunt magni qui quis fugit et neque dolorem et saepe magni provident ipsam corporis et suscipit voluptatem maiores distinctio minus repellat alias nemo harum.", 20, null, null, 1, "Quos et id eligendi saepe reiciendis." },
                    { 21, 43678.0, null, null, "Expedita quia et laudantium ipsa eos culpa mollitia accusantium iste non eos ratione quia quam eum assumenda explicabo.", 21, null, null, 0, "Qui tempora ut." },
                    { 22, 19455.0, null, null, "Reiciendis repellat ratione ratione hic ipsum reiciendis ad eius tempora natus sapiente ipsam officia quis nostrum est quidem saepe temporibus amet.", 22, null, null, 1, "Ut dicta voluptatem." },
                    { 23, 344170.0, null, null, "Quidem est ea dolorem explicabo aspernatur soluta nihil exercitationem ut voluptatem libero et quod eligendi asperiores fugit praesentium veritatis omnis nemo aut vero nesciunt sed perferendis facilis deserunt itaque.", 23, null, null, 0, "Quia perspiciatis voluptatem molestiae et molestiae." },
                    { 24, 223740.0, null, null, "Commodi aut rerum ex officiis explicabo dolorem suscipit voluptas aliquid id ad voluptatem quaerat sed et.", 24, null, null, 0, "Perferendis iusto omnis." },
                    { 25, 416626.0, null, null, "Distinctio officiis quisquam sunt enim quasi rerum facere quas ab quo asperiores repellendus expedita laudantium officia deserunt saepe qui assumenda non voluptatibus.", 25, null, null, 2, "Rem est minima cum sunt." },
                    { 26, 198643.0, null, null, "Provident hic sed laboriosam voluptatibus eveniet exercitationem libero omnis distinctio qui sit deleniti dolor ut et eos temporibus odio voluptatem sed aut corporis quaerat iure ducimus quo veniam.", 26, null, null, 2, "Qui possimus est voluptatum." },
                    { 27, 168191.0, null, null, "Assumenda officiis id consequatur nostrum sit eum saepe quidem omnis id quis laboriosam quaerat non distinctio est et corrupti perferendis voluptas tempore corrupti eum qui facere possimus rerum.", 27, null, null, 0, "Eos possimus doloribus doloribus quod molestiae." },
                    { 28, 12930.0, null, null, "Assumenda voluptate harum dolores optio qui vel et earum amet sunt ut alias velit occaecati ipsam.", 28, null, null, 0, "Ut repellat ratione nihil voluptas." },
                    { 29, 61328.0, null, null, "Odio reprehenderit quia aut earum qui voluptatum non est error velit fuga quidem.", 29, null, null, 2, "Qui odio occaecati." },
                    { 30, 290561.0, null, null, "Itaque recusandae vel temporibus voluptatem ut beatae occaecati cumque alias necessitatibus iste eveniet deleniti eius minima libero corporis nostrum esse aut quia est aliquid quae.", 30, null, null, 1, "Consequatur quod voluptas quasi." }
                });

            migrationBuilder.InsertData(
                table: "DealProducts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DealId", "ModifiedAt", "ModifiedBy", "PricePerUnit", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, null, null, 1, null, null, 41.0, 9, 22 },
                    { 2, null, null, 2, null, null, 82.0, 4, 65 },
                    { 3, null, null, 3, null, null, 84.0, 1, 18 },
                    { 4, null, null, 4, null, null, 54.0, 3, 3 },
                    { 5, null, null, 5, null, null, 39.0, 6, 86 },
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

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_Phone_Email",
                table: "Accounts",
                columns: new[] { "Phone", "Email" },
                unique: true,
                filter: "[Phone] IS NOT NULL AND [Email] IS NOT NULL");

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
