using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoruController : ControllerBase
    {
        ISoruService _soruService;

        public SoruController(ISoruService soruService)
        {
            _soruService = soruService;
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            //dependency chain ---
            //IProductService productService = new ProductManager(new EfProductDal());
            var result = _soruService.GetSoruDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("yanitlanan/kullanici/{kullaniciId}/ders/{dersId}")]
        public IActionResult GetYanitlananOgrenci(int kullaniciId, int dersId)
        {
            //dependency chain ---
            //IProductService productService = new ProductManager(new EfProductDal());
            var result = _soruService.GetYanitlananSorular(kullaniciId, dersId, -1);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("yanitlanan/ogretmen/{ogretmenId}/ders/{dersId}")]
        public IActionResult GetYanitlananOgretmen(int dersId, int ogretmenId)
        {
            //dependency chain ---
            //IProductService productService = new ProductManager(new EfProductDal());
            var yanitlananSorular = _soruService.GetYanitlananSorular(-1, dersId, ogretmenId);

            if (yanitlananSorular.Success)
            {
                return Ok(yanitlananSorular);
            }
            return BadRequest(yanitlananSorular);
        }

        [HttpGet("beklenen/ogretmen/ders/{dersId}")]
        public IActionResult GetBeklenenOgretmen(int dersId)
        {
            //dependency chain ---
            //IProductService productService = new ProductManager(new EfProductDal());
            var yanitlananSorular = _soruService.GetYanitlananSorular(-1, dersId, -1);
            var tumSorulanSorular = _soruService.GetKullaniciSorular(-1, dersId);

            List<Soru> data = new List<Soru>();
            var tumsorulansorulardata = tumSorulanSorular.Data;
            var yanitlananSorularData = yanitlananSorular.Data;

            List<int> sorulanSorularIdleri = new List<int>();
            List<int> yanitlananSorularIdleri = new List<int>();

            foreach (var item in tumsorulansorulardata)
            {
                sorulanSorularIdleri.Add(item.SoruId);
            }

            foreach (var item in yanitlananSorularData)
            {
                yanitlananSorularIdleri.Add(item.SoruId);
            }

            foreach (var item in sorulanSorularIdleri)
            {
                if (!yanitlananSorularIdleri.Contains(item))
                {
                    dynamic soru = tumsorulansorulardata.Where(x => x.SoruId == item).FirstOrDefault();
                    data.Add(soru);
                }
            }

            if (tumSorulanSorular.Success)
            {
                return Ok(new { tumSorulanSorular.Success, tumSorulanSorular.Message, data });
            }
            return BadRequest(tumSorulanSorular);
        }


        [HttpGet("beklenen/kullanici/{kullaniciId}/ders/{dersId}")]
        public IActionResult GetBeklenenOgrenci(int kullaniciId, int dersId)
        {
            //dependency chain ---
            //IProductService productService = new ProductManager(new EfProductDal());
            var yanitlananSorular = _soruService.GetYanitlananSorular(kullaniciId, dersId, -1);
            var tumSorulanSorular = _soruService.GetKullaniciSorular(kullaniciId, dersId);

            List<Soru> data = new List<Soru>();
            var tumsorulansorulardata = tumSorulanSorular.Data;
            var yanitlananSorularData = yanitlananSorular.Data;

            List<int> sorulanSorularIdleri = new List<int>();
            List<int> yanitlananSorularIdleri = new List<int>();

            foreach (var item in tumsorulansorulardata)
            {
                sorulanSorularIdleri.Add(item.SoruId);
            }

            foreach (var item in yanitlananSorularData)
            {
                yanitlananSorularIdleri.Add(item.SoruId);
            }

            foreach (var item in sorulanSorularIdleri)
            {
                if (!yanitlananSorularIdleri.Contains(item))
                {
                    dynamic soru = tumsorulansorulardata.Where(x => x.SoruId == item).FirstOrDefault();
                    data.Add(soru);
                }
            }

            if (tumSorulanSorular.Success)
            {
                return Ok(new { tumSorulanSorular.Success, tumSorulanSorular.Message, data });
            }
            return BadRequest(tumSorulanSorular);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _soruService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Soru soru)
        {
            var result = _soruService.Add(soru);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
