using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{

    /// <summary>
    /// NOTE: as of 7/11/2023, i have not found a public dataset that has all university campuses in the world with their respective latitude and longitude
    /// so for now ill try to use the json file in this repo https://github.com/Hipo/university-domains-list however it may mean that we don't need to use this database
    /// table at all?? looking at the json file it doesn't even have correct info considering georgia tech has a state of "null"
    /// </summary>
    public class Campus
    {

        /// <summary>
        /// CampusId specific to the campus, represents primary key
        /// </summary>
        /// <value></value>
        [Key]
        public int CampusId { get; set; }


        /// <summary>
        /// The name of the campus as a string
        /// </summary>
        /// <value></value>
        public string CampusName { get; set; }


        /// <summary>
        /// The country of where the campus is located
        /// </summary>
        /// <value></value>
        public string Country { get; set; }

        public string StateProvince { get; set; }

        public int Latitude { get; set; }

        public int Longitude { get; set; }


    }
}