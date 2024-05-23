// See https://aka.ms/new-console-template for more information
using Revisao;

Console.WriteLine("Hello, World!");

List<Contato> agenda = new List<Contato>();

void CriaContato()
{
    Contato contato = new Contato();

    Console.WriteLine("Informe o nome do contato: ");
    contato.setNome(Console.ReadLine());

    Console.WriteLine("Informe o telefone do contato: ");
    contato.setTelefone(Console.ReadLine());

    Console.WriteLine("Informe o endereço do contato: ");
    string logradouro = Console.ReadLine();

    Console.WriteLine("Informe o numero da casa: ");
    int num = int.Parse(Console.ReadLine());

    contato.setEndereco(logradouro, num);
    //contato.setEndereco(Console.ReadLine(), int.Parse(Console.ReadLine()));

    agenda.Add(contato);
}


void ImprimeLista()
{
    foreach (Contato item in agenda)
    {
        Console.WriteLine(item.ToString());
        //Console.ReadLine();
    }
}

Contato LocalizaContato(string n)
{
    return agenda.Find(contato => contato.getNome() == n);
}

void RemovedaLista(string nome)
{
    var achei = LocalizaContato(nome);
    if (achei == null)
    {
        Console.WriteLine("Contato não encontrado!");
    }
    else
    {
        agenda.Remove(LocalizaContato(nome));
    }
}

#region aula 1
//Console.WriteLine("Informe o nome do contato: ");
//string leituradoTeclado = Console.ReadLine();

//contato.setNome(leituradoTeclado);

//Console.WriteLine("Informe o telefone do contato: ");
//leituradoTeclado = Console.ReadLine();

//contato.setTelefone(leituradoTeclado);

//Console.WriteLine("Informe o endereço do contato: ");
//leituradoTeclado = Console.ReadLine();

//Console.WriteLine("Informe o numero da casa: ");
//int num = int.Parse(Console.ReadLine());

////contato.endereco.setLogradouro(leituradoTeclado);
//contato.setEndereco(leituradoTeclado, num);

////Console.WriteLine(contato.ToString());

//Console.WriteLine("Informe o nome do contato: ");
//leituradoTeclado = Console.ReadLine();

//contato2.setNome(leituradoTeclado);

//Console.WriteLine("Informe o telefone do contato: ");
//leituradoTeclado = Console.ReadLine();

//contato2.setTelefone(leituradoTeclado);

//Console.WriteLine("Informe o endereço do contato: ");
//leituradoTeclado = Console.ReadLine();

//Console.WriteLine("Informe o numero da casa: ");
//num = int.Parse(Console.ReadLine());

////contato.endereco.setLogradouro(leituradoTeclado);
//contato2.setEndereco(leituradoTeclado, num);

////Console.WriteLine(contato2.ToString());
#endregion

#region aula 2
//contato.setNome("Felipe");
//contato.setTelefone("12345");
//contato.setEndereco("Rua 1", 100);
//agenda.Add(contato);


//contato = new();
//contato.setNome("Joao");
//contato.setTelefone("54321");
//contato.setEndereco("Rua 2", 200);
//agenda.Add(contato);

//contato = new();
//contato.setNome("Paola");
//contato.setTelefone("98765");
//contato.setEndereco("Rua 3", 300);
//agenda.Add(contato);


//contato = new();
//contato.setNome("Daiane");
//contato.setTelefone("145678");
//contato.setEndereco("Rua 4", 400);
//agenda.Add(contato);


//contato = new();
//contato.setNome("Maiara");
//contato.setTelefone("856734");
//contato.setEndereco("Rua 5", 500);
//agenda.Add(contato);


//contato = new();
//contato.setNome("Juliana");
//contato.setTelefone("4678");
//contato.setEndereco("Rua 6", 600);
//agenda.Add(contato);
#endregion
string resposta;

do {
    CriaContato();
    Console.WriteLine("Deseja adicionar um novo contato?");
    resposta = Console.ReadLine();
} while (resposta == "S");


ImprimeLista();
Console.ReadKey();
Console.Clear();

Console.WriteLine("Informe o nome do contato a ser removido:");
RemovedaLista(Console.ReadLine());

ImprimeLista();
Console.ReadLine();
Console.Clear();

Console.WriteLine("Informe o nome do contato a ser encontrado:");
Contato achei = LocalizaContato(Console.ReadLine());

if (achei == null)
{
    Console.WriteLine("Contato não encontrado.");
}
else
{
    Console.WriteLine(achei.ToString());
}


