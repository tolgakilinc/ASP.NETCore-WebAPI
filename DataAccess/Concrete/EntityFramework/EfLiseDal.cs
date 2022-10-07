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
    public class EfLiseDal : EfEntityRepositoryBase<Lise, DeveloperStudentContext>, ILiseDal
    {
        public List<LiseDetailDto> GetLiseDetails()
        {
            using (DeveloperStudentContext context = new DeveloperStudentContext())
            {

                var result = from l in context.Liseler
                             join s in context.Sehirler
                             on l.SehirId equals s.SehirId

                             select new LiseDetailDto
                             {
                                 LiseId = l.LiseId,
                                 LiseAdi = l.LiseAdi,
                                 sehir = new SehirDetailDto
                                 { 
                                     SehirId = s.SehirId,
                                     SehirAdi = s.SehirAdi
                                 },
                                
                             };
                return result.ToList();

            }

        }


    }
}
