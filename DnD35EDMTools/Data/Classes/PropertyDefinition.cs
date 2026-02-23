using System.ComponentModel.DataAnnotations;
using DnD35EDMTools.Data.Enums;

namespace DnD35EDMTools.Data.Classes;

public class PropertyDefinition
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string Name { get; set; }
    public List<int> ApplicableItemTypeIds { get; set; } = [];
    public List<int> ApplicableItemSubtypeIds { get; set; } = [];
    public PropertyApplication AppliesTo { get; set; }
    public int? AppliedToSpecificSkillId { get; set; }
    
    [MaxLength(50)]
    public string ValueType { get; set; }
    [MaxLength(50)]
    public string Description { get; set; }
    
    public SkillData? AppliedToSpecificSkill { get; set; }
}
