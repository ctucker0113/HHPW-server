using System.ComponentModel.DataAnnotations;

namespace HHPW_server.Models;

public class Item
{
    public int ID { get; set; }
    [Required]
    public string? Name { get; set; }
    public decimal Price { get; set; }
}


