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
    public class ResimController : ControllerBase
    {
        private readonly IResimService _resimService;

        public ResimController(IResimService resimService)
        {
            _resimService = resimService;
        }

        /// <summary>
        /// Tüm resimleri getirir
        /// </summary>
        /// <returns></returns>
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _resimService.GetList();
            if (result != null)
                return Ok(result);

            return BadRequest();
        }

        /// <summary>
        /// Id ye göre resim getirir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("getbyid")]
        public IActionResult GetById(string id)
        {
            var result = _resimService.GetById(id);
            if (result != null)
                return Ok(result);

            return NotFound(result);
        }
        /// <summary>
        /// Yeni resim ekler
        /// </summary>
        /// <param name="resim"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public IActionResult Add(Resim resim)
        {
            var result = _resimService.Add(resim);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound(result);

        }

        /// <summary>
        /// Resim günceller
        /// </summary>
        /// <param name="id"></param>
        /// <param name="resim"></param>
        /// <returns></returns>
        [HttpPost("update")]
        public IActionResult Update(string id, [FromBody] Resim resim)
        {
            var result = _resimService.Update(id, resim);
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }
        /// <summary>
        /// Resim siler
        /// </summary>
        /// <param name="resim"></param>
        /// <returns></returns>
        [HttpPost("delete")]
        public IActionResult delete([FromBody] Resim resim)
        {
            var result = _resimService.Delete(resim);
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }
    }
}
