using System.Reflection.Emit;

namespace task3;


public class Student{
    public string Name;
    public int GradeLevel ;

    public int [] Scores = new  int [5];
    public int GetAverage(){
        int sum = 0;
       for (int i = 0; i < Scores.Length; i++)
       {
            sum += i; 
       }
return sum / Scores.Length;
        
        
    }
  public string Getinfo()
  {
    if (GetAverage() > 85)
    return $"Congratulations Shahrom Sharipov on achieving above average scores {GetAverage()} in grade {GradeLevel}! Keep up the good work!";
    else if(GetAverage() <70)

    {
           return $"Abdulloh Abdulloev, if you're having difficulties with your studies, don't hesitate to seek help. Your current average score is {GetAverage} in grade {GradeLevel}.";
    }
    else  (GetAverage()>70 && GetAverage()<85)
    {
        return $"Congratulations Alijoni Zabiri on achieving above average scores {GetAverage()} in {GradeLevel} Keep up the good work!";
    }
  }


}