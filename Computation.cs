using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Drawing;
using Console = Colorful.Console;

namespace DiscreteProject
{
    internal class Computation /*(child)*/ : Designs //(parent)
    {
        Regex reg = new Regex(@"^[a-zA-Z-!$%^&*()_+|~=`{}[\]:;@# ""'<>?,.\\/]+$");
        // Where X = no repetition
        public void PermutationX()                                                                                                              // PERMUX
        {
            base.PermutationXsign();

            BigInteger n;
            permuX_n:
            Console.Write("Enter n: ", Color.White);
            String inp = Console.ReadLine();
            bool cont = true;
            while(cont)
            {
                
                if (inp.Trim() == "" || inp == " ")
                {
                    Console.Clear();
                    base.PermutationXsign();
                    Console.WriteLine("Value of 'n' should be greater than 0 and less than 500", Color.White);
                    goto permuX_n;
                }
                else if (reg.Match(inp).Success)
                {
                    Console.Clear();
                    base.PermutationXsign();
                    Console.WriteLine("Value of 'n' should be greater than 0 and less than 500", Color.White);
                    goto permuX_n;
                }
                else
                {
                    n = BigInteger.Parse(inp);
                    if (n <= 500 && n > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        base.PermutationXsign();
                        Console.WriteLine("Value of 'n' should be greater than 0 and less than 500", Color.White);
                        goto permuX_n;
                    }
                }
            }
            Console.Clear();
            base.PermutationXsign();
            n = BigInteger.Parse(inp);
            BigInteger r;
            Console.WriteLine("Value of n: " + n, Color.White);
            permuX_r:       
            Console.Write("Enter r: ", Color.White);
            String inp2 = Console.ReadLine();
            while(cont)
            {
                if (inp2.Trim() == "" || inp2 == " ")
                {
                    Console.Clear();
                    base.PermutationXsign();
                    Console.WriteLine("Value of n: " + n, Color.White);
                    Console.WriteLine("Value of 'r' should be less than 500 and 'n' should be greater or equal to 'r'", Color.White);
                    goto permuX_r;
                }
                else if (reg.Match(inp2).Success)
                {
                    Console.Clear();
                    base.PermutationXsign();
                    Console.WriteLine("Value of n: " + n, Color.White);
                    Console.WriteLine("Value of 'r' should be less than 500 and 'n' should be greater or equal to 'r'", Color.White);
                    goto permuX_r;
                }
                else
                {
                    r = BigInteger.Parse(inp2);
                    if (r <= 500 && n >= r)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        base.PermutationXsign();
                        Console.WriteLine("Value of n: " + n, Color.White);
                        Console.WriteLine("Value of 'r' should be less than 500 and 'n' should be greater or equal to 'r'", Color.White);
                        goto permuX_r;
                    }
                }
   
            }
            r = BigInteger.Parse(inp2);
            Console.Clear();
            base.PermutationXsign();
            Console.WriteLine("Value of n: " + n, Color.White);
            Console.WriteLine("Value of r: " + r, Color.White);
            Console.Write("Permutation of " + n + " and " + r + " without repetition is: ", Color.White);
            Console.Write(String.Format("{0:#,##0}", PnC.nPr(n, r)), Color.IndianRed);
            Console.WriteLine();
            Choice();

        }
 
        public void Permutation()                                                                                                           //PERMU
        {
            base.Permutationsign();
            BigInteger n;
            permu_n:
            Console.Write("Enter n: ", Color.White);
            String inp = Console.ReadLine();
            bool cont = true;
            while (cont)
            {
                if (inp.Trim() == "" || inp == " ")
                {
                    Console.Clear();
                    base.Permutationsign();
                    Console.WriteLine("Value of 'n' should be greater than 0 and less than 500", Color.White);
                    goto permu_n;
                }
                else if (reg.Match(inp).Success)
                {
                    Console.Clear();
                    base.Permutationsign();
                    Console.WriteLine("Value of 'n' should be greater than 0 and less than 500", Color.White);
                    goto permu_n;
                }
                else
                {
                    n = BigInteger.Parse(inp);
                    if (n <= 500 && n > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        base.Permutationsign();
                        Console.WriteLine("Value of 'n' should be greater than 0 and less than 500", Color.White);
                        goto permu_n;
                    }
                }
            }
            Console.Clear();
            base.Permutationsign();
            n = BigInteger.Parse(inp);
            BigInteger r;
            Console.WriteLine("Value of n: " + n, Color.White);
            permu_r:
            Console.Write("Enter r: ", Color.White);
            String inp2 = Console.ReadLine();
            while (cont)
            {
                if (inp2.Trim() == "" || inp2 == " ")
                {
                    Console.Clear();
                    base.Permutationsign();
                    Console.WriteLine("Value of n: " + n, Color.White);
                    Console.WriteLine("Value of 'r' should be less than 500 and 'n' should be greater or equal to 'r'", Color.White);
                    goto permu_r;
                }
                else if (reg.Match(inp2).Success)
                {
                    Console.Clear();
                    base.Permutationsign();
                    Console.WriteLine("Value of n: " + n, Color.White);
                    Console.WriteLine("Value of 'r' should be less than 500 and 'n' should be greater or equal to 'r'", Color.White);
                    goto permu_r;
                }
                else
                {
                    r = BigInteger.Parse(inp2);
                    if (r <= 500 && n >= r)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        base.Permutationsign();
                        Console.WriteLine("Value of n: " + n, Color.White);
                        Console.WriteLine("Value of 'r' should be less than 500 and 'n' should be greater or equal to 'r'", Color.White);
                        goto permu_r;
                    }
                }

            }
            r = BigInteger.Parse(inp2);
            Console.Clear();
            base.Permutationsign();
            Console.WriteLine("Value of n: " + n, Color.White);
            Console.WriteLine("Value of r: " + r, Color.White);
            Console.Write("Permutation of " + n + " and " + r + " with repetition is: ", Color.White);
            Console.Write(String.Format("{0:#,##0}", PnC.nPrWR(n, r)), Color.IndianRed);
            Console.WriteLine();
            Choice();
        }


        public void CombinationX()                                                                                                              //COMBIX
        {
            base.CombinationXsign();
            BigInteger n;
            combiX_n:
            Console.Write("Enter n: ", Color.White);
            String inp = Console.ReadLine();
            bool cont = true;
            while (cont)
            {
                if (inp.Trim() == "" || inp == " ")
                {
                    Console.Clear();
                    base.CombinationXsign();
                    Console.WriteLine("Value of 'n' should be greater than 0 and less than 500", Color.White);
                    goto combiX_n;

                }
                else if (reg.Match(inp).Success)
                {
                    Console.Clear();
                    base.CombinationXsign();
                    Console.WriteLine("Value of 'n' should be greater than 0 and less than 500", Color.White);
                    goto combiX_n;
                }
                else
                {
                    n = BigInteger.Parse(inp);
                    if (n <= 500 && n > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        base.CombinationXsign();
                        Console.WriteLine("Value of 'n' should be greater than 0 and less than 500", Color.White);
                        goto combiX_n;
                    }
                }
            }
            Console.Clear();
            base.CombinationXsign();
            n = BigInteger.Parse(inp);
            BigInteger r;
            Console.WriteLine("Value of n: " + n, Color.White);
            combiX_r:
            Console.Write("Enter r: ", Color.White);
            String inp2 = Console.ReadLine();
            while (cont)
            {
                if (inp2.Trim() == "" || inp2 == " ")
                {
                    Console.Clear();
                    base.CombinationXsign();
                    Console.WriteLine("Value of n: " + n, Color.White);
                    Console.WriteLine("Value of 'r' should be less than 500 and 'n' should be greater or equal to 'r'", Color.White);
                    goto combiX_r;
                }
                else if (reg.Match(inp2).Success)
                {
                    Console.Clear();
                    base.CombinationXsign();
                    Console.WriteLine("Value of n: " + n, Color.White);
                    Console.WriteLine("Value of 'r' should be less than 500 and 'n' should be greater or equal to 'r'", Color.White);
                    goto combiX_r;
                }
                else
                {
                    r = BigInteger.Parse(inp2);
                    if (r <= 500 && n >= r)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        base.CombinationXsign();
                        Console.WriteLine("Value of n: " + n, Color.White);
                        Console.WriteLine("Value of 'r' should be less than 500 and 'n' should be greater or equal to 'r'", Color.White);
                        goto combiX_r;
                    }
                }

            }
            r = BigInteger.Parse(inp2);
            Console.Clear();
            base.CombinationXsign();
            Console.WriteLine("Value of n: " + n, Color.White);
            Console.WriteLine("Value of r: " + r, Color.White);
            Console.Write("Combination of " + n + " and " + r + " without repetition is: ", Color.White);
            Console.Write(String.Format("{0:#,##0}", PnC.nCr(n, r)), Color.IndianRed);
            Console.WriteLine();
            Choice();
        }

        public void Combination()                                                                                                                      //COMBI
        {
            base.Combinationsign();
            BigInteger n;
            combi_n:
            Console.Write("Enter n: ", Color.White);
            String inp = Console.ReadLine();
            bool cont = true;
            while (cont)
            {
                if (inp.Trim() == "" || inp == " ")
                {
                    Console.Clear();
                    base.Combinationsign();
                    Console.WriteLine("Value of 'n' should be greater than 0 and less than 500", Color.White);
                    goto combi_n;
                }
                else if (reg.Match(inp).Success)
                {
                    Console.Clear();
                    base.Combinationsign();
                    Console.WriteLine("Value of 'n' should be greater than 0 and less than 500", Color.White);
                    goto combi_n;
                }
                else
                {
                    n = BigInteger.Parse(inp);
                    if (n <= 500 && n > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        base.Combinationsign();
                        Console.WriteLine("Value of 'n' should be greater than 0 and less than 500", Color.White);
                        goto combi_n;
                    }
                }
            }
            Console.Clear();
            base.Combinationsign();
            n = BigInteger.Parse(inp);
            BigInteger r;
            Console.WriteLine("Value of n: " + n, Color.White);
            combi_r:
            Console.Write("Enter r: ", Color.White);
            String inp2 = Console.ReadLine();
            while (cont)
            {
                if (inp2.Trim() == "" || inp == " ")
                {
                    Console.Clear();
                    base.Combinationsign();
                    Console.WriteLine("Value of n: " + n, Color.White);
                    Console.WriteLine("Value of 'r' should be less than 500 and 'n' should be greater or equal to 'r'", Color.White);
                    goto combi_r;
                }
                else if (reg.Match(inp2).Success)
                {
                    Console.Clear();
                    base.Combinationsign();
                    Console.WriteLine("Value of n: " + n, Color.White);
                    Console.WriteLine("Value of 'r' should be less than 500 and 'n' should be greater or equal to 'r'", Color.White);
                    goto combi_r;
                }
                else
                {
                    r = BigInteger.Parse(inp2);
                    if (r <= 500 && n >= r)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        base.Combinationsign();
                        Console.WriteLine("Value of n: " + n, Color.White);
                        Console.WriteLine("Value of 'r' should be less than 500 and 'n' should be greater or equal to 'r'", Color.White);
                        goto combi_r;
                    }
                }

            }
            r = BigInteger.Parse(inp2);
            Console.Clear();
            base.Combinationsign();
            Console.WriteLine("Value of n: " + n, Color.White);
            Console.WriteLine("Value of r: " + r, Color.White);
            Console.Write("Combination of " + n + " and " + r + " with repetition is: ", Color.White);
            Console.Write(String.Format("{0:#,##0}", PnC.nCrWR(n, r)), Color.IndianRed);
            Console.WriteLine();
            Choice();
        }

        public void StirlingNumber()                                                                                                                    //STIRLING
        {
            base.Stirlingsign();
            BigInteger n;
            stirling_n:
            Console.Write("Enter n: ", Color.White);
            String inp = Console.ReadLine();
            bool cont = true;
            while (cont)
            {
                if (inp.Trim() == "" || inp == " ")
                {
                    Console.Clear();
                    base.Stirlingsign();
                    Console.WriteLine("Value of 'n' should be greater than 0 and less than 500", Color.White);
                    goto stirling_n;

                }
                else if (reg.Match(inp).Success)
                {
                    Console.Clear();
                    base.Stirlingsign();
                    Console.WriteLine("Value of 'n' should be greater than 0 and less than 500", Color.White);
                    goto stirling_n;

                }
                else
                {
                    n = BigInteger.Parse(inp);
                    if (n <= 500 && n > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        base.Stirlingsign();
                        Console.WriteLine("Value of 'n' should be greater than 0 and less than 500", Color.White);
                        goto stirling_n;
                    }
                }
            }
            Console.Clear();
            base.Stirlingsign();
            n = BigInteger.Parse(inp);
            BigInteger k;
            Console.WriteLine("Value of n: " + n, Color.White);
            stirling_k:
            Console.Write("Enter r: ", Color.White);
            String inp2 = Console.ReadLine();
            while (cont)
            {
                if (inp2.Trim() == "" || inp2 == " ")
                {
                    Console.Clear();
                    base.Stirlingsign();
                    Console.WriteLine("Value of n: " + n, Color.White);
                    Console.WriteLine("Value of 'k' should be greater than 0, less than 500 and 'n' should be greater or equal to 'k'", Color.White);
                    goto stirling_k;
                }
                else if (reg.Match(inp2).Success)
                {
                    Console.Clear();
                    base.Stirlingsign();
                    Console.WriteLine("Value of n: " + n, Color.White);
                    Console.WriteLine("Value of 'k' should be greater than 0, less than 500 and 'n' should be greater or equal to 'k'", Color.White);
                    goto stirling_k;
                }
                else
                {
                    k = BigInteger.Parse(inp2);
                    if (k <= 500 && k > 0 && n >= k)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        base.Stirlingsign();
                        Console.WriteLine("Value of n: " + n, Color.White);
                        Console.WriteLine("Value of 'k' should be greater than 0, less than 500 and 'n' should be greater or equal to 'k'", Color.White);
                        goto stirling_k;
                    }
                }

            }
            k = BigInteger.Parse(inp2);
            Console.Clear();
            base.Stirlingsign();
            Console.WriteLine("Value of n: " + n, Color.White);
            Console.WriteLine("Value of k: " + k, Color.White);
            Console.Write("S({0},{1}) is: ",n,k, Color.White);
            Console.Write(String.Format("{0:#,##0}", PnC.Stirling_method(n, k)), Color.IndianRed);
            Console.WriteLine();
            Choice();
        }

        public void PascalGenerator()                                                                                                             //PASCALRG
        {
            base.PascalTrianglesign();
            bool cont = true;
            while (cont)
            {
                Console.Write("Enter row number: ", Color.White);
                string inp = Console.ReadLine();
                if (inp.Trim() == "" || inp == " ")
                {
                    Console.Clear();
                    base.PascalTrianglesign();
                    Console.WriteLine("Please enter a number between 0 - 500", Color.White);
                }
                else if (reg.Match(inp).Success)
                {
                    Console.Clear();
                    base.PascalTrianglesign();
                    Console.WriteLine("Please enter a number between 0 - 500", Color.White);

                }
                else
                {
                    BigInteger rows = BigInteger.Parse(inp);
                    if (rows == 0)
                    {
                        Console.Clear();
                        base.PascalTrianglesign();
                        Console.WriteLine("Row Number: " + rows, Color.White);
                        Console.WriteLine("Pascal Triangle Generated Row:", Color.White);
                        Console.WriteLine("|" + "\t1" + "\t|", Color.White);
                        break;
                    }
                    else if (rows <= 500 && rows >= 0)
                    {
                        BigInteger val = 1, i;
                        Console.Clear();
                        base.PascalTrianglesign();
                        Console.WriteLine("Row Number: " + rows, Color.White);
                        Console.WriteLine("Pascal Triangle Generated Row:", Color.White);
                        for (i = 1; i <= rows; i++)
                        {
                            Console.Write("\t", Color.White);
                            Console.Write(String.Format("{0:#,##0}", val), Color.White);
                            Console.Write("\t|", Color.White);
                            val = (val * (rows + 1 - i)) / i;



                        }
                        Console.WriteLine("\t1", Color.White);
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        base.PascalTrianglesign();
                        Console.WriteLine("Please enter number between 0 - 500", Color.White);
                    }
                }
            }
            Console.WriteLine();
            Choice();
        }

        public void Choice()
        {

            Console.Write("\nPress ENTER key to continue, or ANY key to end.", Color.White);
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Start();
                break;
            }
            End();


        }

        public virtual void Start()
        {
            //loops start
        }
        public virtual void End()
        {
            //end
        }
    }
}