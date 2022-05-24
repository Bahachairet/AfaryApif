using System.ComponentModel.DataAnnotations;

namespace AfaryApi.Models
{
    public class Client
    {
        [Key]
        public int CliId { get; set; }
        [StringLength(100)]
        public string CliFname { get; set; } = string.Empty;
        [StringLength(100)]
        public string CliLname { get; set; } = string.Empty;
        [StringLength(100)]
        public string CliEmail { get; set; } = string.Empty;
        [StringLength(100)]
        public string CliPw { get; set; } = string.Empty;
    }
}
