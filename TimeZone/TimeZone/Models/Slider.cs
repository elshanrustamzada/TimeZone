using System.ComponentModel.DataAnnotations;

namespace TimeZone.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="don't null")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
