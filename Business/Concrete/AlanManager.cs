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
    public class AlanManager : IAlanService
    {
        IAlanDal _alanDal;


        public AlanManager(IAlanDal alanDal)
        {
            _alanDal = alanDal;
        }
        //  [LogAspect]  AOP  Bir metodun önünde bir metodun sonunda bir metod hata verdiğinde çalışan kod parçacıklarını AOP ile yazılır yani Busine içinde busines yazılımı.
        [ValidationAspect(typeof(AlanValidator))]
        public IResult Add(Alan alan)
        {
            //business codes
            //validation
            /*    ValidationTool.Validate(new ProductValidator(), product); -> if (product.ProductName.Length < 2)
                {
                    //magic strings -> ayrı ayrı string gerçekleşmesi
                    return new ErrorResult(Messages.ProductNameInvalid);
                }
                */

            _alanDal.Add(alan);
            return new Result(true, Messages.ProductAdded);
        }

        public IDataResult<List<Alan>> GetAll()
        {
            //iş kodları 
            //if (DateTime.Now.Hour==1)
            //{
            //    return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            //}

            return new SuccessDataResult<List<Alan>>(_alanDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<AlanDetailDto>> GetAlanDetails()
        {
            throw new NotImplementedException();
        }



        //public IDataResult<List<Alan>> GetAllByCategoryId(int id)
        //{
        //    return new SuccessDataResult<List<Alan>>(_alanDal.GetAll(p => p.CategoryId == id));
        //}

        public IDataResult<Alan> GetById(int alanId)
        {
            return new SuccessDataResult<Alan>(_alanDal.Get(p => p.AlanId == alanId));
        }

        //public IDataResult<List<Alan>> GetByUnitPrice(decimal min, decimal max)
        //{
        //    return new SuccessDataResult<List<Alan>>(_alanDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        //}


    }
}
