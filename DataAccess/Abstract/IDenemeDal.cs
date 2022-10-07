using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IDenemeDal : IEntityRepository<Deneme>
    {
        List<DenemeDetailDto> GetDenemeDetails(int denemeId=-1);
    }
}
//code refactoring