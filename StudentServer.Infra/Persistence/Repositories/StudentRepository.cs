using Microsoft.EntityFrameworkCore;
using StudentServer.Application.Contracts;
using StudentServer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServer.Infra.Persistence.Repositories
{
    public class StudentRepository : AsyncRepository<Student>, IStudentRepository
    {
        private readonly AppDbContext _appDbContext;
        public StudentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public override async Task<Student> FindAsync(Guid id, bool includeRelated = false)
        {
            return await _appDbContext.Students.Where(s => s.Id == id).Include(c => c.Class).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Student>> GetStudentsInClassAsync(Guid classId)
            => await _appDbContext.Students.Where(s => s.ClassId == classId).ToListAsync();

        public async Task<IEnumerable<Student>> SearchStudentByNameAsync(string name)
            => await _appDbContext.Students
            .Where(s => 
            s.FirstName.Contains(name) || 
            s.LastName.Contains(name))
            .ToListAsync();
    }
}
