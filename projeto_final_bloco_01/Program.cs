using projeto_final_bloco_01.Controller;
using projeto_final_bloco_01.Model;

namespace projeto_final_bloco_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menu, creditos;

            string titulo, editora, idioma, formato;
            int opcao = 0, id, tipo, edicao, peso, tamanhoEmMB;
            decimal preco, frete;


            LivroController livros = new();
            LivroFisico lf1 = new LivroFisico(livros.GerarNumero(), "O menino do pijama listrado", "Cia das Letras", "Espanhol", 2, 25, 300, 10);
            livros.CadastrarLivro(lf1);
            lf1.Visualizar();

            menu =
                "\n -------------------------------------" +
                "\n\t LIVRARIA CULTURA" +
                "\n -------------------------------------" +
                "\n\n 1 - Cadastrar livro" +
                "\n 2 - Listar livros " +
                "\n 3 - Procurar livro por id" +
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

                        Console.WriteLine("\nQual o tipo de livro ?\n 1 - Ebook\n 2 - Livro físico");
                        tipo = Convert.ToInt32(Console.ReadLine());

                        //método cadastrar
                        if (tipo == 1)
                        {
                            Console.WriteLine("\n Qual o formato do livro?");
                            formato = Console.ReadLine()!;

                            Console.WriteLine("\n Qual o tamanho do livro em GB?");
                            tamanhoEmMB = Convert.ToInt32(Console.ReadLine());

                            livros.CadastrarLivro(new Ebook(livros.GerarNumero(), titulo, editora, idioma, edicao, preco, formato, tamanhoEmMB));
                        }

                        else if (tipo == 2)
                        {
                            Console.WriteLine("\n Qual o peso do livro?");
                            peso = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\n Quanto é o frete do livro?");
                            frete = Convert.ToDecimal(Console.ReadLine());

                            livros.CadastrarLivro(new LivroFisico(livros.GerarNumero(), titulo, editora, idioma, edicao, preco, peso, frete));
                        }
                        else
                        {
                            Console.WriteLine("\n Erro: o tipo digitado não existe.");
                        }


                        break;

                    case 2:
                        Console.WriteLine("\n Opção Listar Livros");

                        //método listar

                        livros.ListarLivros();
                        break;

                    case 3:
                        Console.WriteLine("\n Opção Listar Livro Por Id");

                        Console.WriteLine("\n Qual o Id do livro? ");
                        id = Convert.ToInt32(Console.ReadLine());

                        //método listar por id
                        livros.ProcurarLivro(id);

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

                        Console.WriteLine("\nQual o tipo de livro ?\n 1 - Ebook\n 2 - Livro físico");
                        tipo = Convert.ToInt32(Console.ReadLine());

                        //método atualizar
                        if (tipo == 1)
                        {
                            Console.WriteLine("\n Qual o formato do livro?");
                            formato = Console.ReadLine()!;

                            Console.WriteLine("\n Qual o tamanho do livro em GB?");
                            tamanhoEmMB = Convert.ToInt32(Console.ReadLine());

                            livros.AtualizarLivro(new Ebook(id, titulo, editora, idioma, edicao, preco, formato, tamanhoEmMB));
                        }

                        else if (tipo == 2)
                        {
                            Console.WriteLine("\n Qual o peso do livro?");
                            peso = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\n Quanto é o frete do livro?");
                            frete = Convert.ToDecimal(Console.ReadLine());

                            livros.AtualizarLivro(new LivroFisico(id, titulo, editora, idioma, edicao, preco, peso, frete));
                        }
                        else
                        {
                            Console.WriteLine("\n Erro: o tipo digitado não existe.");
                        }


                        break;

                    case 5:
                        Console.WriteLine("\n Opção Excluir Livro");

                        Console.WriteLine("\n Qual o Id do livro que deseja excluir? ");
                        id = Convert.ToInt32(Console.ReadLine());

                        //método excluir
                        livros.ExcluirLivro(id);
                        break;

                    default:
                        Console.WriteLine("Erro: Opção inválida, digite novamente.\n");
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
