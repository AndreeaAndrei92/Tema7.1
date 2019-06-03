using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ReadNumber
    {
        static int ReadNumberNr(int start, int end, int i)
        {
            int number = int.Parse(Console.ReadLine());

            if ((number < start) || (number > end) || (number < i))
            {
                throw new ArgumentOutOfRangeException();
            }
            return number;
        }
    }
}

