using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Common
{
    public abstract class BoatFactory : IBoatFactory
    {
        public abstract IDestroyer CreateDestroyer();
        public abstract ICruiser CreateCruiser();
        public abstract IAircraftCarrier CreateAircraftCarrier();
        public abstract ISubMarine CreateSubMarine();
    }
}
