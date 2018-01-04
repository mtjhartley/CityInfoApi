using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        //init dummy data
        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "That one with the big park.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name="Central Park",
                            Description="The most visited urban park in the US." 
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name="Empire State Building",
                            Description = "Get you in an empire state of mind."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Seattle",
                    Description = "Space needle baby!"
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "That one with the big tower."
                }
            };
        }
    }
}
