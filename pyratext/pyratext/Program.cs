using System;
using System.Windows.Forms;

namespace ptext
{
    class Program
    {
        private static string[] AskUserForSplitString(string info)
        {
            string s = "";
            do
            {
                Console.Clear();
                Console.WriteLine(info);
                s = Console.ReadLine();
            }
            while (s.Length == 0);
            return s.Split(' ');
        }

        private static string GeneratePyramidText(string text)
        {
            string s = "";
            string allChars = "";
            foreach (char character in text)
            {
                allChars += character;
                if (character != ' ')
                {
                    if (text.Length == 1)
                        s += $"{allChars}";
                    else s += $"{allChars}\n";
                }
            }
            while (allChars.Length > 1)
            {
                allChars = allChars.Substring(0, allChars.Length - 1);
                if (allChars[allChars.Length - 1] != ' ')
                {
                    if (allChars.Length == 1)
                        s += $"{allChars}";
                    else s += $"{allChars}\n";
                }
            }
            return s;
        }

        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
                args = AskUserForSplitString("Enter text to become pyramid text:");
            Clipboard.SetText(GeneratePyramidText(string.Join(" ", args)));
            Console.WriteLine("Copied to clipboard.");
        }
    }
}
