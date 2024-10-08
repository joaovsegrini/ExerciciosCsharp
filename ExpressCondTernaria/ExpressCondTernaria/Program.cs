using System.Globalization;

/*
var preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double desconto;
if (preco < 20.0) {
    desconto = preco * 0.1;
} else {
    d 
*/
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

Console.WriteLine(desconto);