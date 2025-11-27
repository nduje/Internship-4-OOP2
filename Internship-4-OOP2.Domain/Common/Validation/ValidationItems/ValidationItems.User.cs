namespace Internship_4_OOP2.Domain.Common.Validation.ValidationItems
{
    public static partial class ValidationItems
    {
        public static class User
        {
            public static string CodePrefix = nameof(User);

            public static readonly ValidationItem NameMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}1",
                Message = $"Ime ne smije biti duže od {Entities.Users.User.NameMaxLength} znakova",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem UsernameMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}2",
                Message = $"Korisničko ime ne smije biti duže od {Entities.Users.User.UsernameMaxLength} znakova",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem EmailMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}3",
                Message = $"Email ne smije biti duži od {Entities.Users.User.EmailMaxLength} znakova",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem AddressStreetMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}4",
                Message = $"Adresa ulice ne smije biti duža od {Entities.Users.User.AddressStreetMaxLength} znakova",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem AddressCityMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}5",
                Message = $"Adresa grada ne smije biti duža od {Entities.Users.User.AddressCityMaxLength} znakova",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem WebsiteMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}6",
                Message = $"Website ne smije biti duži od {Entities.Users.User.WebsiteMaxLength} znakova",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem PasswordMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}7",
                Message = $"Lozinka ne smije biti duža od {Entities.Users.User.PasswordMaxLength} znakova",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };
        }
    }
}
