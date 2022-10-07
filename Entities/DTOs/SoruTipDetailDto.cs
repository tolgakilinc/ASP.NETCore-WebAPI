using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class SoruTipDetailDto:IDTo
    {
        public int SoruTipId { get; set; }
        public string SoruTipi { get; set; }
    }
}
