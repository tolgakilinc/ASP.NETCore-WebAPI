using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISınıfService
    {
        IDataResult<List<Sınıf>> GetAll();//IDataResult -> işlem sonucu mesajı  içeren ve döndüreceği mesajı içeren yapı için kullandık
                                          //  IDataResult<List<Sınıf>> GetAllByCategoryId(int id);
                                          //  IDataResult<List<Sınıf>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<SınıfDetailDto>> GetSınıfDetails();
        IDataResult<Sınıf> GetById(int sınıfId);
        IResult Add(Sınıf sınıf); //IResult voidler için kullandık
    }
}
