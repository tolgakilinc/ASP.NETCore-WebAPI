using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class DenemeDetailDto : IDTo
    {
        public int DenemeId { get; set; }
        public KullaniciDetailDto kullanici{ get; set; }
        public DateTime Tarih { get; set; }
        public string DenemeAdi { get; set; }
        public int Puan { get; set; }

        public int TYTNet { get; set; }
        public int AYTNet { get; set; }
        public int DilNet { get; set; }
    }
}
