namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
         public Nokia(string numero, string modelo) : base(numero, modelo)
        {
        }

        // Sobrescrevendo o método abstrato "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia {Modelo} via Loja Nokia...");
        }
    }
}
    