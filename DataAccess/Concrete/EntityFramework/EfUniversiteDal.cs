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
    public class EfUniversiteDal : EfEntityRepositoryBase<Universite, DeveloperStudentContext>, IUniversiteDal
    {
        public List<UniversiteDetailDto> GetUniversiteDetails()
        {
            using (DeveloperStudentContext context = new DeveloperStudentContext())
            {

                var result = from u in context.Universiteler
                             join s in context.Sehirler
                             on u.SehirId equals s.SehirId



                             select new UniversiteDetailDto
                             {
                                 UniversiteId=u.UniversiteId,
                                 UniversiteAdi=u.UniversiteAdi,
                                 UniTur=u.UniTur,
                                 sehir= new SehirDetailDto{ 
                                     SehirId = s.SehirId,
                                     SehirAdi = s.SehirAdi
                                 },


                             };
                return result.ToList();

            }

        }


    }
}
