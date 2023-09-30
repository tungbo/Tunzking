using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tunzking.DataAccess.Migrations
{
    public partial class loadDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descreption = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
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
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CurrentPrice = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, "A T-shirt, or tee for short, is a style of fabric shirt named after the T shape of its body and sleeves. Traditionally, it has short sleeves and a round neckline, known as a crew neck, which lacks a collar. T-shirts are generally made of a stretchy, light, and inexpensive fabric and are easy to clean. The T-shirt evolved from undergarments used in the 19th century and, in the mid-20th century, transitioned from undergarment to general-use casual clothing.", 1, "Shirt" },
                    { 2, "A shoe is an item of footwear intended to protect and comfort the human foot. Though the human foot can adapt to varied terrains and climate conditions, it is vulnerable, and shoes provide protection. Form was originally tied to function but over time shoes also became fashion items. Some shoes are worn as safety equipment, such as steel-toe boots, which are required footwear at industrial worksites.", 2, "Shoes" },
                    { 3, "In modern times, skirts are very commonly worn by women and girls. Some exceptions include the izaar, worn by many Muslim cultures, and the kilt, a traditional men's garment in Scotland, Ireland, and sometimes England. Fashion designers such as Jean Paul Gaultier, Vivienne Westwood, Kenzo and Marc Jacobs have also shown men's skirts. Transgressing social codes, Gaultier frequently introduces the skirt into his men's wear collections as a means of injecting novelty into male attire, most famously the sarong seen on David Beckham.", 3, "Skirt" },
                    { 4, "Shorts are a garment worn over the pelvic area, circling the waist and splitting to cover the upper part of the legs, sometimes extending down to the knees but not covering the entire length of the leg. They are called \"shorts\" because they are a shortened version of trousers, which cover the entire leg, but not the foot. Shorts are typically worn in warm weather or in an environment where comfort and airflow are more important than the protection of the legs.", 4, "Short" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "CurrentPrice", "Description", "Gender", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Jordan", 2, 200.0, "When it comes to hoops, Jordan Brand has earned its global reputation as innovator and collaborator. This AJ XXXVIII honors the International Basketball Federation—the governing body for basketball worldwide. Like white light containing every possible color, the striking outer conceals an insole decorated with all the hues of the vibrant FIBA logo. Boldness, from the inside out.", "Men", "", 400.0, "Air Jordan XXXVIII \"FIBA\"" },
                    { 2, "Gucci", 1, 250.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce interdum mi dui, ac blandit neque tempor eu. Integer nec odio eu lectus porta feugiat. Etiam id feugiat nunc. In eget dictum nulla, vel ultrices sem. Etiam pulvinar nunc sit amet tortor fermentum rhoncus. Nulla facilisi. Integer convallis diam elit, at sodales massa convallis sed. Suspendisse ultricies diam in rhoncus porta. Praesent et ipsum lectus. Phasellus eu mattis ipsum. Vestibulum imperdiet vitae orci nec fringilla. Praesent tempor elit eu nisi egestas viverra. Suspendisse ut metus quis lacus suscipit semper.", "Men", "", 500.0, "Check Collar Cotton Polo Shirt" },
                    { 3, "Gucci", 2, 700.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce interdum mi dui, ac blandit neque tempor eu. Integer nec odio eu lectus porta feugiat. Etiam id feugiat nunc. In eget dictum nulla, vel ultrices sem. Etiam pulvinar nunc sit amet tortor fermentum rhoncus. Nulla facilisi. Integer convallis diam elit, at sodales massa convallis sed. Suspendisse ultricies diam in rhoncus porta. Praesent et ipsum lectus. Phasellus eu mattis ipsum. Vestibulum imperdiet vitae orci nec fringilla. Praesent tempor elit eu nisi egestas viverra. Suspendisse ut metus quis lacus suscipit semper.", "Women", "", 900.0, "WOMEN'S GUCCI JORDAAN LOAFER" },
                    { 4, "Zara", 3, 250.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce interdum mi dui, ac blandit neque tempor eu. Integer nec odio eu lectus porta feugiat. Etiam id feugiat nunc. In eget dictum nulla, vel ultrices sem. Etiam pulvinar nunc sit amet tortor fermentum rhoncus. Nulla facilisi. Integer convallis diam elit, at sodales massa convallis sed. Suspendisse ultricies diam in rhoncus porta. Praesent et ipsum lectus. Phasellus eu mattis ipsum. Vestibulum imperdiet vitae orci nec fringilla. Praesent tempor elit eu nisi egestas viverra. Suspendisse ut metus quis lacus suscipit semper.", "Women", "", 800.0, "Slit denim skirt" },
                    { 5, "Nike", 4, 90.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce interdum mi dui, ac blandit neque tempor eu. Integer nec odio eu lectus porta feugiat. Etiam id feugiat nunc. In eget dictum nulla, vel ultrices sem. Etiam pulvinar nunc sit amet tortor fermentum rhoncus. Nulla facilisi. Integer convallis diam elit, at sodales massa convallis sed. Suspendisse ultricies diam in rhoncus porta. Praesent et ipsum lectus. Phasellus eu mattis ipsum. Vestibulum imperdiet vitae orci nec fringilla. Praesent tempor elit eu nisi egestas viverra. Suspendisse ut metus quis lacus suscipit semper.", "Men", "", 100.0, "YOGA TRAINING SHORTS" },
                    { 6, "Dolce", 2, 200.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce interdum mi dui, ac blandit neque tempor eu. Integer nec odio eu lectus porta feugiat. Etiam id feugiat nunc. In eget dictum nulla, vel ultrices sem. Etiam pulvinar nunc sit amet tortor fermentum rhoncus. Nulla facilisi. Integer convallis diam elit, at sodales massa convallis sed. Suspendisse ultricies diam in rhoncus porta. Praesent et ipsum lectus. Phasellus eu mattis ipsum. Vestibulum imperdiet vitae orci nec fringilla. Praesent tempor elit eu nisi egestas viverra. Suspendisse ut metus quis lacus suscipit semper.", "Women", "", 820.0, "Mixed-materials Daymaster sneakers" }
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

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

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
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
