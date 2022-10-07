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
    public class GunManager : IGunService
    {
        IGunDal _gunDal;

        public GunManager(IGunDal gunDal)
        {
            _gunDal = gunDal;
        }
        [ValidationAspect(typeof(GunValidator))]
        public IResult Add(Gun gun)
        {
         

            _gunDal.Add(gun);
            return new Result(true, Messages.ProductAdded);
        }

        public IDataResult<List<Gun>> GetAll()
        {
        
            return new SuccessDataResult<List<Gun>>(_gunDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<GunDetailDto>> GetGunDetails()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Gun> GetById(int gunId)
        {
            return new SuccessDataResult<Gun>(_gunDal.Get(p => p.GunId == gunId));
        }

    }
}
