using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ISoruDal : IEntityRepository<Soru>
    {
        List<SoruDetailDto> GetSoruDetails();
        List<Soru> GetYanitlananSorular(int kullaniciId, int dersId, int ogretmenId);
        List<Soru> GetKullaniciSorular(int kullaniciId, int dersId);
    }
}