using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    class Program:question_2
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3] 
            {
                { 1, 2, 3, } ,
                { 4, 5, 6 } ,
                { 7, 8, 9 } 
            };

            for(int i=0; i<array.GetLength(0);i++)
            {
                for(int j=0;j<array.GetLength(1);j++)
                Console.WriteLine(array[i,j]);
            }

        
      
        }
    }
}
