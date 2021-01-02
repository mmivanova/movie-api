using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieAPI.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }

        [ForeignKey("MovieId")]
        public ICollection<ActorMovie> Actors { get; set; }


    }
}
