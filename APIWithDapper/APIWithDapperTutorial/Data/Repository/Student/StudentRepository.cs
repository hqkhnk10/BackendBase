using APIWithDapperTutorial.Data.Entities;
using APIWithDapperTutorial.Helper;
using Dapper;
using MySqlConnector;

namespace APIWithDapperTutorial.Data.Repository.Student
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IConfiguration _configuration;

        public StudentRepository(
            IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionStrings").GetSection("MySqlConnection").Value;
            return connection;
        }
        public async Task<ResponseClass> GetStudents()
        {
            var connectionString = this.GetConnection();
            using var conn = new MySqlConnection(connectionString);
            try
            {
                var query = "SELECT * FROM Student";
                conn.Open();
                var students = await conn.QueryAsync<StudentModel>(query);
                var newResult = new ResponseClass(students, 200, "Success");
                return newResult;
            }
            catch (Exception ex)
            {
                var newResult = new ResponseClass(null, 400, ex.Message);
                return newResult;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
