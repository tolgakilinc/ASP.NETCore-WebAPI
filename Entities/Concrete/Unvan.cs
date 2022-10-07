using Core.Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Unvan:IEntity
    {
        public int UnvanId { get; set; }
        public string UnvanAdi{ get; set; }

       
    }
}
