using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class LiseDetailDto:IDTo
    {
        public int LiseId { get; set; }

        public string LiseAdi{ get; set; }

        public SehirDetailDto sehir{ get; set; }
    }
}
