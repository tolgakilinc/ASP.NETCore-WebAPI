using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISoruHavuzService
    {
        IDataResult<List<SoruHavuz>> GetAll();
        IDataResult<List<SoruHavuzDetailDto>> GetSoruHavuzDetails(int dersId = -1);
        IDataResult<SoruHavuz> GetById(int netId);
        IResult Add(SoruHavuz net); //IResult voidler için kullandık
    }
}
