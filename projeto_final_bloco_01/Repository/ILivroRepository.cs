namespace projeto_final_bloco_01.Repository
{
    public interface ILivroRepository
    {
        //CRUD
        public void CadastrarLivro();
        public void ListarLivros();
        public void ProcurarLivro();
        public void AtualizarLivro();
        public void ExcluirLivro();

    }
}
