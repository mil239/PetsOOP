﻿


using ClassLibrary1;

string input = "";

while (input != "4")
{
    Console.WriteLine("Welcome to the pet store");
    Console.WriteLine("1. Add a new pet");
    Console.WriteLine("2. List all pets");
    Console.WriteLine("3. Have two pets meet");
    Console.WriteLine("4. Exit");
    input = Console.ReadLine();
    switch (input)
    {
        case "1":
            Console.WriteLine("1. Add a new Cat");
            string petName = Console.ReadLine();
            Console.WriteLine("2. Add a new Chimpanzee");
            Console.WriteLine("3. Add a new Turtle");
            string input2 = Console.ReadLine();
            switch (input2)
            {
                case "1":
                    Cat newCat = new Cat(petName);
                    break;
                case "2":
                    Chimpanzee newChimp = new Chimpanzee(petName);
                    break;
                case "3":
                    Turtle newTurtle = new Turtle(petName);
                    break;
            }      
            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
            break;
        default:
            break;
    
    }
}