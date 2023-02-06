using StudentServer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServer.Application.Contracts
{
    public interface IStudentRepository
    {
        Task<IEnumerable<StudentEntity>> GetStudentsInClassAsync(Guid classId);
        Task<IEnumerable<StudentEntity>> SearchStudentByNameAsync(string name);
    }
}
