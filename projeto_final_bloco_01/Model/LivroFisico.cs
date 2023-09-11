namespace projeto_final_bloco_01.Model
{
    public class LivroFisico : Livro
    {
        private int peso;
        private decimal frete;

        public LivroFisico(string titulo, string editora, string idioma, int edicao, decimal preco, int peso, decimal frete)
            : base(titulo, editora, idioma, edicao, preco)
        {
            this.peso = peso;
            this.frete = frete;
        }

        public int GetPeso() { return peso; }
        public void SetPeso(int peso) { this.peso = peso; }

        public decimal GetFrete() { return frete; }
        public void SetFrete(decimal frete) { this.frete = frete; }



        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($" Peso: {this.peso}");
            Console.WriteLine($" Frete: {this.frete}");
        }
    }
}
