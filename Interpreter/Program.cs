using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpreter
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LuminaMainWindow());
        }

    }

    public class Interpreter
    {
        Terminal terminal = new Terminal();
        public void StartProgram(string Code)
        {
            terminal.Show();
            string[] Lines = Code.Split('\n');
            Execute(Lines);
        }

        private void Execute(string[] Lines)
        {
            int i = 0;
            foreach (string Line in Lines)
            {
                i++;
                Console.WriteLine(Line);
                terminal.UpdateValue("Yay Line " + i + "Read" + "\n");
            }
        }
    }
}
