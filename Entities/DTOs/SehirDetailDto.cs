using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
  public class SehirDetailDto:IDTo
    {
        public int SehirId { get; set; }
        public string SehirAdi { get; set; }
    }
}
