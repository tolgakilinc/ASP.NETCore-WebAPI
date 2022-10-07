using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUniversiteService
    {
        IDataResult<List<Universite>> GetAll();
        IDataResult<List<UniversiteDetailDto>> GetUniversiteDetails();
        IDataResult<Universite> GetById(int universiteId);
        IResult Add(Universite universite); //IResult voidler için kullandık
    }
}
