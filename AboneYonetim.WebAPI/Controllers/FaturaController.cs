﻿using AboneYonetim.Entities.Concrete;
using AboneYonetim.Entities.Genel;
using AboneYonetim.WebAPI.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AboneYonetim.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FaturaController : Controller
    {
        [HttpGet("Fatura_Getir")]
        public IActionResult Fatura_Getir(int _refID, string kullaniciAd, string sifre)
        {
            clsFatura_Islemler cls = new clsFatura_Islemler();
            Mesajlar<FATURA> m = cls.Getir(_refID, 0);
            return Json(m);
        }
        [HttpGet("Fatura_Getir_Iliskisel")]
        public IActionResult Fatura_Getir_Iliskisel(int _refID, string kullaniciAd, string sifre)
        {
            clsFatura_Islemler cls = new clsFatura_Islemler();
            Mesajlar<FATURA> m = cls.Getir_Iliskisel(_refID, 0);
            return Json(m);
        }
        [HttpGet("Fatura_Getir_AboneID_Iliskisel")]
        public IActionResult Fatura_Getir_AboneID_Iliskisel(int _refID, string kullaniciAd, string sifre)
        {
            clsFatura_Islemler cls = new clsFatura_Islemler();
            Mesajlar<FATURA> m = cls.Getir_AboneID_Iliskisel(_refID, 0);
            return Json(m);
        }


        [HttpGet("Fatura_Getir_Abone_Ad_Iliskisel_Tum")]
        public IActionResult Fatura_Getir_Abone_Ad_Iliskisel_Tum(string aboneAd, string kullaniciAd, string sifre)
        {
            clsFatura_Islemler cls = new clsFatura_Islemler();
            Mesajlar<FATURA> m = cls.Getir_Abone_Ad_Iliskisel_Tum(aboneAd, 0);
            return Json(m);
        }
        [HttpGet("Fatura_Getir_Abone_Ad_Iliskisel_Odenmis")]
        public IActionResult Fatura_Getir_Abone_Ad_Iliskisel_Odenmis(string aboneAd, string kullaniciAd, string sifre)
        {
            clsFatura_Islemler cls = new clsFatura_Islemler();
            Mesajlar<FATURA> m = cls.Getir_Abone_Ad_Iliskisel_Odenmis(aboneAd, 0);
            return Json(m);
        }

        [HttpGet("Fatura_Getir_Abone_Ad_Iliskisel_Odenmemis")]
        public IActionResult Fatura_Getir_Abone_Ad_Iliskisel_Odenmemis(string aboneAd, string kullaniciAd, string sifre)
        {
            clsFatura_Islemler cls = new clsFatura_Islemler();
            Mesajlar<FATURA> m = cls.Getir_Abone_Ad_Iliskisel_Odenmemis(aboneAd, 0);
            return Json(m);
        }
        [HttpGet("Fatura_Listele")]
        public IActionResult Fatura_Listele(string kullaniciAd, string sifre)
        {
            clsFatura_Islemler cls = new clsFatura_Islemler();
            Mesajlar<FATURA> m = cls.Listele(0);
            return Json(m);
        }
        [HttpGet("Fatura_Listele_Iliskisel")]
        public IActionResult Fatura_Listele_Iliskisel(string kullaniciAd, string sifre)
        {
            clsFatura_Islemler cls = new clsFatura_Islemler();
            Mesajlar<FATURA> m = cls.Listele_Iliskisel(0);
            return Json(m);
        }
        [HttpPost("Fatura_Ekle")]
        public IActionResult Fatura_Ekle([FromBody] FATURA fatura, string kullaniciAd, string sifre)
        {
            clsFatura_Islemler cls = new clsFatura_Islemler();
            Mesajlar<FATURA> m = cls.Ekle(fatura, 0);
            return Json(m);
        }

        [HttpPost("Fatura_Duzenle")]
        public IActionResult Fatura_Duzenle([FromBody] FATURA fatura, string kullaniciAd, string sifre)
        {
            clsFatura_Islemler cls = new clsFatura_Islemler();
            Mesajlar<FATURA> m = cls.Duzelt(fatura, 0);
            return Json(m);
        }


        [HttpPost("Fatura_Sil_Id")]
        public IActionResult Fatura_Sil_Id(int refID, string kullaniciAd, string sifre)
        {
            clsFatura_Islemler cls = new clsFatura_Islemler();
            Mesajlar<FATURA> m = cls.Sil_Id(refID, 0);
            return Json(m);
        }
    }
}
