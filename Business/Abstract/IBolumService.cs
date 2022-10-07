using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBolumService
    {
        IDataResult<List<Bolum>> GetAll();//IDataResult -> işlem sonucu mesajı  içeren ve döndüreceği mesajı içeren yapı için kullandık
      //  IDataResult<List<Bolum>> GetAllByCategoryId(int id);
      //  IDataResult<List<Bolum>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<BolumDetailDto>> GetBolumDetails();
        IDataResult<Bolum> GetById(int bolumId);
        IResult Add(Bolum bolum); //IResult voidler için kullandık
    }
}
