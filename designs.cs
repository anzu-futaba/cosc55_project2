﻿using System;
using System.Collections.Generic;
using System.Drawing;
using Console = Colorful.Console;

namespace DiscreteProject
{
    internal class Designs
    {
        public void Discretesign()
        {
            Colorful.Console.ReplaceAllColorsWithDefaults();
            String[] dm = new string[]
            {
                "██████╗ ██╗███████╗ ██████╗██████╗ ███████╗████████╗███████╗                                       ",
                "██╔══██╗██║██╔════╝██╔════╝██╔══██╗██╔════╝╚══██╔══╝██╔════╝                                       ",
                "██║  ██║██║███████╗██║     ██████╔╝█████╗     ██║   █████                                          ",
                "██║  ██║██║╚════██║██║     ██╔══██╗██╔══╝     ██║   ██╔══╝                                         ",
                "██████╔╝██║███████║╚██████╗██║  ██║███████╗   ██║   ███████╗                                       ",
                "╚═════╝ ╚═╝╚══════╝ ╚═════╝╚═╝  ╚═╝╚══════╝   ╚═╝   ╚══════╝                                       ",
                "                                                                                                   ",
                "███╗   ███╗ █████╗ ████████╗██╗  ██╗███████╗███╗   ███╗ █████╗ ████████╗██╗ ██████╗███████╗  ██╗██╗",
                "████╗ ████║██╔══██╗╚══██╔══╝██║  ██║██╔════╝████╗ ████║██╔══██╗╚══██╔══╝██║██╔════╝██╔════╝  ██║██║",
                "██╔████╔██║███████║   ██║   ███████║█████╗  ██╔████╔██║███████║   ██║   ██║██║     ███████╗  ██║██║",
                "██║╚██╔╝██║██╔══██║   ██║   ██╔══██║██╔══╝  ██║╚██╔╝██║██╔══██║   ██║   ██║██║     ╚════██║  ██║██║",
                "██║ ╚═╝ ██║██║  ██║   ██║   ██║  ██║███████╗██║ ╚═╝ ██║██║  ██║   ██║   ██║╚██████╗███████║  ██║██║",
                "╚═╝     ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═╝  ╚═╝╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝  ╚═╝╚═╝"
            };
            Console.WriteLineWithGradient(dm, Color.MistyRose, Color.DarkTurquoise, 15);
            Console.WriteLine();
            Console.WriteLine("1. Permutation(Without Repetition)", Color.White);
            Console.WriteLine("2. Permutation(With Repetition)", Color.White);
            Console.WriteLine("3. Combination(Without Repetition)", Color.White);
            Console.WriteLine("4. Combination(With Repetition)", Color.White);
            Console.WriteLine("5. Stirling Number of Second Case", Color.White);
            Console.WriteLine("6. Pascal Triangle Row Generator", Color.White);
            Console.WriteLine();
        }

        public void PermutationXsign()
        {
            Colorful.Console.ReplaceAllColorsWithDefaults();
            String[] pnr = new string[]
                {
                    "██████╗ ███████╗██████╗ ███╗   ███╗██╗   ██╗████████╗ █████╗ ████████╗██╗ ██████╗ ███╗   ██╗              ",
                    "██╔══██╗██╔════╝██╔══██╗████╗ ████║██║   ██║╚══██╔══╝██╔══██╗╚══██╔══╝██║██╔═══██╗████╗  ██║              ",
                    "██████╔╝█████╗  ██████╔╝██╔████╔██║██║   ██║   ██║   ███████║   ██║   ██║██║   ██║██╔██╗ ██║              ",
                    "██╔═══╝ ██╔══╝  ██╔══██╗██║╚██╔╝██║██║   ██║   ██║   ██╔══██║   ██║   ██║██║   ██║██║╚██╗██║              ",
                    "██║     ███████╗██║  ██║██║ ╚═╝ ██║╚██████╔╝   ██║   ██║  ██║   ██║   ██║╚██████╔╝██║ ╚████║              ",
                    "╚═╝     ╚══════╝╚═╝  ╚═╝╚═╝     ╚═╝ ╚═════╝    ╚═╝   ╚═╝  ╚═╝   ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝              ",
                    " ██╗███╗   ██╗ ██████╗     ██████╗ ███████╗██████╗ ███████╗████████╗██╗████████╗██╗ ██████╗ ███╗   ██╗██╗ ",
                    "██╔╝████╗  ██║██╔═══██╗    ██╔══██╗██╔════╝██╔══██╗██╔════╝╚══██╔══╝██║╚══██╔══╝██║██╔═══██╗████╗  ██║╚██╗",
                    "██║ ██╔██╗ ██║██║   ██║    ██████╔╝█████╗  ██████╔╝█████╗     ██║   ██║   ██║   ██║██║   ██║██╔██╗ ██║ ██║",
                    "██║ ██║╚██╗██║██║   ██║    ██╔══██╗██╔══╝  ██╔═══╝ ██╔══╝     ██║   ██║   ██║   ██║██║   ██║██║╚██╗██║ ██║",
                    "╚██╗██║ ╚████║╚██████╔╝    ██║  ██║███████╗██║     ███████╗   ██║   ██║   ██║   ██║╚██████╔╝██║ ╚████║██╔╝",
                    " ╚═╝╚═╝  ╚═══╝ ╚═════╝     ╚═╝  ╚═╝╚══════╝╚═╝     ╚══════╝   ╚═╝   ╚═╝   ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝ "
                };
            int r = 255;
            int g = 255;
            int b = 255;
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(pnr[i], Color.FromArgb(r, g, b));
                r -= 2;
                g -= 18;
                b -= 18;
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        public void Permutationsign()
        {
            Colorful.Console.ReplaceAllColorsWithDefaults();
            String[] pwr = new string[]
                {
                    "██████╗ ███████╗██████╗ ███╗   ███╗██╗   ██╗████████╗ █████╗ ████████╗██╗ ██████╗ ███╗   ██╗                         ",
                    "██╔══██╗██╔════╝██╔══██╗████╗ ████║██║   ██║╚══██╔══╝██╔══██╗╚══██╔══╝██║██╔═══██╗████╗  ██║                         ",
                    "██████╔╝█████╗  ██████╔╝██╔████╔██║██║   ██║   ██║   ███████║   ██║   ██║██║   ██║██╔██╗ ██║                         ",
                    "██╔═══╝ ██╔══╝  ██╔══██╗██║╚██╔╝██║██║   ██║   ██║   ██╔══██║   ██║   ██║██║   ██║██║╚██╗██║                         ",
                    "██║     ███████╗██║  ██║██║ ╚═╝ ██║╚██████╔╝   ██║   ██║  ██║   ██║   ██║╚██████╔╝██║ ╚████║                         ",
                    "╚═╝     ╚══════╝╚═╝  ╚═╝╚═╝     ╚═╝ ╚═════╝    ╚═╝   ╚═╝  ╚═╝   ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝                         ",
                    " ██╗██╗    ██╗██╗████████╗██╗  ██╗    ██████╗ ███████╗██████╗ ███████╗████████╗██╗████████╗██╗ ██████╗ ███╗   ██╗██╗ ",
                    "██╔╝██║    ██║██║╚══██╔══╝██║  ██║    ██╔══██╗██╔════╝██╔══██╗██╔════╝╚══██╔══╝██║╚══██╔══╝██║██╔═══██╗████╗  ██║╚██╗",
                    "██║ ██║ █╗ ██║██║   ██║   ███████║    ██████╔╝█████╗  ██████╔╝█████╗     ██║   ██║   ██║   ██║██║   ██║██╔██╗ ██║ ██║",
                    "██║ ██║███╗██║██║   ██║   ██╔══██║    ██╔══██╗██╔══╝  ██╔═══╝ ██╔══╝     ██║   ██║   ██║   ██║██║   ██║██║╚██╗██║ ██║",
                    "╚██╗╚███╔███╔╝██║   ██║   ██║  ██║    ██║  ██║███████╗██║     ███████╗   ██║   ██║   ██║   ██║╚██████╔╝██║ ╚████║██╔╝",
                    " ╚═╝ ╚══╝╚══╝ ╚═╝   ╚═╝   ╚═╝  ╚═╝    ╚═╝  ╚═╝╚══════╝╚═╝     ╚══════╝   ╚═╝   ╚═╝   ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝ "
                };
            Colorful.Console.WriteLineWithGradient(pwr, Color.Violet, Color.OrangeRed, 14);
            Console.WriteLine();
        }

        public void CombinationXsign()
        {
            Colorful.Console.ReplaceAllColorsWithDefaults();
            String[] cnr = new string[]
                {
            " ██████╗ ██████╗ ███╗   ███╗██████╗ ██╗███╗   ██╗ █████╗ ████████╗██╗ ██████╗ ███╗   ██╗                  ",
            "██╔════╝██╔═══██╗████╗ ████║██╔══██╗██║████╗  ██║██╔══██╗╚══██╔══╝██║██╔═══██╗████╗  ██║                  ",
            "██║     ██║   ██║██╔████╔██║██████╔╝██║██╔██╗ ██║███████║   ██║   ██║██║   ██║██╔██╗ ██║                  ",
            "██║     ██║   ██║██║╚██╔╝██║██╔══██╗██║██║╚██╗██║██╔══██║   ██║   ██║██║   ██║██║╚██╗██║                  ",
            "╚██████╗╚██████╔╝██║ ╚═╝ ██║██████╔╝██║██║ ╚████║██║  ██║   ██║   ██║╚██████╔╝██║ ╚████║                  ",
            " ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚═════╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝   ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝                  ",
            " ██╗███╗   ██╗ ██████╗     ██████╗ ███████╗██████╗ ███████╗████████╗██╗████████╗██╗ ██████╗ ███╗   ██╗██╗ ",
            "██╔╝████╗  ██║██╔═══██╗    ██╔══██╗██╔════╝██╔══██╗██╔════╝╚══██╔══╝██║╚══██╔══╝██║██╔═══██╗████╗  ██║╚██╗",
            "██║ ██╔██╗ ██║██║   ██║    ██████╔╝█████╗  ██████╔╝█████╗     ██║   ██║   ██║   ██║██║   ██║██╔██╗ ██║ ██║",
            "██║ ██║╚██╗██║██║   ██║    ██╔══██╗██╔══╝  ██╔═══╝ ██╔══╝     ██║   ██║   ██║   ██║██║   ██║██║╚██╗██║ ██║",
            "╚██╗██║ ╚████║╚██████╔╝    ██║  ██║███████╗██║     ███████╗   ██║   ██║   ██║   ██║╚██████╔╝██║ ╚████║██╔╝",
            " ╚═╝╚═╝  ╚═══╝ ╚═════╝     ╚═╝  ╚═╝╚══════╝╚═╝     ╚══════╝   ╚═╝   ╚═╝   ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝ "
                };
            Console.WriteLineWithGradient(cnr, Color.Crimson, Color.Cyan, 14);
            Console.WriteLine();
        }

        public void Combinationsign()
        {
            Colorful.Console.ReplaceAllColorsWithDefaults();
            String[] cwr = new string[]
                {
            " ██████╗ ██████╗ ███╗   ███╗██████╗ ██╗███╗   ██╗ █████╗ ████████╗██╗ ██████╗ ███╗   ██╗                             ",
            "██╔════╝██╔═══██╗████╗ ████║██╔══██╗██║████╗  ██║██╔══██╗╚══██╔══╝██║██╔═══██╗████╗  ██║                             ",
            "██║     ██║   ██║██╔████╔██║██████╔╝██║██╔██╗ ██║███████║   ██║   ██║██║   ██║██╔██╗ ██║                             ",
            "██║     ██║   ██║██║╚██╔╝██║██╔══██╗██║██║╚██╗██║██╔══██║   ██║   ██║██║   ██║██║╚██╗██║                             ",
            "╚██████╗╚██████╔╝██║ ╚═╝ ██║██████╔╝██║██║ ╚████║██║  ██║   ██║   ██║╚██████╔╝██║ ╚████║                             ",
            " ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚═════╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝   ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝                             ",
            " ██╗██╗    ██╗██╗████████╗██╗  ██╗    ██████╗ ███████╗██████╗ ███████╗████████╗██╗████████╗██╗ ██████╗ ███╗   ██╗██╗ ",
            "██╔╝██║    ██║██║╚══██╔══╝██║  ██║    ██╔══██╗██╔════╝██╔══██╗██╔════╝╚══██╔══╝██║╚══██╔══╝██║██╔═══██╗████╗  ██║╚██╗",
            "██║ ██║ █╗ ██║██║   ██║   ███████║    ██████╔╝█████╗  ██████╔╝█████╗     ██║   ██║   ██║   ██║██║   ██║██╔██╗ ██║ ██║",
            "██║ ██║███╗██║██║   ██║   ██╔══██║    ██╔══██╗██╔══╝  ██╔═══╝ ██╔══╝     ██║   ██║   ██║   ██║██║   ██║██║╚██╗██║ ██║",
            "╚██╗╚███╔███╔╝██║   ██║   ██║  ██║    ██║  ██║███████╗██║     ███████╗   ██║   ██║   ██║   ██║╚██████╔╝██║ ╚████║██╔╝",
            " ╚═╝ ╚══╝╚══╝ ╚═╝   ╚═╝   ╚═╝  ╚═╝    ╚═╝  ╚═╝╚══════╝╚═╝     ╚══════╝   ╚═╝   ╚═╝   ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝ "
                };
            Console.WriteLineWithGradient(cwr, Color.Cyan, Color.Fuchsia, 14);
            Console.WriteLine();
        }

        public void Stirlingsign()
        {
            Colorful.Console.ReplaceAllColorsWithDefaults();
            String[] snosc = new string[]
                {
            "███████╗████████╗██╗██████╗ ██╗     ██╗███╗   ██╗ ██████╗     ███╗   ██╗██╗   ██╗███╗   ███╗██████╗ ███████╗██████╗ ",
            "██╔════╝╚══██╔══╝██║██╔══██╗██║     ██║████╗  ██║██╔════╝     ████╗  ██║██║   ██║████╗ ████║██╔══██╗██╔════╝██╔══██╗",
            "███████╗   ██║   ██║██████╔╝██║     ██║██╔██╗ ██║██║  ███╗    ██╔██╗ ██║██║   ██║██╔████╔██║██████╔╝█████╗  ██████╔╝",
            "╚════██║   ██║   ██║██╔══██╗██║     ██║██║╚██╗██║██║   ██║    ██║╚██╗██║██║   ██║██║╚██╔╝██║██╔══██╗██╔══╝  ██╔══██╗",
            "███████║   ██║   ██║██║  ██║███████╗██║██║ ╚████║╚██████╔╝    ██║ ╚████║╚██████╔╝██║ ╚═╝ ██║██████╔╝███████╗██║  ██║",
            "╚══════╝   ╚═╝   ╚═╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═══╝ ╚═════╝     ╚═╝  ╚═══╝ ╚═════╝ ╚═╝     ╚═╝╚═════╝ ╚══════╝╚═╝  ╚═╝",
            " ██████╗ ███████╗    ███████╗███████╗ ██████╗ ██████╗ ███╗   ██╗██████╗      ██████╗ █████╗ ███████╗███████╗        ",
            "██╔═══██╗██╔════╝    ██╔════╝██╔════╝██╔════╝██╔═══██╗████╗  ██║██╔══██╗    ██╔════╝██╔══██╗██╔════╝██╔════╝        ",
            "██║   ██║█████╗      ███████╗█████╗  ██║     ██║   ██║██╔██╗ ██║██║  ██║    ██║     ███████║███████╗█████╗          ",
            "██║   ██║██╔══╝      ╚════██║██╔══╝  ██║     ██║   ██║██║╚██╗██║██║  ██║    ██║     ██╔══██║╚════██║██╔══╝          ",
            "╚██████╔╝██║         ███████║███████╗╚██████╗╚██████╔╝██║ ╚████║██████╔╝    ╚██████╗██║  ██║███████║███████╗        ",
            " ╚═════╝ ╚═╝         ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝╚═════╝      ╚═════╝╚═╝  ╚═╝╚══════╝╚══════╝        "
                };
            Console.WriteLineWithGradient(snosc, Color.OrangeRed, Color.Yellow  , 14);
            Console.WriteLine();
        }

        public void PascalTrianglesign()
        {
            Colorful.Console.ReplaceAllColorsWithDefaults();
            String[] ptrg = new string[]
                {
            "██████╗  █████╗ ███████╗ ██████╗ █████╗ ██╗         ████████╗██████╗ ██╗ █████╗ ███╗   ██╗ ██████╗ ██╗     ███████╗",
            "██╔══██╗██╔══██╗██╔════╝██╔════╝██╔══██╗██║         ╚══██╔══╝██╔══██╗██║██╔══██╗████╗  ██║██╔════╝ ██║     ██╔════╝",
            "██████╔╝███████║███████╗██║     ███████║██║            ██║   ██████╔╝██║███████║██╔██╗ ██║██║  ███╗██║     █████╗  ",
            "██╔═══╝ ██╔══██║╚════██║██║     ██╔══██║██║            ██║   ██╔══██╗██║██╔══██║██║╚██╗██║██║   ██║██║     ██╔══╝  ",
            "██║     ██║  ██║███████║╚██████╗██║  ██║███████╗       ██║   ██║  ██║██║██║  ██║██║ ╚████║╚██████╔╝███████╗███████╗", 
            "╚═╝     ╚═╝  ╚═╝╚══════╝ ╚═════╝╚═╝  ╚═╝╚══════╝       ╚═╝   ╚═╝  ╚═╝╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚══════╝╚══════╝",
            "██████╗  ██████╗ ██╗    ██╗     ██████╗ ███████╗███╗   ██╗███████╗██████╗  █████╗ ████████╗ ██████╗ ██████╗        ",
            "██╔══██╗██╔═══██╗██║    ██║    ██╔════╝ ██╔════╝████╗  ██║██╔════╝██╔══██╗██╔══██╗╚══██╔══╝██╔═══██╗██╔══██╗       ",
            "██████╔╝██║   ██║██║ █╗ ██║    ██║  ███╗█████╗  ██╔██╗ ██║█████╗  ██████╔╝███████║   ██║   ██║   ██║██████╔╝       ",
            "██╔══██╗██║   ██║██║███╗██║    ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝  ██╔══██╗██╔══██║   ██║   ██║   ██║██╔══██╗       ",
            "██║  ██║╚██████╔╝╚███╔███╔╝    ╚██████╔╝███████╗██║ ╚████║███████╗██║  ██║██║  ██║   ██║   ╚██████╔╝██║  ██║       ",
            "╚═╝  ╚═╝ ╚═════╝  ╚══╝╚══╝      ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝       "
                };
            Console.WriteLineWithGradient(ptrg, Color.Yellow, Color.Fuchsia, 14);
            Console.WriteLine();
        }
    }
}