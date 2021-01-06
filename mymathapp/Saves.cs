using System;
using static System.Console;

namespace mymathapp
{
    class Saves
    {
        public void Start()
        {
            Title = "Sparade uträkningar";
            Saved();
        }

        private void Saved()
        {
            string savetitle = @"
 ███████╗██████╗  █████╗ ██████╗  █████╗ ████████╗
 ██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝
 ███████╗██████╔╝███████║██████╔╝███████║   ██║   
 ╚════██║██╔═══╝ ██╔══██║██╔══██╗██╔══██║   ██║   
 ███████║██║     ██║  ██║██║  ██║██║  ██║   ██║   
 ╚══════╝╚═╝     ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝  

" + "  Sparade uträkningar från kalkylatorn: ";

            string savemenu = @"
 _______________________________
|                               |
|    SKRIV OCH TRYCK ENTER:     |
|    R. Radera uträkning        |
|    A. Avsluta och återvänd    |                           
|_______________________________|
";

            while (true)
            {
                Console.Clear();
                CursorVisible = true;

                SavedMath savedmath = new SavedMath();
                int i = 0;

                WriteLine(savetitle);
                // i = 0;
                foreach (Post post in savedmath.getMaths())
                {
                    WriteLine("  " + "[" + i++ + "]" + post.Saved);
                }

                WriteLine(savemenu);


                // Make input values in upper case counts as lower case (X => x)
                string input = Console.ReadLine().ToLower();
                // Switch 
                switch (input)
                {
                    case "r":

                        Console.Write("Ange index att radera: ");
                        // Using try and catch in case errors occurs, like not valid index input 
                        try
                        {
                            string index = Console.ReadLine();
                            savedmath.delMath(Convert.ToInt32(index));
                        }
                        catch
                        {
                            Console.Write("Du har inte angett ett korrekt index-värde! \n");
                            Console.Write("Tryck på ENTER för att fortsätta!");
                            Console.ReadLine();
                        } 
                        break;

                    case "a":
                        ReturnToStart();
                        break;
                }
            }
        }
        private void ReturnToStart()
        {
            Mathapp myMathApp = new Mathapp();
            myMathApp.Start();
        }
    }
}
