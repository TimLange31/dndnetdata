namespace DungeonsData.Models;

public class Damage
{
    public DamageType Damage_Type { get; set; }
    public Dictionary<string, string> Damage_At_Slot_Level { get; set; }
}
