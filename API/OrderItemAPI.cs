using HHPW_server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;


namespace HHPW_server.API
{
    public static class OrderItemAPI
    {
        public static void Map(WebApplication app)
        {
            // GET All OrderItems
            app.MapGet("/api/orderItems", (HHPWDbContext db) =>
            {
                return db.OrderItems.ToList();
            });

            // CREATE an OrderItem
            app.MapPost("/api/orderItems", (HHPWDbContext db, OrderItem newOrderItem) =>
            {
                db.OrderItems.Add(newOrderItem);
                db.SaveChanges();
                return Results.Created($"/api/orderItems/{newOrderItem.ID}", newOrderItem);
            });


            // DELETE an OrderItem
            app.MapDelete("/api/orderItems/{id}", (HHPWDbContext db, int id) =>
            {
                OrderItem orderItemToDelete = db.OrderItems.SingleOrDefault(orderItemToDelete => orderItemToDelete.ID == id);
                if (orderItemToDelete == null)
                {
                    return Results.NotFound();
                }
                db.OrderItems.Remove(orderItemToDelete);
                db.SaveChanges();
                return Results.NoContent();
            });

            // UPDATE an OrderItem
            app.MapPut("/api/orderItems/{id}", (HHPWDbContext db, int id, OrderItem orderItem) =>
            {
                OrderItem orderItemToUpdate = db.OrderItems.SingleOrDefault(order => order.ID == id);

                if (orderItemToUpdate == null)
                {
                    return Results.NotFound();
                }

                orderItemToUpdate.Quantity = orderItem.Quantity;

                db.SaveChanges();
                return Results.NoContent();
            });

            // GET a Single OrderItem
            app.MapGet("/api/orderItems/{id}", (HHPWDbContext db, int id) =>
            {
                var orderItemID = db.OrderItems.FirstOrDefault(c => c.ID == id);

                if (orderItemID == null)
                {
                    return Results.NotFound("OrderItem Not Found.");
                }

                return Results.Ok(orderItemID);
            });

            // GET All OrderItems for a Single Order
            app.MapGet("/api/products/by-seller", (HHPWDbContext db, int OrderID) =>
            {
                var itemsFilteredByOrder = db.OrderItems.Where(c => c.OrderID == OrderID).ToList();

                // If there are no OrderItems containing the OrderID...
                if (!itemsFilteredByOrder.Any())
                {
                    return Results.NotFound("No Items Found For This Order.");
                }

                return Results.Ok(itemsFilteredByOrder);
            });

        }
    }
}