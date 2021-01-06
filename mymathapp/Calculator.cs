using System;
using static System.Console;


namespace mymathapp
{
    class Calculator
    {
        string kalkylator = @"

 ██╗  ██╗ █████╗ ██╗     ██╗  ██╗██╗   ██╗██╗      █████╗ ████████╗ ██████╗ ██████╗ 
 ██║ ██╔╝██╔══██╗██║     ██║ ██╔╝╚██╗ ██╔╝██║     ██╔══██╗╚══██╔══╝██╔═══██╗██╔══██╗
 █████╔╝ ███████║██║     █████╔╝  ╚████╔╝ ██║     ███████║   ██║   ██║   ██║██████╔╝
 ██╔═██╗ ██╔══██║██║     ██╔═██╗   ╚██╔╝  ██║     ██╔══██║   ██║   ██║   ██║██╔══██╗
 ██║  ██╗██║  ██║███████╗██║  ██╗   ██║   ███████╗██║  ██║   ██║   ╚██████╔╝██║  ██║
 ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝   ╚═╝   ╚══════╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝
                                                                                   
";

        public void Start()
        {
            Title = "Kalkylator";
            Calculate();
        }

        private void Calculate()
        {
            Clear();

            while (true)
            {
                CursorVisible = false;
                string shows = kalkylator + "     MENY:";
                string[] menuoptions = { "Addition", "Subtraktion", "Multiplikation", "Division", "Avsluta och återvänd" };
                Menusettings menuMath = new Menusettings(shows, menuoptions);
                int myIndex = menuMath.MyKeys();

                // Switch 
                switch (myIndex)
                {  
                    case 0:
                        CalculateAddition();
                        break;
                    case 1:
                        CalculateSubtraction(); 
                        break;
                    case 2:
                        CalculateMultiplication();
                        break;
                    case 3:
                        CalculateDivision();
                        break;
                    case 4:
                        ReturnToStart(); 
                        break;
                }
            }    
        }
        // Case 0 - Addition
        private void CalculateAddition()
        {
            Clear();
            CursorVisible = true;

            SavedMath savedmath = new SavedMath();
            Write(kalkylator);
            
            Write("Beräkna addition!\n\n");
            Write("Skriv första termen: ");
            var inputOne = Console.ReadLine();
            decimal outputOne;
            // Check that input value is valid decimal
            if (Decimal.TryParse(inputOne, out outputOne))
            {
                Console.Write("Skriv andra termen: ");
                var inputTwo = Console.ReadLine();
                decimal outputTwo;
                // Check that input value is valid decimal
                if (Decimal.TryParse(inputTwo, out outputTwo))
                {
                    CursorVisible = false;
                    string shows = "" + kalkylator + "\n" + " ___________________________________________ \n\n" + "  " + outputOne + " + " + outputTwo + " = " + (outputOne + outputTwo) + "\n" + " ___________________________________________ \n";                   
                    string[] menuoptions = { "Spara din uträkning", "Avrunda", "Avsluta utan att spara" };
                    Menusettings menuMath = new Menusettings(shows, menuoptions);
                    int myIndex = menuMath.MyKeys();
                    
                    switch (myIndex)
                    {
                        // Save calculation
                        case 0:
                            {
                                // Converting decimal to string
                                string saved = outputOne.ToString() + " + " + outputTwo.ToString() + " = " + (outputOne + outputTwo).ToString();
                                // Save to savedmath
                                Post obj = new Post();
                                obj.Saved = saved;
                                savedmath.addMath(obj);
                                
                                Write("Du har sparat din uträkning!\n");
                                Write("Tryck ENTER för att fortsätta!");
                                ReadKey(true); 
                            }
                            break;
                        // Round number
                        case 1:
                            {
                                // Check if sum is already an "integer", else use Math.Round
                                if (outputOne + outputTwo == Math.Round(outputOne + outputTwo))
                                {
                                    Write("Summan är redan i heltal!\n");
                                }
                                else
                                {
                                    Write(" ___________________________________________ \n");
                                    Write("                                           \n");
                                    Write("   " + outputOne + " + " + outputTwo + " ~ " + Math.Round(outputOne + outputTwo) + "\n");
                                    Write(" ___________________________________________ \n\n");
                                }
                                Write("Tryck valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                            break;
                        // Exit without saving 
                        case 2:  
                            Calculator myCalculator = new Calculator();
                            myCalculator.Start();
                            break; 
                    }
                }
                else
                {
                    CursorVisible = false;
                    Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                    Write("Tryck på ENTER för att fortsätta!");
                    ReadLine();
                }
            }
            else
            {
                CursorVisible = false;
                Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                Write("Tryck på ENTER för att fortsätta!");
                ReadLine();
            }
        }

        // Case 1: Subtraction 
        private void CalculateSubtraction()
        {
            Clear();
            CursorVisible = true;

            SavedMath savedmath = new SavedMath();
            Write(kalkylator);

            Write("Beräkna subtraktion!\n\n");
            Write("Skriv första termen: ");
            var inputOne = Console.ReadLine();
            decimal outputOne;
            // Check that input value is valid decimal
            if (Decimal.TryParse(inputOne, out outputOne))
            {
                Write("Skriv andra termen: ");
                var inputTwo = ReadLine();
                decimal outputTwo;
                // Check that input value is valid decimal
                if (Decimal.TryParse(inputTwo, out outputTwo))
                {
                    CursorVisible = false;
                    string shows = "" + kalkylator + "\n" + " ___________________________________________ \n\n" + "  " + outputOne + " - " + outputTwo + " = " + (outputOne - outputTwo) + "\n" + " ___________________________________________ \n";                   
                    string[] menuoptions = { "Spara din uträkning", "Avrunda", "Avsluta utan att spara" };
                    Menusettings menuMath = new Menusettings(shows, menuoptions);
                    int myIndex = menuMath.MyKeys();

                    switch (myIndex)
                    {
                        // Save calculation
                        case 0:
                            {
                                // Converting decimal to string
                                string saved = outputOne.ToString() + " - " + outputTwo.ToString() + " = " + (outputOne - outputTwo).ToString();
                                // Save to savedmath
                                Post obj = new Post();
                                obj.Saved = saved;
                                savedmath.addMath(obj);

                                Write("Du har sparat din uträkning!\n");
                                Write("Tryck ENTER för att fortsätta!");
                                ReadKey(true);
                            }
                            break;
                        // Round number
                        case 1:
                            {
                                // Check if answer is already an "integer", else use Math.Round
                                if (outputOne - outputTwo == Math.Round(outputOne - outputTwo))
                                {
                                    Write("Differensen är redan i heltal!\n");
                                }
                                else
                                {
                                    Write(" ___________________________________________ \n");
                                    Write("                                           \n");
                                    Write("   " + outputOne + " - " + outputTwo + " ~ " + Math.Round(outputOne - outputTwo) + "\n");
                                    Write(" ___________________________________________ \n\n");
                                }
                                Write("Tryck valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                            break;
                        // Exit without saving 
                        case 2:
                            Calculator myCalculator = new Calculator();
                            myCalculator.Start();
                            break;
                    }
                }
                else
                {
                    CursorVisible = false;
                    Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                    Write("Tryck på ENTER för att fortsätta!");
                    ReadLine();
                }
            }
            else
            {
                CursorVisible = false;
                Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                Write("Tryck på ENTER för att fortsätta!");
                ReadLine();
            }
        }


        // Case 2: Multiplication
        private void CalculateMultiplication()
        {
            Clear();
            CursorVisible = true;

            SavedMath savedmath = new SavedMath();
            Write(kalkylator);

            Write("Beräkna multiplikation!\n\n");
            Write("Skriv första faktorn: ");
            var inputOne = Console.ReadLine();
            decimal outputOne;
            // Check that input value is valid decimal
            if (Decimal.TryParse(inputOne, out outputOne))
            {
                Console.Write("Skriv andra faktorn: ");
                var inputTwo = Console.ReadLine();
                decimal outputTwo;
                // Check that input value is valid decimal
                if (Decimal.TryParse(inputTwo, out outputTwo))
                {
                    CursorVisible = false;
                    string shows = "" + kalkylator + "\n" + " ___________________________________________ \n\n" + "  " + outputOne + " * " + outputTwo + " = " + (outputOne * outputTwo) + "\n" + " ___________________________________________ \n";
                    string[] menuoptions = { "Spara din uträkning", "Avrunda", "Avsluta utan att spara" };
                    Menusettings menuMath = new Menusettings(shows, menuoptions);
                    int myIndex = menuMath.MyKeys();

                    switch (myIndex)
                    {
                        // Save calculation
                        case 0:
                            {
                                // Converting decimal to string
                                string saved = outputOne.ToString() + " * " + outputTwo.ToString() + " = " + (outputOne * outputTwo).ToString();
                                // Save to savedmath
                                Post obj = new Post();
                                obj.Saved = saved;
                                savedmath.addMath(obj);

                                Write("Du har sparat din uträkning!\n");
                                Write("Tryck ENTER för att fortsätta!");
                                ReadKey(true);
                            }
                            break;
                        // Round number
                        case 1:
                            {
                                // Check if answer is already an "integer", else use Math.Round
                                if (outputOne * outputTwo == Math.Round(outputOne * outputTwo))
                                {
                                    Write("Produkten är redan i heltal!\n");
                                }
                                else
                                {
                                    Write(" ___________________________________________ \n");
                                    Write("                                           \n");
                                    Write("   " + outputOne + " * " + outputTwo + " ~ " + Math.Round(outputOne * outputTwo) + "\n");
                                    Write(" ___________________________________________ \n\n");
                                }
                                Write("Tryck valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                            break;
                        // Exit without saving 
                        case 2:
                            Calculator myCalculator = new Calculator();
                            myCalculator.Start();
                            break;
                    }
                }
                else
                {
                    CursorVisible = false;
                    Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                    Write("Tryck på ENTER för att fortsätta!");
                    ReadLine();
                }
            }
            else
            {
                CursorVisible = false;
                Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                Write("Tryck på ENTER för att fortsätta!");
                ReadLine();
            }
        }

        // Case 4: Division
        private void CalculateDivision()
        {
            Clear();
            CursorVisible = true;

            SavedMath savedmath = new SavedMath();
            Write(kalkylator);

            Write("Beräkna division!\n\n");
            Write("Skriv täljaren: ");
            var inputOne = Console.ReadLine();
            decimal outputOne;
            // Check that input value is valid decimal
            if (Decimal.TryParse(inputOne, out outputOne))
            {
                Console.Write("Skriv nämnaren: ");
                var inputTwo = Console.ReadLine();
                decimal outputTwo;
                // Check that input value is valid decimal
                if (Decimal.TryParse(inputTwo, out outputTwo))
                {
                    CursorVisible = false;
                    string shows = "" + kalkylator + "\n" + " ___________________________________________ \n\n" + "  " + outputOne + " / " + outputTwo + " = " + (outputOne / outputTwo) + "\n" + " ___________________________________________ \n";
                    string[] menuoptions = { "Spara din uträkning", "Avrunda", "Avsluta utan att spara" };
                    Menusettings menuMath = new Menusettings(shows, menuoptions);
                    int myIndex = menuMath.MyKeys();

                    switch (myIndex)
                    {
                        // Save calculation
                        case 0:
                            {
                                // Converting decimal to string
                                string saved = outputOne.ToString() + " / " + outputTwo.ToString() + " = " + (outputOne / outputTwo).ToString();
                                // Save to savedmath
                                Post obj = new Post();
                                obj.Saved = saved;
                                savedmath.addMath(obj);

                                Write("Du har sparat din uträkning!\n");
                                Write("Tryck ENTER för att fortsätta!");
                                ReadKey(true);
                            }
                            break;
                        // Round number
                        case 1:
                            {
                                // Check if answer is already an "integer", else use Math.Round
                                if (outputOne / outputTwo == Math.Round(outputOne / outputTwo))
                                {
                                    Write("Kvoten är redan i heltal!\n");
                                }
                                else
                                {
                                    Write(" ___________________________________________ \n");
                                    Write("                                           \n");
                                    Write("   " + outputOne + " / " + outputTwo + " ~ " + Math.Round(outputOne / outputTwo) + "\n");
                                    Write(" ___________________________________________ \n\n");
                                }
                                Write("Tryck valfri tangent för att fortsätta!");
                                ReadKey(true);
                            }
                            break;
                        // Exit without saving 
                        case 2:
                            Calculator myCalculator = new Calculator();
                            myCalculator.Start();
                            break;
                    }
                }
                else
                {
                    CursorVisible = false;
                    Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                    Write("Tryck på ENTER för att fortsätta!");
                    ReadLine();
                }
            }
            else
            {
                CursorVisible = false;
                Write("\nDu har inte angett ett korrekt värde! Enbart siffror och decimaltecken är tillåtet. \n");
                Write("Tryck på ENTER för att fortsätta!");
                ReadLine();
            }
        }

        // Case 5: Return to main menu
        private void ReturnToStart()
        {
            Mathapp myMathApp = new Mathapp();
            myMathApp.Start();
        }
    }
}
