using Newtonsoft.Json;

namespace GlobalErrorHandling.Models
{
    public class ErrorClass
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }


        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}