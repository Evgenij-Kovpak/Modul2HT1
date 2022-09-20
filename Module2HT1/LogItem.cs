using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HT1
{
    public class LogItem
    {
        private string _message;
        private TypeOfLoggin _type;
        private DateTime _time;
        private string v;
        private TypeOfLoggin info;

        public DateTime Time
        {
            get { return _time; }
        }
        public string Message
        {
            get { return _message; }
        }

        public TypeOfLoggin Type
        {
            get { return _type; }
        }
        public LogItem(DateTime time,string message, TypeOfLoggin type)
        {
            _time = time;
            _message = message;
            _type = type;
        }

        public LogItem(string v, TypeOfLoggin info)
        {
            this.v = v;
            this.info = info;
        }
    }
}
