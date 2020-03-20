using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Common
{
    public class Destroyer : Boat, IDestroyer
    {
        public Destroyer()
        {
            Length = 3;
        }
    }
}
