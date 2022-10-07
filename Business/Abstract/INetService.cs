using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface INetService
    {
        IDataResult<List<Net>> GetAll();
        IDataResult<List<NetDetailDto>> GetNetDetails();
        IDataResult<Net> GetById(int netId);
        IResult Add(Net net); //IResult voidler için kullandık
    }
}
