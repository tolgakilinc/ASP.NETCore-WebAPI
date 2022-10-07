using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProgramService
    {
        IDataResult<List<Program>> GetAll();//IDataResult -> işlem sonucu mesajı  içeren ve döndüreceği mesajı içeren yapı için kullandık
                                          //  IDataResult<List<Program>> GetAllByCategoryId(int id);
                                          //  IDataResult<List<Program>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProgramDetailDto>> GetProgramDetails();
        IDataResult<List<ProgramDetailDto>> GetUserProgramWithDate(int userId, string date);
        IDataResult<Program> GetById(int programId);
        IResult Add(Program program); //IResult voidler için kullandık
        IResult Delete(Program program); //IResult voidler için kullandık
    }
}
