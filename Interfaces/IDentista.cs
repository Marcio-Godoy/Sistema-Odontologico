using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Tables;

namespace Interfaces
{
    [ServiceContract]
  public interface IDentista
    {
        [OperationContract]
        void Cadastrar(Dentista obj);

        [OperationContract]
        Dentista Buscar(int ID);

        [OperationContract]
        List<Dentista> Listar();

        [OperationContract]
        void Deletar(int ID);

        [OperationContract]
        void Editar(Dentista objNovo);
    }
}
