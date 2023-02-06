using StudentServer.Domain.Entities;
using StudentServer.Domain.Models;

namespace StudentServer.Domain.Extensions
{
    public static class EntityExtensions
    {
        public static Student ToStudentModel(StudentEntity student)
            => new
            (
             firstName: student.FirstName,
             lastName: student.LastName,
             classId: student.ClassId);
    }
}
