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
            // Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido

            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
               throw new InvalidOperationException("Capacidade da suíte é menor que o número de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes (propriedade Hospedes)
            if (Hospedes != null)
            {
                return Hospedes.Count;
            }
            else
            {
                return 0;
            }
        }

        public decimal CalcularValorDiaria()
        {
            // Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valorDiaria = Suite.ValorDiaria;
            decimal valor = DiasReservados * valorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados >= 10)
            {
                valor = valor - (valor * 0.1m);
            }

            return valor;
        }
    }
}