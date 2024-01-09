namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Marca { get; set; }
        public int ArmazenamentoGB { get; set; }

        public Smartphone(string numero, string marca, int armazenamentoGB)
        {
            Numero = numero;
            Marca = marca;
            ArmazenamentoGB = armazenamentoGB;
        }

        protected Smartphone(string numero)
        {
            Numero = numero;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
