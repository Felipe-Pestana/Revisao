// See https://aka.ms/new-console-template for more information
using Revisao;

Console.WriteLine("Hello, World!");

Contato contato = new Contato();
Contato contato2 = new();

Console.WriteLine("Informe o nome do contato: ");
string leituradoTeclado = Console.ReadLine();

contato.setNome(leituradoTeclado);

Console.WriteLine("Informe o telefone do contato: ");
leituradoTeclado = Console.ReadLine();

contato.setTelefone(leituradoTeclado);

Console.WriteLine("Informe o endereço do contato: ");
leituradoTeclado = Console.ReadLine();

Console.WriteLine("Informe o numero da casa: ");
int num = int.Parse(Console.ReadLine());

//contato.endereco.setLogradouro(leituradoTeclado);
contato.setEndereco(leituradoTeclado, num);

//Console.WriteLine(contato.ToString());

Console.WriteLine("Informe o nome do contato: ");
leituradoTeclado = Console.ReadLine();

contato2.setNome(leituradoTeclado);

Console.WriteLine("Informe o telefone do contato: ");
leituradoTeclado = Console.ReadLine();

contato2.setTelefone(leituradoTeclado);

Console.WriteLine("Informe o endereço do contato: ");
leituradoTeclado = Console.ReadLine();

Console.WriteLine("Informe o numero da casa: ");
num = int.Parse(Console.ReadLine());

//contato.endereco.setLogradouro(leituradoTeclado);
contato2.setEndereco(leituradoTeclado, num);

//Console.WriteLine(contato2.ToString());

List<Contato> agenda = new List<Contato>();

agenda.Add(contato);
agenda.Add(contato2);

foreach (Contato item in agenda)
{
    Console.WriteLine(item.ToString());
    Console.ReadLine();
}


Console.ReadKey();