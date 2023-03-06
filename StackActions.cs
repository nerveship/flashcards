using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace flashcards
{
    internal class StackActions
    {
        internal void ViewStack()
        {
            Console.Clear();
            Console.WriteLine("View stack page");
        }

        internal void CreateStack()
        {
            Console.Clear();
            Console.WriteLine("Create stack page");
        }

        internal void DeleteStack()
        {
            Console.Clear();
            Console.WriteLine("Delete stack page");
        }
    }
}
