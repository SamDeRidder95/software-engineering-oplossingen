using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class DiceModel
    {
        protected int _value;
        protected Boolean _isFixed;

        public DiceModel()
        {
            this._value = 0;
            this._isFixed = false;
        }

        public int value {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }

    }
}
