using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
  public  class ProgramDetailDto:IDTo
    {
        public int ProgramId { get; set; }

        public KullaniciDetailDto kullanici{ get; set; }
        public string ProgramAdi { get; set; }
      
        public DateTime Tarih { get; set; }

        public DateTime baslangicTarih { get; set; }
        
        public DateTime bitisTarih { get; set; }
        
        public string Icerik { get; set; }
    }
}
