using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2.Migrations
{
    /// <inheritdoc />
    public partial class addrefreshtoken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenLifetime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshToken", "RefreshTokenLifetime", "SecurityStamp" },
                values: new object[] { "adeb68b1-d5ba-49b2-aad8-4a0cca46f45c", "AQAAAAIAAYagAAAAEClQ/jnCf7zr+8ck8ZNQKBTnODsGEFxZDvB86/wQf6sQdviAT52hI4rNgTyxC7xFUQ==", null, null, "0a49a020-87c7-411b-ba5b-dc2465203ca5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "RefreshToken", "RefreshTokenLifetime", "SecurityStamp", "UserName" },
                values: new object[] { "82b24761-fcb8-4e20-a809-6efcf47d8096", "Alvera92@gmail.com", "Eladio Spencer", "AQAAAAIAAYagAAAAEEQzWPYmDucLCQ385Hyw/vUJc+NnVAbs5a5OdNxLsHHh1pxdyxJ9EayX/OB25fPhSA==", null, null, "f3f7e935-f259-42b0-915a-b873cdfe898f", "Alvera92@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "RefreshToken", "RefreshTokenLifetime", "SecurityStamp", "UserName" },
                values: new object[] { "512ca473-7580-4eba-9824-f7709f045852", "Viviane89@hotmail.com", "Kory Hermiston", "AQAAAAIAAYagAAAAEKwUOZSOKVQLmDPHqQ7FgWmfkvMhbogZrDWhORswDrPatV0gB1ZxmzhiofdSLYxeoQ==", null, null, "3da302eb-0f0f-4eeb-8f58-4a14ce1fa4e6", "Viviane89@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "RefreshToken", "RefreshTokenLifetime", "SecurityStamp", "UserName" },
                values: new object[] { "c085af23-a597-4457-b322-5e012026dd74", "Rowena_Klocko71@gmail.com", "Judy Maggio", "AQAAAAIAAYagAAAAECGfehRwE7R6pxtPVbpT3v2/Ep2qQqyJLa9Suis/aAV3ys8vkjN9Dl6JcqDeiBr8hg==", null, null, "f97e2262-1dfc-42fb-8a95-afdf5d85bbaf", "Rowena_Klocko71@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "RefreshToken", "RefreshTokenLifetime", "SecurityStamp", "UserName" },
                values: new object[] { "3dec411f-5bde-499e-b322-6f7888a7e720", "Lane.Greenfelder@hotmail.com", "Felton Schultz", "AQAAAAIAAYagAAAAEDZ3Z9ZyhTOHXtlBIm1hww9JCZpM+BpJmX7mkWfrS+yoroZErJu91kzc7lOHrm2VrQ==", null, null, "8123d797-f348-4770-818d-9ba1c6a088ec", "Lane.Greenfelder@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "RefreshToken", "RefreshTokenLifetime", "SecurityStamp", "UserName" },
                values: new object[] { "2ca843b3-3cd1-4453-8782-1373729de303", "Andy.Harris32@gmail.com", "Lauren Goodwin", "AQAAAAIAAYagAAAAECw5etEjoK+tfq9M+h4vA46PpIKobMvjxRn03ivJQuMQqfp+5uW8hbcsXWEVhH+FaA==", null, null, "b6558b45-c455-4a0e-8aac-501eeab9b0e5", "Andy.Harris32@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "RefreshToken", "RefreshTokenLifetime", "SecurityStamp", "UserName" },
                values: new object[] { "5b2ad305-8d37-4936-8817-8da59a7b9cef", "Efrain.Bayer@hotmail.com", "Matilde Effertz", "AQAAAAIAAYagAAAAEE21udrDUq6V0Krng+iDD4skIIYRjxy6p/KDnCbGyZpD0xQSfmc2xpFCGqFf6inFQg==", null, null, "2eb14e80-327c-449d-94b3-2040648c41d7", "Efrain.Bayer@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "RefreshToken", "RefreshTokenLifetime", "SecurityStamp", "UserName" },
                values: new object[] { "fbdbf15c-b72b-4bc6-8a46-da276a201b25", "Mackenzie_Barton@hotmail.com", "Mark Ondricka", "AQAAAAIAAYagAAAAEAzmdYZMm0xSZtRgvrUBLX+ovz5ou8ENlSyCpWsdAcKEBUKEjSjAqVZ/Pmeha1uZTA==", null, null, "98cbd070-5bec-4dc9-955a-5d72a642f581", "Mackenzie_Barton@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "RefreshToken", "RefreshTokenLifetime", "SecurityStamp", "UserName" },
                values: new object[] { "e1c91d08-b09c-4c58-be93-7d274caae086", "Guido.Breitenberg@hotmail.com", "Pattie Rolfson", "AQAAAAIAAYagAAAAEAzspd9C8X9ibxKASKSgulXQATMkKsZXGYPJYowNtZ/Hw5ABWp+4QRbuLNpu7mqMoQ==", null, null, "1762c5c0-6fca-4c1a-a821-d3ebf7e83c9f", "Guido.Breitenberg@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "RefreshToken", "RefreshTokenLifetime", "SecurityStamp", "UserName" },
                values: new object[] { "e0947149-0bec-4236-a400-5bb09744a401", "Maci85@gmail.com", "Isadore Zulauf", "AQAAAAIAAYagAAAAEIj9g7JDOvr0w2hRijPcbsJ+FwtjeO4t2s15xmp/mO8rzNR4+TcMjeGqYuY0Apmwvg==", null, null, "1c69f048-1024-4d5a-8651-afe9b42c5ccd", "Maci85@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "RefreshToken", "RefreshTokenLifetime", "SecurityStamp", "UserName" },
                values: new object[] { "0a162a6c-c06d-4b23-ba66-ecc2be6c0d51", "Dallas.Maggio52@hotmail.com", "Kennith Glover", "AQAAAAIAAYagAAAAEGiwY107ACNKOk9fC4wUN9CDhmmwr8HzOiEz0ApXiF+4TJ04TQNGNIhU3WIV3tCDcA==", null, null, "30e832bc-77b1-4e16-9590-67cdde6c7ec0", "Dallas.Maggio52@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "RefreshToken", "RefreshTokenLifetime", "SecurityStamp", "UserName" },
                values: new object[] { "598cbcaa-cf32-4709-ba04-791d11e74969", "Fredy_McCullough@gmail.com", "Kathryne Hansen", "AQAAAAIAAYagAAAAELUSg7i6SWKBxvCE5KL8Q4nOaiyK4M8wC7boxJKYWTzr59v3G9WybDfXFlCzaCBqxA==", null, null, "4f3a268c-46bb-4625-b870-7f4a241af355", "Fredy_McCullough@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "RefreshToken", "RefreshTokenLifetime", "SecurityStamp", "UserName" },
                values: new object[] { "faeb40c0-e355-41e5-ab3a-22798cd4cd97", "Pascale.Murphy5@yahoo.com", "Shea Bosco", "AQAAAAIAAYagAAAAEBI9UbLLXzBfbS4vgTo38JMVoZMCg31zljgmfKHllqbleAyxHDXNwKL3w/GqiQYkTQ==", null, null, "44b624c2-8eb6-4534-81c3-cd9a2b354553", "Pascale.Murphy5@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "RefreshToken", "RefreshTokenLifetime", "SecurityStamp", "UserName" },
                values: new object[] { "58439a3e-c2a2-41ad-8f58-5379ef53b987", "Abdullah85@hotmail.com", "Joan Kunde", "AQAAAAIAAYagAAAAEAPfu3IGj1i8xnpSAAAe1+7mqML4Y1Iz5UwsKd1few2380bsGr6OJ6qYkbR0rUXevw==", null, null, "c1af4938-dda2-4b80-9e88-fe33ff7d3afc", "Abdullah85@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "RefreshToken", "RefreshTokenLifetime", "SecurityStamp", "UserName" },
                values: new object[] { "00a3215c-37b9-436a-9e79-bc2f72e2cca9", "Layla_Schmeler@gmail.com", "Gaetano Marvin", "AQAAAAIAAYagAAAAEMFtrdr+EMA274d3lp8pkEpHb+VlL0JayJ6o5dHByOYLtoXBVg+zLFX6oES8t2xS4Q==", null, null, "68b3a1ff-2de8-4b79-9ea3-7f659cdbf814", "Layla_Schmeler@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "RefreshToken", "RefreshTokenLifetime", "SecurityStamp", "UserName" },
                values: new object[] { "72769024-f94c-40f3-89ab-d4ce52799033", "Robbie_Dicki@yahoo.com", "Erich Fay", "AQAAAAIAAYagAAAAEDD7gLlZa38nJ6LuzDOGhY5w71h1lSryv3dG1p8hlhFsCGX4HEDXyBAJp7mYcx4SPg==", null, null, "f845eaf7-2cd6-4728-8fce-1be25a2d1047", "Robbie_Dicki@yahoo.com" });

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
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 24, "Salvador.Huel76@hotmail.com", "Ella Collier", "698.836.7874 x9413" });

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
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 4, "Loren.Hegmann4@hotmail.com", "Myra Kub", "650-511-5975" });

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
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Justen39@hotmail.com", "Mallie Waters", "322.462.1567 x7668" });

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
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 21, "Selina.Collins@gmail.com", "Litzy Bahringer", "401-256-4462 x9085" });

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
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Abby.Bosco@gmail.com", "Cleo Berge", "1-683-259-8389" });

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
                columns: new[] { "DealId", "PricePerUnit", "ProductId", "Quantity" },
                values: new object[] { 9, 35.0, 8, 31 });

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
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 392101.0, "Modi ea consequatur et consequatur tempora voluptatibus sed accusantium quo aut ratione ex modi aperiam sint sed reprehenderit perspiciatis et.", 1, "Qui perferendis est aut." });

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
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 359806.0, "Veritatis perferendis doloremque ut et dolorem accusantium odio quos at et omnis esse voluptatem iure sed consequatur blanditiis voluptatem laboriosam sed et explicabo et.", 1, "Quis mollitia deleniti voluptas delectus odit." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 36861.0, "Omnis quidem enim illum autem quis illum beatae quidem nihil dolores aut exercitationem porro quisquam animi ab ipsa expedita ratione ut.", "Mollitia deleniti veritatis voluptatibus." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 177330.0, "Vel dolor dolor laborum est saepe esse dolores itaque dolorum quis repudiandae error libero voluptatem ut dignissimos consequatur distinctio vel sed et reiciendis qui sapiente iusto.", 1, "Voluptatem vero explicabo voluptate ut eos." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 162354.0, "Perferendis sed totam iste eum vitae amet labore eaque qui vel voluptatem quos architecto facilis officia.", "Officiis ea consequatur exercitationem." });

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
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 345506.0, "Unde labore magnam praesentium et officiis id quia itaque error sunt est enim et vel mollitia vel eos quia eaque velit aut fugit aut quo qui vero rerum ut.", "Accusantium commodi quia natus vitae." });

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
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 255267.0, "Voluptates et cupiditate ut culpa iste aspernatur quis distinctio sunt voluptate laudantium nulla error doloremque rerum ab.", "A et eos et." });

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
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 178706.0, "Ipsam voluptatem doloribus et repellendus commodi nam ea est molestiae recusandae quam recusandae dolorum maxime natus beatae aliquid porro sint eos odio quasi.", 2, "Aut dolor vero earum et." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 330766.0, "Sit unde sit exercitationem provident dolorem omnis veritatis aut nemo ducimus fuga ea.", "Quaerat dignissimos qui." });

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
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 442567.0, "Eius earum eaque nulla cupiditate tempora officia aliquam mollitia sed aut veniam nihil quia ipsum enim.", "Adipisci eum nostrum." });

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
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 185442.0, "Voluptas beatae quod dolores at totam facilis libero vero reprehenderit qui delectus qui expedita quod esse sit voluptas est at magni iste repudiandae eaque ut sit et asperiores.", 1, "Modi blanditiis voluptates asperiores." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 471952.0, "Dolore cum autem rerum et laborum aut quis vitae reiciendis soluta.", "Atque ea ab ipsa sint." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 122418.0, "Possimus odit et dolorem magnam atque ut dicta accusamus sequi rerum hic quo soluta voluptates reiciendis quos architecto et corporis sed aut sint molestiae nulla rerum.", 2, "Mollitia vel maiores." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 16, "Voluptas fugiat aut expedita hic ex in voluptatem sunt illo aut.", new DateTime(2022, 12, 31, 4, 39, 7, 848, DateTimeKind.Local).AddTicks(7090), 208710.0, 1, "Ut eius voluptatem." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 8, "Itaque et expedita eos ducimus alias non excepturi quia ea cupiditate omnis ratione temporibus quis doloribus repellendus repudiandae et nobis in ab temporibus et.", new DateTime(2023, 1, 26, 16, 27, 10, 505, DateTimeKind.Local).AddTicks(9196), 336601.0, 3, "Et velit minima possimus." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 13, "Odit molestiae quaerat est excepturi qui beatae quos aperiam ut et qui dolor exercitationem quidem magni voluptas illo nihil voluptas.", new DateTime(2022, 8, 18, 19, 10, 12, 836, DateTimeKind.Local).AddTicks(7064), 394448.0, 2, "Est illo ut doloremque." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 9, "Ad earum pariatur magni aut commodi non minima est similique itaque sint.", 66188.0, 4, 1, "Odit est voluptatem aperiam illum ad." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 3, "Et sequi numquam vitae velit fugiat dolores quasi aut quibusdam facilis soluta.", "Id voluptas praesentium et non quasi iusto est et quo qui dolore non pariatur necessitatibus doloremque et inventore quia voluptatem quo atque voluptatem sed placeat.", 0, new DateTime(2023, 3, 16, 5, 44, 17, 814, DateTimeKind.Local).AddTicks(873), 389063.0, 4, 3, "Blanditiis non rerum aut veritatis laboriosam." });

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
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 2, "Placeat reiciendis sed quia nemo quae rem voluptas tempora dolor quo iste et et neque amet.", new DateTime(2023, 4, 2, 19, 51, 14, 4, DateTimeKind.Local).AddTicks(5638), 165462.0, 1, 2, "Commodi pariatur excepturi deserunt possimus voluptatem." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 18, "Quam voluptatum aut quidem quam quos id quae a sit voluptate aliquid expedita aut expedita at reiciendis iste ab voluptas.", 298045.0, 1, "Sit omnis quod voluptates nostrum." });

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
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 8, "Corporis voluptatum adipisci commodi nulla aspernatur iure saepe qui et error ut laudantium aut in esse exercitationem voluptas ea nobis et est aut incidunt similique qui.", 482342.0, 1, "Molestias nam id dolorem." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Title" },
                values: new object[] { 3, "Vitae aut aspernatur magni et recusandae omnis nihil aperiam quod cumque nisi est dignissimos enim quasi omnis et ipsum pariatur atque temporibus expedita eum eum rerum.", 236838.0, "Tempora atque facere consequatur." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 7, "Eaque sit voluptas repellat voluptatibus et culpa eos cum et.", "Voluptas iste hic quae doloribus architecto sed sit esse qui quibusdam.", 2, new DateTime(2023, 3, 7, 21, 49, 43, 935, DateTimeKind.Local).AddTicks(658), 274634.0, 2, 3, "Molestias hic ab molestias." });

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
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 14, "Culpa minus sunt cupiditate voluptates distinctio fugit repellat quo quis et soluta ratione reiciendis.", new DateTime(2023, 5, 9, 16, 51, 36, 468, DateTimeKind.Local).AddTicks(2451), 230972.0, 4, 2, "Non cumque labore sed quam et." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 1, "Quibusdam ipsum id dolorem ut molestias rem dolorum magni sed iure praesentium quas et hic accusamus soluta officia dolores consequatur autem harum mollitia odit nulla.", null, null, null, 190078.0, 1, "Quia quibusdam ut est voluptatum quae." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 14, "Vero assumenda adipisci unde eius pariatur deleniti labore est eum nemo accusamus.", new DateTime(2023, 6, 21, 20, 42, 8, 569, DateTimeKind.Local).AddTicks(8329), 177223.0, 4, "Ea similique molestiae." });

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
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 18, "Asperiores unde alias recusandae fugiat aliquam ducimus non earum ullam nobis aliquid maxime non sit et dolor ab autem.", null, 161330.0, 2, 0, "Cupiditate ipsa quis ipsa." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 12, "Voluptatem nemo nihil libero dicta ullam velit fugit fugit ut vitae sapiente qui reprehenderit et laborum placeat quibusdam repellat similique neque inventore sunt sit iste corporis assumenda aperiam aut et.", null, null, null, 192415.0, 3, 1, "Nam adipisci aspernatur laudantium vel." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Title" },
                values: new object[] { 5, "Sed doloribus sed et est consequatur magni temporibus dolorem fugiat perferendis fugit et.", new DateTime(2022, 11, 25, 7, 9, 56, 21, DateTimeKind.Local).AddTicks(4893), 382922.0, "Exercitationem accusantium sunt sed voluptatem sint." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 12, "Quis qui ut vel dolores repudiandae et doloribus molestiae vel.", new DateTime(2023, 3, 20, 18, 11, 21, 322, DateTimeKind.Local).AddTicks(8290), 257840.0, 1, "Quibusdam velit ut rerum." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 4, "Distinctio temporibus vitae voluptate quia accusantium eos deleniti voluptas amet ut laboriosam consequatur optio nostrum voluptatem sapiente esse esse veritatis ab optio eum iusto dolores voluptatum.", new DateTime(2022, 9, 30, 12, 30, 3, 970, DateTimeKind.Local).AddTicks(894), 215202.0, 4, 2, "Fugit magnam consequuntur." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 16, "Accusantium fugiat voluptatem officiis quia quos qui expedita est repudiandae et sit perferendis modi eveniet sint fugit repellendus ut.", 442923.0, 3, "Commodi impedit et." });

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
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 2, "Voluptatibus cupiditate soluta id at repellendus sed et non dolorem est illum minus.", 384082.0, 3, "Voluptatem at ratione officia." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 25, "Non nisi nemo id consequatur voluptas et reiciendis aut qui rem velit eum et voluptatem nihil saepe qui libero officia autem beatae doloribus labore laborum.", new DateTime(2022, 10, 12, 10, 7, 47, 193, DateTimeKind.Local).AddTicks(974), 331496.0, 1, 2, "Perspiciatis earum iste vero quos." });

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
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 22, "Sed qui doloribus laboriosam quod vel debitis porro officiis debitis non asperiores.", 193508.0, 1, "Hic soluta in sequi cupiditate." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 22, "Eveniet aut soluta qui quia neque quia sed et ratione sint quia molestiae molestias vel rerum facilis et soluta recusandae corporis est sit ut eum deleniti eum.", null, null, null, 380947.0, 0, "Odio natus sit assumenda." });

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
                columns: new[] { "Name", "Price", "ProductCode", "Type" },
                values: new object[] { "Intelligent Cotton Soap", 684.0, "PRO-56387612", 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price", "ProductCode", "Type" },
                values: new object[] { "Tasty Rubber Towels", 587.0, "PRO-71796031", 1 });

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
                columns: new[] { "Name", "Price", "ProductCode", "Type" },
                values: new object[] { "Handcrafted Metal Salad", 602.0, "PRO-46238078", 1 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenLifetime",
                table: "AspNetUsers");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a13c6887-4bca-4481-a734-1b25ed3459d9", "AQAAAAIAAYagAAAAEHUgib1Jclqc1+BjtKjQjja5vO+pF+8EeZGXLPzaMZrFcj1w1gpX+QURYnCNgubfDA==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ff9a3db1-30e2-4bcb-a8bf-540cfe3c11b6", "Abraham_Johnston@gmail.com", "Bartholome Feeney", null, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "914e7576-e550-41f1-9836-f781d16a96ad", "Diamond63@yahoo.com", "Adella Barton", null, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "174daef1-54fd-44d2-801d-b63f98c21030", "Adalberto_Cummings28@gmail.com", "Frieda Zulauf", null, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "67ae35b7-49c7-4336-aee6-20318dc91fbf", "Louie34@hotmail.com", "Lea Wyman", null, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "195c4584-9671-4127-8165-cdfb2082aaca", "Alisha_Gibson91@gmail.com", "Kurt Jerde", null, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a719ac8c-91f4-4765-ad64-73f5a8ba7ea3", "Jevon.Jacobs@yahoo.com", "Anastacio Parisian", null, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "db0f2bb2-184e-49c3-949d-fa6bd2fc183b", "Markus_Langworth74@yahoo.com", "Manuel O'Connell", null, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "087784bf-9262-4293-a27e-75050b1666ea", "Madonna_Wintheiser86@gmail.com", "Esperanza Walter", null, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ff22e903-f5e4-4458-b927-43a65ad9831c", "Natalia45@yahoo.com", "Kirstin Bednar", null, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "72378b18-f7c8-4103-9ea1-b1561eb17cad", "Kira.OHara@hotmail.com", "Jettie Brakus", null, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "187a38c6-6565-4163-a7aa-1fde9771d478", "Anastasia.Miller@gmail.com", "Caleigh Gerhold", null, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5d3c46ee-1eef-4798-8466-9d9cad3b813b", "Ashlee.OHara21@hotmail.com", "Vida Frami", null, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3614b72d-115d-4449-9e07-e79c36e40b6b", "Gillian38@hotmail.com", "Duncan Harris", null, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f4a2e2c4-215a-411c-bb1e-3d28993ad5a9", "Marcelino.Graham16@yahoo.com", "Zula Goyette", null, null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "816385e3-9443-4254-b846-17fdca67ea85", "Kenyatta_Champlin@hotmail.com", "Ciara Emard", null, null, null });

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
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 10, "Braden.Christiansen84@gmail.com", "Vicenta Casper", "849.764.7859 x11159" });

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
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 14, "Aurore.Mann@gmail.com", "Madeline Kshlerin", "673-562-6478" });

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
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 22, "Noble4@hotmail.com", "Jillian Koelpin", "1-618-337-6686" });

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
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 9, "Joseph.Johnson51@hotmail.com", "Bernice Prosacco", "1-392-559-8339 x086" });

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
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Pierce.Koepp@hotmail.com", "Dannie Lang", "1-497-903-0454 x35468" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 2, "Zack.Lehner6@yahoo.com", "Cassidy Jaskolski", "861.437.6344" });

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
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 5, "Tyreek.Reynolds@gmail.com", "Levi Deckow", "659-763-8710 x638" });

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
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 12, "Luciano53@yahoo.com", "Phoebe Turner", "1-225-483-6607 x9366" });

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
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Devyn_Beatty@gmail.com", "Bette Kautzer", "1-640-826-1274 x2216" });

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
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 11, "Dayton81@yahoo.com", "Reyna Gerlach", "1-812-215-1141" });

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
                columns: new[] { "AccountId", "Email", "Name", "Phone" },
                values: new object[] { 3, "Willa.Auer13@yahoo.com", "Samara Schoen", "562.389.8242 x452" });

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
                columns: new[] { "DealId", "PricePerUnit", "ProductId", "Quantity" },
                values: new object[] { 2, 13.0, 6, 34 });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DealId", "PricePerUnit", "ProductId", "Quantity" },
                values: new object[] { 16, 95.0, 1, 71 });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DealId", "PricePerUnit", "ProductId", "Quantity" },
                values: new object[] { 28, 62.0, 3, 66 });

            migrationBuilder.UpdateData(
                table: "DealProducts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DealId", "PricePerUnit", "ProductId", "Quantity" },
                values: new object[] { 27, 39.0, 8, 71 });

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
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 199347.0, "Rerum odit illum ducimus accusantium sunt quibusdam reiciendis fuga labore earum voluptatem iure omnis consequuntur natus debitis dolorem sunt saepe repudiandae iste est voluptatum tenetur occaecati.", 0, "Vel corporis hic explicabo rerum." });

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
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 248383.0, "Nobis suscipit laudantium ut repellendus et et a iusto in consectetur quis voluptatibus.", 2, "Nostrum sint illo neque autem." });

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
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 212370.0, "Non adipisci esse quia laboriosam porro molestias sit dolore molestiae reprehenderit sequi debitis reprehenderit libero sit illum impedit sed numquam repudiandae consequuntur molestiae.", 0, "Fugit vel facere sunt id officiis." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 399498.0, "Harum odio sapiente officiis aspernatur accusamus voluptatem fugit reprehenderit in.", "Eligendi eveniet qui voluptas eum asperiores." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 290003.0, "Occaecati necessitatibus consectetur voluptates qui adipisci ut odio aspernatur ut.", "Molestias aut minima." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 438904.0, "Dicta cupiditate alias sit maxime quia ut et temporibus eum sapiente blanditiis autem dolorem culpa tempora voluptas qui temporibus minima consequuntur.", 2, "Voluptatibus quisquam aperiam accusamus voluptatibus." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 465765.0, "Cumque et cupiditate necessitatibus facilis quo dolorum nam accusamus harum.", 1, "Aspernatur est a qui ea." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 268732.0, "Praesentium quia soluta consequatur magni consequatur optio sapiente maxime inventore culpa qui at in ea et error et a ullam praesentium omnis repudiandae.", "Sint et natus." });

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
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 253199.0, "Nostrum sed aut minima repellat placeat iure facere necessitatibus quis illo rerum.", 1, "Laboriosam quae at tempore quasi tenetur." });

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
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 214468.0, "Rerum eos beatae reprehenderit praesentium accusamus voluptas quo aut voluptatem in dicta eos optio voluptatem et facere quo.", 2, "Aut sit rerum nemo." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 340451.0, "Sed est aut deleniti tenetur sed laboriosam laboriosam rerum qui animi similique architecto qui voluptas perferendis sit officia consequuntur maxime sapiente similique exercitationem ad aliquam.", "Ut excepturi earum accusamus." });

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
                columns: new[] { "ActualRevenue", "Description", "Status", "Title" },
                values: new object[] { 78886.0, "Amet facilis quo distinctio et molestiae velit corrupti explicabo id fugit ipsam repudiandae id est quia eligendi harum quo commodi.", 0, "Eligendi laborum quasi aliquam voluptatum voluptas." });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ActualRevenue", "Description", "Title" },
                values: new object[] { 46423.0, "Id iste in quas quibusdam quia et illo et minima sunt architecto est consequatur est consequatur deleniti fugit cupiditate placeat.", "Vel officia molestiae debitis consequatur." });

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
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 3, "Possimus et et nemo incidunt qui accusantium vero expedita qui molestiae tempora sed similique atque id iusto eligendi molestias eveniet et qui nostrum qui quibusdam omnis non libero repellendus.", null, 231223.0, 1, "Et ratione asperiores qui dolore quia." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 18, "Et iste qui quas impedit dolor enim tempora dicta nostrum facere dolorem accusantium molestiae est doloremque doloremque pariatur.", 320462.0, 3, 0, "Sed quos ab quos qui culpa." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 8, "Ut rerum in voluptates consequuntur ipsa blanditiis qui sit quia quia.", null, null, null, 73479.0, 1, 1, "Eos iure sint eaque corporis." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 19, "Numquam in sed dolor distinctio autem non ut aliquid aut tempora ut necessitatibus incidunt assumenda dolores praesentium voluptatum omnis temporibus dolore iusto rerum nostrum.", null, null, null, 32519.0, 0, 0, "Odit quia et." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 9, "Nam in veniam praesentium velit excepturi explicabo est voluptatum a vitae nihil natus voluptatem aut.", null, 206044.0, 4, 1, "Dolore et nobis culpa." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 10, "Ut voluptas aliquid ut dignissimos enim at eligendi magni vel ducimus ut numquam est animi in nostrum voluptatum mollitia autem minima aliquid dolor voluptatem molestiae vel.", 67536.0, 0, "Modi tempore quidem consectetur est eum." });

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
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 7, "Id perferendis eligendi rerum commodi vel doloribus sed voluptatibus doloremque voluptatum quibusdam iusto iusto quia quae nihil dolore et ratione molestiae recusandae voluptatem modi qui officia dolores incidunt ratione.", 15696.0, 4, "Non ea expedita et omnis." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Title" },
                values: new object[] { 16, "Est exercitationem voluptas amet perferendis tenetur ea sed ea corrupti nobis quis debitis et necessitatibus doloremque quasi.", 125318.0, "Enim ipsam hic hic." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 6, "Eaque vel corrupti quas ut quisquam voluptas et eos distinctio cum sequi sed dolor laboriosam aut sit quasi ut iste asperiores possimus reiciendis voluptas dolor ut.", null, null, new DateTime(2023, 5, 14, 16, 29, 19, 47, DateTimeKind.Local).AddTicks(1473), 314712.0, 3, 2, "Illum reiciendis et ut repellendus placeat." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 16, "Ipsum eligendi ratione eum saepe dolores accusantium accusantium blanditiis omnis.", null, null, null, 25777.0, 4, 1, "Soluta similique dignissimos vero perferendis et." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 3, "Numquam magnam porro et velit quisquam magni vel quo veniam id eligendi et itaque nihil sed et inventore optio a et ut porro facilis dolorem.", null, 471446.0, 2, 0, "Est veniam reprehenderit consequatur." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 10, "Architecto ut placeat quia excepturi sint corrupti modi magnam explicabo aspernatur accusamus ex eum dolor quia.", "Et adipisci enim voluptatem et sint eveniet unde odit autem et mollitia fuga vero soluta excepturi architecto impedit aliquid corrupti amet rem sapiente corrupti qui eos et sit officiis.", 3, new DateTime(2022, 12, 20, 12, 13, 46, 773, DateTimeKind.Local).AddTicks(3425), 181494.0, 3, "Aliquam enim aut et dolorem." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 22, "Similique repudiandae amet dolore saepe corporis aliquam vitae ipsa quas necessitatibus sunt porro est atque eum quo nam qui enim mollitia dolorem neque facere corrupti autem et sunt ad.", new DateTime(2023, 7, 15, 19, 25, 37, 526, DateTimeKind.Local).AddTicks(3013), 306473.0, 1, "Reprehenderit minima libero ea." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 1, "Nam nihil dolores vero aut omnis vel distinctio incidunt numquam perspiciatis delectus dolor voluptatem voluptas eos repudiandae commodi optio sit ut neque quod nostrum est eius veniam voluptatibus aspernatur nulla.", null, 101254.0, 1, 1, "Vel voluptas deserunt quia et quo." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 10, "Nemo nihil eveniet consequatur doloremque qui nihil alias et doloremque praesentium nesciunt.", null, null, null, 124409.0, 0, 0, "Sed consequuntur assumenda magni ducimus." });

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
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Title" },
                values: new object[] { 13, "Ratione doloremque voluptatum quos ipsa cupiditate vel quia quia voluptas eum ipsam.", new DateTime(2022, 12, 13, 11, 21, 2, 506, DateTimeKind.Local).AddTicks(4448), 84639.0, "Dolore dolorem ad." });

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
                columns: new[] { "AccountId", "Description", "EndedDate", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 23, "Tenetur optio libero fugit eos illo laboriosam expedita deleniti et.", null, 35074.0, 2, 0, "Laboriosam accusamus sed." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 15, "Non et consequatur deserunt iste ex omnis aut rem qui.", 162145.0, 0, "Doloremque quia rem rem voluptas." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 19, "Voluptatem nostrum quia blanditiis qui voluptate rerum praesentium numquam consequatur ut maxime beatae laboriosam et et facere minus id qui pariatur quis libero facilis voluptatem id rerum explicabo voluptatem.", null, null, new DateTime(2022, 10, 14, 9, 21, 3, 420, DateTimeKind.Local).AddTicks(9332), 269366.0, 2, "Harum fuga qui." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Title" },
                values: new object[] { 5, "Libero aliquam iste nihil iste quos aliquam autem minus est sint rerum autem sed commodi rerum velit a ducimus cum.", 71592.0, 0, "Sit earum aut et natus." });

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
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Source", "Status", "Title" },
                values: new object[] { 7, "Officiis quae aut illo beatae qui omnis maxime aut quia sequi at asperiores quos hic et dolores tempora sed sint eaque et porro aut est consequatur doloribus.", 438545.0, 2, 1, "Voluptatum harum numquam iure vel." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AccountId", "Description", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 17, "Omnis consequatur recusandae sed aut temporibus est maiores perspiciatis totam mollitia rerum facere explicabo id esse qui.", 296358.0, 0, "Mollitia sed nostrum." });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AccountId", "Description", "DisqualifiedDescription", "DisqualifiedReason", "EndedDate", "EstimatedRevenue", "Status", "Title" },
                values: new object[] { 11, "Suscipit nesciunt laboriosam veritatis a enim et cupiditate nulla quaerat harum culpa omnis ut cupiditate ut id rerum aliquam illo ipsa repellendus dicta inventore consequatur nihil assumenda beatae voluptate.", "Est qui tempore aut ipsam mollitia quos voluptatem amet ea ea laboriosam sit corporis ut animi iusto et quia pariatur eaque veniam cupiditate quasi.", 4, new DateTime(2023, 7, 7, 23, 41, 49, 623, DateTimeKind.Local).AddTicks(9836), 237526.0, 3, "Totam culpa distinctio." });

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
                columns: new[] { "Name", "Price", "ProductCode", "Type" },
                values: new object[] { "Incredible Soft Chicken", 888.0, "PRO-19083308", 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price", "ProductCode", "Type" },
                values: new object[] { "Ergonomic Frozen Chips", 246.0, "PRO-76850509", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price", "ProductCode", "Type" },
                values: new object[] { "Rustic Concrete Chicken", 859.0, "PRO-75825942", 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Price", "ProductCode", "Type" },
                values: new object[] { "Generic Cotton Hat", 774.0, "PRO-82284893", 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Fantastic Rubber Shoes", 35.0, "PRO-89535059" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Price", "ProductCode" },
                values: new object[] { "Licensed Metal Tuna", 978.0, "PRO-84344106" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Price", "ProductCode", "Type" },
                values: new object[] { "Intelligent Steel Bacon", 565.0, "PRO-19442563", 0 });

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
        }
    }
}
