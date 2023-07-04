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
        //passing in connection string as an option 
        public DataContext(DbContextOptions options) : base(options)
        {

        }


        //creates a table for Users
        //Columns: UserId, UserName
        public DbSet<AppUser> Users {get; set;}
    }
}