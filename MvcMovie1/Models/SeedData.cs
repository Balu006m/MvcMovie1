using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie1.Data;
using MvcMovie1.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovie1Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovie1Context>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Around the world in 80 days",
                    ReleaseDate = DateTime.Parse("1956-10-17"),
                    Genre = "Adventure",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Annabelle",
                    ReleaseDate = DateTime.Parse("2014-03-10"),
                    Genre = "Horror",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "The Dark Knight",
                    ReleaseDate = DateTime.Parse("2008-07-18"),
                    Genre = "Action",
                    Rating = "R",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Liar Liar",
                    ReleaseDate = DateTime.Parse("1997-03-21"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 10.00M
                },
                new Movie
                {
                    Title = "Into the Wild",
                    ReleaseDate = DateTime.Parse("2007-05-25"),
                    Genre = "Travel",
                    Rating = "R",
                    Price = 9.00M
                }
            );
           

            context.SaveChanges();
        }
    }
}