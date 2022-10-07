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
    public class SınıfManager : ISınıfService
    {
        ISınıfDal _sınıfDal;


        public SınıfManager(ISınıfDal sınıfDal)
        {
            _sınıfDal = sınıfDal;
        }
        //  [LogAspect]  AOP  Bir metodun önünde bir metodun sonunda bir metod hata verdiğinde çalışan kod parçacıklarını AOP ile yazılır yani Busine içinde busines yazılımı.
        [ValidationAspect(typeof(SınıfValidator))]
        public IResult Add(Sınıf sınıf)
        {
            //business codes
            //validation
            /*    ValidationTool.Validate(new ProductValidator(), product); -> if (product.ProductName.Length < 2)
                {
                    //magic strings -> ayrı ayrı string gerçekleşmesi
                    return new ErrorResult(Messages.ProductNameInvalid);
                }
                */

            _sınıfDal.Add(sınıf);
            return new Result(true, Messages.ProductAdded);
        }

        public IDataResult<List<Sınıf>> GetAll()
        {
            //iş kodları 
            //if (DateTime.Now.Hour==1)
            //{
            //    return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            //}

            return new SuccessDataResult<List<Sınıf>>(_sınıfDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<SınıfDetailDto>> GetSınıfDetails()
        {
            throw new NotImplementedException();
        }



        //public IDataResult<List<Sınıf>> GetAllByCategoryId(int id)
        //{
        //    return new SuccessDataResult<List<Sınıf>>(_sınıfDal.GetAll(p => p.CategoryId == id));
        //}

        public IDataResult<Sınıf> GetById(int sınıfId)
        {
            return new SuccessDataResult<Sınıf>(_sınıfDal.Get(p => p.SınıfId == sınıfId));
        }

        //public IDataResult<List<Sınıf>> GetByUnitPrice(decimal min, decimal max)
        //{
        //    return new SuccessDataResult<List<Sınıf>>(_sınıfDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        //}


    }
}
