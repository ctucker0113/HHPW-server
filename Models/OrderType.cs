using System.ComponentModel.DataAnnotations;

namespace HHPW_server.Models;

public class OrderType
{
    public int ID { get; set; }
    [Required]
    public string? Name { get; set; }
}


