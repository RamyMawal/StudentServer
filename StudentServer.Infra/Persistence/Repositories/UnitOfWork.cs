using StudentServer.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServer.Infra.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        private IStudentRepository _students;
        public IStudentRepository Students
        {
            get
            {
                if (_students != null)
                    return _students;
                return _students = new StudentRepository(appDbContext);
            }
        }

        private IClassRepository _classes;
        public IClassRepository Classes 
        {
            get
            {
                if (_classes != null)
                    return _classes;
                return _classes = new ClassRepository(appDbContext);
            }
        }
    }
}
