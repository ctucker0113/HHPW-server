using HHPW_server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;


namespace HHPW_server.API
{
    public static class OrderAPI
    {
        public static void Map(WebApplication app)
        {
            //GET All Orders
            app.MapGet("/api/orders", (HHPWDbContext db) =>
            {
                return db.Orders.ToList();
            });


            // GET a Single Order
            app.MapGet("/api/orders/{id}", (HHPWDbContext db, int id) =>
            {
                var orderID = db.Orders.FirstOrDefault(c => c.ID == id);

                if (orderID == null)
                {
                    return Results.NotFound("Order Not Found.");
                }

                return Results.Ok(orderID);
            });

            // DELETE an Order
            app.MapDelete("/api/orders/{id}", (HHPWDbContext db, int id) =>
            {
                Order orderToDelete = db.Orders.SingleOrDefault(orderToDelete => orderToDelete.ID == id);
                if (orderToDelete == null)
                {
                    return Results.NotFound();
                }
                db.Orders.Remove(orderToDelete);
                db.SaveChanges();
                return Results.NoContent();
            });

            // CREATE an Order
            app.MapPost("/api/orders", (HHPWDbContext db, Order newOrder) =>
            {
                db.Orders.Add(newOrder);
                db.SaveChanges();
                return Results.Created($"/api/orders/{newOrder.ID}", newOrder);
            });

            // UPDATE an Order
            app.MapPut("/api/orders/{id}", (HHPWDbContext db, int id, Order order) =>
            {
                Order orderToUpdate = db.Orders.SingleOrDefault(order => order.ID == id);

                if (orderToUpdate == null)
                {
                    return Results.NotFound();
                }

                orderToUpdate.Name = order.Name;
                orderToUpdate.IsClosed = order.IsClosed;
                orderToUpdate.PhoneNumber = order.PhoneNumber;
                orderToUpdate.Email = order.Email;
                orderToUpdate.OrderTypeID = order.OrderTypeID;
                orderToUpdate.Total = order.Total;
                orderToUpdate.Tip = order.Tip;
                orderToUpdate.Date = order.Date;

                db.SaveChanges();
                return Results.NoContent();   
            });


        }
    }
}