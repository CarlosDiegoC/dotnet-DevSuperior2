using Exercicio10.Entites;

namespace Exercicio10.Services
{
    internal class InstallmentService
    {
        public int InstallmentsQuantity { get; set; }

        public IPaymentProvider _paymentProvider;

        public InstallmentService(int installmentsQuantity, IPaymentProvider paymentProvider)
        {
            InstallmentsQuantity = installmentsQuantity;
            _paymentProvider = paymentProvider;
        }

        public void ProcessInstallments(Contract contract)
        {
            for (int i = 1; i <= InstallmentsQuantity; i++)
            {
                DateTime dueDate = contract.ContractDate.AddDays(30 * i);
                
                double basicInstallmentValue = (contract.ContractValue / InstallmentsQuantity);
                
                double installmentUpdated = basicInstallmentValue + _paymentProvider.InterestRate(basicInstallmentValue)*i;
                double installmentValue = installmentUpdated + _paymentProvider.PaymentFee(installmentUpdated);
                
                Installment installment = new Installment(dueDate, installmentValue);
                
                contract.Installments.Add(installment);
            }

        }
    }
}
