using System.ComponentModel.DataAnnotations;

namespace AfaryApi.Models
{
    public class Freelancer
    {
        [Key]
        public int FreeId { get; set; }
        [StringLength(100)]
        public string FreeFname { get; set; } = string.Empty;
        [StringLength(100)]
        public string FreeLname { get; set; } = string.Empty;
        [StringLength(100)]
        public string FreeEmail { get; set; } = string.Empty;
        [StringLength(100)]
        public string FreePw { get; set; } = string.Empty;

        
    }
}
