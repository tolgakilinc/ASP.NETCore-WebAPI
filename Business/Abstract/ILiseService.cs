using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ILiseService
    {
        IDataResult<List<Lise>> GetAll();
        IDataResult<List<LiseDetailDto>> GetLiseDetails();
        IDataResult<Lise> GetById(int liseId);
        IResult Add(Lise lise); //IResult voidler için kullandık
    }
}
