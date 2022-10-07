using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SoruYanit : IEntity
    {
        public int SoruYanitId { get; set; }
        public string Yanit { get; set; }

        public int SoruId { get; set; }

        public int KullaniciId { get; set; }

    }
}
