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
                Message = $"Ime ne smije biti duže od {Entities.User.NameMaxLength} znakova",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem UsernameMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}2",
                Message = $"Korisničko ime ne smije biti duže od {Entities.User.UsernameMaxLength} znakova",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem EmailMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}3",
                Message = $"Email ne smije biti duži od {Entities.User.EmailMaxLength} znakova",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem AddressStreetMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}4",
                Message = $"Adresa ulice ne smije biti duža od {Entities.User.AddressStreetMaxLength} znakova",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem AddressCityMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}5",
                Message = $"Adresa grada ne smije biti duža od {Entities.User.AddressCityMaxLength} znakova",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem WebsiteMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}6",
                Message = $"Website ne smije biti duži od {Entities.User.WebsiteMaxLength} znakova",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem PasswordMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}7",
                Message = $"Lozinka ne smije biti duža od {Entities.User.PasswordMaxLength} znakova",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem NameNullOrEmpty = new ValidationItem
            {
                Code = $"{CodePrefix}8",
                Message = $"Ime ne smije ostati prazno",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem UsernameNullOrEmpty = new ValidationItem
            {
                Code = $"{CodePrefix}9",
                Message = $"Korisničko ime ne smije ostati prazno",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem EmailNullOrEmpty = new ValidationItem
            {
                Code = $"{CodePrefix}10",
                Message = $"Email ne smije ostati prazan",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem AddressStreetNullOrEmpty = new ValidationItem
            {
                Code = $"{CodePrefix}11",
                Message = $"Adresa ulice ne smije ostati prazna",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem AddressCityNullOrEmpty = new ValidationItem
            {
                Code = $"{CodePrefix}12",
                Message = $"Adresa grada ne smije ostati prazna",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem GeoLatNullOrEmpty = new ValidationItem
            {
                Code = $"{CodePrefix}13",
                Message = $"Geografska širina ne smije ostati prazna",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem GeoLngNullOrEmpty = new ValidationItem
            {
                Code = $"{CodePrefix}14",
                Message = $"Geografska dužina ne smije ostati prazna",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem PassworNullOrEmpty = new ValidationItem
            {
                Code = $"{CodePrefix}15",
                Message = $"Lozinka ne smije ostati prazna",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem UsernameUnique = new ValidationItem
            {
                Code = $"{CodePrefix}16",
                Message = $"Korisničko ime već postoji u sustavu",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem EmailUnique = new ValidationItem
            {
                Code = $"{CodePrefix}17",
                Message = $"Email već postoji u sustavu",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem NameValid = new ValidationItem
            {
                Code = $"{CodePrefix}18",
                Message = $"Ime nije validno",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem UsernameValid = new ValidationItem
            {
                Code = $"{CodePrefix}19",
                Message = $"Korisničko ime nije validno",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem EmailValid = new ValidationItem
            {
                Code = $"{CodePrefix}20",
                Message = $"Email nije validan",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem GeoLatValid = new ValidationItem
            {
                Code = $"{CodePrefix}21",
                Message = $"Geografska širina nije validna",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem GeoLngValid = new ValidationItem
            {
                Code = $"{CodePrefix}22",
                Message = $"Geografska dužina nije validna",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem WebsiteValid = new ValidationItem
            {
                Code = $"{CodePrefix}23",
                Message = $"Website URL nije validan",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };
        }
    }
}
