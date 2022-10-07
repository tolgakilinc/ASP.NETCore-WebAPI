using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Soru:IEntity
    {
        public int SoruId { get; set; }
        public int KullaniciId { get; set; }
        public string Baslik { get; set; }
       
        public int DersId { get; set; }
        public string Aciklama { get; set; }
    }
}
