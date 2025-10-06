namespace Ucu.Poo.RoleplayGame;

public class Item
{
    public string Name { get; set; }
    
    public int Defense { get; set; }
    
    public int Attack { get; set; }

    public Item(string name, int attack, int defense)
    {
        this.Name = name;
        this.Attack = attack;
        this.Defense = defense;
    }
}