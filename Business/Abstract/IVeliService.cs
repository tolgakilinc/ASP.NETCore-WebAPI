using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IVeliService
    {
        IDataResult<List<Veli>> GetAll();//IDataResult -> işlem sonucu mesajı  içeren ve döndüreceği mesajı içeren yapı için kullandık
      //  IDataResult<List<Veli>> GetAllByCategoryId(int id);
      //  IDataResult<List<Veli>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<VeliDetailDto>> GetVeliDetails();
        IDataResult<Veli> GetById(int veliId);
        IResult Add(Veli veli); //IResult voidler için kullandık
    }
}
