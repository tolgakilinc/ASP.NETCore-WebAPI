using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IVeliTakipService
    {
        IDataResult<List<VeliTakip>> GetAll();
        IDataResult<List<VeliTakipDetailDto>> GetVeliTakipDetails();
        IDataResult<VeliTakip> GetById(int netId);
        IResult Add(VeliTakip net); //IResult voidler için kullandık
    }
}
