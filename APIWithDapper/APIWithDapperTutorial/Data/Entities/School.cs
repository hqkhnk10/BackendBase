namespace APIWithDapperTutorial.Data.Entities
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get;set; }

        public List<StudentModel> Students { get; set; } = new List<StudentModel>();

    }
}
