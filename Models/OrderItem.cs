using System.ComponentModel.DataAnnotations;

namespace HHPW_server.Models;

public class OrderItem
{
    public int ID { get; set; }
    [Required]
    public int OrderID { get; set; }
    public int ItemID { get; set; }
    public int Quantity { get; set; }
}
