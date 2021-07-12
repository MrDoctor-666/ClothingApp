using Microsoft.EntityFrameworkCore.Migrations;

namespace ClothingApp.Data.Common.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                newName: "AspNetRoleClaims");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserRoles",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "AspNetUserRoles",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserClaims",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "AspNetRoles",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetRoles",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "AspNetRoleClaims",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ClothingItems",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "UrlImageAccessory", "UrlImageFootwear", "UrlImageOuterwear", "UrlImageUnderwear" },
                values: new object[] { "/Images/Man/Man.15-20/umbrella.png", "/Images/Man/Man.15-20/footwear_3.png", "/Images/Man/Man.15-20/hoodie.png", "/Images/Man/Man.15-20/jeans.png" });

            migrationBuilder.UpdateData(
                table: "ClothingItems",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "UrlImageAccessory", "UrlImageFootwear", "UrlImageHat", "UrlImageOuterwear", "UrlImageUnderwear" },
                values: new object[] { "/Images/Man/Man.20-25/umbrella.png", "/Images/Man/Man.20-25/footwear_3.png", "/Images/Man/Man.20-25/hat_3.png", "/Images/Man/Man.20-25/mens.png", "/Images/Man/Man.20-25/jeans.png" });

            migrationBuilder.UpdateData(
                table: "ClothingItems",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "UrlImageAccessory", "UrlImageFootwear", "UrlImageHat", "UrlImageOuterwear", "UrlImageUnderwear" },
                values: new object[] { "/Images/Man/Man.25-30/accessory_3.png", "/Images/Man/Man.25-30/footwear_1.png", "/Images/Man/Man.20-25/hat_3.png", "/Images/Man/Man.25-30/shirt.png", "/Images/Man/Man.25-30/short.png" });

            migrationBuilder.UpdateData(
                table: "ClothingItems",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "UrlImageAccessory", "UrlImageFootwear", "UrlImageHat", "UrlImageOuterwear", "UrlImageUnderwear" },
                values: new object[] { "/Images/Man/Man.30-35/umbrella.png", "/Images/Man/Man.30-35/footwear_5.png", "/Images/Man/Man.30-35/hat_2", "/Images/Man/Man.30-35/tshirt.png", "/Images/Man/Man.30-35/shorts_2.png" });

            migrationBuilder.UpdateData(
                table: "ClothingItems",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "UrlImageAccessory", "UrlImageFootwear", "UrlImageOuterwear", "UrlImageUnderwear" },
                values: new object[] { "/Images/Woman/Woman.15-20/umbrella.png", "/Images/Woman/Woman.15-20/footwear_1.png", "/Images/Woman/Woman.15-20/jacket.png", "/Images/Woman/Woman.15-20/pants.png" });

            migrationBuilder.UpdateData(
                table: "ClothingItems",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "UrlImageAccessory", "UrlImageFootwear", "UrlImageHat", "UrlImageOuterwear", "UrlImageUnderwear" },
                values: new object[] { "/Images/Woman/Woman.20-25/umbrella.png", "/Images/Woman/Woman.20-25/footwear_1.png", "/Images/Woman/Woman.20-25/hat_1.png", "/Images/Woman/Woman.20-25/t-shirt.png", "/Images/Woman/Woman.20-25/pants.png" });

            migrationBuilder.UpdateData(
                table: "ClothingItems",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "UrlImageAccessory", "UrlImageFootwear", "UrlImageHat", "UrlImageOuterwear", "UrlImageUnderwear" },
                values: new object[] { "/Images/Woman/Woman.25-30/umbrellf.png", "/Images/Woman/Woman.25-30/footwear_4.png", "/Images/Woman/Woman.25-30/hat_1.png", "/Images/Woman/Woman.25-30/t-shirt.png", "/Images/Woman/Woman.25-30/skirt.png" });

            migrationBuilder.UpdateData(
                table: "ClothingItems",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "UrlImageAccessory", "UrlImageFootwear", "UrlImageHat", "UrlImageOuterwear" },
                values: new object[] { "/Images/Woman/Woman.30-35/umbrella.png", "/Images/Woman/Woman.30-35/footwear_4.png", "/Images/Woman/Woman.30-35/hat_1.png", "/Images/Woman/Woman.30-35/frock.png" });

            migrationBuilder.InsertData(
                table: "MatchingStyleToWeathers",
                columns: new[] { "Id", "Deleted", "StyleId", "Updated", "WeatherSettingId" },
                values: new object[,]
                {
                    { 39L, null, 2L, null, 19L },
                    { 38L, null, 2L, null, 18L },
                    { 37L, null, 2L, null, 17L },
                    { 26L, null, 2L, null, 6L },
                    { 35L, null, 2L, null, 15L },
                    { 34L, null, 2L, null, 14L },
                    { 33L, null, 2L, null, 13L },
                    { 32L, null, 2L, null, 12L },
                    { 31L, null, 2L, null, 11L },
                    { 30L, null, 2L, null, 10L },
                    { 29L, null, 2L, null, 9L },
                    { 28L, null, 2L, null, 8L },
                    { 27L, null, 2L, null, 7L },
                    { 40L, null, 2L, null, 20L },
                    { 36L, null, 2L, null, 16L },
                    { 25L, null, 2L, null, 5L },
                    { 23L, null, 2L, null, 3L },
                    { 2L, null, 1L, null, 2L },
                    { 3L, null, 1L, null, 3L },
                    { 4L, null, 1L, null, 4L },
                    { 5L, null, 1L, null, 5L },
                    { 6L, null, 1L, null, 6L },
                    { 7L, null, 1L, null, 7L },
                    { 8L, null, 1L, null, 8L },
                    { 9L, null, 1L, null, 9L },
                    { 10L, null, 1L, null, 10L },
                    { 24L, null, 2L, null, 4L },
                    { 11L, null, 1L, null, 11L },
                    { 13L, null, 1L, null, 13L },
                    { 14L, null, 1L, null, 14L },
                    { 15L, null, 1L, null, 15L },
                    { 16L, null, 1L, null, 16L },
                    { 17L, null, 1L, null, 17L },
                    { 18L, null, 1L, null, 18L },
                    { 19L, null, 1L, null, 19L },
                    { 20L, null, 1L, null, 20L },
                    { 21L, null, 2L, null, 1L },
                    { 22L, null, 2L, null, 2L },
                    { 12L, null, 1L, null, 12L },
                    { 1L, null, 1L, null, 1L }
                });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Name",
                value: "Мужской образ");

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Name",
                value: "Женский образ");

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
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "MatchingStyleToWeathers",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "UserTokens");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "UserLogins");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "UserClaims");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "RoleClaims");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserTokens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserTokens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserTokens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "UserRoles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserRoles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserLogins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "UserLogins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserLogins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserClaims",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "RoleClaims",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ClothingItems",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "UrlImageAccessory", "UrlImageFootwear", "UrlImageOuterwear", "UrlImageUnderwear" },
                values: new object[] { "./Resources/Images/Man/Man.15-20/umbrella.png", "./Resources/Images/Man/Man.15-20/footwear_3.png", "./Resources/Images/Man/Man.15-20/hoodie.png", "./Resources/Images/Man/Man.15-20/jeans.png" });

            migrationBuilder.UpdateData(
                table: "ClothingItems",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "UrlImageAccessory", "UrlImageFootwear", "UrlImageHat", "UrlImageOuterwear", "UrlImageUnderwear" },
                values: new object[] { "./Resources/Images/Man/Man.20-25/umbrella.png", "./Resources/Images/Man/Man.20-25/footwear_3.png", "./Resources/Images/Man/Man.20-25/hat_3.png", "./Resources/Images/Man/Man.20-25/mens.png", "./Resources/Images/Man/Man.20-25/jeans.png" });

            migrationBuilder.UpdateData(
                table: "ClothingItems",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "UrlImageAccessory", "UrlImageFootwear", "UrlImageHat", "UrlImageOuterwear", "UrlImageUnderwear" },
                values: new object[] { "./Resources/Images/Man/Man.25-30/accessory_3.png", "./Resources/Images/Man/Man.25-30/footwear_1.png", null, "./Resources/Images/Man/Man.25-30/shirt.png", "./Resources/Images/Man/Man.25-30/short.png" });

            migrationBuilder.UpdateData(
                table: "ClothingItems",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "UrlImageAccessory", "UrlImageFootwear", "UrlImageHat", "UrlImageOuterwear", "UrlImageUnderwear" },
                values: new object[] { "./Resources/Images/Man/Man.30-35/umbrella.png", "./Resources/Images/Man/Man.30-35/footwear_5.png", "./Resources/Images/Man/Man.30-35/hat_2", "./Resources/Images/Man/Man.30-35/tshirt.png", "./Resources/Images/Man/Man.30-35/shorts_2.png" });

            migrationBuilder.UpdateData(
                table: "ClothingItems",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "UrlImageAccessory", "UrlImageFootwear", "UrlImageOuterwear", "UrlImageUnderwear" },
                values: new object[] { "./Resources/Images/Woman/Woman.15-20/umbrella.png", "./Resources/Images/Woman/Woman.15-20/footwear_1.png", "./Resources/Images/Woman/Woman.15-20/jacket.png", "./Resources/Images/Woman/Woman.15-20/pants.png" });

            migrationBuilder.UpdateData(
                table: "ClothingItems",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "UrlImageAccessory", "UrlImageFootwear", "UrlImageHat", "UrlImageOuterwear", "UrlImageUnderwear" },
                values: new object[] { "./Resources/Images/Woman/Woman.20-25/umbrella.png", "./Resources/Images/Woman/Woman.20-25/footwear_1.png", "./Resources/Images/Woman/Woman.20-25/hat_1.png", "./Resources/Images/Woman/Woman.20-25/t-shirt.png", "./Resources/Images/Woman/Woman.20-25/pants.png" });

            migrationBuilder.UpdateData(
                table: "ClothingItems",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "UrlImageAccessory", "UrlImageFootwear", "UrlImageHat", "UrlImageOuterwear", "UrlImageUnderwear" },
                values: new object[] { "./Resources/Images/Woman/Woman.25-30/umbrellf.png", "./Resources/Images/Woman/Woman.25-30/footwear_4.png", "./Resources/Images/Woman/Woman.25-30/hat_1.png", "./Resources/Images/Woman/Woman.25-30/t-shirt.png", "./Resources/Images/Woman/Woman.25-30/skirt.png" });

            migrationBuilder.UpdateData(
                table: "ClothingItems",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "UrlImageAccessory", "UrlImageFootwear", "UrlImageHat", "UrlImageOuterwear" },
                values: new object[] { "./Resources/Images/Woman/Woman.30-35/umbrella.png", "./Resources/Images/Woman/Woman.30-35/footwear_4.png", "./Resources/Images/Woman/Woman.30-35/hat_1.png", "./Resources/Images/Woman/Woman.30-35/frock.png" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Name",
                value: "Женский образ");

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Name",
                value: "Мужской образ");
        }
    }
}
