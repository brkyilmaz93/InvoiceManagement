using AboneYonetim.Entities.Concrete;
using AboneYonetim.Entities.Genel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AboneYonetim.WebAPI.Data
{
    public class clsTahsilat_Islemler
    {
        public Mesajlar<TAHSILAT> Duzelt(TAHSILAT t, int aktifKulID)
        {
            Mesajlar<TAHSILAT> m = new Mesajlar<TAHSILAT>();
            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {
                    m.Nesne = cnt.TAHSILATLAR.Where(x => x.ObjectID == t.ObjectID).SingleOrDefault();
                    if (m.Nesne != null)
                    {
                        m.Nesne.Durum = true;
                        m.Nesne.DuzeltmeTarih = DateTime.Now;
                        m.Nesne.Du_KullaniciID = aktifKulID;

                        m.Nesne.AboneID = t.AboneID;
                        m.Nesne.FaturaID = t.FaturaID;
                        m.Nesne.TahTarhi = t.TahTarhi;
                        m.Nesne.TahTutar = t.TahTutar;

                        cnt.SaveChanges();
                        m.Durum = true;
                        m.Mesaj = "Kullanıcı Başarılı Düzenlendi...";
                    }
                }
            }
            catch (Exception eex)
            {
                m.Durum = false;
                m.Mesaj = eex.Message;
            }
            return m;
        }

        public Mesajlar<TAHSILAT> Ekle(TAHSILAT t, int aktifKulID)
        {
            Mesajlar<TAHSILAT> m = new Mesajlar<TAHSILAT>();
            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {
                    t.Durum = true;
                    t.KayitTarih = DateTime.Now;
                    t.Ka_KullaniciID = aktifKulID;



                    cnt.TAHSILATLAR.Add(t);
                    cnt.SaveChanges();

                    m.Durum = true;
                    m.Mesaj = "Bilgiler başarıyla kaydedildi.";
                    m.KayitID = t.ObjectID;
                }
            }
            catch (Exception eex)
            {
                m.Durum = false;
                m.Mesaj = eex.Message;
            }
            return m;
        }


        public Mesajlar<TAHSILAT> TahsilET(TAHSILAT t, int aktifKulID)
        {
            Mesajlar<TAHSILAT> m = new Mesajlar<TAHSILAT>();
            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {
                    t.Durum = true;
                    t.KayitTarih = DateTime.Now;
                    t.Ka_KullaniciID = aktifKulID;

                    var fatura = cnt.FATURALAR.Where(x => x.ObjectID == t.FaturaID).SingleOrDefault();
                    if (fatura != null)
                    {
                        fatura.FaturaOdendiMi = true;
                    }

                    cnt.TAHSILATLAR.Add(t);
                    cnt.SaveChanges();

                    m.Durum = true;
                    m.Mesaj = "Bilgiler başarıyla kaydedildi.";
                    m.KayitID = t.ObjectID;
                }
            }
            catch (Exception eex)
            {
                m.Durum = false;
                m.Mesaj = eex.Message;
            }
            return m;
        }


        public Mesajlar<TAHSILAT> TahsilEt_FaturaNo(string pFaturaNo, int aktifKulID)
        {
            Mesajlar<TAHSILAT> m = new Mesajlar<TAHSILAT>();
            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {                 
                    var fatura = cnt.FATURALAR.Where(x => x.FaturaNo == pFaturaNo).SingleOrDefault();
                    if (fatura != null)
                    {
                        fatura.FaturaOdendiMi = true;
                    }
                    cnt.SaveChanges();
                    m.Durum = true;
                    m.Mesaj = "Bilgiler başarıyla kaydedildi.";
                   
                }
            }
            catch (Exception eex)
            {
                m.Durum = false;
                m.Mesaj = eex.Message;
            }
            return m;
        }

        public Mesajlar<TAHSILAT> Getir(int refID, int aktifKulID)
        {
            Mesajlar<TAHSILAT> m = new Mesajlar<TAHSILAT>();
            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {
                    m.Nesne = cnt.TAHSILATLAR.Where(x => x.ObjectID == refID && m.Durum == true).SingleOrDefault();
                    m.Durum = true;
                    m.Mesaj = "Bilgiler görüntülendi.";
                }
            }
            catch (Exception eex)
            {
                m.Durum = false;
                m.Mesaj = eex.Message;
            }
            return m;
        }

        public Mesajlar<TAHSILAT> Getir_Iliskisel(int refID, int aktifKulID)
        {
            Mesajlar<TAHSILAT> m = new Mesajlar<TAHSILAT>();
            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {
                    m.Nesne = cnt.TAHSILATLAR.Include(x => x.Fatura).Include(x => x.Abone).Where(x => x.ObjectID == refID).SingleOrDefault();
                    m.Durum = true;
                    m.Mesaj = "Bilgiler görüntülendi.";
                }
            }
            catch (Exception eex)
            {
                m.Durum = false;
                m.Mesaj = eex.Message;
            }
            return m;
        }

        public Mesajlar<TAHSILAT> Listele(int aktifKulID)
        {
            Mesajlar<TAHSILAT> m = new Mesajlar<TAHSILAT>();
            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {
                    m.Liste = cnt.TAHSILATLAR.Where(x => x.Durum == true).ToList();
                    m.Durum = true;
                    m.Mesaj = "Kayıtlar listelendi";
                }
            }
            catch (Exception eex)
            {
                m.Durum = false;
                m.Mesaj = eex.Message;
            }

            return m;
        }

        public Mesajlar<TAHSILAT> Listele_Iliskisel(int aktifKulID)
        {
            Mesajlar<TAHSILAT> m = new Mesajlar<TAHSILAT>();
            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {
                    m.Liste = cnt.TAHSILATLAR.Include("Abone").Include(x => x.Fatura).Where(x => x.Durum == true).ToList();
                    m.Durum = true;
                    m.Mesaj = "Kayıtlar listelendi";
                }
            }
            catch (Exception eex)
            {
                m.Durum = false;
                m.Mesaj = eex.Message;
            }
            return m;
        }
        public Mesajlar<TAHSILAT> Sil(TAHSILAT t, int aktifKulID)
        {
            Mesajlar<TAHSILAT> m = new Mesajlar<TAHSILAT>();

            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {

                    m.Nesne = cnt.TAHSILATLAR.Where(x => x.ObjectID == t.ObjectID).SingleOrDefault();

                    if (m != null)
                    {
                        m.Nesne.Durum = false;
                        m.Nesne.SilmeTarih = DateTime.Now;
                        m.Nesne.Sil_KullaniciID = aktifKulID;


                        cnt.SaveChanges();
                        m.Durum = true;
                        m.Mesaj = "Kullanıcı Silindi..";
                    }
                }
            }
            catch (Exception eex)
            {
                m.Durum = false;
                m.Mesaj = eex.Message;
            }
            return m;
        }


        public Mesajlar<TAHSILAT> Sil_Id(int refID, int aktifKulID)
        {
            Mesajlar<TAHSILAT> m = new Mesajlar<TAHSILAT>();

            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {

                    m.Nesne = cnt.TAHSILATLAR.Where(x => x.ObjectID == refID).SingleOrDefault();

                    if (m != null)
                    {
                        m.Nesne.Durum = false;
                        m.Nesne.SilmeTarih = DateTime.Now;
                        m.Nesne.Sil_KullaniciID = aktifKulID;


                        cnt.SaveChanges();
                        m.Durum = true;
                        m.Mesaj = "Kullanıcı Silindi..";
                    }
                }
            }
            catch (Exception eex)
            {
                m.Durum = false;
                m.Mesaj = eex.Message;
            }
            return m;
        }
    }
}
