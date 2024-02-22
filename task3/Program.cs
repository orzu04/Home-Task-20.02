

using task3;

var student1= new Student();
student1.Name = "Ali";
student1.GradeLevel = 11;
student1.Scores = new int [5]{90,93,92,94,99};



var student2 = new Student();

student2.Name = "Mumtoz";
student2.GradeLevel = 11;
student2.Scores = new int [5]{75,53,62,84,94};



double avereg = student1.GetAverage();
if(avereg>=85)
{
    System.Console.WriteLine($"Congratulations {student1.Name} on achieving above average scores {student1.GetAverage} in grade {student1.GradeLevel}! Keep up the good work!");
}
else if(avereg <85 || avereg >70)
{
    System.Console.WriteLine($"{student1.Name}, if you're having difficulties with your studies, don't hesitate toseek help. Your current average score is {student1.GetAverage} in grade {student1.GradeLevel}.");
}
else  {
    System.Console.WriteLine($"Ruhaftoda nashav az boloi hudad bisyortar kor kun");
}


