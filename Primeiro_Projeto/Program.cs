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

    // Verifica se a opção escolhida é a digitada
switch(opcaoEscolhidaNumerica)
    {
        case 1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica); // Caso o usuario escolha a opção executa a mensagem + escolha
            break; 
        case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica); // Caso o usuario escolha a opção executa a mensagem + escolha
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica); // Caso o usuario escolha a opção executa a mensagem + escolha
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica); // Caso o usuario escolha a opção executa a mensagem + escolha
            break;
        case -1: Console.WriteLine("Tchau Tchau :) "); // Caso o usuario escolha a opção executa a mensagem + escolha
            break;
        default: Console.WriteLine("Opção Invalida");
            break;
    }
}

// Chama a função para exibir a mensagem de boas-vindas
ExibirMensagemDeBoasVindas();
// Chama a função para exibir as opções do menu
ExibirFuncoesDoMenu();

