using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
  public  class UniversiteDetailDto:IDTo
    {
        public int UniversiteId { get; set; }
        public string UniversiteAdi { get; set; }

        public string UniTur { get; set; }
        public SehirDetailDto sehir { get; set; }

        
    }
}
