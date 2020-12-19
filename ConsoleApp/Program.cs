
using ConsoleApp.Models;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var genesisBlock = new Block("0 BTC5000 1111", "");
            var block1 = new Block("1111 BTC10 2345 | 1111 BTC50 9876", genesisBlock.Id);
            var block2 = new Block("1111 BTC5 4444 | 1111 BTC80 5555", block1.Id);

            Console.WriteLine("========= BLOCOS =========");
            Console.WriteLine($"Id do Bloco: {genesisBlock.Id}");
            Console.WriteLine($"Conteúdo do Bloco: {genesisBlock.Content}");
            Console.WriteLine($"Bloco Anterior: {genesisBlock.PreviousBlockId}");
            Console.WriteLine();
            Console.WriteLine($"Id do Bloco: {block1.Id}");
            Console.WriteLine($"Conteúdo do Bloco: {block1.Content}");
            Console.WriteLine($"Bloco Anterior: {block1.PreviousBlockId}");

            Console.WriteLine();
            Console.WriteLine($"Id do Bloco: {block2.Id}");
            Console.WriteLine($"Conteúdo do Bloco: {block2.Content}");
            Console.WriteLine($"Bloco Anterior: {block2.PreviousBlockId}");
        }
    }
}
