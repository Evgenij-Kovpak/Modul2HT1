using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HT1
{
    public class Starter
    {
        public void Run()
        {
            var actions = new Actions();
            for(int i = 0; i < 100; i++)
            {
                int num = new Random().Next(1, 4);
                Result result = null;

                switch (num)
                {
                    case 1:
                        result = actions.Method1();
                        break;
                    case 2:
                        result = actions.Method2();
                        break;
                    case 3:
                        result = actions.Method3();
                        break;
                }

                if (result != null && !result.Status)
                {
                    var item = new LogItem(DateTime.Now, "Action failed by reason.Status is false", TypeOfLoggin.Error);
                    Logger.GetInstance().Log(item);
                }
            }
            var text = new StringBuilder();
            for (int i = 0; i < Logger.GetInstance().Storage.Length; i++)
            {
                if(Logger.GetInstance().Storage[i] != null)
                {
                    break;
                }
                var item = Logger.GetInstance().Storage[i];
                text.AppendLine(item.Time.ToShortTimeString() + " Type:" + item.Type + "Message:" + item.Message);
            }

            File.WriteAllText("log.txt", text.ToString());
        }
    }
}
