using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IDersService
    {
        IDataResult<List<DersDetailDto>> GetDersDetails();
        IDataResult<Ders> GetById(int dersId);
        IResult Add(Ders ders); //IResult voidler için kullandık
    }
}
