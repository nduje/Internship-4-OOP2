using Internship_4_OOP2.Domain.Common.Model;
using Internship_4_OOP2.Domain.Common.Validation;
using Internship_4_OOP2.Domain.Common.Validation.ValidationItems;
using Internship_4_OOP2.Domain.Persistence.Users;

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
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }

        public async Task<Result<bool>> Create(IUserRepository userRepository)
        {
            var validationResult = await CreateOrUpdateValidation();

            if (validationResult.HasError)
            {
                return new Result<bool>(false, validationResult);
            }

            await userRepository.InsertAsync(this);

            return new Result<bool>(true, validationResult);
        }

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

            return validationResult;
        }
    }
}
