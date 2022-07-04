using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services
{
    public class StudentManagerService : IStudentManagerService
    {

        private readonly IStudentDb _studentDb;

        public StudentManagerService(IStudentDb studentDb)
        {
            _studentDb = studentDb;
        }

        public bool AddStudent(Student student)
        {

            return _studentDb.Add(student);
        }

        public List<Student> GetAllStudents()
        {
            return _studentDb.GetAllStudents();
        }
    }
}
