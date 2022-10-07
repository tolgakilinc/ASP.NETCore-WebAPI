using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Gun:IEntity
    {
        public int GunId { get; set; }
        public string GunAdi { get; set; }
    }
}
