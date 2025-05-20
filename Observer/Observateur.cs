using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWorkshop.Observer
{
    public interface Observateur
    {
        public void actualise(Véhicule véhicule);
    }
}
