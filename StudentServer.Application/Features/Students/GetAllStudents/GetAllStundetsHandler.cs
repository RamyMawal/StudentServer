using MediatR;
using StudentServer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StudentServer.Application.Features.Students
{
    public class GetAllStundetsHandler : IRequestHandler<GetAllStudentsQuery, IList<Student>>
    {
        public Task<IList<Student>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
