using System;

namespace gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to the Gradebook app");
            double[,] Grade = new double[5, 4];
            string[] NameArr = new string[5];
            for (int i = 0; i <= 4; i++)
            {
                System.Console.WriteLine("Enter the first name");
                string Name = Console.ReadLine();
                NameArr[i] = Name;
                for (int j = 0; j <= 3; j++)
                {
                    System.Console.WriteLine("Enter subject marks...");
                    string GradeName = Console.ReadLine();
                    try
                    {
                        int IntGrade;

                        IntGrade = Convert.ToInt32(GradeName);
                        Grade[i, j] = IntGrade;

                    }
                    catch (FormatException)
                    {
                        System.Console.WriteLine("Enter a number");
                    }
                }
            }

            for (int i = 0; i < 4;i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    System.Console.WriteLine(Grade[i, j]);
                }
            }

        }
    }
}

