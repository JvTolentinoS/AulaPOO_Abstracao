using System;
namespace AulaPOO_Abstracao.classes
{
    public class Boleto : Pagamento
    {
        public string codigoDeBarras = "1111111.22222222222.3333333";
        private DateTime vencimento;
        public void Registrar(float valor, DateTime dataEmissao, string codigoDeBarras){
            Console.WriteLine($"O valor da compra fica m R${valor*0.88f}");
            Console.WriteLine($"A data de emissão {dataEmissao}");
            Console.WriteLine($"Data de Vencimento = {dataEmissao.AddDays(10)}");
            Console.WriteLine($"Código de Barras = {codigoDeBarras}");
            
        }

    }
}