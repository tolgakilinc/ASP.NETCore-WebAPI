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
    public class BolumManager : IBolumService
    {
        IBolumDal _bolumDal;


        public BolumManager(IBolumDal bolumDal)
        {
            _bolumDal = bolumDal;
        }
        //  [LogAspect]  AOP  Bir metodun önünde bir metodun sonunda bir metod hata verdiğinde çalışan kod parçacıklarını AOP ile yazılır yani Busine içinde busines yazılımı.
        [ValidationAspect(typeof(BolumValidator))]
        public IResult Add(Bolum bolum)
        {
            //business codes
            //validation
            /*    ValidationTool.Validate(new ProductValidator(), product); -> if (product.ProductName.Length < 2)
                {
                    //magic strings -> ayrı ayrı string gerçekleşmesi
                    return new ErrorResult(Messages.ProductNameInvalid);
                }
                */

            _bolumDal.Add(bolum);
            return new Result(true, Messages.ProductAdded);
        }

        public IDataResult<List<Bolum>> GetAll()
        {
            //iş kodları 
            //if (DateTime.Now.Hour==1)
            //{
            //    return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            //}

            return new SuccessDataResult<List<Bolum>>(_bolumDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<BolumDetailDto>> GetBolumDetails()
        {
            throw new NotImplementedException();
        }



        //public IDataResult<List<Bolum>> GetAllByCategoryId(int id)
        //{
        //    return new SuccessDataResult<List<Bolum>>(_bolumDal.GetAll(p => p.CategoryId == id));
        //}

        public IDataResult<Bolum> GetById(int bolumId)
        {
            return new SuccessDataResult<Bolum>(_bolumDal.Get(p => p.BolumId == bolumId));
        }

        //public IDataResult<List<Bolum>> GetByUnitPrice(decimal min, decimal max)
        //{
        //    return new SuccessDataResult<List<Bolum>>(_bolumDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        //}

      
    }
}
