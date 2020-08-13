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
    public class YemekController : ControllerBase
    {
        private readonly IYemekService _yemekService;

        public YemekController(IYemekService yemekService)
        {
            _yemekService = yemekService;
        }

        /// <summary>
        /// Bütün yemekleri getirir.
        /// </summary>
        /// <returns></returns>
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _yemekService.GetList();
            if (result != null)
                return Ok(result);

            return BadRequest();
        }

        /// <summary>
        /// Yeni bir yemek ekler
        /// </summary>
        /// <param name="yemek"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public IActionResult Add(Yemek yemek)
        {
            var result = _yemekService.Add(yemek);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound(result);

        }
       
        /// <summary>
        /// İd ye göre yemek getirir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("getbyid")]
        public IActionResult GetById(string id)
        {
            var result = _yemekService.GetById(id);
            if (result != null)
                return Ok(result);

            return NotFound(result);
        }

        /// <summary>
        /// Yemek günceller
        /// </summary>
        /// <param name="id"></param>
        /// <param name="yemek"></param>
        /// <returns></returns>
        [HttpPost("update")]
        public IActionResult Update(string id, [FromBody] Yemek yemek )
        {
            var result = _yemekService.Update(id, yemek);
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }

        /// <summary>
        /// Yemek siler
        /// </summary>
        /// <param name="yemekTur"></param>
        /// <returns></returns>
        [HttpPost("delete")]
        public IActionResult delete([FromBody] Yemek yemekTur)
        {
            var result = _yemekService.Delete(yemekTur);
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }

    }
}
