public class SimpleGoal : Goals
{

    public SimpleGoal(string name  = "Name", string description = "Description", string points  = "0", bool finished  = false, bool eternal = false) : base(name, description, points, finished, eternal) 
    {
    }

    public override int DoGoal(bool decide) 
    {
        int points = 0;
        if (this._goalFinished == true)
        {
            Console.WriteLine("Sorry, you allready completed this goal.");
        } else
        {
        points = int.Parse(_goalPoints);
        }
        _goalFinished = decide; // Decide whether its true or false. 
        return points;
    }
}