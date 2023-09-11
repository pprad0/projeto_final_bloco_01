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
            int opcao = 0, id, edicao, peso;
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

                        Console.WriteLine("\n Qual o Título do livro? ");
                        titulo = Console.ReadLine()!;

                        Console.WriteLine("\n Qual a Editora do livro? ");
                        editora = Console.ReadLine()!;

                        Console.WriteLine("\n Qual o Idioma do livro? ");
                        idioma = Console.ReadLine()!;

                        Console.WriteLine("\n Qual a Edição do livro? (Insira apenas números)  ");
                        edicao = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\n Qual o preço do livro? ");
                        preco = Convert.ToDecimal(Console.ReadLine());

                        //método cadastrar

                        break;

                    case 2:
                        Console.WriteLine("\n Opção Listar Livros");

                        //método listar
                        break;

                    case 3:
                        Console.WriteLine("\n Opção Listar Livro Por Id");

                        Console.WriteLine("\n Qual o Id do livro? ");
                        id = Convert.ToInt32(Console.ReadLine());

                        //método listar por id
                        break;

                    case 4:
                        Console.WriteLine("\n Opção Atualizar Dados de Livro");

                        Console.WriteLine("\n Qual o Id do livro que deseja atualizar? ");
                        id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\n Qual o Título do livro? ");
                        titulo = Console.ReadLine()!;

                        Console.WriteLine("\n Qual a Editora do livro? ");
                        editora = Console.ReadLine()!;

                        Console.WriteLine("\n Qual o Idioma do livro? ");
                        idioma = Console.ReadLine()!;

                        Console.WriteLine("\n Qual a Edição do livro? (Insira apenas números)  ");
                        edicao = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\n Qual o preço do livro? ");
                        preco = Convert.ToDecimal(Console.ReadLine());

                        //método atualizar

                        break;

                    case 5:
                        Console.WriteLine("\n Opção Excluir Livro");

                        Console.WriteLine("\n Qual o Id do livro que deseja excluir? ");
                        id = Convert.ToInt32(Console.ReadLine());

                        //método excluir

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