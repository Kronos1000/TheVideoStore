using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KronosVideo.Models
{
    public class Movie
    {
         [Key]
        public string MovieID { get; set; }
        public string Title { get; set; }

      public int ReleaseYear { get; set; }

      
        public string Classification { get; set; }
    }
}
