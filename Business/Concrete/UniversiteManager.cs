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
    public class UniversiteManager : IUniversiteService
    {
        IUniversiteDal _universiteDal;


        public UniversiteManager(IUniversiteDal universiteDal)
        {
            _universiteDal = universiteDal;
        }

        [ValidationAspect(typeof(UniversiteValidator))]
        public IResult Add(Universite universite)
        {

            _universiteDal.Add(universite);
            return new Result(true, Messages.RecordCreated);
        }

        public IDataResult<List<Universite>> GetAll()
        {

            return new SuccessDataResult<List<Universite>>(_universiteDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<Universite> GetById(int universiteId)
        {
            return new SuccessDataResult<Universite>(_universiteDal.Get(p => p.UniversiteId == universiteId));
        }


        public IDataResult<List<UniversiteDetailDto>> GetUniversiteDetails()
        {

            return new SuccessDataResult<List<UniversiteDetailDto>>(_universiteDal.GetUniversiteDetails());
        }
    }
}
