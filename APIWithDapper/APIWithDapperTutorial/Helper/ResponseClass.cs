using Microsoft.AspNetCore.Mvc;

namespace APIWithDapperTutorial.Helper
{
    public class ResponseClass
    {
        public object Data { get; private set; }
        public int StatusCode { get; private set; }
        public string Message { get; private set; }
        public object Pagination { get; private set; }
        public ResponseClass(object Data, int StatusCode, string Message)
        {
            this.Data = Data;
            this.StatusCode = StatusCode;
            this.Message = Message;
        }
        public ResponseClass( object Data, int StatusCode, string Message, object Pagination) {
            this.Data = Data;
            this.StatusCode = StatusCode;
            this.Message = Message;
            this.Pagination = Pagination;
        }
        public IActionResult CreateResponse()
        {
            switch (StatusCode)
            {
                case 200:
                    return new OkObjectResult(this);
                case 201:
                    return new CreatedResult(Message, this);
                case 202:
                    return new AcceptedResult();
                case 400:
                    return new BadRequestObjectResult(this);
                case 401:
                    return new UnauthorizedResult();
                case 403:
                    return new ForbidResult();
                case 404:
                    return new NotFoundResult();
                default:
                    return new BadRequestResult();
            }
        }
    }
}
