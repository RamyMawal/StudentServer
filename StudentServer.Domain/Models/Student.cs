using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServer.Domain.Models
{
    public class Student
    {
        private Student() { }
        public Student(
            string firstName,
            string lastName,
            Guid classId)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            ClassId = classId;
        }
        public Guid Id { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public double Average { get; private set; }
        public List<double> Grades { get; private set; } = new();
        public Guid ClassId { get; private set; }

        public void ChangeName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void ChangeClass(Guid classId)
        {
            ClassId = classId;
        }

        public void AddGrade(double grade)
        {
            Grades.Add(grade);

            Average = Grades.Sum() / Grades.Count;
        }
    }
}
