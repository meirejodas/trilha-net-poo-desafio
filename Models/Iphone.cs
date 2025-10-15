namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo) : base(numero, modelo)
        {

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeAPP)
        {

            Console.WriteLine($"Instalando o aplicativo {nomeAPP} no iPhone {Modelo} via App Store...");

        }

    }
}