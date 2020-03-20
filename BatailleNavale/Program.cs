using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Bleu;
using Model.Interfaces;
using Model.Rouge;

namespace BatailleNavale
{
    class Program
    {
        static void Main(string[] args)
        {
            IBoatFactory redFactory = new RedBoatFactory();
            IBoatFactory blueFactory = new BlueBoatFactory();

            Console.WriteLine(redFactory.CreateAircraftCarrier());
            Console.WriteLine(blueFactory.CreateAircraftCarrier());

            Console.ReadKey();

        }
    }
}
