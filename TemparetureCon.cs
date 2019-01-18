using System;


namespace Algorithmspgm
{
    class TemparetureCon
    {
        public void TempCon()
        {
            try
            {
                Utility uty = new Utility();
                ////Taking user input to convert
                Console.WriteLine("Which one You want Convert:");
                Console.WriteLine("Press 1.For Celcius To Fahrenheit:");
                Console.WriteLine("Press 2.For Fahrenheit To Celcius:");
                int n = uty.GetInt();
                ////Using switch case to give chosen results. 
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter temperatur in Celcius");
                        double cel = uty.GetDouble();
                        double CelsiustoFahrenheit = (cel * 9 / 5) + 32;
                        Console.WriteLine("Celsius To Fahrenheit " + CelsiustoFahrenheit);
                        break;
                    case 2:
                        Console.WriteLine("Enter temperatur in Fahrenheit");
                        double Fahrenheit = uty.GetDouble();
                        double FahrenheittoCelsius = (Fahrenheit - 32) * 5 / 9;
                        Console.WriteLine("Fahrenheit To Celsius " + FahrenheittoCelsius);
                        break;
                    default:
                        Console.WriteLine("Please give appropriate Choice");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}

