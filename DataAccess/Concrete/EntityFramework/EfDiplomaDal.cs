using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfDiplomaDal : EfEntityRepositoryBase<Diploma, DeveloperStudentContext>, IDiplomaDal
    {
        public List<DiplomaDetailDto> GetDiplomaDetails()
        {
            using (DeveloperStudentContext context = new DeveloperStudentContext())
            {

                var result = from d in context.Diplomalar
                             join u in context.Universiteler
                             on d.UniversiteId equals u.UniversiteId

                             join b in context.Bolumler
                             on d.BolumId equals b.BolumId

                             join k in context.Kullanıcılar
                             on d.KullaniciId equals k.KullaniciId

                             select new DiplomaDetailDto
                             {
                                 DiplomaNumarasi=d.DiplomaNumarasi,
                                 DiplomaNot=d.DiplomaNot,
                                 MezuniyetTarihi=d.MezuniyetTarihi,
                                 universite=u,
                                 bolum=b,
                                 kullanici=k,
                                 TCKimlikNo = d.TCKimlikNo
                             };
                return result.ToList();

            }

        }


    }
}
