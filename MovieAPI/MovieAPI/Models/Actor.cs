using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Models
{
    public class Actor
    {
        public int ActorId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        private string fullName;

        public string FullName
        {
            get { return fullName; }
            set { fullName = FirstName + " " + LastName; }
        }

        [ForeignKey("ActorId")]
        public ICollection<ActorMovie> ActorMovies { get; set; }


    }
}
