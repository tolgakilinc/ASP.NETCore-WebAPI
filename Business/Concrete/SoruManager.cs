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
    public class SoruManager : ISoruService
    {
        ISoruDal _soruDal;


        public SoruManager(ISoruDal soruDal)
        {
            _soruDal = soruDal;
        }

        [ValidationAspect(typeof(SoruValidator))]
        public IResult Add(Soru soru)
        {

            _soruDal.Add(soru);
            return new Result(true, Messages.RecordCreated);
        }

        public IDataResult<List<Soru>> GetAll()
        {

            return new SuccessDataResult<List<Soru>>(_soruDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<Soru> GetById(int soruId)
        {
            return new SuccessDataResult<Soru>(_soruDal.Get(p => p.SoruId == soruId));
        }

        public IDataResult<List<Soru>> GetKullaniciSorular(int kullaniciId, int dersId)
        {
            return new SuccessDataResult<List<Soru>>(_soruDal.GetKullaniciSorular(kullaniciId, dersId), Messages.ProductListed);
        }

        public IDataResult<List<SoruDetailDto>> GetSoruDetails()
        {

            return new SuccessDataResult<List<SoruDetailDto>>(_soruDal.GetSoruDetails());
        }

        public IDataResult<List<Soru>> GetYanitlananSorular(int kullaniciId, int dersId, int ogretmenId)
        {
            return new SuccessDataResult<List<Soru>>(_soruDal.GetYanitlananSorular(kullaniciId, dersId, ogretmenId), Messages.ProductListed);
        }
    }
}
