using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

[Index(nameof(ClientName), IsUnique = true)]

public class CLientEntity
{
    [Key]
    public string Id { get; set; } = null!;
    public string ClientName { get; set; } = null!;

    public virtual ICollection<ProjectEntity> Projects { get; set; } = [];
}
