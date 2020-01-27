using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_Superhero_academy
{
    class Fire:Basehealth
    {
        public int Speed = 17;
        private int Defense = 50;
        private int Dmg = 100;
        // private gör att de bara komms åt här inne.
        public int RSpeed()
        {
            return Speed;
        }

        public int RDefense()
        {
            return Defense;


        }
        public int RDmg()
        {
            return Dmg;

        }


    }
}// Det här är en specifik klas för Earth och här retuneras värdena. Detta gör även att det inte går att ändra på de värden som finns.
}
