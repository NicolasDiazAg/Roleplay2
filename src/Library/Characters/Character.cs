namespace Ucu.Poo.RoleplayGame;

public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public List<Item> _items { get; set; }
    public int Defense { get; set; }
    public int Attack { get; set; }

    public Character(string name,int health, int attack, int defense)
    {
        this.Name = name;
        this.Health = health;
        this.Attack = attack;
        this.Defense = defense;

    }

    public void ShowCharacter()
    {
        Console.WriteLine($"Character:{this.Name}\\n -health:{this.Health} \\n -defense:{this.Defense} \\n -attack:{this.Attack}");
    }
}