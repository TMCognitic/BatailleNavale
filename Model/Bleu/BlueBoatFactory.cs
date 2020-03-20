using Model.Common;
using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Bleu
{
    public class BlueBoatFactory : BoatFactory
    {
        public override IDestroyer CreateDestroyer()
        {
            return new BlueDestroyer();
        }

        public override ICruiser CreateCruiser()
        {
            return new BlueCruiser();
        }

        public override IAircraftCarrier CreateAircraftCarrier()
        {
            return new BlueAircraftCarrier();
        }

        public override ISubMarine CreateSubMarine()
        {
            return new BlueSubMarine();
        }
    }
}
