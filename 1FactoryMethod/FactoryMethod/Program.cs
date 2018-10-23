using System;
using System.Collections.Generic;

namespace FactoryMethod
{

    class MainApp

    {

        static void Main()
        {
            Documento[] documentos = new Documento[2];

            documentos[0] = new Curriculo();
            documentos[1] = new Trabalho();

            foreach (Documento documento in documentos)
            {
                Console.WriteLine("\n" + documento.GetType().Name + "--");
                foreach (Pagina page in documento.Paginas)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            Console.ReadKey();
        }
    }


    abstract class Pagina
    {
    }

    class PaginaHabilidades : Pagina
    {
    }


    class PaginaEducacao : Pagina
    {
    }

    class PaginaExperiencia : Pagina
    {
    }


    class PaginaIntroducao : Pagina
    {
    }


    class PaginaResultados : Pagina
    {
    }

    class PaginaConclusao : Pagina
    {
    }

    class PaginaResumo : Pagina
    {
    }


    class PaginaBibliografia : Pagina
    {
    }


    abstract class Documento
    {
        private List<Pagina> _paginas = new List<Pagina>();

        public Documento()
        {
            this.CriaPaginas();
        }

        public List<Pagina> Paginas
        {
            get { return _paginas; }
        }

        public abstract void CriaPaginas();
    }


    class Curriculo : Documento
    {
        public override void CriaPaginas()
        {
            Paginas.Add(new PaginaHabilidades());
            Paginas.Add(new PaginaEducacao());
            Paginas.Add(new PaginaExperiencia());
        }
    }


    class Trabalho : Documento
    {
        public override void CriaPaginas()
        {
            Paginas.Add(new PaginaIntroducao());
            Paginas.Add(new PaginaResultados());
            Paginas.Add(new PaginaConclusao());
            Paginas.Add(new PaginaResumo());
            Paginas.Add(new PaginaBibliografia());
        }
    }
}

