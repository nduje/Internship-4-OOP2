using Internship_4_OOP2.Domain.Common.Model;
using Internship_4_OOP2.Domain.Common.Validation;
using Internship_4_OOP2.Domain.Common.Validation.ValidationItems;
using Internship_4_OOP2.Domain.Persistence.Companies;

namespace Internship_4_OOP2.Domain.Entities.Companies
{
    public class Company
    {
        public const int NameMaxLength = 150;

        public int Id { get; set; }
        public string Name { get; set; }

        public async Task<Result<bool>> Create(ICompanyRepository companyRepository)
        {
            var validationResult = await CreateOrUpdateValidation();

            if (validationResult.HasError)
            {
                return new Result<bool>(false, validationResult);
            }

            await companyRepository.InsertAsync(this);

            return new Result<bool>(true, validationResult);
        }

        public async Task<ValidationResult> CreateOrUpdateValidation()
        {
            var validationResult = new ValidationResult();

            if (Name?.Length > NameMaxLength)
            {
                validationResult.AddValidationItem(ValidationItems.Company.NameMaxLength);
            }

            if (string.IsNullOrEmpty(Name))
            {
                validationResult.AddValidationItem(ValidationItems.Company.NameMaxLength);
            }

            return validationResult;
        }
    }
}