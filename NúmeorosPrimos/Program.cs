// See https://aka.ms/new-console-template for more information

int num, verif=0;

Console.WriteLine("Digite um número para ver quais números primos existem até esse:");
num = int.Parse(Console.ReadLine());

Console.WriteLine($"Os números primos entre 1 e {num} são:");

for(int  i = 1; i <= num; i++)
{
    verif = 0;
    for(int c = 1; c <= i; c++)
    {

        if(i%c == 0)
        {
            verif += 1;
        }

    }

    if( verif == 2)
    {
        Console.WriteLine(i);
    }
}
