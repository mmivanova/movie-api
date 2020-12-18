using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MovieAPI.Models
{
    public class ActorMovie
    {
        //    public int ActorMovieId { get; set; }


        [ForeignKey("ActorId")]
        public int ActorId { get; set; }

        [JsonIgnore]
        public  Actor Actor { get; set; }

        [ForeignKey("MovieId")]
        public int MovieId { get; set; }

        [JsonIgnore]
        public Movie Movie { get; set; }
    }
}
