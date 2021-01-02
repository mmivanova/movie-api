using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MovieAPI.Models
{
    public class ActorMovie
    {
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
