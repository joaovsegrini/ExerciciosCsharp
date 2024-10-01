Console.WriteLine("Digite a senha: ");
double senha = double.Parse(Console.ReadLine());

while  (senha != 2002) {
    Console.WriteLine("Senha Invalida");
    Console.WriteLine("Digite uma nova senha: ");
    senha = double.Parse(Console.ReadLine());
}

Console.WriteLine("Acesso Permitido");