using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDenemeService
    {
        IDataResult<List<Deneme>> GetAll();//IDataResult -> işlem sonucu mesajı  içeren ve döndüreceği mesajı içeren yapı için kullandık
                                            //  IDataResult<List<Deneme>> GetAllByCategoryId(int id);
                                            //  IDataResult<List<Deneme>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<DenemeDetailDto>> GetDenemeDetails();
        IDataResult<Deneme> GetById(int denemeId);
        IResult Add(Deneme program); //IResult voidler için kullandık
        IResult Delete(Deneme deneme); //IResult voidler için kullandık

    }
}
