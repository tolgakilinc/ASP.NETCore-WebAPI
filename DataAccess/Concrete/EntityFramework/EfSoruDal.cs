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
    public class EfSoruDal : EfEntityRepositoryBase<Soru, DeveloperStudentContext>, ISoruDal
    {
        public List<SoruDetailDto> GetSoruDetails()
        {
            using (DeveloperStudentContext context = new DeveloperStudentContext())
            {

                var result = from soru in context.Soru
                             join k in context.Kullanıcılar
                             on soru.KullaniciId equals k.KullaniciId

                             join d in context.Dersler
                             on soru.DersId equals d.DersId

                             join dersKategori in context.DersKategori
                             on d.DersKategoriId equals dersKategori.DersKategoriId


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

                             select new SoruDetailDto
                             {
                                 SoruId = soru.SoruId,
                                 Baslik = soru.Baslik,
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
                                 ders = new DersDetailDto { 
                                     DersAdi = d.DersAdi,
                                     DersId = d.DersId,
                                     dersKategori = new DersKategori
                                     {
                                         DersKategoriId = dersKategori.DersKategoriId,
                                         DersKategorisi = dersKategori.DersKategorisi
                                     }
                                 },
                                 Aciklama = soru.Aciklama,
                             };
                return result.ToList();

            }

        }
        
        public List<Soru> GetYanitlananSorular(int kullaniciId, int dersId, int ogretmenId = -1)
        {
            using (DeveloperStudentContext context = new DeveloperStudentContext())
            {
                var result = from soru in context.Soru
                             join kullanici in context.Kullanıcılar
                             on soru.KullaniciId equals kullanici.KullaniciId
                             join soruYanit in context.SoruYanit
                             on soru.SoruId equals soruYanit.SoruId
                             where kullaniciId == -1 ? true : kullaniciId == kullanici.KullaniciId
                             where ogretmenId == -1 ? true : soruYanit.KullaniciId == ogretmenId
                             where dersId == soru.DersId
                             select new Soru
                             {
                                 Aciklama = soru.Aciklama,
                                 KullaniciId = kullanici.KullaniciId,
                                 SoruId = soru.SoruId,
                                 Baslik = soru.Baslik,
                                 DersId = soru.DersId
                             };

                return result.ToList();
            }
        }

        public List<Soru> GetKullaniciSorular(int kullaniciId, int dersId)
        {
            using (DeveloperStudentContext context = new DeveloperStudentContext())
            {
                var result = from soru in context.Soru
                             join kullanici in context.Kullanıcılar
                             on soru.KullaniciId equals kullanici.KullaniciId
                             where kullaniciId == -1 ? true : kullaniciId == kullanici.KullaniciId
                             where dersId == soru.DersId
                             select new Soru
                             {
                                 Aciklama = soru.Aciklama,
                                 KullaniciId = kullanici.KullaniciId,
                                 SoruId = soru.SoruId,
                                 Baslik = soru.Baslik,
                                 DersId = soru.DersId
                             };

                return result.ToList();
            }
        }


    }
}
