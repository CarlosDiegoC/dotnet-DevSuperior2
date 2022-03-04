using System;

namespace Exercicio4
{
    public class ContaBancaria
    {
        private string _titular;        
        public int Numero { get; private set; }
        private double Saldo { get; set; }

        public ContaBancaria() 
        { 
        }
        
        public ContaBancaria(string titular, int numero)
        {
            _titular = titular;
            Numero = numero;
        }

        public ContaBancaria(string titular, int numero, double depositoInicial) : this(titular, numero)
        {
            Deposito(depositoInicial);
        }

        public string Titular 
        { 
            get { return _titular; }
            
            set { if (value != null && value.Length > 5) 
                {
                    _titular = value;
                } 
            }
        }
        
        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.0;
        }

        public void ConsultarSaldo()
        {            
            Console.WriteLine ($"O saldo da conta é: {Saldo:C2}"); 
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Número da Conta: " + this.Numero + Environment.NewLine;
            retorno += "Titular da Conta: " + this.Titular + Environment.NewLine;
            retorno += "Saldo da Conta: R$" + this.Saldo.ToString("F2") + Environment.NewLine;               
            return retorno;
        }
    }
}
