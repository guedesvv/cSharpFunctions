
string mensagemInicial = "Funções em C#";

Dictionary<string, List<int>> listaCarros = new Dictionary<string, List<int>>(); 

//carro inicial e suas notas
listaCarros.Add("Gol", new List<int> { 10, 9, 10 });

void ExibirHeader()
{
    
    Console.WriteLine(mensagemInicial);
}

void Menu()
{
    ExibirHeader();
    Console.WriteLine("\nDigite 1 para registrar um novo carro");
    Console.WriteLine("Digite 2 para mostrar carros registrados");
    Console.WriteLine("Digite 3 para avaliar o desempenho do carro");
    Console.WriteLine("Digite 4 para exibir a a média do desempenho dos carros");
    Console.WriteLine("Digite 5 para sair");

    Console.Write("\nEscolha uma alternativa: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarCarro();
            break;
        case 2:
            MostrarCarros();
            break;
        case 3:
            AvaliarCarros();
            break;
        case 4:
            ExibirMedia();
            break;
        case 5:
            Console.WriteLine("Encerrando Aplicação");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarCarro()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registrando Carro");
    Console.Write("Digite o nome do novo carro: ");
    string carros = Console.ReadLine()!;
    listaCarros.Add(carros, new List<int>());
    Console.WriteLine($"O carro {carros} foi registrado");
    Thread.Sleep(3200);
    Console.Clear();
    Menu();
}

void MostrarCarros()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo os carros da aplicação");

    foreach (string carros in listaCarros.Keys)
    {
        Console.WriteLine($"Carros: {carros}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar");
    Console.ReadKey();
    Console.Clear();
    Menu();

}

void ExibirTituloDaOpcao(string titulo)
{
    int qntLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qntLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarCarros()
{

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar desempenho do carro");
    Console.Write("Digite o nome do carro que deseja avaliar: ");
    string nomeCarro = Console.ReadLine()!;
    if (listaCarros.ContainsKey(nomeCarro))
    {
        Console.Write($"Qual a nota para o carro {nomeCarro}: ");
        int nota = int.Parse(Console.ReadLine()!);
        listaCarros[nomeCarro].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para o carro {nomeCarro}");
        Thread.Sleep(2000);
        Console.Clear();
        Menu();
    }
    else
    {
        Console.WriteLine($"\nO carro {nomeCarro} não está registrado");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }

}

void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média de desempenho do carro");
    Console.Write("Digite o nome do carro que deseja exibir a média: ");
    string nomeCarro = Console.ReadLine()!;
    if (listaCarros.ContainsKey(nomeCarro))
    {
        List<int> notasCarro = listaCarros[nomeCarro];
        Console.WriteLine($"\nA média do carro {nomeCarro} é {notasCarro.Average()}.");
        Console.WriteLine("Digite uma tecla para votar ao menu");
        Console.ReadKey();
        Console.Clear();
        Menu();

    }
    else
    {
        Console.WriteLine($"\nO Carro {nomeCarro} não foi encontrado!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
}

Menu();