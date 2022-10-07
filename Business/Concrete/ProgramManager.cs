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
    public class ProgramManager : IProgramService
    {
        IProgramDal _programDal;


        public ProgramManager(IProgramDal programDal)
        {
            _programDal = programDal;
        }

        [ValidationAspect(typeof(ProgramValidator))]
        public IResult Add(Program program)
        {
            _programDal.Add(program);
            return new Result(true, Messages.ProductAdded);
        }

        public IDataResult<List<Program>> GetAll()
        {
            return new SuccessDataResult<List<Program>>(_programDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<ProgramDetailDto>> GetProgramDetails()
        {
            return new SuccessDataResult<List<ProgramDetailDto>>(_programDal.GetProgramDetails(), Messages.ProductListed);
        }

        public IDataResult<Program> GetById(int programId)
        {
            return new SuccessDataResult<Program>(_programDal.Get(p => p.ProgramId == programId));
        }

        public IDataResult<List<ProgramDetailDto>> GetUserProgramWithDate(int userId, string date)
        {
            return new SuccessDataResult<List<ProgramDetailDto>>(_programDal.GetUserProgramWithDate(userId, date), Messages.ProductListed);

        }

        public IResult Delete(Program program)
        {
            _programDal.Delete(program);
            return new Result(true, Messages.ProductAdded);
        }
    }
}
