using AutoMapper;
using CityApi.AutoMapper;
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
    [Route("api/[controller]")]
    [ApiController]
    public class GradoviController : ControllerBase
    {
        private readonly IGradoviService _gradoviService;

        private readonly IControllerMappingService _mapper;
        public GradoviController(IGradoviService gradoviService, IControllerMappingService mapper)
        {
            _gradoviService = gradoviService;
            _mapper = mapper;
        }


        // GET: api/Gradovi
        [HttpGet]
        public async Task<IActionResult> GetAllGradovi()
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


        // GET: api/Gradovi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGrad(int id)
        {
            try
            {
                var gradDb = await _gradoviService.GetGradById(id);
                if (gradDb == null)
                {
                    return NotFound();
                }

                return Ok(_mapper.Map<SifrarnikGradovaZaPbrReadModel>(gradDb));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        // POST: api/Gradovi
        [HttpPost]
        public async Task<ActionResult<SifrarnikGradovaZaPbrReadModel>> PostGrad(SifrarnikGradovaZaPbrCreateModel createGradDto)
        {
            try
            {
                var grad = _mapper.Map<SifrarnikGradovaZaPbr>(createGradDto);
                var noviGrad = await _gradoviService.AddGrad(grad);

                var gradReadDto = _mapper.Map<SifrarnikGradovaZaPbrReadModel>(noviGrad);

                // vraća napravljeni grad
                return CreatedAtAction(nameof(GetGrad), new { id = gradReadDto.Id }, gradReadDto);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        // PUT: api/Gradovi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGrad(int id, SifrarnikGradovaZaPbrUpdateModel updateGradDto)
        {
            if (id != updateGradDto.Id)
            {
                return BadRequest();
            }

            try
            {
                var grad = _mapper.Map<SifrarnikGradovaZaPbr>(updateGradDto);

                var updatedGrad = await _gradoviService.UpdateGrad(id, grad);
                if (updatedGrad == null)
                {
                    return NotFound();
                }

                return Ok(updatedGrad);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGrad(int id)
        {
            try
            {
                var deletedGrad = await _gradoviService.DeleteGrad(id);
                if (deletedGrad == null)
                {
                    return NotFound();
                }
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return NoContent();
        }


    }
}
