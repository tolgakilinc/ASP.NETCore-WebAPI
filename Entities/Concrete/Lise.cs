using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Lise:IEntity
    {
        public int LiseId { get; set; }

        public string LiseAdi { get; set; }

        public int SehirId { get; set; }


    }
}
