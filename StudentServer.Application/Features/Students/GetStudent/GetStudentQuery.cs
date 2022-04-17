using MediatR;
using StudentServer.Domain.Models;
using StudentServer.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServer.Application.Features.Students
{
    public record GetStudentQuery
        (string StudentId): IGetStudentQuery , IRequest<StudentModel>;
}
