using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class DersKategoriDetailDto : IDTo
    {
        public int DersKategoriId { get; set; }
        public string DersKategorisi { get; set; }
    }
}
