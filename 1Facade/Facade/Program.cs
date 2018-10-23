using System;

namespace Facade
{

    class MainApp

    {

        static void Main()
        {

            Hipoteca hipoteca = new Hipoteca();

            Cliente cliente = new Cliente("Fulano da Silva");
            bool liberado = hipoteca.EstaLiberado(cliente, 125000);

            Console.WriteLine("\n" + cliente.Nome +
                " foi " + (liberado ? "Aprovado" : "Rejeitado"));

            Console.ReadKey();
        }
    }

    class Banco

    {
        public bool TemFundosSuficientes(Cliente c, int quantidade)
        {
            Console.WriteLine("Checando banco de " + c.Nome);
            return true;
        }
    }


    class Credito

    {
        public bool TemBomCreditoo(Cliente c)
        {
            Console.WriteLine("Checando credito de " + c.Nome);
            return true;
        }
    }

    class Emprestimo

    {
        public bool NaoTemEmprestimos(Cliente c)
        {
            Console.WriteLine("Checando emprestimos de " + c.Nome);
            return true;
        }
    }


    class Cliente

    {
        private string _nome;


        public Cliente(string name)
        {
            this._nome = name;
        }


        public string Nome
        {
            get { return _nome; }
        }
    }


    class Hipoteca

    {
        private Banco _banco = new Banco();
        private Emprestimo _loan = new Emprestimo();
        private Credito _credito = new Credito();

        public bool EstaLiberado(Cliente cliente, int quantidade)
        {
            Console.WriteLine("{0} aplicando para emprestimo de {1:C}\n",
              cliente.Nome, quantidade);

            bool liberado = true;


            if (!_banco.TemFundosSuficientes(cliente, quantidade))
            {
                liberado = false;
            }
            else if (!_loan.NaoTemEmprestimos(cliente))
            {
                liberado = false;
            }
            else if (!_credito.TemBomCreditoo(cliente))
            {
                liberado = false;
            }

            return liberado;
        }
    }
}

