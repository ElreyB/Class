using System;
using System.Collections.Generic;


class Animal
{
  public string Name;
  public string Species;
  public int Age;
}

public class Program
{
  public static void Main()
  {
    Animal cat = new Animal();
    cat.Name = "Mittens";
    cat.Species = "Feline";
    cat.Age = 5;

    Animal dog = new Animal();
    dog.Name = "Sparky";
    dog.Species = "K-9";
    dog.Age = 8;

    Animal bird = new Animal();
    bird.Name = "Poopy Bottom";
    bird.Species = "Aves";
    bird.Age = 15;

    Animal kitten = new Animal();
    kitten.Name = "Puss";
    kitten.Species = "Feline";
    kitten.Age = 1;

    List<Animal> AnimalsToAdopt = new List<Animal>() {cat, dog, bird, kitten};
    foreach(Animal adoptable in AnimalsToAdopt)
    {
      Console.WriteLine("Name: " + adoptable.Name);
      Console.WriteLine("Species: " + adoptable.Species);
      Console.WriteLine("Age; " + adoptable.Age + "\n");
    }

    for(int i=0; i < AnimalsToAdopt.Count; i++)
    {
      if(AnimalsToAdopt[i].Name == "Puss")
        {
          AnimalsToAdopt[i].Age = 2;
        }
    }

    Console.WriteLine("============Puss age changed=============\n");

    foreach(Animal adoptable in AnimalsToAdopt)
    {
      Console.WriteLine("Name: " + adoptable.Name);
      Console.WriteLine("Species: " + adoptable.Species);
      Console.WriteLine("Age: " + adoptable.Age + "\n");
    }

    Console.WriteLine("What is the maximum age for you new pet?");
    string petMaxAge = Console.ReadLine();
    int maxAge = int.Parse(petMaxAge);

    foreach(Animal adoptable in AnimalsToAdopt)
    {
      if(adoptable.Age <= maxAge)
      {
        Console.WriteLine("====Animals you may like====\n");
        Console.WriteLine("Name: " + adoptable.Name);
        Console.WriteLine("Species: " + adoptable.Species);
        Console.WriteLine("Age: " + adoptable.Age + "\n");
      }
    }
  }
}
