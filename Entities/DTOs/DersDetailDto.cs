using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class DersDetailDto:IDTo
    {
        public int DersId { get; set; }

        public string DersAdi { get; set; }

        public DersKategori dersKategori { get; set; }

    }
}
