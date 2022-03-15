using Exercicio9.Entities;

namespace Exercicio9.Entities
{
    class Company : Payer
    {
        public int NumberOfEmployees { get; set; }

        public Company (string name, double anualIncome, int numberOfEmployees) :base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double TaxesPaid()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
