using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class CharStat
    {
        public char Character;
        public uint Counter;
        public decimal Percentage;

        public void WriteToConsole()
        {
            Console.WriteLine(" " + Character + " ; " + Percentage + "% ; " + Counter);
        }
    }
}
