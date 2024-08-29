Livro l1 = new Livro();
l1.titulo = "Clean Code";
l1.autor = "Robert C. Martin";
l1.ano = 2004;
l1.paginas = 361;

l1.ExibirInfo();
bool v1 = l1.VerificarTrezentos();
Console.WriteLine($"Esse livro tem mais de 300 paginas? {v1}");


