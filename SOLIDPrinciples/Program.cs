using DependencyInversion;
using InterfaceSegregation;
using LiskovSubstitution;
using OpenClosed;
using OpenClosed.Minions;
using SingleResponsibility;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("---------------- Single Responsibility Principle ----------------");
        

        Student student = new("Kayla", "Huber", 100, 80);

        Assignment assignment = new("Final Project", 60);

        student.DoAssignment(assignment);

        Console.WriteLine("---------------- Open/Closed Principle ----------------");

        Hero hero = new(100, 50, 40, 20);

        Ogre ogre = new(80, 40, 10);

        hero.Battle(ogre);

        Sidekick sidekick = new(80, 30, 20, 10);

        sidekick.Battle(ogre);

        Console.WriteLine("\n---------------- Liskov Substitution Principle ----------------");

        Birdkeeper birdkeeper = new Birdkeeper();

        birdkeeper.AddBird(new Hawk());
        birdkeeper.AddBird(new Duck());
        birdkeeper.AddBird(new Pigeon());
        birdkeeper.AddBird(new Penguin());

        birdkeeper.FeedBirds();
        birdkeeper.BirdsFlyAround();

        Console.WriteLine("\n---------------- Interface Segregation Principle ----------------");

        Restaurant restaurant = new Restaurant(new Cook(), new Waiter());

        restaurant.OpenRestaurant();

        Console.WriteLine("\n---------------- Dependency Inversion Principle ----------------");

        CharacterBuilder characterBuilder = new CharacterBuilder(new Human());
        characterBuilder.ChangeAge(33);
        characterBuilder.ChangeEyeColor("Blue");
        characterBuilder.ChangeHairColor("Brown");
        characterBuilder.ChangeWeight(130);
        Console.WriteLine(characterBuilder.ToString());

        CharacterBuilder characterBuilder2 = new CharacterBuilder(new Monster());
        characterBuilder2.ChangeAge(100);
        characterBuilder2.ChangeEyeColor("Green");
        characterBuilder2.ChangeHairColor("Green");
        characterBuilder2.ChangeWeight(500);
        Console.WriteLine(characterBuilder2.ToString());

        Console.Read();
    }
}