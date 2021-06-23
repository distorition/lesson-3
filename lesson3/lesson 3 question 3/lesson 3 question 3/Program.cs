using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3_question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "hello";
            string revers = "";
            for(int i = hello.Length-1;i>=0;i--)
            {
                revers += hello[i];
            }
            Console.WriteLine(revers);
            
        }
    }
}
