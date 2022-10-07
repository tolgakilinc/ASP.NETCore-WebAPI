using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUnvanService
    {
        IDataResult<List<Unvan>> GetAll();//IDataResult -> işlem sonucu mesajı  içeren ve döndüreceği mesajı içeren yapı için kullandık
                                          //  IDataResult<List<Unvan>> GetAllByCategoryId(int id);
                                          //  IDataResult<List<Unvan>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<UnvanDetailDto>> GetUnvanDetails();
        IDataResult<Unvan> GetById(int unvanId);
        IResult Add(Unvan unvan); //IResult voidler için kullandık
    }
}
