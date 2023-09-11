namespace projeto_final_bloco_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //classe mãe: Livro - Título, Editora, Edição, Idioma, Preço

            //classe filha: livro físico - Peso, frete
            //classe filha: ebook - formato, tamanhoEmMB

            string menu, creditos;
            string titulo, editora, idioma;
            int opcao = 0, edicao, peso;
            decimal preco, frete;

            menu =
                "\n -------------------------------------" +
                "\n\t LIVRARIA CULTURA" +
                "\n -------------------------------------" +
                "\n\n 1 - Cadastrar livro" +
                "\n 2 - Listar livros " +
                "\n 3 - Listar livro por id" +
                "\n 4 - Atualizar dados de livro" +
                "\n 5 - Excluir livro" +
                "\n 6 - Sair" +
                "\n\n Digite uma opção: ";


            while (opcao != 6)
            {
                Console.WriteLine(menu);
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\n Opção Cadastrar Livro");
                        break;

                    case 2:
                        Console.WriteLine("\n Opção Listar Livros");
                        break;

                    case 3:
                        Console.WriteLine("\n Opção Listar Livro Por Id");
                        break;

                    case 4:
                        Console.WriteLine("\n Opção Atualizar Dados de Livro");
                        break;

                    case 5:
                        Console.WriteLine("\n Opção Excluir Livro");
                        break;

                }
            }
            //Fim do loop
            Console.WriteLine("\n Opção Sair");






            creditos =
                "\n\n ------------------------------------------------" +
                "\n\t Apoiando a cultura e a educação." +
                "\n ------------------------------------------------" +
                "\n Projeto desenvolvido por: Pedro Melo" +
                "\n Generation Brasil - generation@generation.org" +
                "\n github.com/conteudoGeneration \n";
            Console.WriteLine(creditos);
        }
    }
}