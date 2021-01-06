using System;
using static System.Console;

namespace mymathapp
{
    class Geometry
    {
        string geotitle = @"
 
  ██████╗ ███████╗ ██████╗ ███╗   ███╗███████╗████████╗██████╗ ██╗
 ██╔════╝ ██╔════╝██╔═══██╗████╗ ████║██╔════╝╚══██╔══╝██╔══██╗██║
 ██║  ███╗█████╗  ██║   ██║██╔████╔██║█████╗     ██║   ██████╔╝██║
 ██║   ██║██╔══╝  ██║   ██║██║╚██╔╝██║██╔══╝     ██║   ██╔══██╗██║
 ╚██████╔╝███████╗╚██████╔╝██║ ╚═╝ ██║███████╗   ██║   ██║  ██║██║
  ╚═════╝ ╚══════╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝   ╚═╝   ╚═╝  ╚═╝╚═╝
";

        public void Start()
        {
            Title = "Beräkna geometri";
            Geometrys();
        }

        private void Geometrys()
        {
            Clear();

            while (true)
            {
                CursorVisible = false;
                string shows = geotitle + "\n\n" + "     MENY:";
                string[] menuoptions = { "Omkrets", "Area", "Volym", "Avsluta och återvänd" };
                Menusettings menuMath = new Menusettings(shows, menuoptions);
                int myIndex = menuMath.MyKeys();                       

                // Switch 
                switch (myIndex)
                {
                    case 0:
                        GeoCircum();
                        break;
                    case 1:
                        GeoArea();
                        break;
                    case 2:
                        GeoVolume();
                        break;
                    case 3:
                        ReturnToStart();
                        break;
                }
            }
        }

        // Case 0 - Circumference
        private void GeoCircum()
        {
            Clear();
            string circumtitle = @"
 ____ _  _ _  _ ____ ____ ___ ____ 
 |  | |\/| |_/  |__/ |___  |  [__  
 |__| |  | | \_ |  \ |___  |  ___] 

";
            // While(true) keeps us inside this until we say otherwise
            while (true)
            {
                string shows = geotitle + circumtitle + "     MENY:";
                string[] menuoptions = { "Kvadrat", "Rektangel", "Triangel", "Cirkel", "Parallellogram", "Tillbaka till geometri-meny" };
                Menusettings menuMath = new Menusettings(shows, menuoptions);
                int myIndex = menuMath.MyKeys();

                switch (myIndex)
                {
                    // Square
                    case 0:
                        {
                            CursorVisible = true;
                            Write("\n");
                            Write("Skriv längden på en sida: ");
                            var inputOne = Console.ReadLine();
                            decimal outputOne;
                            CursorVisible = false;
                            // Check that input value is valid decimal
                            if (Decimal.TryParse(inputOne, out outputOne))
                            {
                                Write(" ___________________________________________ \n");
                                Write("                                           \n");
                                Write("   " + "Omkretsen av din kvadrat är: " + (outputOne * 4) + "\n");
                                Write("   " + "[" + outputOne + " * " + 4 + " = " + (outputOne * 4) + "] \n");
                                Write(" ___________________________________________ \n\n");
                                Write("Tryck på valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                            else
                            {
                                Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                Write("Tryck på valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                        }
                        break;
                    // Rectangel
                    case 1:
                        {
                            CursorVisible = true;
                            Write("\n");
                            Write("Skriv längden på ena sidan (basen): ");
                            var inputOne = ReadLine();
                            decimal outputOne;
                            // Check that input value is valid decimal
                            if (Decimal.TryParse(inputOne, out outputOne))
                            {
                                Write("Skriv längden på andra sidan (höjden): ");
                                var inputTwo = ReadLine();
                                decimal outputTwo;
                                CursorVisible = false;
                                // Check that input value is valid decimal
                                if (Decimal.TryParse(inputTwo, out outputTwo))
                                {
                                    Write(" ___________________________________________ \n");
                                    Write("                                           \n");
                                    Write("   " + "Omkretsen av din rektangel är: " + (outputOne * 2 + outputTwo * 2 ) + "\n");
                                    Write("   " + "[" + outputOne + " * " + 2 + " + " + outputTwo + " * " + 2 +  " = " + (outputOne * 2 + outputTwo * 2) + "] \n");
                                    Write(" ___________________________________________ \n\n");
                                    Write("Tryck på valfri tangent för att fortsätta!");
                                    ReadKey(true);
                                }
                                else
                                {
                                    Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                    Write("Tryck på valfri tangent för att fortsätta!");
                                    ReadKey(true);
                                }                                
                            }
                            else
                            {
                                CursorVisible = false;
                                Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                Write("Tryck på valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                        }
                        break;
                    // Triangle
                    case 2:
                        {
                            CursorVisible = true;
                            Write("\n");
                            Write("Skriv längden på ena sidan: ");
                            var inputOne = ReadLine();
                            decimal outputOne;
                            // Check that input value is valid decimal
                            if (Decimal.TryParse(inputOne, out outputOne))
                            {
                                Write("Skriv längden på andra sidan: ");
                                var inputTwo = ReadLine();
                                decimal outputTwo;
                                // Check that input value is valid decimal
                                if (Decimal.TryParse(inputTwo, out outputTwo))
                                {
                                    Write("Skriv längden på tredje sidan: ");
                                    var inputThree = ReadLine();
                                    decimal outputThree;
                                    CursorVisible = false;
                                    // Check that input value is valid decimal
                                    if (Decimal.TryParse(inputThree, out outputThree))
                                    {
                                        Write(" ___________________________________________ \n");
                                        Write("                                           \n");
                                        Write("   " + "Omkretsen av din triangel är: " + (outputOne + outputTwo + outputThree) + "\n");
                                        Write("   " + "[" + outputOne + " + " + outputTwo + " + " + outputThree + " = " + (outputOne + outputTwo + outputThree ) + "] \n");
                                        Write(" ___________________________________________ \n\n");
                                        Write("Tryck på valfri tangent för att fortsätta!");
                                        ReadKey(true);
                                    }
                                    else
                                    {
                                        Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                        Write("Tryck på valfri tangent för att fortsätta!");
                                        ReadKey(true);
                                    } 
                                }
                                else
                                {
                                    CursorVisible = false;
                                    Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                    Write("Tryck på valfri tangent för att fortsätta!");
                                    ReadKey(true);
                                }
                            }
                            else
                            {
                                CursorVisible = false;
                                Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                Write("Tryck på valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                        }
                        break;
                    // Circle
                    case 3:
                        {
                            CursorVisible = true;
                            double pi = Math.PI;
                            Write("\n");
                            Write("Skriv cirkelns diameter: ");
                            var inputOne = Console.ReadLine();
                            double outputOne;
                            CursorVisible = false;
                            // Check that input value is valid decimal
                            if (Double.TryParse(inputOne, out outputOne))
                            {
                                Write(" ___________________________________________ \n");
                                Write("                                           \n");
                                Write("   " + "Omkretsen av din cirkel är: " + (outputOne * pi ) + "\n");
                                Write("   " + "Omkretsen avrundad är: " + Math.Round(outputOne * pi) + "\n");
                                Write("   " + "[" + outputOne + " * " + "pi" + " = " + (outputOne * pi) + "] \n");
                                Write(" ___________________________________________ \n\n");
                                Write("Tryck på valfri tangent för att fortsätta!"); 
                                ReadKey(true);
                            }
                            else
                            {
                                Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                Write("Tryck på valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                        }
                        break;
                    // Parallellogram
                    case 4:
                        {
                            CursorVisible = true;
                            Write("\n");
                            Write("Skriv längden ena sidan (basen): ");
                            var inputOne = ReadLine();
                            decimal outputOne;
                            // Check that input value is valid decimal
                            if (Decimal.TryParse(inputOne, out outputOne))
                            {
                                Write("Skriv längden på andra sidan (obs ej motsatta sidan): ");
                                var inputTwo = ReadLine();
                                decimal outputTwo;
                                CursorVisible = false;
                                // Check that input value is valid decimal
                                if (Decimal.TryParse(inputTwo, out outputTwo))
                                {
                                    Write(" ___________________________________________ \n");
                                    Write("                                           \n");
                                    Write("   " + "Omkretsen av ditt parallellogram  är: " + (outputOne * 2 + outputTwo * 2) + "\n");
                                    Write("   " + "[" + outputOne + " * " + 2 + " + " + outputTwo + " * " + 2 + " = " + (outputOne * 2 + outputTwo * 2) + "] \n");
                                    Write(" ___________________________________________ \n\n");
                                    Write("Tryck på valfri tangent för att fortsätta!");
                                    ReadKey(true);
                                }
                                else
                                {
                                    Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                    Write("Tryck på valfri tangent för att fortsätta!");
                                    ReadKey(true);
                                }
                            }
                            else
                            {
                                CursorVisible = false;
                                Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                Write("Tryck på valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                        }
                        break;
                    // End and go back
                    case 5:
                        Geometry myGeometry = new Geometry();
                        myGeometry.Start();
                        break;
                }
            }
        }


        // Case 1: Area 
        private void GeoArea()
        {
            Clear();
            string areatitle = @"
 ____ ____ ____ ____ 
 |__| |__/ |___ |__| 
 |  | |  \ |___ |  | 

";
            // While(true) keeps us inside this until we say otherwise
            while (true)
            {
                string shows = geotitle + areatitle + "     MENY:";
                string[] menuoptions = { "Kvadrat", "Rektangel", "Triangel", "Cirkel", "Parallellogram", "Tillbaka till geometri-meny" };
                Menusettings menuMath = new Menusettings(shows, menuoptions);
                int myIndex = menuMath.MyKeys();

                switch (myIndex)
                {
                    // Square
                    case 0:
                        {
                            CursorVisible = true;
                            Write("\n");
                            Write("Skriv längden på en sida: ");
                            var inputOne = Console.ReadLine();
                            decimal outputOne;
                            CursorVisible = false;
                            // Check that input value is valid decimal
                            if (Decimal.TryParse(inputOne, out outputOne))
                            {
                                Write(" ___________________________________________ \n");
                                Write("                                           \n");
                                Write("   " + "Arean av din kvadrat är: " + (outputOne * outputOne) + "\n");
                                Write("   " + "[" + outputOne + " * " + outputOne + " = " + (outputOne * outputOne) + "] \n");
                                Write(" ___________________________________________ \n\n");
                                Write("Tryck på valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                            else
                            {
                                Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                Write("Tryck på valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                        }
                        break;
                    // Rectangel
                    case 1:
                        {
                            CursorVisible = true;
                            Write("\n");
                            Write("Skriv längden på ena sidan (basen): ");
                            var inputOne = ReadLine();
                            decimal outputOne;
                            // Check that input value is valid decimal
                            if (Decimal.TryParse(inputOne, out outputOne))
                            {
                                Write("Skriv längden på andra sidan (höjden): ");
                                var inputTwo = ReadLine();
                                decimal outputTwo;
                                CursorVisible = false;
                                // Check that input value is valid decimal
                                if (Decimal.TryParse(inputTwo, out outputTwo))
                                {
                                    Write(" ___________________________________________ \n");
                                    Write("                                           \n");
                                    Write("   " + "Arean av din rektangel är: " + (outputOne * outputTwo) + "\n");
                                    Write("   " + "[" + outputOne + " * " + outputTwo + " = " + (outputOne * outputTwo) + "] \n");
                                    Write(" ___________________________________________ \n\n");
                                    Write("Tryck på valfri tangent för att fortsätta!");
                                    ReadKey(true);
                                }
                                else
                                {
                                    Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                    Write("Tryck på valfri tangent för att fortsätta!");
                                    ReadKey(true);
                                }
                            }
                            else
                            {
                                CursorVisible = false;
                                Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                Write("Tryck på valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                        }
                        break;
                    // Triangle
                    case 2:
                        {
                            CursorVisible = true;
                            Write("\n");
                            Write("Skriv längden på basen: ");
                            var inputOne = ReadLine();
                            decimal outputOne;
                            // Check that input value is valid decimal
                            if (Decimal.TryParse(inputOne, out outputOne))
                            {
                                Write("Skriv längden på höjden: ");
                                var inputTwo = ReadLine();
                                decimal outputTwo;
                                CursorVisible = false;
                                // Check that input value is valid decimal
                                if (Decimal.TryParse(inputTwo, out outputTwo))
                                {
                                    Write(" ___________________________________________ \n");
                                    Write("                                           \n");
                                    Write("   " + "Arean av din triangel är: " + (outputOne * outputTwo / 2) + "\n");
                                    Write("   " + "[" + outputOne + " * " + outputTwo + " / " + 2 + " = " + (outputOne * outputTwo / 2) + "] \n");
                                    Write(" ___________________________________________ \n\n");
                                    Write("Tryck på valfri tangent för att fortsätta!");
                                    ReadKey(true);
                                }
                                else
                                {
                                    Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                    Write("Tryck på valfri tangent för att fortsätta!");
                                    ReadKey(true);
                                }
                            }
                            else
                            {
                                CursorVisible = false;
                                Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                Write("Tryck på valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                        }
                        break;
                    // Circle
                    case 3:
                        {
                            CursorVisible = true;
                            double pi = Math.PI;
                            Write("\n");
                            Write("Skriv cirkelns diameter: ");
                            var inputOne = Console.ReadLine();
                            double outputOne;
                            CursorVisible = false;
                            // Check that input value is valid decimal
                            if (Double.TryParse(inputOne, out outputOne))
                            {
                                double rad = (outputOne / 2);
                                double pows = Math.Pow(rad, 2);
                                Write(" ___________________________________________ \n");
                                Write("                                           \n");
                                Write("   " + "Arean av din cirkel är: " + (pows * pi) + "\n");
                                Write("   " + "Arean avrundad är: " + Math.Round( pows * pi) + "\n" );
                                Write("   " + "[" + "pi" + " * " + "(" + outputOne + " / 2 )² " + " = " + (pows * pi) + "] \n");
                                Write(" ___________________________________________ \n\n");
                                Write("Tryck på valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                            else
                            {
                                Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                Write("Tryck på valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                        }
                        break;
                    // Parallellogram
                    case 4:
                        {
                            CursorVisible = true;
                            Write("\n");
                            Write("Skriv längden på basen: ");
                            var inputOne = ReadLine();
                            decimal outputOne;
                            // Check that input value is valid decimal
                            if (Decimal.TryParse(inputOne, out outputOne))
                            {
                                Write("Skriv längden på höjden (obs ej sidan): ");
                                var inputTwo = ReadLine();
                                decimal outputTwo;
                                CursorVisible = false;
                                // Check that input value is valid decimal
                                if (Decimal.TryParse(inputTwo, out outputTwo))
                                {
                                    Write(" ___________________________________________ \n");
                                    Write("                                           \n");
                                    Write("   " + "Arean av ditt parallellogram är: " + (outputOne * outputTwo) + "\n");
                                    Write("   " + "[" + outputOne + " * " + outputTwo + " = " + (outputOne * outputTwo) + "] \n");
                                    Write(" ___________________________________________ \n\n");
                                    Write("Tryck på valfri tangent för att fortsätta!");
                                    ReadKey(true);
                                }
                                else
                                {
                                    Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                    Write("Tryck på valfri tangent för att fortsätta!");
                                    ReadKey(true);
                                }
                            }
                            else
                            {
                                CursorVisible = false;
                                Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                Write("Tryck på valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                        }
                        break;
                    // End and go back
                    case 5:
                        Geometry myGeometry = new Geometry();
                        myGeometry.Start();
                        break;
                }
            }
        }


        // Case 2: Volume
        private void GeoVolume()
        {
            Clear();
            string volumetitle = @"
 _  _ ____ _    _   _ _  _ 
 |  | |  | |     \_/  |\/| 
  \/  |__| |___   |   |  | 

";
            // While(true) keeps us inside this until we say otherwise
            while (true)
            {
                string shows = geotitle + volumetitle + "     MENY:";
                string[] menuoptions = { "Rätblock", "Cylinder", "Sfär", "Kon", "Pyramid med triangelformad bas", "Pyramid med kvadratisk bas", "Tillbaka till geometri-meny" };
                Menusettings menuMath = new Menusettings(shows, menuoptions);
                int myIndex = menuMath.MyKeys();

                switch (myIndex)
                {
                    // Right block
                    case 0:
                        {
                            CursorVisible = true;
                            Write("\n");
                            Write("Skriv längden på basen: ");
                            var inputOne = ReadLine();
                            decimal outputOne;
                            // Check that input value is valid decimal
                            if (Decimal.TryParse(inputOne, out outputOne))
                            {
                                Write("Skriv längden på bredden: ");
                                var inputTwo = ReadLine();
                                decimal outputTwo;
                                // Check that input value is valid decimal
                                if (Decimal.TryParse(inputTwo, out outputTwo))
                                {
                                    Write("Skriv längden på höjden: ");
                                    var inputThree = ReadLine();
                                    decimal outputThree;
                                    CursorVisible = false;
                                    // Check that input value is valid decimal
                                    if (Decimal.TryParse(inputThree, out outputThree))
                                    {
                                        Write(" ___________________________________________ \n");
                                        Write("                                           \n");
                                        Write("   " + "Volymen av ditt rätblock är: " + (outputOne * outputTwo * outputThree) + "\n");
                                        Write("   " + "[" + outputOne + " * " + outputTwo + " * " + outputThree + " = " + (outputOne * outputTwo * outputThree) + "] \n");
                                        Write(" ___________________________________________ \n\n");
                                        Write("Tryck på valfri tangent för att fortsätta!");
                                        ReadKey(true);
                                    }
                                    else
                                    {
                                        Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                        Write("Tryck på valfri tangent för att fortsätta!");
                                        ReadKey(true);
                                    }
                                }
                                else
                                {
                                    CursorVisible = false;
                                    Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                    Write("Tryck på valfri tangent för att fortsätta!");
                                    ReadKey(true);
                                }
                            }
                            else
                            {
                                CursorVisible = false;
                                Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                Write("Tryck på valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                        }
                        break;
                    // Cylinder
                    case 1:
                        {
                            CursorVisible = true;
                            double pi = Math.PI;
                            Write("\n");
                            Write("Skriv längden på radien på basen: ");
                            var inputOne = ReadLine();
                            double outputOne;
                            // Check that input value is valid decimal
                            if (Double.TryParse(inputOne, out outputOne))
                            {
                                Write("Skriv längden på höjden: ");
                                var inputTwo = ReadLine();
                                double outputTwo;
                                CursorVisible = false;
                                // Check that input value is valid decimal
                                if (Double.TryParse(inputTwo, out outputTwo))    
                                {
                                    double pows = Math.Pow(outputOne, 2);
                                    Write(" ___________________________________________ \n");
                                    Write("                                           \n");
                                    Write("   " + "Volymen av din cylinder är: " + (pi * pows * outputTwo) + "\n");
                                    Write("   " + "Volymen avrundad är: " + Math.Round(pows * pi * outputTwo) + "\n");
                                    Write("   " + "[ pi * " + outputOne + "²" + " * " + outputTwo + " = " + (pi * pows * outputTwo) + "] \n");
                                    Write(" ___________________________________________ \n\n");
                                    Write("Tryck på valfri tangent för att fortsätta!");
                                    ReadKey(true);
                                }
                                else
                                {
                                    Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                    Write("Tryck på valfri tangent för att fortsätta!");
                                    ReadKey(true);
                                }
                            }
                            else
                            {
                                CursorVisible = false;
                                Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                Write("Tryck på valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                        }
                        break;
                    // Sphere
                    case 2:
                        {
                            CursorVisible = true;
                            double pi = Math.PI;
                            Write("\n");
                            Write("Skriv längden på radien: ");
                            var inputOne = ReadLine();
                            double outputOne;
                            CursorVisible = false;
                            // Check that input value is valid double
                            if (Double.TryParse(inputOne, out outputOne))
                            {
                                    double pows = Math.Pow(outputOne, 3);
                                    Write(" ___________________________________________ \n");
                                    Write("                                           \n");
                                    Write("   " + "Volymen av din sfär är: " + ( (4 * pi * pows) /3 ) + "\n");
                                    Write("   " + "Volymen avrundad är: " + Math.Round((4 * pi * pows) / 3) + "\n");
                                    Write("   " + "[ (4 * pi * " + outputOne + "³)" + " /3 " +   " = " + ((4 * pi * pows) / 3) + "] \n");
                                    Write(" ___________________________________________ \n\n");
                                    Write("Tryck på valfri tangent för att fortsätta!");
                                    ReadKey(true);
                                
                            }
                            else
                            {
                                Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                Write("Tryck på valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                        }
                        break;
                    // Cone
                    case 3:
                        {
                            CursorVisible = true;
                            double pi = Math.PI;
                            Write("\n");
                            Write("Skriv längden på radien på basen: ");
                            var inputOne = ReadLine();
                            double outputOne;
                            // Check that input value is valid decimal
                            if (Double.TryParse(inputOne, out outputOne))
                            {
                                Write("Skriv längden på höjden: ");
                                var inputTwo = ReadLine();
                                double outputTwo;
                                CursorVisible = false;
                                // Check that input value is valid decimal
                                if (Double.TryParse(inputTwo, out outputTwo))
                                {
                                    double pows = Math.Pow(outputOne, 2);
                                    Write(" ___________________________________________ \n");
                                    Write("                                           \n");
                                    Write("   " + "Volymen av din kon är: " + ((pi * pows * outputTwo) / 3) + "\n");
                                    Write("   " + "Volymen avrundad är: " + Math.Round( (pi * pows * outputTwo)/3 ) + "\n");
                                    Write("   " + "[ ( pi * " + outputOne + "²" + " * " + outputTwo + ") /3" + " = " + ((pi * pows * outputTwo) / 3) + "] \n");
                                    Write(" ___________________________________________ \n\n");
                                    Write("Tryck på valfri tangent för att fortsätta!");
                                    ReadKey(true);
                                }
                                else
                                {
                                    Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                    Write("Tryck på valfri tangent för att fortsätta!");
                                    ReadKey(true);
                                }
                            }
                            else
                            {
                                CursorVisible = false;
                                Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                Write("Tryck på valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                        }
                        break;
                    // Pyramid -triangle base
                    case 4:
                        {
                            CursorVisible = true;
                            Write("\n");
                            Write("Skriv längden på basen på triangeln (på basen av pyramiden): ");
                            var inputOne = ReadLine();
                            double outputOne;
                            // Check that input value is valid decimal
                            if (Double.TryParse(inputOne, out outputOne))
                            {
                                Write("Skriv längden på höjden (på triangeln på basen av pyramiden): ");
                                var inputTwo = ReadLine();
                                double outputTwo;
                                // Check that input value is valid decimal
                                if (Double.TryParse(inputTwo, out outputTwo))
                                {
                                    Write("Skriv längden på höjden av pyramiden: ");
                                    var inputThree = ReadLine();
                                    double outputThree;
                                    CursorVisible = false;
                                    // Check that input value is valid decimal
                                    if (Double.TryParse(inputThree, out outputThree))
                                    {
                                        Write(" ___________________________________________ \n");
                                        Write("                                           \n");
                                        Write("   " + "Volymen av din pyramid är: " + (((outputOne * outputTwo / 2) * outputThree) / 3) + "\n");
                                        Write("   " + "[ ( (" + outputOne + " * " + outputTwo + "/3) " + " * " + outputThree + " )/3" + " = " + (((outputOne * outputTwo / 2) * outputThree) / 3) + "] \n");
                                        Write(" ___________________________________________ \n\n");
                                        Write("Tryck på valfri tangent för att fortsätta!");
                                        ReadKey(true);
                                    }
                                    else
                                    {
                                        Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                        Write("Tryck på valfri tangent för att fortsätta!");
                                        ReadKey(true);
                                    }
                                }
                                else
                                {
                                    CursorVisible = false;
                                    Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                    Write("Tryck på valfri tangent för att fortsätta!");
                                    ReadKey(true);
                                }
                            }
                            else
                            {
                                CursorVisible = false;
                                Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                Write("Tryck på valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                        }
                        break;
                    // Pyramid -square base
                    case 5:
                        {
                            CursorVisible = true;
                            Write("\n");
                            Write("Skriv längden på en sida på basen: ");
                            var inputOne = ReadLine();
                            double outputOne;
                            // Check that input value is valid decimal
                            if (Double.TryParse(inputOne, out outputOne))
                            {
                                Write("Skriv längden på höjden: ");
                                var inputTwo = ReadLine();
                                double outputTwo;
                                CursorVisible = false;
                                // Check that input value is valid decimal
                                if (Double.TryParse(inputTwo, out outputTwo))
                                {
                                    Write(" ___________________________________________ \n");
                                    Write("                                           \n");
                                    Write("   " + "Volymen av din pyramid är: " + ((outputOne * outputOne * outputTwo) / 3) + "\n");
                                    Write("   " + "[ (" + outputOne + " * " + outputOne + " * " + outputTwo + ") /3" + " = " + ((outputOne * outputOne * outputTwo) / 3) + "] \n");
                                    Write(" ___________________________________________ \n\n");
                                    Write("Tryck på valfri tangent för att fortsätta!");
                                    ReadKey(true);
                                }
                                else
                                {
                                    Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                    Write("Tryck på valfri tangent för att fortsätta!");
                                    ReadKey(true);
                                }
                            }
                            else
                            {
                                CursorVisible = false;
                                Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                                Write("Tryck på valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                        }
                        break;
                    // End and go back
                    case 6:
                        Geometry myGeometry = new Geometry();
                        myGeometry.Start();
                        break;
                }
            }
        }


        // Case 3: Return to main menu
        private void ReturnToStart()
        {
            Mathapp myMathApp = new Mathapp();
            myMathApp.Start();
        }
    }
}
