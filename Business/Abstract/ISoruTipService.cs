using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISoruTipService
    {
        IDataResult<List<SoruTip>> GetAll();//IDataResult -> işlem sonucu mesajı  içeren ve döndüreceği mesajı içeren yapı için kullandık
                                          //  IDataResult<List<SoruTip>> GetAllByCategoryId(int id);
                                          //  IDataResult<List<SoruTip>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<SoruTipDetailDto>> GetSoruTipDetails();
        IDataResult<SoruTip> GetById(int soruTipId);
        IResult Add(SoruTip soruTip); //IResult voidler için kullandık
    }
}
