using System;
using static System.Console;

namespace mymathapp
{
    class Menusettings
    {
        private int MyIndex;
        private string[] MenuOptions;   
        private string Shows;          

        // Constructor 
        public Menusettings (string shows, string[] menuoptions)
        {
            Shows = shows;
            MenuOptions = menuoptions; 
            MyIndex = 0; 
        } 

        // Method for rendering menu to screen
        private void ShowOptions()    
        {
            WriteLine(Shows);
                for (int i=0; i < MenuOptions.Length; i++)
                {
                    string myOption = MenuOptions[i];
                    string before; 

                    if (i == MyIndex)
                    {
                        before = " >>";
                        ForegroundColor = ConsoleColor.Black;
                        BackgroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        before = "   ";
                        ForegroundColor = ConsoleColor.Blue;
                        BackgroundColor = ConsoleColor.Black;
                }
                    WriteLine($" {before} {myOption} ");  
                }
            ResetColor();
            ForegroundColor = ConsoleColor.Blue;
        }

        public int MyKeys()      
        {
            // Use reading of keys to choose from menu instead of user writing input
            ConsoleKey keyPressed;
            do
            {
                Clear();
                ShowOptions(); 

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key; 

                // If the up-arrow is pressed
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    MyIndex--;
                    // If up-arrow is pressed when you are at top of index, go to last index
                    if (MyIndex == -1)
                    {
                        MyIndex = MenuOptions.Length - 1; 
                    }
                }
                // If the down-arrow is pressed
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    MyIndex++;
                    // If down-arrow is pressed when is at last index, start from index 0 again.
                    if (MyIndex == MenuOptions.Length)
                    {
                        MyIndex = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter); // While ENTER is not pressed!

            return MyIndex;
        }
    }
}
