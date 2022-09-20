using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HT1
{
    public class Result
    {
        private bool _status;
        public bool Status 
        {
            get { return _status; } 
        }

        public Result(bool status)
        {
            _status = status;
        }
    }
}
