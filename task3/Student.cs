using System.Reflection.Emit;

namespace task3;


public class Student{
    public string Name;
    public int GradeLevel ;

    public int [] Scores;
    public double GetAverage(){
        int sum = 0;
       for (int i = 0; i < Scores.Length; i++)
       {
            sum += Scores[i]; 
       }
return sum /(double) Scores.Length;
        
        
    }
  


}