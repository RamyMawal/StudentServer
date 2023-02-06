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
    public class StudentConfig : IEntityTypeConfiguration<StudentEntity>
    {
        public void Configure(EntityTypeBuilder<StudentEntity> builder)
        {
            builder.HasKey(s => s.Id);

            builder.HasIndex(s => s.ClassId);

            builder.HasIndex(s => s.Average);

            builder.HasOne<Class>()
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.ClassId);
        }
    }
}
