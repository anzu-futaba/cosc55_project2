using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Drawing;
using Console = Colorful.Console;

namespace DiscreteProject
{
    internal class startexit : Computation
    {

        Regex reg = new Regex(@"^[a-zA-Z-!$%^&*()_+|~=`{}[\]:;@# ""'<>?,.\\/]+$");

        public override void Start()
        {   
            Console.Clear();
            base.Discretesign();
            while (true)
            {
                Console.Write("Enter your choice: ", Color.White);
                String input = Console.ReadLine();
                if (input.Trim() == "" || input == " ")
                {
                    Console.Clear();
                    base.Discretesign();
                    Console.WriteLine("Please choose from 1 - 6", Color.White);
                }
                else if(reg.Match(input).Success)
                {
                    Console.Clear();
                    base.Discretesign();
                    Console.WriteLine("Please choose from 1 - 6", Color.White);
                }
                else
                {
                    Int64 choicex = Convert.ToInt64(input);
                    if (choicex == 1)
                    {
                        Console.Clear();
                        base.PermutationX();
                        break;
                    }
                    else if (choicex == 2)
                    {
                        Console.Clear();
                        base.Permutation();
                        break;
                    }
                    else if (choicex == 3)
                    {
                        Console.Clear();
                        base.CombinationX();
                        break;
                    }
                    else if (choicex == 4)
                    {
                        Console.Clear();
                        base.Combination();
                        break;
                    }
                    else if (choicex == 5)
                    {
                        Console.Clear();
                        base.StirlingNumber();
                        break;
                    }
                    else if (choicex == 6)
                    {
                        Console.Clear();
                        base.PascalGenerator();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        base.Discretesign();
                        Console.WriteLine("Enter valid choice!", Color.White);
                    }

                }
            }
        }

        public override void End()
        {
            Colorful.Console.ReplaceAllColorsWithDefaults();
            Console.Clear();
            string ended1 = "### Program Ended ###\n";
            Console.SetCursorPosition((Console.WindowWidth - ended1.Length) / 2, Console.CursorTop);
            Console.WriteLine(ended1);
            string ended12 = "D I S C R E T E  M A T H E M A T I C S  I I\n";
            Console.SetCursorPosition((Console.WindowWidth - ended12.Length) / 2, Console.CursorTop);
            Console.WriteLine(ended12);
            Console.ResetColor();
            Console.ResetColor();
            string ended2 = "This program was created by the following Students\n";
            Console.SetCursorPosition((Console.WindowWidth - ended2.Length) / 2, Console.CursorTop);
            Console.WriteLine(ended2);
            string ended3 = "Tristan Keith D. Lagumbay\n";
            Console.SetCursorPosition((Console.WindowWidth - ended3.Length) / 2, Console.CursorTop);
            Console.ForegroundColor = Color.Red;
            Console.WriteLine(ended3);
            Console.ResetColor();
            string ended4 = "John Oliver Onofre\n";
            Console.SetCursorPosition((Console.WindowWidth - ended4.Length) / 2, Console.CursorTop);
            Console.ForegroundColor = Color.Green;
            Console.WriteLine(ended4);
            Console.ResetColor();
            string ended11 = "Course - Year - Block/Section";
            Console.SetCursorPosition((Console.WindowWidth - ended11.Length) / 2, Console.CursorTop);
            Console.WriteLine(ended11);
            Console.ResetColor();
            string ended7 = "BSCS     2            1    \n";
            Console.SetCursorPosition((Console.WindowWidth - ended7.Length) / 2, Console.CursorTop);
            Console.ForegroundColor = Color.Magenta;
            Console.WriteLine(ended7);
            Console.ResetColor();
            string ended10 = "Discrete Mathematics Professor";
            Console.SetCursorPosition((Console.WindowWidth - ended10.Length) / 2, Console.CursorTop);
            Console.WriteLine(ended10);
            Console.ResetColor();
            string ended9 = "Sir Johnroe Paulo Canamaque\n";
            Console.SetCursorPosition((Console.WindowWidth - ended9.Length) / 2, Console.CursorTop);
            Console.ForegroundColor = Color.Blue;
            Console.WriteLine(ended9);
            Console.ResetColor();
            string ended8 = "  ### Program Ended ###\n\n\n\n";
            Console.SetCursorPosition((Console.WindowWidth - ended8.Length) / 2, Console.CursorTop);
            Console.WriteLine(ended8);
            string credits = "Credited to / ";
            Console.SetCursorPosition((Console.WindowWidth - ended8.Length) / 2, Console.CursorTop);
            Console.WriteLine(credits);
            string website = "/ www.pktfive.com";
            Console.SetCursorPosition((Console.WindowWidth - credits.Length) / 2, Console.CursorTop);
            Console.ForegroundColor = Color.Cyan;
            Console.WriteLine(website);
            Console.ResetColor();
            Console.ReadLine();
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}