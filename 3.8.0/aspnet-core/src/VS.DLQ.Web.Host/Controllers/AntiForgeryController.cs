using Microsoft.AspNetCore.Antiforgery;
using VS.DLQ.Controllers;

namespace VS.DLQ.Web.Host.Controllers
{
    public class AntiForgeryController : DLQControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
