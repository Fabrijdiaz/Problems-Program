using System;
using System.Linq;

namespace Problem_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemOne();
            ProblemFour();
            ProblemFive();
        }

        //Problem #1
        public static void ProblemOne()
        {
            int total = 0;
            int counter = 1;
            while(counter <= 100)
            {
                int result = counter / 3;
                int reminder = counter - (result * 3);
                if (reminder == 0)
                {
                    total++;
                }
                counter++;
            }
            Console.WriteLine("Total count of numbers between 1 and 100 that are divisible by 3 with no reminder: " + total);
        }

        //Problem #4
        public static void ProblemFour()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 10);
            int counter = 1;
            int guess = 0;
            while (counter <= 4)
            {
                Console.Write("\nEnter a number between 1 and 10: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("\nYou won");
                    break;
                }
                counter++;
            }
            if (guess != number)
            {
                Console.WriteLine("\nYou lost");
            }
        }

        //Problem #5
        public static void ProblemFive()
        {
            Console.Write("\nEnter a series of numbers separated by comma: ");
            string s = Console.ReadLine();
            string[] subs = s.Split(',');
            int max = 0;
            int index = 0;
            Console.WriteLine("");
            for(int i = 0; i < subs.Length; i++)
            {
                if (max < Int32.Parse(subs[i]))
                {
                    max = Int32.Parse(subs[i]);
                    index = i;
                }
            }
            Console.WriteLine(max);
        }
    }
}
