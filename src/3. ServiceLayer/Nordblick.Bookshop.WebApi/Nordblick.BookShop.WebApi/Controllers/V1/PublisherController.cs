using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Nordblick.Bookshop.BusinessObjects;
using Nordblick.Bookshop.DataObjects;

namespace Nordblick.BookShop.WebApi.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PublisherController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _unitOfWork.Publisher.GetAll();


                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }


        [HttpGet("{id}", Name = "PublisherById")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var result = await _unitOfWork.Publisher.Find(id);

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
        public async Task<IActionResult> Post([FromBody] Publisher value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Publisher result = await _unitOfWork.Publisher.Add(value);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Publisher value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _unitOfWork.Publisher.Update(value);

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
                var result = await _unitOfWork.Publisher.Find(id);

                if (result == null)
                {
                    return NotFound();
                }

                await _unitOfWork.Publisher.Remove(id);
                
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

    }
}
