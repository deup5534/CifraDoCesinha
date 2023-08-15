// //string stringNumero = "321";
// int inteiroNumero = int.Parse(stringNumero);
// Console.WriteLine(inteiroNumero);  // Isso imprimirá 321



Console.WriteLine("---------CIFRA DE CESAR---------\n");


Console.Write("Escreva aqui sua senha, vou te mostrar como ela ficaria criptografada.\n");
string segredoASerEscrito = Console.ReadLine();

Console.Write("Agora, a chave que você deseja. (Por favor, digite de 1 até 27).\n");
int chave = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***CRIPTOGRAFANDO***");
Thread.Sleep(2000);

string cifraDeCesar = segredoASerEscrito

.Replace("a", "65")
.Replace("á", "65")
.Replace("â", "65")
.Replace("ã", "65")
.Replace("b", "66")
.Replace("c", "67")
.Replace("d", "68")
.Replace("e", "69")
.Replace("é", "69")
.Replace("ê", "69")
.Replace("f", "70")
.Replace("g", "71")
.Replace("h", "72")
.Replace("i", "73")
.Replace("í", "73")
.Replace("j", "74")
.Replace("k", "75")
.Replace("l", "76")
.Replace("m", "77")
.Replace("n", "78")
.Replace("o", "79")
.Replace("ó", "79")
.Replace("ô", "79")
.Replace("õ", "79")
.Replace("p", "80")
.Replace("q", "81")
.Replace("r", "82")
.Replace("s", "83")
.Replace("t", "84")
.Replace("u", "85")
.Replace("ú", "85")
.Replace("û", "85")
.Replace("v", "86")
.Replace("w", "87")
.Replace("x", "88")
.Replace("y", "89")
.Replace("z", "90");


int cifraDeCesar = int.Parse(segredoASerEscrito);

if (chave >= 28)

{
    Console.WriteLine("\n'-'\nChei das graça né");
    Console.WriteLine("\nEscreve certo isso...");
}

else{

// int criptografia = Convert.ToInt32();
Console.Write($"Sua mensagem Criptografada: {cifraDeCesar}\n");

}
