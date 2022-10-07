using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class DersKategori : IEntity
    {
        public int DersKategoriId { get; set; }
        public string DersKategorisi { get; set; }
    }
}   