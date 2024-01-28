using System.ComponentModel.DataAnnotations;

namespace Movie.Models;

public class Movie
{
    public int Id { get; set; }
    // string? - denotes nullable type
    // 
    public string? Title { get; set; }

}