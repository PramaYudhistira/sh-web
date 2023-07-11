using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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

        /// <summary>
        /// Establish relation between campus table
        /// </summary>
        /// <value></value>
        [ForeignKey("Campus")]
        public int CampusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public Campus Campus { get; set; }

        /// <summary>
        /// Is there a better way to do this??
        /// The campus the student prefers
        /// </summary>
        /// <value></value>
        public string PreferredCampus { get; set; }


    }
}