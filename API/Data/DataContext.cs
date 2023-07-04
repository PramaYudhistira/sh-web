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
        /// DbSet for AppUser entity, will correspond to a table with columns UserId, UserName
        /// </summary>
        public DbSet<AppUser> Users {get; set;}
    }
}