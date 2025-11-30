using Internship_4_OOP2.Application.Common.Model;
using Internship_4_OOP2.Application.Common.Response;
using Internship_4_OOP2.Domain.Persistence.Users;
using Internship_4_OOP2.Application.Common.Request;
using Internship_4_OOP2.Application.DTOs;


namespace Internship_4_OOP2.Application.Users.User
{

    public class GetAllUsersRequestHandler
        : RequestHandler<GetAllUsersRequest, GetAllUsersResponse>
    {
        private readonly IUserUnitOfWork _unitOfWork;

        public GetAllUsersRequestHandler(IUserUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        protected async override Task<Result<GetAllUsersResponse>> HandleRequest(GetAllUsersRequest request, Result<GetAllUsersResponse> result)
        {
            var users = await _unitOfWork.Repository.GetUsers();

            var userDtos = users.Users.Select(u => new UserDto
            {
                Name = u.Name,
                Username = u.Username,
                Email = u.Email,
            }).ToList();

            result.Value = new GetAllUsersResponse
            {
                Users = userDtos
            };

            return result;
        }

        protected override Task<bool> IsAuthorized()
        {
            return Task.FromResult(true);
        }
    }
}
