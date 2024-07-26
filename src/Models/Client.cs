namespace EMJI.Models
{
    public class Client
    {
        public string FirstName, Surname, PhoneNumber, Notes;
        public Guid ID;
        public string FullName { get => FirstName + " " + Surname; }
        public bool CanContact = false;
        public bool Arrived { get; set; }
        public Client(string fname, string lname, string number, string notes){
            FirstName = fname;
            Surname = lname;
            PhoneNumber = number;
            Notes = notes;
        }
    }
}
