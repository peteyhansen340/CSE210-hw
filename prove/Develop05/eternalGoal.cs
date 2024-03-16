public class EternalGoal : Goals
{
    private new bool _neverEnding = true; 

    public EternalGoal(string name  = "Name", string description = "Description", string points  = "0", bool finished  = false, bool eternal = true) : base(name, description, points, finished, eternal) 
    {
    }

    public override void GetDetails()
    {
        base.GetDetails();
    }

    public override int DoGoal(bool decide) 
    {
        int points = int.Parse(_goalPoints);
        this._goalFinished = false;
        return points;
    }

}
