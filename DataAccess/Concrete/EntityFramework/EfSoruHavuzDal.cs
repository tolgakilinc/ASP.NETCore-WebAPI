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
    public class EfSoruHavuzDal : EfEntityRepositoryBase<SoruHavuz, DeveloperStudentContext>, ISoruHavuzDal
    {
        public List<SoruHavuzDetailDto> GetSoruHavuzDetails(int dersId = -1)
        {
            using (DeveloperStudentContext context = new DeveloperStudentContext())
            {

                var result = from sh in context.SoruHavuz
                             join soru in context.Soru
                             on sh.SoruId equals soru.SoruId

                             join sy in context.SoruYanit
                             on sh.SoruId equals sy.SoruId
                             
                             join st in context.DersKategori
                             on sh.DersKategoriId equals st.DersKategoriId

                             join k in context.Kullanıcılar
                             on soru.KullaniciId equals k.KullaniciId

                             join ders in context.Dersler
                             on soru.DersId equals ders.DersId

                             join ogretmen in context.Kullanıcılar
                             on sy.KullaniciId equals ogretmen.KullaniciId

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

                             join dersKategori in context.DersKategori
                             on ders.DersKategoriId equals dersKategori.DersKategoriId

                             /**/

                            join u1 in context.Unvan
                            on ogretmen.UnvanId equals u1.UnvanId

                             join s1 in context.Sehirler
                             on ogretmen.SehirId equals s1.SehirId

                             join a1 in context.Alanlar
                             on ogretmen.AlanId equals a1.AlanId

                             join b1 in context.Bolumler
                             on ogretmen.BolumId equals b1.BolumId

                             join l1 in context.Liseler
                             on ogretmen.LiseId equals l1.LiseId

                             join us1 in context.Universiteler
                             on ogretmen.UniversiteId equals us1.UniversiteId

                             join sf1 in context.Sınıf
                             on ogretmen.SınıfId equals sf1.SınıfId

                             join v1 in context.Veliler
                             on ogretmen.VeliId equals v1.VeliId

                             join uniSehir1 in context.Sehirler
                             on us.SehirId equals uniSehir1.SehirId

                             join liseSehir1 in context.Sehirler
                             on l.SehirId equals liseSehir1.SehirId

                             where dersId == -1 ? true : ders.DersId == dersId

                             select new SoruHavuzDetailDto
                             {
                               HavuzId=sh.HavuzId,
                               soru = new SoruDetailDto {
                                   Aciklama = soru.Aciklama,
                                   Baslik = soru.Baslik,
                                   SoruId = soru.SoruId,
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
                                   ders = new DersDetailDto
                                   {
                                       DersAdi = ders.DersAdi,
                                       DersId = ders.DersId,
                                       dersKategori = new DersKategori
                                       {
                                           DersKategoriId = dersKategori.DersKategoriId,
                                           DersKategorisi = dersKategori.DersKategorisi
                                       }
                                   }
                               },
                               soruYanit= new SoruYanitDetailDto {
                                   soru = soru,
                                   kullanici = new KullaniciDetailDto {
                                       KullaniciId = ogretmen.KullaniciId,
                                       Ad = ogretmen.Ad,
                                       Soyad = ogretmen.Soyad,
                                       Sifre = ogretmen.Sifre,
                                       Eposta = ogretmen.Eposta,
                                       Yas = ogretmen.Yas,
                                       unvan = u1,
                                       sehir = new SehirDetailDto
                                       {
                                           SehirAdi = s1.SehirAdi,
                                           SehirId = s1.SehirId
                                       },
                                       sınıf = sf1,
                                       alan = a1,
                                       bolum = b1,
                                       lise = new LiseDetailDto
                                       {
                                           LiseAdi = l1.LiseAdi,
                                           LiseId = l1.LiseId,
                                           sehir = new SehirDetailDto
                                           {
                                               SehirAdi = liseSehir1.SehirAdi,
                                               SehirId = liseSehir1.SehirId
                                           }
                                       },
                                       TelefonNo = ogretmen.TelefonNo,
                                       universite = new UniversiteDetailDto
                                       {
                                           UniTur = us1.UniTur,
                                           UniversiteAdi = us1.UniversiteAdi,
                                           UniversiteId = us1.UniversiteId,
                                           sehir = new SehirDetailDto
                                           {
                                               SehirAdi = uniSehir1.SehirAdi,
                                               SehirId = uniSehir1.SehirId
                                           }
                                       },
                                       veli = v1
                                   },
                                   SoruYanitId = sy.SoruYanitId,
                                   Yanit = sy.Yanit
                               },
                               dersKategori= new DersKategoriDetailDto
                               {
                                   DersKategoriId = dersKategori.DersKategoriId,
                                   DersKategorisi = dersKategori.DersKategorisi
                               },
                             };
                return result.ToList();

            }

        }


    }
}
