/*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que 
serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora 
do intervalo, mostrando essas informações.

A primeira linha da entrada contém um valor inteiro N, que indica o número de casos de teste.
Cada caso de teste a seguir é um valor inteiro X.*/

int x, n, foradointervalo, dentrodointervalo;

n=int.Parse(Console.ReadLine());
foradointervalo = 0;
dentrodointervalo=0;

for (int i=0; i<n; i++)
{
    x = int.Parse(Console.ReadLine());

    if (x>=10 && x <= 20)
    {
        dentrodointervalo++;
    }
    else
    {
        foradointervalo++;
    }
}

Console.WriteLine($"{dentrodointervalo} in");
Console.WriteLine($"{foradointervalo} out");