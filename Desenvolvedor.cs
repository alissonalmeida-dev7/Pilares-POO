namespace Heranca
{
    public class Desenvolvedor : Funcionario
    {
        public override decimal CalcularBonus()
        {
            return 500m;
        }

        public override void Trabalhar()
        {
            Console.WriteLine("Desenvolvedor está programando.");
        }
    }
}