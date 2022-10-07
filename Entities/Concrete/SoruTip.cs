using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class SoruTip:IEntity
    {
        public int SoruTipId { get; set; }
        public string SoruTipi { get; set; }
    }
}
