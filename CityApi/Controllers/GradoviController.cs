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
    [Route("[controller]")]
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

        // AutoMapper 12 with Profile
        //private readonly IMapper _mapper;
        //public GradoviController(IGradoviService gradoviService, IMapper mapper)
        //{
        //    _gradoviService = gradoviService;
        //    _mapper = mapper;
        //}

        [HttpGet]
        //[Route("GetAll")]
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

        [HttpGet("GetGrad/{id}")]
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


        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<SifrarnikGradovaZaPbrReadModel>> CreateGrad(SifrarnikGradovaZaPbrCreateModel createGradDto)
        {
            try
            {
                var grad = _mapper.Map<SifrarnikGradovaZaPbr>(createGradDto);
                var noviGrad = await _gradoviService.CreateGrad(grad);

                var gradReadDto = _mapper.Map<SifrarnikGradovaZaPbrReadModel>(noviGrad);

                // vraća napravljeni grad
                return CreatedAtAction(nameof(GetGrad), new { id = gradReadDto.Id }, gradReadDto);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateGrad(SifrarnikGradovaZaPbrUpdateModel updateGradDto)
        {
            try
            {
                var gradDb = _mapper.Map<SifrarnikGradovaZaPbr>(updateGradDto);

                var grad = await _gradoviService.UpdateGrad(gradDb);
                if (grad == null)
                {
                    return NotFound();
                }
                return Ok(grad);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGradById(int id, SifrarnikGradovaZaPbrUpdateModel updateGradDto)
        {
            try
            {
                var grad = _mapper.Map<SifrarnikGradovaZaPbr>(updateGradDto);
                grad.Id = id;
                var updatedGrad = await _gradoviService.UpdateGradById(id, grad);
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


        //[HttpDelete("Delete/{id}")]
        //public async Task<IActionResult> DeleteGrad(int id)
        //{
        //    var grad = await _gradoviService.GetGradById(id);
        //    if (grad == null)
        //    {
        //        return NotFound();
        //    }

        //    try
        //    {
        //        await _gradoviService.DeleteGrad(id);
        //    }
        //    catch
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError);
        //    }
        //    return Ok();
        //}


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteGrad(int id)
        {
            var grad = await _gradoviService.GetGradById(id);
            if (grad == null)
            {
                return NotFound();
            }

            try
            {
                await _gradoviService.DeleteGrad(grad);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok();
        }
    }
}
