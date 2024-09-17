/* 
 * Author: Lucas Galhardo
 * Formação C#
 * Desafio 01
 * Created: 16/09/2024
 */


//1 - Crie um programa em que o usuário precisa digitar um nome e
//    uma mensagem de boas vindas personalizada com o nome dele é exibida:
//    Olá, Welisson! Seja muito bem-vindo!

MensagemBoasVindas();
void MensagemBoasVindas()
{
    Console.Clear();
    Console.WriteLine("Informe seu nome: ");
    string? nome = Console.ReadLine();
    Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo(a)!");
}

//2 - Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário
//    e ao final exiba o nome completo.

ConcatenarNomes();
void ConcatenarNomes()
{
    Console.Clear();
    Console.Write("Informe o primeiro nome: ");
    string? nome = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Informe o sobrenome: ");
    string? sobrenome = Console.ReadLine();
    Console.WriteLine($"O nome completo é: {nome} {sobrenome}");
}

// 3 - Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
//   - A soma entre esses dois números;
//   - A subtração entre os dois números;
//   - A multiplicação entre os dois números;
//   - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
//   - A média entre os dois números.
CalcularComDoisNumeros();
void CalcularComDoisNumeros()
{
    Console.Clear();
    Console.Write("Informe o primeiro número: ");
    double numero1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Informe o segundo número: ");
    double numero2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("\nResultados");
    Console.WriteLine("Soma: {0}", numero1 + numero2);
    Console.WriteLine("Subtração: {0}", numero1 - numero2);
    Console.WriteLine("Multiplicação: {0}", numero1 * numero2);
    Console.WriteLine(String.Format(numero2 == 0 ? "Divisão: Numero 2 não pode ser zero" : "Divisão: {0}", numero1 / numero2));
    Console.WriteLine("Média: {0}",(numero1 + numero2)/2);
}

// 4 - Crie um programa em que o usuário digita uma ou mais palavras
//     e é exibido a quantidade de caracteres que a palavra inserida tem.
ContarCaracteres();

void ContarCaracteres()
{
    Console.Clear();
    Console.Write("Digite a palavra desejada: ");
    string? palavra = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Quantidade de caracteres: {0}", palavra.Length);
}

// 5 - Crie um programa em que o usuário precisa digitar a placa de um veículo
//     e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
//     - A placa deve ter 7 caracteres alfanuméricos;
//     - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
//     - Os quatro últimos caracteres são números;
//     Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário.
VerificarPlaca();

void VerificarPlaca()
{
    Console.Clear();
    Console.Write("Digite a placa do veículo: ");
    string? placa = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("Resultada da validação: \n");
    
    if (placa.Length != 7)
    {
        Console.WriteLine("***Falso***");
        return;
    }

    if (!Char.IsLetter(placa[0]) || !Char.IsLetter(placa[1]) || !Char.IsLetter(placa[2])) {
        Console.WriteLine("***Falso***");
        return;
    }

    if (!Char.IsNumber(placa[3]) || !Char.IsNumber(placa[4]) || !Char.IsNumber(placa[5]) || !Char.IsNumber(placa[6]))
    {
        Console.WriteLine("***Falso***");
        return;
    }
    Console.WriteLine("***Verdadeiro***");
}