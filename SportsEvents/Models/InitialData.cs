using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SportsEvents.Models
{
    public class InitialData
    {
        public static void EnsurePopulation(IApplicationBuilder app)
        {
            DatabaseContext context = app.ApplicationServices.GetRequiredService<DatabaseContext>();
            context.Database.Migrate();
            if (!context.Events.Any())
            {
                context.Events.AddRange(
                new Event
                {
                    Name = "Brighton Hula Championship",
                    StartDate = "01/12/2020",
                    EndDate = "08/12/2020",
                    Location = "Queen's Park, Brighton"
                },
                new Event
                {
                    Name = "Southampton Rugby Cup",
                    StartDate = "20/04/2020",
                    EndDate = "22/04/2020",
                    Location = "St. Mary's Stadium, Southampton"
                },
                new Event
                {
                    Name = "Cheltenham Town FC Away",
                    StartDate = "06/09/2020",
                    EndDate = "14/09/2020",
                    Location = "The Spiers & Hartwell Jubilee Stadium, Evesham"
                },
                new Event
                {
                    Name = "Boston Golf-Bash",
                    StartDate = "07/08/2020",
                    EndDate = "14/08/2020",
                    Location = "The Boston Golf Club"
                },
                new Event
                {
                    Name = "Edinburgh Test Match",
                    StartDate = "02/06/2020",
                    EndDate = "02/07/2020",
                    Location = "Mazars Grange Cricket Club, Edinburgh"
                },
                new Event
                {
                    Name = "Little Jimmy's Crazy Golf Adventure",
                    StartDate = "01/04/2020",
                    EndDate = "30/04/2020",
                    Location = "Plonk Crazy Gold, Shoreditch"
                });
                context.SaveChanges();
            }
            if (!context.Persons.Any())
            {
                context.Persons.AddRange(
                new Person
                {
                    Name = "Brenda Smith",
                    DOB = "12/12/1949",
                    Gender = "Female",
                    Email = "brenda@gooflabs.com",
                    Address = "10 Norton Avenue, St Pauls",
                    Postcode = "SU19 UK8",
                    Telephone = "07814442783",
                    PlaceOfWork = "Gooflabs Inc",
                    Biography = "Workaholic, loves cats",
                    KeySkills = "Great speaker and hard worker"
                }, 
                new Person
                {
                    Name = "Billybob Stevenson",
                    DOB = "1/1/1962",
                    Gender = "Male",
                    Email = "billybob@automation.com",
                    Address = "12 Knights Road, Kingston",
                    Postcode = "LE23 8UR",
                    Telephone = "09654389255",
                    PlaceOfWork = "Automation Corp",
                    Biography = "Lackadaisical, likes dogs",
                    KeySkills = "Good orator and great team worker"
                },
                new Person
                {
                    Name = "Samuel Brunson",
                    DOB = "3/4/1979",
                    Gender = "Male",
                    Email = "sammyB@umrullo.com",
                    Address = "42 Saxon View, Wembley",
                    Postcode = "SE19 25J",
                    Telephone = "0733836275",
                    PlaceOfWork = "Umrullo Place",
                    Biography = "Loves to work with people but dislikes children",
                    KeySkills = "Good worker, great attendance"
                });
                context.SaveChanges();
            }
        }
    }
}
