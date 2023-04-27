using System.ComponentModel.DataAnnotations;

namespace WebAndDbSample.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
    }
}
