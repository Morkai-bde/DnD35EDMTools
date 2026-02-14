using System.ComponentModel.DataAnnotations;

namespace DnD35EDMTools.Data.Classes;

public class SkillData
{
    public int Id { get; set; }
    [Required] [MaxLength(75)] public string Name { get; set; } = "";
    [MaxLength(20)] public string? Attribute { get; set; }
    public bool IsTrainedOnly { get; set; }
    [Range(0, 5)] public int ArmourCheckPenaltyMultiplier { get; set; }
    public bool IsCustomizable { get; set; }
    [MaxLength(5)] public string Sourcebook { get; set; } = "";
    public int Page { get; set; } = 0;
    public List<ClassData> Classes { get; set; }
}
