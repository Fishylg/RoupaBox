using System;
using System.Collections.Generic;

namespace RoupaBox
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }

        public Cliente()
        {
            Console.Clear();
            Console.WriteLine("\nCadastro de Cliente");
            Console.Write("Nome: ");
            Nome = Console.ReadLine();

            Console.Write("CPF (11 dígitos): ");
            CPF = ValidarCPF();

            Console.Write("Telefone: ");
            Telefone = Console.ReadLine();

            Console.Write("Idade: ");
            Idade = int.Parse(Console.ReadLine());

            Console.Write("Email: ");
            Email = ValidarEmail();

            Console.Write("Sexo: ");
            Sexo = Console.ReadLine();

            Console.Write("Endereço: ");
            Endereco = Console.ReadLine();

            Console.WriteLine("\nCliente cadastrado com sucesso!");
        }

        private string ValidarCPF()
        {
            string cpf = Console.ReadLine();
            while (cpf.Length != 11 || !long.TryParse(cpf, out _))
            {
                Console.Write("CPF inválido, tente novamente: ");
                cpf = Console.ReadLine();
            }
            return cpf;
        }

        private string ValidarEmail()
        {
            string email = Console.ReadLine();
            while (!email.Contains("@"))
            {
                Console.Write("E-mail inválido, tente novamente: ");
                email = Console.ReadLine();
            }
            return email;
        }
    }
}
