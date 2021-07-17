using StudentModel.Student;
using StudentSys.Models.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSysTwo.Models.RequestDto
{
    public class StudentResponse:ResponseDto<List<StudentModel.Student.StudentModel>>
    {
       
    }
}