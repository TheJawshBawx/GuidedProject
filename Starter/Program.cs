using System;

// initialize inital variables - graded assignments 
int currentAssignments = 5;
string[] studentNames = new string[] {"Sophia" , "Andrew" , "Emma" , "Logan"};

int[] sophiaScores = new int[] {90, 86, 87, 98, 100};
int[] andrewScores = new int[] {92, 89, 81, 96, 90};
int[] emmaScores = new int[] {90, 85, 87, 98, 68};
int [] loganScores = new int[] {90, 95, 87, 88, 96};

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

// Sumation and Output
Console.WriteLine($"Student\t\tGrade");
foreach (string name in studentNames)
{
    Console.WriteLine(name);foreach (int score in sophiaScores)
    {
       sophiaSum += score;
    }

    sophiaScore = (decimal)sophiaSum / currentAssignments;
    }

