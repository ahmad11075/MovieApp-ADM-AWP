using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Models;

namespace MovieApp.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Customer
                if (!context.Customers.Any())
                {
                    context.Customers.AddRange(new List<Customer>()
                    {
                     new Customer()
                     {
                         FullName="Customer1",
                         Age = 33,
                         EducationLevel = "Doctorate",
                         Gender = "Male",
                         Ownership = "Own",
                         InternalConnection = "Dial-Up",
                         MaritalStatus = "Married",
                         MovieSelector = "Spouse&Partner",
                         NumBathrooms = 2.5,
                         NumBedrooms = 3,
                         NumCars = 1,
                         NumChildren = 0,
                         NumTVs = 2,
                         PPVFreq = "Rarely",
                         BuyingFreq = "Monthly",
                         Format = "DVD",
                         RentingFreq = "Rarely",
                         ViewingFreq = "Monthly",
                         TheaterFreq = "Monthly",
                         TVMovieFreq = "Monthly",
                         TVSignal = "Cable",
                         SSMA_TimeStamp = DateTime.Now.AddSeconds(2)


                     },
                     new Customer()
                     {
                         FullName="Customer2",
                         Age = 33,
                         EducationLevel = "Doctorate",
                         Gender = "Male",
                         Ownership = "Own",
                         InternalConnection = "DSL",
                         MaritalStatus = "Married",
                         MovieSelector = "Spouse&Partner",
                         NumBathrooms = 2,
                         NumBedrooms = 2,
                         NumCars = 2,
                         NumChildren = 1,
                         NumTVs = 1,
                         PPVFreq = "Never",
                         BuyingFreq = "Monthly",
                         Format = "DVD",
                         RentingFreq = "Monthly",
                         ViewingFreq = "Weekly",
                         TheaterFreq = "Rarely",
                         TVMovieFreq = "Weekly",
                         TVSignal = "Cable",
                         SSMA_TimeStamp = DateTime.Now.AddSeconds(-50)

                     },
                     new Customer()
                     {
                         FullName="Customer3",
                         Age = 50,
                         EducationLevel = "Bachelor's Degree",
                         Gender = "Male",
                         Ownership = "Rent",
                         InternalConnection = "Cable Modem",
                         MaritalStatus = "Never Married",
                         MovieSelector = "Me",
                         NumBathrooms = 2.5,
                         NumBedrooms = 4,
                         NumCars = 2,
                         NumChildren = 2,
                         NumTVs = 3,
                         PPVFreq = "Rarely",
                         BuyingFreq = "Monthly",
                         Format = "VHS",
                         RentingFreq = "Monthly",
                         ViewingFreq = "Weekly",
                         TheaterFreq = "Rarely",
                         TVMovieFreq = "Weekly",
                         TVSignal = "Cable",
                         SSMA_TimeStamp = DateTime.Now.AddSeconds(-150)
                     },
                     new Customer()
                     {
                         FullName="Customer4",
                         Age = 35,
                         EducationLevel = "Doctorate",
                         Gender = "Male",
                         Ownership = "Own",
                         InternalConnection = "No Internet Connection",
                         MaritalStatus = "Married",
                         MovieSelector = "Spouse&Partner",
                         NumBathrooms = 3.5,
                         NumBedrooms = 2,
                         NumCars = 2,
                         NumChildren = 0,
                         NumTVs = 2,
                         PPVFreq = "Never",
                         BuyingFreq = "Monthly",
                         Format = "DVD",
                         RentingFreq = "Monthly",
                         ViewingFreq = "Weekly",
                         TheaterFreq = "Rarely",
                         TVMovieFreq = "Weekly",
                         TVSignal = "Cable",
                         SSMA_TimeStamp = DateTime.Now.AddSeconds(+60)
                     },
                     new Customer()
                     {
                         FullName="Customer5",
                         Age = 32,
                         EducationLevel = "Doctorate",
                         Gender = "Male",
                         Ownership = "Own",
                         InternalConnection = "DSL",
                         MaritalStatus = "Married",
                         MovieSelector = "Me",
                         NumBathrooms = 1.5,
                         NumBedrooms = 1,
                         NumCars = 0,
                         NumChildren = 4,
                         NumTVs = 1,
                         PPVFreq = "Monthly",
                         BuyingFreq = "Monthly",
                         Format = "DVD",
                         RentingFreq = "Monthly",
                         ViewingFreq = "Weekly",
                         TheaterFreq = "Weekly",
                         TVMovieFreq = "Weekly",
                         TVSignal = "Digital Satellite",
                         SSMA_TimeStamp = DateTime.Now.AddSeconds(-100)
                     }
                    }
                    );
                }
                //Actor
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Cruise, Tom",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTk1MjM3NTU5M15BMl5BanBnXkFtZTcwMTMyMjAyMg@@._V1_UY1200_CR142,0,630,1200_AL_.jpg",
                            Bio = "This the Bio of the first actor"
                        },
                        new Actor()
                        {
                            FullName = "Hanks, Tom ",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTQ2MjMwNDA3Nl5BMl5BanBnXkFtZTcwMTA2NDY3NQ@@._V1_UY1200_CR100,0,630,1200_AL_.jpg",
                            Bio = "This the Bio of the second actor"
                        },
                        new Actor()
                        {
                            FullName = "Ford, Harrison",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTY4Mjg0NjIxOV5BMl5BanBnXkFtZTcwMTM2NTI3MQ@@._V1_UY1200_CR88,0,630,1200_AL_.jpg",
                            Bio = "This the Bio of the third actor"
                        },
                        new Actor()
                        {
                            FullName = "Cage, Nicolas",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMjUxMjE4MTQxMF5BMl5BanBnXkFtZTcwNzc2MDM1NA@@._V1_.jpg",
                            Bio = "This the Bio of the fourth actor"
                        },
                        new Actor()
                        {
                            FullName = "Chan, Jackie",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTk4MDM0MDUzM15BMl5BanBnXkFtZTcwOTI4MzU1Mw@@._V1_UY1200_CR117,0,630,1200_AL_.jpg",
                            Bio = "This the Bio of the fifth actor"
                        }
                    });
                    context.SaveChanges();

                }

                //Director
                if (!context.Directors.Any())
                {
                    context.Directors.AddRange(new List<Director>()
                    {
                        new Director()
                        {
                            FullName = "Alex Proyas",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTU2ODQ1NDgyMV5BMl5BanBnXkFtZTcwODYwMzkzMg@@._V1_UY1200_CR109,0,630,1200_AL_.jpg",
                            Bio = "This the Bio of the first director"
                        },
                        new Director()
                        {
                            FullName = "Joseph Kosinski",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BNjQ4MDA2ZDYtYmRiYi00MWQ5LThlYmQtN2U0MWE3NTc1MWQ1XkEyXkFqcGdeQXVyNTQxNTQ4Mg@@._V1_.jpg",
                            Bio = "This the Bio of the second director"
                        },
                        new Director()
                        {
                            FullName = "Phillip Noyce",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTQ0NDIyNTYzOF5BMl5BanBnXkFtZTcwNTczNDc2Mw@@._V1_UY1200_CR160,0,630,1200_AL_.jpg",
                            Bio = "This the Bio of the third director"
                        },
                        new Director()
                        {
                            FullName = "Quentin Tarantino",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTgyMjI3ODA3Nl5BMl5BanBnXkFtZTcwNzY2MDYxOQ@@._V1_.jpg",
                            Bio = "This the Bio of the fourth director"
                        },
                        new Director()
                        {
                            FullName = "Robert Zemeckis",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTgyMTMzMDUyNl5BMl5BanBnXkFtZTcwODA0ODMyMw@@._V1_.jpg",
                            Bio = "This the Bio of the fifth director"
                        }


                    });
                    context.SaveChanges();
                }
                //Movie
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Clear and Present Danger",
                            ImageURL = "~/Images/MovieImages/3.jpg",
                            Price = 30.50,
                            Description = "Action Movie",
                            DirectorId = 3,
                            MovieCategory = MovieCategory.Action

                        },
                         new Movie()
                        {
                             Name = "Top Gun",
                            ImageURL = "~/Images/MovieImages/1.jpg",
                            Price = 25.00,
                            Description = "Drama Movie",
                            DirectorId = 2,
                            MovieCategory = MovieCategory.Drama

                        },
                          new Movie()
                        {
                               Name = "Forrest Gump",
                            ImageURL = "~/Images/MovieImages/2.jpg",
                            Price = 38.50,
                            Description = "Drama Movie",
                            DirectorId = 5,
                            MovieCategory = MovieCategory.Comedy

                        },
                           new Movie()
                        {
                                Name = "Knowing",
                            ImageURL = "~/Images/MovieImages/4.jpg",
                            Price = 44.00,
                            Description = "Sceince Fiction Movie",
                            DirectorId = 1,
                            MovieCategory = MovieCategory.SceinceFiction

                        },
                            new Movie()
                        {
                                 Name = "Police Story",
                            ImageURL = "~/Images/MovieImages/5.jpg",
                            Price = 16.50,
                            Description = "Action Movie",
                            DirectorId = 4,
                            MovieCategory = MovieCategory.Action

                        }

                    });
                    context.SaveChanges();
                }
                //Actor & Movie
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                         {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2

                        },
                         new Actor_Movie()
                        {

                            ActorId = 2,
                            MovieId = 3

                        },
                          new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1

                        },
                           new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4

                        },
                            new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5

                        },

                    }

                        );
                    context.SaveChanges();


                }
                //Criteria
                if (!context.Criterias.Any())
                {
                    context.Criterias.AddRange(new List<Criteria>()
                    {
                        new Criteria()
                        {
                            Name = "Previews"
                        },
                        new Criteria()
                        {
                            Name = "Friends Recommendation"
                        },
                        new Criteria()
                        {
                            Name = "Cast"
                        },
                        new Criteria()
                        {
                            Name = "Director"
                        },
                        new Criteria()
                        {
                            Name = "Genre"
                        },
                        new Criteria()
                        {
                            Name = "Critics Recommendation"
                        },
                        new Criteria()
                        {
                            Name = "Television Ads"
                        }

                    });
                    context.SaveChanges();


                }
                //Technology
                if (!context.Technologies.Any())
                {
                    context.Technologies.AddRange(new List<Technology>()
                    {
                        new Technology()
                        {
                            Name = "Surround Sound"
                        },
                        new Technology()
                        {
                            Name = "Console Game System(e.g. XBOX PS2 etc)"
                        },
                       new Technology()
                        {
                            Name = "DVD"
                        },
                        new Technology()
                        {
                            Name = "HDTV"
                        },
                        new Technology()
                        {
                            Name = "Video-capable Automobile"
                        },
                        new Technology()
                        {
                            Name = "VHS"
                        },
                        new Technology()
                        {
                            Name = "Front Projection TV"
                        }

                    });
                    context.SaveChanges();


                }
                //Hobby
                if (!context.Hobbies.Any())
                {
                    context.Hobbies.AddRange(new List<Hobby>()
                    {
                        new Hobby()
                        {
                            Name = "Kids & Family"
                        },
                        new Hobby()
                        {
                            Name = "Home Design/Improvement"
                        },
                       new Hobby()
                        {
                            Name = "Computer"
                        },
                        new Hobby()
                        {
                            Name = "Business & Investing"
                        },
                        new Hobby()
                        {
                            Name = "Music & Radio"
                        },
                        new Hobby()
                        {
                            Name = "Gardening"
                        },
                        new Hobby()
                        {
                            Name = "Other"
                        }

                    });
                    context.SaveChanges();


                }
                //Channel
                if (!context.Channels.Any())
                {
                    context.Channels.AddRange(new List<Channel>()
                    {
                        new Channel()
                        {
                            Name = "USA"
                        },
                        new Channel()
                        {
                            Name = "HBO"
                        },
                       new Channel()
                        {
                            Name = "Independent Film Channel"
                        },
                        new Channel()
                        {
                            Name = "Lifetime Movie Network"
                        },
                        new Channel()
                        {
                            Name = "A&E"
                        },
                        new Channel()
                        {
                            Name = "Turner Classic Movies"
                        },
                        new Channel()
                        {
                            Name = "American Movie Classics"
                        }

                    });
                    context.SaveChanges();

                }
                //Customer & Criteria
                if (!context.Customers_Criterias.Any())
                {
                    context.Customers_Criterias.AddRange(new List<Customer_Criteria>()
                         {
                        new Customer_Criteria()
                        {
                            CustomerId = 1,
                            CriteriaId = 2

                        },
                         new Customer_Criteria()
                        {

                            CustomerId = 2,
                            CriteriaId = 3

                        },
                          new Customer_Criteria()
                        {
                            CustomerId = 3,
                            CriteriaId = 1

                        },
                           new Customer_Criteria()
                        {
                            CustomerId = 4,
                            CriteriaId = 4

                        },
                            new Customer_Criteria()
                        {
                            CustomerId = 5,
                            CriteriaId = 5

                        },

                    }

                           );
                    context.SaveChanges();


                }
                //Customer & Technology
                if (!context.Customers_Technologies.Any())
                {
                    context.Customers_Technologies.AddRange(new List<Customer_Technology>()
                         {
                        new Customer_Technology()
                        {
                            CustomerId = 1,
                            TechnologyId = 2

                        },
                         new Customer_Technology()
                        {

                            CustomerId = 2,
                            TechnologyId = 3

                        },
                          new Customer_Technology()
                        {
                            CustomerId = 3,
                            TechnologyId = 1

                        },
                           new Customer_Technology()
                        {
                            CustomerId = 4,
                            TechnologyId = 4

                        },
                            new Customer_Technology()
                        {
                            CustomerId = 5,
                            TechnologyId = 5

                        },

                    }

                           );
                    context.SaveChanges();


                }
                //Customer & Hobby
                if (!context.Customers_Hobbies.Any())
                {
                    context.Customers_Hobbies.AddRange(new List<Customer_Hobby>()
                         {
                        new Customer_Hobby()
                        {
                            CustomerId = 1,
                            HobbyId = 2

                        },
                         new Customer_Hobby()
                        {

                            CustomerId = 2,
                            HobbyId = 3

                        },
                          new Customer_Hobby()
                        {
                            CustomerId = 3,
                            HobbyId = 1

                        },
                           new Customer_Hobby()
                        {
                            CustomerId = 4,
                            HobbyId = 4

                        },
                            new Customer_Hobby()
                        {
                            CustomerId = 5,
                            HobbyId = 5

                        },

                    }

                           );
                    context.SaveChanges();


                }
                //Customer & Channel
                if (!context.Customers_Channels.Any())
                {
                    context.Customers_Channels.AddRange(new List<Customer_Channel>()
                         {
                        new Customer_Channel()
                        {
                            CustomerId = 1,
                            ChannelId = 2

                        },
                         new Customer_Channel()
                        {

                            CustomerId = 2,
                            ChannelId = 3

                        },
                          new Customer_Channel()
                        {
                            CustomerId = 3,
                            ChannelId = 1

                        },
                           new Customer_Channel()
                        {
                            CustomerId = 4,
                            ChannelId = 4

                        },
                            new Customer_Channel()
                        {
                            CustomerId = 5,
                            ChannelId = 5

                        },

                    }

                           );
                    context.SaveChanges();


                }


            }
        }
    }
}
