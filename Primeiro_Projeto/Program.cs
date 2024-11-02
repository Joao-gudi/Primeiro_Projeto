// Define uma função para exibir a mensagem de boas-vindas
void ExibirMensagemDeBoasVindas()
{
    // Cria uma string com a mensagem de boas-vindas
    string mensagemBoasVindas = "Boas Vindas ao Screean sound";

    // Exibe uma arte ASCII e a mensagem de boas-vindas
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗░█████╗░███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝██╔══██╗████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░███████║██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██╔══██║██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░░██║██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    // Exibe a mensagem de boas-vindas
    Console.WriteLine(mensagemBoasVindas);
}

// Define uma função para exibir as opções do menu
void ExibirFuncoesDoMenu()
{
    // Chama a função que exibe a mensagem de boas-vindas
    ExibirMensagemDeBoasVindas();

    // Exibe as opções do menu para o usuário
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    // Solicita que o usuário digite sua opção
    Console.Write("\nDigite a sua opção: ");
    // Lê a opção escolhida pelo usuário e garante que não seja nula
    string opcaoEscolhida = Console.ReadLine()!;
    // Converte a opção escolhida para um número inteiro
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    // Verifica se a opção escolhida é válida e executa a ação correspondente
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            registrarBanda(); // Chama a função para registrar uma banda
            break;
        case 2:
            mostrarAsBandaRegistradas(); // Chama a função para mostrar todas as bandas registradas
            break;
        case 3:
            avaliarUmaBanda();
            break;
        case 4:
            mediaDeUmaBanda(); 
            break;
        case -1:
            Console.WriteLine("Tchau Tchau :) "); // Mensagem de despedida
            break;
        default:
            Console.WriteLine("Opção Invalida"); // Mensagem para opção inválida
            break;
    }
}

// Cria uma lista para armazenar os nomes das bandas
//List<string> listaBandas = new List<string> { "U2", "The Beatles", "Calypso" };


Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());


// Define a função para registrar uma banda
void registrarBanda()
{
    // Exibe uma mensagem de registro de bandas
    Console.WriteLine("Registro de bandas");
    // Solicita ao usuário o nome da banda que deseja registrar
    Console.Write("Digite o nome da banda que deseja registrar: ");
    // Lê o nome da banda e garante que não seja nulo
    string nomeDaBanda = Console.ReadLine()!;
    // Adiciona o nome da banda à lista
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    // Exibe uma mensagem de confirmação do registro
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso ");
    // Pausa a execução por 2 segundos
    Thread.Sleep(2000);
    // Limpa o console
    Console.Clear();
    // Chama a função para exibir as opções do menu
    ExibirFuncoesDoMenu();
}

// Define a função para mostrar todas as bandas registradas
void mostrarAsBandaRegistradas()
{
    // Limpa o console
    Console.Clear();
    // Exibe um cabeçalho
    exibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");
    // Itera sobre a lista de bandas e exibe cada uma
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    // Solicita que o usuário pressione uma tecla para voltar ao menu principal
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    // Limpa o console
    Console.Clear();
    // Chama a função para exibir as opções do menu
    ExibirFuncoesDoMenu();
}


void exibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteristicos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteristicos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristicos + "\n");
}




void avaliarUmaBanda()
{
    Console.Clear();
    exibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear() ;
        ExibirFuncoesDoMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirFuncoesDoMenu();
    }
}

// Chama a função para exibir a mensagem de boas-vindas
//ExibirMensagemDeBoasVindas();
// Chama a função para exibir as opções do menu



void mediaDeUmaBanda()
{
    Console.Clear();
    exibirTituloDaOpcao("Média da banda");
    Console.Write("Digite o nome de uma banda que gostaria de ver a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notas = bandasRegistradas[nomeDaBanda];
        if (notas.Count > 0)
        {
            double media = notas.Average();
            Console.WriteLine($"A média das notas da banda {nomeDaBanda} é {media:F1}");
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} não possui avaliações.");
        }
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirFuncoesDoMenu();
}
ExibirFuncoesDoMenu(); 
