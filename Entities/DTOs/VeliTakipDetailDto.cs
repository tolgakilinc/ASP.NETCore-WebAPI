using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
  public  class VeliTakipDetailDto:IDTo
    {
        public int VeliTakipId { get; set; }
      
        public DateTime Tarih { get; set; }

        public string KullanilanSure { get; set; }
        public Veli veli{ get; set; }
    }
}
