using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProgramDal : IEntityRepository<Program>
    {
        List<ProgramDetailDto> GetProgramDetails();

        List<ProgramDetailDto> GetUserProgramWithDate(int userId, string date);
    }
}
//code refactoring