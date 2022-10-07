using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class NetDetailDto:IDTo
    {
        public int NetId { get; set; }
        public DersDetailDto ders { get; set; }
        public int DogruSayisi { get; set; }
        public int YanlisSayisi { get; set; }
        public decimal NetSayisi { get; set; }

        

       
    }
}
