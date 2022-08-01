using Microsoft.EntityFrameworkCore;

namespace RazorPagesBookstore.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppContext>>()
                )
            )
            {
                if (context == null || context.Author == null)
                {
                    throw new ArgumentNullException("Null AppContext");
                }
                // Look for any movies.
                if (context.Author.Any())
                {
                    // DB has been seeded
                    return;
                }

                context.Author.AddRange(
                    new Author
                    {
                        Name = "Jeffrey Archer",
                        DateOfBirth = DateTime.ParseExact("15-04-1940", "dd-MM-yyyy", null),
                        Bio = "Jeffrey Howard Archer, Baron Archer of Weston-super-Mare (born 15 April 1940) is an English novelist, life peer and former politician."
                    },
                    new Author
                    {
                        Name = "James Patterson",
                        DateOfBirth = DateTime.ParseExact("22-01-1947", "dd-MM-yyyy", null),
                        Bio = "James Brendan Patterson (born March 22, 1947) is an American author and philanthropist."
                    },
                    new Author
                    {
                        Name = "Sidney Sheldon",
                        DateOfBirth = DateTime.ParseExact("02-11-1917", "dd-MM-yyyy", null),
                        Bio = "Sidney Sheldon was an American writer, director, and producer. His 18 novels have sold over 300 million copies in 51 languages. Sheldon is consistently cited as one of the top - 10 best - selling fiction writers of all time."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}