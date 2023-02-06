using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServer.Domain.Entities
{
    public class StudentEntity
    {
        private StudentEntity() { }

        public StudentEntity(
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
        public float Average { get; private set; }
        public List<float> Grades { get; private set; } 
        public Guid ClassId { get; private set; }
        public Class Class { get; private set; }
        public string ClassName { get; private set; }

        
    }
}
