using Internship_4_OOP2.Api.Common;
using Internship_4_OOP2.Application.Common.Request;
using Internship_4_OOP2.Application.Users.User;
using Internship_4_OOP2.Domain.Persistence.Users;
using Microsoft.AspNetCore.Mvc;

namespace Internship_4_OOP2.Api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetAll([FromServices] IUserUnitOfWork unitOfWork)
        {
            var requestHandler = new GetAllUsersRequestHandler(unitOfWork);
            var result = await requestHandler.ProcessAuthorizedRequestAsync(new GetAllUsersRequest());
            
            return result.ToActionResult(this);
        }
    }
}
