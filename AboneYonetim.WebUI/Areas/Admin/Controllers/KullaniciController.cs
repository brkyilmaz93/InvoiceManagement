﻿using AboneYonetim.Entities.Concrete;
using AboneYonetim.WebUI.Controllers;
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
    public class KullaniciController : BaseController
    {
        public KullaniciController(IHttpContextAccessor cnt, IConfiguration configuration) : base(cnt, configuration)
        {

        }
        public IActionResult Index()
        {
            @ViewBag.userName = _baseUser.Kulad;
            @ViewBag.passWord = _basePassword;
            @ViewBag.webUrl = _WebApiUrl;
            @ViewBag.RefID = 0;
            return View();
        }

        public IActionResult Ekle()
        {
            @ViewBag.userName = _baseUser.Kulad;
            @ViewBag.passWord = _basePassword;
            @ViewBag.webUrl = _WebApiUrl;
            @ViewBag.RefID = 0;
            return View(new KULLANICI());
        }

       //[HttpPost]
       //public IActionResult Ekle(KULLANICI kullanici)
       //{
       //    @ViewBag.userName = _baseUser.Kulad;
       //    @ViewBag.passWord = _basePassword;
       //    @ViewBag.webUrl = _WebApiUrl;
       //    @ViewBag.RefID = 0;
       //    return View(kullanici);
       //}
    }
}
