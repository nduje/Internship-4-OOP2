using Internship_4_OOP2.Application.Common.Model;
using Internship_4_OOP2.Domain.Persistence.Users;

namespace Internship_4_OOP2.Application.Users.User
{
    public class CreateUserRequest
    {
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
    }

    internal class CreateUserRequestHandler : RequestHandler<CreateUserRequest, SuccessPostResponse>
    {
        private readonly IUserUnitOfWork _unitOfWork;

        public CreateUserRequestHandler(IUserUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        protected async override Task<Result<SuccessPostResponse>> HandleRequest(CreateUserRequest request, Result<SuccessPostResponse> result)
        {
            var user = new Domain.Entities.Users.User
            {
                Name = request.Name,
                Username = request.Username,
                Email = request.Email,
                AddressStreet = request.AddressStreet,
                AddressCity = request.AddressCity,
                GeoLat = request.GeoLat,
                GeoLng = request.GeoLng,
                Website = request.Website,
                Password = Guid.NewGuid().ToString(),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                IsActive = true
            };

            var userResult = await user.Create(_unitOfWork.Repository);
            result.SetValidationResult(userResult.ValidationResult);

            if(result.HasError)
            {
                return result;
            }

            await _unitOfWork.SaveAsync();

            result.SetResult(new SuccessPostResponse(user.Id));
            return result;
        }

        protected override Task<bool> IsAuthorized()
        {
            return Task.FromResult(true);
        }
    }
}
