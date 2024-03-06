public class Activity
{
    protected string _startingMessage;
    protected string _activityName; 
    protected int _timeInput;
    private List<string> _thoughts = new List<string>() 
    {"peace", "relax", "calm", "silence", "love", "feel"};
    protected Random random = new Random();
    private string _thought;

    public Activity(string startMessage, string endMessage, string name){
        startMessage = _startingMessage;
        name = _activityName;
    }

    public void SetName(string name){
        name = _activityName;
    }

    public void StartingMessage(){
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine(" ");
        Console.WriteLine(_startingMessage);
        Console.WriteLine(" ");
    }

    public void EndingMessage(){
        Console.WriteLine($"You have completed another {_timeInput} seconds of the {_activityName}.");
    }

    public void GetThought(){
        int index = random.Next(_thoughts.Count);
        string thought = _thoughts[index];
        _thought = thought;
    }

    public void Thinking(int seconds){

        for (int i = 0; i < seconds; i++)
        {
        Console.Write(_thought);
        Console.Write(".");
        Thread.Sleep(333);
        this.ClearLine();
        
        Console.Write(_thought);
        Console.Write("..");
        Thread.Sleep(333);
        this.ClearLine();
        
        Console.Write(_thought);
        Console.Write("...");
        Thread.Sleep(333);
        this.ClearLine();
        }
    }

    public void SetTimeInput(){
        Console.Write("How long, in seconds, would you like for your session? ");
        string timeString = Console.ReadLine();
        _timeInput = int.Parse(timeString);
    }

    public void StartingScreen(){
        this.StartingMessage();
        this.SetTimeInput();  
    } 

    public void ClearLine(){
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(Enumerable.Repeat<char>(' ', Console.BufferWidth).ToArray());
        Console.SetCursorPosition(0, Console.CursorTop);
    }

    public int GetTimeInput(){
        return _timeInput;
    }

}