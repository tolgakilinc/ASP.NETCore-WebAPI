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
   public class EfKullaniciDal : EfEntityRepositoryBase<Kullanici, DeveloperStudentContext>, IKullaniciDal
    { 
        public List<KullaniciDetailDto> GetKullaniciDetails(int kullaniciId = -1)
        {
            using (DeveloperStudentContext context = new DeveloperStudentContext())
            {

                var result = from k in context.Kullanıcılar
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

                             where kullaniciId == -1 ? true : k.KullaniciId == kullaniciId
                             
                             select new KullaniciDetailDto
                             {
                                 KullaniciId = k.KullaniciId,
                                 Ad = k.Ad,
                                 Soyad = k.Soyad,
                                 Sifre = k.Sifre,
                                 Eposta = k.Eposta,
                                 Yas = k.Yas,
                                 unvan = u,
                                 sehir = new SehirDetailDto { 
                                     SehirAdi = s.SehirAdi,
                                     SehirId = s.SehirId
                                 },
                                 sınıf=sf,
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
                                 universite = new UniversiteDetailDto { 
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
                             };

                return result.ToList();

            }

        }

        public List<KullaniciDetailDto> userLog(string email, string password)
        {
            using (DeveloperStudentContext context = new DeveloperStudentContext())
            {

                var result = from k in context.Kullanıcılar
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

                             where k.Eposta == email && k.Sifre == password

                             select new KullaniciDetailDto
                             {
                                 KullaniciId = k.KullaniciId,
                                 Ad = k.Ad,
                                 Soyad = k.Soyad,
                                 Sifre = k.Sifre,
                                 Eposta = k.Eposta,
                                 Yas = k.Yas,
                                 unvan = u,
                                 sehir = new SehirDetailDto {SehirAdi = s.SehirAdi, SehirId = s.SehirId},
                                 sınıf = sf,
                                 alan = a,
                                 bolum = b,
                                 lise = new LiseDetailDto { 
                                     LiseAdi = l.LiseAdi,
                                     LiseId = l.LiseId,
                                     sehir = new SehirDetailDto { 
                                         SehirAdi = liseSehir.SehirAdi,
                                         SehirId = liseSehir.SehirId
                                     }
                                 },
                                 TelefonNo = k.TelefonNo,
                                 universite = new UniversiteDetailDto {
                                     sehir = new SehirDetailDto { 
                                         SehirId = uniSehir.SehirId,
                                         SehirAdi = uniSehir.SehirAdi
                                     },
                                     UniTur = us.UniTur,
                                     UniversiteAdi = us.UniversiteAdi,
                                     UniversiteId = us.UniversiteId
                                 },
                                 veli = v
                             };

                return result.ToList();

            }

        }

      


        public List<KullaniciDetailDto> update(Kullanici kullanici)
        {
            using (DeveloperStudentContext context = new DeveloperStudentContext())
            {

                var result = from k in context.Kullanıcılar
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

                            

                             select new KullaniciDetailDto
                             {
                                 KullaniciId = k.KullaniciId,
                                 Ad = k.Ad,
                                 Soyad = k.Soyad,
                                 Sifre = k.Sifre,
                                 Eposta = k.Eposta,
                                 Yas = k.Yas,
                                 unvan = u,
                                 sehir = new SehirDetailDto { SehirAdi = s.SehirAdi, SehirId = s.SehirId },
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
                                     sehir = new SehirDetailDto
                                     {
                                         SehirId = uniSehir.SehirId,
                                         SehirAdi = uniSehir.SehirAdi
                                     },
                                     UniTur = us.UniTur,
                                     UniversiteAdi = us.UniversiteAdi,
                                     UniversiteId = us.UniversiteId
                                 },
                                 veli = v
                             };

                return result.ToList();

            }

        }
        public List<KullaniciDetailDto> Login(string email, string password)
        {
            return userLog(email, password);
        }

        
    }
}
