﻿using AboneYonetim.WebUI.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AboneYonetim.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : BaseController
    {
        public DashboardController(IHttpContextAccessor cnt, IConfiguration configuration) : base(cnt, configuration)
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
