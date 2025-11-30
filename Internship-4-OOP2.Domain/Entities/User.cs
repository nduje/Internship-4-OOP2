using Internship_4_OOP2.Domain.Common.Validation;
using Internship_4_OOP2.Domain.Common.Validation.ValidationItems;
using System.Text.RegularExpressions;

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

        public async Task<ValidationResult> CreateOrUpdateValidation()
        {
            var validationResult = new ValidationResult();

            if (Name?.Length > NameMaxLength)
            {
                validationResult.AddValidationItem(ValidationItems.User.NameMaxLength);
            }

            if (Username?.Length > UsernameMaxLength)
            {
                validationResult.AddValidationItem(ValidationItems.User.UsernameMaxLength);
            }

            if (Email?.Length > EmailMaxLength)
            {
                validationResult.AddValidationItem(ValidationItems.User.EmailMaxLength);
            }

            if (AddressStreet?.Length > AddressStreetMaxLength)
            {
                validationResult.AddValidationItem(ValidationItems.User.AddressStreetMaxLength);
            }

            if (AddressCity?.Length > AddressCityMaxLength)
            {
                validationResult.AddValidationItem(ValidationItems.User.AddressCityMaxLength);
            }

            if (Website?.Length > WebsiteMaxLength)
            {
                validationResult.AddValidationItem(ValidationItems.User.WebsiteMaxLength);
            }

            if (Password?.Length > PasswordMaxLength)
            {
                validationResult.AddValidationItem(ValidationItems.User.PasswordMaxLength);
            }

            if (string.IsNullOrEmpty(Name))
            {
                validationResult.AddValidationItem(ValidationItems.User.NameNullOrEmpty);
            }

            if (string.IsNullOrEmpty(Username))
            {
                validationResult.AddValidationItem(ValidationItems.User.UsernameValid);
            }

            if (string.IsNullOrEmpty(Email))
            {
                validationResult.AddValidationItem(ValidationItems.User.EmailNullOrEmpty);
            }

            if (string.IsNullOrEmpty(AddressStreet))
            {
                validationResult.AddValidationItem(ValidationItems.User.AddressStreetNullOrEmpty);
            }

            if (string.IsNullOrEmpty(AddressCity))
            {
                validationResult.AddValidationItem(ValidationItems.User.AddressCityNullOrEmpty);
            }

            if (GeoLat == null)
            {
                validationResult.AddValidationItem(ValidationItems.User.GeoLatNullOrEmpty);
            }

            if (GeoLng == null)
            {
                validationResult.AddValidationItem(ValidationItems.User.GeoLngNullOrEmpty);
            }

            if (Password == null)
            {
                validationResult.AddValidationItem(ValidationItems.User.PassworNullOrEmpty);
            }

            // TODO: UsernameUnique

            // TODO: EmailUnique

            if (!Regex.IsMatch(Name, @"^[A-Za-z ]+$"))
            {
                validationResult.AddValidationItem(ValidationItems.User.NameValid);
            }

            if (!Regex.IsMatch(Username, @"^[A-Za-z0-9 ]+$"))
            {
                validationResult.AddValidationItem(ValidationItems.User.UsernameValid);
            }

            if (!Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                validationResult.AddValidationItem(ValidationItems.User.EmailValid);
            }

            if (GeoLat < -90 || GeoLat > 90)
            {
                validationResult.AddValidationItem(ValidationItems.User.GeoLatValid);
            }

            if (GeoLng < -180 || GeoLng > 180)
            {
                validationResult.AddValidationItem(ValidationItems.User.GeoLngValid);
            }

            if (!Regex.IsMatch(Website, @"^(https?:\/\/)?([\w\-]+\.)+[\w\-]{2,}(\/\S*)?$"))
            {
                validationResult.AddValidationItem(ValidationItems.User.WebsiteValid);
            }

            return validationResult;
        }
    }
}
