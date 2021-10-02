using Lab.core;
using System.Collections.Generic;

namespace Lab3.Kumachev
{
    public class KumachevLog : LogAbstract, LogInterface
    {
        private static KumachevLog instance;

        private readonly List<string> logs;

        private KumachevLog()
        {
            logs = new List<string>();
        }

        public static KumachevLog I()
        {
            if (instance == null)
                instance = new KumachevLog();

            return instance;
        }

        public LogInterface Log(string str)
        {
            logs.Add(str);
            return this;
        }

        public LogInterface Write()
        {
            writeConsole(logs.ToArray());
            return this;
        }
    }
}
