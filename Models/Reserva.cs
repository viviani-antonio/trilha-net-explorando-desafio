namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            if (hospedes == null)
            {
                throw new ArgumentNullException(nameof(hospedes), "A lista de hóspedes não pode ser nula");
            }
            if (Suite.Capacidade < hospedes.Count)
            {
                throw new InvalidOperationException($"A capacidade da suíte {Suite.Capacidade} é menor que o número de hóspedes recebedo {hospedes.Count}. ");
            }
            Hospedes = hospedes;
            // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido              
        }
        
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes( )
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            
            decimal valor = 0;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                valor = (DiasReservados * Suite.ValorDiaria) - (valor * 0.10m);
                decimal desconto = valor - (valor * 0.10M);
                valor = desconto;
            }
            else
            {
                valor = DiasReservados * Suite.ValorDiaria;
            }

                return valor;
        }
    }
}