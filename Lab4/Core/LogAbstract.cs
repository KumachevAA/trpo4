using System;

namespace Lab.core
{
    public abstract class LogAbstract
    {

        protected string formatLog(string[] strings)
        {
            return string.Join(";\n\r", strings);
        }

        protected void writeConsole(string s)
        {
            Console.WriteLine(s);
        }

        protected void writeConsole(string[] s)
        {
            Console.WriteLine(formatLog(s));
        }
    }
}
