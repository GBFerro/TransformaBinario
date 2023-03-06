int input;

int[] binario =  new int[8];

int Imenu()
{
    Console.WriteLine("Digite um valor: ");
    return int.Parse(Console.ReadLine());  
}

int converteBinario(int input)
{
    int a;

    a = input % 2;
    return a;
}

input = Imenu();

for (int i = 0; i <= 7; i++)
{
    binario[i] = converteBinario(input);
    input = input / 2;
}

for (int i = 7; i >= 0; i--)
{
    Console.Write(binario[i]);

}