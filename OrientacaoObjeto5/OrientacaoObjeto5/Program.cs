using OrientacaoObjeto5;
using System.Globalization;

Aluno aluno = new Aluno();


Console.WriteLine("Nome do aluno: ");
aluno.Nome = Console.ReadLine();
Console.WriteLine("Digite as três notas do aluno: ");
aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



Console.WriteLine("NOTA FINAL = "
    + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

if (aluno.Aprovado())
{
    Console.WriteLine("APROVADO");
}
else
{
    Console.WriteLine("REPROVADO");
    Console.WriteLine("FALTARAM "
        + aluno.NomeRestante().ToString("F2", CultureInfo.InvariantCulture)
        + " PONTOS");
}