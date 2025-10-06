namespace Ucu.Poo.RoleplayGame;

public class Armor : Item
{
    public Armor(string name, int attackValue, int defenseValue) : base(name, attackValue, defenseValue)
    {
        this.DefenseValue = defenseValue;
        this.AttackValue = attackValue;
    }
}
