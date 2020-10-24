using Academy_Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academy.Models
{
    // Modify this class to access database
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDBContext context;

        public StudentRepository(AppDBContext context)
        {
            this.context = context;
        }


        // List All students in database
        public async Task<IEnumerable<Student>> GetStudents()
        {
        
            return await context.Students.ToListAsync();
        
        }

        // Get student by Id
        public async Task<Student> GetStudent(string id)
        {
            
            return await context.Students.FirstOrDefaultAsync(e => e.id == id);
        
        }
        
        // Create new student in database
        public async Task<Student> CreateStudent(Student newStudent)
        {

            var result = await context.Students.AddAsync(newStudent);
            
            await context.SaveChangesAsync();
            
            return result.Entity;

        }

        // Update student data in database
        public async Task<Student> UpdateStudent(Student editStudent)
        {
            var result = await context.Students.FirstOrDefaultAsync(e => e.id == editStudent.id);

            context.Entry(result).CurrentValues.SetValues(editStudent);

            await context.SaveChangesAsync();
            
            return result;

        }

        // Delete student from database
        public async Task<Student> DeleteStudent(string id)
        {

            var result = await context.Students.FirstOrDefaultAsync(e => e.id == id);

            context.Remove(result);

            await context.SaveChangesAsync();

            return result;

        }

        
    }
}
