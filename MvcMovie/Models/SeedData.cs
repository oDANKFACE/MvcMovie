using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "The R.M.",
                    ReleaseDate = DateTime.Parse("2003-1-31"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 7.99M,
                    ImageName = "TheRM.jpg"
                },
                new Movie
                {
                    Title = "The Other Side of Heaven",
                    ReleaseDate = DateTime.Parse("2004-4-12"),
                    Genre = "Drama",
                    Rating = "PG",
                    Price = 8.99M,
                    ImageName = "OtherSideOfHeaven.jpg"
                },
                new Movie
                {
                    Title = "Meet the Mormons",
                    ReleaseDate = DateTime.Parse("2015-2-26"),
                    Genre = "Documentary",
                    Rating = "PG",
                    Price = 9.99M,
                    ImageName = "MeetTheMormons.jpg"
                },
                new Movie
                {
                    Title = "17 Miracles",
                    ReleaseDate = DateTime.Parse("2011-6-03"),
                    Genre = "Drama",
                    Rating = "PG",
                    Price = 9.99M,
                    ImageName = "17Miracles.jpg"
                },                
                new Movie
                {
                    Title = "Ephraim's Rescue",
                    ReleaseDate = DateTime.Parse("2013-5-31"),
                    Genre = "Drama",
                    Rating = "PG",
                    Price = 9.99M,
                    ImageName = "EphraimsRescue.jpg"
                }
            );
        context.SaveChanges();
    }
}
}