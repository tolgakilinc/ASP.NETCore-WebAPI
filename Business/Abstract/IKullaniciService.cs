using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKullaniciService
    {
        IDataResult<List<Kullanici>> GetAll();
        IDataResult<List<KullaniciDetailDto>> GetKullaniciDetails();
        IDataResult<List<KullaniciDetailDto>> Login(string email, string password);
        IDataResult<List<KullaniciDetailDto>> GetById(int kullaniciId);
        IResult Add(Kullanici kullanici); //IResult voidler için kullandık
        IResult Update(Kullanici kullanici);
    }
}