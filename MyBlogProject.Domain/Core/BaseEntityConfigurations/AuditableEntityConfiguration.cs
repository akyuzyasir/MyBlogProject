using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlogProject.Domain.Core.BaseEntities;

namespace MyBlogProject.Domain.Core.BaseEntityConfigurations;

public class AuditableEntityConfiguration<TEntity> : BaseEntityConfiguration<TEntity> where TEntity : AuditableEntity
{
    public override void Configure(EntityTypeBuilder<TEntity> builder)
    {
        base.Configure(builder);
        builder.Property(x => x.DeletedDate).IsRequired(false);
        builder.Property(x => x.DeletedBy).IsRequired(false);
    }
}
