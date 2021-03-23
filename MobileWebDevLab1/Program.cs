using System;
using System.Collections.Generic;

namespace MobileWebDevLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pet> pets = new List<Pet>();
            Ferret ferret = new Ferret();
            ferret.name = "Shirou";
            ferret.color = "White";
            ferret.hoursSlept = "20";
            ferret.fallen = "4";
            pets.Add(ferret);
            int choice = 0;
            
            do
            {
                Console.WriteLine("Enter the number for what animal you want to add: 1. Cat 2. Dog 3. Ferret 4. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Cat cat = new Cat();
                    Console.WriteLine("Enter the name of the cat");
                    cat.name = Console.ReadLine();
                    Console.WriteLine("Enter the color of the cat");
                    cat.color = Console.ReadLine();
                    Console.WriteLine("Enter the hours the cat slept");
                    cat.hoursSlept = Console.ReadLine();
                    Console.WriteLine("Enter the # of times the cat meowed");
                    cat.meowed = Console.ReadLine();
                    pets.Add(cat);
                }
                else if (choice == 2)
                {
                    Dog dog = new Dog();
                    Console.WriteLine("Enter the name of the dog");
                    dog.name = Console.ReadLine();
                    Console.WriteLine("Enter the color of the dog");
                    dog.color = Console.ReadLine();
                    Console.WriteLine("Enter the hours the dog slept");
                    dog.hoursSlept = Console.ReadLine();
                    Console.WriteLine("Enter the # of times the dog went outside");
                    dog.outside = Console.ReadLine();
                    pets.Add(dog);

                } 
                else if (choice == 3)
                {
                    Ferret ferr = new Ferret();
                    Console.WriteLine("Enter the name of the ferret");
                    ferr.name = Console.ReadLine();
                    Console.WriteLine("Enter the color of the ferret");
                    ferr.color = Console.ReadLine();
                    Console.WriteLine("Enter the hours the ferret slept");
                    ferr.hoursSlept = Console.ReadLine();
                    Console.WriteLine("Enter the # of times the ferret fell from a high place");
                    ferr.fallen = Console.ReadLine();
                    pets.Add(ferr);
                }
                else if (choice == 4)
                {
                 
                }
                else
                {
                    Console.WriteLine("You entered a wrong choice");
                    Console.WriteLine("Enter the number for what animal you want to add: 1. Cat 2. Dog 3. Ferret 4. Exit");
                    choice = Convert.ToInt32(Console.ReadLine());
                }

            } while (choice != 4);

            foreach (Pet pet in pets)
            {
                Console.WriteLine("Name: " + pet.name + " Color: " + pet.color + " Hours Slept: " + pet.hoursSlept);

            }
            Console.WriteLine("End");
        }
    }
}
