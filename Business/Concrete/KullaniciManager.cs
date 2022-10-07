using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDal _kullaniciDal;


        public KullaniciManager(IKullaniciDal  kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }
       
        [ValidationAspect(typeof(KullaniciValidator))]
        public IResult Add(Kullanici kullanici)
        {
            _kullaniciDal.Add(kullanici);


            return new Result(true, Messages.RecordCreated);
        }

        public IResult Update(Kullanici kullanici)
        {
            _kullaniciDal.Update(kullanici);
            return new Result(true, Messages.RecordCreated);
        }

        public IDataResult<List<Kullanici>> GetAll()
        {
            return new SuccessDataResult<List<Kullanici>>(_kullaniciDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<KullaniciDetailDto>> GetById(int kullaniciId)
        {
            return new SuccessDataResult<List<KullaniciDetailDto>>(_kullaniciDal.GetKullaniciDetails(kullaniciId));
        }

     
        public IDataResult<List<KullaniciDetailDto>> GetKullaniciDetails()
        {

            return new SuccessDataResult<List<KullaniciDetailDto>>(_kullaniciDal.GetKullaniciDetails());
        }

        public IDataResult<List<KullaniciDetailDto>> Login(string email, string password)
        {
            var result = new SuccessDataResult<List<KullaniciDetailDto>>(_kullaniciDal.Login(email, password));

            if (result == null || result.Data.Count != 0)
            {
                return result;
            }
            else
            {
                return new ErrorDataResult<List<KullaniciDetailDto>>("kullanıcı adı şifre yanlış");
            }
        }

       
    }
}
