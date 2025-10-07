namespace Ucu.Poo.RoleplayGame;

public class SpellsBook
{
    public List<Spell> Spells { get; set; } = new List<Spell>();
    
    public int AttackValue
    {
        get
        {
            int value = 0;
            foreach (Spell spell in this.Spells)
            {
                value += spell.AttackValue;
            }
            return value;
        }
    }

    public int DefenseValue
    {
        get
        {
            int value = 0;
            foreach (Spell spell in this.Spells)
            {
                value += spell.DefenseValue;
            }
            return value;
        }
    }

    public void AddSpell(Spell spell)
    {
        this.Spells.Add(spell);
    }

    public void RemoveSpell(Spell spell)
    {
        this.Spells.Remove(spell);
    }
}
