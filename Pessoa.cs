class Pessoa
{
    public string nome;
    public int idade;
    public string sexo;

    void Comer()
    {
        Console.WriteLine($"{nome} comendo.");
    }
    public void MostrarInformacoes()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Sexo: " + sexo);
    }
}