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
    public class KullaniciRolController : Controller
    {
        [HttpGet("Kullanici_Rol_Listele")]
        public IActionResult Kullanici_Rol_Listele(string kullaniciAd, string sifre)
        {
            clsKullanici_Rol_Islemler cls = new clsKullanici_Rol_Islemler();
            Mesajlar<KULLANICI_ROL> m = cls.Listele(0);

            return Json(m);
        }
        [HttpPost("Rol_Ekle")]
        public IActionResult Rol_Ekle([FromBody] KULLANICI_ROL rol, string kulAd, string sifre)
        {
            clsKullanici_Rol_Islemler cls = new clsKullanici_Rol_Islemler();
            Mesajlar<KULLANICI_ROL> m = cls.Ekle(rol, 0);
            return Json(m);
        }

    }
}
