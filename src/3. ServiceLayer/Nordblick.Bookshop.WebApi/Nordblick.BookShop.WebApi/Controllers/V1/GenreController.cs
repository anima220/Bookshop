using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nordblick.Bookshop.BusinessObjects;
using Nordblick.Bookshop.DataObjects;

namespace Nordblick.BookShop.WebApi.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public GenreController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                IEnumerable<Genre> result = await _unitOfWork.Genre.GetAll();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }


        [HttpGet("{id}", Name = "GenreById")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var result = await _unitOfWork.Genre.Find(id);

                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Genre value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Genre result = await _unitOfWork.Genre.Add(value);

                return Ok(result);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Genre value)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _unitOfWork.Genre.Update(value);

                return Ok(result);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await _unitOfWork.Genre.Find(id);

                if (result == null)
                {
                    return NotFound();
                }

                await _unitOfWork.Genre.Remove(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

    }
}
