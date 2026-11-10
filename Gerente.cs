namespace Heranca
{
    public class Gerente : Funcionario
    {
        public int Codigo { get; set; }

        public Gerente()
        {
            
        }
        public Gerente(string nome, int codigo, decimal salario) : base(nome, salario) 
        {
            Codigo = codigo;
        }

        public override decimal CalcularBonus()
        {
            return 1000m;
        }

        public void GerenciarEquipe()
        {
            Console.WriteLine("Gestor está gerenciando a equipe.");
        }

        public void ExibirSalario()
        {
            Console.WriteLine($"O salario do funcionario é {Salario:C}");
        }

        public void DefinirSalario(decimal valor)
        {
            Salario = valor;
        }

        public override void Trabalhar()
        {
            Console.WriteLine("Gerente está trabalhando.");
        }
    }
}