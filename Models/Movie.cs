using System.ComponentModel.DataAnnotations;

namespace Learn.AspNetCore.Basic.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]  //Data annotation
        public DateTime ReleaseDate { get; set; }
        public string? Genere { get; set; }
        public decimal? Price { get; set; }
    }
}
