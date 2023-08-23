using System.ComponentModel.DataAnnotations;

namespace Crud_Entity.Models
{
    public class Movie
    {

        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Gender { get; set; }
        public decimal Price { get; set; }

    }
}
