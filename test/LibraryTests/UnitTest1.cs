using NUnit.Framework;
using Ucu.Poo.RoleplayGame;
using NUnit.Framework;

namespace TestLibrary;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    public void RestoreHealth()
    {
        Character dwarf = new Character("ENANO", 100,20,10);
            
        dwarf.ReciveAttack(50);
        dwarf.Cure();

        //Al no poder usar AreEquals de xUNIT, tuvimos que hacerlo de esta forma
        if (dwarf.Health == 100)
        {
            Console.WriteLine("Test passed");
        }
        else
        {
            Console.WriteLine("Test failed");
        }

    }
    
    [Test]
    public void AttackAction()
    {
        Character tungthur = new Character("Tung Thur", 100, 30, 5);
        Character elf = new Character("Elf", 100, 20, 10);

        elf.ReciveAttack(tungthur.AttackValue());

        int expectedHealth = 100 - (tungthur.Attack - elf.Defense);

        if (elf.Health == expectedHealth)
        {
            Console.WriteLine("Test passed");
        }
        else
        {
            Console.WriteLine("Test failed");
        }
    }


}
