using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Learn.AspNetCore.Basic.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [Display(Name ="Release Date")]
        [DataType(DataType.Date)]  //Data annotation
        public DateTime ReleaseDate { get; set; }
        public string? Genere { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }
    }
}
