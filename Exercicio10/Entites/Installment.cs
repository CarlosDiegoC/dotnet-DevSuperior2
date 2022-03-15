using System.Globalization;
namespace Exercicio10.Entites
{
    internal class Installment
    {
        public DateTime InstallmentDate { get; set; }
        public double InstallmentValue{ get; set; }
        

        public Installment(DateTime dueDate, double installmentValue)
        {
            InstallmentDate = dueDate;
            InstallmentValue = installmentValue;
        }

        public override string ToString()
        {
            return InstallmentDate.ToString("dd/MM/yyyy") 
                + " - $" 
                + InstallmentValue.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
