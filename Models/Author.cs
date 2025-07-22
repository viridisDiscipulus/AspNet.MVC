using System.ComponentModel;

namespace AspNet.MVC.Models
{
    public class Author
    {
        public int Id { get; set; }
        [DisplayName("Ime")]
        public string FirstName { get; set; }
        [DisplayName("Prezime")]
        public string LastName { get; set; }
        [DisplayName("Datum rođenja")]
        public DateTime DateOfBirth { get; set; }
    }
}
