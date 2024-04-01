namespace DungeonsData.Models;

public class Monster
{
    public string Index { get; set; }
    public string Name { get; set; }
    public string Size { get; set; }
    public string Type { get; set; }
    public string Alignment { get; set; }
    public List<ArmorClass> Armor_Class { get; set; }
    public int Hit_Points { get; set; }
    public string Hit_Dice { get; set; }
    public string Hit_Points_Roll { get; set; }
    public Speed Speed { get; set; }
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }
    public List<Proficiency> Proficiencies { get; set; }
    public List<string> Damage_Vulnerabilities { get; set; }
    public List<string> Damage_Resistances { get; set; }
    public List<string> Damage_Immunities { get; set; }
    public List<ConditionImmunity> Condition_Immunities { get; set; }
    public Senses Senses { get; set; }
    public string Languages { get; set; }
    public double Challenge_Rating { get; set; }
    public int Proficiency_Bonus { get; set; }
    public int Xp { get; set; }
    public List<SpecialAbility> Special_Abilities { get; set; }
    public List<Action> Actions { get; set; }
    public List<LegendaryAction> Legendary_Actions { get; set; }
    public string Image { get; set; }
    public string Url { get; set; }
}
