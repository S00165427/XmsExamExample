namespace XmsExam.Migrations.LibraryMigrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<XmsExam.Models.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\LibraryMigrations";
        }

        protected override void Seed(XmsExam.Models.LibraryContext context)
        {
            seedMember(context);
            seedBooks(context);
        }


        private void seedMember(LibraryContext context)
        {
            #region Member1
            context.Members.AddOrUpdate(c => c.MemberId,
                        new Member
                        {
                            FirstName = "sararh",
                            SecondName = "aaaa",
                            DateJoined = DateTime.Now,
                            MemberId = 1,
                            //Members = SeedMembers(context),
                            //      memberLoan = new List<Loan>()
                            /*
                                                       memberLoan = new List<Loan>()
                                       {	// Create a Loan out on book to one memnber
                                                   new Loan { LoanId = 1,
                                                      MemberId = 1,
                                                      BookId=1,
                                                      // Update attendees with a method similar to the SeedClubMembers 
                                                      // See below
                                                   }
                                        } */
                        });
            #endregion
            #region Member2
            context.Members.AddOrUpdate(c => c.MemberId,
                       new Member
                       {
                           FirstName = "Tina",
                           SecondName = "bbbbb",
                           DateJoined = DateTime.Now,
                           MemberId = 2,
                            //Member = SeedMembers(context),
                            //      memberLoan = new List<Loan>()
                        });
            #endregion
            context.SaveChanges(); // NOTE EF will update the relevant foreign key fields in the clubs, club events and member tables based on the attributes
        }

        private void seedBooks(LibraryContext context)
        {
            #region Book1
            context.books.AddOrUpdate(c => c.BookId,
                        new Book
                        {
                            BookId = 1,
                            Title = "circle of friends ",
                            ISBN = "12345678",
                            Author = "Meave Binchy",
                            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
                            //  to avoid creating duplicate seed data. E.g.
                            //
                            //    context.People.AddOrUpdate(
                            //      p => p.FullName,
                            //      new Person { FullName = "Andrew Peters" },
                            //      new Person { FullName = "Brice Lambson" },
                            //      new Person { FullName = "Rowan Miller" }
                            //    );
                            //
                            //Members = SeedMembers(context),
                            //      memberLoan = new List<Loan>()
                        });
            #endregion
            #region Book2
            context.books.AddOrUpdate(c => c.BookId,
                        new Book
                        {
                            BookId = 2,
                            Title = " friends ",
                            ISBN = "23456789",
                            Author = "aaaaaaaaa",
                            //Members = SeedMembers(context),
                            //      memberLoan = new List<Loan>()
                        });
            #endregion
            #region Book3
            context.books.AddOrUpdate(c => c.BookId,
                        new Book
                        {
                            BookId = 3,
                            Title = " Circle ",
                            ISBN = "34567890",
                            Author = "bbbbbb",
                            //Members = SeedMembers(context),
                            //      memberLoan = new List<Loan>()
                        });
            #endregion
            context.SaveChanges(); // NOTE EF will update the relevant foreign key fields in the clubs, club events and member tables based on the attributes
        }
    }
}
