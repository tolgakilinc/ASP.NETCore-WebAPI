using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Deneme : IEntity
    {
        public int DenemeId { get; set; }
        public int KullaniciId { get; set; }
        public DateTime Tarih { get; set; }
        public string DenemeAdi { get; set; }
        public int Puan { get; set; }

        public int TYTNet { get; set; }
        public int AYTNet { get; set; }
        public int DilNet { get; set; }
    }
}
