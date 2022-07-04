using Domain;
using System.Collections.Generic;

namespace Services
{
    public interface IStudentManagerService
    {
        bool AddStudent(Student student);
        List<Student> GetAllStudents();
    }
}