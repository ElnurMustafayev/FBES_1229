namespace ModelStateApp.Models;

using System.ComponentModel.DataAnnotations;

public class Product {
    public int Id { get; set; }
    
    [Required]
    [MinLength(3)]
    [MaxLength(100)]
    public string? Name { get; set; }

    [Required]
    [Range(0, 100_000)]
    public decimal? Price { get; set; }
}