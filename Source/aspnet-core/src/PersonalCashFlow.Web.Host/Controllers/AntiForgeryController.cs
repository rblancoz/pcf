using Microsoft.AspNetCore.Antiforgery;
using PersonalCashFlow.Controllers;

namespace PersonalCashFlow.Web.Host.Controllers
{
    public class AntiForgeryController : PersonalCashFlowControllerBase
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
