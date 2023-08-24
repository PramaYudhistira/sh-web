using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// TODO: potentially may have to change all IDS to GUIDS
/// </summary>
namespace API.Entities
{
    public class Chat
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        /// <value>int</value>
        [Key]
        public int ChatId { get; set; }

        public DateTime TimeStamp { get; set; }


    }
}