using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class ShoppingManager
    {

        private Dictionary<string, int> _basket = new Dictionary<string, int>();

        public bool Add(string product, int price)
        {
            _basket.Add("Banana", 4);

            if (!_basket.ContainsKey(product))
            {
                _basket.Add(product, price);
                return true;
            }
            else return false;

        }


        public int Total()
        { 
            int totalCost = 0;

            foreach (var product in _basket)
            {
               totalCost  += product.Value;
            }

            return totalCost;
           
        }
        
    }
}
