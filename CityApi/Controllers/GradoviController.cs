using AutoMapper;
using Hp.Data;
using Hp.Data.Entities;
using Hp.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service;
using Service.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GradoviController : ControllerBase
    {
        private readonly IGradoviService _gradoviService;
        private readonly IMapper _mapper;

        public GradoviController(IGradoviService gradoviService, IMapper mapper)
        {
            _gradoviService = gradoviService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetGradovi()
        {
            try
            {
                IEnumerable<SifrarnikGradovaZaPbr> gradoviDb = await _gradoviService.GetAllGradovi();
                if (gradoviDb != null)
                {
                    return Ok(_mapper.Map<List<SifrarnikGradovaZaPbrReadModel>>(gradoviDb));
                }
                else
                {
                    return NotFound();
                }
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
                var gradDb = await _gradoviService.GetGradById(id);

                if (gradDb == null)
                {
                    return NotFound();
                }

                return Ok(_mapper.Map<SifrarnikGradovaZaPbrReadModel>(gradDb));

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }






    }
}
