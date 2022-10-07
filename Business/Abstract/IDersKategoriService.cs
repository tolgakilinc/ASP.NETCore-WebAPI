using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDersKategoriService
    {
        IDataResult<List<DersKategori>> GetAll();//IDataResult -> işlem sonucu mesajı  içeren ve döndüreceği mesajı içeren yapı için kullandık
                                           //  IDataResult<List<DersKategori>> GetAllByCategoryId(int id);
                                           //  IDataResult<List<DersKategori>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<DersKategoriDetailDto>> GetDersKategoriDetails();
        IDataResult<DersKategori> GetById(int dersKategoriId);
        IResult Add(DersKategori dersKategori); //IResult voidler için kullandık
    }
}
