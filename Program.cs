using System;
using System.Collections.Generic;
using APP_Series.Classes;
using APP_Series.Enumerados;
//using APP_Series.Enum;

namespace APP_Series
{
  class Program
  {
    static SerieRepositorio repositorio = new SerieRepositorio();
    static void Main(string[] args)
    {



      string opcaoUsuario;
      Console.WriteLine("Inicio Locadora De Séries:");

      opcaoUsuario = ObterOpcaoUsuario();

      while (opcaoUsuario != "X")
      {
        switch (opcaoUsuario)
        {
          case "1":
            ListaSeries();
            break;
          case "2":
            InserirSerie();
            break;
          case "3":
            AtualizarSerie();
            break;
          case "4":
            ExcluirSerie();
            break;
          case "5":
            VisualizarSerie();
            break;
          case "C":
            Console.Clear();
            break;
          default:
            //throw new ArgumentOutOfRangeException();
            Console.WriteLine("Comando Inválido");
            break;
        }
        opcaoUsuario = ObterOpcaoUsuario();
      }
    }
    private static string ObterOpcaoUsuario()
    {
      string opcaoUsuario;

      Console.WriteLine("Informe a opção Desejada:");
      Console.WriteLine("1 - Listar Séries");
      Console.WriteLine("2 - Inserir nova Série");
      Console.WriteLine("3 - Atualizar Série");
      Console.WriteLine("4 - ExcluirSérie");
      Console.WriteLine("5 - Visualizar Série");
      Console.WriteLine("C - Limpar Tela");
      Console.WriteLine("X - Sair");

      opcaoUsuario = Console.ReadLine().ToUpper();
      Console.WriteLine("opção Escolhida: {0}", opcaoUsuario);
      Console.WriteLine();
      return opcaoUsuario;
    }

    private static void VisualizarSerie()
    {
      throw new NotImplementedException();
    }

    private static void ExcluirSerie()
    {
      throw new NotImplementedException();
    }

    private static void AtualizarSerie()
    {
      throw new NotImplementedException();
    }

    private static void InserirSerie()
    {
      int entradaGenero;
      string entradaTitulo;
      int entradaAno;
      string entradaDescricao;
      Serie novaSerie;
      Console.WriteLine("Inserir Nova Série:");

      foreach (int i in Enum.GetValues(typeof(Genero)))
      {
        Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
      }
      Console.Write("Digite o Genêro Entre as Opções Acima: ");
      entradaGenero = int.Parse(Console.ReadLine());

      Console.Write("Digite o Título da Série: ");
      entradaTitulo = Console.ReadLine();

      Console.Write("Digite o Ano da Série: ");
      entradaAno = int.Parse(Console.ReadLine());

      Console.Write("Digite a Descrição da Série: ");
      entradaDescricao = Console.ReadLine();
      novaSerie = new Serie(id: repositorio.ProximaId(),
                            genero: (Genero)entradaGenero,
                            titulo: entradaTitulo,
                            ano: entradaAno,
                            descricao: entradaDescricao);
      repositorio.Insere(novaSerie);
    }

    private static void ListaSeries()
    {
      Console.WriteLine("Lista de Séries:");
      List<Serie> lista = repositorio.Lista();

      if (lista.Count == 0)
      {
        Console.WriteLine("Nenhuma Série Cadastrada");
        return;
      }
      foreach (Serie serie in lista)
      {
        Console.WriteLine("#ID {0} - {1}", serie.retornaId(),
        serie.retornaTitulo());
      }
    }
  }
}
