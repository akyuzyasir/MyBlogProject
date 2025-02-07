using MyBlogProject.Domain.Enums;

namespace MyBlogProject.Domain.Core.BaseEntities;

public class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public string CreatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public string? UpdatedBy { get; set; }
    public Status Status { get; set; }
}
