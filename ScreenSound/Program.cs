//Variables
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
List<string> listaDasBandas = new List<string>();

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
};

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua Opção: "); 
    string opcaoEscolhida = Console.ReadLine()!; // Dessa forma não pula linha igual o readline

    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida); //converte em number

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        case 3:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        case 4:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        case -1:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
    ;

    Console.WriteLine("Tchau tchau :)");
};

void RegistrarBanda() {
    Console.Clear(); //Limpa o console
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o none da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda); //adicionar a banda na lista de bandas
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000); //faz ter um timout de 2000 segundos
    Console.Clear();
    ExibirOpcoesDoMenu();
}
;

void Desafio()
{
    Console.Write("\nDigite a sua Nota: ");
    string notaMedia = Console.ReadLine()!;

    int nota = int.Parse(notaMedia);

    if (nota >= 5)
    {
        Console.WriteLine("Nota suficiente para aprovação");
    } else
    {
        Console.WriteLine("Nota não suficiente, reprovado");
    };
}
;

void Desafio2() {
    //int numeroSecreto = 42; caso eu queresse definir o numero

    //Aqui o número sempre será aleatorio
    Random aleatorio = new Random();
    int numeroSecreto = aleatorio.Next(1, 101);

    do
    {
        Console.Write("Digite um número entre 1 e 100: ");
        int chute = int.Parse(Console.ReadLine());

        if (chute == numeroSecreto)
        {
            Console.WriteLine("O jogo acabou. Você acertou o número secreto!");
            break;
        }
        else if (chute < numeroSecreto)
        {
            Console.WriteLine("O número é maior.");
        }
        else
        {
            Console.WriteLine("O número é menor.");
        }

    } while (true);
};

ExibirOpcoesDoMenu();
//Desafio();
//Desafio2();