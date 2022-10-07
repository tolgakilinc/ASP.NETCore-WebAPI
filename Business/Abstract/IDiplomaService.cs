using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDiplomaService
    {
        IDataResult<List<Diploma>> GetAll();
        IDataResult<List<DiplomaDetailDto>> GetDiplomaDetails();
        IDataResult<Diploma> GetById(int dersId);
        IResult Add(Diploma ders); //IResult voidler için kullandık
    }
}
