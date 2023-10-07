using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    internal class Lumina
    {
        string[] BreakChars = {"(", ";", "{", " ", "=" };
        public static Terminal terminal = new Terminal();
        public void StartProgram(string Code)
        {
            terminal.Show();
            string[] Lines = Code.Split('\n');
            Execute(Lines);
        }

        private void Execute(string[] Lines)
        {
            languageFeatures languageFeaturesInstance = new languageFeatures();
            int i = 0;
            foreach (string Line in Lines)
            {
                i++;
                //terminal.UpdateValue("Yay Line " + i + "Read" + "\n");
                char[] LineArr = Line.ToCharArray();
                if (LineArr.Length > 0)
                {
                    //Now run though each line and see if they are a keyword
                    string buf = "";
                    string Keyword = "";
                    for(int j = 0; j < LineArr.Length; j++)
                    {
                        if (IsIn(BreakChars, LineArr[j].ToString()))
                        {
                            Keyword = buf;
                            string ValueOfKeyWord = "hi";
                            buf = "";
                            object[] methodArguments = new object[] { ValueOfKeyWord };
                            MethodInfo methodInfo = typeof(languageFeatures).GetMethod(Keyword);
                            if (methodInfo != null)
                            {
                                methodInfo.Invoke(languageFeaturesInstance, methodArguments);
                            }
                            else
                            {
                                Console.WriteLine("Method not found: " + Keyword);
                            }
                        }
                        else
                        {
                            buf += LineArr[j].ToString();
                        }

                        
                    }
                }
                
            }
        }

        bool IsIn(string[] Chars, string c)
        {
            for(int i = 0; i < Chars.Length; i++)
            {
                if (Chars[i] == c)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class languageFeatures
    {
        public void print(string Text)
        {
            Terminal terminal = Lumina.terminal;
            terminal.UpdateValue(Text);
        }
    }
}
