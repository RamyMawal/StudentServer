using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServer.Application.Contracts
{
    public interface IUnitOfWork
    {
        public IStudentRepository Students { get; }
        public IClassRepository Classes { get; }
    }
}
