using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Kullanici : IEntity
    {
        public int KullaniciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public string Eposta { get; set; }
        public string Sifre { get; set; }
        public string TelefonNo { get; set; }
        public int SehirId { get; set; }
        public int Yas { get; set; }
        public int UnvanId { get; set; }
        public int AlanId { get; set; }
        public int BolumId { get; set; }

        public int LiseId { get; set; }
        public int UniversiteId { get; set; }

        public int SınıfId { get; set; }

        public int VeliId { get; set; }

    }
}
