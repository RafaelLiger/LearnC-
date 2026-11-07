try
{
    int idade = -5;

    if (idade < 0)
    {
        throw new ArgumentException("A idade não pode ser negativa!");
    }

    Console.WriteLine(idade);
}
catch (ArgumentException erro)
{
    Console.WriteLine($"Erro: {erro.Message}");
}

Console.WriteLine("Programa continua executando!");