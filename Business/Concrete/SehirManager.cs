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
    public class SehirManager : ISehirService
    {
        ISehirDal _sehirDal;


        public SehirManager(ISehirDal sehirDal)
        {
            _sehirDal = sehirDal;
        }
        //  [LogAspect]  AOP  Bir metodun önünde bir metodun sonunda bir metod hata verdiğinde çalışan kod parçacıklarını AOP ile yazılır yani Busine içinde busines yazılımı.
        [ValidationAspect(typeof(SehirValidator))]
        public IResult Add(Sehir sehir)
        {
            //business codes
            //validation
            /*    ValidationTool.Validate(new ProductValidator(), product); -> if (product.ProductName.Length < 2)
                {
                    //magic strings -> ayrı ayrı string gerçekleşmesi
                    return new ErrorResult(Messages.ProductNameInvalid);
                }
                */

            _sehirDal.Add(sehir);
            return new Result(true, Messages.ProductAdded);
        }

        public IDataResult<List<Sehir>> GetAll()
        {
            //iş kodları 
            //if (DateTime.Now.Hour==1)
            //{
            //    return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            //}

            return new SuccessDataResult<List<Sehir>>(_sehirDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<SehirDetailDto>> GetSehirDetails()
        {
            throw new NotImplementedException();
        }



        //public IDataResult<List<Sehir>> GetAllByCategoryId(int id)
        //{
        //    return new SuccessDataResult<List<Sehir>>(_sehirDal.GetAll(p => p.CategoryId == id));
        //}

        public IDataResult<Sehir> GetById(int sehirId)
        {
            return new SuccessDataResult<Sehir>(_sehirDal.Get(p => p.SehirId == sehirId));
        }

        //public IDataResult<List<Sehir>> GetByUnitPrice(decimal min, decimal max)
        //{
        //    return new SuccessDataResult<List<Sehir>>(_sehirDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        //}


    }
}
