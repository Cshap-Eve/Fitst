using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentModel.Student
{
    public class StudentModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime BronDate { get; set; }
        public string Phone { get; set; }
        public string QQ { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
        public string Class { get; set; }
    }
}
