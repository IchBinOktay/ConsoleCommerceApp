namespace Core.Entities.Base
{
    public class Marketuser:Person
    {
        public int PhoneNumber { get; set; }
        public int Pin { get; set; }
        public int SerialNumber { get; set; }
        public string Password { get; set; }
    }
}
