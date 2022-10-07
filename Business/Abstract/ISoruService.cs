using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISoruService
    {
        IDataResult<List<Soru>> GetAll();
        IDataResult<List<SoruDetailDto>> GetSoruDetails();
        IDataResult<Soru> GetById(int soruId);
        IResult Add(Soru soru); //IResult voidler için kullandık
        IDataResult<List<Soru>> GetYanitlananSorular(int kullaniciId, int dersId, int ogretmenId);
        IDataResult<List<Soru>> GetKullaniciSorular(int kullaniciId, int dersId);
    }
}
