using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSys.Models.ResponseDto
{
    public class ResponseDto<T>
    {
        public string msg { get; set; } = "";
        public int count { get; set; }
        public int code { get; set; }
        public T data { get; set; }
    }
}