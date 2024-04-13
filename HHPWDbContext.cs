using Microsoft.EntityFrameworkCore;
using HHPW_server.Models;
using System.Runtime.CompilerServices;

public class HHPWDbContext : DbContext
{

    public DbSet<Item> Items { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderType> OrderTypes { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    public HHPWDbContext(DbContextOptions<HHPWDbContext> context) : base(context)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Sample Data for Items
        modelBuilder.Entity<Item>().HasData(new Item[]
        {
        new Item {
            ID = 1,
            Name = "Pulverizing Pepperoni Pizza",
            Price = 12.99M,
        },
        new Item {
            ID = 2,
            Name = "Spicy Buffalo Wings",
            Price = 8.99M
        },
        new Item {
            ID = 3,
            Name = "Classic Margherita Pizza",
            Price = 10.99M
        },
        new Item {
            ID = 4,
            Name = "BBQ Chicken Feast Pizza",
            Price = 13.99M
        },
        new Item {
            ID = 5,
            Name = "Garlic Parmesan Wings",
            Price = 9.49M
        }
        });

        modelBuilder.Entity<OrderType>().HasData(new OrderType[]
       {

        new OrderType {
            ID = 1,
            Name = "Phone"
        },

        new OrderType{
            ID = 2,
            Name = "Online"
        },

        new OrderType{
            ID = 3,
            Name = "In Person"
        }
       });

        modelBuilder.Entity<Order>().HasData(new Order[]
       {

        new Order {
            ID = 1,
            Name = "Gary's Order",
            IsClosed = false,
            PhoneNumber = 615-442-9914,
            Email = "hurlyburlygirlie@gmail.com",
            OrderTypeID = 1,
            Total = 22.55M,
            Tip = 10.90M,
            Date = new DateTime(2024, 1, 13),
            UserID = 1
        },

        new Order {
            ID = 2,
            Name = "Sarah's Family Feast",
            IsClosed = true,
            PhoneNumber = 615-444-8888,
            Email = "sarahsmail@example.com",
            OrderTypeID = 2,
            Total = 35.20M,
            Tip = 5.00M,
            Date = new DateTime(2024, 1, 14),
            UserID = 2
        },

        new Order {
            ID = 3,
            Name = "John's Quick Lunch",
            IsClosed = false,
            PhoneNumber = 615-555-1234,
            Email = "john.doe@example.com",
            OrderTypeID = 1,
            Total = 15.99M,
            Tip = 3.00M,
            Date = new DateTime(2024, 1, 15),
            UserID = 3
        },

        new Order {
            ID = 4,
            Name = "Emily's Dinner Party",
            IsClosed = true,
            PhoneNumber = 615-667-9090,
            Email = "emily.party@example.com",
            OrderTypeID = 2,
            Total = 48.75M,
            Tip = 8.00M,
            Date = new DateTime(2024, 1, 16),
            UserID = 4
        },

        new Order {
            ID = 5,
            Name = "Mike's Game Night",
            IsClosed = false,
            PhoneNumber = 615-321-6789,
            Email = "mike.games@example.com",
            OrderTypeID = 1,
            Total = 30.40M,
            Tip = 6.00M,
            Date = new DateTime(2024, 1, 17),
            UserID = 5
        }





       }) ;

        modelBuilder.Entity<User>().HasData(new User[]
       {

        new User {
            ID = 1,
            UID = "sampleName1",
            Name = "Harry Potter"
        },

        new User {
            ID = 2,
            UID = "sampleName2",
            Name = "Albus Dumbledore"
        }
       });


        modelBuilder.Entity<OrderItem>().HasData(new OrderItem[]
           {
        new OrderItem {
            ID = 1,
            OrderID = 1,
            ItemID = 1,
            Quantity = 2
        },
        new OrderItem {
            ID = 2,
            OrderID = 1,  // Same order, different item
            ItemID = 2,
            Quantity = 1
        },
        new OrderItem {
            ID = 3,
            OrderID = 2,  // Another order
            ItemID = 3,
            Quantity = 3
        },
        new OrderItem {
            ID = 4,
            OrderID = 2,
            ItemID = 4,
            Quantity = 1
        },
        new OrderItem {
            ID = 5,
            OrderID = 3,
            ItemID = 5,
            Quantity = 2
        }

       });


    }

}

