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
    public class DersKategoriController : ControllerBase
    {
        IDersKategoriService _dersKategoriService;

        public DersKategoriController(IDersKategoriService dersKategoriService)
        {
            _dersKategoriService = dersKategoriService;
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            
            var result = _dersKategoriService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _dersKategoriService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(DersKategori dersKategori)
        {
            var result = _dersKategoriService.Add(dersKategori);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
