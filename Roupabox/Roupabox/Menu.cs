using System;
using System.Collections.Generic;

namespace RoupaBox
{
    internal class Menu
    {
        private List<Cliente> clientes = new List<Cliente>();
        private Produtos produtos = new Produtos();

        public void ExibirMenu()
        {
            while (true)
            {
                Console.WriteLine("Menu Principal");
                Console.WriteLine("1. Cadastrar Cliente");
                Console.WriteLine("2. Listar Clientes");
                Console.WriteLine("3. Cadastrar Produto");
                Console.WriteLine("4. Listar Produtos");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Encerrando o programa...");
                        return;
                    case 1:
                        var novoCliente = new Cliente();
                        clientes.Add(novoCliente);
                        break;
                    case 2:
                        ListarClientes();
                        break;
                    case 3:
                        produtos.CadProdutos();
                        break;
                    case 4:
                        produtos.ListarProdutos();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        private void ListarClientes()
        {
            Console.Clear();
            Console.WriteLine("\nClientes Cadastrados:");
            if (clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
            }
            else
            {
                foreach (var cliente in clientes)
                {
                    Console.WriteLine($"Nome: {cliente.Nome}, CPF: {cliente.CPF}, Email: {cliente.Email}, Telefone: {cliente.Telefone}, Idade: {cliente.Idade}, Sexo: {cliente.Sexo}, Endereço: {cliente.Endereco}");
                }
            }
        }
    }
}
