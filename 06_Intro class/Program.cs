using _06_Intro_class;

internal class Program
{
    private static void Main(string[] args)
    {
        Character character = new Character("Elf", 100, 5);
        character.Print();

        Console.WriteLine();


        Console.WriteLine(character);

        character.Name = "    ";
        character.Name = "King Elf";
        Console.WriteLine(character);

        Character character1 = new Character(hp: 150, name: "Mage", damage: 2);
        Console.WriteLine(character1);
        Character character2 = new Character{ Name = "Warrior", Damage = 10 };
        Console.WriteLine(character2);
        //character1.KPD = 123; // error 
    }
}