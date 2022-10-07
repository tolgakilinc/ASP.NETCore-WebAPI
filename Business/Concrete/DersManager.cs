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
    public class DersManager : IDersService
    {
        IDersDal _dersDal;


        public DersManager(IDersDal dersDal)
        {
            _dersDal = dersDal;
        }

        [ValidationAspect(typeof(DersValidator))]
        public IResult Add(Ders ders)
        {

            _dersDal.Add(ders);
            return new Result(true, Messages.RecordCreated);
        }

        public IDataResult<List<DersDetailDto>> GetDersDetails()
        {

            return new SuccessDataResult<List<DersDetailDto>>(_dersDal.GetDersDetails(), Messages.ProductListed);
        }

        public IDataResult<Ders> GetById(int dersId)
        {
            return new SuccessDataResult<Ders>(_dersDal.Get(p => p.DersId == dersId));
        }


      
    }
}
