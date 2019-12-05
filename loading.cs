using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace DiscreteProject
{
    class loading
    {
        startexit anzu = new startexit();

        public static void Clear(int x, int y, int width, int height)
        {
            int curTop = Console.CursorTop;
            int curLeft = Console.CursorLeft;
            for (; height > 0;)
            {
                Console.SetCursorPosition(x, y - --height);
                Console.Write(new string(' ', width));
            }
            Console.SetCursorPosition(curLeft, curTop);
        }
        
        public void load()
        {
            Console.WriteLine("Please wait while pre-loading data.");

            ConsoleSpinner spinner = new ConsoleSpinner();
            spinner.Delay = 100;
            int PreloadCount = 0;
            bool spin = true;
            while(spin)
            {
                spinner.Turn(displayMsg: "Loading/Streaming Resources", sequenceCode: 4);
                if (PreloadCount != 20)
                {
                    PreloadCount += 1;
                }
                if (PreloadCount == 20)
                {
                    break;
                }
            }
            PreloadCount = 0;
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            Console.WriteLine("Resources............................OK");


            while(spin)
            {
                spinner.Turn(displayMsg: "Loading Signs", sequenceCode: 4);
                if(PreloadCount != 20)
                {
                    PreloadCount += 1;
                }
                if(PreloadCount == 20)
                {
                    break;
                }
            }


            int testfail = 0;

            anzu.Discretesign();
            testfail += 1;
            Thread.Sleep(5);
            Clear(0, 20, 200, 20);
            Console.SetCursorPosition(0, 3);

            anzu.PermutationXsign();
            testfail += 1;
            Thread.Sleep(5);
            Clear(0, 20, 200, 20);
            Console.SetCursorPosition(0, 3);

            anzu.Permutationsign();
            testfail += 1;
            Thread.Sleep(5);
            Clear(0, 20, 200, 20);
            Console.SetCursorPosition(0, 3);

            anzu.CombinationXsign();
            testfail += 1;
            Thread.Sleep(5);
            Clear(0, 20, 200, 20);
            Console.SetCursorPosition(0, 3);

            anzu.Combinationsign();
            testfail += 1;
            Thread.Sleep(5);
            Clear(0, 20, 200, 20);
            Console.SetCursorPosition(0, 3);

            anzu.Stirlingsign();
            testfail += 1;
            Thread.Sleep(5);
            Clear(0, 20, 200, 20);
            Console.SetCursorPosition(0, 3);

            anzu.PascalTrianglesign();
            testfail += 1;
            Thread.Sleep(5);
            Clear(0, 20, 200, 20);
            Console.SetCursorPosition(0, 1);
            if(testfail == 7)
            {
                Console.Clear();
                Console.WriteLine("Pre-load data summary: ");
                Console.WriteLine("┌----------------------------------------┐");
                Console.WriteLine("| Resources...........................OK |");
                Console.WriteLine("| Signs...............................OK |");
                Console.WriteLine("└----------------------------------------┘");
                Console.WriteLine("                 SUCCESS!                 ");
                
                Thread.Sleep(5000);
                anzu.Start();
            }
            else
            {
                Console.WriteLine("Something went wrong while pre-loading data.");
                Console.WriteLine("Please re-open application.");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
            
        }

        private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("DiscreteProject.Colorful.Console.dll"))
            {
                byte[] assemblyData = new byte[stream.Length];
                stream.Read(assemblyData, 0, assemblyData.Length);
                return Assembly.Load(assemblyData);
            }
        }
    }
    public class ConsoleSpinner
    {
        static string[,] sequence = null;

        public int Delay { get; set; } = 200;

        int totalSequences = 0;
        int counter;

        public ConsoleSpinner()
        {
            counter = 0;
            sequence = new string[,] {
  
            { "/", "—", "\\", "|" },
            { ".", "o", "0", "o" },
            { "+", "x","+","x" },
            { "V", "<", "^", ">" },
            { ".   ", "..  ", "... ", "...." },
            { "=>   ", "==>  ", "===> ", "====>" },       
        };

            totalSequences = sequence.GetLength(0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sequenceCode"> 0 | 1 | 2 |3 | 4 | 5 </param>
        public void Turn(string displayMsg = "", int sequenceCode = 0)
        {
            counter++;

            Thread.Sleep(Delay);

            sequenceCode = sequenceCode > totalSequences - 1 ? 0 : sequenceCode;

            int counterValue = counter % 4;

            string fullMessage = displayMsg + sequence[sequenceCode, counterValue];
            int msglength = fullMessage.Length;

            Console.Write(fullMessage);

            Console.SetCursorPosition(Console.CursorLeft - msglength, Console.CursorTop);
        }       
    }
}

