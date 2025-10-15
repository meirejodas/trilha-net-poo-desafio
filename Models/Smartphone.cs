namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; } 
        

        public Smartphone(string numero, string modelo)
        {
            Numero = numero;
            Modelo = modelo;
           
        }

        public void Ligar()
        {
            Console.WriteLine($"{Modelo} está ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"{Modelo} está recebendo uma ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}