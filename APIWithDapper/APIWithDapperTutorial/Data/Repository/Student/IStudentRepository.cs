using APIWithDapperTutorial.Helper;

namespace APIWithDapperTutorial.Data.Repository.Student
{
    public interface IStudentRepository
    {
        Task<ResponseClass> GetStudents();
    }
}
