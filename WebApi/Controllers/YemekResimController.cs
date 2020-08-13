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
    public class YemekResimController : ControllerBase
    {
        private readonly IYemekResimService _yemekResimService;

        public YemekResimController(IYemekResimService yemekResimService )
        {
            _yemekResimService = yemekResimService;
        }

        /// <summary>
        /// İlişkili tüm yemek ve resim bilgisini getirir
        /// </summary>
        /// <returns></returns>
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _yemekResimService.GetList();
            if (result != null)
                return Ok(result);

            return BadRequest();
        }

        /// <summary>
        /// Yeni bir yemek resim ilişkisi getirir.
        /// </summary>
        /// <param name="yemekResim"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public IActionResult Add(YemekResim yemekResim)
        {
            var result = _yemekResimService.Add(yemekResim);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound(result);

        }
        /// <summary>
        /// İd ye göre ilişki getirir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("getbyid")]
        public IActionResult GetById(string id)
        {
            var result = _yemekResimService.GetById(id);
            if (result != null)
                return Ok(result);

            return NotFound(result);
        }

        /// <summary>
        /// Yemek Id ye göre resim getirir.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("getresimbyyemekid")]
        public IActionResult GetResimByYemekId(string id)
        {
            var result = _yemekResimService.GetResimByYemId(id);
            if (result != null)
                return Ok(result);

            return NotFound(result);
        }

        /// <summary>
        /// Yemek ve resim ilişkisini günceller.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="yemekResim"></param>
        /// <returns></returns>
        [HttpPost("update")]
        public IActionResult Update(string id, [FromBody] YemekResim yemekResim)
        {
            var result = _yemekResimService.Update(id, yemekResim);
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }
        /// <summary>
        /// Yemekı resim ilişkisini siler
        /// </summary>
        /// <param name="yemekResim"></param>
        /// <returns></returns>
        [HttpPost("delete")]
        public IActionResult Delete([FromBody] YemekResim yemekResim)
        {
            var result = _yemekResimService.Delete(yemekResim);
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }
    }
}
