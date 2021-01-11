using System;
namespace AulaPOO_Abstracao.classes
{
    public class Credito : Cartao
    {
        private float limite = 3000;

        public void PagarCredito(float valor){
            if(valor <= this.limite){
                Console.WriteLine($"");
                int parcelas = int.Parse(Console.ReadLine());
                    do
                    {
                        Console.WriteLine($"Selecione a quantidade de parcelas de 1 a 12:");
                        parcelas = int.Parse(Console.ReadLine());
                    } while (parcelas > 12);

                    float juros;
                    if(parcelas <= 6){
                        juros = 0.05f;
                    }else{
                        juros = 0.08f;
                    }
                    float total = this.valor + (this.valor * juros);

                    ExibirNota(this.titular, total);
            }else{
                Console.WriteLine($"Saldo Insuficiente");
            }
        }

        public void ExibirNota(string titular, float total){
            Console.WriteLine($"Titular {titular} - valor da compra = {total}");
        }
    }
}