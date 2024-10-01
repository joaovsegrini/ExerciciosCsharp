/* Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo) */

int N = int.Parse(Console.ReadLine());

int cont_in = 0;
int cont_out = 0;

for (int i = 0; i < N; i++) {
    int x = int.Parse(Console.ReadLine());
    if (x >= 10 && x  <= 20) {
        cont_in++;
    }
    else { cont_out++; };
}
Console.WriteLine(cont_in + " in");
Console.WriteLine(cont_out + " out");
