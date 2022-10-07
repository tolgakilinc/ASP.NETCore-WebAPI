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
    public class LiseManager : ILiseService
    {
        ILiseDal _liseDal;


        public LiseManager(ILiseDal liseDal)
        {
            _liseDal = liseDal;
        }

        [ValidationAspect(typeof(LiseValidator))]
        public IResult Add(Lise lise)
        {

            _liseDal.Add(lise);
            return new Result(true, Messages.RecordCreated);
        }

        public IDataResult<List<Lise>> GetAll()
        {

            return new SuccessDataResult<List<Lise>>(_liseDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<Lise> GetById(int liseId)
        {
            return new SuccessDataResult<Lise>(_liseDal.Get(p => p.LiseId == liseId));
        }


        public IDataResult<List<LiseDetailDto>> GetLiseDetails()
        {

            return new SuccessDataResult<List<LiseDetailDto>>(_liseDal.GetLiseDetails());
        }
    }
}
