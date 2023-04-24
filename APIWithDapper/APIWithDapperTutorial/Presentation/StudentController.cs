using APIWithDapperTutorial.Business.Student;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIWithDapperTutorial.Presentation
{
    [ApiController]
    public class StudentController : Controller
    {
        public readonly IStudentService _StudentService;

        public StudentController(IStudentService StudentService)
        {
            _StudentService = StudentService;
        }

        [HttpGet, Route("GetStudents")]
        [AllowAnonymous]
        public async Task<IActionResult> GetStudents()
        {
            var result = await _StudentService.GetStudents();

            return result.CreateResponse();
        }
    }
}
