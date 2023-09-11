namespace projeto_final_bloco_01.Model
{
    public abstract class Livro
    {
        private string titulo, editora, idioma;
        private int edicao;
        private decimal preco;

        public Livro(string titulo, string editora, string idioma, int edicao, decimal preco)
        {
            this.titulo = titulo;
            this.editora = editora;
            this.idioma = idioma;
            this.edicao = edicao;
            this.preco = preco;
        }

        public string GetTitulo() { return titulo; }
        public void SetTitulo(string titulo) { this.titulo = titulo; }

        public string GetEditora() { return editora; }
        public void SetEditora(string editora) { this.editora = editora; }

        public string GetIdioma() { return idioma; }
        public void SetIdioma(string idioma) { this.idioma = idioma; }

        public int GetEdicao() { return edicao; }
        public void SetEdicao(int edicao) { this.edicao = edicao; }

        public decimal GetPreco() { return preco; }
        public void SetPreco(decimal preco) { this.preco = preco; }

        public virtual void Visualizar()
        {
            Console.WriteLine("\n\n--------------------------------------");
            Console.WriteLine("\n\t Dados do livro");
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine($" Título: {this.titulo}");
            Console.WriteLine($" Editora: {this.editora}");
            Console.WriteLine($" Idioma: {this.idioma}");
            Console.WriteLine($" Edição: {this.edicao}");
            Console.WriteLine($" Preço: {this.preco}");
        }
    }
}
