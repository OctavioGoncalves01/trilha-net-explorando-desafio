namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    //Na clase existem 3 construtores 
    public Pessoa() { }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    //Na classe tem 3 parametros, sendo 2 dele usaveis pelo programador
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}