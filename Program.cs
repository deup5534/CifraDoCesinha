Console.WriteLine("---------CIFRA DE CESAR---------\n");


Console.Write("Escreva aqui sua senha, vou te mostrar como ela ficaria criptografada.\n");
string segredoASerEscrito = Console.ReadLine();

Console.Write("Agora, a chave que você deseja. (Por favor, digite de 1 até 27).\n");
int chave = Convert.ToInt32(Console.ReadLine());


if (chave >= 1 && chave <= 26)

{
    Console.WriteLine("**CRIPTOGRAFANDO**");

    Thread.Sleep(2000);

    string cifraDeCesar = Criptografar(segredoASerEscrito, chave);

    Console.Write($"Sua mensagem criptografada: {cifraDeCesar}\n");
}

else{

        Console.WriteLine("\n'-'\nCheio das graças, né?");

        Console.WriteLine("\nEscreve certo isso...");

}
