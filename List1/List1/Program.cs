using System.Globalization;
using System.Collections.Generic;
using List1;

Console.Write("Quantos funcionários serão registrados? ");
int n = int.Parse(Console.ReadLine());

List<Funcionario> list = new List<Funcionario>();

for (int i = 1; i<= n; i++) {
    Console.WriteLine("Funcionário #" + i + ":");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Sálario: ");
    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    list.Add(new Funcionario(id, nome, salario));
    Console.WriteLine();
}

Console.Write("Entre com o id do funcionário que irá receber aumento: ");
int procurarId = int.Parse(Console.ReadLine());

Funcionario func = list.Find(x => x.Id == procurarId);
if(func != null) {
    Console.Write("Entre com a porcentagem: ");
    double porcentagem = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
    func.AumentoSalario(porcentagem);
}
else {
    Console.WriteLine("Esse id não existe!");
}

Console.WriteLine();
Console.WriteLine("Lista atualizada de funcionários:");
foreach (Funcionario obj in list) {
    Console.WriteLine(obj);
}
