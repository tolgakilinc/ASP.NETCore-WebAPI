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
    public class UnvanManager : IUnvanService
    {
        IUnvanDal _unvanDal;


        public UnvanManager(IUnvanDal unvanDal)
        {
            _unvanDal = unvanDal;
        }
        //  [LogAspect]  AOP  Bir metodun önünde bir metodun sonunda bir metod hata verdiğinde çalışan kod parçacıklarını AOP ile yazılır yani Busine içinde busines yazılımı.
        [ValidationAspect(typeof(UnvanValidator))]
        public IResult Add(Unvan unvan)
        {
            //business codes
            //validation
            /*    ValidationTool.Validate(new ProductValidator(), product); -> if (product.ProductName.Length < 2)
                {
                    //magic strings -> ayrı ayrı string gerçekleşmesi
                    return new ErrorResult(Messages.ProductNameInvalid);
                }
                */

            _unvanDal.Add(unvan);
            return new Result(true, Messages.ProductAdded);
        }

        public IDataResult<List<Unvan>> GetAll()
        {
            //iş kodları 
            //if (DateTime.Now.Hour==1)
            //{
            //    return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            //}

            return new SuccessDataResult<List<Unvan>>(_unvanDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<UnvanDetailDto>> GetUnvanDetails()
        {
            throw new NotImplementedException();
        }



        //public IDataResult<List<Unvan>> GetAllByCategoryId(int id)
        //{
        //    return new SuccessDataResult<List<Unvan>>(_unvanDal.GetAll(p => p.CategoryId == id));
        //}

        public IDataResult<Unvan> GetById(int unvanId)
        {
            return new SuccessDataResult<Unvan>(_unvanDal.Get(p => p.UnvanId == unvanId));
        }

        //public IDataResult<List<Unvan>> GetByUnitPrice(decimal min, decimal max)
        //{
        //    return new SuccessDataResult<List<Unvan>>(_unvanDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        //}


    }
}
