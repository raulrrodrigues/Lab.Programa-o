
class Livro
{
    public string titulo;
    public string autor;

    public int paginas;

    public int ano; 

    public void ExibirInfo()
    {
        Console.WriteLine($"titulo: {titulo}, auto: {autor}, paginas: {paginas}, ano: {ano}");
    }
    
    public bool VerificarTrezentos()
    {
        if (paginas > 300)
        {
            return true;
        }else{
            return false;
        }
    }
}