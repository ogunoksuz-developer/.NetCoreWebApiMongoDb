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
    public class YemekTurController : ControllerBase
    {
        private readonly IYemekTurService _yemekTurService ;

        public YemekTurController(IYemekTurService yemekTurService)
        {
            _yemekTurService = yemekTurService;
        }

        /// <summary>
        /// Tüm yemek türlerini getirir.
        /// </summary>
        /// <returns></returns>
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _yemekTurService.GetList();
            if (result != null)
                return Ok(result);

            return BadRequest();
        }

        /// <summary>
        /// İd ye göre yemek türünü getirir.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("getbyid")]
        public IActionResult GetById(string id)
        {
            var result = _yemekTurService.GetById(id);
            if (result != null)
                return Ok(result);

            return NotFound(result);
        }

        /// <summary>
        /// Yeni yemek türü ekler
        /// </summary>
        /// <param name="yemekTur"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public IActionResult Add(YemekTur yemekTur)
        {
            var result= _yemekTurService.Add(yemekTur);
            if (result!=null)
            {
                return Ok(result);
            }
            return NotFound(result);

        }

        /// <summary>
        /// Yemek türünü günceller
        /// </summary>
        /// <param name="id"></param>
        /// <param name="yemekTur"></param>
        /// <returns></returns>
        [HttpPost("update")]
        public IActionResult Update(string id, [FromBody] YemekTur yemekTur)
        {
            var result = _yemekTurService.Update(id, yemekTur);
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }

        /// <summary>
        /// Yemek türünü günceller.
        /// </summary>
        /// <param name="yemekTur"></param>
        /// <returns></returns>

        [HttpPost("delete")]
        public IActionResult delete([FromBody] YemekTur yemekTur)
        {
            var result = _yemekTurService.Delete(yemekTur);
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }

    }
}
