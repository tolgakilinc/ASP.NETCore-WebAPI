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
    [Route("api/soruYanit")]
    [ApiController]
    public class SoruYanitlarController : ControllerBase
    {
        ISoruYanitService _soruYanitService;

        public SoruYanitlarController(ISoruYanitService soruYanitService)
        {
            _soruYanitService = soruYanitService;
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            //dependency chain ---
            //IProductService productService = new ProductManager(new EfProductDal());
            var result = _soruYanitService.GetSoruYanitDetails();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _soruYanitService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("soru/{id}")]
        public IActionResult GetBySoruId(int id)
        {
            var result = _soruYanitService.GetBySoruId(id);

            List<SoruYanit> data = new List<SoruYanit>();
            data.Add(result.Data);

            if (result.Success)
            {
                return Ok(new { result.Success, result.Message, data });
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(SoruYanit soruYanit)
        {
            var result = _soruYanitService.Add(soruYanit);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
