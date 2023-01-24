using System;
//Added to use a List of Animal objects
using System.Collections.Generic;

namespace PA_1
{   
    //StartMenu class will include the  functionality of a menu
    class StartMenu
    {
        //Void function which will display the choice the user is allowed to make in the menu
        //Did not want to type this all over again at the bottom of the while loop so i made it a method
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
        //This will be what allows the user to actually interact with the menu
        public void menuInterFace()
        {
            displaymenu();
            //will read the userinput and turn it into an int for the switch case conditon
            int UsersChoice = int.Parse(Console.ReadLine());
            //will be used a counter to be used in for loops 
            int AnimalCounter = 0;

            //the creation of the list of animals
            //If all classes share a base class, we can make an list of objects of type Animal class
            List<Animal> World = new List<Animal>();
            
            //While the choice is not 7, keep looping through
            while (UsersChoice != 7)
            {
                //userChoice will depend on what case will be used
                switch (UsersChoice)
                {
                    case 1: //adding a Cat object into the list
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

                        //takes everything in passes to paramaterized constructor to create an instance of the Cat class
                        Cat cat = new Cat(Catname,Catnoise,Catage,Catweight,whiskers);
                        //Adding to the list
                        World.Add(cat);
                        //Since an animal was added we will now increment count
                        AnimalCounter++;
                        break;

                    case 2://adding a Cassowary object into the list
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

                        //takes everything in passes to paramaterized constructor to create an instance of the Cassowary class
                        Cassowary cassowary = new Cassowary(Cassowaryname, Cassowarynoise, Cassowaryage, Cassowaryweight, AngerLevel);
                        //Adding to the list
                        World.Add(cassowary);
                        //Since an animal was added we will now increment count
                        AnimalCounter++;

                        break;

                    case 3://Adding a Human object into the list
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

                        //takes everything in passes to paramaterized constructor to create an instance of the Human class
                        Human human = new Human(name, noise, age, weight, money);
                        //Adding to the list
                        World.Add(human);
                        ////Since an animal was added we will now increment count
                        AnimalCounter++;

                        break;
                    case 4://Will print the info of all animals found in the list
                        if (AnimalCounter == 0)
                        {
                            Console.WriteLine("There are no animals in the list so far!");
                        }
                        for (int i = 0; i < AnimalCounter; i++)
                        {
                            World[i].PrintInfo();
                        }
                        break;
                        
                    case 5: //Will increment age of all animals found in the list 
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
                    case 6: //will display all the noises the animals make in the list
                        if (AnimalCounter == 0)
                        {
                            Console.WriteLine("There are no animals in the list so far!");
                        }
                        for (int i = 0; i < AnimalCounter; i++)
                        {
                            Console.WriteLine($"{World[i].Name} makes the noise \"{World[i].MakeNoise()}\"");
                        }
                        break;
                    default://default means none of the other switch cases were entered meaning they entered something which is not a valid choice
                        Console.WriteLine("Try Again, this time with a valid choice!");
                        break;
                }
                // user will need to press enter to continue (small pause so not everything is thrown at them at once and they have time to read)
                Console.WriteLine("(press Enter to continue)");
                Console.ReadLine();
                //Will display choices again and the loop continues until user wants to exit program
                displaymenu();
                UsersChoice = int.Parse(Console.ReadLine());
            }
        }
    }
}
