using HHPW_server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;


namespace HHPW_server.API
{
    public static class ItemAPI
    {
        public static void Map(WebApplication app)
        {
            // GET All Items
            app.MapGet("/api/items", (HHPWDbContext db) =>
            {
                return db.Items.ToList();
            });


            // GET a Single Item
            app.MapGet("/api/items/{id}", (HHPWDbContext db, int id) =>
            {
                var itemID = db.Items.FirstOrDefault(c => c.ID == id);

                if (itemID == null)
                {
                    return Results.NotFound("Item Not Found.");
                }

                return Results.Ok(itemID);
            });
        }
    }
}
