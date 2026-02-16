using System.ComponentModel.DataAnnotations;

namespace DnD35EDMTools.Data;

public class LanguageData
{
    public int Id { get; set; }
    [Required]
    [MaxLength(20)]
    public string Name { get; set; }
    [MaxLength(100)]
    public string? Description { get; set; }
    [Required]
    [MaxLength(10)]
    public string Type { get; set; } = "Living";
    [MaxLength(10)]
    public bool IsAutomatic { get; set; }
    [Required]
    [MaxLength(5)]
    public string Sourcebook { get; set; }
    public int Page { get; set; }
}