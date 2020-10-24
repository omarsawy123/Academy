using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Models;
using Academy_Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Academy.Controllers
{
    [Route("/api/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }


        [HttpGet]
        public async Task<ActionResult> GetStudents()
        {
            
            try
            {
                var result = await studentRepository.GetStudents();
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Student>> GetStudent(string id)
        {
            try
            {

                var result = await studentRepository.GetStudent(id);

                if (result == null)
                {
                    return NotFound("student not found");
                }

                return result;
                

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");

            }
        }

        [HttpPost]
        public async Task<ActionResult<Student>> CreateStudent(Student newStudent)
        {
            try
            {
                if (newStudent == null)
                {
                    return BadRequest();
                }

                var checkIfStudentExits = await studentRepository.GetStudent(newStudent.id);

                if (checkIfStudentExits != null)
                {
                    ModelState.AddModelError("id", "Error!, Student already exists");
                }


                var result = await studentRepository.CreateStudent(newStudent);

                return CreatedAtAction(nameof(GetStudent), new { id = newStudent.id }, newStudent);


            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpPut]
        public async Task<ActionResult<Student>> UpdateStudent(Student editedStudent)
        {
            try
            {
                if (editedStudent == null)
                {
                    return NotFound("Student not found");
                }

                var result = await studentRepository.UpdateStudent(editedStudent);

                return result;


            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");

            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Student>> DeleteStudent(string id)
        {
            try
            {

                var CheckIfStudentExists = await studentRepository.GetStudent(id);
                
                if (CheckIfStudentExists == null)
                {
                    return NotFound("Student not found");
                }

                var result = await studentRepository.DeleteStudent(id);

                return result;

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");

            }
        }



    }
}
