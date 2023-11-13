using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] student = new int[3][];
            student[0] = new int[3] { 58, 92, 78 };
            student[1] = new int[4] { 90, 87, 93, 89 };
            student[2] = new int[2] { 76, 88 };
            int avergae=0;
            for(int i = 0; i < student.Length; i++)
            {
                int count = 0; 
                int averagscore = 0;
                Console.WriteLine("Score obtain by Students");
                for (int j = 0; j < student[i].Length; j++)
                {
                    averagscore += student[i][j];
                    Console.Write(+student[i][j]+"\t");
      
                    count++;
                }
                
                int result = averagscore /count;
                avergae += result;
                Console.WriteLine();
                Console.WriteLine("Average Score of Student:\t"+result);
            }
            int result2 = avergae/3;
            Console.WriteLine("Average score of all the Student:\t"+result2);
            Console.ReadKey();
        }
    }
}
