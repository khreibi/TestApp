using Domain;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class StudentDb : IStudentDb
    {
        private static readonly HashSet<StudentPersistance> _studentDb = new HashSet<StudentPersistance>();

        public bool Add(Student student)
        {
            var studentPersistance = new StudentPersistance { Name = student.Name };
            _studentDb.Add(studentPersistance);
            return true;
        }

        public List<Student> GetAllStudents()
        {
            return _studentDb.Select(e => new Student { Name = e.Name }).ToList();
        }
    }
}
