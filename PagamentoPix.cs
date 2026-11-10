namespace Heranca
{
    public class PagamentoPix : IPagamento
    {
        public void Pagar(decimal valor)
        {
            // throw new NotImplementedException(); retornar erro
            Console.WriteLine($"Pagamento via PIX: {valor:C}");
        }
    }
}