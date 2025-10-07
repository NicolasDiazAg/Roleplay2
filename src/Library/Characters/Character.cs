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
        this.items = new List<Item>();
    }

    public virtual int AttackValue()
    {
        foreach (var VARIABLE in this.items)
        {
            Attack += VARIABLE.AttackValue;
        }

        return Attack;
    }

    public virtual int DefenseValue()
    {
        foreach (var VARIABLE in this.items)
        {
            Defense += VARIABLE.DefenseValue;
        }
        
        return Defense;
    }
    public void ReciveAttack(int damage)
    {
        int finaldamage = damage - DefenseValue(); 
        if (finaldamage > 0)
        {
            this.Health -= finaldamage;
            if (this.Health < 0)
            {
                this.Health = 0;
            }
        }
    }

    public void AddItem(Item item)
    {
        this.items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        this.items.Remove(item);
    }
    
    public void Cure()
    {
        this.Health = 100;
    }
    
    public void ShowCharacter()
    {
        Console.WriteLine(
            $"Character:{this.Name}\n -health:{this.Health} \n -defense:{this.Defense} \n -attack:{this.Attack}");
    }
    
    
}