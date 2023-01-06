using Desafio_POO_Celular_DIO.Models;

namespace Desafio_POO_Celular_DIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Realizar os testes com as classes Nokia e Iphone
            Console.WriteLine("Smartphone Nokia: ");
            Smartphone nokia = new Nokia(numero: "988181818", Modelo: "Modelo 2022", IMEI: "1111", Memoria: 64);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatssApp");

            Console.WriteLine("\n------------------------------\n");

            Console.WriteLine("Smartphone Iphone: ");
            Smartphone iphone = new Iphone(numero: "9373737373", Modelo: "2023", IMEI: "2222", Memoria: 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Spotify");
        }
    }
}