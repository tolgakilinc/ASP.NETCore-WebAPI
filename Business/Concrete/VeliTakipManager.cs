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
    public class VeliTakipManager : IVeliTakipService
    {
        IVeliTakipDal _veliTakipDal;


        public VeliTakipManager(IVeliTakipDal veliTakipDal)
        {
            _veliTakipDal = veliTakipDal;
        }

        [ValidationAspect(typeof(VeliTakipValidator))]
        public IResult Add(VeliTakip veliTakip)
        {

            _veliTakipDal.Add(veliTakip);
            return new Result(true, Messages.RecordCreated);
        }

        public IDataResult<List<VeliTakip>> GetAll()
        {

            return new SuccessDataResult<List<VeliTakip>>(_veliTakipDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<VeliTakip> GetById(int veliTakipId)
        {
            return new SuccessDataResult<VeliTakip>(_veliTakipDal.Get(p => p.VeliTakipId == veliTakipId));
        }


        public IDataResult<List<VeliTakipDetailDto>> GetVeliTakipDetails()
        {

            return new SuccessDataResult<List<VeliTakipDetailDto>>(_veliTakipDal.GetVeliTakipDetails());
        }
    }
}
