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
        }
    }
}