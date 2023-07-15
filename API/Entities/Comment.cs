using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        public string CommentContent { get; set; }

        [ForeignKey("Post")]
        public int PostId{ get; set; }

        public Post Post { get; set; }

        [ForeignKey("AppUser")]
        public int AppUserId { get; set; }

        public AppUser AppUser { get; set; }

    
    }
}