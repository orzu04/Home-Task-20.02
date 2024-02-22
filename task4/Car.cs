namespace task4;

public class Car
{

   public string  Make;
   public string  Model;
   public int Year;
   public double Mileage;
   public double Fuel;

public void Drive (double miles)
{

  Mileage = miles;
  System.Console.WriteLine(Mileage);

}

   public void AddFuel(double gallons)  {
     Fuel = gallons ;
     System.Console.WriteLine(Fuel);
   }
   


}
