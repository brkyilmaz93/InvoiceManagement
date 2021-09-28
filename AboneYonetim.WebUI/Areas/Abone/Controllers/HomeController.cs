using AboneYonetim.WebUI.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AboneYonetim.WebUI.Areas.Abone.Controllers
{
    [Area("Abone")]
    public class HomeController : BaseController
    {
        public HomeController(IHttpContextAccessor cnt, IConfiguration configuration) : base(cnt, configuration)
        {

        }
        public IActionResult Index()
        {
            @ViewBag.userName = _baseUser.Kulad;
            @ViewBag.passWord = _basePassword;
            @ViewBag.webUrl = _WebApiUrl;
            return View();
        }
    }
}
