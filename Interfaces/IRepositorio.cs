using System.Collections.Generic;

namespace APP_Series.Interfaces
{
  public interface IRepositorio<T>
  {
    List<T> Lista();
    T RetornaPorId(int id);
    void Insere(T entidade);
    void Excluir(int id);
    void Atualizar(int id, T entidade);
    int ProximaId();
  }
}