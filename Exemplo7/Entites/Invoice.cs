using System.Globalization;
namespace Exemplo7.Entites
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment()
        {
            return BasicPayment + Tax;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "INVOICE:" + Environment.NewLine;
            retorno += "Basic payment: $" + BasicPayment.ToString("F2", CultureInfo.InvariantCulture) + Environment.NewLine;
            retorno += "Tax: $" + Tax.ToString("F2", CultureInfo.InvariantCulture) + Environment.NewLine;
            retorno += "Total payment: $" + TotalPayment().ToString("F2", CultureInfo.InvariantCulture);
            return retorno;
        }
    }
}
