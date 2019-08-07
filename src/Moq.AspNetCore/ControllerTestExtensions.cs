using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Moq.AspNetCore
{
    public static class ControllerTestExtensions
    {
        public static Mock<ClaimsPrincipal> MockUser(this Controller controller)
        {
            var mockUser = new Mock<ClaimsPrincipal>();

            var contextMock = new Mock<HttpContext>();
            contextMock.SetupProperty(ctx => ctx.User, mockUser.Object);

            controller.ControllerContext = new ControllerContext()
            {
                HttpContext = contextMock.Object
            };
            return mockUser;
        }
    }

}