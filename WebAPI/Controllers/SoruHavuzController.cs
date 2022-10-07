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
    [Route("api/soruHavuz")]
    [ApiController]
    public class SoruHavuzController : ControllerBase
    {
        ISoruHavuzService _soruHavuzService;

        public SoruHavuzController(ISoruHavuzService soruHavuzService)
        {
            _soruHavuzService = soruHavuzService;
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            //dependency chain ---
            //IProductService productService = new ProductManager(new EfProductDal());
            var result = _soruHavuzService.GetSoruHavuzDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("ders/{dersId}")]
        public IActionResult GetAllByDersId(int dersId)
        {
            //dependency chain ---
            //IProductService productService = new ProductManager(new EfProductDal());
            var result = _soruHavuzService.GetSoruHavuzDetails(dersId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _soruHavuzService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(SoruHavuz soruHavuz)
        {
            var result = _soruHavuzService.Add(soruHavuz);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
