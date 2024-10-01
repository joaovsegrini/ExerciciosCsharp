/* Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel". */

using System.Globalization;int N = int.Parse(Console.ReadLine());for (int i = 0; i < N; i++) {
    string[] line = Console.ReadLine().Split(' ');
    int x = int.Parse(line[0]);
    int y = int.Parse(line[1]);

    if (y == 0) {
        Console.WriteLine("divisão impossivel");
    }
    else {
        double divisao = (double)x / y;
        Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
    }
}