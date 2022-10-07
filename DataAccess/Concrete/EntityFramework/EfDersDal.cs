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
    public class EfDersDal : EfEntityRepositoryBase<Ders, DeveloperStudentContext>, IDersDal
    {
        public List<DersDetailDto> GetDersDetails()
        {
            using (DeveloperStudentContext context = new DeveloperStudentContext())
            {

                var result = from d in context.Dersler
                             join dk in context.DersKategori
                             on d.DersKategoriId equals dk.DersKategoriId

                             select new DersDetailDto
                             {
                              DersId = d.DersId,
                              DersAdi=d.DersAdi,
                              dersKategori=dk,


                             };
                return result.ToList();

            }

        }


    }
}
