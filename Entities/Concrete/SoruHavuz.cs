using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class SoruHavuz : IEntity
    {
        [Key]
        public int HavuzId { get; set; }
        public int SoruId { get; set; }
        public int DersKategoriId { get; set; }

    }
}
