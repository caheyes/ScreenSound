//Variables
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
//List<string> listaDasBandas = new List<string> {"U2", "The Beatles", "Calypso"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());
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
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
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
    ExibirTituloDaOpcao("Registro de bandas");

    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    //listaDasBandas.Add(nomeDaBanda); //adicionar a banda na lista de bandas
   bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000); //faz ter um timout de 2000 segundos
    Console.Clear();
    ExibirOpcoesDoMenu();
}
;

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    foreach (string banda in bandasRegistradas.Keys) {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey(); //Ao cliclar qualquer tecla
    Console.Clear();

    ExibirOpcoesDoMenu();
}
;

void AvaliarUmaBanda()
{
    //digite qual a banda deseja avaliar

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    //contains serve para ver se contem aquele nome no array
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000); //para esperar alhuns segundos
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu");
        Console.ReadKey(); //Qualquer tecla
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}
;

void ExibirTituloDaOpcao(string titulo) {
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*'); // criando um string vazia que criará a linha de asteriscos
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");

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
