Calculadora QualquerCoisa = new Calculadora();

Console.WriteLine("Digite o numero x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o numero y: ");
double y = Convert.ToDouble(Console.ReadLine());

double resultado = QualquerCoisa.Soma(x,y);
Console.WriteLine($"O resultado da soma de {x} e {y} é = {QualquerCoisa.Soma(x,y)}");
Console.WriteLine($"O resultado da subtração de {x} e {y} é = {QualquerCoisa.Subtracao(x,y)}");
Console.WriteLine($"O resultado da divisão de {x} e {y} é = {QualquerCoisa.Divisao(x,y)}");
Console.WriteLine($"O resultado da multiplicação de {x} e {y} é = {QualquerCoisa.Multiplicacao(x,y)}");

