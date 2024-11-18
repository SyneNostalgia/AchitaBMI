using System;

namespace bmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculating = true;

            while (continueCalculating)
            {
                Console.Clear();

                head("AlexTheExorcist");

                double height = 0.0;
                double weight = 0.0;
                Console.Write("Input your weight (kg): ");
                weight = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input your height (cm): ");
                height = Convert.ToDouble(Console.ReadLine());
                line("#", 40, ConsoleColor.DarkYellow);
                bmi(weight,height);
                line("%", 40, ConsoleColor.DarkYellow);

                Console.Write("Would you like to calculate again? (y/n): ");
                string choice = Console.ReadLine();

                while (choice != "y" && choice != "n")
                {
                    Console.WriteLine("Invalid input. Please enter 'y' for yes or 'n' for no.");
                    choice = Console.ReadLine();
                }

                continueCalculating = (choice == "y");
            }
        }

        static void line(string letter, int width, ConsoleColor color)
        {
            Console.ForegroundColor = color;

            string str = "";
            for (int i = 0; i < width; i++)
            {
                str += letter;
            }
            Console.WriteLine(str);

            Console.ResetColor();
        }
        static void head(string dev)
        {
            Console.WriteLine("Body Mass Index (BMI)");
            line("-", 40, ConsoleColor.DarkYellow);

            color("Develop by "+ dev , ConsoleColor.Magenta, ConsoleColor.White);

            line("-", 40, ConsoleColor.DarkYellow);
            Console.WriteLine("Please input your information");
        }
        static void bmi(double weight = 0.0 , double height = 0.0)
        {
            double bmi = weight / Math.Pow(height / 100, 2);
            if (bmi < 18.5)
            {
                color("From your body mass index, you are Underweight",ConsoleColor.DarkRed, ConsoleColor.Black);
            }
            else if (bmi < 25.0)
            {
                color("From your body mass index, you are Normal weight", ConsoleColor.Green, ConsoleColor.Black);
            }
            else if (bmi < 30.0)
            {
                color("From your body mass index, you are Overweight", ConsoleColor.Yellow, ConsoleColor.Black);
            }
            else
            {
                color("From your body mass index, you are Obesity", ConsoleColor.Red, ConsoleColor.Black);
            }
            Console.WriteLine("Your body mass index (BMI) is " + bmi.ToString("0.00"));
        }
        static void color(string text,ConsoleColor fg, ConsoleColor bg)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bg;

            Console.WriteLine(text);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
