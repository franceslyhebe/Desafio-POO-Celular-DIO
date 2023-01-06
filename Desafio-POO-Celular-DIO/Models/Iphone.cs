

namespace Desafio_POO_Celular_DIO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string Modelo, string IMEI, int Memoria) : base(numero, Modelo, IMEI, Memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone.....");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}