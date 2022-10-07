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
    public class DiplomaManager : IDiplomaService
    {
        IDiplomaDal _diplomaDal;


        public DiplomaManager(IDiplomaDal kullaniciDal)
        {
            _diplomaDal = kullaniciDal;
        }

        [ValidationAspect(typeof(DiplomaValidator))]
        public IResult Add(Diploma diploma)
        {

            _diplomaDal.Add(diploma);
            return new Result(true, Messages.RecordCreated);
        }

        public IDataResult<List<Diploma>> GetAll()
        {

            return new SuccessDataResult<List<Diploma>>(_diplomaDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<Diploma> GetById(int diplomaId)
        {
            return new SuccessDataResult<Diploma>(_diplomaDal.Get(p => p.DiplomaNumarasi == diplomaId));
        }


        public IDataResult<List<DiplomaDetailDto>> GetDiplomaDetails()
        {

            return new SuccessDataResult<List<DiplomaDetailDto>>(_diplomaDal.GetDiplomaDetails());
        }
    }
}
