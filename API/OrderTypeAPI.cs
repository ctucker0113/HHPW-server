using HHPW_server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;


namespace HHPW_server.API
{
    public static class OrderTypeAPI
    {
        public static void Map(WebApplication app)
        {
            //GET All Order Types
            app.MapGet("/api/orderTypes", (HHPWDbContext db) =>
            {
                return db.OrderTypes.ToList();
            });


        }
    }
}

