using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace MyProject.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            BooksStoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BooksStoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                new Book
                {
                    Title = "PUBG: BATTLEGROUNDS",
                    Description = "Play PUBG: BATTLEGROUNDS for free. Land on strategic locations, loot weapons and supplies, and survive to become the last team standing across various, diverse Battlegrounds. Squad up and join the Battlegrounds for the original Battle Royale experience that only PUBG: BATTLEGROUNDS",
                    Genre = "Battle royale",
                    Price = 21.98m,
                },
                new Book
                {
                    Title = "Grand Theft Auto V",
                    Description = "Grand Theft Auto V for PC offers players the option to explore the award-winning world of Los Santos and Blaine County in resolutions of up to 4k and beyond, as well as the chance to experience the game running at 60 frames per second.",
                    Genre = "Action-adventure",
                    Price = 17.46m,
                },
                new Book
                {
                    Title = "League of Legends",
                    Description = "League of Legends (LoL), commonly referred to as League, is a 2009 multiplayer online battle arena video game developed and published by Riot Games. Inspired by Defense of the Ancients, a custom map for Warcraft III, Riot's founders sought to develop a stand-alone game in the same genre. Since its release in October 2009, the game has been free-to-play and is monetized through purchasable character customization. The game is available for Microsoft Windows and macOS.",
                    Genre = "MOBA",
                    Price = 13.41m,

                },

                new Book
                {
                    Title = "FIFA Online",
                    Description = "FIFA Online is a series of online sports games developed by Electronic Arts (EA). Based on EA's FIFA series of games, it is released with a free-to-play model with a focus on the Asian video game market. The first entry in the series was released in May 2006.",
                    Genre = "Sport",
                    Price = 18.69m,
                },
                new Book
                {
                    Title = "Cyberpunk 2077",
                    Description = "Cyberpunk 2077 is an open-world, action-adventure RPG set in the dark future of Night City — a dangerous megalopolis obsessed with power, glamor, and ceaseless body modification.",
                    Genre = "Action role-playing",
                    Price = 31.26m,
                }
            );
                context.SaveChanges();
            }
        }
    }
}






