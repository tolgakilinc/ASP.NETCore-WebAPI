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
    public class SoruTipController : ControllerBase
    {
        ISoruTipService _soruTipService;

        public SoruTipController(ISoruTipService soruTipService)
        {
            _soruTipService = soruTipService;
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            //dependency chain ---
            //IProductService productService = new ProductManager(new EfProductDal());
            var result = _soruTipService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _soruTipService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(SoruTip soruTip)
        {
            var result = _soruTipService.Add(soruTip);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
