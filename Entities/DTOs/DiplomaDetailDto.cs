using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class DiplomaDetailDto:IDTo
    {
        public int DiplomaNumarasi { get; set; }
        public Kullanici kullanici{ get; set; }
        public int DiplomaNot { get; set; }
        public string TCKimlikNo { get; set; }
        public Universite universite{ get; set; }

        public DateTime MezuniyetTarihi { get; set; }

        public Bolum bolum{ get; set; }
    }
}
