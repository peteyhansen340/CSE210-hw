public class ListingActivity : Activity
{
    private List<string> _randomPrompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?",
        "What are some things that you are grateful for?",
        "What are some challenges you have overcome this week?",
        "What are some things that bring you joy?",
        "What are some things that you want to improve about yourself?",
        "What are some things that you have learned recently?"
    };
    private string _prompt;
    private bool _stopInput = false;

    public int _lineNumber = 0;

    
    public ListingActivity(string startMessage, string endMessage, string name) : 
    base(startMessage, endMessage, name)
    {
        _startingMessage = startMessage;
        _activityName = name;
    }
    public void RandomPrompt(){
        int index = random.Next(_randomPrompts.Count);
        string prompt = _randomPrompts[index];
        _prompt = prompt;
    }

        private void GetInput()
    {
        while (!_stopInput)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            _lineNumber += 1; 
        }
    }

    public void Script() {
        Console.WriteLine("Get ready...");
        Console.WriteLine(" ");

        this.GetThought();
        
        this.Thinking(4);
        
        this.ClearLine();

        this.RandomPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {_prompt} ---");

        for (int y = 5; y > -1; y--)
            {
                this.ClearLine();
                Console.Write($"You may begin in: {y}");
                Thread.Sleep(1000);
                if (y == 0)
                {   
                    this.ClearLine();
                    Console.Write("You may begin in: ");
                    break;
                }

            }
        Console.WriteLine("");
        
        var inputThread = new Thread(() => GetInput());
        inputThread.Start();

        var timerThread = new Thread(() => 
        {
            Thread.Sleep(_timeInput * 1000);
            _stopInput = true;
        });
        timerThread.Start();

        inputThread.Join();
        Console.WriteLine($"You listed {_lineNumber} items!");

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