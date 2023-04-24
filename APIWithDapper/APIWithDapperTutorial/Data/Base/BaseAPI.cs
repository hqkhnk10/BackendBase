namespace APIWithDapperTutorial.Data.Base
{
    public class BaseAPI<T>
    {
        public List<T> Data { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
