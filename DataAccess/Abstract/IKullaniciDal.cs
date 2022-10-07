using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IKullaniciDal : IEntityRepository<Kullanici>
    {
        List<KullaniciDetailDto> GetKullaniciDetails(int kullaniciId = -1);
        List<KullaniciDetailDto> Login(string email, string password);
    }
}