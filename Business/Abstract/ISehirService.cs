using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISehirService
    {
        IDataResult<List<Sehir>> GetAll();//IDataResult -> işlem sonucu mesajı  içeren ve döndüreceği mesajı içeren yapı için kullandık
                                          //  IDataResult<List<Sehir>> GetAllByCategoryId(int id);
                                          //  IDataResult<List<Sehir>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<SehirDetailDto>> GetSehirDetails();
        IDataResult<Sehir> GetById(int sehirId);
        IResult Add(Sehir sehir); //IResult voidler için kullandık
    }
}
