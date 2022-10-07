using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfProgramDal : EfEntityRepositoryBase<Program, DeveloperStudentContext>, IProgramDal
    {
        public List<ProgramDetailDto> initQuery(int userId = -1, string date = "")
        {
            using (DeveloperStudentContext context = new DeveloperStudentContext())
            {
                DateTime test = DateTime.Now;
                if (date!= "")
                {
                    test = DateTime.ParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                }
                var result = from p in context.Program
                             join k in context.Kullanıcılar
                             on p.KullaniciId equals k.KullaniciId



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

                             where userId == -1 ? true : k.KullaniciId == userId
                             where date == "" ? true : p.Tarih == test

                             select new ProgramDetailDto
                             {
                                 ProgramId = p.ProgramId,
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
                                 ProgramAdi = p.ProgramAdi,
                                 Tarih = p.Tarih,
                                 Icerik = p.Icerik,
                                 baslangicTarih = p.baslangicTarih,
                                 bitisTarih = p.bitisTarih
                             };

                return result.ToList();

            }

        }

        public List<ProgramDetailDto> GetProgramDetails()
        {
            return initQuery();
        }

        public List<ProgramDetailDto> GetUserProgramWithDate(int userId, string date)
        {
            return initQuery(userId, date);
        }
    }
}
