public class ChecklistGoal : Goals 
{
    private int _numberTimes; 
    private int _counter; 
    private int _bonus; 

    public ChecklistGoal(string name  = "Name", string description = "Description", string points  = "0", bool finished  = false, bool eternal = false, int times = 0, int counter = 0, int bonus = 0) : base(name, description, points, finished, eternal)
    {
        _numberTimes = times;
        _counter = counter;
        _bonus = bonus;
    }

    public override void GetDetails()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine(); 
        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = Console.ReadLine(); 
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string answer = Console.ReadLine();
        _numberTimes = int.Parse(answer);
        Console.Write("What is the bonus for accomplising it that many times? ");
        answer = Console.ReadLine();
        _bonus = int.Parse(answer);
    }

    public override int DoGoal(bool decide) 
    {   
        int points = 0;
        if (this._goalFinished == true)
        {
            Console.WriteLine("Sorry, you allready completed this goal.");
        } else
        {
            if (decide == true)
            {
                _counter += 1; 
            }
            if (_counter == _numberTimes)
            {
                _goalFinished = true;
            }

            points = int.Parse(_goalPoints);

            if (_goalFinished == true)
            {
                points += _bonus;
            }
        }
        return points;
    }

    public int GetCounter()
    {
        return _counter;
    }

    public int GetTimes()
    {
        return _numberTimes;
    }

    public int GetBonus()
    {
        return _bonus;
    }

}
