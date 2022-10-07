using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class GunDetailDto:IDTo
    {
        public int GunId { get; set; }
        public string GunAdi { get; set; }
    }
}
