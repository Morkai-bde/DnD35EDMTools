using System.ComponentModel.DataAnnotations;

namespace DnD35EDMTools.Data.Classes;

public class PropertyDefinition
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string Name { get; set; }
    public List<int> ApplicableItemTypeIds { get; set; } = [];
    public List<int> ApplicableItemSubtypeIds { get; set; } = [];
    [MaxLength(50)]
    public string ValueType { get; set; }
    [MaxLength(50)]
    public string AppliesTo { get; set; }
    public string Description { get; set; }
}
