using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo7.Services
{
    internal class BrazilTaxService
    {       
        public double Tax(double amount)
        {
            if (amount >= 100)
            {
                return amount * 0.15;
            }
            
            else return amount * 0.20;
        }

    }
}
