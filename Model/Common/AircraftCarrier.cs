using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Common
{
    public class AircraftCarrier : Boat, IAircraftCarrier
    {
        public AircraftCarrier()
        {
            Length = 5;
        }
    }
}
