﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RodriguesP4.Data
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider, string testUserPw)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Password is set with the following at the command line:
                // dotnet user-secrets set SeedUserPW <pw>
                // The admin user can do anything

                var adminID = await CreateUser(serviceProvider, testUserPw, "cmath2000@gmail.com");
                await CreateRole(serviceProvider, "admin");
                await AddUserToRole(serviceProvider, adminID, "admin");

                SeedDB(context, adminID);
            }
        }

        private static void SeedDB(ApplicationDbContext context, string adminID)
        {
            //TODO: Seed database here if needed.
            //// Look for any movies.
            //if (context.Movies.Any())
            //{
            //    return;   // DB has been seeded
            //}

            //context.Workflows.AddRange(
            //    new Movie
            //    {
            //        Title = "When Harry Met Sally",
            //        ReleaseDate = DateTime.Parse("1989-2-12"),
            //        Genre = "Romantic Comedy",
            //        Price = 7.99M
            //    },

            //    new Movie
            //    {
            //        Title = "Ghostbusters ",
            //        ReleaseDate = DateTime.Parse("1984-3-13"),
            //        Genre = "Comedy",
            //        Price = 8.99M
            //    }
            //);
            //context.SaveChanges();

        }

        private static async Task<string> CreateUser(IServiceProvider serviceProvider,
                                                    string testUserPw, string UserName)
        {
            var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();

            var user = await userManager.FindByNameAsync(UserName);
            if (user == null)
            {
                user = new IdentityUser
                {
                    UserName = UserName,
                    EmailConfirmed = true
                };
                await userManager.CreateAsync(user, testUserPw);
            }

            if (user == null)
            {
                throw new Exception("The password is probably not strong enough!");
            }

            return user.Id;
        }

        private static async Task<IdentityResult> CreateRole(IServiceProvider serviceProvider, string role)
        {
            var roleManager = serviceProvider.GetService<RoleManager<IdentityRole>>();

            if (roleManager == null)
            {
                throw new Exception("roleManager null");
            }

            if (!await roleManager.RoleExistsAsync(role))
            {
                return await roleManager.CreateAsync(new IdentityRole(role));
            }

            return null;
        }

        private static async Task<IdentityResult> AddUserToRole(IServiceProvider serviceProvider, string uid, string role)
        {
            var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();

            var user = await userManager.FindByIdAsync(uid);

            if (user == null)
            {
                throw new Exception("The testUserPw password was probably not strong enough!");
            }

            return await userManager.AddToRoleAsync(user, role);
        }
    }

}
