using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data
{
    public class DataContext : DbContext
    {
        /// <summary>
        /// constructor for DataContext that calls the DbContext constructor that passes in the connection string
        /// </summary>
        /// <param name="options">the connection string being passed in</param>
        /// <returns></returns>
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        //creates a table for Users
        //Columns: UserId, UserName
        /// <summary>
        /// property for AppUser that will have UserId and UserName
        /// </summary>
        /// <value>A DbSet which represents the table of users</value>
        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Post> Posts { get; set; }
    }
}