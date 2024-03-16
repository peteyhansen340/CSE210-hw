using System.Xml.Serialization;
// TODO: Goals class

public abstract class Goals 
{
    protected string _goalName; 
    protected string _goalDescription; 
    protected string _goalPoints; 
    protected bool _goalFinished; // checkmark 
    protected bool _neverEnding; 

    public Goals(string name  = "Name", string description = "Description", string points  = "0", bool finished  = false, bool eternal = false)
    {
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
        _goalFinished = finished;
        _neverEnding = eternal;
    }

    public virtual void GetDetails()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine(); 
        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = Console.ReadLine(); 
    }

    public abstract int DoGoal(bool decide);

    public string GetName()
    {
        return _goalName;
    }

    public string GetDescription()
    {
        return _goalDescription; 
    }

    public bool CheckFinished()
    {
        return _goalFinished;
    }

    public string GetPoints()
    {
        return _goalPoints;
    }

    public bool GetLength()
    {
        return _neverEnding; 
    }

}


