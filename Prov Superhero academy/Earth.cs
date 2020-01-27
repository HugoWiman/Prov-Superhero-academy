using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_Superhero_academy
{
    class Earth:Basehealth
    {
        private int Speed = 50;
        private int Defense = 100;
        private int Dmg = 30;
      
      
        public int RDefense()
        {
            return Defense;


        }
        public int RDmg()
        {
            return Dmg;

        }
    }// Det här är en specifik klas för Earth och här retuneras värdena. Detta gör även att det inte går att ändra på de värden som finns.
}
