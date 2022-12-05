using System;


public class Program 
{
    public static void Main()
    {
        Console.WriteLine("Girl can I get your number please!!!");
        string stringUserInput = Console.ReadLine();
        int userInput = int.Parse(stringUserInput);
        for (int index = 1; index <= userInput; index++) 
        {
            if (index % 3 == 0 && index % 5 == 0) 
            {
                Console.WriteLine("Ping-Ping!!!");
            } 
            else if (index % 3 == 0)
            {
                Console.WriteLine("Ping");
            }
            else if (index % 5 == 0)
            {
                Console.WriteLine("Pong");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }

}
