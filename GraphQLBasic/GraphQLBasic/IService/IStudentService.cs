using GraphQLBasic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLBasic.IService
{
    public interface IStudentService
    {
        List<Student> GetStudents();
    }
}
