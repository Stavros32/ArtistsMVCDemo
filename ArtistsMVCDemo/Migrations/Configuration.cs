namespace ArtistsMVCDemo.Migrations
{
    using ArtistsMVCDemo.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ArtistsMVCDemo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ArtistsMVCDemo.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var artists = new List<Artist>
            {
                new Artist
                {
                    ID = 1,
                    FirstName = "Nikos",
                    LastName = "Karvelas",
                    Albums = new List<Album>()
                    {
                        new Album()
                        {
                            ID = 1,
                            Title = "First Karvela's Album",
                            Songs = new List<Song>()
                            {
                                new Song()
                                {
                                    ID = 1,
                                    Title = "To krevati"
                                },
                                new Song()
                                {
                                    ID = 2,
                                    Title = "Nantia"
                                }
                            }
                        }, 
                        new Album()
                        {
                            ID = 2,
                            Title = "Second Karvela's Album",
                            Songs = new List<Song>()
                            {
                                new Song()
                                {
                                    ID = 3,
                                    Title = "Theia Lola"
                                },
                                new Song()
                                {
                                    ID = 4,
                                    Title = "Pote min les pote"
                                }
                            }
                        },
                    }
                },
                new Artist
                {
                    ID = 2,
                    FirstName = "Giorgos",
                    LastName = "Theofanous",
                    Albums = new List<Album>()
                    {
                        new Album()
                        {
                            ID = 3,
                            Title = "First Theofanous Album",
                            Songs = new List<Song>()
                            {
                                new Song()
                                {
                                    ID = 5,
                                    Title = "Kokkini Grammi"
                                },
                                new Song()
                                {
                                    ID = 6,
                                    Title = "Ela na me teleioseis"
                                },
                                new Song()
                                {
                                    ID = 7,
                                    Title = "Den exei sidera"
                                }
                            }
                        }
                    }
                }
            };

            artists.ForEach(a => context.Artists.AddOrUpdate(a));
            context.SaveChanges();
        }
    }
}
