using Internship_4_OOP2.Application.DTOs;

namespace Internship_4_OOP2.Application.Common.Response
{
    public class GetAllUsersResponse
    {
        public List<UserDto> Users { get; set; } = new();
    }
}
