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
    public class SoruHavuzManager : ISoruHavuzService
    {
        ISoruHavuzDal _havuzDal;


        public SoruHavuzManager(ISoruHavuzDal havuzDal)
        {
            _havuzDal = havuzDal;
        }

        [ValidationAspect(typeof(SoruHavuzValidator))]
        public IResult Add(SoruHavuz havuz)
        {

            _havuzDal.Add(havuz);
            return new Result(true, Messages.RecordCreated);
        }

        public IDataResult<List<SoruHavuz>> GetAll()
        {

            return new SuccessDataResult<List<SoruHavuz>>(_havuzDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<SoruHavuz> GetById(int havuzId)
        {
            return new SuccessDataResult<SoruHavuz>(_havuzDal.Get(p => p.HavuzId == havuzId));
        }


        public IDataResult<List<SoruHavuzDetailDto>> GetSoruHavuzDetails(int dersId = -1)
        {

            return new SuccessDataResult<List<SoruHavuzDetailDto>>(_havuzDal.GetSoruHavuzDetails(dersId));
        }
    }
}
