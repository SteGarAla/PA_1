using System;

namespace PA_1
{
    //Creating the parent class that will be inheierted
    abstract class Animal
    {
        //public fields
        //The name of the Animal
        public string Name;
        //The Noise the Animal makes
        public string Noise;
        //The Age of the Animal
        public int Age;
        //The weight of the Animal
        public int Weight;

        //paramaterized constructor to initalize every value (will be used in child classes to not repeat code)
        public Animal(string name,string noise, int age, int weight)
        {
            Name = name;
            Noise = noise;
            Age = age;
            Weight = weight;
        }

        //A virutal void method that will print the info of the bird, virtual so that I can implement basic functionality and child classes will add on their small new change to it
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name} \nNoise: {Noise} \nAGE: {Age} year(s) old \nWeight: {Weight}");
        }
        //A abstract because each animal will implement their own MakeNoise()
        public abstract string MakeNoise();
        //virtual so i can implement basic incrementation and child classes will add their own spin to it
        public virtual void AgeUp()
        {
            Age++;
        }
    }

    //Creating a Cat class which is a child class of Animal class
    class Cat : Animal
    {
        //Added variable Whiskers to cat
        int Whiskers;

        //Using the base (Animal) classes constructor and adding the additional code to initalize (Whiskers)
        public Cat(string name, string noise, int age, int weight, int whiskers) : base ( name,  noise,  age, weight)
        {
            Whiskers = whiskers;
        }

        //overriding base class by using base class PrintInfo() and then adding addional Cat info to be displayed
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Whiskers: {Whiskers}\n");
        }
        //overriding base class by returning the Noise the Cat makes
        public override string MakeNoise()
        {
            return Noise;
        }
        //using base class AgeUp() and then incrementing whiskers the Cat has to override the base class AgeUp()
        public override void AgeUp()
        {
            base.AgeUp();
            //amount of whiskers goes up as they age
            Whiskers++;
        }
    }

    //Creating a Cassowary class which is a child class of Animal class
    class Cassowary : Animal
    {
        //Added variable Whiskers to cat
        int AngerLevel;

        //Using the base (Animal) classes constructor and adding the additional code to initalize (AngerLevel)
        public Cassowary(string name, string noise, int age, int weight, int angerLevel) : base(name, noise, age, weight)
        {
            AngerLevel = angerLevel;
        }

        //overriding base class by using base class PrintInfo() and then adding  Cassowary info to be displayed
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Anger Level: {AngerLevel}\n");
        }

        //overriding base class by returning the Noise the Cassowary makes
        public override string MakeNoise()
        {
            return Noise;
        }

        // using base class AgeUp() and then incrementing level of anger the Cassowary has to override the base class AgeUp()
        public override void AgeUp()
        {
            base.AgeUp();
            //amount of angriness goes up as they age, they seem live mean/angry birds
            AngerLevel += 200;
        }
    }

    //Creating a Human class which is a child class of Animal class
    class Human : Animal
    {
        //Added variable Whiskers to cat
        int MoneyInBankAccount;

        //Using the base (Animal) classes constructor and adding the additional code to initalize (MoneyInBankAccount)
        public Human(string name, string noise, int age, int weight, int Money) : base(name, noise, age, weight)
        {
            MoneyInBankAccount = Money;
        }

        //overriding base class by using base class PrintInfo() and then adding Human info to be displayed
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Money In Bank Account: {MoneyInBankAccount}\n");
        }

        //overriding base class by returning the Noise the Human makes
        public override string MakeNoise()
        {
            return Noise;
        }

        // using base class AgeUp() and then incrementing the amount of money the human has to override base class AgeUp()
        public override void AgeUp()
        {
            base.AgeUp();
            //amount of money in the bank account goes up by 1000 as they age
            MoneyInBankAccount+= 1000;
        }
    }
}
