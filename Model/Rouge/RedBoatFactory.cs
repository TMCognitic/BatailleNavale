using Model.Common;
using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Rouge
{
    public class RedBoatFactory : BoatFactory
    {
        public override IDestroyer CreateDestroyer()
        {
            return new RedDestroyer();
        }

        public override ICruiser CreateCruiser()
        {
            return new RedCruiser();
        }

        public override IAircraftCarrier CreateAircraftCarrier()
        {
            return new RedAircraftCarrier();
        }

        public override ISubMarine CreateSubMarine()
        {
            return new RedSubMarine();
        }
    }
}
