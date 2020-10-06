namespace SportsEvents.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string Telephone { get; set; }
        public string PlaceOfWork { get; set; }
        public string Biography { get; set; }
        public string KeySkills { get; set; }
        public int AttendingEvent { get; set; }
        //0 means none attending
    }
}
