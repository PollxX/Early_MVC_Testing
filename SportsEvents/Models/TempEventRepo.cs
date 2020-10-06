using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsEvents.Models
{
    public class TempEventRepo : IEventRepo
    {
        public static List<Event> everyEvent = new List<Event>
        {
            new Event
            {
                EventID = 1,
                Name = "Brighton Hula Championship",
                StartDate = "01/12/2020",
                EndDate = "08/12/2020",
                Location = "Queen's Park, Brighton"
            },
            new Event
            {
                EventID = 2,
                Name = "Southampton Rugby Cup",
                StartDate = "20/04/2020",
                EndDate = "22/04/2020",
                Location = "St. Mary's Stadium, Southampton"
            },
            new Event
            {
                EventID = 3,
                Name = "Cheltenham Town FC Away",
                StartDate = "06/09/2020",
                EndDate = "14/09/2020",
                Location = "The Spiers & Hartwell Jubilee Stadium, Evesham"
            },
            new Event
            {
                EventID = 4,
                Name = "Boston Golf-Bash",
                StartDate = "07/08/2020",
                EndDate = "14/08/2020",
                Location = "The Boston Golf Club"
            },
            new Event
            {
                EventID = 5,
                Name = "Edinburgh Test Match",
                StartDate = "02/06/2020",
                EndDate = "02/07/2020",
                Location = "Mazars Grange Cricket Club, Edinburgh"
            },
            new Event
            {
                EventID = 6,
                Name = "Little Jimmy's Crazy Golf Adventure",
                StartDate = "01/04/2020",
                EndDate = "30/04/2020",
                Location = "Plonk Crazy Gold, Shoreditch"
            }
        };

        public static List<Person> everyPerson = new List<Person>
        {
            new Person
            {
                PersonID = 0,
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
                PersonID = 1,
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
                PersonID = 2,
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
            }
        };

        public IQueryable<Event> Events()
        {
            return everyEvent.AsQueryable<Event>();
        }

        public IQueryable<Person> Persons()
        {
            return everyPerson.AsQueryable<Person>();
        }

        public Person RemovePerson(int id)
        {
            var del = everyPerson.Single(d => d.PersonID.Equals(id));
            everyPerson.Remove(del);
            return del;
        }

        public Person AddPerson(Person per)
        {
            per.PersonID = everyPerson.Count();
            everyPerson.Add(per);
            return per;
        }

        public Person RSVP(int eID, int pID, string name)
        {
            var getPerson = everyPerson.Single(p => p.PersonID.Equals(pID));
            var getEvent = everyEvent.Single(e => e.EventID.Equals(eID));
            
            if (getPerson == null || getEvent == null)
            {
                return null;
            }
            if (getPerson.Name == name)
            {
                getPerson.AttendingEvent = eID;
                
            }
            return getPerson;
        }

        public Person EditPerson(int id, string type, string value)
        {
            var editor = everyPerson.Single(d => d.PersonID.Equals(id));
            if (type == "Name")
            {
                editor.Name = value;
            } 
            else if (type == "DOB")
            {
                editor.DOB = value;
            }
            else if (type == "Gender")
            {
                editor.Gender = value;
            }
            else if (type == "Email")
            {
                editor.Email = value;
            }
            else if (type == "Address")
            {
                editor.Address = value;
            }
            else if (type == "Postcode")
            {
                editor.Postcode = value;
            }
            else if (type == "Telephone")
            {
                editor.Telephone = value;
            }
            else if (type == "PlaceOfWork")
            {
                editor.PlaceOfWork = value;
            }
            else if (type == "Biography")
            {
                editor.Biography = value;
            }
            else if (type == "KeySkills")
            {
                editor.KeySkills = value;
            } 
            else if (type == "AttendingEvent")
            {
                editor.AttendingEvent = 0;
            }
            return editor;
        }
    }
}
