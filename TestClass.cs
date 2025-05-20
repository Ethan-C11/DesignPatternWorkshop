using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternWorkshop.Observer;

namespace DesignPatternWorkshop
{
    public static class TestClass
    {
        public static void TestObserver()
        {
            Véhicule voiture = new Véhicule();
            VueVéhicule vueVéhicule = new VueVéhicule();
            voiture.ajoute(vueVéhicule);

            voiture.setDescription("Première description");
            voiture.setPrix(12000);
        }
    }
}
