namespace HomeCinema.Data.Migrations
{
    using HomeCinema.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HomeCinemaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HomeCinemaContext context)
        {
            //  create genres
            context.GenreSet.AddOrUpdate(g => g.Name, GenerateGenres());

            // create movies
            context.MovieSet.AddOrUpdate(m => m.Title, GenerateMovies());

            //// create stocks
            context.StockSet.AddOrUpdate(GenerateStocks());

            // create customers
            context.CustomerSet.AddOrUpdate(GenerateCustomers());

            // create roles
            context.RoleSet.AddOrUpdate(r => r.Name, GenerateRoles());

            // username: chsakell, password: homecinema
            context.UserSet.AddOrUpdate(u => u.Email, new User[]{
                new User()
                {
                    Email="chsakells.blog@gmail.com",
                    Username="chsakell",
                    HashedPassword ="XwAQoiq84p1RUzhAyPfaMDKVgSwnn80NCtsE8dNv3XI=",
                    Salt = "mNKLRbEFCH8y1xIyTXP4qA==",
                    IsLocked = false,
                    DateCreated = DateTime.Now
                }
            });

            // // create user-admin for chsakell
            context.UserRoleSet.AddOrUpdate(new UserRole[] {
                new UserRole() {
                    RoleId = 1, // admin
                    UserId = 1  // chsakell
                }
            });
        }

        private Genre[] GenerateGenres()
        {
            Genre[] genres = new Genre[] {
                new Genre() { Name = "Comedy" },
                new Genre() { Name = "Sci-fi" },
                new Genre() { Name = "Action" },
                new Genre() { Name = "Horror" },
                new Genre() { Name = "Romance" },
                new Genre() { Name = "Comedy" },
                new Genre() { Name = "Crime" },
            };

            return genres;
        }
        private Movie[] GenerateMovies()
        {
            Movie[] movies = new Movie[] {
                new Movie()
                {   Title="Minions", 
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10), 
                    ModifiedDate=new DateTime(2015, 7, 10), 
                    //Image ="minions.jpg", 
                    //GenreId = 1, 
                    //Director ="Kyle Bald", 
                    //Writer="Brian Lynch", 
                    //Producer="Janet Healy", 
                    //ReleaseDate = new DateTime(2015, 7, 10), 
                    //Rating = 3, 
                    Description = "Minions Stuart, Kevin and Bob are recruited by Scarlet Overkill, a super-villain who, alongside her inventor husband Herb, hatches a plot to take over the world.", 
                    //TrailerURI = "https://www.youtube.com/watch?v=Wfql_DoHRKc" 
                },
                new Movie()
                {   Title="Ted 2",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10),
                    //Image ="ted2.jpg", 
                    //GenreId = 1, 
                    //Director ="Seth MacFarlane", 
                    //Writer="Seth MacFarlane", 
                    //Producer="Jason Clark", 
                    //ReleaseDate = new DateTime(2015, 6, 27), 
                    //Rating = 4, 
                    Description = "Newlywed couple Ted and Tami-Lynn want to have a baby, but in order to qualify to be a parent.", 
                    //TrailerURI = "https://www.youtube.com/watch?v=S3AVcCggRnU" 
                },
                new Movie()
                {   Title="Trainwreck",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10),
                    //Image ="trainwreck.jpg", 
                    //GenreId = 2, 
                    //Director ="Judd Apatow", 
                    //Writer="Amy Schumer", 
                    //Producer="Judd Apatow", 
                    //ReleaseDate = new DateTime(2015, 7, 17), 
                    //Rating = 5, 
                    Description = "Having thought that monogamy was never possible, a commitment-phobic career woman may have to face.", 
                    //TrailerURI = "https://www.youtube.com/watch?v=2MxnhBPoIx4" 
                },
                new Movie()
                {   Title="Inside Out",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10),
                    //Image ="insideout.jpg", 
                    //GenreId = 1, 
                    //Director ="Pete Docter", 
                    //Writer="Pete Docter", 
                    //Producer="John Lasseter", 
                    //ReleaseDate = new DateTime(2015, 6, 19), 
                    //Rating = 4, 
                    Description = "After young Riley is uprooted from her Midwest life and moved to San Francisco, her emotions.", 
                    //TrailerURI = "https://www.youtube.com/watch?v=seMwpP0yeu4" 
                },
                new Movie()
                {   Title="Home",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10),
                    //Image ="home.jpg", 
                    //GenreId = 1, 
                    //Director ="Tim Johnson", 
                    //Writer="Tom J. Astle", 
                    //Producer="Suzanne Buirgy", 
                    //ReleaseDate = new DateTime(2015, 5, 27), 
                    //Rating = 4, 
                    Description = "Oh, an alien on the run from his own people, lands on Earth and makes.", 
                    //TrailerURI = "https://www.youtube.com/watch?v=MyqZf8LiWvM" 
                },
                new Movie()
                {   Title="Batman v Superman: Dawn of Justice",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10),
                    //Image ="batmanvssuperman.jpg", 
                    //GenreId = 2, 
                    //Director ="Zack Snyder", 
                    //Writer="Chris Terrio", 
                    //Producer="Wesley Coller", 
                    //ReleaseDate = new DateTime(2015, 3, 25), 
                    //Rating = 4, 
                    Description = "Fearing the actions of a god-like Super Hero left unchecked, Gotham.", 
                    //TrailerURI = "https://www.youtube.com/watch?v=0WWzgGyAH6Y" 
                },
                new Movie()
                {   Title="Ant-Man",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10),
                    //Image ="antman.jpg", 
                    //GenreId = 2, 
                    //Director ="Payton Reed", 
                    //Writer="Edgar Wright", 
                    //Producer="Victoria Alonso", 
                    //ReleaseDate = new DateTime(2015, 7, 17), 
                    //Rating = 5, 
                    Description = "Armed with a super-suit with the astonishing ability to shrink in scale.", 
                    //TrailerURI = "https://www.youtube.com/watch?v=1HpZevFifuo" 
                },
                new Movie()
                {   Title="Jurassic World",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10),
                    //Image ="jurassicworld.jpg", 
                    //GenreId = 2, 
                    //Director ="Colin Trevorrow", 
                    //Writer="Rick Jaffa", 
                    //Producer="Patrick Crowley", 
                    //ReleaseDate = new DateTime(2015, 6, 12), 
                    //Rating = 4, 
                    Description = "A new theme park is built on the original site of Jurassic Park.", 
                    //TrailerURI = "https://www.youtube.com/watch?v=RFinNxS5KN4" 
                },
                new Movie()
                {   Title="Fantastic Four",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10),
                    //Image ="fantasticfour.jpg", 
                    //GenreId = 2, 
                    //Director ="Josh Trank", 
                    //Writer="Simon Kinberg", 
                    //Producer="Avi Arad", 
                    //ReleaseDate = new DateTime(2015, 8, 7), 
                    //Rating = 2, 
                    Description = "Four young outsiders teleport to an alternate and dangerous universe which alters their physical form.", 
                    //TrailerURI = "https://www.youtube.com/watch?v=AAgnQdiZFsQ" 
                },
                new Movie()
                {   Title="Mad Max: Fury Road",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10),
                    //Image ="madmax.jpg", 
                    //GenreId = 2, 
                    //Director ="George Miller", 
                    //Writer="George Miller", 
                    //Producer="Bruce Berman", 
                    //ReleaseDate = new DateTime(2015, 5, 15), 
                    //Rating = 3, 
                    Description = "In a stark desert landscape where humanity is broken, two rebels just might be able to restore order:", 
                    //TrailerURI = "https://www.youtube.com/watch?v=hEJnMQG9ev8" 
                },
                new Movie()
                {   Title="True Detective",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10),
                    //Image ="truedetective.jpg", 
                    //GenreId = 6, 
                    //Director ="Nic Pizzolatto", 
                    //Writer="Bill Bannerman", 
                    //Producer="Richard Brown", 
                    //ReleaseDate = new DateTime(2015, 5, 15), 
                    //Rating = 4, 
                    Description = "An anthology series in which police investigations unearth the personal and professional secrets.", 
                    //TrailerURI = "https://www.youtube.com/watch?v=TXwCoNwBSkQ" 
                },
                new Movie()
                {   Title="The Longest Ride",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10),
                    //Image ="thelongestride.jpg", 
                    //GenreId = 5, 
                    //Director ="Nic Pizzolatto", 
                    //Writer="George Tillman Jr.", 
                    //Producer="Marty Bowen", 
                    //ReleaseDate = new DateTime(2015, 5, 15), 
                    //Rating = 5, 
                    Description = "After an automobile crash, the lives of a young couple intertwine with a much older man.", 
                    //TrailerURI = "https://www.youtube.com/watch?v=FUS_Q7FsfqU" 
                },
                new Movie()
                {   Title="The Walking Dead",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10),
                    //Image ="thewalkingdead.jpg", 
                    //GenreId = 4, 
                    //Director ="Frank Darabont", 
                    //Writer="David Alpert", 
                    //Producer="Gale Anne Hurd", 
                    //ReleaseDate = new DateTime(2015, 3, 28), 
                    //Rating = 5, 
                    Description = "Sheriff's Deputy Rick Grimes leads a group of survivors in a world overrun by zombies.", 
                    //TrailerURI = "https://www.youtube.com/watch?v=R1v0uFms68U" 
                },
                new Movie()
                {   Title="Southpaw",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10),
                    //Image ="southpaw.jpg", 
                    //GenreId = 3, 
                    //Director ="Antoine Fuqua", 
                    //Writer="Kurt Sutter", 
                    //Producer="Todd Black", 
                    //ReleaseDate = new DateTime(2015, 8, 17), 
                    //Rating = 4, 
                    Description = "Boxer Billy Hope turns to trainer Tick Willis to help him get his life back on track", 
                    //TrailerURI = "https://www.youtube.com/watch?v=Mh2ebPxhoLs" 
                },
                new Movie()
                {   Title="Specter",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10),
                    //Image ="spectre.jpg", 
                    //GenreId = 3, 
                    //Director ="Sam Mendes", 
                    //Writer="Ian Fleming", 
                    //Producer="Zakaria Alaoui", 
                    //ReleaseDate = new DateTime(2015, 11, 5), 
                    //Rating = 5, 
                    Description = "A cryptic message from Bond's past sends him on a trail to uncover a sinister organization.", 
                    //TrailerURI = "https://www.youtube.com/watch?v=LTDaET-JweU" 
                },
            };

            return movies;
        }
        private Stock[] GenerateStocks()
        {
            List<Stock> stocks = new List<Stock>();

            for (int i = 1; i <= 15; i++)
            {
                // Three stocks for each movie
                for (int j = 0; j < 3; j++)
                {
                    Stock stock = new Stock()
                    {
                        //MovieId = i,
                        UniqueKey = Guid.NewGuid(),
                        IsAvailable = true
                    };
                    stocks.Add(stock);
                }
            }

            return stocks.ToArray();
        }
        private Customer[] GenerateCustomers()
        {
            List<Customer> _customers = new List<Customer>();

            // Create 100 customers
            for (int i = 0; i < 100; i++)
            {
                Customer customer = new Customer()
                {
                    FirstName = MockData.Person.FirstName(),
                    LastName = MockData.Person.Surname(),
                    IdentityCard = Guid.NewGuid().ToString(),
                    UniqueKey = Guid.NewGuid(),
                    Email = MockData.Internet.Email(),
                    DateOfBirth = new DateTime(1985, 10, 20).AddMonths(i).AddDays(10),
                    RegistrationDate = DateTime.Now.AddDays(i),
                    Mobile = "1234567890"
                };

                _customers.Add(customer);
            }

            return _customers.ToArray();
        }
        private Role[] GenerateRoles()
        {
            Role[] _roles = new Role[]{
                new Role()
                {
                    Name="Admin"
                }
            };

            return _roles;
        }
        /*private Rental[] GenerateRentals()
        {
            for (int i = 1; i <= 45; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Random r = new Random();
                    int customerId = r.Next(1, 99);
                    Rental _rental = new Rental()
                    {
                        CustomerId = 1,
                        StockId = 1,
                        Status = "Returned",
                        RentalDate = DateTime.Now.AddDays(j),
                        ReturnedDate = DateTime.Now.AddDays(j + 1)
                    };

                    _rentals.Add(_rental);
                }
            }

            //return _rentals.ToArray();
        }*/
    }
}
