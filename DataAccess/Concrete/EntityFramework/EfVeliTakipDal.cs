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
    public class EfVeliTakipDal : EfEntityRepositoryBase<VeliTakip, DeveloperStudentContext>, IVeliTakipDal
    {
        public List<VeliTakipDetailDto> GetVeliTakipDetails()
        {
            using (DeveloperStudentContext context = new DeveloperStudentContext())
            {

                var result = from vk in context.VeliKontrol
                             join v in context.Veliler
                             on vk.VeliId equals v.VeliId


                             select new VeliTakipDetailDto
                             {

                                 VeliTakipId = vk.VeliTakipId,
                                 veli = v,
                                 Tarih = vk.Tarih,
                                 KullanilanSure = vk.KullanilanSure,





                             };
                return result.ToList();

            }

        }


    }
}
