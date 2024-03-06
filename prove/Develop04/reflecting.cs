



public class ReflectingActivity : Activity 
{
    private List<string> _reflectionPrompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you took a stand for something you believed in.",
        "Think of a time when you overcame a significant obstacle.",
        "Think of a time when you made a difference in someone's life.",
        "Think of a time when you put someone else's needs before your own.",
        "Think of a time when you made a sacrifice for the greater good.",
        "Think of a time when you helped someone without expecting anything in return.",
        "Think of a time when you showed compassion to someone in need.",
        "Think of a time when you made a positive impact on your community.",
        "Think of a time when you went above and beyond to help someone.",
        "Think of a time when you demonstrated courage in a difficult situation."
    };

    private List<string> _randomQuestions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "What was the most challenging part of this experience?",
        "What did you accomplish as a result of this experience?",
        "What would you do differently if you were to experience this again?",
        "What did you gain from this experience?",
        "What was the impact of this experience on others?",
        "What was the biggest lesson you learned from this experience?",
        "How did this experience change you?"
    }; 
    private string _prompt;
    private string _question;

    public ReflectingActivity(string startMessage, string endMessage, string name) : 
    base(startMessage, endMessage, name)
    {
        _startingMessage = startMessage;
        _activityName = name;
    }

    public void RandomPrompt(){
        int index = random.Next(_reflectionPrompts.Count);
        string prompt = _reflectionPrompts[index];
        _prompt = prompt;
    }

    public void RandomQuestion(){
        int index = random.Next(_randomQuestions.Count);
        string question = _randomQuestions[index];
        _question = question;
    }

    public void Script(){
        Console.WriteLine("Get ready...");
        Console.WriteLine(" ");

        this.GetThought();
        
        this.Thinking(4);
        
        this.ClearLine();

        this.RandomPrompt();

        Console.WriteLine($" --- {_prompt} ---");
        Console.WriteLine(" ");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine(" ");
        Console.WriteLine("Now ponder on each of the following questions as they related to this experince.");
        for (int y = 5; y > -1; y--)
            {
                this.ClearLine();
                Console.Write($"You may begin in: {y}");
                Thread.Sleep(1000);

            }

        Console.Clear();

        if (_timeInput < 4)
        {
            _timeInput = 4;
        }

        for (int i = 0; i < (_timeInput / 4); i++)
            {
                this.RandomQuestion();
                Console.WriteLine($"> {_question} ");
                this.GetThought();
                this.Thinking(4);
                this.ClearLine();
            }
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