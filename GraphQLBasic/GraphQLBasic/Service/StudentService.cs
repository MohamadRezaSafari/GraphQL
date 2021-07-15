using GraphQLBasic.IService;
using GraphQLBasic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLBasic.Service
{
    public class StudentService : IStudentService
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 9; i++)
            {
                students.Add(new Student()
                {
                    StudentId = i,
                    Name = "Stu " + i,
                    Role = "100" + i
                });
            }

            return students;
        }
    }
}
