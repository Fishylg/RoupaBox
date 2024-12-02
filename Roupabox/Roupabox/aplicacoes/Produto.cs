using System;
using System.Collections.Generic;

namespace RoupaBox
{
    internal class Produtos
    {
        private List<ProdutoCad> listaProdutos = new List<ProdutoCad>();

        public void CadProdutos()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Produtos");

            Console.WriteLine("\nDigite a descrição do produto: ");
            string descPro = Console.ReadLine();

            var produto = new ProdutoCad(descPro);

            Console.WriteLine("\nDigite a marca do produto: ");
            produto.MarcaPro = Console.ReadLine();

            Console.WriteLine("\nDigite o tamanho do produto: ");
            produto.TamPro = Console.ReadLine();

            Console.WriteLine("\nDigite a cor do produto: ");
            produto.CorPro = Console.ReadLine();

            Console.WriteLine("\nDigite a categoria do produto: ");
            produto.CatPro = Console.ReadLine();

            Console.WriteLine("\nDigite o valor do produto: ");
            produto.ValPro = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o peso do produto: ");
            produto.PesoPro = double.Parse(Console.ReadLine());

            listaProdutos.Add(produto);

            Console.WriteLine("\nO produto foi cadastrado com sucesso!");
            ListarProdutos();
        }

        public void ListarProdutos()
        {
            Console.WriteLine("\nProdutos Cadastrados:");
            if (listaProdutos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }

            foreach (var produto in listaProdutos)
            {
                Console.WriteLine($"Descrição: {produto.DescPro}, Marca: {produto.MarcaPro}, Valor: R${produto.ValPro:F2}, Tamanho: {produto.TamPro}, Cor: {produto.CorPro}, Categoria: {produto.CatPro}, Peso: {produto.PesoPro}kg");
            }
        }
    }
}
