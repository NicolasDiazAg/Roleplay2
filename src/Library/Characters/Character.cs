namespace Ucu.Poo.RoleplayGame;

public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public List<Item> items { get; set; }
    public int Defense { get; set; }
    public int Attack { get; set; }
    public Character(string name,int health, int attack, int defense)
    {
        this.Name = name;
        this.Health = health;
        this.Attack = attack;
        this.Defense = defense;
    }

    public int AttackValue()
    {
        foreach (var VARIABLE in this.items)
        {
            Attack += VARIABLE.AttackValue;
        }

        return Attack;
    }
    public void ReciveAttack(int damage)
    {
        if (this.Defense < damage)
        {
            this.Health -= damage - this.Defense;
        }
    }
    
    public void Cure()
    {
        this.Health = 100;
    }
    
    public void ShowCharacter()
    {
        Console.WriteLine($"Character:{this.Name}\\n -health:{this.Health} \\n -defense:{this.Defense} \\n -attack:{this.Attack}");
    }
}