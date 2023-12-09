using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Data
    {
        private DateTime _date;

        public Data()
        {
            _date = DateTime.Now;
        }

        public void OneWeekAhead()
        {
            _date.AddDays(7);
        }

        public void OneWeekBefore()
        {
            _date.AddDays(-7);
        }

        public void Pokaz()
        {
            Console.WriteLine(_date.ToString());
        }
    }
}
