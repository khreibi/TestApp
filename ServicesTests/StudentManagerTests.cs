using Domain;
using Moq;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using NFluent;

namespace ServicesTests
{
    public class StudentManagerTests
    {

        [Fact]
        public void GetAllStudentsTest()
        {
            var studentDbMoq = Mock.Of<IStudentDb>();
            var expected = new List<Student> { new Student { Name = "momo" } };
            Mock.Get(studentDbMoq).Setup(e => e.GetAllStudents()).Returns(expected);

            var studentManager = new StudentManagerService(studentDbMoq);

            var result = studentManager.GetAllStudents();
            Check.That(result).Equals(expected);
        }
    }
}
