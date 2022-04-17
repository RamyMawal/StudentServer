using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentServer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServer.Infra.Persistence.Configurations
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);

            builder.HasIndex(s => s.ClassId);

            builder.HasIndex(s => s.Grade);

            builder.HasOne<Class>()
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.ClassId);
        }
    }
}
