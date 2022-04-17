using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServer.Domain.Queries
{
    public interface IGetStudentQuery
    {
        public string StudentId { get; }
    }
}
