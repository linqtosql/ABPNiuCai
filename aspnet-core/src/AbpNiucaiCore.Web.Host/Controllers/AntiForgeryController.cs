using AbpNiucaiCore.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace AbpNiucaiCore.Web.Host.Controllers
{
    public class AntiForgeryController : AbpNiucaiCoreControllerBase
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