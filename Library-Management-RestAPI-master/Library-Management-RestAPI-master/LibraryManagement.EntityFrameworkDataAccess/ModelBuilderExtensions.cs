using LibraryManagement.Pocos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement.EntityFrameworkDataAccess
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //BookPoco[] books = new BookPoco[3];

            //var books = new BookPoco
            //{
            //    Id = Guid.Parse("a6ea9ec7-304b-48b1-aaf4-d5167cd827f8"),
            //    BookName = "Hamlet",
            //    ISBN = 86745289,
            //    PublishedDate = new DateTime(1989, 07, 23)               
            //};

            //var user = new UsersPoco
            //{
            //    Id = Guid.Parse("11223344-5566-7788-99AA-BBCCDDEEFF00"),
            //    UserName = "Nick Jonas",
            //    DOB = new DateTime(1992, 09, 16),
            //    Books = new[] { books }
            //};

            //books[1] = new BookPoco
            //{
            //    Id = Guid.Parse("14b25223-547e-4b56-8fdc-a7573d27c7de"),
            //    BookName = "King Lear",
            //    ISBN = 86745289,
            //    PublishedDate = new DateTime(1989, 07, 23)
            //};

            //books[2] = new BookPoco
            //{
            //    Id = Guid.Parse("700518df-ab27-4a73-bed9-08e1257bde90"),
            //    BookName = "Othello",
            //    ISBN = 86745289,
            //    PublishedDate = new DateTime(1989, 07, 23)
            //};

            //modelBuilder.Entity<UsersPoco>(u =>
            //{
            //    u.HasData(user);
            //    u.OwnsMany(b => b.Books).HasData(books);
            //});

            //modelBuilder.Entity<BookPoco>(b =>
            //{
            //    b.HasData(books);
            //    b.OwnsOne(u => u.User).HasData(user);
            //});
            //modelBuilder.Entity<UsersPoco>().HasData(
            //    new UsersPoco
            //    {
            //        Id = Guid.Parse("11223344-5566-7788-99AA-BBCCDDEEFF00"),
            //        UserName = "Nick Jonas",
            //        DOB = new DateTime(1992, 09, 16)
            //    }
            //);
            modelBuilder.Entity<BookPoco>().HasData(
                new BookPoco
                {
                    Id = Guid.Parse("a6ea9ec7-304b-48b1-aaf4-d5167cd827f8"),
                    BookName = "Hamlet",
                    ISBN = 86745289,
                    PublishedDate = new DateTime(1989, 07, 23),
                    User = new UsersPoco
                    {
                        Id = Guid.Parse("11223344-5566-7788-99AA-BBCCDDEEFF00"),
                        UserName = "Nick Jonas",
                        DOB = new DateTime(1992, 09, 16)
                    }
                },
                new BookPoco
                {
                    Id = Guid.Parse("14b25223-547e-4b56-8fdc-a7573d27c7de"),
                    BookName = "King Lear",
                    ISBN = 86745289,
                    PublishedDate = new DateTime(1989, 07, 23),
                    User = new UsersPoco
                    {
                        Id = Guid.Parse("11223344-5566-7788-99AA-BBCCDDEEFF00"),
                        UserName = "Nick Jonas",
                        DOB = new DateTime(1992, 09, 16)
                    }
                },
                new BookPoco
                {
                    Id = Guid.Parse("700518df-ab27-4a73-bed9-08e1257bde90"),
                    BookName = "Othello",
                    ISBN = 86745289,
                    PublishedDate = new DateTime(1989, 07, 23),
                    User = new UsersPoco
                    {
                        Id = Guid.Parse("11223344-5566-7788-99AA-BBCCDDEEFF00"),
                        UserName = "Nick Jonas",
                        DOB = new DateTime(1992, 09, 16)
                    }
                }
            );
        }
    }
}
