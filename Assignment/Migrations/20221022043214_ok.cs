using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Migrations
{
    public partial class ok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    DoB = table.Column<DateTime>(nullable: false),
                    Img = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Img = table.Column<string>(nullable: false),
                    Edition = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false),
                    AuthorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_books_authors_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_books_categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmail = table.Column<string>(nullable: true),
                    OrderPrice = table.Column<double>(nullable: false),
                    OrderQuantity = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    BookID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orders_books_BookID",
                        column: x => x.BookID,
                        principalTable: "books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "A", "f073be6d-1ed2-448b-87f7-251be4900e75", "Admin", "Admin" },
                    { "B", "d871d9e9-4ea8-4d81-8ffe-ec8aff8d1636", "Customer", "Customer" },
                    { "C", "e1e944a9-2ab3-46d6-b618-cde52d647a10", "StoreOwner", "StoreOwner" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "ca05d072-d20b-4ed8-85e2-cea6f3950a32", "admin@fpt.edu.vn", true, false, null, null, "admin@fpt.edu.vn", "AQAAAAEAACcQAAAAEM3ukB646TUuodpkEXY+/tD8RPrXIrAov5sv6EBzSOjK/lwvhWZMJdLqE7tIqCDeEQ==", null, false, "25bbdb04-8301-4221-97aa-25d95cfcc130", false, "admin@fpt.edu.vn" },
                    { "2", 0, "69e89678-f7d6-44e2-b1a6-97dde27bad32", "customer@fpt.edu.vn", true, false, null, null, "customer@fpt.edu.vn", "AQAAAAEAACcQAAAAEP9edc/mrlBZRJcY14MYE6V6Vs5ZCk2x9E9EtJngmFazTSgQR3+yBj4/DzzRA+emrQ==", null, false, "5acc7f9f-7d60-469a-8ab7-545333cbb7ee", false, "customer@fpt.edu.vn" },
                    { "3", 0, "b2065641-2660-4196-aab0-36a2ae404365", "storeowner@fpt.edu.vn", true, false, null, null, "storeowner@fpt.edu.vn", "AQAAAAEAACcQAAAAEDIOMLDIZZqvEqWJ51lv0f2poS0wmX5VeEsg7WBBObz4MPPuHsyceul5zCDwUDDU4Q==", null, false, "ca52060a-3d6d-4225-9c64-6415e1853f07", false, "storeowner@fpt.edu.vn" },
                    { "4", 0, "a05c5bb4-8a7f-4ccc-a5a0-631585db026f", "customer1@fpt.edu.vn", true, false, null, null, "customer1@fpt.edu.vn", "AQAAAAEAACcQAAAAEI6kP+JWgBERYYf/KanZRvTkybQO83jaxfuM4X55f7EiBU1RcjcQqZoMnx4touzsrg==", null, false, "f4ad115a-d6f1-4fb7-89d2-ed553b1737fb", false, "customer1@fpt.edu.vn" }
                });

            migrationBuilder.InsertData(
                table: "authors",
                columns: new[] { "Id", "Description", "DoB", "Img", "Name" },
                values: new object[,]
                {
                    { 1, "ác phẩm của Kafka đều mang một đặc trưng: nói về một phần u tối trong dãy “cảm xúc” của con người. Chúng đều được bao trùm trong bầu không khí, ấn tượng, cảm giác rất riêng biệt, xuất hiện với tần suất lớn như một nỗi ám ảnh khôn nguôi.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSS_RyhnMq01yw12TECaSLPWq83HKvFvakE6A&usqp=CAU", "Franz Kafka" },
                    { 4, "ác phẩm của Kafka đều mang một đặc trưng: nói về một phần u tối trong dãy “cảm xúc” của con người. Chúng đều được bao trùm trong bầu không khí, ấn tượng, cảm giác rất riêng biệt, xuất hiện với tần suất lớn như một nỗi ám ảnh khôn nguôi.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSS_RyhnMq01yw12TECaSLPWq83HKvFvakE6A&usqp=CAU", "Gabriel Garcia Marquez" },
                    { 3, "ác phẩm của Kafka đều mang một đặc trưng: nói về một phần u tối trong dãy “cảm xúc” của con người. Chúng đều được bao trùm trong bầu không khí, ấn tượng, cảm giác rất riêng biệt, xuất hiện với tần suất lớn như một nỗi ám ảnh khôn nguôi.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSS_RyhnMq01yw12TECaSLPWq83HKvFvakE6A&usqp=CAU", "Victor Hugo" },
                    { 5, "ác phẩm của Kafka đều mang một đặc trưng: nói về một phần u tối trong dãy “cảm xúc” của con người. Chúng đều được bao trùm trong bầu không khí, ấn tượng, cảm giác rất riêng biệt, xuất hiện với tần suất lớn như một nỗi ám ảnh khôn nguôi.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSS_RyhnMq01yw12TECaSLPWq83HKvFvakE6A&usqp=CAU", "Emest Hemingway" }
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "Science", 1 },
                    { 3, "Mystery", 1 },
                    { 2, "Comedy", 1 },
                    { 4, "Horror", 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "1", "A" },
                    { "2", "B" },
                    { "3", "C" },
                    { "4", "B" }
                });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "Id", "AuthorID", "CategoryID", "Description", "Edition", "Img", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, "ahsufhadhsafasdhaa", 2, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQiUAaDFqobRwQ7KdQLQF3qkBYmb7rETd2TlA&usqp=CAU", "asdj", 30.399999999999999, 20 },
                    { 2, 1, 1, "kjhadbfhlgsdafb saldlasdasd", 3, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQiUAaDFqobRwQ7KdQLQF3qkBYmb7rETd2TlA&usqp=CAU", "oiwouas", 99.0, 25 },
                    { 3, 4, 3, "kalhdfladhlahldf fadhfahdfaf", 2, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQiUAaDFqobRwQ7KdQLQF3qkBYmb7rETd2TlA&usqp=CAU", "uhsdbhasad", 38.0, 5 },
                    { 6, 4, 2, "kalhdfladhlahldf fadhfahdfaf", 2, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQiUAaDFqobRwQ7KdQLQF3qkBYmb7rETd2TlA&usqp=CAU", "Chiến tranh và hòa bình", 38.0, 4 },
                    { 9, 4, 2, "kalhdfladhlahldf fadhfahdfaf", 2, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQiUAaDFqobRwQ7KdQLQF3qkBYmb7rETd2TlA&usqp=CAU", "Trăm năm cô đơn", 38.0, 7 },
                    { 4, 4, 4, "kalhdfladhlahldf fadhfahdfaf", 2, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQiUAaDFqobRwQ7KdQLQF3qkBYmb7rETd2TlA&usqp=CAU", "Cuốn theo chiều gió", 38.0, 10 }
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
                name: "IX_books_AuthorID",
                table: "books",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_books_CategoryID",
                table: "books",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_orders_BookID",
                table: "orders",
                column: "BookID");
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
                name: "orders");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
