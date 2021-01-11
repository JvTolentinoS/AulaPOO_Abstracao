using System;
using AulaPOO_Abstracao.classes;

namespace AulaPOO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Digite o Valor da compra:");
            float valorDaCompra = float.Parse(Console.ReadLine());

            Console.WriteLine($"Selecione o tipo de pagamento");
            Console.WriteLine($"1 - Boleto");
            Console.WriteLine($"2 - Cartão");
            int opcao = int.Parse(Console.ReadLine());
            
            switch(opcao)
            {
                case 1:
                //boleto
                Boleto boleto = new Boleto();
                boleto.Valor = valorDaCompra;
                boleto.Registrar(boleto.Valor, boleto.Data, boleto.codigoDeBarras);
                break;

                case 2:
                //cartao
                Console.WriteLine($"Selecione o tipo de pagamento");
                Console.WriteLine($"1 - Crédito");
                Console.WriteLine($"2 - Débito");
                int tipoCartao = int.Parse(Console.ReadLine());
                    switch (tipoCartao)
                    {
                        case 1:
                            Credito credito = new Credito();
                            credito.numero = "";
                            credito.bandeira = "";
                            credito.cvv = "";
                            credito.titular = "";
                            credito.PagarCredito(valorDaCompra);
                            break;
                        case 2:
                            Debito debito = new Debito();
                            debito.numero ="";
                            debito.bandeira = "";
                            debito.cvv = "";
                            debito.titular = "";
                            debito.PagarDebito(valorDaCompra);
                            break;
                        default:
                            break;
                    }
                break;
                    
                
                
            }
            
            

        }
    }
}
