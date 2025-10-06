namespace Ucu.Poo.RoleplayGame;

public class Item
{
    public string Name { get; set; }
    
    public int DefenseValue { get; set; }
    
    public int AttackValue { get; set; }

    public Item(string name, int attackValue, int defenseValue)
    {
        this.Name = name;
        this.AttackValue = attackValue;
        this.DefenseValue = defenseValue;
    }
}