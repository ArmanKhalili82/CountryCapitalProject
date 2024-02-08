using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models;

public class City
{
    [Key]
    public int Id { get; set; }
    public int CountryId { get; set; }
    [ForeignKey(nameof(CountryId))]
    public virtual Country Country { get; set; }
    public string Name { get; set; }
    public bool IsCapital { get; set; }
}
