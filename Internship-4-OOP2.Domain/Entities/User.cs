namespace Internship_4_OOP2.Domain.Entities
{
    public class User
    {
        public const int NameMaxLength = 100;
        public const int UsernameMaxLength = 100;
        public const int EmailMaxLength = 255;
        public const int AddressStreetMaxLength = 150;
        public const int AddressCityMaxLength = 100;
        public const int WebsiteMaxLength = 100;
        public const int PasswordMaxLength = 100;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string? AddressStreet { get; set; }
        public string? AddressCity { get; set; }
        public double? GeoLat { get; set; }
        public double? GeoLng { get; set; }
        public string? Website { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
