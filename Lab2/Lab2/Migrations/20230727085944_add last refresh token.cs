using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2.Migrations
{
    /// <inheritdoc />
    public partial class addlastrefreshtoken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastRefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "7695 Rolfson Mountains, Cummingsland, Vietnam", "Jayme83@yahoo.com", "Parker, Johns and Collins", "1-220-458-8241 x68487", 29646.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "0263 Oberbrunner Prairie, Lake Jeff, Egypt", "Lolita.Predovic@gmail.com", "Franecki, Bahringer and Kulas", "334-723-2807 x333", 24422.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "1287 Hessel Via, Howellfort, Greece", "Nicole49@hotmail.com", "Lesch - Wiza", "408-402-6079 x0434", 14922.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "881 Tommie Shores, Douglasview, United States of America", "Oleta49@gmail.com", "Brown - Altenwerth", "1-717-542-5676 x0069", 4169.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "676 Buckridge Forest, Emardshire, Belgium", "Garfield.Howe@yahoo.com", "Zulauf - O'Connell", "433-251-9782 x9177", 7235.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "5732 Kuhn Fort, North Karleeview, Gibraltar", "Sigrid_Kub@gmail.com", "Rutherford, Friesen and Sawayn", "1-465-707-5067", 38652.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "653 Bartell Route, Lake Zelma, Ireland", "Magali29@hotmail.com", "Hilll Group", "(815) 829-0345 x9949", 7098.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "510 Rickie Port, Satterfieldberg, Iceland", "Marianna96@hotmail.com", "Runolfsdottir - Jenkins", "851-450-1983 x0723", 14780.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "421 Murphy Inlet, North Max, Finland", "Harrison_Towne37@gmail.com", "Osinski, Kertzmann and Grady", "578-653-5680 x584", 24195.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "20452 Anissa Mills, South Dewaynehaven, Cocos (Keeling) Islands", "Trycia.Gleichner83@gmail.com", "Nicolas, Legros and Kassulke", "(541) 319-8751", 15987.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "58442 Oswald Oval, Nienowbury, Monaco", "Hubert.Abbott@yahoo.com", "Fisher - Quigley", "1-947-610-8711 x32474", 36761.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "9479 Ankunding Pike, Fernandoshire, Saint Kitts and Nevis", "Edyth_Konopelski96@yahoo.com", "Schiller - Fritsch", "(698) 786-5191", 17904.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "5257 Goyette Ridges, East Jadynborough, New Caledonia", "Danial49@hotmail.com", "Heaney LLC", "659-414-2517 x44932", 31038.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "02747 Alexanne Port, South Jabariton, Vietnam", "Nathaniel.Sanford@gmail.com", "Romaguera - Walker", "473.733.7141 x6214", 48587.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "31853 Ansel Brooks, Markusport, Cook Islands", "Dixie.Nienow95@gmail.com", "Breitenberg, Schoen and Von", "(591) 284-7109 x645", 17465.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "901 Franecki Lake, South Gennaroport, Switzerland", "Filomena.Grady@yahoo.com", "Schmitt, Pouros and Greenfelder", "348-960-7163 x71010", 45239.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "35894 Moore Ridge, Houstonburgh, Solomon Islands", "Bertram.Gulgowski@gmail.com", "Dietrich, Tromp and Hagenes", "581-716-8757", 35333.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "97435 Blanche Street, Port Juliettown, Japan", "Alva93@yahoo.com", "Heller LLC", "(613) 575-1862 x607", 48100.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "27293 Montana Port, South Roxannebury, Tunisia", "Tad20@yahoo.com", "Jaskolski - Schuster", "(605) 348-3521 x97924", 13994.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "3282 Kohler Forest, Jenkinsville, Samoa", "Jordane.Mueller@hotmail.com", "Dickinson Inc", "714-251-9390", 21293.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "45085 Casimir Station, Lake Jamal, Paraguay", "Lavon.Hoeger27@yahoo.com", "Heidenreich - Reichel", "378.625.4308 x286", 24112.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "96520 Bogisich Squares, North Deanna, Monaco", "Ruby_Raynor35@hotmail.com", "Effertz and Sons", "(939) 686-8580 x07588", 36013.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "804 Ruthie Village, West Tressa, Malawi", "Jordan20@yahoo.com", "Cartwright, Morissette and Smith", "(904) 614-0028", 18469.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "33027 Asa Spring, Destiniborough, Netherlands", "Annie_Bernier@yahoo.com", "Green, Swift and Hamill", "545.308.0609", 6837.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "453 Thompson Knolls, Goodwinland, Afghanistan", "Isobel.Kiehn41@hotmail.com", "Blanda - Donnelly", "802.871.8579", 49058.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "LastRefreshToken", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2ed0e10-7076-4ac1-b6d5-f93f2236707d", null, "AQAAAAIAAYagAAAAEISPPdkvr6G+PgwexnBIyjhiBsDEMJ3QDjwm834ss6P57Hmr5zc7/N1L0xay7j7dHA==", "e50f6dcf-88c0-4456-a7a6-47ba082386a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "LastRefreshToken", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "05e65c46-4862-41d0-8e09-1d6091d21163", "Damian_Bauch19@hotmail.com", null, "Roma Trantow", "AQAAAAIAAYagAAAAEJRPxSRB8t5dywBXewxC2pblhWj2p0vLrLTHwa14kCloqyObcXJX7Tx33iZM1r5yBA==", "f22b7e28-e482-454f-8b5d-12a163f130c3", "Damian_Bauch19@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "LastRefreshToken", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c5f4aa4f-112a-4733-85cf-05cb8724c50f", "Connie.Klocko86@gmail.com", null, "Jaylen Marvin", "AQAAAAIAAYagAAAAELY/0iwAbsVtHM8aXUexQGFPtpV2V3qHZyRZX2iYD687KkT9yRJ6b/RKgRniBoKPQg==", "0f7f63c1-4cc2-4a6e-8e9b-d9cde7c06560", "Connie.Klocko86@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "LastRefreshToken", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4d1ad72c-1240-4b1f-9fd0-d5bf4e4376c1", "Devin34@yahoo.com", null, "Hailey Willms", "AQAAAAIAAYagAAAAECU1158v51gNHFjfsL/vJCOsm2QHULywFjqXHGuDpyTBBEvnXln/5wFOjnTGWr3KpA==", "72d6eafe-eded-4e98-ba30-b43012483d63", "Devin34@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "LastRefreshToken", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b4bef67d-f560-4d34-b216-507bbf9d5e9f", "Roxane_Kris@hotmail.com", null, "Cody Howe", "AQAAAAIAAYagAAAAEFFkoVgUA0pJ7V2KBKFe/f8rMqFlL1m4nKP7t3ZEqL26xGj9o8VNrfDalWrNZPot1A==", "3aa4b59c-b50e-47d7-a4e9-31eb8a5d911c", "Roxane_Kris@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "LastRefreshToken", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c10dcd33-ea55-4c92-99d7-daa48b51c026", "Esta_Barrows26@hotmail.com", null, "Fausto MacGyver", "AQAAAAIAAYagAAAAENU28cK9uioyNYkeEie9lFjx+tzoLWYNGE7+deg601TKnNoEhvp3yci0THkbF+DAfQ==", "b30cc5fe-c027-4054-a899-0832534ef6b4", "Esta_Barrows26@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "LastRefreshToken", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0ddb1af7-bc94-4d78-996c-9b92bd61b3ab", "Emie.Emard49@gmail.com", null, "Jalyn Sanford", "AQAAAAIAAYagAAAAELDhatPXMUYjdLzy9cx1ikymsvzdeiqQ4S8yGy4iwn9AKq7gbxVS/Ael6r/uSlyRkQ==", "c31f55c9-5c73-42fc-b5de-51a00372b44f", "Emie.Emard49@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "LastRefreshToken", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fbb974dd-c345-48b3-ab4d-d553791faea0", "Erwin_Dicki@yahoo.com", null, "Adeline Luettgen", "AQAAAAIAAYagAAAAELpgmpPO3eo/kJACUkbX0lvHmJ4mFI9zp1QwRTbetJecJ8VGS9TlQC4ErdOcPxw3bg==", "78e1cc1f-79d1-426e-96bd-e89f9968d008", "Erwin_Dicki@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "LastRefreshToken", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ddfcb257-ac9c-42e3-ac22-a8ecc37f7bcd", "Gaetano_Cummings@hotmail.com", null, "Marc Kertzmann", "AQAAAAIAAYagAAAAEFHwvLmsFhVZfDKrPc69ukkW01w+2VZ/O3S4iXfXtkopOrSVqhcCxqPKInxRI8kKzg==", "3382e0db-0a4a-4c05-88ac-fe3361c63c05", "Gaetano_Cummings@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "LastRefreshToken", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7a23a0c9-0af8-4347-a592-54ecb5931cf7", "Joana_Botsford20@yahoo.com", null, "Laverne Fadel", "AQAAAAIAAYagAAAAEB1nGrL2+zXAljCAlY+A4f+vhOTZc/u7nRD+L1lGPJSdp81thkyZ0qCyeKm6uMKKbw==", "94c6f9ee-f200-4d3c-a3fb-beb34c866967", "Joana_Botsford20@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "LastRefreshToken", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d8c59baf-e508-4138-8916-56698db652a3", "Earnestine71@yahoo.com", null, "Jacklyn Mertz", "AQAAAAIAAYagAAAAED9p/LpFiKWs6e7CPKdNm/gPisamTh/rRV04cfQ1XUuxW9A2+SfGZxFT5XWGx/xUog==", "4f60c51e-3617-4ff1-a737-d7c221a7874b", "Earnestine71@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "Email", "LastRefreshToken", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c5c85bc0-2363-4cbc-a26c-dbd2ebb6ac9d", "Elissa13@gmail.com", null, "Onie Skiles", "AQAAAAIAAYagAAAAEPDax/dfL2k1afpxRbwAt+xFeKJe4K79zet7k7eLx+N92srg/Sk7pCwJifQiCvxKfg==", "f7d52097-f6c1-4a45-9c6d-c781b9480965", "Elissa13@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "Email", "LastRefreshToken", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6538d5cd-dbf0-4e10-a1d3-d3fbf2feee8e", "Mariela_Kunde@hotmail.com", null, "Laury Hand", "AQAAAAIAAYagAAAAEOqgxbIA4exvDa80GMUVkSm4K1UpZlt56WCJMi2QiRgyf86BWJbcJp/yIBsFfTRmGg==", "73ffc9d4-a599-4626-86ee-1e11d885ecab", "Mariela_Kunde@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "Email", "LastRefreshToken", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f3ab0a57-beb1-462d-9466-0a861be317e0", "Salvador68@yahoo.com", null, "Lila Barton", "AQAAAAIAAYagAAAAEMVPFke4vPD23lkizVElIUAbboZw3dEaJQ97yZ+4dzdgN+K53CC2wb9MdppNA9CxlA==", "94f0d0d6-fc57-4e73-896a-8b70e0eabc93", "Salvador68@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "Email", "LastRefreshToken", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d31bd3ce-d145-430d-a776-6acaa67130cd", "Tyree_Dickinson25@yahoo.com", null, "Bryana Hegmann", "AQAAAAIAAYagAAAAEJk24G29kdgizvF2jg+mSm7FlMqI+bSbp4RpFvqBhm57pWPVQhc3sJbDYSt0EM2IXg==", "70b31e0e-b793-4a6e-82c0-f33851a8f5fe", "Tyree_Dickinson25@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ConcurrencyStamp", "Email", "LastRefreshToken", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1ee03d35-7ec6-4689-91ff-4a95e3c912cd", "Laurine.Herman@hotmail.com", null, "Miguel Mayer", "AQAAAAIAAYagAAAAEDfwHmog/VrtFARb5RbAxIQk7HZRFnEn/zWD+TELN9yHf81otbjgQ7TsuBP74IZA9Q==", "5c67eea0-0535-4de3-9618-31f37b5d91de", "Laurine.Herman@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 5, "Maximus.Spinka@yahoo.com", "Edyth Schumm", "(522) 858-1606 x9940" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 2, "Justice.Dietrich@hotmail.com", "Alena Jast", "449.616.5663 x6839" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 1, "Wade.Parisian@yahoo.com", "Lea Streich", "(255) 513-1607" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 16, "Meghan71@hotmail.com", "Cordia Wiza", "696.565.7042 x4141" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Jakob19@hotmail.com", "Ryan Konopelski", "1-789-716-7911 x3878" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 15, "Zoe.Olson58@yahoo.com", "Mathias Abbott", "1-761-743-3953 x7222" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 10, "Everette81@gmail.com", "Laury Bernhard", "227-719-5140 x4266" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 20, "Ubaldo_Kiehn@gmail.com", "Melyna Hagenes", "805.941.7956 x7609" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 19, "Velma_Feil@hotmail.com", "Danielle Conn", "792.406.3746" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Gene.Ratke@gmail.com", "Leonel Blanda", "232.500.8912" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 13, "Annamae_Zulauf@yahoo.com", "Cora Veum", "(305) 485-9077 x714" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 11, "Moses51@gmail.com", "Beulah Glover", "921-381-5416" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 16, "Kaylie88@yahoo.com", "Maia Bartoletti", "(885) 292-5296" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 17, "Jarret42@hotmail.com", "Jacquelyn Leuschke", "423-814-3422 x517" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 5, "Marquis45@yahoo.com", "Wyman Pacocha", "755.262.3255" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 8, "Friedrich_Trantow@yahoo.com", "Jacey Wilkinson", "(578) 624-7306" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 14, "Josephine_Bednar73@yahoo.com", "Rowland Gislason", "253.284.9948 x73862" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Kristin_Sauer@yahoo.com", "Edna Bechtelar", "711.362.6572" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 7, "Lilian_Champlin48@gmail.com", "Mohammad Carter", "278-760-4490 x26628" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 1, "Shanelle5@gmail.com", "Mabelle Cormier", "483.862.0816 x15631" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 2, "Jadyn45@hotmail.com", "Zaria Koepp", "841-372-3969 x29884" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 13, "Demond.Stamm83@gmail.com", "Madelyn Donnelly", "1-970-846-3467 x57562" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 5, "Alexane.Huels44@hotmail.com", "Elvis Ritchie", "(947) 495-5531 x66971" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 2, "Blaze40@yahoo.com", "Ayla Pfeffer", "546-330-3841 x3609" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 11, "Brady98@gmail.com", "Judge DuBuque", "786.258.6145 x044" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 19, "Sam_Crist@gmail.com", "Queenie Lindgren", "465-614-3173" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 19, "Michael84@yahoo.com", "Clifford Walter", "924-457-5831 x31401" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 7, "Dena_Kilback97@yahoo.com", "Sedrick Bergstrom", "354-660-6795" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 9, "Gerald.Buckridge71@yahoo.com", "Lavon Casper", "347-280-8449 x103" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 11, "Mathilde7@hotmail.com", "Bernita Krajcik", "841-227-7410 x892" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 10, "Loma35@yahoo.com", "Karianne Willms", "431.991.1987" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 24, "Daija_Jacobi52@yahoo.com", "Darren Murray", "(371) 483-7964" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Brook.Nolan@hotmail.com", "Harmon Orn", "213.412.6949 x9350" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 2, "Arjun47@hotmail.com", "Karen Jacobs", "914.461.4829 x818" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 14, "Cassie.Waelchi23@gmail.com", "Hans Klocko", "1-682-606-6313" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 6, "Braeden_Thiel@gmail.com", "Jaydon Hermiston", "(262) 978-7750" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 23, "Maude_Baumbach79@hotmail.com", "Pink Ward", "1-300-402-2982 x613" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 13, "Kaela.Kris@gmail.com", "Mohammed Muller", "558-844-8539 x902" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 1, "Santiago.Konopelski@yahoo.com", "Mckenzie Stanton", "(995) 359-1165" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 15, "Caitlyn.Moore0@hotmail.com", "Karelle Schinner", "348.417.2536 x9609" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 6, "Terence_McClure@yahoo.com", "Gabrielle Morar", "(724) 444-6868" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Kelton57@yahoo.com", "Jenifer Wyman", "471-467-1835" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 23, "Desiree64@gmail.com", "Burdette Wisoky", "(651) 597-1979 x162" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Ila.Hagenes@hotmail.com", "Ephraim Carroll", "343-601-0567" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Buford.Schneider@yahoo.com", "Bessie Wintheiser", "1-601-490-8059 x355" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 20, "Faustino_Walker53@gmail.com", "Kory Gaylord", "745.805.5359 x202" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 12, "Raina_Keebler@hotmail.com", "Casey Stamm", "(486) 240-3100 x3492" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 20, "Franco.Conn@yahoo.com", "Isaias Carter", "1-249-214-4142 x46843" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 14, "Abdullah_Roob75@hotmail.com", "Yasmin Barrows", "1-205-672-8427" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 24, "Tressie_Turcotte@yahoo.com", "Orrin Will", "(359) 823-0563" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 12, "Ali62@yahoo.com", "Monserrat Schneider", "490-740-1193 x862" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 20, "Linnea_Mayer@yahoo.com", "Erika Crona", "676.206.0257" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 19, "Odell.Spinka95@yahoo.com", "Nelson Auer", "(965) 202-5103 x427" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 15, "Darius.Hessel@gmail.com", "Aron Christiansen", "(666) 572-5020" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Madelyn45@hotmail.com", "Georgette Rempel", "505.629.9710" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 2, "Jonas85@hotmail.com", "Tremaine Fahey", "(812) 917-2880" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Nichole9@gmail.com", "Zelda Ondricka", "589.329.1889 x30384" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 16, "Conor31@hotmail.com", "Vickie Cummerata", "1-432-553-8640 x8295" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 24, "Lyda64@gmail.com", "Sophie Daugherty", "1-762-605-6479" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 19, "Alexandrine.Douglas@yahoo.com", "Kendrick Hills", "448.910.6076 x366" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 21, "Zane.Lakin12@gmail.com", "Yolanda Williamson", "778-692-1767" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 19, "Marvin36@hotmail.com", "Colby Heller", "661.701.9902" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 25, "Clarissa40@yahoo.com", "Ari Schulist", "(862) 931-4397 x5731" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 9, "Johnathan_Conn97@hotmail.com", "Camylle Erdman", "1-951-750-0647" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 23, "Barney_Kilback@gmail.com", "Nathaniel Nader", "(694) 203-0766" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Alec.Russel@yahoo.com", "Joe Grady", "1-435-446-3628" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 16, "Melyssa_Schaden85@hotmail.com", "Daren Kling", "398.466.5645" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 12, "Emie_Quigley@hotmail.com", "Jarret Krajcik", "925.389.6780 x057" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 24, "Daniela14@gmail.com", "Elvie Crist", "424.516.4139" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 20, "Estevan0@yahoo.com", "Rory Carter", "255.296.2006 x07278" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 12, "Bo.Prohaska@yahoo.com", "Dane Jaskolski", "1-403-973-9606" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 25, "Alysha_Brown43@gmail.com", "Kassandra Hickle", "(496) 896-1732" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 8, "Larissa_Stamm@gmail.com", "Emery Bruen", "729-578-9145" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 8, "Letha.Dietrich@gmail.com", "Granville Wilderman", "510.958.1464 x954" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 18, "Kris.Maggio35@hotmail.com", "Jeanie Beer", "267-441-2556 x05906" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 17, "Reese.Johnson99@hotmail.com", "Natasha Maggio", "451-932-7731" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Jefferey_Nitzsche@gmail.com", "Annabel Kunde", "(768) 917-5217" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Coy48@gmail.com", "Carmen Leuschke", "917.292.2012 x20068" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 17, "Javon76@yahoo.com", "Newell Gutkowski", "(784) 857-9481" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 10, "Clair39@gmail.com", "Immanuel Stanton", "349-400-1878 x057" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 10, "Penelope95@hotmail.com", "Maurice Stark", "1-311-670-0174 x18788" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Kathryne_Nitzsche@yahoo.com", "Earnest Okuneva", "1-598-716-5655 x9646" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 9, "Marisol.Rogahn81@yahoo.com", "Selena Kuhn", "1-572-909-8954 x1191" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 18, "Jayden_Deckow@gmail.com", "Nyasia Kertzmann", "836.574.2469 x516" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Berta_Olson88@gmail.com", "Roosevelt Mraz", "(531) 592-7645 x877" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 21, "Jeffrey54@gmail.com", "Raymond Harber", "(929) 291-4510" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 11, "Jada.Gutkowski11@yahoo.com", "Elton Glover", "(640) 862-7056 x6697" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 7, "Laurie.Schaden37@hotmail.com", "Nathaniel Wilkinson", "423-828-2574 x7261" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 5, "Jewell82@gmail.com", "Marques Pollich", "1-233-356-4229" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 5, "Maximo.Kulas74@hotmail.com", "Milo Hilpert", "(841) 524-2331 x93685" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 22, "Rae_Kling@hotmail.com", "Marcia Boyer", "840.385.0681 x723" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 20, "Korey_Cassin@yahoo.com", "Kristina Ebert", "845.215.6233" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Noe_Schultz25@yahoo.com", "Garry Daugherty", "(523) 765-6283 x4927" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 8, "Gilberto_Feil@gmail.com", "Ora Herzog", "(299) 220-6174" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 23, "Pattie96@gmail.com", "Brandt Bernier", "485-239-2499" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 22, "Darren.Lockman@gmail.com", "Jacklyn Becker", "483.702.4773 x59309" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Jarod_Jakubowski83@yahoo.com", "Anya Vandervort", "(467) 501-2803 x3331" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Kennith38@hotmail.com", "Fae Rodriguez", "(698) 695-4397 x691" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 14, "Yesenia25@gmail.com", "Joyce Feil", "(830) 836-6188" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 10, "Brooks.Lindgren31@yahoo.com", "Kitty Corkery", "1-657-489-9330 x135" });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DealId", "PricePerUnit", "ProductId", "Quantity" },
                values: new object[] { 1, 77.0, 5, 7 });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DealId", "PricePerUnit", "ProductId", "Quantity" },
                values: new object[] { 27, 25.0, 8, 8 });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DealId", "PricePerUnit", "ProductId", "Quantity" },
                values: new object[] { 11, 22.0, 6, 5 });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DealId", "PricePerUnit", "Quantity" },
                values: new object[] { 3, 68.0, 33 });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DealId", "PricePerUnit", "ProductId", "Quantity" },
                values: new object[] { 12, 93.0, 1, 86 });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 326912.0, "Sapiente vel officia quo adipisci perspiciatis omnis illum in ipsa architecto et enim rerum fuga reprehenderit ut.", 0, "Deserunt provident at." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 424208.0, "Et officiis non quo incidunt dolorem et saepe tempora perferendis consectetur nemo ipsam modi molestias quaerat dolor est consequuntur voluptatem dignissimos aut.", 2, "Amet sed eveniet autem adipisci." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 463108.0, "Dolores nihil autem sunt dolor modi rerum sequi aut est quod enim nemo ad veniam dolores quo ut error fuga.", 0, "Expedita quibusdam labore." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 292782.0, "Consectetur modi nemo sapiente temporibus quos ducimus cum aliquid aperiam rem laborum voluptate et odit aut pariatur earum quas.", "Quia voluptatem modi explicabo." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 109567.0, "Fuga illum et tempora nemo qui corrupti provident modi veritatis alias qui similique quod hic vero aut sit odit odio consequuntur unde optio omnis distinctio consequatur alias aliquid.", 0, "Deleniti ea ut." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 110555.0, "Ut vitae nihil sed sapiente sit in cum deserunt iure dignissimos est quisquam quo nemo nemo voluptate et eos placeat deserunt aut in et qui sint.", 1, "Accusantium dolores voluptas." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 319983.0, "Magni fuga perferendis dolorum consequatur consequatur quam occaecati doloremque vitae aut consequatur eius quis optio eveniet neque aut et et porro sit.", "Non voluptas ad saepe blanditiis tempore." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 499327.0, "Debitis quia provident eos quod molestiae est consequuntur similique molestias non id et temporibus voluptatem ipsa voluptas libero tempore necessitatibus aut in voluptatem fugiat et commodi repellat odit.", 1, "Corrupti beatae reprehenderit omnis eos aperiam." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 185531.0, "Occaecati non quia mollitia aspernatur beatae doloribus voluptatum autem deleniti blanditiis tempore et ipsam dolor amet ipsam ut consequatur hic excepturi porro ut ut et nihil rerum commodi quidem possimus.", "Quidem qui ea autem est doloribus." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 427231.0, "Voluptas dolor earum beatae excepturi soluta reiciendis laboriosam harum minima at consectetur dolores quia rerum dignissimos expedita mollitia rem officiis dolorem provident tempora.", 2, "Ut et odit tempore consectetur." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 277320.0, "Voluptatem et expedita quas nobis nisi quis ullam ut voluptas expedita accusantium sit dolorem assumenda expedita.", 2, "Repellat odio est praesentium." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 82956.0, "Sunt est et autem possimus dolores ducimus porro incidunt autem provident consequatur omnis in voluptates officiis culpa aut beatae voluptas est.", 0, "Aliquam vitae minus." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 250037.0, "Debitis rerum ut et rerum et nihil aut non sed dolorem ea non omnis non molestias quia itaque est voluptas temporibus maiores.", "Possimus a adipisci nostrum." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 362293.0, "Ut repudiandae incidunt quia odit voluptatibus aut velit sit omnis nihil eos hic sequi soluta nam.", 0, "Et velit et quas sit esse." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 436060.0, "Adipisci voluptas beatae vel itaque beatae voluptatem vero vero dolorum consequatur in velit voluptatibus consectetur quidem accusamus.", 1, "Itaque neque omnis tempore tempora quisquam." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 288435.0, "Doloremque repellendus nesciunt ipsum itaque nemo placeat adipisci vel nihil.", 2, "Dolores nesciunt possimus omnis." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 32580.0, "Hic unde sed et blanditiis sunt aperiam perspiciatis est consequatur et a error quibusdam molestias.", 2, "Accusamus sunt debitis voluptas qui." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 102238.0, "Consequatur earum aliquid voluptate laborum ipsum in voluptas non quae voluptatem.", 0, "Soluta est delectus vel." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 193577.0, "Doloremque illum velit atque totam suscipit praesentium at earum alias officiis odit vero perferendis a qui minus quis quia est in in minus repudiandae ut.", 2, "Facere maxime tempora repudiandae ut." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 467089.0, "Omnis natus consequuntur fugit deleniti similique et ad quas est culpa nemo aut nemo rerum maxime aut consequatur excepturi quidem quisquam ab.", "Ut rerum eius iusto sint." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 74833.0, "Molestiae beatae aut dignissimos deleniti deleniti eum quo quod non.", 1, "Aut tenetur eius accusantium." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 334273.0, "Assumenda soluta ea vero omnis autem dolores odit nisi ut magni repellendus nihil in dolores reprehenderit voluptatem qui minus inventore velit a quia eos et qui qui est iusto omnis.", 0, "Vitae ipsum quidem." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 343217.0, "Maiores illum molestiae dolor incidunt inventore facere nesciunt incidunt sint quia earum consequatur est enim repellat tempore voluptas est ipsa perspiciatis mollitia eaque mollitia.", 2, "Quae iure sint ea." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 261317.0, "Sequi laboriosam hic sint sunt sint et nesciunt vitae sequi qui ut accusamus non voluptatem autem mollitia molestias aut eaque eveniet non enim omnis est nostrum saepe vel.", 0, "Sequi ullam veniam quas." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 344971.0, "Doloribus totam quasi sequi ut autem molestiae at eos ratione sit ut optio voluptas qui quia libero dolorum odit porro odio aut voluptates.", 1, "Esse distinctio consectetur non nisi ut." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 73198.0, "Eum omnis ut aut voluptates molestiae est laudantium occaecati eum aut non et omnis ipsa hic recusandae consequatur recusandae quia mollitia esse error dicta.", "Eaque itaque sit sit." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 385975.0, "Eos ut fugiat provident doloribus molestiae rem similique laudantium et pariatur rem consequatur.", 2, "Quo tenetur qui ex excepturi." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 316056.0, "Itaque dolorem aut eius qui expedita voluptates nesciunt sint ipsa sit facere aut vero tempore quia officiis reiciendis qui ipsam et.", "Aut velit molestias atque asperiores." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 493436.0, "Eum quis asperiores sunt autem at rerum vel corporis sapiente fugiat est soluta molestiae corrupti recusandae distinctio autem tempore sit veritatis dolore aliquam ut.", 2, "Dolorum qui quae et." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 123049.0, "Sequi blanditiis voluptas vitae est nam corrupti et blanditiis assumenda ut necessitatibus quod cumque sunt.", "Quasi sint sed voluptate et repudiandae." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 5, "Magnam perferendis occaecati et alias voluptatum voluptatibus tempora voluptates inventore rerum eius debitis quisquam vero porro rem aut.", null, 338126.0, 3, 0, "Sed voluptatem libero ea." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 2, "In quo veniam qui est molestias non aut eum perspiciatis ea dolorum eligendi quidem molestiae quam consequatur eos aspernatur porro consequatur eum.", "Dolorum quibusdam laborum est corporis consequatur eum ut ratione cum molestiae reprehenderit earum eius incidunt est deserunt voluptate facere voluptatem nihil dolor.", 4, new DateTime(2023, 1, 12, 15, 7, 36, 318, DateTimeKind.Local).AddTicks(2466), 268534.0, 0, 3, "Sed veniam impedit aperiam adipisci corrupti." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 14, "Praesentium temporibus architecto est provident facilis sint qui rerum officiis praesentium unde et asperiores praesentium eaque velit est quisquam neque necessitatibus dolor sunt voluptate molestiae quibusdam.", "Sed veniam rerum voluptatem eos numquam quia assumenda asperiores nam doloremque consequatur sint laboriosam.", 4, new DateTime(2023, 7, 3, 13, 25, 20, 758, DateTimeKind.Local).AddTicks(2310), 203197.0, 4, 3, "Eligendi et qui reiciendis excepturi maxime." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 25, "Perspiciatis omnis magni et eos sed expedita voluptas repudiandae nihil ut numquam aspernatur nobis placeat totam sint autem id quis harum iure dolores id sunt ea.", 421933.0, 3, "Saepe architecto aut consequuntur." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 15, "Temporibus a ut fugit ipsa sit accusantium ipsum eaque et saepe et totam dolores aspernatur.", "Aut modi autem nulla amet ea amet quibusdam qui incidunt neque placeat.", 1, new DateTime(2022, 10, 7, 15, 38, 47, 198, DateTimeKind.Local).AddTicks(7758), 242385.0, 2, "Quaerat fugiat rerum ut." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 22, "Voluptatum et voluptatem eum autem maiores sit commodi et fuga animi laboriosam.", null, null, null, 498569.0, 2, 1, "Non blanditiis blanditiis." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 7, "Numquam ipsum in consectetur et nostrum laborum aspernatur adipisci voluptatem repellat laboriosam.", new DateTime(2023, 1, 29, 11, 13, 12, 678, DateTimeKind.Local).AddTicks(3137), 82859.0, 0, "Provident quos nihil placeat aut non." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 21, "Quae beatae laboriosam minus corporis cupiditate eum quidem nulla in voluptatem sint sint nisi accusamus quibusdam iusto reprehenderit delectus possimus aspernatur quidem quia dolorem tempore ea quaerat quidem minima.", 312893.0, 4, 0, "Dignissimos sint quibusdam non architecto architecto." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 20, "Tenetur sit ut eos facere ea nulla iste optio quas tempore ullam esse.", "Consequuntur quis labore deserunt minus voluptate assumenda sit occaecati voluptatibus eos beatae cum harum suscipit atque magnam fugit expedita quibusdam ut quia.", 1, new DateTime(2023, 1, 6, 10, 56, 15, 773, DateTimeKind.Local).AddTicks(7501), 137423.0, 2, 3, "Consectetur debitis maiores ab ullam quia." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 10, "Vero assumenda non esse explicabo earum deserunt sint voluptas est sit rerum sit voluptatem placeat earum doloremque praesentium occaecati dignissimos est eum non distinctio.", new DateTime(2023, 3, 1, 21, 19, 35, 439, DateTimeKind.Local).AddTicks(9835), 485851.0, 0, 2, "Alias debitis dignissimos iusto quam." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 13, "Et assumenda aut impedit corporis vero ut molestias error blanditiis eum distinctio doloremque quia voluptate totam ea ut quo aut ut laboriosam ullam beatae quia asperiores.", "Exercitationem ab officiis est enim autem aspernatur quam et excepturi consequatur magni sit autem corporis quis quo quibusdam quam facere magnam sunt temporibus esse assumenda sint vitae voluptatem ad et.", 4, new DateTime(2022, 8, 17, 23, 15, 55, 449, DateTimeKind.Local).AddTicks(1802), 172146.0, 4, 3, "Quos omnis ad." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 21, "Dolor quis aut in possimus aut atque rem molestias et sunt omnis ut ut dolores est dignissimos provident cupiditate ut fugiat.", null, null, null, 35681.0, 0, "Dolore optio qui et." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 21, "Voluptas debitis nemo repellendus ipsam explicabo voluptas ut illum praesentium et est dolorum.", null, null, null, 86741.0, 1, 1, "Soluta doloremque tempore tempore soluta." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 2, "Vel ab qui aliquam necessitatibus deserunt pariatur earum autem assumenda exercitationem distinctio a distinctio placeat consectetur enim.", new DateTime(2023, 1, 15, 21, 13, 37, 435, DateTimeKind.Local).AddTicks(5568), 287355.0, 3, "Quo nisi illo cupiditate." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 23, "Dicta ipsum quidem eligendi quos corporis et ex consequatur debitis voluptatem dolor dolorem fuga excepturi ab voluptatem consectetur quaerat et aliquam et doloremque laboriosam saepe quidem maiores dolorum doloribus.", 348373.0, 2, "Qui et aut veritatis omnis nam." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { "Placeat soluta velit minima autem nam provident animi et consectetur molestiae excepturi enim repellat.", null, 6073.0, 0, 0, "Et ex pariatur pariatur sunt vel." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 4, "Aut esse quis nobis perferendis voluptatem quam magnam est at velit nulla quia aliquam earum ut autem quam eaque ut cum dicta quo distinctio expedita et.", null, 358710.0, 2, 0, "Cumque a sequi iusto." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 19, "Eveniet atque distinctio amet sunt voluptates aspernatur quasi non eveniet unde porro nisi quidem deleniti quia hic officiis dolorum cumque tempore.", null, null, null, 347624.0, 2, 1, "Quas id voluptatem in autem." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 2, "Officia pariatur sunt amet excepturi repellendus blanditiis quo ullam dolor labore quo.", new DateTime(2022, 9, 19, 23, 7, 36, 729, DateTimeKind.Local).AddTicks(426), 305719.0, 2, "Qui alias quia." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 11, "Aut odit magni ut voluptatem ut iusto ut occaecati aut quam nihil quod quis dolor ea vel voluptatem reiciendis nemo.", 473753.0, 1, "Ipsa animi ipsum quia." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 21, "Deserunt tenetur eveniet doloribus et incidunt accusantium voluptates repellat voluptas provident et eum saepe voluptatem vel ea quidem deleniti cumque quo fuga reiciendis quos cum labore id consequatur commodi autem.", null, 435583.0, 4, 1, "Nostrum in est asperiores maxime." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 22, "Vel facere adipisci sunt qui quae non quia vero occaecati harum deleniti voluptate velit cum deleniti molestiae cum quas optio tempore inventore ea aut eveniet consequuntur eos et sunt dolorum.", null, 404344.0, 0, 0, "Dicta dolor harum at voluptas impedit." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 23, "Qui iure ex qui eveniet sed dolores in optio perspiciatis omnis nihil.", "Et dolores dignissimos dolor facere corporis neque ratione eaque rerum nemo saepe recusandae consequatur facere iusto placeat delectus maxime qui eveniet quam voluptas voluptatem esse fugit ut.", 1, new DateTime(2022, 9, 13, 7, 33, 27, 267, DateTimeKind.Local).AddTicks(4873), 32518.0, 3, 3, "Ipsum facilis id dicta distinctio voluptatem." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 8, "Nihil eum et excepturi ipsum error eius aliquam eius maiores aspernatur earum voluptatem possimus voluptates quas.", new DateTime(2023, 7, 22, 13, 12, 47, 284, DateTimeKind.Local).AddTicks(6723), 467252.0, 0, 2, "Enim libero quae nihil incidunt tempora." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 11, "Ea sit alias natus possimus voluptas deserunt quia asperiores et quia et doloremque veritatis.", null, null, null, 25629.0, 0, "Voluptatem architecto ut ad dolores corporis." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 4, "Voluptatem temporibus maxime temporibus ipsum repudiandae voluptatum rerum minima rem nihil consectetur non ea.", 459413.0, 4, 0, "Incidunt reprehenderit nemo non." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 19, "Cum tenetur eum facere debitis sapiente dolorem delectus illo eligendi qui quisquam accusantium inventore sit porro minima debitis quaerat.", new DateTime(2023, 5, 1, 10, 28, 6, 460, DateTimeKind.Local).AddTicks(1190), 470625.0, 0, "Eius corrupti magni distinctio sed." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 11, "Omnis consequatur aut quidem facere similique aut et iste et omnis et et non dolor ipsa sed sit quo reiciendis occaecati qui velit voluptatem enim ducimus nisi.", 30384.0, 0, 1, "Suscipit voluptatum perspiciatis odit dolor." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 18, "Est blanditiis odit velit provident sapiente accusamus ex omnis et dolores architecto exercitationem sint cum laudantium quo fugit ut necessitatibus ut laborum optio est.", "Distinctio amet sed repellendus fugit debitis cum possimus velit similique quos quae quia cum autem magnam in dolorum.", 1, new DateTime(2023, 2, 6, 3, 10, 57, 879, DateTimeKind.Local).AddTicks(7696), 14840.0, 1, 3, "Ullam itaque nemo rerum." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 20, "Rerum error id praesentium placeat quidem tenetur molestias nihil molestiae rerum quae temporibus consequuntur ullam sit fugit suscipit placeat sed.", 435798.0, 0, 1, "Explicabo molestias maxime." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Fantastic Wooden Fish", 632.0, "PRO-92725553" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price", "ProductCode", "Type" },
                values: new object[] { "Sleek Concrete Chair", 485.0, "PRO-19880907", 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Practical Concrete Chair", 765.0, "PRO-78088948" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Ergonomic Plastic Bike", 348.0, "PRO-03613245" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Price", "ProductCode", "Type" },
                values: new object[] { "Awesome Steel Pants", 873.0, "PRO-90918735", 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Tasty Soft Towels", 777.0, "PRO-30271425" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Refined Frozen Mouse", 253.0, "PRO-13046323" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Generic Rubber Chips", 497.0, "PRO-57344577" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Intelligent Metal Table", 928.0, "PRO-30872783" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "Price", "ProductCode", "Type" },
                values: new object[] { "Refined Concrete Bike", 10.0, "PRO-97472896", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastRefreshToken",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "53077 Gibson Dam, South Isidrofort, Marshall Islands", "Giovanna_McLaughlin83@gmail.com", "Wisozk - Conroy", "1-873-487-0130 x6753", 9320.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "799 Thelma Overpass, Bogantown, United States of America", "Sanford.Mills@yahoo.com", "Schowalter, Ziemann and Abshire", "1-623-376-4391 x12917", 25368.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "0724 Tobin Prairie, Gutkowskihaven, Venezuela", "Emery41@hotmail.com", "DuBuque, Witting and Pfeffer", "1-242-750-3710", 25088.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "45512 Blake Plains, Tiachester, Ghana", "Josh_Wolf@gmail.com", "Orn, Brakus and Heaney", "1-710-529-7001", 29448.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "100 Lubowitz Ports, Larkinberg, Niue", "Brandyn_Wiza@hotmail.com", "Konopelski Group", "(433) 973-7236", 46180.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "227 Hammes Ports, West River, Ukraine", "Hosea62@gmail.com", "Tillman - Nolan", "(345) 474-7652", 3554.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "0906 Amya Field, New Carolina, Timor-Leste", "Kenneth_OConnell@gmail.com", "Hand, Pacocha and Gerhold", "1-645-426-6594 x17775", 22142.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "781 Wava Loop, Keeblerburgh, India", "Jude.Koepp95@yahoo.com", "Haag - Quigley", "(597) 239-5557 x0165", 48470.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "04394 Lynch Curve, South Clint, France", "Zetta.Wilkinson27@gmail.com", "Schowalter, Gulgowski and Kub", "302.378.1093", 9974.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "101 Ruthie Lake, Robertston, Qatar", "Max80@hotmail.com", "Konopelski, Mayert and Runolfsson", "890.811.0584", 35997.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "09718 Stroman Motorway, New Sunny, Eritrea", "Vernice79@yahoo.com", "Schoen Inc", "(546) 702-7719 x0251", 27021.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "4031 Austin Shoal, Priceland, Ghana", "Malachi.Stokes44@hotmail.com", "Murray, McGlynn and Batz", "338.641.2852", 12994.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "172 Balistreri Port, East Anyabury, Sweden", "Annette_Torphy@gmail.com", "Schimmel, Ziemann and Heaney", "881.661.4184 x2825", 19580.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "69374 Guido Mills, Lauryberg, Kuwait", "Gia43@hotmail.com", "Heathcote, Crooks and Powlowski", "219-657-3671 x557", 49110.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "009 Trantow Centers, Casperville, Djibouti", "Darien_Rau@yahoo.com", "Fisher, Schultz and Heller", "590-716-1311", 25853.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "9057 Kaitlyn Field, South Tyrell, France", "Jayne.Lynch@hotmail.com", "Gaylord - Hahn", "(455) 711-8293 x9712", 38752.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "39343 Denesik Centers, North Amber, Reunion", "Reginald.Quigley@gmail.com", "Volkman - Hammes", "496.685.6816 x5592", 32851.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "8309 Ruecker Rue, East Lonie, Belgium", "Merlin_Turner@gmail.com", "Corkery, Graham and Ebert", "(444) 783-3680", 29336.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "8161 Augusta Burg, Nicklauston, Canada", "Kurtis_Waters7@gmail.com", "Rippin - Heaney", "1-879-334-2038", 1633.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "2810 Leffler Oval, Port Laura, Tanzania", "Lamont62@yahoo.com", "Frami Group", "1-734-875-5477 x465", 13267.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "2956 Jerrell Mountains, Marilouside, Czech Republic", "Alessandra59@hotmail.com", "Kihn Inc", "254-453-2273", 8933.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "5637 Stehr Curve, New Ottilieville, Egypt", "Lavinia_Murray61@hotmail.com", "Leffler and Sons", "1-673-766-4615 x899", 1080.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "9067 Zelma Brooks, Rippinton, Swaziland", "Bill.Reynolds@gmail.com", "Windler, Olson and Zulauf", "1-750-372-0747", 44233.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "34786 Cameron Cove, Armandostad, Marshall Islands", "Johanna64@yahoo.com", "Prohaska Group", "802-774-6029", 10032.0 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "Email", "Name", "Phone", "TotalSales" },
                values: new object[] { "06565 Schroeder Rest, Legrosborough, Indonesia", "Fritz67@yahoo.com", "Rodriguez - Streich", "(627) 866-5793 x829", 25821.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adeb68b1-d5ba-49b2-aad8-4a0cca46f45c", "AQAAAAIAAYagAAAAEClQ/jnCf7zr+8ck8ZNQKBTnODsGEFxZDvB86/wQf6sQdviAT52hI4rNgTyxC7xFUQ==", "0a49a020-87c7-411b-ba5b-dc2465203ca5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "82b24761-fcb8-4e20-a809-6efcf47d8096", "Alvera92@gmail.com", "Eladio Spencer", "AQAAAAIAAYagAAAAEEQzWPYmDucLCQ385Hyw/vUJc+NnVAbs5a5OdNxLsHHh1pxdyxJ9EayX/OB25fPhSA==", "f3f7e935-f259-42b0-915a-b873cdfe898f", "Alvera92@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "512ca473-7580-4eba-9824-f7709f045852", "Viviane89@hotmail.com", "Kory Hermiston", "AQAAAAIAAYagAAAAEKwUOZSOKVQLmDPHqQ7FgWmfkvMhbogZrDWhORswDrPatV0gB1ZxmzhiofdSLYxeoQ==", "3da302eb-0f0f-4eeb-8f58-4a14ce1fa4e6", "Viviane89@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c085af23-a597-4457-b322-5e012026dd74", "Rowena_Klocko71@gmail.com", "Judy Maggio", "AQAAAAIAAYagAAAAECGfehRwE7R6pxtPVbpT3v2/Ep2qQqyJLa9Suis/aAV3ys8vkjN9Dl6JcqDeiBr8hg==", "f97e2262-1dfc-42fb-8a95-afdf5d85bbaf", "Rowena_Klocko71@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3dec411f-5bde-499e-b322-6f7888a7e720", "Lane.Greenfelder@hotmail.com", "Felton Schultz", "AQAAAAIAAYagAAAAEDZ3Z9ZyhTOHXtlBIm1hww9JCZpM+BpJmX7mkWfrS+yoroZErJu91kzc7lOHrm2VrQ==", "8123d797-f348-4770-818d-9ba1c6a088ec", "Lane.Greenfelder@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2ca843b3-3cd1-4453-8782-1373729de303", "Andy.Harris32@gmail.com", "Lauren Goodwin", "AQAAAAIAAYagAAAAECw5etEjoK+tfq9M+h4vA46PpIKobMvjxRn03ivJQuMQqfp+5uW8hbcsXWEVhH+FaA==", "b6558b45-c455-4a0e-8aac-501eeab9b0e5", "Andy.Harris32@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5b2ad305-8d37-4936-8817-8da59a7b9cef", "Efrain.Bayer@hotmail.com", "Matilde Effertz", "AQAAAAIAAYagAAAAEE21udrDUq6V0Krng+iDD4skIIYRjxy6p/KDnCbGyZpD0xQSfmc2xpFCGqFf6inFQg==", "2eb14e80-327c-449d-94b3-2040648c41d7", "Efrain.Bayer@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fbdbf15c-b72b-4bc6-8a46-da276a201b25", "Mackenzie_Barton@hotmail.com", "Mark Ondricka", "AQAAAAIAAYagAAAAEAzmdYZMm0xSZtRgvrUBLX+ovz5ou8ENlSyCpWsdAcKEBUKEjSjAqVZ/Pmeha1uZTA==", "98cbd070-5bec-4dc9-955a-5d72a642f581", "Mackenzie_Barton@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e1c91d08-b09c-4c58-be93-7d274caae086", "Guido.Breitenberg@hotmail.com", "Pattie Rolfson", "AQAAAAIAAYagAAAAEAzspd9C8X9ibxKASKSgulXQATMkKsZXGYPJYowNtZ/Hw5ABWp+4QRbuLNpu7mqMoQ==", "1762c5c0-6fca-4c1a-a821-d3ebf7e83c9f", "Guido.Breitenberg@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e0947149-0bec-4236-a400-5bb09744a401", "Maci85@gmail.com", "Isadore Zulauf", "AQAAAAIAAYagAAAAEIj9g7JDOvr0w2hRijPcbsJ+FwtjeO4t2s15xmp/mO8rzNR4+TcMjeGqYuY0Apmwvg==", "1c69f048-1024-4d5a-8651-afe9b42c5ccd", "Maci85@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0a162a6c-c06d-4b23-ba66-ecc2be6c0d51", "Dallas.Maggio52@hotmail.com", "Kennith Glover", "AQAAAAIAAYagAAAAEGiwY107ACNKOk9fC4wUN9CDhmmwr8HzOiEz0ApXiF+4TJ04TQNGNIhU3WIV3tCDcA==", "30e832bc-77b1-4e16-9590-67cdde6c7ec0", "Dallas.Maggio52@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "598cbcaa-cf32-4709-ba04-791d11e74969", "Fredy_McCullough@gmail.com", "Kathryne Hansen", "AQAAAAIAAYagAAAAELUSg7i6SWKBxvCE5KL8Q4nOaiyK4M8wC7boxJKYWTzr59v3G9WybDfXFlCzaCBqxA==", "4f3a268c-46bb-4625-b870-7f4a241af355", "Fredy_McCullough@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "faeb40c0-e355-41e5-ab3a-22798cd4cd97", "Pascale.Murphy5@yahoo.com", "Shea Bosco", "AQAAAAIAAYagAAAAEBI9UbLLXzBfbS4vgTo38JMVoZMCg31zljgmfKHllqbleAyxHDXNwKL3w/GqiQYkTQ==", "44b624c2-8eb6-4534-81c3-cd9a2b354553", "Pascale.Murphy5@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "58439a3e-c2a2-41ad-8f58-5379ef53b987", "Abdullah85@hotmail.com", "Joan Kunde", "AQAAAAIAAYagAAAAEAPfu3IGj1i8xnpSAAAe1+7mqML4Y1Iz5UwsKd1few2380bsGr6OJ6qYkbR0rUXevw==", "c1af4938-dda2-4b80-9e88-fe33ff7d3afc", "Abdullah85@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "00a3215c-37b9-436a-9e79-bc2f72e2cca9", "Layla_Schmeler@gmail.com", "Gaetano Marvin", "AQAAAAIAAYagAAAAEMFtrdr+EMA274d3lp8pkEpHb+VlL0JayJ6o5dHByOYLtoXBVg+zLFX6oES8t2xS4Q==", "68b3a1ff-2de8-4b79-9ea3-7f659cdbf814", "Layla_Schmeler@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "72769024-f94c-40f3-89ab-d4ce52799033", "Robbie_Dicki@yahoo.com", "Erich Fay", "AQAAAAIAAYagAAAAEDD7gLlZa38nJ6LuzDOGhY5w71h1lSryv3dG1p8hlhFsCGX4HEDXyBAJp7mYcx4SPg==", "f845eaf7-2cd6-4728-8fce-1be25a2d1047", "Robbie_Dicki@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 15, "Patricia99@hotmail.com", "Colten Donnelly", "763.299.3180" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 20, "Marianne.Wilkinson49@yahoo.com", "Waino Feeney", "426.640.7129 x9191" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 17, "Giovani42@gmail.com", "Jeramie Herman", "(515) 300-8262 x34541" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 22, "Maxie44@gmail.com", "Olin Zulauf", "550-576-6602 x5590" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 17, "Lilliana.Hoppe18@gmail.com", "Jaylan Veum", "291-631-4966 x166" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 23, "Gina80@hotmail.com", "Savanna Pollich", "(673) 499-4429" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 21, "Dina_Rice71@yahoo.com", "Braxton Hessel", "1-644-669-6591" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 24, "Cordelia.Rosenbaum72@yahoo.com", "Harley Lebsack", "1-261-337-5910 x476" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 13, "Reagan_Nikolaus14@gmail.com", "Mollie Lemke", "1-519-884-7033 x82669" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Salvador.Huel76@hotmail.com", "Ella Collier", "698.836.7874 x9413" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Hugh.Grady@hotmail.com", "Shayna Barton", "644.945.8634" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 12, "Reggie54@gmail.com", "Shany Mitchell", "887.200.0063" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 13, "Zack.Ebert@gmail.com", "Darien Tromp", "280.437.8678 x291" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 12, "Odie_Hyatt73@hotmail.com", "Fred Wilkinson", "(201) 460-2425 x2129" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 8, "Dorcas.Parisian78@yahoo.com", "Marty Gutkowski", "(609) 795-7536 x712" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 14, "Isaias24@hotmail.com", "Junior Williamson", "(462) 406-6990" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 11, "Aisha89@gmail.com", "Ayla Ritchie", "(422) 228-5506 x5673" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 13, "Alana_Bernhard@yahoo.com", "Kyleigh Lebsack", "(788) 463-5332 x9303" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 13, "Ruthe_Howell@gmail.com", "Citlalli Dickens", "(392) 685-9265 x59106" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 23, "Daphne_Wuckert@gmail.com", "London Schulist", "(660) 603-1883" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 18, "Jacynthe_Brown52@yahoo.com", "Daija Bayer", "(595) 482-4973" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 8, "Brook.Hartmann@hotmail.com", "Darby Hegmann", "1-605-863-2659 x09447" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Buford_Swaniawski73@hotmail.com", "Franz Bosco", "1-377-865-8678 x91521" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 19, "Ismael77@gmail.com", "Clovis Graham", "751.488.6767 x68774" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 15, "Rico32@hotmail.com", "Josiah Kirlin", "306.429.7876 x93641" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 22, "Larissa_Padberg@gmail.com", "Idella Bins", "840.556.8243 x8600" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 24, "Porter.Labadie@yahoo.com", "Cathy Kuphal", "419.277.4986" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 18, "Rosamond.Schuster@hotmail.com", "Unique Denesik", "1-975-424-9044" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 16, "Lucas10@yahoo.com", "Rachel Rippin", "1-654-430-0987 x2078" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 1, "Micah_McDermott99@yahoo.com", "Mara Boyer", "(330) 953-5144" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 2, "Elisabeth_Boyle@gmail.com", "Jaquelin Steuber", "1-708-847-7933 x94064" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Ken.Smitham@yahoo.com", "Eulalia Lemke", "(572) 230-5150" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 14, "Reina.Champlin61@yahoo.com", "Louisa Reynolds", "1-337-491-5885" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 18, "Ariane_Reichert59@hotmail.com", "Wilma Howe", "1-620-386-8588 x14839" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 6, "Valentin_Kuphal@hotmail.com", "Blanche Borer", "693.755.2469 x5496" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Frederick_Windler82@yahoo.com", "Carolanne Kunze", "437.882.8519 x6943" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 14, "Major57@yahoo.com", "Clement Beatty", "1-568-381-6971 x7291" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 5, "Hal_Rodriguez91@gmail.com", "David Cremin", "(743) 537-4663 x425" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 23, "Hector74@gmail.com", "Jovanny Reinger", "789-485-9162 x167" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 25, "Joshua_Miller@gmail.com", "Tavares Zieme", "213-515-6163 x942" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 23, "Wallace70@hotmail.com", "Kamron Carroll", "608.706.4943 x3717" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 25, "Freida79@yahoo.com", "Karina Abernathy", "405.672.2260" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 22, "Audrey.Quitzon96@hotmail.com", "Isai Borer", "295.662.6996 x46282" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 19, "Aliza62@gmail.com", "Beverly Stamm", "924.538.0039 x120" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 23, "Darrion40@hotmail.com", "Delphine Kreiger", "419.865.3909" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 17, "Julian_Haley59@yahoo.com", "Ora Towne", "357.705.6242 x4844" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 19, "Vella.Hand@gmail.com", "Mariah Pouros", "1-994-534-2291" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 21, "Patsy.Kris@yahoo.com", "Erik Barrows", "1-686-211-2348 x302" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 25, "Estevan48@yahoo.com", "Dejon Friesen", "958-977-5312 x44075" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Lysanne46@gmail.com", "Danielle Herman", "1-601-710-9893" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 18, "Maritza97@hotmail.com", "Hassie O'Hara", "1-462-889-1247" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 2, "Yolanda.Kunde48@gmail.com", "Samantha Satterfield", "1-348-514-2013 x072" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 16, "Ramon9@yahoo.com", "Nichole Cummerata", "(491) 662-0608" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 10, "Arnulfo.Aufderhar@gmail.com", "Judson Frami", "561.996.2838 x628" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Loren.Hegmann4@hotmail.com", "Myra Kub", "650-511-5975" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Amber17@gmail.com", "Maude Hintz", "1-294-970-8748 x3806" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Newell.Feil91@gmail.com", "Maida Crooks", "776-561-0843 x26575" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 18, "Carlo68@hotmail.com", "Irving Kerluke", "266.384.0226 x52095" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 2, "Maynard_Robel98@hotmail.com", "Sammie Wintheiser", "890.291.5231" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Llewellyn.Hand35@hotmail.com", "Lauren Zboncak", "(261) 554-7575" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 18, "Jaylin_Schaden@hotmail.com", "August Breitenberg", "912.456.6621 x504" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 25, "Lukas_Feil32@gmail.com", "Matteo Ryan", "610.664.1088 x6893" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Amir_Kreiger72@hotmail.com", "Catharine Funk", "(775) 539-4030" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 15, "Loy.OConnell@hotmail.com", "Isaiah Rosenbaum", "711.964.6877 x4819" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 5, "Eugene.Jenkins@hotmail.com", "Annabel Keeling", "(722) 646-0015 x75798" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 15, "Melvina48@gmail.com", "Lavada Walker", "(458) 878-1132" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 11, "Grady49@gmail.com", "Keely Kassulke", "495.432.9454" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 5, "Dennis93@hotmail.com", "Hailee Mosciski", "840-627-4931 x1738" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Frances87@gmail.com", "Felicia Wunsch", "1-496-443-5982 x2748" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 1, "Dewitt26@hotmail.com", "Edmund Homenick", "(713) 785-0684 x05677" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 16, "Devyn.Bernhard@gmail.com", "Mya Volkman", "1-892-353-9277" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 17, "Willis_Leannon@gmail.com", "Lou Reilly", "383.481.0814 x01286" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 12, "Justen39@hotmail.com", "Mallie Waters", "322.462.1567 x7668" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 7, "Corine.Schimmel68@hotmail.com", "Keely Marquardt", "405.365.6622 x4969" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 21, "Abe51@gmail.com", "Bridget Rogahn", "960-701-6490" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 24, "Mazie.Fay@hotmail.com", "Jairo Daugherty", "970-882-3369" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 6, "Marjorie_MacGyver82@yahoo.com", "Carole Sipes", "491.821.2395 x20091" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Selina.Collins@gmail.com", "Litzy Bahringer", "401-256-4462 x9085" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 20, "Lilly_Nikolaus@gmail.com", "Ross Thompson", "616-754-6613 x6850" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 7, "Orville.Abshire45@hotmail.com", "Joany Boyle", "1-412-452-9378 x89677" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 5, "Aurore_Wiegand@gmail.com", "Danial Volkman", "815.730.4664" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 5, "Aileen_Veum@hotmail.com", "Myah Walter", "909-274-4769" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 12, "Zechariah96@yahoo.com", "Newell Feeney", "1-773-641-6773" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Joaquin.Conn@yahoo.com", "Casandra Morar", "357.951.0451" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 25, "Elva.Windler41@gmail.com", "Robin Stamm", "(481) 714-5165 x526" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 13, "Nathanael3@gmail.com", "Ally Grimes", "335.639.1196 x606" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 23, "Mavis.Reynolds@hotmail.com", "Providenci Bartell", "355.448.6794 x8821" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 22, "Gideon_Hermann@yahoo.com", "Wallace Hessel", "1-221-930-9746 x837" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 21, "Willy.Olson11@hotmail.com", "Loyal Swift", "355-684-6931 x34971" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 22, "Ross.Turcotte63@hotmail.com", "Annamae Davis", "490.705.5723 x733" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 11, "Blaise54@gmail.com", "Alison Spencer", "767.833.1639" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 2, "Scot.Yost@yahoo.com", "Loy Wiza", "(480) 818-1011" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 20, "Joelle.OHara47@gmail.com", "Kenyon Brakus", "1-829-392-7902" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 5, "Abby.Bosco@gmail.com", "Cleo Berge", "1-683-259-8389" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 13, "Margot_Rippin91@hotmail.com", "Kenyon Kerluke", "1-787-462-3018 x1962" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Keenan.Yundt@gmail.com", "Dimitri Abbott", "1-751-593-1950" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 1, "Tania.Rempel@hotmail.com", "Maia Gottlieb", "542-689-2257 x5161" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 17, "Naomie.Daugherty@hotmail.com", "Holden Mraz", "1-713-858-2769" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 10, "Pascale_Doyle22@hotmail.com", "Abigail Hoeger", "(973) 939-7256" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 24, "Albin_Oberbrunner@hotmail.com", "Erica Walker", "(639) 488-8609 x4208" });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DealId", "PricePerUnit", "ProductId", "Quantity" },
                values: new object[] { 18, 16.0, 6, 37 });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DealId", "PricePerUnit", "ProductId", "Quantity" },
                values: new object[] { 11, 52.0, 2, 62 });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DealId", "PricePerUnit", "ProductId", "Quantity" },
                values: new object[] { 28, 41.0, 5, 58 });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DealId", "PricePerUnit", "Quantity" },
                values: new object[] { 9, 35.0, 31 });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DealId", "PricePerUnit", "ProductId", "Quantity" },
                values: new object[] { 29, 59.0, 6, 5 });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 147362.0, "Nihil est sint qui sit dolor quo excepturi velit ipsa qui temporibus.", 2, "Voluptas iure odio consequuntur." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 132576.0, "Reiciendis et ipsa sed odio doloremque explicabo asperiores officia nihil.", 1, "Quasi labore dolores culpa et." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 457023.0, "Totam reprehenderit nulla tenetur aut commodi maiores laboriosam numquam nihil quasi nemo et voluptatibus exercitationem sit qui facilis iusto suscipit omnis deserunt et assumenda occaecati est et eaque qui eaque.", 2, "Sed quia occaecati ea." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 392101.0, "Modi ea consequatur et consequatur tempora voluptatibus sed accusantium quo aut ratione ex modi aperiam sint sed reprehenderit perspiciatis et.", "Qui perferendis est aut." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 258733.0, "A et nulla id expedita et aut in vel nihil repellendus minus ab inventore veritatis ipsam molestiae corrupti nam quis id voluptatem sint.", 2, "Recusandae qui et nesciunt tempore." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 243898.0, "Illum non sunt eius quidem cumque sint corporis atque sint sed perspiciatis et fugit veritatis ut mollitia accusamus atque aperiam omnis sed quae cupiditate possimus corporis.", 0, "Excepturi facere esse voluptas libero pariatur." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 359806.0, "Veritatis perferendis doloremque ut et dolorem accusantium odio quos at et omnis esse voluptatem iure sed consequatur blanditiis voluptatem laboriosam sed et explicabo et.", "Quis mollitia deleniti voluptas delectus odit." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 36861.0, "Omnis quidem enim illum autem quis illum beatae quidem nihil dolores aut exercitationem porro quisquam animi ab ipsa expedita ratione ut.", 2, "Mollitia deleniti veritatis voluptatibus." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 177330.0, "Vel dolor dolor laborum est saepe esse dolores itaque dolorum quis repudiandae error libero voluptatem ut dignissimos consequatur distinctio vel sed et reiciendis qui sapiente iusto.", "Voluptatem vero explicabo voluptate ut eos." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 162354.0, "Perferendis sed totam iste eum vitae amet labore eaque qui vel voluptatem quos architecto facilis officia.", 0, "Officiis ea consequatur exercitationem." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 452267.0, "Sint est ut maiores omnis odit eius voluptas facere sit et eos et dolore optio omnis vel officiis aspernatur voluptate necessitatibus omnis sed ad.", 1, "Illum quod ad." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 357273.0, "Perferendis ducimus ea debitis culpa harum dignissimos ipsa praesentium quibusdam et eligendi fuga unde veritatis et similique beatae voluptas.", 1, "Qui delectus odit." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 24453.0, "Nisi provident est deserunt et aliquam rerum dolores velit nobis perferendis iste tempore dignissimos nemo.", "Harum dolor a." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 345506.0, "Unde labore magnam praesentium et officiis id quia itaque error sunt est enim et vel mollitia vel eos quia eaque velit aut fugit aut quo qui vero rerum ut.", 1, "Accusantium commodi quia natus vitae." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 426805.0, "Ut quaerat odio recusandae provident odit sit voluptas deleniti eos doloribus impedit voluptas assumenda aut nam sint ea cupiditate voluptates quas et vitae.", 0, "Ab officia architecto." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 330485.0, "Ipsa ut asperiores aperiam veniam aliquid amet non soluta debitis et fugit rerum soluta et placeat deserunt totam perspiciatis ad qui quae deserunt aut et asperiores.", 0, "Culpa alias aliquid." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 255267.0, "Voluptates et cupiditate ut culpa iste aspernatur quis distinctio sunt voluptate laudantium nulla error doloremque rerum ab.", 1, "A et eos et." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 433155.0, "Qui accusamus voluptatem dolores voluptas autem dolores praesentium aut aperiam quis qui et nisi vero sed ad officiis provident sed voluptas deserunt nihil deleniti et.", 1, "Ipsa esse magni maxime recusandae." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 386148.0, "Culpa odit dolore suscipit voluptatem similique accusamus ducimus aliquam accusantium impedit voluptates et aut id et quod minus commodi beatae necessitatibus eius maxime ea voluptatem eius reiciendis repellat enim.", 1, "Illo nam voluptatem dolorem dolorem." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 178706.0, "Ipsam voluptatem doloribus et repellendus commodi nam ea est molestiae recusandae quam recusandae dolorum maxime natus beatae aliquid porro sint eos odio quasi.", "Aut dolor vero earum et." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 330766.0, "Sit unde sit exercitationem provident dolorem omnis veritatis aut nemo ducimus fuga ea.", 0, "Quaerat dignissimos qui." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 446122.0, "Sit quisquam cumque et dolores eos saepe hic pariatur minus ullam aliquid nisi dolorum quis ratione et consequatur voluptatem dolorem dolore dolore totam in.", 1, "Tenetur quia quas ea sunt." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 442567.0, "Eius earum eaque nulla cupiditate tempora officia aliquam mollitia sed aut veniam nihil quia ipsum enim.", 0, "Adipisci eum nostrum." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 65717.0, "Soluta sunt modi est laudantium rerum et et aut et tempora eos magnam temporibus exercitationem pariatur aut ea ratione explicabo hic qui necessitatibus deleniti.", 2, "Voluptatem sequi et." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 157022.0, "Est neque dolores unde alias illo et quisquam hic quibusdam et voluptatem cumque unde corrupti aliquam neque autem et ab et dolores laboriosam perspiciatis.", 0, "Excepturi temporibus quisquam sunt nemo rerum." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 353902.0, "Ipsam consequatur omnis commodi est incidunt modi debitis animi quidem fuga doloremque eaque ad ut voluptas.", "Voluptatum qui dolor quidem perspiciatis." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 382713.0, "Optio voluptatem sit omnis consequatur velit cupiditate aut est soluta est eos rerum molestiae fugit omnis natus blanditiis.", 0, "Dignissimos magni ut voluptas molestiae odit." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 185442.0, "Voluptas beatae quod dolores at totam facilis libero vero reprehenderit qui delectus qui expedita quod esse sit voluptas est at magni iste repudiandae eaque ut sit et asperiores.", "Modi blanditiis voluptates asperiores." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 471952.0, "Dolore cum autem rerum et laborum aut quis vitae reiciendis soluta.", 1, "Atque ea ab ipsa sint." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 122418.0, "Possimus odit et dolorem magnam atque ut dicta accusamus sequi rerum hic quo soluta voluptates reiciendis quos architecto et corporis sed aut sint molestiae nulla rerum.", "Mollitia vel maiores." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 16, "Voluptas fugiat aut expedita hic ex in voluptatem sunt illo aut.", new DateTime(2022, 12, 31, 4, 39, 7, 848, DateTimeKind.Local).AddTicks(7090), 208710.0, 1, 2, "Ut eius voluptatem." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 8, "Itaque et expedita eos ducimus alias non excepturi quia ea cupiditate omnis ratione temporibus quis doloribus repellendus repudiandae et nobis in ab temporibus et.", null, null, new DateTime(2023, 1, 26, 16, 27, 10, 505, DateTimeKind.Local).AddTicks(9196), 336601.0, 3, 2, "Et velit minima possimus." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 13, "Odit molestiae quaerat est excepturi qui beatae quos aperiam ut et qui dolor exercitationem quidem magni voluptas illo nihil voluptas.", null, null, new DateTime(2022, 8, 18, 19, 10, 12, 836, DateTimeKind.Local).AddTicks(7064), 394448.0, 2, 2, "Est illo ut doloremque." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 9, "Ad earum pariatur magni aut commodi non minima est similique itaque sint.", 66188.0, 4, "Odit est voluptatem aperiam illum ad." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 3, "Et sequi numquam vitae velit fugiat dolores quasi aut quibusdam facilis soluta.", "Id voluptas praesentium et non quasi iusto est et quo qui dolore non pariatur necessitatibus doloremque et inventore quia voluptatem quo atque voluptatem sed placeat.", 0, new DateTime(2023, 3, 16, 5, 44, 17, 814, DateTimeKind.Local).AddTicks(873), 389063.0, 4, "Blanditiis non rerum aut veritatis laboriosam." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 17, "Rerum harum provident sed debitis non nihil quo doloremque iusto rerum.", "Adipisci vitae pariatur odio voluptate modi alias vitae omnis voluptatibus voluptatibus enim blanditiis quis quos qui sunt quidem aut nihil voluptatem voluptatum quidem soluta non.", 4, new DateTime(2023, 1, 27, 13, 9, 47, 64, DateTimeKind.Local).AddTicks(9916), 217468.0, 1, 3, "Unde autem officia aut." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 2, "Placeat reiciendis sed quia nemo quae rem voluptas tempora dolor quo iste et et neque amet.", new DateTime(2023, 4, 2, 19, 51, 14, 4, DateTimeKind.Local).AddTicks(5638), 165462.0, 1, "Commodi pariatur excepturi deserunt possimus voluptatem." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 18, "Quam voluptatum aut quidem quam quos id quae a sit voluptate aliquid expedita aut expedita at reiciendis iste ab voluptas.", 298045.0, 0, 1, "Sit omnis quod voluptates nostrum." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 1, "Eum dignissimos aspernatur quo voluptatum molestias amet rerum laborum quas in adipisci commodi architecto veritatis hic reiciendis repellendus aliquam.", null, null, null, 386515.0, 3, 0, "Ut assumenda consectetur nisi velit." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 8, "Corporis voluptatum adipisci commodi nulla aspernatur iure saepe qui et error ut laudantium aut in esse exercitationem voluptas ea nobis et est aut incidunt similique qui.", null, 482342.0, 1, 1, "Molestias nam id dolorem." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 3, "Vitae aut aspernatur magni et recusandae omnis nihil aperiam quod cumque nisi est dignissimos enim quasi omnis et ipsum pariatur atque temporibus expedita eum eum rerum.", null, null, null, 236838.0, 2, 0, "Tempora atque facere consequatur." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 7, "Eaque sit voluptas repellat voluptatibus et culpa eos cum et.", "Voluptas iste hic quae doloribus architecto sed sit esse qui quibusdam.", 2, new DateTime(2023, 3, 7, 21, 49, 43, 935, DateTimeKind.Local).AddTicks(658), 274634.0, 3, "Molestias hic ab molestias." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 9, "Magnam numquam et illo quia quidem omnis recusandae voluptatum aut aut quas omnis odit sit sit voluptatem voluptatum sit totam quo reiciendis eligendi molestiae impedit aliquam aperiam id quis vero.", "Ullam pariatur reprehenderit sit corporis aliquam consequatur eum est possimus minima iure veniam voluptatem aliquam.", 0, new DateTime(2022, 10, 11, 1, 33, 25, 709, DateTimeKind.Local).AddTicks(8028), 158134.0, 0, 3, "Nihil est aut omnis ea." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 14, "Culpa minus sunt cupiditate voluptates distinctio fugit repellat quo quis et soluta ratione reiciendis.", new DateTime(2023, 5, 9, 16, 51, 36, 468, DateTimeKind.Local).AddTicks(2451), 230972.0, 4, "Non cumque labore sed quam et." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 1, "Quibusdam ipsum id dolorem ut molestias rem dolorum magni sed iure praesentium quas et hic accusamus soluta officia dolores consequatur autem harum mollitia odit nulla.", 190078.0, 4, "Quia quibusdam ut est voluptatum quae." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { "Vero assumenda adipisci unde eius pariatur deleniti labore est eum nemo accusamus.", new DateTime(2023, 6, 21, 20, 42, 8, 569, DateTimeKind.Local).AddTicks(8329), 177223.0, 4, 2, "Ea similique molestiae." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 8, "Numquam ut omnis velit vero omnis reiciendis est ut non sed voluptas omnis labore qui iure at sint quas pariatur ut alias corporis.", new DateTime(2023, 1, 9, 12, 52, 21, 610, DateTimeKind.Local).AddTicks(283), 313005.0, 4, 2, "Beatae beatae rerum qui sequi." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 18, "Omnis rerum illum nihil repellendus asperiores iste deserunt natus optio et dolore ex sunt qui ut occaecati sint expedita eum in voluptas nostrum occaecati accusamus veritatis nesciunt ipsa atque.", "Ab nostrum nihil iure fugit cum odit necessitatibus velit rerum.", 3, new DateTime(2023, 4, 30, 3, 9, 35, 520, DateTimeKind.Local).AddTicks(8450), 373396.0, 3, 3, "Eius nobis aut nulla." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 18, "Asperiores unde alias recusandae fugiat aliquam ducimus non earum ullam nobis aliquid maxime non sit et dolor ab autem.", null, 161330.0, 0, "Cupiditate ipsa quis ipsa." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 12, "Voluptatem nemo nihil libero dicta ullam velit fugit fugit ut vitae sapiente qui reprehenderit et laborum placeat quibusdam repellat similique neque inventore sunt sit iste corporis assumenda aperiam aut et.", 192415.0, 3, "Nam adipisci aspernatur laudantium vel." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 5, "Sed doloribus sed et est consequatur magni temporibus dolorem fugiat perferendis fugit et.", new DateTime(2022, 11, 25, 7, 9, 56, 21, DateTimeKind.Local).AddTicks(4893), 382922.0, 1, 2, "Exercitationem accusantium sunt sed voluptatem sint." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 12, "Quis qui ut vel dolores repudiandae et doloribus molestiae vel.", new DateTime(2023, 3, 20, 18, 11, 21, 322, DateTimeKind.Local).AddTicks(8290), 257840.0, 1, 2, "Quibusdam velit ut rerum." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 4, "Distinctio temporibus vitae voluptate quia accusantium eos deleniti voluptas amet ut laboriosam consequatur optio nostrum voluptatem sapiente esse esse veritatis ab optio eum iusto dolores voluptatum.", null, null, new DateTime(2022, 9, 30, 12, 30, 3, 970, DateTimeKind.Local).AddTicks(894), 215202.0, 4, 2, "Fugit magnam consequuntur." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 16, "Accusantium fugiat voluptatem officiis quia quos qui expedita est repudiandae et sit perferendis modi eveniet sint fugit repellendus ut.", null, 442923.0, 3, 1, "Commodi impedit et." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 12, "Sed vero libero omnis in iusto quia quis modi quia unde consequatur fuga consequatur distinctio.", "Quae ipsam dolore ipsa accusantium aspernatur iusto nobis ratione qui dolor perferendis dolorum deserunt occaecati cum ad et natus officiis qui fuga.", 3, new DateTime(2023, 7, 4, 17, 34, 25, 122, DateTimeKind.Local).AddTicks(3755), 414314.0, 3, "Asperiores modi est." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 2, "Voluptatibus cupiditate soluta id at repellendus sed et non dolorem est illum minus.", 384082.0, 3, 1, "Voluptatem at ratione officia." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 25, "Non nisi nemo id consequatur voluptas et reiciendis aut qui rem velit eum et voluptatem nihil saepe qui libero officia autem beatae doloribus labore laborum.", new DateTime(2022, 10, 12, 10, 7, 47, 193, DateTimeKind.Local).AddTicks(974), 331496.0, 1, "Perspiciatis earum iste vero quos." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 25, "Dolorum delectus nostrum molestiae molestias consequatur minus voluptatem suscipit similique quisquam.", 155074.0, 1, 0, "Sit non quam sunt." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 22, "Sed qui doloribus laboriosam quod vel debitis porro officiis debitis non asperiores.", null, null, null, 193508.0, 2, 1, "Hic soluta in sequi cupiditate." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 22, "Eveniet aut soluta qui quia neque quia sed et ratione sint quia molestiae molestias vel rerum facilis et soluta recusandae corporis est sit ut eum deleniti eum.", 380947.0, 1, 0, "Odio natus sit assumenda." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Unbranded Cotton Fish", 111.0, "PRO-01768008" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price", "ProductCode", "Type" },
                values: new object[] { "Licensed Soft Table", 112.0, "PRO-03314005", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Intelligent Cotton Soap", 684.0, "PRO-56387612" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Tasty Rubber Towels", 587.0, "PRO-71796031" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Price", "ProductCode", "Type" },
                values: new object[] { "Small Metal Chicken", 228.0, "PRO-79830805", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Refined Steel Salad", 456.0, "PRO-05724048" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Licensed Fresh Bacon", 58.0, "PRO-34848463" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Handcrafted Metal Salad", 602.0, "PRO-46238078" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Licensed Fresh Bacon", 372.0, "PRO-17280488" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "Price", "ProductCode", "Type" },
                values: new object[] { "Handcrafted Rubber Fish", 119.0, "PRO-79397964", 1 });
        }
    }
}
