using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class BolumDetailDto : IDTo
    {
        public int BolumId { get; set; }
        public string BolumAdi { get; set; }
        
    }
}
