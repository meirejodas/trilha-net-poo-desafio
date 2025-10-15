using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e 
class Program
{
    static void Main(string[] args)
    {
        // Testando a classe Nokia
        Nokia nokia = new Nokia("123456789", "Nokia 3310");
        Console.WriteLine("=== Teste Nokia ===");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine(); // Separador no console

        // Testando a classe iPhone
        Iphone iphone = new Iphone("987654321", "iPhone 14");
        Console.WriteLine("=== Teste iPhone ===");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

        Console.WriteLine("\nTestes finalizados!");
    }
}