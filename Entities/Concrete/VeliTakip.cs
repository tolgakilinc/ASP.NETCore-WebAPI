using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class VeliTakip:IEntity
    {
        public int VeliTakipId { get; set; }
       

        public DateTime Tarih { get; set; }

        public string KullanilanSure { get; set; }
       
        public int VeliId { get; set; }
    }
}
