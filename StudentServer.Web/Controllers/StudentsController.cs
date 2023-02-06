using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentServer.Application.Features.Students;
using StudentServer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentServer.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Student>>> GetAllStudents()
        {
            try
            {
                var query = new GetAllStudentsQuery();

                var result = await _mediator.Send(query);

                return Ok(result);
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(string id)
        {
            try
            {
                var query = new GetStudentQuery(id);

                var result = await _mediator.Send(query);

                if (result == null)
                    return NotFound();

                return result;
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task AddStudent(Student student)
        {

        }
    }
}
