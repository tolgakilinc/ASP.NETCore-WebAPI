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
    public class GunController : ControllerBase
    {
        IGunService _gunService;

        public GunController(IGunService gunService)
        {
            _gunService = gunService;
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            //dependency chain ---
            //IProductService productService = new ProductManager(new EfProductDal());
            var result = _gunService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _gunService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Gun gun)
        {
            var result = _gunService.Add(gun);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
