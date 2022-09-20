using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Module2HT1
{
    public class Actions
    {
        private Logger _logger = Logger.GetInstance();
        public Result Method1()
        {
            var item = new LogItem(DateTime.Now, "Start: Method1", TypeOfLoggin.Info);
            _logger.Log(item);
            return new Result(true);
        }

        public Result Method2()
        {
            var item = new LogItem(DateTime.Now, "Skipped logic in method: Method2", TypeOfLoggin.Warning);
            _logger.Log(item);
            return new Result(true);
        }

        public Result Method3()
        {
            var item = new LogItem(DateTime.Now, "I broke logic: Method3", TypeOfLoggin.Error);
            _logger.Log(item);
            return new Result(false);
        }
    }
}
