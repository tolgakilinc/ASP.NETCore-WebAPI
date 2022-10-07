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
    public class DersKategoriManager : IDersKategoriService
    {
        IDersKategoriDal _dersKategoriDal;


        public DersKategoriManager(IDersKategoriDal dersKategoriDal)
        {
            _dersKategoriDal = dersKategoriDal;
        }
        [ValidationAspect(typeof(DersKategoriValidator))]
        public IResult Add(DersKategori dersKategori)
        {

            _dersKategoriDal.Add(dersKategori);
            return new Result(true, Messages.ProductAdded);
        }

        public IDataResult<List<DersKategori>> GetAll()
        {
           
            return new SuccessDataResult<List<DersKategori>>(_dersKategoriDal.GetAll(), Messages.ProductListed);
        }
        public IDataResult<List<DersKategoriDetailDto>> GetDersKategoriDetails()
        {
            throw new NotImplementedException();
        }
   
        public IDataResult<DersKategori> GetById(int dersKategoriId)
        {
            return new SuccessDataResult<DersKategori>(_dersKategoriDal.Get(p => p.DersKategoriId == dersKategoriId));
        }
    }
}
