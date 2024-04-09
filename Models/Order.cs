using System.ComponentModel.DataAnnotations;

namespace HHPW_server.Models;

public class Order
{
    public int ID { get; set; }
    [Required]
    public string? Name { get; set; }
    public bool IsClosed { get; set; }
    public int PhoneNumber { get; set; }
    public string? Email { get; set; }
    public int OrderTypeID { get; set; }
    public decimal Total { get; set; }
    public decimal Tip { get; set; }
    public DateTime Date { get; set; }
    public int UserID { get; set; }
}

