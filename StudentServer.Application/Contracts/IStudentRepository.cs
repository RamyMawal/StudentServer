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
        Task<IEnumerable<Student>> GetStudentsInClassAsync(Guid classId);
        Task<IEnumerable<Student>> SearchStudentByNameAsync(string name);
    }
}
