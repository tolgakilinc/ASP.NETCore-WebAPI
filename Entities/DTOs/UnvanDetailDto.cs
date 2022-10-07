using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class UnvanDetailDto: IDTo
    {
        public int UnvanId { get; set; }
        public string UnvanAdi { get; set; }
    }
}
