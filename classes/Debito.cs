using System;
namespace AulaPOO_Abstracao.classes

{
    public class Debito : Cartao
    {
        private float saldo = 600;

        public void PagarDebito(float valor){
            if(valor <= this.saldo){
               float total = this.valor - this.saldo;
            }else{
                Console.WriteLine($"Saldo insuficiente, faça por crédito!");
            }
        }   
        public void ExibirNota(string titular, float total){
            Console.WriteLine($"Titular {titular} - valor da compra = {total}");
        }             
    }
}