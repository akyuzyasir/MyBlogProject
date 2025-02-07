using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlogProject.Domain.Core.BaseEntities;

namespace MyBlogProject.Domain.Core.BaseEntityConfigurations;

public class BaseUserConfiguration<TEntity>: AuditableEntityConfiguration<TEntity> where TEntity: BaseUser
{
    public override void Configure(EntityTypeBuilder<TEntity> builder)
    {
        base.Configure(builder);
        builder.Property(u => u.FirstName).IsRequired().HasMaxLength(128);
        builder.Property(u=>u.LastName).IsRequired().HasMaxLength(128);
        builder.Property(u => u.Email).IsRequired();
    }
}
