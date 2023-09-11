using projeto_final_bloco_01.Model;
using projeto_final_bloco_01.Repository;

namespace projeto_final_bloco_01.Controller
{
    public class LivroController : ILivroRepository
    {
        private readonly List<Livro> listaLivros = new();
        int id = 0;

        //CRUD
        public void CadastrarLivro(Livro livro) // ok
        {
            listaLivros.Add(livro);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" O livro com Id {livro.GetId()} foi criado com sucesso!");
            Console.ResetColor();
        }

        public void ListarLivros() //ok
        {
            foreach (var livro in listaLivros)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                livro.Visualizar();
                Console.ResetColor();

            }

        }
        public void ProcurarLivro(int id) // ok
        {
            var livro = BuscarNaCollection(id);

            if (livro is not null)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                livro.Visualizar();
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n O livro de Id {id} não foi encontrada!");
                Console.ResetColor();
            }
        }

        public void AtualizarLivro(Livro livro) // ok
        {
            var buscaLivro = BuscarNaCollection(livro.GetId());

            if (buscaLivro is not null)
            {
                var index = listaLivros.IndexOf(buscaLivro);
                listaLivros[index] = livro;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" O livro de Id {livro.GetId()} foi atualizado com sucesso!");
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" Este id não foi encontrado!");
                Console.ResetColor();
            }
        }

        public void ExcluirLivro(int id) // ok
        {
            var livro = BuscarNaCollection(id);

            if (livro is not null)
            {

                if (listaLivros.Remove(livro))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($" O livro de Id {id} foi apagado com sucesso!");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" O livro de Id {id} não foi encontrada!");
                Console.ResetColor();
            }
        }





        //Métodos auxiliares
        public int GerarNumero()
        {
            return ++id;
        }

        public Livro? BuscarNaCollection(int id)
        {
            foreach (var livro in listaLivros)
            {
                if (livro.GetId() == id)
                    return livro;
            }

            return null;
        }
    }
}
