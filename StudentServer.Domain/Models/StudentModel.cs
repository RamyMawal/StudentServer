using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServer.Domain.Models
{
    public class StudentModel
    {
        public StudentModel() { }
        public StudentModel(
            string id,
            string firstName,
            string lastName,
            int grade,
            string classId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
            ClassId = classId;
        }
        public string Id { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Grade { get; private set; }
        public string ClassId { get; private set; }
    }
}
