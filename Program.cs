Console.WriteLine("---------CIFRA DE CESAR---------\n"); //Exibindo nome do programa.


Console.Write("Escreva aqui sua senha, vou te mostrar como ela ficaria criptografada.\n");
string segredoASerEscrito = Console.ReadLine(); //capturando a palavra que vai ser criptografada

Console.Write("Agora, a chave que você deseja. (Por favor, digite de 1 até 27).\n");
int chave = Convert.ToInt32(Console.ReadLine()); //denominando qual chave da criptografia será


if (chave >= 1 && chave <= 26) //Colocando condições para que haja limite na chave.

{
    Console.WriteLine("**CRIPTOGRAFANDO**"); //"Tela de loading".

    Thread.Sleep(2000); //Tempo de 2 segundos.

    string cifraDeCesar = Criptografar(segredoASerEscrito, chave); //Combinando os resultados e com o chave que o usuário decidiu.  

    Console.Write($"Sua mensagem criptografada: {cifraDeCesar}\n"); //Exibindo o resultado da combinação anterior.
}

else
{

        Console.WriteLine("\n'-'\nCheio das graças, né?"); 
                                                            //Exibindo tela de erro.
        Console.WriteLine("\nEscreve certo isso...");

}
