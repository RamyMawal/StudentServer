using StudentServer.Domain.Entities;
using StudentServer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServer.Domain.Extensions
{
    public static class EntityExtensions
    {
        public static StudentModel ToStudentModel(Student student)
            => new
            (id: student.Id.ToString(),
             firstName: student.FirstName,
             lastName: student.LastName,
             grade: student.Grade,
             classId: student.ClassId.ToString());
    }
}
