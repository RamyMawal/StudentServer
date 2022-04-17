using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServer.Domain.Entities
{
    public class Student
    {
        private Student() { }

        public Student(
            Guid id,
            string firstName,
            string lastName,
            Guid classId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            ClassId = classId;
        }

        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Grade { get; private set; }
        public Guid ClassId { get; private set; }
        public Class Class { get; private set; }
        public string ClassName { get; private set; }

        public void ChangeName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void ChangeClass(Guid classId)
        {
            ClassId = classId;
        }

        public void ChangeGrade(int grade)
        {
            Grade = grade;
        }
    }
}
