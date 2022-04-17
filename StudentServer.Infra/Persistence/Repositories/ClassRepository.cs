using StudentServer.Application.Contracts;
using StudentServer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServer.Infra.Persistence.Repositories
{
    partial class ClassRepository : AsyncRepository<Class>, IClassRepository
    {
        private readonly AppDbContext appDbContext;

        public ClassRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            this.appDbContext = appDbContext;
        }

    }
}
