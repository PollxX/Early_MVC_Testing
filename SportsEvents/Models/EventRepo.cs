using System.Linq;

namespace SportsEvents.Models
{
    public class EventRepo : IEventRepo
    {
        private DatabaseContext context;
        public EventRepo(DatabaseContext ctx)
        {
            context = ctx;
        }

        public Person AddPerson(Person per)
        {
            throw new System.NotImplementedException();
        }

        public Person EditPerson(int id, string type, string value)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Event> Events() 
        {
            return context.Events;
        }
        public IQueryable<Person> Persons()
        {
            return context.Persons;
        }

        public Person RemovePerson(int id)
        {
            throw new System.NotImplementedException();
        }

        public Person RSVP(int eID, int pID, string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
