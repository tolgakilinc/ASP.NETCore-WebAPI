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
    public class SoruTipManager : ISoruTipService
    {
        ISoruTipDal _soruTipDal;


        public SoruTipManager(ISoruTipDal soruTipDal)
        {
            _soruTipDal = soruTipDal;
        }
        //  [LogAspect]  AOP  Bir metodun önünde bir metodun sonunda bir metod hata verdiğinde çalışan kod parçacıklarını AOP ile yazılır yani Busine içinde busines yazılımı.
        [ValidationAspect(typeof(SoruTipValidator))]
        public IResult Add(SoruTip soruTip)
        {
            //business codes
            //validation
            /*    ValidationTool.Validate(new ProductValidator(), product); -> if (product.ProductName.Length < 2)
                {
                    //magic strings -> ayrı ayrı string gerçekleşmesi
                    return new ErrorResult(Messages.ProductNameInvalid);
                }
                */

            _soruTipDal.Add(soruTip);
            return new Result(true, Messages.ProductAdded);
        }

        public IDataResult<List<SoruTip>> GetAll()
        {
            //iş kodları 
            //if (DateTime.Now.Hour==1)
            //{
            //    return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            //}

            return new SuccessDataResult<List<SoruTip>>(_soruTipDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<SoruTipDetailDto>> GetSoruTipDetails()
        {
            throw new NotImplementedException();
        }



        //public IDataResult<List<SoruTip>> GetAllByCategoryId(int id)
        //{
        //    return new SuccessDataResult<List<SoruTip>>(_soruTipDal.GetAll(p => p.CategoryId == id));
        //}

        public IDataResult<SoruTip> GetById(int soruTipId)
        {
            return new SuccessDataResult<SoruTip>(_soruTipDal.Get(p => p.SoruTipId == soruTipId));
        }

        //public IDataResult<List<SoruTip>> GetByUnitPrice(decimal min, decimal max)
        //{
        //    return new SuccessDataResult<List<SoruTip>>(_soruTipDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        //}


    }
}
