using System;
using Domain;

namespace Persistence;

public class DbInitializer
{
    public static async Task SeedData(AppDbContext context)
    {
        if (context.Activities.Any()) return;

        var activities = new List<Activity>
        {
            new()
            {
                Title = "Future Activity 1",
                Date = DateTime.Now.AddMonths(8),
                Description = "Activity 1 months in future",
                Category = "Film",
                City = "London",
                Venue = "River Thames, England, United Kingdom",
                Latitude = 51.5575525,
                Longitude = -0.781404
            },
            new()
            {
                Title = "Past Activity 2",
                Date = DateTime.Now.AddMonths(-2),
                Description = "Activity 2 months in future",
                Category = "Drinks",
                City = "London",
                Venue = "The Lamb, England, United Kingdom",
                Latitude = 51.51171665,
                Longitude = -0.1256611057818921
            },
            new() 
            {
                Title = "Future Activity 3",
                Date = DateTime.Now.AddMonths(9),
                Description = "Activity 3 months in future",
                Category = "Music",
                City = "Paris",
                Venue = "Palais Garnier, Paris, France",
                Latitude = 48.8719,
                Longitude = 2.3316
            },
            new() 
            {
                Title = "Future Activity 4",
                Date = DateTime.Now.AddMonths(10),
                Description = "Activity 4 months in future",
                Category = "Art",
                City = "New York",
                Venue = "Metropolitan Museum of Art, New York, USA",
                Latitude = 40.7794,
                Longitude = -73.9632
            },
            new() 
            {
                Title = "Future Activity 5",
                Date = DateTime.Now.AddMonths(11),
                Description = "Activity 5 months in future",
                Category = "Technology",
                City = "San Francisco",
                Venue = "Moscone Center, San Francisco, USA",
                Latitude = 37.7833,
                Longitude = -122.4039
            },
            new()
            {
                Title = "Future Activity 6",
                Date = DateTime.Now.AddMonths(12),
                Description = "Activity 6 months in future",
                Category = "Theatre",
                City = "London",
                Venue = "Globe Theatre, London, UK",
                Latitude = 51.5081,
                Longitude = -0.0976
            },
            new() 
            {
                Title = "Future Activity 7",
                Date = DateTime.Now.AddMonths(13),
                Description = "Activity 7 months in future",
                Category = "Sports",
                City = "Tokyo",
                Venue = "Tokyo Dome, Tokyo, Japan",
                Latitude = 35.7056,
                Longitude = 139.7519
            },
            new() 
            {
                Title = "Future Activity 8",
                Date = DateTime.Now.AddMonths(14),
                Description = "Activity 8 months in future",
                Category = "Food",
                City = "Rome",
                Venue = "Piazza Navona, Rome, Italy",
                Latitude = 41.8992,
                Longitude = 12.4731
            }
        };

        context.Activities.AddRange(activities);

        await context.SaveChangesAsync();
    }
}
