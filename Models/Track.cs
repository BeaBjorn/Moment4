//dataannotations for validation
using System.ComponentModel.DataAnnotations;

//Namespace
namespace PlaylistApi.Models
{
    public class Track
    {
        //Setting an Id of type int
        public int TrackId { get; set; }
        //Setting an artist of type string and makes field required
        [Required]
        public string? Artist { get; set; }
        //Setting a Title of type string and makes field required
        [Required]
        public string? Title { get; set; }
        //Setting a length of type int and makes field required
        [Required]
        public int? Length { get; set; }
        //Setting a Category of type string and makes field required
        public string? Category { get; set; }
    }
}
