using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
   public class Diploma:IEntity
    {
        [Key]
        public int DiplomaNumarasi { get; set; }
        public int KullaniciId { get; set; }
        public int DiplomaNot { get; set; }
        public string TCKimlikNo { get; set; }
        public int UniversiteId { get; set; }
        public DateTime MezuniyetTarihi { get; set; }
        public int BolumId { get; set; }
    }
}
