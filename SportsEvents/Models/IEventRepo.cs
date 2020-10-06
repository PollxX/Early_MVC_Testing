using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsEvents.Models
{
    public interface IEventRepo
    {
        IQueryable<Event> Events();
        IQueryable<Person> Persons();
        Person RemovePerson(int id);
        Person EditPerson(int id, string type, string value);
        Person RSVP(int eID, int pID, string name);
        Person AddPerson(Person per);
    }
}
