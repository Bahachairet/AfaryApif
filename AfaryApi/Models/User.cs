namespace AfaryApi.Models
{
    public class User
    {
        public string Username { get; set; } = string.Empty;
        public byte[] passwordHash { get; set; }
        public byte[] passwordSalt { get; set; }
    }
}
