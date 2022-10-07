using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGunService
    {
        IDataResult<List<Gun>> GetAll();//IDataResult -> işlem sonucu mesajı  içeren ve döndüreceği mesajı içeren yapı için kullandık
        IDataResult<List<GunDetailDto>> GetGunDetails();
        IDataResult<Gun> GetById(int bolumId);
        IResult Add(Gun bolum); //IResult voidler için kullandık
    }
}
