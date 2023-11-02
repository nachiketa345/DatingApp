using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Errors
{
    public class ApiException
    {
       
        public ApiException(int statusCode,string message,string deatils)
        {
            Details = deatils;
            Message = message;
            StatusCode = statusCode;

        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
    }
}