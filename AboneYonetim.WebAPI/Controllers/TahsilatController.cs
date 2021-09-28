using AboneYonetim.Entities.Concrete;
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
    public class TahsilatController : Controller
    {
        [HttpGet("Tahsilat_Getir")]
        public IActionResult Tahsilat_Getir(int _refID, string kullaniciAd, string sifre)
        {
            clsTahsilat_Islemler cls = new clsTahsilat_Islemler();
            Mesajlar<TAHSILAT> m = cls.Getir(_refID, 0);

            return Json(m);
        }
        [HttpGet("Tahsilat_Getir_Iliskisel")]
        public IActionResult Tahsilat_Getir_Iliskisel(int _refID, string kullaniciAd, string sifre)
        {
            clsTahsilat_Islemler cls = new clsTahsilat_Islemler();
            Mesajlar<TAHSILAT> m = cls.Getir_Iliskisel(_refID, 0);
            return Json(m);
        }
        [HttpPost("Tahsilat_Ekle")]
        public IActionResult Tahsilat_Ekle([FromBody] TAHSILAT tahsilat, string kullaniciAd, string sifre)
        {
            clsTahsilat_Islemler cls = new clsTahsilat_Islemler();
            Mesajlar<TAHSILAT> m = cls.Ekle(tahsilat, 0);
            return Json(m);
        }
        [HttpPost("Tahsilat_Duzenle")]
        public IActionResult Tahsilat_Duzenle([FromBody] TAHSILAT tahsilat, string kullaniciAd, string sifre)
        {
            clsTahsilat_Islemler cls = new clsTahsilat_Islemler();
            Mesajlar<TAHSILAT> m = cls.Duzelt(tahsilat, 0);
            return Json(m);
        }
        [HttpPost("Tahsilat_Sil")]
        public IActionResult Tahsilat_Sil([FromBody] TAHSILAT tahsilat, string kullaniciAd, string sifre)
        {
            clsTahsilat_Islemler cls = new clsTahsilat_Islemler();
            Mesajlar<TAHSILAT> m = cls.Sil(tahsilat, 0);
            return Json(m);
        }


        [HttpPost("Tahsilat_Et")]
        public IActionResult Tahsilat_Et([FromBody] TAHSILAT tahsilat, string kullaniciAd, string sifre)
        {
            clsTahsilat_Islemler cls = new clsTahsilat_Islemler();
            Mesajlar<TAHSILAT> m = cls.TahsilET(tahsilat, 0);
            return Json(m);
        }
        [HttpPost("Tahsilat_Et_FaturaNo")]
        public IActionResult Tahsilat_Et_FaturaNo(string pFaturaNo, string kullaniciAd, string sifre)
        {
            clsTahsilat_Islemler cls = new clsTahsilat_Islemler();
            Mesajlar<TAHSILAT> m = cls.TahsilEt_FaturaNo(pFaturaNo, 0);
            return Json(m);
        }


        [HttpGet("Tahsilat_Listele")]
        public IActionResult Tahsilat_Listele(string kullaniciAd, string sifre)
        {
            clsTahsilat_Islemler cls = new clsTahsilat_Islemler();
            Mesajlar<TAHSILAT> m = cls.Listele(0);

            return Json(m);
        }

        [HttpGet("Tahsilat_Listele_Iliskisel")]
        public IActionResult Tahsilat_Listele_Iliskisel(string kullaniciAd, string sifre)
        {
            clsTahsilat_Islemler cls = new clsTahsilat_Islemler();
            Mesajlar<TAHSILAT> m = cls.Listele_Iliskisel(0);

            return Json(m);
        }
        [HttpPost("Tahsilat_Sil_Id")]
        public IActionResult Tahsilat_Sil_Id(int _refID, string kulAd, string sifre)
        {
            clsTahsilat_Islemler cls = new clsTahsilat_Islemler();
            Mesajlar<TAHSILAT> m = cls.Sil_Id(_refID,0);
            return Json(m);
        }


    }
}
