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
    public class DenemeManager : IDenemeService
    {
        IDenemeDal _denemeDal;


        public DenemeManager(IDenemeDal denemeDal)
        {
            _denemeDal = denemeDal;
        }
        //  [LogAspect]  AOP  Bir metodun önünde bir metodun sonunda bir metod hata verdiğinde çalışan kod parçacıklarını AOP ile yazılır yani Busine içinde busines yazılımı.
        [ValidationAspect(typeof(DenemeValidator))]
        public IResult Add(Deneme deneme)
        {
            //business codes
            //validation
            /*    ValidationTool.Validate(new ProductValidator(), product); -> if (product.ProductName.Length < 2)
                {
                    //magic strings -> ayrı ayrı string gerçekleşmesi
                    return new ErrorResult(Messages.ProductNameInvalid);
                }
                */

            _denemeDal.Add(deneme);
            return new Result(true, Messages.ProductAdded);
        }

        public IDataResult<List<Deneme>> GetAll()
        {
            //iş kodları 
            //if (DateTime.Now.Hour==1)
            //{
            //    return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            //}

            return new SuccessDataResult<List<Deneme>>(_denemeDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<DenemeDetailDto>> GetDenemeDetails()
        {
            return new SuccessDataResult<List<DenemeDetailDto>>(_denemeDal.GetDenemeDetails(), Messages.ProductListed);
        }



        //public IDataResult<List<Deneme>> GetAllByCategoryId(int id)
        //{
        //    return new SuccessDataResult<List<Deneme>>(_denemeDal.GetAll(p => p.CategoryId == id));
        //}

        public IDataResult<Deneme> GetById(int denemeId)
        {
            return new SuccessDataResult<Deneme>(_denemeDal.Get(p => p.DenemeId == denemeId));
        }

        //public IDataResult<List<Deneme>> GetByUnitPrice(decimal min, decimal max)
        //{
        //    return new SuccessDataResult<List<Deneme>>(_DenemeDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        //}

        public IResult Delete(Deneme deneme)
        {
            _denemeDal.Delete(deneme);
            return new Result(true, Messages.ProductAdded);
        }
    }
}
