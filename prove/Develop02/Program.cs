using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Time to Journal! please choose an option.");
        option1();
        option2();
        option3();
        option4();
        option5();
        Console.Write("WHat would you like to do?");
        

    }
    

    static void option1()
    {
        Console.WriteLine("1. Entry");
    }
    static void option2()
    {
        Console.WriteLine("2. Display");
    }
    static void option3()
    {
        Console.WriteLine("3. Load");
    }
    static void option4()
    {
        Console.WriteLine("4. Save");
    }
    static void option5()
    {
        Console.WriteLine("5. Quite");
    }
    
}
