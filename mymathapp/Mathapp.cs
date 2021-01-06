using System;
using static System.Console;

namespace mymathapp
{
    class Mathapp
    {
        string matteapp = @"

             ██╗     ███████╗███╗   ██╗ █████╗ ███████╗               
             ██║     ██╔════╝████╗  ██║██╔══██╗██╔════╝               
             ██║     █████╗  ██╔██╗ ██║███████║███████╗               
             ██║     ██╔══╝  ██║╚██╗██║██╔══██║╚════██║               
             ███████╗███████╗██║ ╚████║██║  ██║███████║               
             ╚══════╝╚══════╝╚═╝  ╚═══╝╚═╝  ╚═╝╚══════╝               
                                                                       
 ███╗   ███╗ █████╗ ████████╗████████╗███████╗ █████╗ ██████╗ ██████╗ 
 ████╗ ████║██╔══██╗╚══██╔══╝╚══██╔══╝██╔════╝██╔══██╗██╔══██╗██╔══██╗
 ██╔████╔██║███████║   ██║      ██║   █████╗  ███████║██████╔╝██████╔╝
 ██║╚██╔╝██║██╔══██║   ██║      ██║   ██╔══╝  ██╔══██║██╔═══╝ ██╔═══╝ 
 ██║ ╚═╝ ██║██║  ██║   ██║      ██║   ███████╗██║  ██║██║     ██║     
 ╚═╝     ╚═╝╚═╝  ╚═╝   ╚═╝      ╚═╝   ╚══════╝╚═╝  ╚═╝╚═╝     ╚═╝     
                                                             
";  
        public void Start()
        {
            Title = "Lenas matteapp";
            MenuMath();
        }

        private void MenuMath()
        {
            ForegroundColor = ConsoleColor.Blue;
            CursorVisible = false;

            string shows = matteapp + "  Gå med upp- och ned-pilknappen. Välj genom att trycka ENTER!\n\n" + "     MENY:";
            string[] menuoptions = { "Kalkylator", "Geometri", "Sparade lösningar", "Avsluta konsolappen" };
            Menusettings menuMath = new Menusettings(shows, menuoptions);
            int myIndex = menuMath.MyKeys();            

            switch(myIndex)
            {     
                case 0:
                    Calculator myCalculator = new Calculator();
                    myCalculator.Start();
                    break;
                case 1:
                    Geometry myGeometry = new Geometry();
                    myGeometry.Start();
                    break;
                case 2:
                    Saves mySaves = new Saves();
                    mySaves.Start();
                    break;
                case 3:
                    ExitApp();
                    break; 
            }
        }

        private void ExitApp()
        {

            Clear();
            ForegroundColor = ConsoleColor.Red;
            WriteLine(@"


                   ¤¤¤¤¤
                ¤¤¤¤¤¤¤¤¤¤¤
              ¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤
             ¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤
             ¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤
             ¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤                   ██████████████████████████████████████████████
              ¤¤¤¤¤¤¤¤¤¤¤¤¤¤                    ██                                          ██
                ¤¤¤¤¤¤¤¤¤¤                      ██  Tack för att du använt Lenas matteapp!  ██
                  ¤¤¤¤¤¤                        ██                                          ██
              ¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤                   ██   Tryck valfri tangent för att avsluta!  ██
         ¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤              ██                                          ██
       ¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤            ██████████████████████████████████████████████
      ¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤       ¤¤¤¤
     ¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤    ¤¤¤¤¤¤¤¤
    ¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤  ¤¤¤¤¤¤¤
    ¤¤¤¤¤¤   ¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤  ¤¤¤¤¤¤¤¤¤¤¤¤¤¤
   ¤¤¤¤¤¤¤   ¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤   ¤¤¤¤¤¤¤¤¤¤¤
   ¤¤¤¤¤¤   ¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤   ¤¤¤¤¤¤¤¤¤¤
  ¤¤¤¤¤¤¤   ¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤   ¤¤¤¤¤¤¤¤
  ¤¤¤¤¤¤¤   ¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤.   ¤¤¤¤¤
 ¤¤¤¤¤¤¤   ¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤.
.¤¤¤¤¤¤¤   ¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤.
"); 
            ReadKey(true);
            Environment.Exit(0);
        }
    }
}
