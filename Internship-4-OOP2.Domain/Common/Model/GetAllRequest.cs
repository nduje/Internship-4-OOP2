using Internship_4_OOP2.Domain.Entities.Users;

namespace Internship_4_OOP2.Domain.Common.Model
{
    public class GetAllRequest<TValue>
    {
        public IEnumerable<TValue> Values { get; init; }
    }
}
