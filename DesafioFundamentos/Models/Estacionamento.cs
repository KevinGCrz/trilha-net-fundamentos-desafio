using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        int contador = 1;
        private Dictionary<int, string> veiculos = new Dictionary<int, string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)//CONSTRUTOR
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(contador, Console.ReadLine());

            Console.WriteLine($"Seu carro está localizado na vaga: {contador}");
            contador++;
        }

        public void RemoverVeiculo()
        {
            if (veiculos.Any())// Verifica se o veículo existe
            {
                    Console.WriteLine("Digite a vaga do veículo para ser removido:");
                foreach(var item in veiculos)
                        {
                            Console.WriteLine($"Vaga: {item.Key} - Carro placa: {item.Value}");
                        }

                int removido = Convert.ToInt32(Console.ReadLine());
                
                if (veiculos.ContainsKey(removido)) //Verifica se vaga está correta
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");               

                    decimal valorTotal = 0; 
                    int horas = Convert.ToInt32(Console.ReadLine());

                    decimal valorEstacionamento = precoInicial * precoPorHora;
                    valorTotal = valorEstacionamento * horas;

                    Console.WriteLine($"O veículo {veiculos[removido]} foi removido e o preço total foi de: R$ {valorTotal} por {horas} horas.");
                    veiculos.Remove(removido);
                }
                else
                {
                    Console.WriteLine("Desculpe, está vaga não está ocupada");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())// Verifica se há veículos no estacionamento
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach(var item in veiculos)
                    {
                        Console.WriteLine($"Vaga: {item.Key} - Carro placa: {item.Value}");
                    }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
