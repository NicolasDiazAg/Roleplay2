namespace Ucu.Poo.RoleplayGame;

public class Spell : Item
{
    public Spell(string name, int attackValue, int defenseValue) : base(name, attackValue, defenseValue)
    {
        this.DefenseValue = defenseValue;
        this.AttackValue = attackValue;
    }
}
