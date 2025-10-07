using System.Runtime.CompilerServices;

namespace Ucu.Poo.RoleplayGame;

public class Wizzard : Character
{
    public SpellsBook SpellsBook { get; set; }
    
    public override int AttackValue()
    {
        foreach (var VARIABLE in this.items)
        {
            Attack += VARIABLE.AttackValue;
        }
        
        foreach (var Spell in this.SpellsBook.Spells)
        {
            Attack += Spell.AttackValue;
        }

        return Attack;
    }

    public override int DefenseValue()
    {
        foreach (var VARIABLE in this.items)
        {
            Defense += VARIABLE.DefenseValue;
        }

        foreach (var Spell in this.SpellsBook.Spells)
        {
            Defense += Spell.DefenseValue;
        }
        
        return Defense;
    }
    
    public Wizzard(string name, int health, int attack, int defense) : base(name, health, attack, defense)
    {
        SpellsBook = new SpellsBook();
    }
}