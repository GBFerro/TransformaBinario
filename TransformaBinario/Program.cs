int valor, resto;

int[] binario = new int[8];

string Imenu()
{
    Console.WriteLine("Digite um valor: ");
    return Console.ReadLine();
}

int j = 0;
int[] converteBinario(int input)
{
    if (input > 0)
    {
        resto = input % 2;
        binario[j] = resto;
        input /= 2;
        j++;
        return converteBinario(input);
    }
    return binario;
}

int retornaErro()
{
    string stringValor = Imenu();
    int num;
    if (!int.TryParse(stringValor, out num))
    {
        Console.WriteLine("Informe um número válido");
        return retornaErro();
    }
    else
    {
        if ((num > 255) || (num < 0))
        {
            Console.WriteLine("O valor extrapola o limite");
            return retornaErro();
        }

    }
    return num;
}

valor = retornaErro();
converteBinario(valor);

for (int i = (binario.Length - 1); i >= 0; i--)
{
    Console.Write(binario[i]);

}