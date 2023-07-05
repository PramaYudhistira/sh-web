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


        /// <summary>
        /// The username for each UserId
        /// </summary>
        /// <value>The string the user enters for their username</value>
        public string UserName { get; set; }

    }
}