using APIWithDapperTutorial.Data.Repository.Student;
using APIWithDapperTutorial.Helper;

namespace APIWithDapperTutorial.Business.Student
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _StudentRepository;
        public StudentService(IStudentRepository StudentRepository) {
            _StudentRepository = StudentRepository;
        }
        public async Task<ResponseClass> GetStudents()
        {
            var students = await _StudentRepository.GetStudents();
            return students;
        }
    }
}
