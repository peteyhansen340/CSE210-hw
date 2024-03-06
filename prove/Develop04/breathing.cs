



public class BreathingActivity : Activity
{   

    public BreathingActivity(string startMessage, string endMessage, string name) : 
    base(startMessage, endMessage, name)
    {
        _startingMessage = startMessage;
        _activityName = name;
    }

    public void Breathing()
    {   
        if (_timeInput < 10)
        {
            _timeInput += 10;
        }
        
        for (int i = 0; i < (_timeInput / 10); i++)
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            for (int y = 4; y > -1; y--)
            {
                this.ClearLine();
                Console.Write($"Breath in...{y}");
                if (y == 0)
                {   
                    this.ClearLine();
                    Console.Write("Breath in...");
                    break;
                }
                Thread.Sleep(1000);

            }
            Console.WriteLine(" ");
            for (int y = 6; y > -1; y--)
            {
                this.ClearLine();
                Console.Write($"Breath out...{y}");
                if (y == 0)
                {   
                    this.ClearLine();
                    Console.Write("Breath out...");
                    break;
                }
                Thread.Sleep(1000);
            }
        }
    }
    public void Script()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.WriteLine(" ");

        this.GetThought();
        
        this.Thinking(4);
        
        this.ClearLine();

        this.Breathing();

        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("Well Done !!");

        this.GetThought();
        this.Thinking(4);

        Console.WriteLine(" ");
        Console.WriteLine(" ");
        this.EndingMessage();

        this.GetThought();
        this.Thinking(4);
    }
}
