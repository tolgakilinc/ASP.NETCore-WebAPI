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
    public class SoruYanitManager : ISoruYanitService
    {
        ISoruYanitDal _soruYanitDal;


        public SoruYanitManager(ISoruYanitDal soruYanitDal)
        {
            _soruYanitDal = soruYanitDal;
        }

        [ValidationAspect(typeof(SoruYanitValidator))]
        public IResult Add(SoruYanit soruYanit)
        {
            _soruYanitDal.Add(soruYanit);

            /*var result = _soruYanitDal.Get(user => user.Eposta == email && user.Sifre == password);
            if (result != null)
            {
                return new SuccessDataResult<User>(result, "giriş başarılı");
            }*/

            return new Result(true, Messages.RecordCreated);
        }

        public IDataResult<List<SoruYanit>> GetAll()
        {
            return new SuccessDataResult<List<SoruYanit>>(_soruYanitDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<SoruYanitDetailDto>> GetById(int soruYanitId)
        {
            return new SuccessDataResult<List<SoruYanitDetailDto>>(_soruYanitDal.GetSoruYanitDetails(soruYanitId));
        }

        public IDataResult<SoruYanit> GetBySoruId(int soruId)
        {
            return new SuccessDataResult<SoruYanit>(_soruYanitDal.Get(x=> x.SoruId == soruId), Messages.ProductListed);
        }

        public IDataResult<List<SoruYanitDetailDto>> GetSoruYanitDetails()
        {

            return new SuccessDataResult<List<SoruYanitDetailDto>>(_soruYanitDal.GetSoruYanitDetails());
        }
    }
}
