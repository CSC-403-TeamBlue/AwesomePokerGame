using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomePokerGameSln
{
    static class Stars
    {
        private static int _amount = 25;

        public static int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
    }
}
