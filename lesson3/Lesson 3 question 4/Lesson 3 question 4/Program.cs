using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] WaterFight = new string[10, 10]
            {
                {"O","O","X","O","O","X", "O","O","O","O" },
                {"O","O","X","O","O","X", "O","O","O","O" },
                {"O","O","X","O","O","X", "O","O","O","O" },
                { "O","O","O","O","O","O", "O","O","O","X"},
                { "O","O","O","O","O","O", "O","O","O","X"},
                {"O","O","O","O","O","O", "O","O","O","O" },
                { "X","O","O","O","O","O", "O","O","O","O"},
                { "X","O","O","O","O","O", "O","O","O","O"},
                {"O","O","O","O","O","O", "O","O","O","O" },
                { "X","O","O","O","O","O", "O","X","X","X"},
            };


            
            for (int i = 0; i < WaterFight.GetLength(0); i++)
            {
                for(int j=0;j< WaterFight.GetLength(1);j++)
                {
                    Console.Write($"{WaterFight[i, j]}"+" ");
                }
                Console.WriteLine();
            }
           




        }
    }
}
