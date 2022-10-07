using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class AlanDetailDto:IDTo
    {
        public int AlanId { get; set; }
        public string AlanAdi { get; set; }
    }
}
