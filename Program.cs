using TransferBank;

internal class Program
{
    static List<Conta> listaContas = new List<Conta>(){
        new Conta(tipoConta: (TipoConta)1, saldo: 1000, credito: 100, nome: "Marco Santos"),
        new Conta(tipoConta: (TipoConta)2, saldo: 2000, credito: 200, nome: "Marc Santos"),
        new Conta(tipoConta: (TipoConta)1, saldo: 3000, credito: 300, nome: "Mar Santos"),
        new Conta(tipoConta: (TipoConta)2, saldo: 4000, credito: 400, nome: "Ma Santos"),
        new Conta(tipoConta: (TipoConta)1, saldo: 5000, credito: 500, nome: "M Santos"),
        new Conta(tipoConta: (TipoConta)2, saldo: 6000, credito: 600, nome: "Marcos Santos"),
    };

    private static void Main(string[] args)
    {
        string opcaoUsuario = ObterOpcaoUruário();

        while (opcaoUsuario.ToUpper() != "X")
        {
            switch (opcaoUsuario){
                case "1":
                    ListarContas();
                break;
                case "2":
                    InserirConta();
                break;
                case "3":
                    Transferir();
                break;
                case "4":
                    Sacar();
                break;
                case "5":
                    Depositar();
                break;
                case "C":
                    Console.Clear();
                break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            opcaoUsuario = ObterOpcaoUruário();
        }

        Console.WriteLine("Obrigado por utilizar nossos serviços.");
    }

    private static void Transferir()
    {
        System.Console.Write("Digite o número da conta de origem: ");
        int indiceContaOrigem = int.Parse(Console.ReadLine()!);

        System.Console.Write("Digite o número da conta de destino: ");
        int indiceContaDestino = int.Parse(Console.ReadLine()!);

        System.Console.Write("Digite o valor a ser transferido: ");
        double valorTransferencia = double.Parse(Console.ReadLine()!);

        listaContas[indiceContaOrigem].Transferir(valorTransferencia, listaContas[indiceContaDestino]);
    }

    private static void Depositar()
    {
        System.Console.Write("Digite o número da conta: ");
        int indiceConta = int.Parse(Console.ReadLine()!);

        System.Console.Write("Digite o valor a ser depositado: ");
        double valorDepositado = double.Parse(Console.ReadLine()!);

        listaContas[indiceConta].Depositar(valorDepositado);
    }

    private static void Sacar()
    {
        System.Console.Write("Digite o número da conta: ");
        int indiceConta = int.Parse(Console.ReadLine()!);

        System.Console.Write("Digite o valor a ser sacado: ");
        double valorSacado = double.Parse(Console.ReadLine()!);

        listaContas[indiceConta].Sacar(valorSacado);
    }

    private static void ListarContas()
    {
        System.Console.WriteLine("Listar Contas\n");

        if(listaContas.Count == 0){
            System.Console.WriteLine("Nenhuma Conta cadastrada.");
            return;
        }

        for (int i = 0; i < listaContas.Count; i++){
            Conta conta = listaContas[i];
            System.Console.Write($"#{i} - ");
            System.Console.WriteLine(conta);
        }

        Console.ReadLine();
    }

    private static void InserirConta()
    {
        System.Console.Write("Inserir Nova Conta");

        System.Console.Write("Difite 1 para Conta Fisica ou 2 para Juridica: ");
        int entradaTipoConta = int.Parse(Console.ReadLine()!);

        System.Console.Write("Digite o nome do Cliente: ");
        string entradaNome = Console.ReadLine()!;

        Console.Write("Digite o saldo inicial: ");
        double entradaSaldo = double.Parse(Console.ReadLine()!);

        Console.Write("Digite o crédito: ");
        double entradaCredito = double.Parse(Console.ReadLine()!);

        Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                    saldo: entradaSaldo,
                                    credito: entradaCredito,
                                    nome: entradaNome);
        
        listaContas.Add(novaConta);
    }

    private static string ObterOpcaoUruário()
    {
        Console.WriteLine();
        Console.WriteLine("Transfer Bank a seu dispor!!");
        Console.WriteLine("Informe a opção desejada:\n");

        Console.WriteLine("1 - Listar contas");
        Console.WriteLine("2 - Inserir nova conta");
        Console.WriteLine("3 - Transferir");
        Console.WriteLine("4 - Sacar");
        Console.WriteLine("5 - Depositar");
        Console.WriteLine("C - Limpar Tela");
        Console.WriteLine("X - Sair");
        Console.WriteLine();

        string opcaoUsuario = Console.ReadLine()!.ToUpper();
        Console.WriteLine();
        return opcaoUsuario;
    }
}