using Assignment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> books { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Author> authors { get; set; }
        public DbSet<Order> orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            PopulateCategory(builder);
            PopulateAuthor(builder);
            PopulateBook(builder);

            //add du lieu cho user
            PopulateUser(builder);

            //add du lieu cho role
            PopulateRole(builder);

            //add du lieu cho userrole
            PopulateUserRole(builder);
        }

        private void PopulateUser(ModelBuilder builder)
        {
            var admin = new IdentityUser
            {
                Id = "1",
                UserName = "admin@fpt.edu.vn",
                Email = "admin@fpt.edu.vn",
                NormalizedUserName = "admin@fpt.edu.vn",
                EmailConfirmed = true

            };

            var customer = new IdentityUser
            {
                Id = "2",
                UserName = "customer@fpt.edu.vn",
                Email = "customer@fpt.edu.vn",
                NormalizedUserName = "customer@fpt.edu.vn",
                EmailConfirmed = true
            };

            var customer1 = new IdentityUser
            {
                Id = "4",
                UserName = "customer1@fpt.edu.vn",
                Email = "customer1@fpt.edu.vn",
                NormalizedUserName = "customer1@fpt.edu.vn",
                EmailConfirmed = true
            };

            var storeowner = new IdentityUser
            {
                Id = "3",
                UserName = "storeowner@fpt.edu.vn",
                Email = "storeowner@fpt.edu.vn",
                NormalizedUserName = "storeowner@fpt.edu.vn",
                EmailConfirmed = true
            };
            //khai bao thu vien de ma hoa mat khau
            var hasher = new PasswordHasher<IdentityUser>();

            //thiet lap va ma hoa tung tai khoan
            admin.PasswordHash = hasher.HashPassword(admin, "123456");
            customer.PasswordHash = hasher.HashPassword(customer, "123456");
            storeowner.PasswordHash = hasher.HashPassword(storeowner, "123456");
            customer1.PasswordHash = hasher.HashPassword(customer1, "123456");
            //add tai khoan vao fb
            builder.Entity<IdentityUser>().HasData(admin, customer, storeowner, customer1);
        }

        private void PopulateRole(ModelBuilder builder)
        {

            var admin = new IdentityRole
            {
                Id = "A",
                Name = "Admin",
                NormalizedName = "Admin"
            };
            var customer = new IdentityRole
            {
                Id = "B",
                Name = "Customer",
                NormalizedName = "Customer"
            };
            var storeowner = new IdentityRole
            {
                Id = "C",
                Name = "StoreOwner",
                NormalizedName = "StoreOwner"
            };
            
            builder.Entity<IdentityRole>().HasData(admin, customer, storeowner);

        }

        private void PopulateUserRole(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "1",
                    RoleId = "A",
                },
                new IdentityUserRole<string>
                {
                    UserId = "2",
                    RoleId = "B",
                },
                new IdentityUserRole<string>
                {
                    UserId = "3",
                    RoleId = "C",
                },
                new IdentityUserRole<string>
                {
                    UserId = "4",
                    RoleId= "B",
                }
                );
        }

        private void PopulateAuthor(ModelBuilder builder)
        {
            var A1 = new Author
            {
                Id = 1,
                Name = "Franz Kafka",
                Description = "ác phẩm của Kafka đều mang một đặc trưng:" +
                " nói về một phần u tối trong dãy “cảm xúc” của con người. Chúng đều được bao trùm trong bầu không khí," +
                " ấn tượng, cảm giác rất riêng biệt, xuất hiện với tần suất lớn như một nỗi ám ảnh khôn nguôi.",
                Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSS_RyhnMq01yw12TECaSLPWq83HKvFvakE6A&usqp=CAU"
            };
            var A2 = new Author
            {
                Id = 4,
                Name = "Gabriel Garcia Marquez",
                Description = "ác phẩm của Kafka đều mang một đặc trưng:" +
                " nói về một phần u tối trong dãy “cảm xúc” của con người. Chúng đều được bao trùm trong bầu không khí," +
                " ấn tượng, cảm giác rất riêng biệt, xuất hiện với tần suất lớn như một nỗi ám ảnh khôn nguôi.",
                Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSS_RyhnMq01yw12TECaSLPWq83HKvFvakE6A&usqp=CAU"
            };
            var A3 = new Author
            {
                Id = 3,
                Name = "Victor Hugo",
                Description = "ác phẩm của Kafka đều mang một đặc trưng:" +
                " nói về một phần u tối trong dãy “cảm xúc” của con người. Chúng đều được bao trùm trong bầu không khí," +
                " ấn tượng, cảm giác rất riêng biệt, xuất hiện với tần suất lớn như một nỗi ám ảnh khôn nguôi.",
                Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSS_RyhnMq01yw12TECaSLPWq83HKvFvakE6A&usqp=CAU"
            };
            var A5 = new Author
            {
                Id = 5,
                Name = "Emest Hemingway",
                Description = "ác phẩm của Kafka đều mang một đặc trưng:" +
                " nói về một phần u tối trong dãy “cảm xúc” của con người. Chúng đều được bao trùm trong bầu không khí," +
                " ấn tượng, cảm giác rất riêng biệt, xuất hiện với tần suất lớn như một nỗi ám ảnh khôn nguôi.",
                Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSS_RyhnMq01yw12TECaSLPWq83HKvFvakE6A&usqp=CAU"
            };
            builder.Entity<Author>().HasData(A1, A2, A3, A5);
        }

        private void PopulateBook(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Name = "asdj",
                    CategoryID = 1,
                    Price = 30.4,
                    Quantity = 20,
                    Edition = 2,
                    AuthorID = 1,
                    Description = "ahsufhadhsafasdhaa",
                    Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQiUAaDFqobRwQ7KdQLQF3qkBYmb7rETd2TlA&usqp=CAU"
                },
                new Book
                {
                    Id = 2,
                    Name = "oiwouas",
                    CategoryID = 1,
                    Price = 99,
                    Quantity = 25,
                    Edition = 3,
                    AuthorID = 1,
                    Description = "kjhadbfhlgsdafb saldlasdasd",
                    Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQiUAaDFqobRwQ7KdQLQF3qkBYmb7rETd2TlA&usqp=CAU"
                },
                new Book
                {
                    Id = 3,
                    Name = "uhsdbhasad",
                    CategoryID = 3,
                    Price = 38,
                    Edition = 2,
                    Quantity = 5,
                    AuthorID = 4,
                    Description = "kalhdfladhlahldf fadhfahdfaf",
                    Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQiUAaDFqobRwQ7KdQLQF3qkBYmb7rETd2TlA&usqp=CAU"
                },
                new Book
                {
                    Id = 4,
                    Name = "Cuốn theo chiều gió",
                    CategoryID = 4,
                    Price = 38,
                    Edition = 2,
                    Quantity = 10,
                    AuthorID = 4,
                    Description = "kalhdfladhlahldf fadhfahdfaf",
                    Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQiUAaDFqobRwQ7KdQLQF3qkBYmb7rETd2TlA&usqp=CAU"
                },
                new Book
                {
                    Id = 6,
                    Name = "Chiến tranh và hòa bình",
                    CategoryID = 2,
                    Price = 38,
                    Edition = 2,
                    Quantity = 4,
                    AuthorID = 4,
                    Description = "kalhdfladhlahldf fadhfahdfaf",
                    Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQiUAaDFqobRwQ7KdQLQF3qkBYmb7rETd2TlA&usqp=CAU"
                },
                new Book
                {
                    Id = 9,
                    Name = "Trăm năm cô đơn",
                    CategoryID = 2,
                    Price = 38,
                    Edition = 2,
                    Quantity = 7,
                    AuthorID = 4,
                    Description = "kalhdfladhlahldf fadhfahdfaf",
                    Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQiUAaDFqobRwQ7KdQLQF3qkBYmb7rETd2TlA&usqp=CAU"
                }
                );
        }

        private void PopulateCategory(ModelBuilder builder)
        {
            var Science = new Category { Id = 1, Name = "Science", Status = 1 };
            var Mystery = new Category { Id = 3, Name = "Mystery", Status = 1 };
            var Comedy = new Category { Id = 2, Name = "Comedy", Status = 1 };
            var Horror = new Category { Id = 4, Name = "Horror", Status = 1  };
            builder.Entity<Category>().HasData(Science, Mystery, Comedy, Horror);
        }
    }
}
