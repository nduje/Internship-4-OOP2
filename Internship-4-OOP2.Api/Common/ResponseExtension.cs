using Internship_4_OOP2.Application.Common.Model;
using Internship_4_OOP2.Application.Common.Response;
using Microsoft.AspNetCore.Mvc;

namespace Internship_4_OOP2.Api.Common
{
    public static class ResponseExtension
    {
        public static ActionResult ToActionResult<TValue>(this Result<TValue> result, ControllerBase controller) where TValue : class
        {
            var response = new Response<TValue>(result);

            if (result.HasError)
            {
                return controller.BadRequest(response);
            }

            return controller.Ok(response);
        }
    }
}
