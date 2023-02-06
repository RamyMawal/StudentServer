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
    public class StudentRepository : AsyncRepository<StudentEntity>, IStudentRepository
    {
        private readonly AppDbContext _appDbContext;
        public StudentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public override async Task<StudentEntity> FindAsync(Guid id, bool includeRelated = false)
        {
            return await _appDbContext.Students.Where(s => s.Id == id).Include(c => c.Class).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<StudentEntity>> GetStudentsInClassAsync(Guid classId)
            => await _appDbContext.Students.Where(s => s.ClassId == classId).ToListAsync();

        public async Task<IEnumerable<StudentEntity>> SearchStudentByNameAsync(string name)
            => await _appDbContext.Students
            .Where(s => 
            s.FirstName.Contains(name) || 
            s.LastName.Contains(name))
            .ToListAsync();
    }
}
