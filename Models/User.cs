using System.ComponentModel.DataAnnotations;

namespace HHPW_server.Models;

public class User
{
    public int ID { get; set; }
    [Required]
    public string? UID { get; set; }
    public string? Name { get; set; }
}

