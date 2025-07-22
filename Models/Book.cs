using System.ComponentModel;

namespace AspNet.MVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        [DisplayName("Naslov")]
        public string Title { get; set; }
        [DisplayName("Godina izdanja")]
        public int YearPublished { get; set; }
        [DisplayName("Autor")]
        public Author? Author { get; set; }
    }
}
