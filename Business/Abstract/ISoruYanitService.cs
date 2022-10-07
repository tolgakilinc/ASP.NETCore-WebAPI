using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISoruYanitService
    {
        IDataResult<List<SoruYanit>> GetAll();
        IDataResult<List<SoruYanitDetailDto>> GetSoruYanitDetails();
        IDataResult<List<SoruYanitDetailDto>> GetById(int soruYanitId);
        IDataResult<SoruYanit> GetBySoruId(int soruId);
        IResult Add(SoruYanit kullanici); //IResult voidler için kullandık
    }
}