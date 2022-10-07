using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ISoruHavuzDal : IEntityRepository<SoruHavuz>
    {
        List<SoruHavuzDetailDto> GetSoruHavuzDetails(int dersId = -1);

    }
}