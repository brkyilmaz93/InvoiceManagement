using AboneYonetim.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboneYonetim.Entities.ViewModel
{
    public class FATURA_TAHSILAT_VIEW_MODEL
    {
        public FATURA Fatura { get; set; }
        public TAHSILAT Tasilat { get; set; }

        public FATURA_TAHSILAT_VIEW_MODEL()
        {
            Fatura = new FATURA();
            Tasilat = new TAHSILAT();
        }
    }
}
