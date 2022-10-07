using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Program:IEntity
    {
        public int ProgramId { get; set; }

        public int KullaniciId { get; set; }
        public string ProgramAdi { get; set; }
        public DateTime Tarih { get; set; }

        public DateTime baslangicTarih { get; set; }
        public DateTime bitisTarih { get; set; }
        public string Icerik { get; set; }
    }
}
