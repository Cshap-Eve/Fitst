using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSys.Models.StudentDto
{
    public class StudentDto
    {
        public int page { get; set; }
        public int limit { get; set; }
        public string Name { get; set; }
        public string className { get; set; }
        public string phone { get; set; }
        public DateTime? DateTime { get; set; }
    }
}