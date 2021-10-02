using Lab.core;
using System;

namespace Lab3.Kumachev
{
    public class KumachevLog : LogAbstract, LogInterface
    {
        private static KumachevLog instance;

        private KumachevLog()
        {
        }

        public static KumachevLog I()
        {
            if (instance == null)
                instance = new KumachevLog();

            return instance;
        }

        public void Log(string str)
        {
            _log(str);
        }

        public void Write()
        {
            _write();
        }

        public override void _log(string str)
        {
            log.Add(str);
        }

        public override void _write()
        {
            foreach (string entry in log)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
