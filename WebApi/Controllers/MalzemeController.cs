using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MalzemeController : ControllerBase
    {
        private readonly IMalzemeService _malzemeService;


        public MalzemeController(IMalzemeService malzemeService)
        {
            _malzemeService =malzemeService;
        }

        /// <summary>
        /// Tüm malzemeleri getirir
        /// </summary>
        /// <returns></returns>
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _malzemeService.GetList();
            if (result != null)
                return Ok(result);

            return BadRequest();
        }
        /// <summary>
        /// Yeni malzeme ekler
        /// </summary>
        /// <param name="malzame"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public IActionResult Add(Malzeme malzame)
        {
            var result = _malzemeService.Add(malzame);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound(result);

        }
        /// <summary>
        /// Id ye göre malzeme getirir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("getbyid")]
        public IActionResult GetById(string id)
        {
            var result = _malzemeService.GetById(id);
            if (result != null)
                return Ok(result);

            return NotFound(result);
        }

        /// <summary>
        /// Malzeme günceller
        /// </summary>
        /// <param name="id"></param>
        /// <param name="malzame"></param>
        /// <returns></returns>
        [HttpPost("update")]
        public IActionResult Update(string id, [FromBody] Malzeme malzame)
        {
            var result = _malzemeService.Update(id, malzame);
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }

        /// <summary>
        /// Malzeme siler
        /// </summary>
        /// <param name="malzame"></param>
        /// <returns></returns>
        [HttpPost("delete")]
        public IActionResult delete([FromBody] Malzeme malzame )
        {
            var result = _malzemeService.Delete(malzame);
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }
    }
}
