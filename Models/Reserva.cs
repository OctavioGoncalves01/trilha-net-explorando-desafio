namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        //Quando instanciamos essa classo podemos passar os dias de reserva ou não
        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        //Metodo para poder cadastrar uma lista de hospedes
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido

            bool sucesso =  hospedes.Count <= Suite.Capacidade ; 
            if (sucesso)
            {
                Hospedes = hospedes;
                
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception("Quantidade de Pessoas maior que a capacidade maxima do quarto");
                
            }
        }

        //Metodo usado para cadastrar uma suite
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        //Metodo usado para obter uma quantidade de hospedes de acordo com a lista
        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            int quantidadeHospedes = Hospedes.Count;
            return quantidadeHospedes;
        }

        //Usado para calcular o valor total da hospedagem, 
        //se a quantidade de dias forem maior ou igual a 10, terá um desconto de 10%
        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            
            if (DiasReservados >= 10 )
            {
                valor -=  valor * 10 /100;
            }

            return valor;
        }
    }
}