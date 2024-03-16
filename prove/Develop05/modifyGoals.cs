public class ModifyGoals
{
    private List<Goals> _goals = new List<Goals>();
    private string _fileName;
    private int _totalPoints = 0; 

    public void AddGoal(Goals goal)
    {
        _goals.Add(goal);
    }

    public void Save()
    {
        Console.Write("What is the name for the goal file? ");
        _fileName = Console.ReadLine();
        using (FileStream stream = new FileStream(_fileName, FileMode.Create))
        {
            using (StreamWriter writer = new StreamWriter(stream))
            {   
                writer.WriteLine($"{_totalPoints}");
                foreach (Goals goal in _goals)
                {   
                    string name = goal.GetName(); 
                    string description = goal.GetDescription();
                    string points = goal.GetPoints();
                    bool finished = goal.CheckFinished();
                    bool eternal = goal.GetLength();

                    if (goal is ChecklistGoal child)
                    {
                        int times = child.GetTimes();
                        int counter = child.GetCounter();
                        int bonus = child.GetBonus();
                        writer.WriteLine($"{name}, {description}, {points}, {finished}, {eternal}, {times}, {counter}, {bonus}");
                    } else
                    {
                        writer.WriteLine($"{name}, {description}, {points}, {finished}, {eternal},");
                    }
                }
            }
        }
    }



    public void Load()
    {
        Console.Write("Enter the name of the goal file: ");
        _fileName = Console.ReadLine();
        using (FileStream stream = new FileStream(_fileName, FileMode.Open))
        {
            using (StreamReader reader = new StreamReader(stream))
            {
                _totalPoints = int.Parse(reader.ReadLine());
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(',');

                    string name = parts[0];
                    string description = parts[1];
                    string points = parts[2];
                    bool finished = bool.Parse(parts[3]);
                    bool eternal = bool.Parse(parts[4]);

                    if (parts.Length == 8)
                    {
                        int times = int.Parse(parts[5]);
                        int counter = int.Parse(parts[6]);
                        int bonus = int.Parse(parts[7]);
                        ChecklistGoal child = new ChecklistGoal(name, description, points, finished, eternal, times, counter, bonus);
                        
                        _goals.Add(child);
                    }
                    else if (eternal == true)
                    {
                        EternalGoal child = new EternalGoal(name, description, points, eternal, finished);
                        
                        _goals.Add(child);
                    }
                    else
                    {
                        SimpleGoal child = new SimpleGoal(name, description, points, eternal, finished);
                        
                        _goals.Add(child);
                    }
                }
            }
        }
    }



    public void DisplayGoals()
    {
        int goalNumber = 1;
        foreach (Goals goal in _goals)
        {   
            string endTag = "";
            if (goal is ChecklistGoal child)
            {
                int counterInt = child.GetCounter();
                int totalInt = child.GetTimes(); 
                string counter = counterInt.ToString();
                string total = totalInt.ToString(); 
                endTag = "-- Currently completed: " + counter + "/" + total;
            }

            string name = goal.GetName(); 
            string description = goal.GetDescription();
            string checkbox = "[ ]";
            if (goal.CheckFinished() == true)
            {
                checkbox = "[X]";
            }
            Console.WriteLine($"   {goalNumber}. {checkbox} {name} ({description}) {endTag}");
            goalNumber++;
        }
    }

    public List<Goals> GetGoals()
    {
        return _goals;
    }

    public void AddPoints(int points)
    {
        _totalPoints += points;
    }

    public void RemovePoints(int points)
    {
        _totalPoints -= points;
    }

    public int GetPoints()
    {
        return _totalPoints;
    }
}