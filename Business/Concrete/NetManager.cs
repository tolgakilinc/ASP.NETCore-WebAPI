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
    public class NetManager : INetService
    {
        INetDal _netDal;


        public NetManager(INetDal netDal)
        {
            _netDal = netDal;
        }

        [ValidationAspect(typeof(NetValidator))]
        public IResult Add(Net net)
        {

            _netDal.Add(net);
            return new Result(true, Messages.RecordCreated);
        }

        public IDataResult<List<Net>> GetAll()
        {

            return new SuccessDataResult<List<Net>>(_netDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<Net> GetById(int netId)
        {
            return new SuccessDataResult<Net>(_netDal.Get(p => p.NetId == netId));
        }


        public IDataResult<List<NetDetailDto>> GetNetDetails()
        {

            return new SuccessDataResult<List<NetDetailDto>>(_netDal.GetNetDetails());
        }
    }
}
