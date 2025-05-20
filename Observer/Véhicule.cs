using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWorkshop.Observer
{
    public class Véhicule : Sujet
    {
        private string _description {  get; set; }
        private float _prix { get; set; }

        public string getDescription() => _description;
        public float getPrix() => _prix;

        public void setDescription(string desc)
        {
            _description = desc;
            notifie(this);
        }
        public void setPrix(float prix)
        { 
            _prix = prix;
            notifie(this);
        }

    }
}
