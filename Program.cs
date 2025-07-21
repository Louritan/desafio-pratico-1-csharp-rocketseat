/*
* 1. Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas
* vindas personalizada com o nome dele é exibida: Olá, Welisson! Seja muito bem-vindo!
*/

static void DesafioUm()
{
    string? nome = null;

    do
    {
        Console.WriteLine("Digite o seu nome:");
        nome = Console.ReadLine();
    } while (string.IsNullOrEmpty(nome));

    Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
}

/*
* 2. Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final
* exiba o nome completo.
*/

static void DesafioDois()
{
    string? nome = null;
    string? sobrenome = null;

    do
    {
        Console.WriteLine("Digite o seu nome:");
        nome = Console.ReadLine();
    } while (string.IsNullOrEmpty(nome));

    do
    {
        Console.WriteLine("Digite o seu sobrenome:");
        sobrenome = Console.ReadLine();
    } while (string.IsNullOrEmpty(sobrenome));

    var nomeCompleto = $"{nome} {sobrenome}";
    Console.WriteLine(nomeCompleto);
}

/*
* 3. Crie um programa com 2 valores do tipo double já declarados que retorne:
* - A soma entre esses dois números;
* - A subtração entre os dois números;
* - A multiplicação entre os dois números;
* - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
* - A média entre os dois números;
*/

static void DesafioTres()
{
    double? n1 = null;
    double? n2 = null;

    do
    {
        Console.WriteLine("Digite o primeiro número:");
        n1 = double.Parse(Console.ReadLine()!);
    } while (n1 == null);

    do
    {
        Console.WriteLine("Digite o segundo número:");
        n2 = double.Parse(Console.ReadLine()!);
    } while (n2 == null);

    var soma = n1 + n2;
    Console.WriteLine($"n1 + n2 = {soma}");

    var subtracao = n1 - n2;
    Console.WriteLine($"n1 - n2 = {subtracao}");

    var multiplicacao = n1 * n2;
    Console.WriteLine($"n1 * n2 = {multiplicacao}");

    if (n2 != 0.0)
    {
        var divisao = n1 / n2;
        Console.WriteLine($"n1 / n2 = {divisao}");
    }
    else
    {
        Console.WriteLine("Impossível dividir por zero!");
    }

    var media = (n1 + n2) / 2;
    Console.WriteLine($"Média = {media}");
}

/*
* 4. Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de
* caracteres que a palavra inserida tem.
*/

static void DesafioQuatro()
{
    string? palavras = null;

    do
    {
        Console.WriteLine("Digite uma ou mais palavras:");
        palavras = Console.ReadLine();
    } while (string.IsNullOrEmpty(palavras));

    uint quantidadeCaracteres = 0;

    foreach (var c in palavras)
    {
        if (c == ' ')
            continue;

        quantidadeCaracteres++;
    }

    Console.WriteLine($"Quantidade de caracteres das palavras: {quantidadeCaracteres}");
}

/*
* 5. Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa
* verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
* - A placa deve ter 7 caracteres alfanuméricos;
* - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
* - Os quatro últimos caracteres são números;
* Ao final, o programa deve exibir Verdadeiro se a placa for válida e Falso caso contrário.
*/

static void DesafioCinco()
{
    string? placa = null;

    do
    {
        Console.WriteLine("Digite a placa do veículo:");
        placa = Console.ReadLine();
    } while (string.IsNullOrEmpty(placa));

    if (placa.Length != 7)
    {
        Console.WriteLine("Placa inválida! A placa deve ter 7 caracteres.");
        return;
    }

    for (int i = 0; i < 3; i++)
    {
        if (!char.IsLetter(placa[i]))
        {
            Console.WriteLine("Placa inválida! Os primeiros 3 caracteres devem ser letras.");
            return;
        }
    }

    for (int i = 3; i < 7; i++)
    {
        if (!char.IsDigit(placa[i]))
        {
            Console.WriteLine("Placa inválida! Os 4 ultimos caracteres devem ser números.");
            return;
        }
    }

    Console.WriteLine("Placa válida!");
}

/*
* 6. Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
* - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos);
* - Apenas a data no formato "01/03/2024";
* - Apenas a hora no formato de 24 horas;
* - A data com o mês por extenso;
*/

static void DesafioSeis()
{
    var agora = DateTime.Now;

    string? formato = null;

    do
    {
        Console.WriteLine("Digite o formato desejado:");
        Console.WriteLine("[1] - Completo");
        Console.WriteLine("[2] - Apenas a data");
        Console.WriteLine("[3] - Apenas a hora");
        Console.WriteLine("[4] - A data com o mês por extenso");
        formato = Console.ReadLine();
    } while (string.IsNullOrEmpty(formato));

    switch (formato)
    {
        case "1":
            Console.WriteLine(agora.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss"));
            break;
        case "2":
            Console.WriteLine(agora.ToString("dd/MM/yyyy"));
            break;
        case "3":
            Console.WriteLine(agora.ToString("HH:mm:ss"));
            break;
        case "4":
            Console.WriteLine(agora.ToString("dd 'de' MMMM 'de' yyyy"));
            break;
        default:
            Console.WriteLine("Formato inválido!");
            break;
    }
}

static void Pause()
{
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
}

string? entrada = null;

do
{
    Console.Clear();
    Console.WriteLine("Digite o desafio desejado:");
    Console.WriteLine("[1] - Desafio 1");
    Console.WriteLine("[2] - Desafio 2");
    Console.WriteLine("[3] - Desafio 3");
    Console.WriteLine("[4] - Desafio 4");
    Console.WriteLine("[5] - Desafio 5");
    Console.WriteLine("[6] - Desafio 6");
    Console.WriteLine("[0] - Sair");
    entrada = Console.ReadLine();

    switch (entrada)
    {
        case "1":
            DesafioUm();
            Pause();
            break;
        case "2":
            DesafioDois();
            Pause();
            break;
        case "3":
            DesafioTres();
            Pause();
            break;
        case "4":
            DesafioQuatro();
            Pause();
            break;
        case "5":
            DesafioCinco();
            Pause();
            break;
        case "6":
            DesafioSeis();
            Pause();
            break;
        case "0":
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            Pause();
            break;
    }
} while (entrada != "0");
