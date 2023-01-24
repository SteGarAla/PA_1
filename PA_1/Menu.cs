using System;
using System.Collections.Generic;

namespace PA_1
{
    class StartMenu
    {
        private void displaymenu()
        {
            Console.WriteLine("Welcome to Programming Assignment: One (Animals in the World?)");
            Console.WriteLine("Press 1 to add Cat to list");
            Console.WriteLine("Press 2 to add Cassowary to list");
            Console.WriteLine("Press 3 to add Human to list");
            Console.WriteLine("Press 4 to display all animals in the list");
            Console.WriteLine("Press 5 to age all animals in the list");
            Console.WriteLine("Press 6 to hear the noises animals in list make");
            Console.WriteLine("Press 7 to exit program");
        }

        public void menuInterFace()
        {
            displaymenu();
            int UsersChoice = int.Parse(Console.ReadLine());
            //will be used a counter to be used in for loops 
            int AnimalCounter = 0;

            //the creation of the list of animals
            List<Animal> World = new List<Animal>();

            while (UsersChoice != 7)
            {
                switch (UsersChoice)
                {
                    case 1:
                        
                        Console.WriteLine("Enter the name of the Cat: ");
                        string Catname = Console.ReadLine();

                        Console.WriteLine("Enter the noise the Cat makes: ");
                        string Catnoise = Console.ReadLine();

                        Console.WriteLine("Enter the Age of the Cat: ");
                        int Catage = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the Weight of the Cat: ");
                        int Catweight = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the amount of whiskers on the Cat: ");
                        int whiskers = int.Parse(Console.ReadLine());

                        Cat cat = new Cat(Catname,Catnoise,Catage,Catweight,whiskers);
                        World.Add(cat);
                        AnimalCounter++;
                        break;

                    case 2:
                        Console.WriteLine("Enter the name of the Cassowary: ");
                        string Cassowaryname = Console.ReadLine();

                        Console.WriteLine("Enter the noise the Cassowary makes: ");
                        string Cassowarynoise = Console.ReadLine();

                        Console.WriteLine("Enter the Age of the Cassowary: ");
                        int Cassowaryage = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the Weight of the Cassowary: ");
                        int Cassowaryweight = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the level of anger the Cassowary has: ");
                        int AngerLevel = int.Parse(Console.ReadLine());

                        Cassowary cassowary = new Cassowary(Cassowaryname, Cassowarynoise, Cassowaryage, Cassowaryweight, AngerLevel);
                        World.Add(cassowary);
                        AnimalCounter++;

                        break;

                    case 3:
                        Console.WriteLine("Enter the name of the Human: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter the noise the Human makes: ");
                        string noise = Console.ReadLine();

                        Console.WriteLine("Enter the Age of the Human: ");
                        int age = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the Weight of the Human: ");
                        int weight = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the amount of money the human has in their account: ");
                        int money = int.Parse(Console.ReadLine());

                        Human human = new Human(name, noise, age, weight, money);
                        World.Add(human);
                        AnimalCounter++;

                        break;
                    case 4:
                        if (AnimalCounter == 0)
                        {
                            Console.WriteLine("There are no animals in the list so far!");
                        }
                        for (int i = 0; i < AnimalCounter; i++)
                        {
                            World[i].PrintInfo();
                        }
                        break;
                        
                    case 5: //age all the animals
                        if (AnimalCounter == 0)
                        {
                            Console.WriteLine("There are no animals in the list so far!");
                        }
                        for(int i = 0; i < AnimalCounter; i++)
                        {
                            Console.WriteLine($"Incrementing age for {World[i].Name} \nAge before: {World[i].Age}");
                            World[i].AgeUp();
                            Console.WriteLine($"Age after: {World[i].Age}\n");
                        }
                        break;
                    case 6: //hear all noises animals make
                        if (AnimalCounter == 0)
                        {
                            Console.WriteLine("There are no animals in the list so far!");
                        }
                        for (int i = 0; i < AnimalCounter; i++)
                        {
                            Console.WriteLine($"{World[i].Name} makes the noise \"{World[i].MakeNoise()}\"");
                        }
                        break;
                    default:
                        Console.WriteLine("Try Again, this time with a valid choice!");
                        break;
                }
                Console.WriteLine("(press Enter to continue)");
                Console.ReadLine();

                displaymenu();
                UsersChoice = int.Parse(Console.ReadLine());
            }
        }
    }
}
