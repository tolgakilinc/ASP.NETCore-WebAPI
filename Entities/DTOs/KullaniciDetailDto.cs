using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class KullaniciDetailDto : IDTo
    {
        public int KullaniciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public string Eposta { get; set; }

        public string Sifre { get; set; }
        public string TelefonNo { get; set; }
        public SehirDetailDto sehir { get; set; }
        public int Yas { get; set; }
        public Unvan unvan{ get; set; }
        public Alan alan { get; set; }
        public Bolum bolum{ get; set; }

        public LiseDetailDto lise{ get; set; }
        public UniversiteDetailDto universite{ get; set; }

        public Sınıf sınıf{ get; set; }

        public Veli veli { get; set; }
    }
}
