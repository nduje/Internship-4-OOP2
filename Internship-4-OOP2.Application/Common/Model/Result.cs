using Internship_4_OOP2.Domain.Common.Validation;

namespace Internship_4_OOP2.Application.Common.Model
{
    public class Result<TValue> where TValue : class
    {
        private List<ValidationResultItem> _info = new List<ValidationResultItem>();
        private List<ValidationResultItem> _warnings = new List<ValidationResultItem>();
        private List<ValidationResultItem> _errors = new List<ValidationResultItem>();

        public TValue? Value { get; set; }
        public Guid RequestId { get; set; }
        public bool IsAuthorized { get; set; } = true;
        
        public IReadOnlyList<ValidationResultItem> Infos
        {
            get => _info.AsReadOnly();
            init => _info.AddRange(value);
        }

        public IReadOnlyList<ValidationResultItem> Warnings
        {
            get => _warnings.AsReadOnly();
            init => _warnings.AddRange(value);
        }

        public IReadOnlyList<ValidationResultItem> Errors
        {
            get => _errors.AsReadOnly();
            init => _errors.AddRange(value);
        }

        public bool HasInfo => Errors.Any(validationResult => validationResult.ValidationSeverity == Domain.Common.Validation.ValidationSeverity.Info);
        public bool HasWarning => Errors.Any(validationResult => validationResult.ValidationSeverity == Domain.Common.Validation.ValidationSeverity.Warning);
        public bool HasError => Errors.Any(validationResult => validationResult.ValidationSeverity == Domain.Common.Validation.ValidationSeverity.Error);

        public void SetResult(TValue value)
        {
            Value = value;
        }

        public void SetValidationResult(ValidationResult validationResult)
        {
            _info?.AddRange(validationResult.ValidationItems.Where(x => x.ValidationSeverity == ValidationSeverity.Info).Select(x => ValidationResultItem.FromValidationItem(x)));
            _warnings?.AddRange(validationResult.ValidationItems.Where(x => x.ValidationSeverity == ValidationSeverity.Warning).Select(x => ValidationResultItem.FromValidationItem(x)));
            _errors?.AddRange(validationResult.ValidationItems.Where(x => x.ValidationSeverity == ValidationSeverity.Error).Select(x => ValidationResultItem.FromValidationItem(x)));
        }

        public void SetUnauthorizedResult()
        {
            Value = null;
            IsAuthorized = false;
        }
    }
}
