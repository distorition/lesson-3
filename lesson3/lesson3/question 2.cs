using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    class question_2
    {
       
            //телефонный справочник
            string[,] numbook = new string[5, 2]
             {
            {"Mark","+312441 , aaaa@mail.ri" },
            {"Oleg","+123123 , sss@mail.ru" },
            {"Denis","23121231 , gag@gogle.com" },
            {"Lol","+543456 , sdafwq@mail.ry" },
            {"???","666 ???@??.??" }
             };

            foreach(var book in numbook )
            {
                Console.WriteLine(book);
            }
        
        

        
    }
}

        

          

