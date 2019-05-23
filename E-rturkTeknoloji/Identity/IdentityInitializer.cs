using E_rturkTeknoloji.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_rturkTeknoloji.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            //Roller
            if (!context.Roles.Any(i=>i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "admin", Description = "admin role " };

                manager.Create(role);
            }
            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Description = "user role" };

                manager.Create(role);
            }
            //Users
            if (!context.Roles.Any(i => i.Name == "mehmet"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "mehmet", Surname = "ertürk", UserName = "merturk",Email = "erturkmehmettt@gmail.com"};

                manager.Create(user,"merturk123");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }
            if (!context.Roles.Any(i => i.Name == "yunusemre"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "yunus emre", Surname = "ertürk", UserName = "yerturk", Email = "yerturk@gmail.com" };

                manager.Create(user, "yerturk123");
                manager.AddToRole(user.Id, "user");
                
            }



            base.Seed(context);
        }
    }
}