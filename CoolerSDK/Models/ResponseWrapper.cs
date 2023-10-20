using System.Net;

namespace CoolerSDK.Models
{
    public class HttpResponseWrapper<T>
    {
        public T? Content { get; set; }
        public HttpStatusCode httpStatusCode { get; set; }
    }
}