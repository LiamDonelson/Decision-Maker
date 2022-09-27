
// This bool is for the running the program, asking them to pick an integer
bool pickingANumber = true;


// asking name 
Console.WriteLine(" Hello! What is your name?");
string name = Console.ReadLine();
Console.WriteLine(name + ", nice to meet you!");

while (pickingANumber)
{


    Console.WriteLine("Please enter an integer between 1 and 100.");
    int userInt = int.Parse(Console.ReadLine());


    // addressing if thar variable is positive and if it is between 1-100
    if (userInt <= 0 || userInt > 100)
    {
        Console.WriteLine(name + ", the integer you picked wasnt between 1 and 100. Please pick another number!");
        continue;
    }

    // building the specifications of where the number should be placed 
    if (0 != userInt % 2 && userInt < 60)
    {
        Console.WriteLine(userInt + " Odd and less than 60");
    }
    else if (0 == userInt % 2 && userInt >= 2 && userInt <= 24)
    {
        Console.WriteLine(userInt + " Even and less than 25");
    }
    else if (0 == userInt % 2 && userInt >= 26 && userInt <= 60)
    {
        Console.WriteLine(userInt + " Even and between 26 and 60 inclusive");
    }
    else if (0 == userInt % 2 && userInt > 60)
    {
        Console.WriteLine(userInt + " Even and greater than 60");
    }
    else
    {
        Console.WriteLine(userInt + " Odd and greater than 60");
    }


    // Would you like to repeat the whole process again
    bool chooseAnotherNumber = true;
    while (chooseAnotherNumber)
    {
        Console.WriteLine("Would you like to choose another number? Y/N");
        string restart = Console.ReadLine().ToLower();
        if (restart == "y")
        {
            // loops the program to pick another number
            chooseAnotherNumber = false;
        }
        else if (restart == "n")
        {
            // ends the program
            Console.WriteLine(" Have a great day " + name + "!");
            chooseAnotherNumber = false;
            pickingANumber = false;
        }
        else
        {
            // loops the second while loop because they didnt input y or n 
            Console.WriteLine(" Im sorry, im not sure what that meant.");
            continue; ;
        }
    }
    
}