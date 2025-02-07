using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlogProject.Domain.Core.BaseEntities;

namespace MyBlogProject.Domain.Core.BaseEntityConfigurations;

public class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.HasKey(b => b.Id);
        builder.Property(b => b.Id).ValueGeneratedOnAdd();
        builder.Property(b => b.CreatedDate).IsRequired();
        builder.Property(b => b.CreatedBy).IsRequired();
        builder.Property(b => b.UpdatedDate).IsRequired(false);
        builder.Property(b => b.UpdatedBy).IsRequired(false);
        builder.Property(b => b.Status).IsRequired();
    }
}
