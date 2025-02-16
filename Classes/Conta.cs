using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransferBank
{
    public class Conta
    {
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private TipoConta TipoConta { get; set; }

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }
        
        //O método sacar retorna um valor booleano a fim de verificar se o valor esta ou não dentro do limite possivel
        public bool Sacar (double valorSaque)
        {
            // Valida se o saldo é suficiente
            if(this.Saldo - valorSaque < (this.Credito * -1))
            {
                System.Console.WriteLine("Saldo Insulficiente");
                return false;
            }

            this.Saldo -= valorSaque;

            System.Console.WriteLine($"O saldo atual da conta de {this.Nome} é R${this.Saldo}.");

            return true;
        }

        public void Depositar (double valorDeposito){

            this.Saldo += valorDeposito;

            System.Console.WriteLine($"O saldo atual da conta de {this.Nome} é R${this.Saldo}.");
        }

        public void Transferir(double valorATranferir, Conta contaDestino){
            
            if(this.Sacar(valorATranferir)){
                contaDestino.Depositar(valorATranferir);
            }

        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Crédito " + this.Credito + " | ";
            return retorno;
        }
    }
}