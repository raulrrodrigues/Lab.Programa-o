int x; 

Pessoa p1 = new Pessoa();
p1.nome = "Lucas";
p1.idade = 31;
p1.sexo = "Masculino";
p1.MostrarInformacoes();

Console.WriteLine($"Nome: {p1.nome}, Idade: {p1.idade}, Sexo: {p1.sexo} ");

Pessoa p2 = new Pessoa();
p2.nome = "Joana";
p2.idade = 31;
p2.sexo = "feminino";
p2.MostrarInformacoes();

Console.WriteLine($"Nome: {p2.nome}, Idade: {p2.idade}, Sexo: {p2.sexo}");