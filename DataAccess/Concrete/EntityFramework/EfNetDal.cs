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
    public class EfNetDal : EfEntityRepositoryBase<Net, DeveloperStudentContext>, INetDal
    {
        public List<NetDetailDto> GetNetDetails()
        {
            using (DeveloperStudentContext context = new DeveloperStudentContext())
            {

                var result = from n in context.Netler
                             join d in context.Dersler
                             on n.DersId equals d.DersId

                             join dersKategori in context.DersKategori
                             on d.DersKategoriId equals dersKategori.DersKategoriId

                             select new NetDetailDto
                             {
                                 NetId=n.NetId,
                                 ders= new DersDetailDto { 
                                     dersKategori = dersKategori,
                                     DersAdi = d.DersAdi,
                                     DersId = d.DersId                                     
                                 },
                                 DogruSayisi=n.DogruSayisi,
                                 YanlisSayisi=n.YanlisSayisi,
                                 NetSayisi=n.NetSayisi,
                             };

                return result.ToList();

            }

        }


    }
}
