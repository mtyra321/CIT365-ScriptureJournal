using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ScriptureJournal.Data;
using System;
using System.Linq;

namespace ScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ScriptureJournalContext>>()))
            {
                //Look for any movies.
                if (context.Scripture.Any())
                    {
                        return;   // DB has been seeded
                    }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "3 Nephi",
                        Chapter = 15,
                        Verse = 1,
                        CreatedDate =  DateTime.Now
                    },
                    new Scripture
                    {
                        Book = "Mormon",
                        Chapter = 5,
                        Verse = 2,
                        CreatedDate = DateTime.Now

                    },

                    new Scripture
                    {
                        Book = "Matthew",
                        Chapter = 27,
                        Verse = 34,
                        CreatedDate = DateTime.Now

                    },

                    new Scripture
                    {
                        Book = "Acts",
                        Chapter = 22,
                        Verse = 7,
                        CreatedDate = DateTime.Now

                    },

                    new Scripture
                    {
                        Book = "Galations",
                        Chapter = 3,
                        Verse = 15,
                        CreatedDate = DateTime.Now

                    },

                    new Scripture
                    {
                        Book = "1 Nephi",
                        Chapter = 10,
                        Verse = 1,
                        CreatedDate = DateTime.Now

                    },

                    new Scripture
                    {
                        Book = "Genesis",
                        Chapter = 6,
                        Verse = 14,
                        CreatedDate = DateTime.Now

                    }
                );
                context.SaveChanges();
            }
        }
    }
}