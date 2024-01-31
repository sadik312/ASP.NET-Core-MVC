using System.ComponentModel.DataAnnotations;

namespace Movie.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; } // string? - denotes nullable type
    [DataType(DateType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
    public decimal Price { get; set; }

}