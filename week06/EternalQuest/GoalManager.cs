using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score; 
    private List<string> _levels = new List<string>();
    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        bool workOnGoals = true;
        while (workOnGoals)
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("-------Menu Options-----");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Levels Achieved");
            Console.WriteLine("7. Quit");
            string userSelection = Console.ReadLine();
            if (userSelection == "1")
            {
                CreateGoal();
            }

            else if (userSelection == "2")
            {
                ListGoalDetails();
            }

            else if (userSelection == "3")
            {
                Console.Write("What's the name of the file you which to save your goals to? ");
                string filename = Console.ReadLine();
                SaveGoals(filename);
                Console.WriteLine("Goals Saved");
            }

            else if (userSelection == "4")
            {
                Console.Write("What's the name of the file you which to load your goals from? ");
                string filename = Console.ReadLine();
                LoadGoals(filename);
                Console.WriteLine("Goals Loaded");
            }

            else if (userSelection == "5")
            {
                RecordEvent();
                CalculateLevel();
            }

            else if (userSelection == "6")
            {
                DisplayLevelsAchieved();
            }

            else if (userSelection == "7")
            {
                workOnGoals = false;
            }

            else
            {
               Console.WriteLine("Sorry, that's not a valid selection, please try again");
            }

        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have: {_score} points");
        DisplayLevel();
    }

    public void ListGoalNames()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        ListGoalNames();
        Console.WriteLine("What type of goal would you like to create?");
        string goalType = Console.ReadLine();


        if (goalType == "1")
        {
            Console.WriteLine("What is the name for your goal?");
            string goalName = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            string goalDescription = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated to this goal?");
            int goalPoints = int.Parse(Console.ReadLine());
            SimpleGoal goal = new SimpleGoal(goalName, goalDescription, goalPoints);
            _goals.Add(goal);
        }

        else if (goalType == "2")
        {
            Console.WriteLine("What is the name for your goal?");
            string goalName = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            string goalDescription = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated to this goal?");
            int goalPoints = int.Parse(Console.ReadLine());
            EternalGoal goal = new EternalGoal(goalName, goalDescription, goalPoints);
            _goals.Add(goal);
        }

        else if (goalType == "3")
        {
            Console.WriteLine("What is the name for your goal?");
            string goalName = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            string goalDescription = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated to this goal?");
            int goalPoints = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times does this goal need to be accomplish for a bonus?");
            int goalTarget = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            int goalBonus = int.Parse(Console.ReadLine());
            ChecklistGoal goal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);
            _goals.Add(goal);
        }

        else
        {
            Console.WriteLine("Sorry, that's not a valid selection, please try again");
        }
    }

    public void RecordEvent()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetName()}");
            index++;
        }
        Console.WriteLine("Which goal did you accomplish?");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        Goal goalSelected = _goals[goalIndex];
        if (goalSelected.IsComplete())
        {
            Console.WriteLine("You've already completed this goal");
        }

        else
        {
            goalSelected.RecordEvent();
            _score+= goalSelected.GetPoints();
            Console.WriteLine($"Congratulations! You earned {goalSelected.GetPoints()} points");
            if (goalSelected is ChecklistGoal checklist && checklist.IsComplete())
            {
                _score+= checklist.GetBonus();
                Console.WriteLine($"You earned an additional {checklist.GetBonus()} bonus");
            }
        }
         
    }

    public void CalculateLevel()
    {
        if (_score >= 2000 && !_levels.Contains("Celestial"))
        {
            _levels.Add("Celestial");
            Console.WriteLine("leveling up");
            ShowSpinner(3);
            Console.WriteLine("Level Achieved: \n");
            Console.WriteLine("Celestial");
            Console.WriteLine("You have reached the stars. Your quest is eternal, and your legacy is written in light.");
        } 

        else if (_score >= 1500 && !_levels.Contains("Seraph"))
        {
            _levels.Add("Seraph");
            Console.WriteLine("leveling up");
            ShowSpinner(3);
            Console.WriteLine("Level Achieved: \n");
            Console.WriteLine("Seraph");
            Console.WriteLine("You have transcended the struggle. Your goals are no longer chores, but part of your nature.");
        }

        else if (_score >= 1000 && !_levels.Contains("Virtuoso"))
        {
            _levels.Add("Virtuoso");
            Console.WriteLine("leveling up");
            ShowSpinner(3);
            Console.WriteLine("Level Achieved: \n");
            Console.WriteLine("Virtuoso");
            Console.WriteLine("Your progress is a work of art. You perform your daily tasks with effortless precision.");	
        }

        else if (_score >= 500 && !_levels.Contains("Dominus"))
        {
            _levels.Add("Dominus");
            Console.WriteLine("leveling up");
            ShowSpinner(3);
            Console.WriteLine("Level Achieved: \n");
            Console.WriteLine("Dominus");
            Console.WriteLine("Mastery is yours. You dominate your habits rather than letting them dominate you.");		
        }

        else if (_score >= 400 && !_levels.Contains("Centurion"))
        {
            _levels.Add("Centurion");
            Console.WriteLine("leveling up");
            ShowSpinner(3);
            Console.WriteLine("Level Achieved: \n");
            Console.WriteLine("Centurion");
            Console.WriteLine("Command over oneself is the greatest victory. 100% dedication is your new baseline.");	
        }

        else if (_score >= 300 && !_levels.Contains("Squadron Leader"))
        {
            _levels.Add("Squadron Leader");
            Console.WriteLine("leveling up");
            ShowSpinner(3);
            Console.WriteLine("Level Achieved: \n");
            Console.WriteLine("Squadron Leader");
            Console.WriteLine("You have mastered your own routine and now inspire others by your consistent example.");
        }

        else if (_score >= 200 && !_levels.Contains("Paladin"))
        {
            _levels.Add("Paladin");
            Console.WriteLine("leveling up");
            ShowSpinner(3);
            Console.WriteLine("Level Achieved: \n");
            Console.WriteLine("Paladin");
            Console.WriteLine("A champion of discipline. You no longer just watch; you act with a holy purpose.");
        }
        else if (_score >= 100 && !_levels.Contains("Sentinel"))
        {
            _levels.Add("Sentinel");
            Console.WriteLine("leveling up");
            ShowSpinner(3);
            Console.WriteLine("Level Achieved: \n");
            Console.WriteLine("Sentinel");
            Console.WriteLine("You have stood your ground and taken the first steps. The watch begins here.");
        }

        

        

        

        

        

        

        
    }
    public string GetCurrentLevel()
    {   
        string currentLevel = "";
        if (_levels.Count == 0)
        {
            return currentLevel;
        }

        else
        {
            currentLevel = _levels[_levels.Count - 1];
            return currentLevel;
        }
    }
    public void DisplayLevel()
    {
        if (_levels.Count == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Achieve your goals to start leveling up");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"{GetCurrentLevel()} Level");  
        }
        
    }

    public void DisplayLevelsAchieved()
    {   
        Console.WriteLine();
        Console.WriteLine("Your level badges:");
        foreach (string level in _levels)
        {
            Console.WriteLine(level);
        }
    }
    public void ShowSpinner(int seconds)
    {   
        List<string> spinner = ["|","/","—","\\", "|", "/", "—", "\\"];
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(3);
        int i = 0;
        while (DateTime.Now <= endTime)
        {   
            Console.Write(spinner[i]);
            Thread.Sleep(400);
            Console.Write("\b \b");
            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
        }  
    }
    public void SaveGoals(string filename)
    {
        using (StreamWriter filewriter = new StreamWriter(filename))
        {
            filewriter.WriteLine(_score);
            string levels = string.Join(",", _levels);
            filewriter.WriteLine(levels);

            foreach (Goal goal in _goals)
            {
                filewriter.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        _levels.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        if (!string.IsNullOrWhiteSpace(lines[1]))
        {
            string[] levels = lines[1].Split(",");
            foreach (string level in levels)
            {
                _levels.Add(level);
            }
        }

        for (int i = 2; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split("|");
            List<string> goalDetails = new List<string>();
            goalDetails.Add(parts[0]);
            if (goalDetails[0]== "SimpleGoal:")
            {
                goalDetails.Add(parts[1]);
                goalDetails.Add(parts[2]);
                goalDetails.Add(parts[3]);
                goalDetails.Add(parts[4]);
                SimpleGoal goal = new SimpleGoal(goalDetails[1], goalDetails[2], int.Parse(goalDetails[3]));
                if (goalDetails[4] == "true")
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }

            else if (goalDetails[0]== "EternalGoal:")
            {
                goalDetails.Add(parts[1]);
                goalDetails.Add(parts[2]);
                goalDetails.Add(parts[3]);
                EternalGoal goal = new EternalGoal(goalDetails[1], goalDetails[2], int.Parse(goalDetails[3]));
                _goals.Add(goal);
            }
            else if (goalDetails[0]== "ChecklistGoal:")
            {
                goalDetails.Add(parts[1]);
                goalDetails.Add(parts[2]);
                goalDetails.Add(parts[3]);
                goalDetails.Add(parts[4]);
                goalDetails.Add(parts[5]);
                goalDetails.Add(parts[6]);
                ChecklistGoal goal = new ChecklistGoal(goalDetails[1], goalDetails[2], int.Parse(goalDetails[3]), int.Parse(goalDetails[5]), int.Parse(goalDetails[6]));
                goal.SetTimesCompleted(int.Parse(parts[4]));
                _goals.Add(goal);
            }
        }

    }
}

    
