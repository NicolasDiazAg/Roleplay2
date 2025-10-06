namespace Ucu.Poo.RoleplayGame;

public class Weapon : Item
{
    public Weapon(string name, int attackValue, int defenseValue) : base(name, attackValue, defenseValue)
    {
        this.DefenseValue = defenseValue;
        this.AttackValue = attackValue;
    }
}