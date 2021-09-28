using AboneYonetim.Entities.Concrete;
using AboneYonetim.Entities.Genel;
using AboneYonetim.Entities.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AboneYonetim.WebAPI.Data
{
    public class clsFatura_Islemler
    {
        public Mesajlar<FATURA> Duzelt(FATURA f, int aktifKulID)
        {
            Mesajlar<FATURA> m = new Mesajlar<FATURA>();
            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {
                    m.Nesne = cnt.FATURALAR.Where(x => x.ObjectID == f.ObjectID).SingleOrDefault();
                    if (m != null)
                    {
                        m.Nesne.Durum = true;
                        m.Nesne.DuzeltmeTarih = DateTime.Now;
                        m.Nesne.Du_KullaniciID = aktifKulID;

                        m.Nesne.AboneID = f.AboneID;
                        m.Nesne.FaturaOdendiMi = f.FaturaOdendiMi;
                        m.Nesne.FaturaDuzenlenmeTarih = f.FaturaDuzenlenmeTarih;
                        m.Nesne.FaturaSonOdemeTarih = f.FaturaSonOdemeTarih;
                        m.Nesne.FaturaDonemi = f.FaturaDonemi;
                        m.Nesne.FaturaTutari = f.FaturaTutari;


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

        public Mesajlar<FATURA> Ekle(FATURA f, int aktifKulID)
        {
            Mesajlar<FATURA> m = new Mesajlar<FATURA>();
            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {
                    f.Durum = true;
                    f.KayitTarih = DateTime.Now;
                    f.Ka_KullaniciID = aktifKulID;
                    f.DuzeltmeTarih = DateTime.Now;
                    f.FaturaOdendiMi = false;
                    f.Aktif = true;

                    cnt.FATURALAR.Add(f);
                    cnt.SaveChanges();

                    m.Durum = true;
                    m.Mesaj = "Bilgiler başarıyla kaydedildi.";
                    m.KayitID = f.ObjectID;
                }
            }
            catch (Exception eex)
            {
                m.Durum = false;
                m.Mesaj = eex.Message;
            }
            return m;
        }

        public Mesajlar<FATURA> Getir(int refID, int aktifKulID)
        {
            Mesajlar<FATURA> m = new Mesajlar<FATURA>();
            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {
                    m.Nesne = cnt.FATURALAR.Where(x => x.ObjectID == refID && x.Durum == true).SingleOrDefault();
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

        public Mesajlar<FATURA> Getir_Iliskisel(int refID, int aktifKulID)
        {
            Mesajlar<FATURA> m = new Mesajlar<FATURA>();
            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {
                    m.Nesne = cnt.FATURALAR.Include(x => x.Abone).Where(x => x.ObjectID == refID && x.Durum == true).SingleOrDefault();
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
        public Mesajlar<FATURA> Getir_AboneID_Iliskisel(int refID, int aktifKulID)
        {
            Mesajlar<FATURA> m = new Mesajlar<FATURA>();
            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {

                    m.Liste = cnt.FATURALAR.Include(x => x.Abone).Where(x => x.AboneID == refID && x.Durum == true && x.FaturaOdendiMi == false).ToList();
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
        public Mesajlar<FATURA> Getir_Abone_Ad_Iliskisel_Tum(string aboneAd, int aktifKulID)
        {
            Mesajlar<FATURA> m = new Mesajlar<FATURA>();
            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {
                    //var aranaAbone_ID = cnt.ABONELER.Include("KULLANICILAR").Where(k => k.Kullanici.Kulad == aboneAd).SingleOrDefault();

                    m.Liste = cnt.FATURALAR.Include(x => x.Abone).Where(x => x.Abone.Kullanici.Kulad == aboneAd).ToList();
                    m.Durum = true;


                }
            }
            catch (Exception eex)
            {
                m.Durum = false;
                m.Mesaj = eex.Message;
            }
            return m;
        }
        public Mesajlar<FATURA> Getir_Abone_Ad_Iliskisel_Odenmis(string aboneAd, int aktifKulID)
        {
            Mesajlar<FATURA> m = new Mesajlar<FATURA>();
            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {
                    //var aranaAbone_ID = cnt.ABONELER.Include("KULLANICILAR").Where(k => k.Kullanici.Kulad == aboneAd).SingleOrDefault();

                    m.Liste = cnt.FATURALAR.Include(x => x.Abone).Where(x => x.Abone.Kullanici.Kulad == aboneAd && x.FaturaOdendiMi == true).ToList();
                    m.Durum = true;


                }
            }
            catch (Exception eex)
            {
                m.Durum = false;
                m.Mesaj = eex.Message;
            }
            return m;
        }

        public Mesajlar<FATURA> Getir_Abone_Ad_Iliskisel_Odenmemis(string aboneAd, int aktifKulID)
        {
            Mesajlar<FATURA> m = new Mesajlar<FATURA>();
            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {
                    //var aranaAbone_ID = cnt.ABONELER.Include("KULLANICILAR").Where(k => k.Kullanici.Kulad == aboneAd).SingleOrDefault();

                    m.Liste = cnt.FATURALAR.Include(x => x.Abone).Where(x => x.Abone.Kullanici.Kulad == aboneAd && x.FaturaOdendiMi==false).ToList();
                    m.Durum = true;


                }
            }
            catch (Exception eex)
            {
                m.Durum = false;
                m.Mesaj = eex.Message;
            }
            return m;
        }
        public Mesajlar<FATURA> Listele(int aktifKulID)
        {
            Mesajlar<FATURA> m = new Mesajlar<FATURA>();
            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {
                    m.Liste = cnt.FATURALAR.Where(x => x.Durum == true).ToList();
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
        public Mesajlar<FATURA> Listele_Iliskisel(int aktifKulID)
        {
            Mesajlar<FATURA> m = new Mesajlar<FATURA>();
            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {
                    m.Liste = cnt.FATURALAR.Include(x => x.Abone).Where(x => x.Durum == true).ToList();
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

        public Mesajlar<FATURA> Sil(FATURA f, int aktifKulID)
        {
            Mesajlar<FATURA> m = new Mesajlar<FATURA>();

            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {

                    m.Nesne = cnt.FATURALAR.Where(x => x.ObjectID == f.ObjectID).SingleOrDefault();

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
        public Mesajlar<FATURA> Sil_Id(int refId, int aktifKulID)
        {
            Mesajlar<FATURA> m = new Mesajlar<FATURA>();

            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {

                    m.Nesne = cnt.FATURALAR.Where(x => x.ObjectID == refId).SingleOrDefault();

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
