using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {


        /// <summary>
        /// Primary key for the AppUser table, use this for RELATIONSHIP ESTABLISHMENT
        /// </summary>
        /// <value>The integer representing UserId</value>
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }

    }
}