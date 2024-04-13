using HHPW_server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;


namespace HHPW_server.API
{
    public static class UserAPI
    {
        public static void Map(WebApplication app)
        {

            // GET a Single User
            app.MapGet("/api/users/{id}", (HHPWDbContext db, int id) =>
            {
                var userID = db.Users.FirstOrDefault(c => c.ID == id);

                if (userID == null)
                {
                    return Results.NotFound("User Not Found.");
                }

                return Results.Ok(userID);
            });

        }
    }
}

