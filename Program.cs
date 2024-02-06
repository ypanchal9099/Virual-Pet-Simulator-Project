
// Virtual Pet Simulator Project

using System;

class VirtualPet
{
    private string name;
    private int hunger;
    private int happiness;
    private int health;

    public VirtualPet(string petName)
    {
        name = petName;
        hunger = 60;
        happiness = 40;
        health = 50;
        //Console.WriteLine($"{petName}");
    }
    
    // Feed the pet
    public void Feed()
    {
        //string nm = name;
        //Console.WriteLine($"{name} is playing.");
        Console.WriteLine($"You feed your pet. His hunger decreses, and health improve slightly.");
        hunger = hunger - 10;
        happiness = happiness + 10;
        health = health + 15;
        //CheckStatus();
    }

    // Play with pet
    public void Play()
    {
        string nm = name;
        Console.WriteLine("Your pet is playing. Happiness increases, and hunger increase slightly.");
        hunger = hunger + 5;
        happiness = happiness + 10;
        health = health + 15;
        //CheckStatus();
    }

    public void sleep()
    {
        string nm = name;
        Console.WriteLine("You put your pet to sleep. Improve health, happiness decrease slightly.");
        hunger = hunger + 5;
        happiness = happiness + 5;
        health = health + 15;
        //CheckStatus();
    }

    // Check pet's status 
    public void CheckStatus()
    {
        //string name;
        Console.WriteLine($"Status of your pet: \n- Hunger : {hunger} \n- Happiness : {happiness} \n- Health : {health}");

        if (hunger <= 0)
        {
            Console.WriteLine($"{name} is full and happy!");
            Environment.Exit(0);
        }
        else if (hunger > 100)
        {
            Console.WriteLine($"{name} is too hungry. Game over!");
            Environment.Exit(0);
        }
    }
    public void displayName()
    {
        string s1 = "Cat"; 
        string s2 = "Dog";
        string s3 = "Rabbit";
        if (s1 == "Cat")
        {
            Console.WriteLine(value: $"\nYou have choosen a {s1}. What would you like to name your pet?");
        }
        else if (s2 == "Dog")
        {
            Console.WriteLine(value: $"\nYou have choosen a {s2}. What would you like to name your pet?");
        }
        else if(s3 == "Rabbit")
        {
            Console.WriteLine(value: $"\nYou have choosen a {s3}. What would you like to name your pet?");
        }

        Console.Write("Enter name of your pet: ");
        string pname = Console.ReadLine();
        
        Console.WriteLine($"\nWelcome, {pname}! Let's take good care of him");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Virtual Pet Care Simulator");
        Console.WriteLine("\n--------------------------");
        Console.WriteLine("Please choose a type of pet:");
        Console.WriteLine("1. Cat\n2. Dog\n3. Rabbit\n4. Exit");
        Console.Write("Choose the option(1 - 4): ");
        string petName = Console.ReadLine();
        VirtualPet myPet = new VirtualPet(petName);
        //VirtualPet name = new VirtualPet(petName)
        
        switch (petName)
        {
            case "1":
                myPet.displayName();
                break;
            case "2":
                myPet.displayName();
                break;
            case "3":
                myPet.displayName();
                break;
            case "4":
                Console.WriteLine("Goodbye!");
                return;
            default:
                Console.WriteLine("Invalid choice..");
                break;
        }

        do
        {
            Console.WriteLine("\n----- Main Menu -----");
            Console.WriteLine("1. Feed the pet");
            Console.WriteLine("2. Play with the pet");
            Console.WriteLine("3. Put the pet to rest");
            Console.WriteLine("4. Display pet status");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an action (1-5): ");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    myPet.Feed();
                    break;
                case "2":
                    myPet.Play();
                    break;
                case "3":
                    myPet.sleep();
                    break;
                case "4":
                    myPet.CheckStatus();
                    break;
                case "5":
                    Console.WriteLine("Thank you for playing with pet..Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                    break;
            }
        } while (true);
    }
}