using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10.Services
{
    internal interface IPaymentProvider
    {
        public double InterestRate(double amount);
        public double PaymentFee(double amount);
    }
}
