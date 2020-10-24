using Academy_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academy.Models
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetStudents();
        Task<Student> GetStudent(string id);
        Task<Student> CreateStudent(Student newStudent);
        Task<Student> UpdateStudent(Student editStudent);
        Task<Student> DeleteStudent(string id);


    }
}
