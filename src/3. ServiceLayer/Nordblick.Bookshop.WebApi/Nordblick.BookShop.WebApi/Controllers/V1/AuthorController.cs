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
    public class AuthorController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public AuthorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _unitOfWork.Author.GetAll();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}/Books")]
        public async Task<IActionResult> GetBooksByAuthorId(int id)
        {
            try
            {
                var result = await _unitOfWork.Book.GetAllByAuthorId(id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }


        [HttpGet("{id}", Name = "AuthorById")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var result = await _unitOfWork.Author.Find(id);

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
        public async Task<IActionResult> Post([FromBody] Author value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            try
            {
                Author result = await _unitOfWork.Author.Add(value);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }



        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Author value)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _unitOfWork.Author.Update(value);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // DELETE: api/Authors

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await _unitOfWork.Author.Find(id);

                if (result == null)
                {
                    return NotFound();
                }

                await _unitOfWork.Author.Remove(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

    }
}
