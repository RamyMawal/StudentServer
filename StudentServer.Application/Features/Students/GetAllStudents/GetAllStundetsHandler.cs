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
    public class GetAllStundetsHandler : IRequestHandler<GetAllStudentsQuery, IList<StudentModel>>
    {
        public Task<IList<StudentModel>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
