string[] valores = Console.ReadLine().Split(' ');
int A = int.Parse(valores[0]);
int B = int.Parse(valores[1]);

if (A % B == 0 || B % A == 0) {
    Console.WriteLine("São Multiplos");
}
else {
    Console.WriteLine("Não são multiplos");
}


