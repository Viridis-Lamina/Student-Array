using System;

namespace StudentArray 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students do you have?");
            int StudentNum = int.Parse (Console.ReadLine());

            double averagegrade = 0;
            double highestgrade = 0;
            String Beststudent = "";

            string[] studentnames = new string [StudentNum];
            Double[] studentgrades = new Double[StudentNum];
           
            for (int i = 0; i < StudentNum; i++)
            {
                Console.WriteLine ("Enter student number {0}'s name", i+1);
                studentnames[i] = Console.ReadLine();
                Console.WriteLine("please enter {0}'s grade", studentnames[i]);
                studentgrades[i] = double.Parse (Console.ReadLine());
                averagegrade += studentgrades[i];
                Console.WriteLine();

                if (studentgrades[i] > highestgrade)
                {
                    highestgrade = studentgrades[i];
                    Beststudent = studentnames[i];
                }
            }

            Double Averageoutput = averagegrade / studentgrades.Length;
            Console.WriteLine("The average student grade is {0}", Averageoutput);
            Console.WriteLine();
            Console.WriteLine("The highest Grade is {0} Belonging to {1}", highestgrade, Beststudent);


        }
    }
}