using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HT1
{
    public class Logger
    {
        private LogItem[] _storage = new LogItem[1000];
        private int _index = 0;
        private static Logger _instance;

        public LogItem[] Storage
        {
            get { return _storage; }
        }
        private Logger()
        {

        }
        public static Logger GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Logger();
            }

            return _instance;
        }

        public void Log(LogItem item)
        {
            _storage[_index] = item;
            _index++;
        }
    }
}
