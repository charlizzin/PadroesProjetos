using System;

namespace Memento
{
    class MainApp

    {
        static void Main()
        {
            PossivelVenda s = new PossivelVenda();
            s.Nome = "Fulano da Silva";
            s.Telefone = "(33) 3271-0000";
            s.Orcamento = 25000.0;

            Memoria m = new Memoria();
            m.Memento = s.SalvaMemoria();

            s.Nome = "Siclano da Silva";
            s.Telefone = "(33) 3225-0000";
            s.Orcamento = 1000000.0;

            s.RestauraMemoria(m.Memento);

            Console.ReadKey();
        }
    }

    class PossivelVenda

    {
        private string _Nome;
        private string _Telefone;
        private double _Orcamento;


        public string Nome
        {
            get { return _Nome; }
            set

            {
                _Nome = value;
                Console.WriteLine("Nome:  " + _Nome);
            }
        }

        public string Telefone
        {
            get { return _Telefone; }
            set

            {
                _Telefone = value;
                Console.WriteLine("Telefone: " + _Telefone);
            }
        }


        public double Orcamento
        {
            get { return _Orcamento; }
            set

            {
                _Orcamento = value;
                Console.WriteLine("Orcamento: " + _Orcamento);
            }
        }


        public Memento SalvaMemoria()
        {
            Console.WriteLine("\nSalvando estado --\n");
            return new Memento(_Nome, _Telefone, _Orcamento);
        }


        public void RestauraMemoria(Memento memento)
        {
            Console.WriteLine("\nRestaurando estado --\n");
            this.Nome = memento.Nome;
            this.Telefone = memento.Telefone;
            this.Orcamento = memento.Orcamento;
        }
    }


    class Memento

    {
        private string _Nome;
        private string _Telefone;
        private double _Orcamento;

        public Memento(string Nome, string Telefone, double Orcamento)
        {
            this._Nome = Nome;
            this._Telefone = Telefone;
            this._Orcamento = Orcamento;
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }

        public double Orcamento
        {
            get { return _Orcamento; }
            set { _Orcamento = value; }
        }
    }


    class Memoria

    {
        private Memento _memento;

        public Memento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}