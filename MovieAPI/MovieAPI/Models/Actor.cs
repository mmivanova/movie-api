using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieAPI.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        private string fullName;
        public string FullName
        {
            get { return fullName = FirstName + " " + LastName; }
            set { fullName = value;}
        }

        [ForeignKey("ActorId")]
        public ICollection<ActorMovie> Movies { get; set; }


    }
}
