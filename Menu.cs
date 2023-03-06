using flashcards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Menu
{
    internal static void MainMenu()
    {
        StackActions stackActions = new();
        Console.Clear();
        bool closeApp = false;

        while (closeApp == false)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. View current stacks\n2. Create new stack\n3. Delete stack\n4. Exit program");
            Console.WriteLine("---------------------------");

            int UserChoice = Helpers.GetNumberInput();

            switch (UserChoice)
            {
                case 1:
                    stackActions.ViewStack();
                    break;

                case 2:
                    stackActions.CreateStack();
                    break;

                case 3:
                    stackActions.DeleteStack();
                    break;

                case 4:
                    Console.WriteLine("Exit program page");
                    closeApp = true;
                    break;
            }
        }
    }
}