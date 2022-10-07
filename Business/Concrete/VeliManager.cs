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
    public class VeliManager : IVeliService
    {
        IVeliDal _veliDal;


        public VeliManager(IVeliDal veliDal)
        {
            _veliDal = veliDal;
        }
        //  [LogAspect]  AOP  Bir metodun önünde bir metodun sonunda bir metod hata verdiğinde çalışan kod parçacıklarını AOP ile yazılır yani Busine içinde busines yazılımı.
        [ValidationAspect(typeof(VeliValidator))]
        public IResult Add(Veli veli)
        {
            _veliDal.Add(veli);
            return new Result(true, Messages.ProductAdded);
        }

        public IDataResult<List<Veli>> GetAll()
        {

            return new SuccessDataResult<List<Veli>>(_veliDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<VeliDetailDto>> GetVeliDetails()
        {
            throw new NotImplementedException();
        }





        public IDataResult<Veli> GetById(int veliId)
        {
            return new SuccessDataResult<Veli>(_veliDal.Get(p => p.VeliId == veliId));
        }




    }
}
