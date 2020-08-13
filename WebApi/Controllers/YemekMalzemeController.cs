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
    public class YemekMalzemeController : ControllerBase
    {
        private readonly IYemekMalzemeService _yemekMalzemeService;

        public YemekMalzemeController(IYemekMalzemeService yemekMalzemeService)
        {
            _yemekMalzemeService = yemekMalzemeService;
        }
        /// <summary>
        /// Tüm İlişkili yemek ve malzemeleri getirir 
        /// </summary>
        /// <returns></returns>
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _yemekMalzemeService.GetList();
            if (result != null)
                return Ok(result);

            return BadRequest();
        }
        /// <summary>
        /// Yeni yemek malzeme ilişkisi ekler
        /// </summary>
        /// <param name="yemekMalzeme"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public IActionResult Add(YemekMalzeme yemekMalzeme)
        {
            var result = _yemekMalzemeService.Add(yemekMalzeme);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound(result);

        }

        /// <summary>
        /// İd ye göre ilikili yemek ve malzemeyi getirir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("getbyid")]
        public IActionResult GetById(string id)
        {
            var result = _yemekMalzemeService.GetById(id);
            if (result != null)
                return Ok(result);

            return NotFound(result);
        }

        /// <summary>
        /// Yemek Id ye göre malzemeleri getirir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("getmalzemebyyemekid")]
        public IActionResult GetMalzemeByYemekId(string id)
        {
            var result = _yemekMalzemeService.GetMalzemeByYemekId(id);
            if (result != null)
                return Ok(result);

            return NotFound(result);
        }

        /// <summary>
        /// Yemek ve malzeme ilişkisini günceller
        /// </summary>
        /// <param name="id"></param>
        /// <param name="yemekMalzeme"></param>
        /// <returns></returns>
        [HttpPost("update")]
        public IActionResult Update(string id, [FromBody] YemekMalzeme yemekMalzeme)
        {
            var result = _yemekMalzemeService.Update(id, yemekMalzeme);
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }

        /// <summary>
        /// Yemek ve malzeme ilişkisini siler
        /// </summary>
        /// <param name="yemekMalzeme"></param>
        /// <returns></returns>
        [HttpPost("delete")]
        public IActionResult delete([FromBody] YemekMalzeme yemekMalzeme)
        {
            var result = _yemekMalzemeService.Delete(yemekMalzeme);
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }
    }
}
