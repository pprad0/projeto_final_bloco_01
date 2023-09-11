using projeto_final_bloco_01.Model;

namespace projeto_final_bloco_01.Repository
{
    public interface ILivroRepository
    {
        //CRUD
        public void CadastrarLivro(Livro livro);
        public void ListarLivros();
        public void ProcurarLivro(int id);
        public void AtualizarLivro(Livro livro);
        public void ExcluirLivro(int id);

    }
}
