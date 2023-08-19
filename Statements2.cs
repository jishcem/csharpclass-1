using System;
namespace SampleApp
{
	public class Statements2
	{
		public Statements2()
		{
			// Without initialization
            string greeting;
            int a, b, c;
            List<double> xs;
        }

		public void SomethingElse()
		{
            // With initialization
            string greeting = "Hello";
            int a = 3, b = 2, c = a + b;
            List<double> xs = new();
        }

        public void ExceptionHandling()
        {
            try
            {
                ProcessShapes(shapeAmount);
            }
            catch (Exception e)
            {
                LogError(e, "Shape processing failed.");
                throw;
            }
        }

        pubic void IterationStatement()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i);
            }
            // Output:
            // 012


            var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int element in fibNumbers)
            {
                Console.Write($"{element} ");
            }
            // Output:
            // 0 1 1 2 3 5 8 13
        }

        public void SelectionStatement()
        {
            DisplayWeatherReport(15.0);  // Output: Cold.
            DisplayWeatherReport(24.0);  // Output: Perfect!

            void DisplayWeatherReport(double tempInCelsius)
            {
                if (tempInCelsius < 20.0)
                {
                    Console.WriteLine("Cold.");
                }
                else
                {
                    Console.WriteLine("Perfect!");
                }
            }



            DisplayMeasurement(-4);  // Output: Measured value is -4; too low.
            DisplayMeasurement(5);  // Output: Measured value is 5.
            DisplayMeasurement(30);  // Output: Measured value is 30; too high.
            DisplayMeasurement(double.NaN);  // Output: Failed measurement.

            void DisplayMeasurement(double measurement)
            {
                switch (measurement)
                {
                    case < 0.0:
                        Console.WriteLine($"Measured value is {measurement}; too low.");
                        break;

                    case > 15.0:
                        Console.WriteLine($"Measured value is {measurement}; too high.");
                        break;

                    case double.NaN:
                        Console.WriteLine("Failed measurement.");
                        break;

                    default:
                        Console.WriteLine($"Measured value is {measurement}.");
                        break;
                }
            }
        }
    }
}

