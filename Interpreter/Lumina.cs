using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    internal class Lumina
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
                //terminal.UpdateValue("Yay Line " + i + "Read" + "\n");
                char[] LineArr = Line.ToCharArray();
                if (LineArr.Length > 0)
                {
                    terminal.UpdateValue(LineArr[6].ToString());
                }
                
            }
        }
    }

    public class languageFeatures
    {
        public void print()
        {

        }
    }
}
