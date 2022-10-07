using Core.Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class SoruDetailDto:IDTo
    {
        public int SoruId { get; set; }
        public KullaniciDetailDto kullanici { get; set; }
        public string Baslik { get; set; }
        public DersDetailDto ders { get; set; }
        public string Aciklama { get; set; }
    }
}
