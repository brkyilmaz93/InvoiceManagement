﻿using AboneYonetim.Entities.Concrete;
using AboneYonetim.Entities.ViewModel;
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
    public class FaturaController : BaseController
    {
        public FaturaController(IHttpContextAccessor cnt, IConfiguration configuration) : base(cnt, configuration)
        {

        }

        public IActionResult Index()
        {
            @ViewBag.userName = _baseUser.Kulad;
            @ViewBag.passWord = _basePassword;
            @ViewBag.webUrl = _WebApiUrl;
            return View();
        }

        public IActionResult Ekle()
        {
            @ViewBag.userName = _baseUser.Kulad;
            @ViewBag.passWord = _basePassword;
            @ViewBag.webUrl = _WebApiUrl;
            @ViewBag.RefID = 0;
            return View(new FATURA());
        }

        [HttpPost]
        public IActionResult Ekle(int ModID)
        {
            @ViewBag.userName = _baseUser.Kulad;
            @ViewBag.passWord = _basePassword;
            @ViewBag.webUrl = _WebApiUrl;
            @ViewBag.RefID = ModID;
            //@ViewBag.SehirID = _baseSistemParametreler.SehirID;
            //@ViewBag.IlceID = _baseSistemParametreler.IlceID;

            return View(new FATURA());
        }
    }
}
