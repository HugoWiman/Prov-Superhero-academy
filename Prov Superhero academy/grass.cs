using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_Superhero_academy
{
    class grass:Basehealth
    {
        private int speed = 10;
        private int Defense = 60;
        private int Dmg = 60;
        public int RSpeed()
        {
            return speed;


        }

        public int RDefense()
        {
            return Defense;

            // Här retuneras De
        }
        public int RDmg()
        {
            return Dmg;

        }

    }
}
