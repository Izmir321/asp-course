
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Domain.Models;

public class Client
{
    public string Id { get; set; } = null!;
    public string ClientName { get; set; } = null!;

}
