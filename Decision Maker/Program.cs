bool a = true;

Console.WriteLine(" Hello! What is your name?");
string name = Console.ReadLine();
Console.WriteLine(name + ", nice to meet you!");

while (a)
{


    Console.WriteLine("Please enter an integer between 1 and 100.");
    int userInt = int.Parse(Console.ReadLine());
    if (userInt <= 0 || userInt > 100)
    {
        Console.WriteLine(name + ", the integer you picked wasnt between 1 and 100. Please pick another number!");
        continue;
    }

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



    bool b = true;
    while (b)
    {
        Console.WriteLine("Would you like to choose another number? Y/N");
        string restart = Console.ReadLine().ToLower();
        if (restart == "y")
        {
            b = false;
        }
        else if (restart == "n")
        {
            Console.WriteLine(" Have a great day " + name + "!");
            b = false;
            a = false;
        }
        else
        {
            Console.WriteLine(" Im sorry, im not sure what that meant.");
            continue; ;
        }
    }
    
}