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
            string [,] CombinedArr = new string[6,4];
            string [,]AvgArr = new string [5,2];
            for (int i = 0; i <= 4; i++)
            {
                System.Console.WriteLine("Enter the first name");
                string Name = Console.ReadLine();
                NameArr[i] = Name;
                for (int j = 0; j <= 2; j++)
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

            for (int i = 0; i <= 4;i++)
            { 
                CombinedArr[i,0]=NameArr[i];
                System.Console.WriteLine(CombinedArr[i,0]);
                for (int j = 0; j <= 2; j++)
                {
                    String GradeString = Grade[i,j].ToString();
                    CombinedArr[i+1,j]=GradeString;
                    System.Console.WriteLine(CombinedArr[i+1,j]);
                }   
            }

             for (int i = 0; i <= 4;i++)
            { 
                AvgArr[i,0]=NameArr[i];
                System.Console.WriteLine(AvgArr[i,0]);
                for (int j = 1; j <= 1; j++)
                {
                    double num1 =Grade[i,0];
                    double num2 =Grade[i,1];
                    double num3 =Grade[i,2];
                    double add =num1+num2+num3;
                    double  avg = add/3;
                    System.Console.WriteLine(avg);
                }   
            }




        }
    }
}

