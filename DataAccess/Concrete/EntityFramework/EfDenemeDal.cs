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
    public class EfDenemeDal : EfEntityRepositoryBase<Deneme, DeveloperStudentContext>, IDenemeDal
    {
        public List<DenemeDetailDto> GetDenemeDetails(int DenemeId = -1)
        {
            using (DeveloperStudentContext context = new DeveloperStudentContext())
            {


                var result = from d in context.Denemeler
                             join k in context.Kullanıcılar
                             on d.KullaniciId equals k.KullaniciId

                             join u in context.Unvan
                             on k.UnvanId equals u.UnvanId

                             join s in context.Sehirler
                             on k.SehirId equals s.SehirId

                             join a in context.Alanlar
                             on k.AlanId equals a.AlanId

                             join b in context.Bolumler
                             on k.BolumId equals b.BolumId

                             join l in context.Liseler
                             on k.LiseId equals l.LiseId

                             join us in context.Universiteler
                             on k.UniversiteId equals us.UniversiteId

                             join sf in context.Sınıf
                             on k.SınıfId equals sf.SınıfId

                             join v in context.Veliler
                             on k.VeliId equals v.VeliId

                             join uniSehir in context.Sehirler
                             on us.SehirId equals uniSehir.SehirId

                             join liseSehir in context.Sehirler
                             on l.SehirId equals liseSehir.SehirId

                             select new DenemeDetailDto
                             {
                                 AYTNet = d.AYTNet,
                                 DenemeAdi = d.DenemeAdi,
                                 DenemeId = d.DenemeId,
                                 DilNet = d.DilNet,
                                 kullanici = new KullaniciDetailDto {
                                     KullaniciId = k.KullaniciId,
                                     Ad = k.Ad,
                                     Soyad = k.Soyad,
                                     Sifre = k.Sifre,
                                     Eposta = k.Eposta,
                                     Yas = k.Yas,
                                     unvan = u,
                                     sehir = new SehirDetailDto
                                     {
                                         SehirAdi = s.SehirAdi,
                                         SehirId = s.SehirId
                                     },
                                     sınıf = sf,
                                     alan = a,
                                     bolum = b,
                                     lise = new LiseDetailDto
                                     {
                                         LiseAdi = l.LiseAdi,
                                         LiseId = l.LiseId,
                                         sehir = new SehirDetailDto
                                         {
                                             SehirAdi = liseSehir.SehirAdi,
                                             SehirId = liseSehir.SehirId
                                         }
                                     },
                                     TelefonNo = k.TelefonNo,
                                     universite = new UniversiteDetailDto
                                     {
                                         UniTur = us.UniTur,
                                         UniversiteAdi = us.UniversiteAdi,
                                         UniversiteId = us.UniversiteId,
                                         sehir = new SehirDetailDto
                                         {
                                             SehirAdi = uniSehir.SehirAdi,
                                             SehirId = uniSehir.SehirId
                                         }
                                     },
                                     veli = v
                                 },
                                 Puan = d.Puan,
                                 Tarih = d.Tarih,
                                 TYTNet = d.TYTNet
                             };
                return result.ToList();

            }

        }


    }
}