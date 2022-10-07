using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class SoruHavuzDetailDto:IDTo
    {
        public int HavuzId { get; set; }
        public SoruDetailDto soru{ get; set; }
        public SoruYanitDetailDto soruYanit { get; set; }
        public DersKategoriDetailDto dersKategori { get; set; }
    }
}
