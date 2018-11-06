using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomePokerGameSln
{
    static class CardBack
    {
        public enum BackType
        {
            HALLOWEEN,
            NINJA,
            WALUIGI,
            GEORGE,
            CANADA,
        }

        private static BackType _kind = BackType.HALLOWEEN;

        public static BackType Kind
        {
            get { return _kind; }
            set { _kind = value; }
        }
    }
}
