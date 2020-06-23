using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models
{
    public class Response
    {
        public string Message { get; set; }
        public object Result { get; set; }
        public bool IsSuccess { get; set; }
    }
}
