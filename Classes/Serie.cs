using System;
using APP_Series.Enumerados;

namespace APP_Series.Classes
{
  public class Serie : EntidadeBase
  {
    private Genero Genero { get; set; }
    private string Titulo { get; set; }
    private string Descricao { get; set; }
    private int Ano { get; set; }

    private bool Excluido { get; set; }

    public Serie(int id, Genero genero, string titulo, string descricao, int ano)
    {
      this.id = id;
      this.Genero = genero;
      this.Titulo = titulo;
      this.Descricao = descricao;
      this.Ano = ano;
      Excluido = false;
    }
    public override string ToString()
    {
      string retorno;

      retorno = "";
      retorno += "Gênero: " + this.Genero + Environment.NewLine; // Interpreta se é \n ou outra coisa do SO
      retorno += "Título: " + this.Titulo + Environment.NewLine;
      retorno += "Descrição: " + this.Descricao + Environment.NewLine;
      retorno += "Ano de início: " + this.Ano + Environment.NewLine;

      return retorno;

    }
    public string retornaTitulo()
    {
      return this.Titulo;
    }
    public int retornaId()
    {
      return this.id;
    }
    public void Excluir()
    {
      this.Excluido = true;
    }
  }

}