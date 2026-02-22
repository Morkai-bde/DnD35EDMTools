namespace DnD35EDMTools.Data.Classes;

public class ItemProperty
{
    public int Id  { get; set; }
    public int ItemId  { get; set; }
    public int PropertyDefinitionId  { get; set; }
    public string Value  { get; set; }

    public ItemData Item { get; set; }
    public PropertyDefinition PropertyDefinition  { get; set; }
}
