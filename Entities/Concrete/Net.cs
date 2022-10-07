using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Net : IEntity
    {
        public int NetId { get; set; }

        public int DersId { get; set; }
        public int DogruSayisi { get; set; }
        public int YanlisSayisi { get; set; }
        public decimal NetSayisi { get; set; }

        

        
    }
}
