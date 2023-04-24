using APIWithDapperTutorial.Helper;

namespace APIWithDapperTutorial.Business.Student
{
    public interface IStudentService
    {
        Task<ResponseClass> GetStudents();
    }
}
