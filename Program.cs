using System;
using System.Diagnostics;

bool play = true;
while (play != false)
{
    int truce = 30;//don't look here: that's the answer and I don't know how to randomly generate numbers
    int newguess = 30;
    Console.WriteLine("Try to guess the number");
    string guess = Console.ReadLine();
    try { newguess = int.Parse(guess); }
    catch { Console.WriteLine("no"); }

    if (newguess > truce)
    {
        Console.WriteLine("Sorry, too high");
    }
    else if (newguess < truce)
    {
        Console.WriteLine("Sorry, too low");
    }
    else
    {
        if (newguess == truce) ;
        {
            Console.WriteLine("You got it right");
            play = false;
                    }
    }
}
// i did a thing