using Ucu.Poo.RoleplayGame;
using System;

public class Program
{
    static Wizzard wizzard1;
    static Wizzard wizzard2;
    static Spell spell1;
    static Spell spell2;
    public static void Main(string[] args)
    {
        Create_Wizzards_and_Spells();
        Wizzard_Fight(wizzard1, wizzard2, spell1, spell2);
        
    }

    public static void Create_Wizzards_and_Spells()
    {
        wizzard2 = new Wizzard("Mary Poppings", 100, 0, 0);
        wizzard1 = new Wizzard("Simon Petrikov", 100, 0, 0);
        Console.WriteLine($"-------- SE INICIALIZARON LOS SIGUIENTES MAGOS --------");
        wizzard1.ShowCharacter();
        wizzard2.ShowCharacter();
        //Creo los hechizos
        spell2 = new Spell("Paraguas", 0, 40);
        spell1 = new Spell("Granizo", 45, 0);
        //Asigno los hechizos
        wizzard1.SpellsBook.AddSpell(spell1);
        wizzard2.SpellsBook.AddSpell(spell2);
        Console.WriteLine($"-------- SE INICIALIZARON Y ASIGNARON LOS SIGUIENTES HECHIZOS --------");
        Console.WriteLine($"{spell1.Name}🪄 con {spell1.AttackValue}🗡 daño y {spell1.DefenseValue}️🛡️ -> ASIGNADO A {wizzard1.Name}");
        Console.WriteLine($"{spell2.Name}🪄 con {spell2.AttackValue}🗡 daño y {spell2.DefenseValue}️🛡️ -> ASIGNADO A {wizzard2.Name}");
    }
    
    public static void Wizzard_Fight(Wizzard wizzard1,  Wizzard wizzard2, Spell spell1, Spell spell2)
    {
        Console.WriteLine($"{wizzard1.Name} se volvió loco y quiere atacar a {wizzard2.Name}");
        Console.WriteLine($"{wizzard1.Name} usó {spell1.Name}❄️ en {wizzard2.Name}");
        wizzard2.ReciveAttack(wizzard1.AttackValue()); 
        Console.WriteLine($"{wizzard2.Name} tiene una defensa de {wizzard2.DefenseValue()} y tiene {wizzard1.Health} ❤️HP");
    }
}
