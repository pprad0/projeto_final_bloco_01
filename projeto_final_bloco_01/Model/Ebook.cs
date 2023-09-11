namespace projeto_final_bloco_01.Model
{
    public class Ebook : Livro
    {
        private string formato;
        private int tamanhoEmMB;

        public Ebook(string titulo, string editora, string idioma, int edicao, decimal preco, string formato, int tamanhoEmMB)
            : base(titulo, editora, idioma, edicao, preco)
        {
            this.tamanhoEmMB = tamanhoEmMB;
            this.formato = formato;
        }

        public string GetFormato() { return formato; }
        public void SetFormato(string formato) { this.formato = formato; }

        public int GetTamanhoEmMB() { return tamanhoEmMB; }
        public void SetTamanhoEmMB(int tamanhoEmMB) { this.tamanhoEmMB = tamanhoEmMB; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($" Formato: {this.formato}");
            Console.WriteLine($" Tamanho do arquivo (MB): {this.tamanhoEmMB}");
        }
    }
}
