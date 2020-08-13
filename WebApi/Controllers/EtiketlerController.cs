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
    public class EtiketlerController : ControllerBase
    {
        private readonly IEtiketlerService _etiketlerService ;
       
        public EtiketlerController(IEtiketlerService etiketlerService)
        {
            _etiketlerService = etiketlerService;
        }

        /// <summary>
        /// Tüm etiketleri getirir
        /// </summary>
        /// <returns></returns>
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _etiketlerService.GetList();
            if (result != null)
                return Ok(result);

            return BadRequest();
        }
        /// <summary>
        /// Yeni etiket ekler
        /// </summary>
        /// <param name="etiketler"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public IActionResult Add(Etiketler etiketler )
        {
            var result = _etiketlerService.Add(etiketler);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound(result);

        }
        /// <summary>
        /// İd ye gore etiket getirir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("getbyid")]
        public IActionResult GetById(string id)
        {
            var result = _etiketlerService.GetById(id);
            if (result != null)
                return Ok(result);

            return NotFound(result);
        }

        /// <summary>
        /// Etiket günceller
        /// </summary>
        /// <param name="id"></param>
        /// <param name="etiketler"></param>
        /// <returns></returns>
        [HttpPost("update")]
        public IActionResult Update(string id, [FromBody] Etiketler etiketler)
        {
            var result = _etiketlerService.Update(id, etiketler);
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }

        /// <summary>
        /// Etiket siler
        /// </summary>
        /// <param name="etiketler"></param>
        /// <returns></returns>
        [HttpPost("delete")]
        public IActionResult delete([FromBody] Etiketler etiketler)
        {
            var result = _etiketlerService.Delete(etiketler);
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }
    }
}
