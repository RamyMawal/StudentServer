using MediatR;
using StudentServer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServer.Application.Features.Students
{
    public record GetAllStudentsQuery() : IRequest<IList<StudentModel>>;
}
