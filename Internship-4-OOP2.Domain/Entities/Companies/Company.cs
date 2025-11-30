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
    }
}