using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


//TODO: Create a database schema diagram
namespace API.Entities
{
    public class Post
    {

        /// <summary>
        /// The unique PostId of a user's post
        /// </summary>
        /// <value></value>
        [Key]
        public int PostId { get; set; }

        public string PostTypeId { get; set; }



        /// <summary>
        /// Establish the relation between User and Post
        /// </summary>
        /// <value></value>
        [ForeignKey("AppUser")]
        public int AppUserId { get; set; }


        /// <summary>
        /// Navigation property, this is purely for EF to establish relationship between Post and AppUser in an object
        /// -oriented level
        /// </summary>
        /// <value></value>
        public AppUser AppUser { get; set; }

        [ForeignKey("Campus")]
        public int CampusId { get; set; }

        public Campus Campus { get; set; }

        
    }
}