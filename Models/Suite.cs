namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        //Exixtem 2 construtores
        public Suite() { }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        //Contem 3 parametros do tipo Get/Set
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}