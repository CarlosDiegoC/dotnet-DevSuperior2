namespace Exercicio10.Entites
{
    internal class Contract
    {
        public int ContractNumer { get; set; }
        public DateTime ContractDate { get; set; }
        public double ContractValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int contractNumer, DateTime contractDate, double contractValue)
        {
            ContractNumer = contractNumer;
            ContractDate = contractDate;
            ContractValue = contractValue;
            Installments = new List<Installment>();
        }
    }
}
