string? letra = Console.ReadLine();

    while((string.IsNullOrEmpty(letra)))
    {
        if ((string.IsNullOrEmpty(letra)))
        {
            Console.WriteLine("Insira uma letra: ");
            letra = Console.ReadLine();
        }
    }

    switch (letra.ToLower())
    {
        case "a":
        case "e":
        case "i":
        case "o":
        case "u":

        Console.WriteLine("A letra inserida, é uma vogal");
        break;

        case null:
        Console.WriteLine("Insira uma letra: ");
        break;

        default : Console.WriteLine("A letra inserida, não é uma vogal");
        break;
    }
