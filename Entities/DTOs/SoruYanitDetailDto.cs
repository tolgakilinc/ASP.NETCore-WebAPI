using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class SoruYanitDetailDto : IDTo
    {
        public int SoruYanitId { get; set; }

        public string Yanit { get; set; }
        public Soru soru{ get; set; }
        public KullaniciDetailDto kullanici{ get; set; }
    }
}
