using System.Runtime.ExceptionServices;

namespace Internship_4_OOP2.Domain.Entities.Users
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

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public bool IsActive { get; set; }

        public async Task<Result<int?>> Create()
        {

        }

        public async Task<> CreateOrUpdateValidation()
        {
            if (Name?.Length > NameMaxLength)
            {
                
            }

            if (Username?.Length > UsernameMaxLength)
            {

            }

            if (Email?.Length > EmailMaxLength)
            {
            
            }

            if (AddressStreet?.Length > AddressStreetMaxLength)
            {

            }

            if (AddressCity?.Length > AddressCityMaxLength)
            {

            }

            if (Website?.Length > WebsiteMaxLength)
            {

            }

            if (Password?.Length > PasswordMaxLength)
            {

            }
        }
    }
}
