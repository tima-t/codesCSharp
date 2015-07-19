using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef
{
    class Chef
    {
      

        private Potato GetPotato()
        {
            //...
        }

        private Carrot GetCarrot()
        {
            //...
        }
        private Peel(Vegetable someVegetable)
        {

        }
        private void Cut(Vegetable someVegetable)
        {
            //...
        }

        private Bowl GetBowl()
        {
            //... 
        }
        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Peel(potato);
            Peel(carrot);
            Cut(potato);
            Cut(carrot);
            Bowl bowl;
            bowl = GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);
        }
      
    }
}
