

namespace Desafio_POO_Celular_DIO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string Modelo, string IMEI, int Memoria) : base(numero, Modelo, IMEI, Memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia....");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}