using StudentServer.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServer.Domain.Entities
{
    public class Class
    {
        private Class()
        {

        }

        public Class(
            Guid id,
            string name,
            string code,
            Subject subject)
        {
            Id = id;
            Name = name;
            Code = code;
            Subject = subject;
        }
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Code { get; private set; }
        public Subject Subject { get; private set; }
        private List<StudentEntity> students { get; set; } = new();
        public IReadOnlyCollection<StudentEntity> Students => students;
    }
}
