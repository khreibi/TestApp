using Domain;
using Services;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentManager = new StudentManagerService();

            var student1 = new Student {  Name = "momo" };
            var student2 = new Student {  Name = "koko" };
            studentManager.AddStudent(student1);
        }
    }
}
