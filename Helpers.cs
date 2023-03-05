using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flashcards
{
    internal class Helpers
    {
        internal static int GetNumberInput()
        {
            string Input = Console.ReadLine();
            int ConvertedInput;

            while (!int.TryParse(Input, out ConvertedInput))
            {
                Console.WriteLine("Please input numbers");
                Input = Console.ReadLine();
            }
            return ConvertedInput;
        }
    }
}
