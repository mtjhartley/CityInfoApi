using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Entities;

namespace CityInfo.API
{
    public static class CityInfoContextExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            // init seed data
            var cities = new List<City>()
            {
                new City()
                {
                    Name = "New York City",
                    Description = "That one with the big park.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name="Central Park",
                            Description="The most visited urban park in the US."
                        },
                        new PointOfInterest()
                        {
                            Name="Empire State Building",
                            Description = "Get you in an empire state of mind."
                        }
                    }
                },
                new City()
                {
                    Name = "Seattle",
                    Description = "Space needle baby!"
                },
                new City()
                {
                    Name = "Paris",
                    Description = "That one with the big tower."
                }
            };

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
