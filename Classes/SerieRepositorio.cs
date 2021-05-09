using System.Collections.Generic;
using APP_Series.Interfaces;

namespace APP_Series.Classes
{
  public class SerieRepositorio : IRepositorio<Serie>
  {
    private List<Serie> listaSerie = new List<Serie>();
    public void Atualizar(int id, Serie entidade)
    {
      listaSerie[id] = entidade;
    }

    public void Excluir(int id)
    {
      listaSerie[id].Excluir();
      //listaSerie.RemoveAt(id); // Remove reclassificando a lista
    }

    public void Insere(Serie entidade)
    {
      listaSerie.Add(entidade);
    }

    public List<Serie> Lista()
    {
      return listaSerie;
    }

    public int ProximaId()
    {
      return listaSerie.Count;
    }

    public Serie RetornaPorId(int id)
    {
      return listaSerie[id];
    }
  }
}