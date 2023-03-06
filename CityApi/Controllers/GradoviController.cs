using Hp.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CityApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GradoviController : ControllerBase
    {
        private readonly IGradoviService _gradoviService;

        public GradoviController(IGradoviService gradoviService)
        {
            _gradoviService = gradoviService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetGradovi()
        {
            try
            {
                return Ok(await _gradoviService.GetAllGradovi());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGrad(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            try
            {
                var grad = await _gradoviService.GetGradById(id);

                if (grad == null)
                {
                    return NotFound();
                }

                return Ok(grad);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
