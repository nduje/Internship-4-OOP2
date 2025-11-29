namespace Internship_4_OOP2.Domain.Common.Validation.ValidationItems
{
    public static partial class ValidationItems
    {
        public static class Company
        {
            public static string CodePrefix = nameof(Company);

            public static readonly ValidationItem NameMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}24",
                Message = $"Ime ne smije biti duže od {Entities.Companies.Company.NameMaxLength} znakova",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem NameNullOrEmpty = new ValidationItem
            {
                Code = $"{CodePrefix}25",
                Message = $"Ime ne smije ostati prazno",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem NameUnique = new ValidationItem
            {
                Code = $"{CodePrefix}25",
                Message = $"Ime već postoji u sustavu",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };
        }
    }
}
