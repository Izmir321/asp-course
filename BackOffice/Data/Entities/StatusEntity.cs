using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

[Index(nameof(StatusName), IsUnique = true)]

public class StatusEntity
{
    [Key]
    public string Id { get; set; } = null!;
    public string StatusName { get; set; } = null!;

    public virtual ICollection<ProjectEntity> Projects { get; set; } = [];


}