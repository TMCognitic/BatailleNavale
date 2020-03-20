using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Common
{
    public class Boat : IBoat
    {
        private int _length;

        public int Length
        {
            get
            {
                return _length;
            }

            protected set
            {
                _length = value;
            }
        }
    }
}
