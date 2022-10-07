using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Universite:IEntity
    {
        public int UniversiteId { get; set; }
        public string UniversiteAdi { get; set; }

        public string UniTur { get; set; }
        public int SehirId { get; set; }

        
    }
}
