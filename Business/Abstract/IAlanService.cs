using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAlanService
    {
        IDataResult<List<Alan>> GetAll();//IDataResult -> işlem sonucu mesajı  içeren ve döndüreceği mesajı içeren yapı için kullandık
                                          
        IDataResult<List<AlanDetailDto>> GetAlanDetails();
        IDataResult<Alan> GetById(int alanId);
        IResult Add(Alan alan); //IResult voidler için kullandık
    }
}
