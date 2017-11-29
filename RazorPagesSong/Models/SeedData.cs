using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RazorPagesSong.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SongContext(
                serviceProvider.GetRequiredService<DbContextOptions<SongContext>>()))
            {
                // Look for any movies.
                if (context.Song.Any())
                {
                    return;   // DB has been seeded
                }

                context.Song.AddRange(
                    new Song
                    {
                        Title = "I Ain't the One",
                        ReleaseDate = DateTime.Parse("1973-8-13"),
                        Writer = "Gary Rossington",
                        Composer = "Ronnie Van Zant",
                        Artist = "Lynyrd Skynyrd",
                        Album = "(Pronounced 'Lĕh-'nérd 'Skin-'nérd)"
                    },

                    new Song
                    {
                        Title = "Tuesday's Gone",
                        ReleaseDate = DateTime.Parse("1973-8-13"),
                        Writer = "Allen Collins",
                        Composer = "Ronnie Van Zant",
                        Artist = "Lynyrd Skynyrd",
                        Album = "(Pronounced 'Lĕh-'nérd 'Skin-'nérd)"
                    },

                    new Song
                    {
                        Title = "Gimme Three Steps",
                        ReleaseDate = DateTime.Parse("1973-8-13"),
                        Writer = "Allen Collins",
                        Composer = "Ronnie Van Zant",
                        Artist = "Lynyrd Skynyrd",
                        Album = "(Pronounced 'Lĕh-'nérd 'Skin-'nérd)"
                    },

                    new Song
                    {
                        Title = "Simple Man",
                        ReleaseDate = DateTime.Parse("1973-8-13"),
                        Writer = "Gary Rossington",
                        Composer = "Ronnie Van Zant",
                        Artist = "Lynyrd Skynyrd",
                        Album = "(Pronounced 'Lĕh-'nérd 'Skin-'nérd)"
                    },
                    new Song
                    {
                        Title = "Things Goin' On",
                        ReleaseDate = DateTime.Parse("1973-8-13"),
                        Writer = "Gary Rossington",
                        Composer = "Ronnie Van Zant",
                        Artist = "Lynyrd Skynyrd",
                        Album = "(Pronounced 'Lĕh-'nérd 'Skin-'nérd)"
                    },
                    new Song
                    {
                        Title = "Mississippi Kid",
                        ReleaseDate = DateTime.Parse("1973-8-13"),
                        Writer = "Gary Rossington",
                        Composer = "Ronnie Van Zant",
                        Artist = "Lynyrd Skynyrd",
                        Album = "(Pronounced 'Lĕh-'nérd 'Skin-'nérd)"
                    },
                    new Song
                    {
                        Title = "Free Bird",
                        ReleaseDate = DateTime.Parse("1973-8-13"),
                        Writer = "Gary Rossington",
                        Composer = "Ronnie Van Zant",
                        Artist = "Lynyrd Skynyrd",
                        Album = "(Pronounced 'Lĕh-'nérd 'Skin-'nérd)"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}