
//Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
//incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
//impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.



string[] valores = Console.ReadLine().Split(' ');
int x = int.Parse(valores[0]);
int y = int.Parse(valores[1]);

while (x != 0 && y != 0) {
    if (x > 0 && y > 0) {
        Console.WriteLine("primeiro");
    } 
    else if (x < 0 && y > 0) {
        Console.WriteLine("segundo");
    } 
    else if (x < 0 && y < 0) {
        Console.WriteLine("terceiro");
    } 
    else {
        Console.WriteLine("quarto");
    }
    valores = Console.ReadLine().Split(' ');
    x = int.Parse(valores[0]);
    y = int.Parse(valores[1]);
}