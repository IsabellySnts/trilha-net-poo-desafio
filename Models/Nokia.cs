namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string imei, int memoria, string modelo) : base(numero, imei, memoria, modelo)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
             Console.WriteLine($"Instalando {nomeApp} na playStore do Nokia...");
        }
    }
}