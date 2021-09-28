 using AboneYonetim.Entities.Genel;
using AboneYonetim.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AboneYonetim.WebAPI.Data
{
    public class clsFatura_Tahsilat_VM_Islemler
    {
        public Mesajlar<FATURA_TAHSILAT_VIEW_MODEL> Fatura_Tahsilat_Getir(int faturaId, int aktifKulID)
        {
            Mesajlar<FATURA_TAHSILAT_VIEW_MODEL> m = new Mesajlar<FATURA_TAHSILAT_VIEW_MODEL>();
            try
            {
                using (AboneYonetimContext cnt = new AboneYonetimContext())
                {
                    m.Nesne.Fatura = cnt.FATURALAR.Where(x => x.ObjectID == faturaId && x.Durum == true).SingleOrDefault();
                    m.Nesne.Tasilat = cnt.TAHSILATLAR.Where(x => x.FaturaID == faturaId && x.Durum==true).SingleOrDefault();
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
    }
}