using System;
using System.Windows.Forms;

namespace ptext
{
    class Program
    {
        private static string GeneratePyramidText(string args)
        {
            string s = "";
            string allChars = "";
            foreach (char c in args)
            {
                allChars += c;
                if (c != ' ')
                    s += $"{allChars}\n";
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
            {
                throw new Exception("Args are empty!");
            }
            Clipboard.SetText(GeneratePyramidText(string.Join(" ", args)));
            Console.WriteLine("Copied to clipboard.");
        }
    }
}
