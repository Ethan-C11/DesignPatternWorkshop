using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWorkshop.Observer
{
    public class VueVéhicule : Observateur
    {
        public void actualise(Véhicule véhicule)
        {
            redessine(véhicule);
        }

        public void redessine(Véhicule véhicule)
        {
            Console.WriteLine($"Description : {véhicule.getDescription()}\nPrix : {véhicule.getPrix()}");
        }
    }
}
